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
    public partial interface IMasterData
    {
        /// <summary>
        /// The add user system of record map is exposed and provided to create a system of record user map between the Dude Platform user and the system of record user name.
        /// Any response that does not provide a ```201 Created``` response should be treated as an error.
        /// </summary>
        /// <param name="PostSystemOfRecordUserCreateInput">Object containing request parameters</param>
        /// <return>Returns the SystemOfRecordUserModel response from the API call</return>
        SystemOfRecordUserModel PostSystemOfRecordUserCreate(PostSystemOfRecordUserCreateInput input);

        /// <summary>
        /// The add user system of record map is exposed and provided to create a system of record user map between the Dude Platform user and the system of record user name.
        /// Any response that does not provide a ```201 Created``` response should be treated as an error.
        /// </summary>
        /// <param name="PostSystemOfRecordUserCreateInput">Object containing request parameters</param>
        /// <return>Returns the SystemOfRecordUserModel response from the API call</return>
        Task<SystemOfRecordUserModel> PostSystemOfRecordUserCreateAsync(PostSystemOfRecordUserCreateInput input);

        /// <summary>
        /// The get product is exposed and provided to return a Dude Platform product from a system of record product id.
        /// Any response that does not provide a ```200 OK``` response should be treated as an error.
        /// </summary>
        /// <param name="GetProductDetailInput">Object containing request parameters</param>
        /// <return>Returns the ProductModel response from the API call</return>
        ProductModel GetProductDetail(GetProductDetailInput input);

        /// <summary>
        /// The get product is exposed and provided to return a Dude Platform product from a system of record product id.
        /// Any response that does not provide a ```200 OK``` response should be treated as an error.
        /// </summary>
        /// <param name="GetProductDetailInput">Object containing request parameters</param>
        /// <return>Returns the ProductModel response from the API call</return>
        Task<ProductModel> GetProductDetailAsync(GetProductDetailInput input);

        /// <summary>
        /// The get account is exposed and provided to return a Dude Platform account from a system of record account id.
        /// Any response that does not provide a ```200 OK``` response should be treated as an error.
        /// </summary>
        /// <param name="GetAccountDetailInput">Object containing request parameters</param>
        /// <return>Returns the AccountModel response from the API call</return>
        AccountModel GetAccountDetail(GetAccountDetailInput input);

        /// <summary>
        /// The get account is exposed and provided to return a Dude Platform account from a system of record account id.
        /// Any response that does not provide a ```200 OK``` response should be treated as an error.
        /// </summary>
        /// <param name="GetAccountDetailInput">Object containing request parameters</param>
        /// <return>Returns the AccountModel response from the API call</return>
        Task<AccountModel> GetAccountDetailAsync(GetAccountDetailInput input);

        /// <summary>
        /// The get system of record user is exposed and provided to return a system of record user from a Dude Platform user.
        /// Any response that does not provide a ```200 OK``` response should be treated as an error.
        /// </summary>
        /// <param name="GetSystemOfRecordUserInput">Object containing request parameters</param>
        /// <return>Returns the SystemOfRecordUserModel response from the API call</return>
        SystemOfRecordUserModel GetSystemOfRecordUser(GetSystemOfRecordUserInput input);

        /// <summary>
        /// The get system of record user is exposed and provided to return a system of record user from a Dude Platform user.
        /// Any response that does not provide a ```200 OK``` response should be treated as an error.
        /// </summary>
        /// <param name="GetSystemOfRecordUserInput">Object containing request parameters</param>
        /// <return>Returns the SystemOfRecordUserModel response from the API call</return>
        Task<SystemOfRecordUserModel> GetSystemOfRecordUserAsync(GetSystemOfRecordUserInput input);

        /// <summary>
        /// The get user is exposed and provided to return a Dude Platform user from a system of record user name.
        /// Any response that does not provide a ```200 OK``` response should be treated as an error.
        /// </summary>
        /// <param name="GetUserDetailInput">Object containing request parameters</param>
        /// <return>Returns the UserModel response from the API call</return>
        UserModel GetUserDetail(GetUserDetailInput input);

        /// <summary>
        /// The get user is exposed and provided to return a Dude Platform user from a system of record user name.
        /// Any response that does not provide a ```200 OK``` response should be treated as an error.
        /// </summary>
        /// <param name="GetUserDetailInput">Object containing request parameters</param>
        /// <return>Returns the UserModel response from the API call</return>
        Task<UserModel> GetUserDetailAsync(GetUserDetailInput input);

    }
} 