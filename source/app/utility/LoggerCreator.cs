using System;
using System.IO;

namespace app.utility
{
    public class LoggerCreator : IConfigureLog
    {
        public static string default_file_path = "MyLog.log";

        public ICanLog use_console()
        {
            var output = Console.Out;
            return new Log(output);
        }

        public ICanLog use_text_file()
        {
            var output= new StreamWriter(default_file_path);
            return new Log(output);
        }
    }
}