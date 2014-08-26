using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public static class DataDump
    {
        public static String[] ExportTables(string[,] export)
        {
            String[] display = new string[15];

            for (int i = 0; i < 15; ++i)
            {
                for (int j = 0; j < 2; ++j)
                {
                    if (j == 0 && export[i, j] == "True")
                    {
                        try
                        {
                            ExecuteDump(export[i, j + 1]);
                            display[i] = "Successfull Export: " + export[i, 1];
                        }
                        catch
                        {
                            display[i] = "Failed Export: " + export[i, 1];
                        }
                    }
                }
            }

            return display;
        }

        private static void ExecuteDump(string type)
        {
            string arg1 = "";
            string arg2 = "";
            string arg3 = "";
            string arg4 = "";
            string arg5 = "";

            string userDIR = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            arg1 = @"/c bcp CMAS.dbo." + type + @" out " + userDIR + "\\" + type + @"DataOnly.csv /Uawsuserwill /P*050987Wwhite /Ssqlinstance-1.cnsq0dkjy1df.us-west-2.rds.amazonaws.com,1433 /c /t,";
            arg2 = @"BCP ""DECLARE @colnames VARCHAR(max);SELECT @colnames = COALESCE(@colnames + ',', '') + column_name from CMAS.INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='" + type + @"'; select @colnames;"" queryout " + userDIR + "\\" + type + "HeadersOnly.csv /c /t, /Uawsuserwill /P*050987Wwhite /Ssqlinstance-1.cnsq0dkjy1df.us-west-2.rds.amazonaws.com,1433";
            arg3 = @"copy /b " + userDIR + "\\" + type + "HeadersOnly.csv+" + userDIR + "\\" + type + "DataOnly.csv " + userDIR + "\\" + type + "TableData.csv";
            arg4 = "del " + userDIR + "\\" + type + "HeadersOnly.csv";
            arg5 = "del " + userDIR + "\\" + type + "DataOnly.csv";

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = arg1 + " & " + arg2 + " & " + arg3 + " & " + arg4 + " & " + arg5;
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
