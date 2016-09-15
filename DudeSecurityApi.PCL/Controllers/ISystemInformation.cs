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
    public partial interface ISystemInformation
    {
        /// <summary>
        /// Retrieve api version, vitals, links, etc.
        /// </summary>
        /// <return>Returns the SystemInformationModel response from the API call</return>
        SystemInformationModel GetSICheck();

        /// <summary>
        /// Retrieve api version, vitals, links, etc.
        /// </summary>
        /// <return>Returns the SystemInformationModel response from the API call</return>
        Task<SystemInformationModel> GetSICheckAsync();

    }
} 