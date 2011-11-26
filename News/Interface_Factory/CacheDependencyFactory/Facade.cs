using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Caching;

namespace CacheDependencyFactory
{
    public class Facade
    {
        public static AggregateCacheDependency GetDependency()
        {
           return Access.CreateDependendcy().GetDependency();
        }
    }
}
