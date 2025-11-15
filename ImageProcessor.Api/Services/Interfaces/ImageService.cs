using ImageMagick;
using ImageProcessor.Api.Models;

namespace ImageProcessor.Api.Services.Interfaces;

public class ImageService: IImageService
{
    public Task<ImageResponse> ProcessImageRequest(
        ImageRequest request)
    {
        var imageBytes = Convert.FromBase64String(request.Base64Image);

        using var image = new MagickImage(imageBytes);

        foreach (var processingValue in request.Actions)
        {
            ApplyProcessingValue(image, processingValue);
        }

        var resultingBase64Image = request.ReturnBase64
            ? image.ToBase64()
            : string.Empty;

        var result = new ImageResponse
        {
            Base64Image = resultingBase64Image
        };

        return Task.FromResult(result);
    }

    private void ApplyProcessingValue(MagickImage image, ProcessingValue processingValue)
    {
        switch (processingValue.Action)
        {
            case Enums.ProcessingType.Brightness:
                image.Modulate(
                    brightness: new Percentage(processingValue.Value));
                break;
            case Enums.ProcessingType.Contrast:
                image.SigmoidalContrast(processingValue.Value);
                break;
            case Enums.ProcessingType.Saturation:
                image.Modulate(
                    brightness: new Percentage(100),
                    saturation: new Percentage(processingValue.Value));
                break;
            case Enums.ProcessingType.Sharpening:
                image.Sharpen(0, processingValue.Value);
                break;
            default:
                throw new NotImplementedException($"Processing type {processingValue.Action} is not implemented.");
        }
    }
}
