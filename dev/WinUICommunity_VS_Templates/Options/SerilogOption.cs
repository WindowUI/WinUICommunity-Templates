﻿using System;
using System.Collections.Generic;
using WinUICommunity_VS_Templates.Shell;

namespace WinUICommunity_VS_Templates.Options
{
    public class SerilogOption
    {
        public bool UseFileLogger { get; set; } = false;
        public bool UseDebugLogger { get; set; } = false;
        public void ConfigSerilog(Dictionary<string, string> replacementsDictionary, Dictionary<string, PackageRefrence> libs)
        {
            if (libs.ContainsKey("Serilog.Sinks.File"))
            {
                UseFileLogger = true;
                replacementsDictionary.Add("$SerilogFilePath$", Environment.NewLine + """public static readonly string LogFilePath = Path.Combine(LogDirectoryPath, "Log.txt");""");
                replacementsDictionary.Add("$SerilogFile$", Environment.NewLine + "            .WriteTo.File(Constants.LogFilePath, rollingInterval: RollingInterval.Day)");
            }
            else
            {
                replacementsDictionary.Add("$SerilogFile$", "");
                replacementsDictionary.Add("$SerilogFilePath$", "");
            }

            if (libs.ContainsKey("Serilog.Sinks.Debug"))
            {
                UseDebugLogger = true;
                replacementsDictionary.Add("$SerilogDebug$", Environment.NewLine + "            .WriteTo.Debug()");
            }
            else
            {
                replacementsDictionary.Add("$SerilogDebug$", "");
            }

            if (libs.ContainsKey("Serilog.Sinks.Debug") || libs.ContainsKey("Serilog.Sinks.File"))
            {
                replacementsDictionary.Add("$SerilogDirectoryPath$", Environment.NewLine + """public static readonly string LogDirectoryPath = Path.Combine(RootDirectoryPath, "Log");""");
                replacementsDictionary.Add("$ConfigLogger$", Environment.NewLine + Environment.NewLine + "ConfigureLogger();");
                replacementsDictionary.Add("$UnhandeledException$", Environment.NewLine + Environment.NewLine + """UnhandledException += (s, e) => Logger?.Error(e.Exception, "UnhandledException");""");
            }
            else
            {
                replacementsDictionary.Add("$SerilogDirectoryPath$", "");
                replacementsDictionary.Add("$ConfigLogger$", "");
                replacementsDictionary.Add("$UnhandeledException$", "");
            }
        }
    }
}
