using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace WrapNET {
 public class Fonts {
  public static PrivateFontCollection Set = new PrivateFontCollection();
  public struct Config {
   public static String Directory = "fonts";
  }

  public static void LoadFonts(String path) {
   foreach (String fileName in Directory.GetFiles(path, "*.ttf")) {
    Set.AddFontFile(fileName);
   }
  }

  public static FontFamily GetFamily(String name) {
   return GetFamily(name, false);
  }

  public static FontFamily GetFamily(String name, Boolean throwException) {
   if (Set.Families.Length == 0)
    LoadFonts(Config.Directory);

   try {
    return new FontFamily(name, Set);
   }
   catch (ArgumentException) {
    if (throwException)
     throw;
    return Control.DefaultFont.FontFamily;
   }
  }
 }
}
