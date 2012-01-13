using System.IO;

namespace app.utility
{
    public class Log : ICanLog
    {
        readonly IGenerateLogMessages message_generator;

        public Log(TextWriter output, IGenerateLogMessages message_generator)
        {
            this.output = output;
            this.message_generator = message_generator;
        }

        public TextWriter output { get;private set; }

        public void Info(object message_item)
        {
            output.WriteLine(message_generator.generate(info_header, message_item));
        }

        public static string info_header = "Info -";

        public Log(TextWriter streamWriter) : this(streamWriter, new LogMessagesBuilder())
        {
        }
    }
}