using ImageProcessor.Api.Models;

namespace ImageProcessor.Api.Services.Interfaces;

public interface IImageService
{
    Task<ImageResponse> ProcessImageRequest(
        ImageRequest request);
}
