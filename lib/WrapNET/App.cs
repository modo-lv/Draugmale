using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WrapNET {
 public static class App  {
  public readonly static List<String> CommandLineArgs { get { return getCommandLineArgs(); } }
  private static List<String> commandLineArgs;

  public static String Directory { get { return Path.GetDirectoryName(Application.ExecutablePath); } }

  private static List<string> getCommandLineArgs() {
   if (commandLineArgs == null) {
    commandLineArgs = new List<String>(Environment.GetCommandLineArgs().Length);
    foreach (var arg in Environment.GetCommandLineArgs())
     commandLineArgs.Add(arg);
   }
   return commandLineArgs;
  }
 }
}