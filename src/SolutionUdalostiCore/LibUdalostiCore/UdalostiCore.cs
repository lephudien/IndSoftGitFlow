﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibUdalostiCore
{
  public class UdalostiCore
  {
    public static string GetMyVersion()
    {
      System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
      System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

      Version version = Assembly.GetAssembly(typeof(System.Data.SqlClient.SqlAuthenticationMethod)).GetName().Version;

      return $"AdapterDB2.MSSQL Ver={fvi.FileVersion}" +
            $"{Environment.NewLine}Using EXTERNAL MSSQLClientVer {version.ToString()}";
    }

    public bool Connect(string sConnectString)
    {
      if (sConnectString.Contains("MSSQL"))
        return true;

      return false;
    }
  }
}