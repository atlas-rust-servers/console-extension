using JetBrains.Annotations;
using Oxide.Core;
using UnityEngine;

namespace Oxide.Ext.ConsoleExt;

[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public static class OxideConsole
{
    public const string NORMAL = "{0}";

    public const string RED = "\u001B[31m{0}\u001B[0m";
    public const string GREEN = "\u001B[32m{0}\u001B[0m";
    public const string YELLOW = "\u001B[33m{0}\u001B[0m";
    public const string BLUE = "\u001B[34m{0}\u001B[0m";
    public const string MAGENTA = "\u001B[35m{0}\u001B[0m";
    public const string CYAN = "\u001B[36m{0}\u001B[0m";
    public const string WHITE = "\u001B[37m{0}\u001B[0m";
    public const string GRAY = "\u001B[90m{0}\u001B[0m";

    public const string LIGHT_RED = "\u001B[91m{0}\u001B[0m";
    public const string LIGHT_GREEN = "\u001B[92m{0}\u001B[0m";
    public const string LIGHT_YELLOW = "\u001B[93m{0}\u001B[0m";
    public const string LIGHT_BLUE = "\u001B[94m{0}\u001B[0m";
    public const string LIGHT_MAGENTA = "\u001B[95m{0}\u001B[0m";
    public const string LIGHT_CYAN = "\u001B[96m{0}\u001B[0m";
    public const string LIGHT_WHITE = "\u001B[97m{0}\u001B[0m";

    public const string BOLD = "\u001B[1m{0}\u001B[0m";
    public const string UNDERLINE = "\u001B[4m{0}\u001B[0m";
    public const string BLINK = "\u001B[5m{0}\u001B[0m";
    public const string REVERSE = "\u001B[7m{0}\u001B[0m";
    public const string HIDDEN = "\u001B[8m{0}\u001B[0m";
    public const string CROSSED = "\u001B[9m{0}\u001B[0m";
    public const string INVISIBLE = "\u001B[8m{0}\u001B[0m";
    public const string RESET = "\u001B[0m{0}\u001B[0m";

    public const string BOLD_RED = "\u001B[1m\u001B[31m{0}\u001B[0m";
    public const string BOLD_GREEN = "\u001B[1m\u001B[32m{0}\u001B[0m";
    public const string BOLD_YELLOW = "\u001B[1m\u001B[33m{0}\u001B[0m";
    public const string BOLD_BLUE = "\u001B[1m\u001B[34m{0}\u001B[0m";
    public const string BOLD_MAGENTA = "\u001B[1m\u001B[35m{0}\u001B[0m";
    public const string BOLD_CYAN = "\u001B[1m\u001B[36m{0}\u001B[0m";
    public const string BOLD_WHITE = "\u001B[1m\u001B[37m{0}\u001B[0m";
    public const string BOLD_GRAY = "\u001B[1m\u001B[90m{0}\u001B[0m";
    public const string BOLD_LIGHT_RED = "\u001B[1m\u001B[91m{0}\u001B[0m";
    public const string BOLD_LIGHT_GREEN = "\u001B[1m\u001B[92m{0}\u001B[0m";
    public const string BOLD_LIGHT_YELLOW = "\u001B[1m\u001B[93m{0}\u001B[0m";
    public const string BOLD_LIGHT_BLUE = "\u001B[1m\u001B[94m{0}\u001B[0m";
    public const string BOLD_LIGHT_MAGENTA = "\u001B[1m\u001B[95m{0}\u001B[0m";
    public const string BOLD_LIGHT_CYAN = "\u001B[1m\u001B[96m{0}\u001B[0m";
    public const string BOLD_LIGHT_WHITE = "\u001B[1m\u001B[97m{0}\u001B[0m";

    public const string UNDERLINE_RED = "\u001B[4m\u001B[31m{0}\u001B[0m";
    public const string UNDERLINE_GREEN = "\u001B[4m\u001B[32m{0}\u001B[0m";
    public const string UNDERLINE_YELLOW = "\u001B[4m\u001B[33m{0}\u001B[0m";
    public const string UNDERLINE_BLUE = "\u001B[4m\u001B[34m{0}\u001B[0m";
    public const string UNDERLINE_MAGENTA = "\u001B[4m\u001B[35m{0}\u001B[0m";
    public const string UNDERLINE_CYAN = "\u001B[4m\u001B[36m{0}\u001B[0m";
    public const string UNDERLINE_WHITE = "\u001B[4m\u001B[37m{0}\u001B[0m";
    public const string UNDERLINE_GRAY = "\u001B[4m\u001B[90m{0}\u001B[0m";
    public const string UNDERLINE_LIGHT_RED = "\u001B[4m\u001B[91m{0}\u001B[0m";
    public const string UNDERLINE_LIGHT_GREEN = "\u001B[4m\u001B[92m{0}\u001B[0m";
    public const string UNDERLINE_LIGHT_YELLOW = "\u001B[4m\u001B[93m{0}\u001B[0m";
    public const string UNDERLINE_LIGHT_BLUE = "\u001B[4m\u001B[94m{0}\u001B[0m";
    public const string UNDERLINE_LIGHT_MAGENTA = "\u001B[4m\u001B[95m{0}\u001B[0m";
    public const string UNDERLINE_LIGHT_CYAN = "\u001B[4m\u001B[96m{0}\u001B[0m";
    public const string UNDERLINE_LIGHT_WHITE = "\u001B[4m\u001B[97m{0}\u001B[0m";

    public const string BLINK_RED = "\u001B[5m\u001B[31m{0}\u001B[0m";
    public const string BLINK_GREEN = "\u001B[5m\u001B[32m{0}\u001B[0m";
    public const string BLINK_YELLOW = "\u001B[5m\u001B[33m{0}\u001B[0m";
    public const string BLINK_BLUE = "\u001B[5m\u001B[34m{0}\u001B[0m";
    public const string BLINK_MAGENTA = "\u001B[5m\u001B[35m{0}\u001B[0m";
    public const string BLINK_CYAN = "\u001B[5m\u001B[36m{0}\u001B[0m";
    public const string BLINK_WHITE = "\u001B[5m\u001B[37m{0}\u001B[0m";
    public const string BLINK_GRAY = "\u001B[5m\u001B[90m{0}\u001B[0m";
    public const string BLINK_LIGHT_RED = "\u001B[5m\u001B[91m{0}\u001B[0m";
    public const string BLINK_LIGHT_GREEN = "\u001B[5m\u001B[92m{0}\u001B[0m";
    public const string BLINK_LIGHT_YELLOW = "\u001B[5m\u001B[93m{0}\u001B[0m";
    public const string BLINK_LIGHT_BLUE = "\u001B[5m\u001B[94m{0}\u001B[0m";
    public const string BLINK_LIGHT_MAGENTA = "\u001B[5m\u001B[95m{0}\u001B[0m";
    public const string BLINK_LIGHT_CYAN = "\u001B[5m\u001B[96m{0}\u001B[0m";
    public const string BLINK_LIGHT_WHITE = "\u001B[5m\u001B[97m{0}\u001B[0m";

    public const string INVERT_RED = "\u001B[7m\u001B[31m{0}\u001B[0m";
    public const string INVERT_GREEN = "\u001B[7m\u001B[32m{0}\u001B[0m";
    public const string INVERT_YELLOW = "\u001B[7m\u001B[33m{0}\u001B[0m";
    public const string INVERT_BLUE = "\u001B[7m\u001B[34m{0}\u001B[0m";
    public const string INVERT_MAGENTA = "\u001B[7m\u001B[35m{0}\u001B[0m";
    public const string INVERT_CYAN = "\u001B[7m\u001B[36m{0}\u001B[0m";
    public const string INVERT_WHITE = "\u001B[7m\u001B[37m{0}\u001B[0m";
    public const string INVERT_GRAY = "\u001B[7m\u001B[90m{0}\u001B[0m";
    public const string INVERT_LIGHT_RED = "\u001B[7m\u001B[91m{0}\u001B[0m";
    public const string INVERT_LIGHT_GREEN = "\u001B[7m\u001B[92m{0}\u001B[0m";
    public const string INVERT_LIGHT_YELLOW = "\u001B[7m\u001B[93m{0}\u001B[0m";
    public const string INVERT_LIGHT_BLUE = "\u001B[7m\u001B[94m{0}\u001B[0m";
    public const string INVERT_LIGHT_MAGENTA = "\u001B[7m\u001B[95m{0}\u001B[0m";
    public const string INVERT_LIGHT_CYAN = "\u001B[7m\u001B[96m{0}\u001B[0m";
    public const string INVERT_LIGHT_WHITE = "\u001B[7m\u001B[97m{0}\u001B[0m";

    public static void Log(object obj, string color = NORMAL)
    {
        Debug.LogFormat(color, obj);
    }

    [StringFormatMethod("format")]
    public static void LogFormat(string format, string color, params object[] args)
    {
        string text = format.FormatNoThrow(args);
        Log(text, color);
    }

    public static void LogAsync(object obj, string color = NORMAL)
    {
        Interface.Oxide?.NextTick(() => Log(obj, color));
    }
}