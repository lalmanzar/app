namespace app.utility
{
    public interface IConfigureLog
    {
        ICanLog use_console();
        ICanLog use_text_file();
    }
}