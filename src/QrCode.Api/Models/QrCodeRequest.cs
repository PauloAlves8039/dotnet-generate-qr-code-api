using QrCode.Api.Validation;

namespace QrCode.Api.Models;

public class QrCodeRequest
{
    public string Content { get; private set; }
    public int PixelsPerModule { get; private set; }
    public string ForegroundColorHex { get; private set; }
    public string BackgroundColorHex { get; private set; }
    public string ErrorCorrectionLevel { get; private set; }

    public QrCodeRequest(string content)
    {
        ValidateMode(content);
        Content = content;
        PixelsPerModule = 10;
        ForegroundColorHex = "#000000";
        BackgroundColorHex = "#FFFFFF";
        ErrorCorrectionLevel = "Q";
    }

    private static void ValidateMode(string content)
    {
        ModelExceptionValidation.When(string.IsNullOrWhiteSpace(content), "The content of the QR Code is mandatory.");
        ModelExceptionValidation.When(content.Length > 100, "The content can be no longer than 100 characters.");
    }
}
