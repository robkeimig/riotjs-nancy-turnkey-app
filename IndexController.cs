using System.IO;
using Nancy;

namespace NancyApplication
{
    public sealed class IndexController : NancyModule
    {
        public IndexController() : base("")
        {
            var indexPath = Path.Combine(Directory.GetCurrentDirectory(), "WebContent", "index.html");

            Get("/", _ =>
            {
                var indexBytes = File.ReadAllBytes(indexPath);
                
                return new Response()
                {
                    ContentType = "text/html",
                    Contents = s => s.Write(indexBytes, 0, indexBytes.Length)
                };
            });
        }
    }
}