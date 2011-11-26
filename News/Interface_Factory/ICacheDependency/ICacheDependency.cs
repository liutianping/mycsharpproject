using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Caching;

namespace ICacheDependency
{
    public interface ICacheDependency
    {
        AggregateCacheDependency GetDependency();
    }
}
