using System.Diagnostics.CodeAnalysis;

namespace ImageProcessor.Api.Models;

[ExcludeFromCodeCoverage]
public class ImageResponse
{
    public string? Base64Image { get; set; }
}
