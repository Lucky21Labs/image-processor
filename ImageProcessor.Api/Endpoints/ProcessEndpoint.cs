using ImageProcessor.Api.Constants;
using ImageProcessor.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace ImageProcessor.Api.Endpoints;

public static class ProcessEndpoint
{
    public static void MapProcessingEndpoints(this WebApplication app)
    {
        var group = app
            .MapGroup(EndpointConstants.ProcessEndpointGroup)
            .WithTags("Processing");

        group.MapPost(EndpointConstants.ProcessImageEndpoint, ProcessImageHandler)
            .WithName("ProcessImage")
            .WithDescription("Processes an image with the specified operations.")
            .Produces<ImageResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status500InternalServerError);

    }

    private static async Task<IResult> ProcessImageHandler(
        [FromBody] ImageRequest imageRequest)
    {
        // Implementation goes here
        return Results.Ok(new ImageResponse());
    }
}
