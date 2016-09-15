/*
 * DudeSecurityApi.PCL
 *
 * This file was automatically generated for Dude Solutions, Inc. by APIMATIC v2.0 ( https://apimatic.io ) on 09/15/2016
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
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
    public partial class Markets: BaseController, IMarkets
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static Markets instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static Markets Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new Markets();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// This collection allows new account product associations to be created and for products of existing associations to be returned.
        /// </summary>
        /// <param name="GetMarketCollectionInput">Object containing request parameters</param>
        /// <return>Returns the GetMarketCollectionResponseModel response from the API call</return>
        public GetMarketCollectionResponseModel GetMarketCollection(GetMarketCollectionInput input)
        {
            Task<GetMarketCollectionResponseModel> t = GetMarketCollectionAsync(input);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// This collection allows new account product associations to be created and for products of existing associations to be returned.
        /// </summary>
        /// <param name="GetMarketCollectionInput">Object containing request parameters</param>
        /// <return>Returns the GetMarketCollectionResponseModel response from the API call</return>
        public async Task<GetMarketCollectionResponseModel> GetMarketCollectionAsync(GetMarketCollectionInput input)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/markets");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "page", input.Page },
                { "pagesize", input.Pagesize },
                { "orderby", input.Orderby },
                { "name", input.Name },
                { "includeAudit", input.IncludeAudit }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "Dude SDK" },
                { "accept", "application/json" }
            };
            _headers.Add("Authorization", string.Format("Bearer {0}", Configuration.OAuthAccessToken));

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //return null on 404
            if (_response.StatusCode == 404)
                 return null;

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<GetMarketCollectionResponseModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 