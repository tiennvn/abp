namespace Volo.Abp.Http;

/// <summary>
/// Thông tin phản hồi khi xảy ra lỗi
/// </summary>
public class RemoteServiceErrorResponse
{
    /// <summary>
    /// Thông tin của lỗi
    /// </summary>
    public RemoteServiceErrorInfo Error { get; set; }

    public RemoteServiceErrorResponse(RemoteServiceErrorInfo error)
    {
        Error = error;
    }
}
