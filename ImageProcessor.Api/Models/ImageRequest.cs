using System.Diagnostics.CodeAnalysis;

namespace ImageProcessor.Api.Models;

[ExcludeFromCodeCoverage]
public class ImageRequest
{
    public string? Base64Image { get; set; }

    public string? ImageFormat { get; set; }

    public bool ReturnBase64 { get; set; }

    public List<ProcessingValue>? Actions { get; set; }
}
