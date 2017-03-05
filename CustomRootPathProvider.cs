using System.IO;
using Nancy;

namespace NancyApplication
{
    internal class CustomRootPathProvider : IRootPathProvider
    {
        public string GetRootPath()
        {
            return Directory.GetCurrentDirectory();
        }
    }
}
