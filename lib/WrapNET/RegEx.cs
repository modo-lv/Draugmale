using System;
using System.Collections.Generic;
using System.Text;

namespace WrapNET {
 class RegEx {
  public struct Patterns {
   public const string Email = @"[\w.\+-]+@[\w.-]+\.[a-zA-Z]{2,}";
   public const string Md5 = @"[a-fA-F0-9]{32}";
  }
 }
}
