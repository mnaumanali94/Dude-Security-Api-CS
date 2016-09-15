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
    public partial interface IAccountProducts
    {
        /// <summary>
        /// This endpoint allows existing account product associations to be found and returned or removed.
        /// </summary>
        /// <param name="DeleteAccountProductDetailInput">Object containing request parameters</param>
        /// <return>Returns the void response from the API call</return>
        void DeleteAccountProductDetail(DeleteAccountProductDetailInput input);

        /// <summary>
        /// This endpoint allows existing account product associations to be found and returned or removed.
        /// </summary>
        /// <param name="DeleteAccountProductDetailInput">Object containing request parameters</param>
        /// <return>Returns the void response from the API call</return>
        Task DeleteAccountProductDetailAsync(DeleteAccountProductDetailInput input);

        /// <summary>
        /// This endpoint allows existing account product associations to be found and returned or removed.
        /// </summary>
        /// <param name="GetAccountProductDetailInput">Object containing request parameters</param>
        /// <return>Returns the AccountProductModel response from the API call</return>
        AccountProductModel GetAccountProductDetail(GetAccountProductDetailInput input);

        /// <summary>
        /// This endpoint allows existing account product associations to be found and returned or removed.
        /// </summary>
        /// <param name="GetAccountProductDetailInput">Object containing request parameters</param>
        /// <return>Returns the AccountProductModel response from the API call</return>
        Task<AccountProductModel> GetAccountProductDetailAsync(GetAccountProductDetailInput input);

        /// <summary>
        /// This collection allows new account product associations to be created and for products of existing associations to be returned.
        /// </summary>
        /// <param name="GetAccountProductCollectionInput">Object containing request parameters</param>
        /// <return>Returns the GetAccountProductCollectionResponseModel response from the API call</return>
        GetAccountProductCollectionResponseModel GetAccountProductCollection(GetAccountProductCollectionInput input);

        /// <summary>
        /// This collection allows new account product associations to be created and for products of existing associations to be returned.
        /// </summary>
        /// <param name="GetAccountProductCollectionInput">Object containing request parameters</param>
        /// <return>Returns the GetAccountProductCollectionResponseModel response from the API call</return>
        Task<GetAccountProductCollectionResponseModel> GetAccountProductCollectionAsync(GetAccountProductCollectionInput input);

        /// <summary>
        /// This collection allows new account product associations to be created.
        /// </summary>
        /// <param name="PostAccountProductCreateInput">Object containing request parameters</param>
        /// <return>Returns the AccountProductModel response from the API call</return>
        AccountProductModel PostAccountProductCreate(PostAccountProductCreateInput input);

        /// <summary>
        /// This collection allows new account product associations to be created.
        /// </summary>
        /// <param name="PostAccountProductCreateInput">Object containing request parameters</param>
        /// <return>Returns the AccountProductModel response from the API call</return>
        Task<AccountProductModel> PostAccountProductCreateAsync(PostAccountProductCreateInput input);

    }
} 