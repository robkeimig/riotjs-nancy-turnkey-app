namespace NancyApplication
{
    using Microsoft.AspNetCore.Builder;
    using Nancy.Owin;

    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            var opts = new NancyOptions();
            opts.Bootstrapper = new Bootstrapper();
            app.UseOwin(x => x.UseNancy(opts));
        }
    }
}
