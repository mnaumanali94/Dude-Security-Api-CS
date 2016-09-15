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
    public partial interface IHeartbeat
    {
        /// <summary>
        /// The heartbeat is exposed and provided to check for availability of the service.
        /// Any response that does not provide a ```200 OK``` response code should be treated as an error.
        /// </summary>
        /// <return>Returns the HeartbeatModel response from the API call</return>
        HeartbeatModel GetHeartbeatCheck();

        /// <summary>
        /// The heartbeat is exposed and provided to check for availability of the service.
        /// Any response that does not provide a ```200 OK``` response code should be treated as an error.
        /// </summary>
        /// <return>Returns the HeartbeatModel response from the API call</return>
        Task<HeartbeatModel> GetHeartbeatCheckAsync();

    }
} 