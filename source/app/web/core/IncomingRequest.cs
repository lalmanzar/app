namespace app.web.core
{
    public static class IncomingRequest
    {
        public static RequestCriteria was
        {
            get { return (x => true); }
        }
    }
}