using System;
using System.Linq;
using System.Data.SQLite;
using System.Data;

namespace UTILITIES_HAN
{
    class DBOperation
    {
        public static string connectionString = "";

        public static Object SQLiteRequest_Read(string cmdString, params object[] argsList)
        {
            if (argsList.Length % 2 != 0)
                MsgResult.DebugMsgBox("The length of argsList is invalid, please check it!");
            if (argsList.Length / 2 != cmdString.Count(c => c.Equals('@')))
                MsgResult.DebugMsgBox("The length of argsList is invalid, please check it!");

            DataTable result = null;
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(cmdString, connection))
                    {
                        if (argsList != null && argsList.Length > 0)
                            for (int i = 0; i < argsList.Length; i += 2)
                                command.Parameters.AddWithValue(argsList[i].ToString(), argsList[i + 1]);

                        command.CommandTimeout = 10;
                        connection.Open();
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        result = new DataTable();
                        adapter.Fill(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MsgResult.DebugMsgBox("SQLiteRequest_Read: Request failed. cmdString: " + cmdString);
            }
            return result;
        }

        public static Exception SQLiteRequest_Write(string cmdString, params object[] argsList)
        {
            if (argsList.Length % 2 != 0)
                MsgResult.DebugMsgBox("The length of argsList is invalid, please check it!");
            if (argsList.Length / 2 != cmdString.Count(c => c.Equals('@')))
                MsgResult.DebugMsgBox("The length of argsList is invalid, please check it!");

            Exception result = null;
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(cmdString, connection))
                    {
                        if (argsList != null && argsList.Length > 0)
                            for (int i = 0; i < argsList.Length; i += 2)
                                command.Parameters.AddWithValue(argsList[i].ToString(), argsList[i + 1]);

                        command.CommandTimeout = 10;
                        connection.Open(); 
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                result = ex;
                MsgResult.DebugMsgBox("SQLiteRequest_Write: Request failed. cmdString: " + cmdString);
            }
            return result;
        }
    }
}
