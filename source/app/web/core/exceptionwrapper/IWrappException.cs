using System;
using app.utility.containers;

namespace app.web.core.exceptionwrapper
{
    public interface IWrappException<ReturnType>
    {
        ReturnType create_exception_using(Func<Exception> type);
        Func<ReturnType> action { get; set; }
    }

    public class WrappException<ReturnType> : IWrappException<ReturnType>
    {
        public ReturnType create_exception_using(Func<Exception> exceptionFactory)
        {
            try
            {
                return action();
            } 
            catch (Exception e)
            {
                throw new NotImplementedException();
//                throw exceptionFactory(e);
            }
        }

        public Func<ReturnType> action { get; set; }
    }
}