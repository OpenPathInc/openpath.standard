using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OpenPath.Standard.Base.Data.Poco;
using OpenPath.Standard.Base.Service.Interface;
using OpenPath.Utility.Repository.Interface;
using OpenPath.Utility.Repository.Poco;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace OpenPath.Standard.Api.V1.Controllers {

    /// <summary>
    /// Base controller for API endpoints.
    /// </summary>
    public class BaseContoller : ControllerBase {

        // PROPERTIES
        // ====================================================================================================

        /// <summary>
        /// Represents a type used to configure the logging system and create instances of
        /// Microsoft.Extensions.Logging.ILogger from the registered
        /// Microsoft.Extensions.Logging.ILoggerProviders.
        /// </summary>
        internal ILoggerFactory LoggerFactory { get; set; }

        /// <summary>
        /// A generic interface for logging where the category name is derived from the specified
        /// TCategoryName type name. Generally used to enable activation of a named
        /// Microsoft.Extensions.Logging.ILogger from dependency injection.
        /// </summary>
        internal ILogger<PlanetsController> Logger { get; set; }

        // CONSTRUCTORS
        // ====================================================================================================

        /// <summary>
        /// The Base endpoint constructor.
        /// </summary>
        /// <param name="loggerFactory">The Microsoft Logger Factory.</param>
        public BaseContoller(
            ILoggerFactory loggerFactory
        ) {

            // associate the injected services
            LoggerFactory = loggerFactory;
            Logger = loggerFactory.CreateLogger<PlanetsController>();

        }

        public async Task<IActionResult> Envelope<TData>(TData data, ServiceResponsePaco response, IEnumerable<string> errors = null) {

            return await Envelope<TData, FilterPoco>(data, null, response, errors);

        }

        public async Task<IActionResult> Envelope<TData, TFilter>(TData data, IFilter filter, ServiceResponsePaco response, IEnumerable<string> errors = null) {

            var statusCode = GetStatusCode(response);

            // get project properties
            var version = Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
            var company = Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyCompanyAttribute>().Company;
            var copyright = Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright;
            var product = Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyProductAttribute>().Product;

            TFilter nextFilter;
            TFilter previousFilter;
            var nextUrl = (string)null;
            var previousUrl = (string)null;
            var currentURL = (string)null;

            if (filter != null) {

                nextFilter = (TFilter)filter.Clone(1);
                previousFilter = (TFilter)filter.Clone(-1);
                nextUrl = this.Url.Action(HttpContext.Request.Method, null, nextFilter, Request.Scheme);
                previousUrl = this.Url.Action(HttpContext.Request.Method, null, previousFilter, Request.Scheme);
                currentURL = this.Url.Action(HttpContext.Request.Method, null, filter, Request.Scheme);

            }

            // create the envelope
            var envelope = new EnvelopePoco<object> {

                Company = company,
                ApiName = product,
                Version = version,
                Copyright = $"Copyright (c) {copyright}",

                Data = data,
                Filter = filter,

                NextPage = string.IsNullOrWhiteSpace(nextUrl) ? null : new Uri(nextUrl),
                LastPage = string.IsNullOrWhiteSpace(previousUrl) ? null : new Uri(previousUrl),
                CurrentPage = string.IsNullOrWhiteSpace(currentURL) ? null : new Uri(currentURL),

                UtcTimestamp = DateTime.UtcNow

            };

            // create the response
            envelope.Response = new EnvelopeResponsePaco {
                StatusCode = statusCode,
                ErrorMessages = errors
            };

            switch(statusCode) {
                case 200: envelope.Response.StatusMessage = "OK"; break;
                case 201: envelope.Response.StatusMessage = "Created"; break;
                case 207: envelope.Response.StatusMessage = "Multi-Status (200 - OK & 201 - Created)"; break;
                case 404: envelope.Response.StatusMessage = "Not Found"; break;
            }

            return StatusCode(statusCode, envelope);

        }

        private int GetStatusCode(ServiceResponsePaco response) {

            if (response.HasUpdatedOnly) return 200;
            if (response.HasCreatedOnly) return 201;
            if (response.HasCreatedAndUpdated) return 207;
            if (response.RecordsUpdated == 0) return 404;

            return 500;

        }

    }

}
