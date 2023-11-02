import { Injectable, inject } from '@angular/core';
import {
  ActivatedRouteSnapshot,
  CanActivateFn,
  Router,
  RouterStateSnapshot,
} from '@angular/router';
import { HttpErrorResponse } from '@angular/common/http';

import { Observable, of } from 'rxjs';
import { tap } from 'rxjs/operators';

import { OAuthService } from 'angular-oauth2-oidc';

import { IAbpGuard } from '../abstracts';
import { findRoute, getRoutePath } from '../utils/route-utils';
import { RoutesService, PermissionService, HttpErrorReporterService } from '../services';

/**
 * @deprecated Use `permissionGuard` instead.
 */
@Injectable({
  providedIn: 'root',
})
export class PermissionGuard implements IAbpGuard {
  protected readonly router = inject(Router);
  protected readonly routesService = inject(RoutesService);
  protected readonly oAuthService = inject(OAuthService);
  protected readonly permissionService = inject(PermissionService);
  protected readonly httpErrorReporter = inject(HttpErrorReporterService);

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<boolean> {
    let { requiredPolicy } = route.data || {};

    if (!requiredPolicy) {
      const routeFound = findRoute(this.routesService, getRoutePath(this.router, state.url));
      requiredPolicy = routeFound?.requiredPolicy;
    }

    if (!requiredPolicy) return of(true);

    return this.permissionService.getGrantedPolicy$(requiredPolicy).pipe(
      tap(access => {
        if (!access && this.oAuthService.hasValidAccessToken()) {
          this.httpErrorReporter.reportError({ status: 403 } as HttpErrorResponse);
        }
      }),
    );
  }
}

export const permissionGuard: CanActivateFn = (
  route: ActivatedRouteSnapshot,
  state: RouterStateSnapshot,
) => {
  const router = inject(Router);
  const routesService = inject(RoutesService);
  const oAuthService = inject(OAuthService);
  const permissionService = inject(PermissionService);
  const httpErrorReporter = inject(HttpErrorReporterService);

  let { requiredPolicy } = route.data || {};

  if (!requiredPolicy) {
    const routeFound = findRoute(routesService, getRoutePath(router, state.url));
    requiredPolicy = routeFound?.requiredPolicy;
  }

  if (!requiredPolicy) return of(true);

  return permissionService.getGrantedPolicy$(requiredPolicy).pipe(
    tap(access => {
      if (!access && oAuthService.hasValidAccessToken()) {
        httpErrorReporter.reportError({ status: 403 } as HttpErrorResponse);
      }
    }),
  );
};
