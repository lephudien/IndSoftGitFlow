﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPrehledUdalosti
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
      System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

      string sBranch = "master";
      System.Windows.Forms.MessageBox.Show($"AppPrehledUdalosti Ver={fvi.FileVersion} BrachName: {sBranch}" +
                                          $"{Environment.NewLine}Using {LibUdalostiCore.UdalostiCore.GetMyVersion()}");


      // Mala zmena 1
      int i = 5;
      // Mala zmena 1
      int i2 = 10;
    }
  }
}
