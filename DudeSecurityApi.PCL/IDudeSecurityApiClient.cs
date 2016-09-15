/*
 * DudeSecurityApi.PCL
 *
 * This file was automatically generated for Dude Solutions, Inc. by APIMATIC v2.0 ( https://apimatic.io ) on 09/15/2016
 */
using System;
using DSI.SDK.Security.Controllers;

namespace DSI.SDK.Security
{
    public partial interface IDudeSecurityApiClient
    {

        /// <summary>
        /// Singleton access to AccountProducts controller
        /// </summary>
        IAccountProducts AccountProducts { get;}

        /// <summary>
        /// Singleton access to User controller
        /// </summary>
        IUser User { get;}

        /// <summary>
        /// Singleton access to Account controller
        /// </summary>
        IAccount Account { get;}

        /// <summary>
        /// Singleton access to Heartbeat controller
        /// </summary>
        IHeartbeat Heartbeat { get;}

        /// <summary>
        /// Singleton access to SystemInformation controller
        /// </summary>
        ISystemInformation SystemInformation { get;}

        /// <summary>
        /// Singleton access to APIClients controller
        /// </summary>
        IAPIClients APIClients { get;}

        /// <summary>
        /// Singleton access to Markets controller
        /// </summary>
        IMarkets Markets { get;}

        /// <summary>
        /// Singleton access to MasterData controller
        /// </summary>
        IMasterData MasterData { get;}

    }
}