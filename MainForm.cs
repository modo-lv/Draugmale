using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using WrapNET;

namespace Draugmale {
 public partial class MainForm : WinForm {
  public MainForm() {
   Font = new Font(Fonts.GetFamily("DejaVu Sans", true), Font.Size);
   InitializeComponent();
  }

  private void MainForm_Load(object sender, EventArgs e) {
  }

 }
}
