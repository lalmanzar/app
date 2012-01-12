using System;
using app.utility.containers;

namespace app.web.core.exceptionwrapper
{
    public class CanThrowException
    {
        public static IWrappException<ReturnType> when<ReturnType>(Func<ReturnType> func)
        {
            var wrapper = Container.fetch.an<IWrappException<ReturnType>>();
            wrapper.action = func;
            return wrapper;
        }
    }
}