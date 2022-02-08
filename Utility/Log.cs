using System;

/// <summary>
/// The tool for console logging.
/// </summary>
public static class Log
{
    /// <summary>
    /// Prints text into the console.
    /// </summary>
    /// <param name="msg">The message.</param>
    /// <param name="inline">Is a new line after this.</param>
    /// <param name="color">The color of the text.</param>
    public static void Print(object msg, bool inline = false, ConsoleColor? color = null)
    {
        Console.ForegroundColor = color != null ? (ConsoleColor)color : ConsoleColor.White;
        Console.Write($"{msg + (inline ? "" : "\n")}");
        Console.ForegroundColor = ConsoleColor.White;
    }

    /// <summary>
    /// Prints text into the console with the [INFO] prefix.
    /// </summary>
    /// <param name="msg">The info message.</param>
    /// <param name="inline">Is a new line after this.</param>
    /// <param name="color">The color of the text.</param>
    public static void Info(object msg, bool inline = false, ConsoleColor? color = null)
    {
        Console.ForegroundColor = color != null ? (ConsoleColor)color : ConsoleColor.Cyan;
        Console.Write($"[INFO] - {msg + (inline ? "" : "\n")}");
        Console.ForegroundColor = ConsoleColor.White;
    }

    /// <summary>
    /// Prints a warning into the console.
    /// </summary>
    /// <param name="msg">The warning message.</param>
    /// <param name="inline">Is a new line after this.</param>
    /// <param name="color">The color of the text.</param>
    public static void Warn(object msg, bool inline = false, ConsoleColor? color = null)
    {
        Console.ForegroundColor = color != null ? (ConsoleColor)color : ConsoleColor.Yellow;
        Console.Write($"[WARNING] - {msg + (inline ? "" : "\n")}");
        Console.ForegroundColor = ConsoleColor.White;
    }

    /// <summary>
    /// Prints an error into the console.
    /// </summary>
    /// <param name="msg">The error message.</param>
    /// <param name="inline">Is a new line after this.</param>
    /// <param name="color">The color of the text.</param>
    public static void Error(object msg, bool inline = false, ConsoleColor? color = null)
    {
        Console.ForegroundColor = color != null ? (ConsoleColor)color : ConsoleColor.Red;
        Console.Write($"[ERROR] - {msg + (inline ? "" : "\n")}");
        Console.ForegroundColor = ConsoleColor.White;
    }
}