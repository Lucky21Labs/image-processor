using ImageProcessor.Api.Services.Interfaces;

namespace ImageProcessor.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddAppServices(
        this IServiceCollection services)
    {
        services.AddScoped<IImageService, ImageService>();
    }
}
