using System;
using System.Collections;

namespace Volo.Abp.Http;

/// <summary>
/// Object chứa thông tin của lỗi
/// </summary>
[Serializable]
public class RemoteServiceErrorInfo
{
    /// <summary>
    /// Mã lối
    /// </summary>
    /// <example>Authentication.Account:0010</example>
    public string Code { get; set; }

    /// <summary>
    /// Nội dung lỗi
    /// </summary>
    /// <example>Tài khoản của bạn đã bị khóa</example>
    public string Message { get; set; }

    /// <summary>
    /// Chi tiết lỗi
    /// </summary>
    /// <example>Các lỗi sau đây đã được phát hiện trong quá trình xác nhận</example>
    public string Details { get; set; }

    /// <summary>
    /// Dữ liệu liên quan đến lỗi. Tùy vào từng trường hợp lỗi, mà sẽ có key khác nhau
    /// </summary>
    /// <example>
    /// {
    ///   "currentTime": "2023-08-03T07:48:05.0051498Z",
    ///   "nextResendOtpTime": "2023-08-03T07:48:33.6346059Z"
    /// }
    /// </example>
    public IDictionary Data { get; set; }

    /// <summary>
    /// Danh sách thông tin của lỗi kiểm tra dữ liệu đầu vào
    /// </summary>
    public RemoteServiceValidationErrorInfo[] ValidationErrors { get; set; }

    /// <summary>
    /// Creates a new instance of <see cref="RemoteServiceErrorInfo"/>.
    /// </summary>
    public RemoteServiceErrorInfo()
    {

    }

    /// <summary>
    /// Creates a new instance of <see cref="RemoteServiceErrorInfo"/>.
    /// </summary>
    /// <param name="code">Error code</param>
    /// <param name="details">Error details</param>
    /// <param name="message">Error message</param>
    /// <param name="data">Error data</param>
    public RemoteServiceErrorInfo(string message, string details = null, string code = null, IDictionary data = null)
    {
        Message = message;
        Details = details;
        Code = code;
        Data = data;
    }
}
