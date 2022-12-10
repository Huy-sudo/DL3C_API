﻿namespace DL3C_API.Infrastructure.Utility.ErrorHandling.Object;

/// <summary>
/// Exception StackFrame Detail.
/// </summary>
public class ErrorLocation
{
    /// <summary>
    /// Gets or sets Method makes Exception.
    /// </summary>
    public string? BugMethod { get; set; }

    /// <summary>
    /// Gets or sets File makes Exception.
    /// </summary>
    public string? BugFile { get; set; }

    /// <summary>
    /// Gets or sets Line make Exception.
    /// </summary>
    public int BugLine { get; set; }
}