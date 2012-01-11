namespace app.web.core.extensions
{
    public static class RequestCriteriaExtensions
    {
        public static RequestCriteria made_for<RequestType>(this RequestCriteria criteria)
        {
            return x => x.request_name.Equals(typeof (RequestType).Name);
        }
    }
}