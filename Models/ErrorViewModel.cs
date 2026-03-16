namespace lab1.Models;

/// <summary>
/// Represents error information to be displayed to the user.
/// </summary>
public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
