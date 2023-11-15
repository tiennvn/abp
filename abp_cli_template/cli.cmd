abp new Tien.New -t app -u mvc --tiered -o ./Tien.New -dbms PostgreSQL --no-random-port

abp new WiOn.Max -t app -u mvc --tiered -dbms PostgreSQL --no-random-port --local-framework-ref --abp-path ..\..\..\..\

abp new WiOn.Tizet -t app -u mvc --tiered -dbms PostgreSQL -o ./

abp new Acme.BookStore -t app -u mvc --tiered -dbms PostgreSQL --no-random-port --local-framework-ref --abp-path ..\..\..\..\

abp new New.Max -t app -u mvc --tiered -dbms PostgreSQL --no-random-port --local-framework-ref --template-source "D:\002.Project\100.ABPProject\101.ABP_Framework_github\abp\templates\app"

abp new Tizet.Pos -t app --theme basic -dbms PostgreSQL --no-random-port --local-framework-ref --template-source "D:\002.Project\100.ABPProject\101.ABP_Framework_github\abp\templates\app" 

abp new Acme.BookStore -t app -u mvc --tiered -dbms PostgreSQL --no-random-port --local-framework-ref --template-source "D:\002.Project\100.ABPProject\101.ABP_Framework_github\abp\templates\app" 
