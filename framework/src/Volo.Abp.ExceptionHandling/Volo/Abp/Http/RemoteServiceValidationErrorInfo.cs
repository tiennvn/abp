using System;

namespace Volo.Abp.Http;

/// <summary>
/// Chứa thông tin của những lỗi ràng buộc dữ liệu đầu vào
/// </summary>
[Serializable]
public class RemoteServiceValidationErrorInfo
{
    /// <summary>
    /// Nội dung lỗi ràng buộc dữ liệu
    /// </summary>
    /// <example>Trường Name là bắt buộc.</example>
    public string Message { get; set; }

    /// <summary>
    /// Các trường vi phạm kiểm tra ràng buộc dữ liệu
    /// </summary>
    /// <example>["name"]</example>
    public string[] Members { get; set; }

    /// <summary>
    /// Creates a new instance of <see cref="RemoteServiceValidationErrorInfo"/>.
    /// </summary>
    public RemoteServiceValidationErrorInfo()
    {

    }

    /// <summary>
    /// Creates a new instance of <see cref="RemoteServiceValidationErrorInfo"/>.
    /// </summary>
    /// <param name="message">Validation error message</param>
    public RemoteServiceValidationErrorInfo(string message)
    {
        Message = message;
    }

    /// <summary>
    /// Creates a new instance of <see cref="RemoteServiceValidationErrorInfo"/>.
    /// </summary>
    /// <param name="message">Validation error message</param>
    /// <param name="members">Related invalid members</param>
    public RemoteServiceValidationErrorInfo(string message, string[] members)
        : this(message)
    {
        Members = members;
    }

    /// <summary>
    /// Creates a new instance of <see cref="RemoteServiceValidationErrorInfo"/>.
    /// </summary>
    /// <param name="message">Validation error message</param>
    /// <param name="member">Related invalid member</param>
    public RemoteServiceValidationErrorInfo(string message, string member)
        : this(message, new[] { member })
    {

    }
}
