/*
 * DudeSecurityApi.PCL
 *
 * This file was automatically generated for Dude Solutions, Inc. by APIMATIC v2.0 ( https://apimatic.io ) on 09/15/2016
 */
using System;
using DSI.SDK.Security.Controllers;
using APIMATIC.SDK.Http.Client;

namespace DSI.SDK.Security
{
    public partial class DudeSecurityApiClient: IDudeSecurityApiClient
    {

        /// <summary>
        /// Singleton access to AccountProducts controller
        /// </summary>
        public IAccountProducts AccountProducts
        {
            get
            {
                return DSI.SDK.Security.Controllers.AccountProducts.Instance;
            }
        }

        /// <summary>
        /// Singleton access to User controller
        /// </summary>
        public IUser User
        {
            get
            {
                return DSI.SDK.Security.Controllers.User.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Account controller
        /// </summary>
        public IAccount Account
        {
            get
            {
                return DSI.SDK.Security.Controllers.Account.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Heartbeat controller
        /// </summary>
        public IHeartbeat Heartbeat
        {
            get
            {
                return DSI.SDK.Security.Controllers.Heartbeat.Instance;
            }
        }

        /// <summary>
        /// Singleton access to SystemInformation controller
        /// </summary>
        public ISystemInformation SystemInformation
        {
            get
            {
                return DSI.SDK.Security.Controllers.SystemInformation.Instance;
            }
        }

        /// <summary>
        /// Singleton access to APIClients controller
        /// </summary>
        public IAPIClients APIClients
        {
            get
            {
                return DSI.SDK.Security.Controllers.APIClients.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Markets controller
        /// </summary>
        public IMarkets Markets
        {
            get
            {
                return DSI.SDK.Security.Controllers.Markets.Instance;
            }
        }

        /// <summary>
        /// Singleton access to MasterData controller
        /// </summary>
        public IMasterData MasterData
        {
            get
            {
                return DSI.SDK.Security.Controllers.MasterData.Instance;
            }
        }

        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public DudeSecurityApiClient() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public DudeSecurityApiClient(string oAuthAccessToken)
        {
            Configuration.OAuthAccessToken = oAuthAccessToken;
        }
    }
}