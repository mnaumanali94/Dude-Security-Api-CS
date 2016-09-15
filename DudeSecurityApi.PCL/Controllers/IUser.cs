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
    public partial interface IUser
    {
        /// <summary>
        /// This collection returns a list of Dude Platform users for the account.
        /// </summary>
        /// <param name="GetUserCollectionInput">Object containing request parameters</param>
        /// <return>Returns the GetUserCollectionResponseModel response from the API call</return>
        GetUserCollectionResponseModel GetUserCollection(GetUserCollectionInput input);

        /// <summary>
        /// This collection returns a list of Dude Platform users for the account.
        /// </summary>
        /// <param name="GetUserCollectionInput">Object containing request parameters</param>
        /// <return>Returns the GetUserCollectionResponseModel response from the API call</return>
        Task<GetUserCollectionResponseModel> GetUserCollectionAsync(GetUserCollectionInput input);

        /// <summary>
        /// This endpoint allows for existing users to be found and updated or returned.
        /// </summary>
        /// <param name="PutUserDetailInput">Object containing request parameters</param>
        /// <return>Returns the UserModel response from the API call</return>
        UserModel PutUserDetail(PutUserDetailInput input);

        /// <summary>
        /// This endpoint allows for existing users to be found and updated or returned.
        /// </summary>
        /// <param name="PutUserDetailInput">Object containing request parameters</param>
        /// <return>Returns the UserModel response from the API call</return>
        Task<UserModel> PutUserDetailAsync(PutUserDetailInput input);

        /// <summary>
        /// This endpoint allows for existing users to be found and updated or returned.
        /// </summary>
        /// <param name="GetUserDetailInput">Object containing request parameters</param>
        /// <return>Returns the UserDetailModel response from the API call</return>
        UserDetailModel GetUserDetail(GetUserDetailInput input);

        /// <summary>
        /// This endpoint allows for existing users to be found and updated or returned.
        /// </summary>
        /// <param name="GetUserDetailInput">Object containing request parameters</param>
        /// <return>Returns the UserDetailModel response from the API call</return>
        Task<UserDetailModel> GetUserDetailAsync(GetUserDetailInput input);

        /// <summary>
        /// This collection returns a list of Dude Platform users for the account.
        /// </summary>
        /// <param name="PostUserCreateInput">Object containing request parameters</param>
        /// <return>Returns the UserActivationModel response from the API call</return>
        UserActivationModel PostUserCreate(PostUserCreateInput input);

        /// <summary>
        /// This collection returns a list of Dude Platform users for the account.
        /// </summary>
        /// <param name="PostUserCreateInput">Object containing request parameters</param>
        /// <return>Returns the UserActivationModel response from the API call</return>
        Task<UserActivationModel> PostUserCreateAsync(PostUserCreateInput input);

    }
} 