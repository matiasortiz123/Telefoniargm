using System;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using modulo_documentacion.Models;


namespace modulo_documentacion
{
    public class common
    {
        public static byte[] Reporting(string reporte, string parametros, string formato)
        {
            System.Net.NetworkCredential credencial = new System.Net.NetworkCredential("administrator", "iUNi58LBvw");
            WebClient client = new WebClient();
            client.Credentials = credencial;
            string reportURL = "http://vm-1824914/ReportServer_MSSQLSERVER2012/Pages/ReportViewer.aspx?%2fmodulo_documentacion%2f" + reporte + "&rs:Command=Render" + parametros + "&rs:Format=" + formato;
            return client.DownloadData(reportURL);
        }
        public static byte[] ConvertFromBase64String(string input)
        {
            if (String.IsNullOrWhiteSpace(input)) return null;
            try
            {
                string working = input.Replace('-', '+').Replace('_', '/'); ;
                while (working.Length % 4 != 0)
                {
                    working += '=';
                }
                return Convert.FromBase64String(working);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
