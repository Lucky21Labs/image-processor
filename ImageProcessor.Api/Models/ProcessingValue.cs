using System.Diagnostics.CodeAnalysis;
using ImageProcessor.Api.Enums;

namespace ImageProcessor.Api.Models;

[ExcludeFromCodeCoverage]
public class ProcessingValue
{
    public ProcessingType Action { get; set; }

    public float Value { get; set; }
}
