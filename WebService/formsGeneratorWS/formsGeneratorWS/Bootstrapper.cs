namespace formsGeneratorWS
{
    using formsGeneratorWS.Data.Repositories;
    using Nancy;
    using Nancy.Bootstrapper;
    using Nancy.Json;
    using Nancy.TinyIoc;
    using System;

    public class Bootstrapper : DefaultNancyBootstrapper
    {

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);

            //repos

            container.Register<IFormRepository, FormRepository>();
            container.Register<IFormDataRepository, FormDataRepository>();
            
        }

        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);

            JsonSettings.MaxJsonLength = Int32.MaxValue;

        }
        // The bootstrapper enables you to reconfigure the composition of the framework,
        // by overriding the various methods and properties.
        // For more information https://github.com/NancyFx/Nancy/wiki/Bootstrapper
    }
}