using System.Diagnostics.CodeAnalysis;

namespace ImageProcessor.Api.Models;

[ExcludeFromCodeCoverage]
public class ImageRequest
{
    public required string Base64Image { get; set; }

    public required string ImageFormat { get; set; }

    public bool ReturnBase64 { get; set; }

    public List<ProcessingValue> Actions { get; set; } = [];
}
