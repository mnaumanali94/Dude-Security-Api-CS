/*
 * DudeSecurityApi.PCL
 *
 * This file was automatically generated for Dude Solutions, Inc. by APIMATIC v2.0 ( https://apimatic.io ) on 09/15/2016
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMATIC.SDK.Common;
using APIMATIC.SDK.Http.Request;
using APIMATIC.SDK.Http.Response;
using APIMATIC.SDK.Http.Client;
using DSI.SDK.Security.Models;

namespace DSI.SDK.Security.Controllers
{
    public partial interface IAPIClients
    {
        /// <summary>
        /// Gets information about a given API Client and System of Record mapping.
        /// Any response that does not provide a ```200 OK``` response should be treated as an error.
        /// </summary>
        /// <param name="GetSystemOfRecordApiClientInput">Object containing request parameters</param>
        /// <return>Returns the SystemOfRecordApiClientModel response from the API call</return>
        SystemOfRecordApiClientModel GetSystemOfRecordApiClient(GetSystemOfRecordApiClientInput input);

        /// <summary>
        /// Gets information about a given API Client and System of Record mapping.
        /// Any response that does not provide a ```200 OK``` response should be treated as an error.
        /// </summary>
        /// <param name="GetSystemOfRecordApiClientInput">Object containing request parameters</param>
        /// <return>Returns the SystemOfRecordApiClientModel response from the API call</return>
        Task<SystemOfRecordApiClientModel> GetSystemOfRecordApiClientAsync(GetSystemOfRecordApiClientInput input);

    }
} 