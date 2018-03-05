namespace AssassinCore.Common
{
    public class CommandLogging
    {
        /// <summary>
        /// 开始执行命令 
        /// </summary>
        public const string Aa = "Start executing the command";

        /// <summary>
        /// 打开数据库连接 
        /// </summary>
        public const string Bb = "Open the database connection";

        /// <summary>
        /// 命令执行结束 
        /// </summary>
        public const string Cc = "Command execution is over";

        /// <summary>
        /// 关闭数据库连接 
        /// </summary>
        public const string Dd = "Close the database connection";

        /// <summary>
        /// 完成 
        /// </summary>
        public const string Ee = "Command Completed";

        /// <summary>
        /// 开始数据库事务 
        /// </summary>
        public const string Ff = "Begins a database transaction";

        /// <summary>
        /// 提交当前数据库事务 
        /// </summary>
        public const string Gg = "Commit the current database transaction";

        /// <summary>
        /// 回滚当前数据库事务 
        /// </summary>
        public const string Hh = "Roll back the current database transaction";

        /// <summary>
        /// 提交当前数据库事务失败
        /// </summary>
        public const string Ii = "Failed to submit current database transaction";

        /// <summary>
        /// 回滚当前数据库事务失败
        /// </summary>
        public const string Kk = "Roll back the current database transaction failed";

        /// <summary>
        /// 命令执行过程中发生错误
        /// </summary>
        public const string Jj = "An error occurred during command execution";
    }
}