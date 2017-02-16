using System;
using System.IO;
using Nancy;
using Nancy.Conventions;

namespace NancyApplication
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        //Web admin content file extensions we will allow to be served to client
        private static string[] AllowedExtensions = { ".js", ".css", ".tag", ".png", ".svg", ".html", ".woff", ".woff2", ".ttf", ".txt" };

        /// <summary>
        /// Override root path provider with custom version so that we can set the content root dynamically
        /// </summary>
        protected override IRootPathProvider RootPathProvider
        {
            get
            {
                return new CustomRootPathProvider();
            }
        }

        /// <summary>
        /// Enable static file serving using standard nancy convention builder
        /// </summary>
        /// <param name="nancyConventions"></param>
        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            base.ConfigureConventions(nancyConventions);
            
            //Content root is set using custom provider, so no need to manipulate paths here
            nancyConventions.StaticContentsConventions.Add(
                StaticContentConventionBuilder.AddDirectory("/", 
                    "WebContent", AllowedExtensions)
            );
        }
    }

    internal class CustomRootPathProvider : IRootPathProvider
    {
        public string GetRootPath()
        {
            return Directory.GetCurrentDirectory();
        }
    }
}