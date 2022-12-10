﻿namespace DL3C_API.Infrastructure.Utility.ErrorHandling;

using DL3C_API.Infrastructure.Utility.ErrorHandling.Object;
using Microsoft.AspNetCore.Mvc;

/// <summary>
/// Error handler class.
/// </summary>
public interface IErrorHandler
{
    /// <summary>
    /// Custom error (handled exception).
    /// </summary>
    /// <param name="exception">exception.</param>
    /// <returns>default response error object of Microsoft.</returns>
    ValidationProblemDetails? HandlerError(Exception? exception);

    /// <summary>
    /// Custom unexpected error (un-handled exception).
    /// </summary>
    /// <param name="exception">exception.</param>
    /// <returns>default response error object of Microsoft.</returns>
    ValidationProblemDetails? UnhandledError(Exception? exception);

    /// <summary>
    /// Get error location of exception.
    /// </summary>
    /// <param name="exception">exception.</param>
    /// <returns>location of exception.</returns>
    ErrorLocation? GetLocation(Exception? exception);
}