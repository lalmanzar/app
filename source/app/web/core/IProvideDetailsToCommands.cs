using System;
using System.Collections.Generic;

namespace app.web.core
{
  public interface IProvideDetailsToCommands
  {
      IDictionary<string,string> parameters { get; set; }
  }
}