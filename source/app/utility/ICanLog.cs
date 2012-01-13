using System.IO;

namespace app.utility
{
    public interface ICanLog
    {
        TextWriter output { get; }
        void Info(object message_item);
    }
}