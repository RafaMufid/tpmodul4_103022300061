// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Metadata.Ecma335;

public class KodePos
{
    public static string GetKodePos(string daerah)
    {
        string[,] dataKodePos =
        {
            {"Batununggal", "40266" },
            {"Kujangsari", "40287" },
            {"Mengger", "40267" },
            {"Wates", "40256" },
            {"Cijaura", "40287" },
            {"Jatisari", "40286" },
            {"Margasari", "40286" },
            {"Sekejati", "40286" },
            {"Kebonwaru", "40272" },
            {"Maleer", "40274" },
            {"Samoja", "40273" }
        };

        for (int i = 0; i < dataKodePos.GetLength(0); i++)
        {
            if (dataKodePos[i, 0].Equals(daerah, StringComparison.OrdinalIgnoreCase))
            { 
                return dataKodePos[i, 1];
            }
        }
        return "kode pos tidak ditemukan";
    }
}