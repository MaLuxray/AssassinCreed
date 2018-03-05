
using System;

namespace AssassinCore.Common
{
    public static class StringTextWriterExtension
    {
        /// <summary>
        /// An error occurred during command execution
        /// </summary>
        public static StringTextWriter WriteError(this StringTextWriter writer, string errorMessage)
        {
            return writer.WriteLine($"{DateTime.Now:yyyy/MM/dd HH:mm:ss:fff} {CommandLogging.Jj}: {errorMessage}");
        }

        /// <summary>
        /// Excute T-SQL statement: 
        /// </summary>
        internal static StringTextWriter WriteSql(this StringTextWriter writer, string sql)
        {
            return writer.WriteLine($"{DateTime.Now:yyyy/MM/dd HH:mm:ss:fff} Execute T-SQL statement: {sql}");
        }

        /// <summary>
        /// Start executing the command
        /// </summary>
        internal static StringTextWriter WriteAa(this StringTextWriter writer)
        {
            return writer.WriteLine($"{DateTime.Now:yyyy/MM/dd HH:mm:ss:fff} {CommandLogging.Aa}");
        }

        /// <summary>
        /// Open the database connection
        /// </summary>
        internal static StringTextWriter WriteBb(this StringTextWriter writer, string name)
        {
            return writer.WriteLine($"{DateTime.Now:yyyy/MM/dd HH:mm:ss:fff} {CommandLogging.Bb} ({name ?? "System.Data.IDbConnection"})");
        }

        /// <summary>
        /// Command execution is over
        /// </summary>
        internal static StringTextWriter WriteCc(this StringTextWriter writer)
        {
            return writer.WriteLine($"{DateTime.Now:yyyy/MM/dd HH:mm:ss:fff} {CommandLogging.Cc}");
        }

        /// <summary>
        /// Close the database connection
        /// </summary>
        internal static StringTextWriter WriteDd(this StringTextWriter writer, string name)
        {
            return writer.WriteLine($"{DateTime.Now:yyyy/MM/dd HH:mm:ss:fff} {CommandLogging.Dd} ({name ?? "System.Data.IDbConnection"})");
        }

        /// <summary>
        /// Command Completed
        /// </summary>
        internal static StringTextWriter WriteEe(this StringTextWriter writer)
        {
            return writer.Write($"{DateTime.Now:yyyy/MM/dd HH:mm:ss:fff} {CommandLogging.Ee}");
        }

        /// <summary>
        /// Begins a database transaction
        /// </summary>
        internal static StringTextWriter WriteFf(this StringTextWriter writer)
        {
            return writer.WriteLine($"{DateTime.Now:yyyy/MM/dd HH:mm:ss:fff} {CommandLogging.Ff}");
        }

        /// <summary>
        /// Commit the current database transaction
        /// </summary>
        internal static StringTextWriter WriteGg(this StringTextWriter writer)
        {
            return writer.WriteLine($"{DateTime.Now:yyyy/MM/dd HH:mm:ss:fff} {CommandLogging.Gg}");
        }

        /// <summary>
        /// Roll back the current database transaction
        /// </summary>
        internal static StringTextWriter WriteHh(this StringTextWriter writer)
        {
            return writer.WriteLine($"{DateTime.Now:yyyy/MM/dd HH:mm:ss:fff} {CommandLogging.Hh}");
        }
    }
}