using System.ComponentModel.DataAnnotations;

namespace QrCode.Api.DTOs;

public class QrCodeRequestDto
{
    [Required(ErrorMessage = "The content is mandatory.")]
    [StringLength(1000, ErrorMessage = "The content can be no longer than 1000 characters.")]
    public string Content { get; set; } = string.Empty;
}