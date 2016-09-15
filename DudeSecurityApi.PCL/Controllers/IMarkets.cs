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
    public partial interface IMarkets
    {
        /// <summary>
        /// This collection allows new account product associations to be created and for products of existing associations to be returned.
        /// </summary>
        /// <param name="GetMarketCollectionInput">Object containing request parameters</param>
        /// <return>Returns the GetMarketCollectionResponseModel response from the API call</return>
        GetMarketCollectionResponseModel GetMarketCollection(GetMarketCollectionInput input);

        /// <summary>
        /// This collection allows new account product associations to be created and for products of existing associations to be returned.
        /// </summary>
        /// <param name="GetMarketCollectionInput">Object containing request parameters</param>
        /// <return>Returns the GetMarketCollectionResponseModel response from the API call</return>
        Task<GetMarketCollectionResponseModel> GetMarketCollectionAsync(GetMarketCollectionInput input);

    }
} 