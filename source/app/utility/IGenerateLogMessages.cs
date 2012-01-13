namespace app.utility
{
    public interface IGenerateLogMessages
    {
        string generate(string message_header, object message);
    }

    class LogMessagesBuilder : IGenerateLogMessages
    {
        public string generate(string message_header, object message)
        {
            throw new System.NotImplementedException();
        }
    }
}