using System;
using System.Collections;

namespace Volo.Abp.Http;

/// <summary>
/// Used to store information about an error.
/// Thông tin của lỗi.
/// </summary>
[Serializable]
public class RemoteServiceErrorInfo
{
    /// <summary>
    /// Error code. 
    /// Mã lối.
    /// </summary>
    /// <example>tesst:code:0001</example>
    public string Code { get; set; }

    /// <summary>
    /// Error message. 
    /// Nội dung lỗi.
    /// </summary>
    /// <example>Lỗi kiểm tra dữ liệu</example>
    public string Message { get; set; }

    /// <summary>
    /// Error details.
    /// Chi tiết lỗi.
    /// </summary>
    public string Details { get; set; }

    /// <summary>
    /// Error data.
    /// Dữ liệu liên quan đến lỗi.
    /// </summary>
    public IDictionary Data { get; set; }

    /// <summary>
    /// Validation errors if exists.
    /// Danh sách thông tin của lỗi kiểm tra dữ liệu đầu vào.
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
