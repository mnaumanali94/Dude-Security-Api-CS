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
    public partial class User: BaseController, IUser
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static User instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static User Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new User();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// This collection returns a list of Dude Platform users for the account.
        /// </summary>
        /// <param name="GetUserCollectionInput">Object containing request parameters</param>
        /// <return>Returns the GetUserCollectionResponseModel response from the API call</return>
        public GetUserCollectionResponseModel GetUserCollection(GetUserCollectionInput input)
        {
            Task<GetUserCollectionResponseModel> t = GetUserCollectionAsync(input);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// This collection returns a list of Dude Platform users for the account.
        /// </summary>
        /// <param name="GetUserCollectionInput">Object containing request parameters</param>
        /// <return>Returns the GetUserCollectionResponseModel response from the API call</return>
        public async Task<GetUserCollectionResponseModel> GetUserCollectionAsync(GetUserCollectionInput input)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/accounts/{accountId}/users");

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
                { "includeAudit", input.IncludeAudit },
                { "q", input.Q },
                { "email", input.Email },
                { "firstName", input.FirstName },
                { "lastName", input.LastName },
                { "isActivated", input.IsActivated },
                { "isEnabled", input.IsEnabled },
                { "roles", input.Roles }
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
                return APIHelper.JsonDeserialize<GetUserCollectionResponseModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// This endpoint allows for existing users to be found and updated or returned.
        /// </summary>
        /// <param name="PutUserDetailInput">Object containing request parameters</param>
        /// <return>Returns the UserModel response from the API call</return>
        public UserModel PutUserDetail(PutUserDetailInput input)
        {
            Task<UserModel> t = PutUserDetailAsync(input);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// This endpoint allows for existing users to be found and updated or returned.
        /// </summary>
        /// <param name="PutUserDetailInput">Object containing request parameters</param>
        /// <return>Returns the UserModel response from the API call</return>
        public async Task<UserModel> PutUserDetailAsync(PutUserDetailInput input)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/accounts/{accountId}/users/{id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", input.AccountId },
                { "id", input.Id }
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
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };
            _headers.Add("Authorization", string.Format("Bearer {0}", Configuration.OAuthAccessToken));

            //append body params
            var _body = APIHelper.JsonSerialize(input.Body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PutBody(_queryUrl, _headers, _body);

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

        /// <summary>
        /// This endpoint allows for existing users to be found and updated or returned.
        /// </summary>
        /// <param name="GetUserDetailInput">Object containing request parameters</param>
        /// <return>Returns the UserDetailModel response from the API call</return>
        public UserDetailModel GetUserDetail(GetUserDetailInput input)
        {
            Task<UserDetailModel> t = GetUserDetailAsync(input);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// This endpoint allows for existing users to be found and updated or returned.
        /// </summary>
        /// <param name="GetUserDetailInput">Object containing request parameters</param>
        /// <return>Returns the UserDetailModel response from the API call</return>
        public async Task<UserDetailModel> GetUserDetailAsync(GetUserDetailInput input)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/accounts/{accountId}/users/{id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", input.AccountId },
                { "id", input.Id }
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
                return APIHelper.JsonDeserialize<UserDetailModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// This collection returns a list of Dude Platform users for the account.
        /// </summary>
        /// <param name="PostUserCreateInput">Object containing request parameters</param>
        /// <return>Returns the UserActivationModel response from the API call</return>
        public UserActivationModel PostUserCreate(PostUserCreateInput input)
        {
            Task<UserActivationModel> t = PostUserCreateAsync(input);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// This collection returns a list of Dude Platform users for the account.
        /// </summary>
        /// <param name="PostUserCreateInput">Object containing request parameters</param>
        /// <return>Returns the UserActivationModel response from the API call</return>
        public async Task<UserActivationModel> PostUserCreateAsync(PostUserCreateInput input)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/accounts/{accountId}/users");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", input.AccountId }
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
                return APIHelper.JsonDeserialize<UserActivationModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 