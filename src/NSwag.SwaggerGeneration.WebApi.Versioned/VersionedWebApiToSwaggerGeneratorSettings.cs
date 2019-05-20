namespace NSwag.SwaggerGeneration.WebApi.Versioned
{
    using System.Collections.Generic;
    using Microsoft.Web.Http;
    using Processors;

    public class VersionedWebApiToSwaggerGeneratorSettings : SwaggerGeneratorSettings
    {
        public VersionedWebApiToSwaggerGeneratorSettings()
        {
            OperationProcessors.Add(new VersionedOperationParameterProcessor(this));
            OperationProcessors.Add(new VersionedOperationResponseProcessor(this));
        }

        public List<ApiVersion> ApiVersions { get; } = new List<ApiVersion>();

        /// <summary>
        /// This property is needed to resolve duplicate operations when using Web Api controllers
        /// </summary>
        public string ODataPath { get; set; } = "/odata";
    }
}