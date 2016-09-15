/*
 * DudeSecurityApi.PCL
 *
 * This file was automatically generated for Dude Solutions, Inc. by APIMATIC v2.0 ( https://apimatic.io ) on 09/15/2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using APIMATIC.SDK.Common;

namespace DSI.SDK.Security.Models
{
    public class UserDetailModel : UserModel 
    {
        // These fields hold the values for the public properties.
        private AccountModel account;
        private List<PermissionModel> permissions;
        private BaseClientModel createdByApiClient;
        private BaseClientModel updatedByApiClient;
        private BaseUserModel createdByUser;
        private DateTime? createdDateTime;
        private BaseUserModel updatedByUser;
        private DateTime? updatedDateTime;

        /// <summary>
        /// Represents a Dude Platform account
        /// </summary>
        [JsonProperty("account")]
        public AccountModel Account 
        { 
            get 
            {
                return this.account; 
            } 
            set 
            {
                this.account = value;
                onPropertyChanged("Account");
            }
        }

        /// <summary>
        /// The list of permissions available to the user based on the current role set.
        /// </summary>
        [JsonProperty("permissions")]
        public List<PermissionModel> Permissions 
        { 
            get 
            {
                return this.permissions; 
            } 
            set 
            {
                this.permissions = value;
                onPropertyChanged("Permissions");
            }
        }

        /// <summary>
        /// Represents the API Client object with base properties.
        /// </summary>
        [JsonProperty("createdByApiClient")]
        public BaseClientModel CreatedByApiClient 
        { 
            get 
            {
                return this.createdByApiClient; 
            } 
            set 
            {
                this.createdByApiClient = value;
                onPropertyChanged("CreatedByApiClient");
            }
        }

        /// <summary>
        /// Represents the API Client object with base properties.
        /// </summary>
        [JsonProperty("updatedByApiClient")]
        public BaseClientModel UpdatedByApiClient 
        { 
            get 
            {
                return this.updatedByApiClient; 
            } 
            set 
            {
                this.updatedByApiClient = value;
                onPropertyChanged("UpdatedByApiClient");
            }
        }

        /// <summary>
        /// Represents a user with base properties.
        /// </summary>
        [JsonProperty("createdByUser")]
        public BaseUserModel CreatedByUser 
        { 
            get 
            {
                return this.createdByUser; 
            } 
            set 
            {
                this.createdByUser = value;
                onPropertyChanged("CreatedByUser");
            }
        }

        /// <summary>
        /// The UTC date and time the object was created.
        /// </summary>
        [JsonProperty("createdDateTime")]
        public DateTime? CreatedDateTime 
        { 
            get 
            {
                return this.createdDateTime; 
            } 
            set 
            {
                this.createdDateTime = value;
                onPropertyChanged("CreatedDateTime");
            }
        }

        /// <summary>
        /// Represents a user with base properties.
        /// </summary>
        [JsonProperty("updatedByUser")]
        public BaseUserModel UpdatedByUser 
        { 
            get 
            {
                return this.updatedByUser; 
            } 
            set 
            {
                this.updatedByUser = value;
                onPropertyChanged("UpdatedByUser");
            }
        }

        /// <summary>
        /// The UTC date and time the object was last updated.
        /// </summary>
        [JsonProperty("updatedDateTime")]
        public DateTime? UpdatedDateTime 
        { 
            get 
            {
                return this.updatedDateTime; 
            } 
            set 
            {
                this.updatedDateTime = value;
                onPropertyChanged("UpdatedDateTime");
            }
        }
    }
} 