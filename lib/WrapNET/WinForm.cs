using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WrapNET {
 public class WinForm : Form {
  public readonly Int32 BorderThickness, TitleBarHeight;

  public WinForm() {
   BorderThickness = (Width - ClientSize.Width) / 2;
   TitleBarHeight = Height - ClientSize.Height - (2 * BorderThickness);
  }
 }
}
