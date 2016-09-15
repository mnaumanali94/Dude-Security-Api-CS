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
    public partial interface IAccount
    {
        /// <summary>
        /// Retrieves information about the location for the account the token is bound to.  Client credential grants will not be able to successfully call the endpoint.
        /// </summary>
        /// <return>Returns the LocationModel response from the API call</return>
        LocationModel GetAccountMeLocation();

        /// <summary>
        /// Retrieves information about the location for the account the token is bound to.  Client credential grants will not be able to successfully call the endpoint.
        /// </summary>
        /// <return>Returns the LocationModel response from the API call</return>
        Task<LocationModel> GetAccountMeLocationAsync();

        /// <summary>
        /// Retrieves information about the account the token is bound to.  Client credential grants will not be able to successfully call the endpoint.
        /// </summary>
        /// <return>Returns the AccountModel response from the API call</return>
        AccountModel GetAccountMe();

        /// <summary>
        /// Retrieves information about the account the token is bound to.  Client credential grants will not be able to successfully call the endpoint.
        /// </summary>
        /// <return>Returns the AccountModel response from the API call</return>
        Task<AccountModel> GetAccountMeAsync();

        /// <summary>
        /// This endpoint allow for the creation of accounts.
        /// </summary>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the AccountModel response from the API call</return>
        AccountModel PostAccountCreate(AccountModel body);

        /// <summary>
        /// This endpoint allow for the creation of accounts.
        /// </summary>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the AccountModel response from the API call</return>
        Task<AccountModel> PostAccountCreateAsync(AccountModel body);

        /// <summary>
        /// This endpoint allows for existing accounts to be found by ID and returned.
        /// </summary>
        /// <param name="PutAccountDetailInput">Object containing request parameters</param>
        /// <return>Returns the AccountModel response from the API call</return>
        AccountModel PutAccountDetail(PutAccountDetailInput input);

        /// <summary>
        /// This endpoint allows for existing accounts to be found by ID and returned.
        /// </summary>
        /// <param name="PutAccountDetailInput">Object containing request parameters</param>
        /// <return>Returns the AccountModel response from the API call</return>
        Task<AccountModel> PutAccountDetailAsync(PutAccountDetailInput input);

        /// <summary>
        /// This endpoint allows for existing accounts to be found by ID and returned.
        /// </summary>
        /// <param name="GetAccountDetailInput">Object containing request parameters</param>
        /// <return>Returns the AccountModel response from the API call</return>
        AccountModel GetAccountDetail(GetAccountDetailInput input);

        /// <summary>
        /// This endpoint allows for existing accounts to be found by ID and returned.
        /// </summary>
        /// <param name="GetAccountDetailInput">Object containing request parameters</param>
        /// <return>Returns the AccountModel response from the API call</return>
        Task<AccountModel> GetAccountDetailAsync(GetAccountDetailInput input);

    }
} 