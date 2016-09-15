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
    public partial class AccountProducts: BaseController, IAccountProducts
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static AccountProducts instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static AccountProducts Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new AccountProducts();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// This endpoint allows existing account product associations to be found and returned or removed.
        /// </summary>
        /// <param name="DeleteAccountProductDetailInput">Object containing request parameters</param>
        /// <return>Returns the void response from the API call</return>
        public void DeleteAccountProductDetail(DeleteAccountProductDetailInput input)
        {
            Task t = DeleteAccountProductDetailAsync(input);
            Task.WaitAll(t);
        }

        /// <summary>
        /// This endpoint allows existing account product associations to be found and returned or removed.
        /// </summary>
        /// <param name="DeleteAccountProductDetailInput">Object containing request parameters</param>
        /// <return>Returns the void response from the API call</return>
        public async Task DeleteAccountProductDetailAsync(DeleteAccountProductDetailInput input)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/accounts/{accountId}/products/{id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", input.AccountId },
                { "id", input.Id }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "Dude SDK" }
            };
            _headers.Add("Authorization", string.Format("Bearer {0}", Configuration.OAuthAccessToken));

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Delete(_queryUrl, _headers, null);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

        }

        /// <summary>
        /// This endpoint allows existing account product associations to be found and returned or removed.
        /// </summary>
        /// <param name="GetAccountProductDetailInput">Object containing request parameters</param>
        /// <return>Returns the AccountProductModel response from the API call</return>
        public AccountProductModel GetAccountProductDetail(GetAccountProductDetailInput input)
        {
            Task<AccountProductModel> t = GetAccountProductDetailAsync(input);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// This endpoint allows existing account product associations to be found and returned or removed.
        /// </summary>
        /// <param name="GetAccountProductDetailInput">Object containing request parameters</param>
        /// <return>Returns the AccountProductModel response from the API call</return>
        public async Task<AccountProductModel> GetAccountProductDetailAsync(GetAccountProductDetailInput input)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/accounts/{accountId}/products/{id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", input.AccountId },
                { "id", input.Id }
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
                return APIHelper.JsonDeserialize<AccountProductModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// This collection allows new account product associations to be created and for products of existing associations to be returned.
        /// </summary>
        /// <param name="GetAccountProductCollectionInput">Object containing request parameters</param>
        /// <return>Returns the GetAccountProductCollectionResponseModel response from the API call</return>
        public GetAccountProductCollectionResponseModel GetAccountProductCollection(GetAccountProductCollectionInput input)
        {
            Task<GetAccountProductCollectionResponseModel> t = GetAccountProductCollectionAsync(input);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// This collection allows new account product associations to be created and for products of existing associations to be returned.
        /// </summary>
        /// <param name="GetAccountProductCollectionInput">Object containing request parameters</param>
        /// <return>Returns the GetAccountProductCollectionResponseModel response from the API call</return>
        public async Task<GetAccountProductCollectionResponseModel> GetAccountProductCollectionAsync(GetAccountProductCollectionInput input)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/accounts/{accountId}/products");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", input.AccountId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "page", input.Page },
                { "pagesize", input.Pagesize },
                { "orderby", input.Orderby },
                { "q", input.Q },
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
                return APIHelper.JsonDeserialize<GetAccountProductCollectionResponseModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// This collection allows new account product associations to be created.
        /// </summary>
        /// <param name="PostAccountProductCreateInput">Object containing request parameters</param>
        /// <return>Returns the AccountProductModel response from the API call</return>
        public AccountProductModel PostAccountProductCreate(PostAccountProductCreateInput input)
        {
            Task<AccountProductModel> t = PostAccountProductCreateAsync(input);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// This collection allows new account product associations to be created.
        /// </summary>
        /// <param name="PostAccountProductCreateInput">Object containing request parameters</param>
        /// <return>Returns the AccountProductModel response from the API call</return>
        public async Task<AccountProductModel> PostAccountProductCreateAsync(PostAccountProductCreateInput input)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/accounts/{accountId}/products");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", input.AccountId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "Dude SDK" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };
            _headers.Add("Authorization", string.Format("Bearer {0}", Configuration.OAuthAccessToken));

            //append body params
            var _body = APIHelper.JsonSerialize(input.Body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

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
                return APIHelper.JsonDeserialize<AccountProductModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 