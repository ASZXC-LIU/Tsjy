using System.Reflection;
using Furion;

namespace Tsjy.Web.Entry
{
    public class SingleFilePublish : ISingleFilePublish
    {
        public Assembly[] IncludeAssemblies()
        {
            return Array.Empty<Assembly>();
        }

        public string[] IncludeAssemblyNames()
        {
            return new[]
            {
                "Tsjy.Application",
                "Tsjy.Core",
                "Tsjy.EntityFramework.Core",
                "Tsjy.Web.Core"
            };
        }
    }
}