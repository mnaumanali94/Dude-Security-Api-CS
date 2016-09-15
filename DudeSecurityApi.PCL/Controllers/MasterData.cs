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
    public partial class MasterData: BaseController, IMasterData
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static MasterData instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static MasterData Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new MasterData();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// The add user system of record map is exposed and provided to create a system of record user map between the Dude Platform user and the system of record user name.
        /// Any response that does not provide a ```201 Created``` response should be treated as an error.
        /// </summary>
        /// <param name="PostSystemOfRecordUserCreateInput">Object containing request parameters</param>
        /// <return>Returns the SystemOfRecordUserModel response from the API call</return>
        public SystemOfRecordUserModel PostSystemOfRecordUserCreate(PostSystemOfRecordUserCreateInput input)
        {
            Task<SystemOfRecordUserModel> t = PostSystemOfRecordUserCreateAsync(input);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// The add user system of record map is exposed and provided to create a system of record user map between the Dude Platform user and the system of record user name.
        /// Any response that does not provide a ```201 Created``` response should be treated as an error.
        /// </summary>
        /// <param name="PostSystemOfRecordUserCreateInput">Object containing request parameters</param>
        /// <return>Returns the SystemOfRecordUserModel response from the API call</return>
        public async Task<SystemOfRecordUserModel> PostSystemOfRecordUserCreateAsync(PostSystemOfRecordUserCreateInput input)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/masterdata/{sourceAbbreviation}/users/{userName}/map/{userSummaryId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "sourceAbbreviation", input.SourceAbbreviation },
                { "userName", input.UserName },
                { "userSummaryId", input.UserSummaryId }
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
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, null);

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
                return APIHelper.JsonDeserialize<SystemOfRecordUserModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// The get product is exposed and provided to return a Dude Platform product from a system of record product id.
        /// Any response that does not provide a ```200 OK``` response should be treated as an error.
        /// </summary>
        /// <param name="GetProductDetailInput">Object containing request parameters</param>
        /// <return>Returns the ProductModel response from the API call</return>
        public ProductModel GetProductDetail(GetProductDetailInput input)
        {
            Task<ProductModel> t = GetProductDetailAsync(input);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// The get product is exposed and provided to return a Dude Platform product from a system of record product id.
        /// Any response that does not provide a ```200 OK``` response should be treated as an error.
        /// </summary>
        /// <param name="GetProductDetailInput">Object containing request parameters</param>
        /// <return>Returns the ProductModel response from the API call</return>
        public async Task<ProductModel> GetProductDetailAsync(GetProductDetailInput input)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/masterdata/products/{productId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "productId", input.ProductId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "sourceAbbreviation", input.SourceAbbreviation },
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
                return APIHelper.JsonDeserialize<ProductModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// The get account is exposed and provided to return a Dude Platform account from a system of record account id.
        /// Any response that does not provide a ```200 OK``` response should be treated as an error.
        /// </summary>
        /// <param name="GetAccountDetailInput">Object containing request parameters</param>
        /// <return>Returns the AccountModel response from the API call</return>
        public AccountModel GetAccountDetail(GetAccountDetailInput input)
        {
            Task<AccountModel> t = GetAccountDetailAsync(input);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// The get account is exposed and provided to return a Dude Platform account from a system of record account id.
        /// Any response that does not provide a ```200 OK``` response should be treated as an error.
        /// </summary>
        /// <param name="GetAccountDetailInput">Object containing request parameters</param>
        /// <return>Returns the AccountModel response from the API call</return>
        public async Task<AccountModel> GetAccountDetailAsync(GetAccountDetailInput input)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/masterdata/accounts/{accountNumber}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "accountNumber", input.AccountNumber }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "sourceAbbreviation", input.SourceAbbreviation },
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
                return APIHelper.JsonDeserialize<AccountModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// The get system of record user is exposed and provided to return a system of record user from a Dude Platform user.
        /// Any response that does not provide a ```200 OK``` response should be treated as an error.
        /// </summary>
        /// <param name="GetSystemOfRecordUserInput">Object containing request parameters</param>
        /// <return>Returns the SystemOfRecordUserModel response from the API call</return>
        public SystemOfRecordUserModel GetSystemOfRecordUser(GetSystemOfRecordUserInput input)
        {
            Task<SystemOfRecordUserModel> t = GetSystemOfRecordUserAsync(input);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// The get system of record user is exposed and provided to return a system of record user from a Dude Platform user.
        /// Any response that does not provide a ```200 OK``` response should be treated as an error.
        /// </summary>
        /// <param name="GetSystemOfRecordUserInput">Object containing request parameters</param>
        /// <return>Returns the SystemOfRecordUserModel response from the API call</return>
        public async Task<SystemOfRecordUserModel> GetSystemOfRecordUserAsync(GetSystemOfRecordUserInput input)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/masterdata/platformusers/{userId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "userId", input.UserId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
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
                return APIHelper.JsonDeserialize<SystemOfRecordUserModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// The get user is exposed and provided to return a Dude Platform user from a system of record user name.
        /// Any response that does not provide a ```200 OK``` response should be treated as an error.
        /// </summary>
        /// <param name="GetUserDetailInput">Object containing request parameters</param>
        /// <return>Returns the UserModel response from the API call</return>
        public UserModel GetUserDetail(GetUserDetailInput input)
        {
            Task<UserModel> t = GetUserDetailAsync(input);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// The get user is exposed and provided to return a Dude Platform user from a system of record user name.
        /// Any response that does not provide a ```200 OK``` response should be treated as an error.
        /// </summary>
        /// <param name="GetUserDetailInput">Object containing request parameters</param>
        /// <return>Returns the UserModel response from the API call</return>
        public async Task<UserModel> GetUserDetailAsync(GetUserDetailInput input)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/masterdata/users/{userName}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "userName", input.UserName }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "sourceAbbreviation", input.SourceAbbreviation },
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
                return APIHelper.JsonDeserialize<UserModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 