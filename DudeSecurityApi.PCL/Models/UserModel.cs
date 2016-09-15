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
    public class UserModel : BaseUserModel 
    {
        // These fields hold the values for the public properties.
        private List<SecurityRoleModel> roles;
        private bool isActivated;
        private bool isEnabled;
        private double? hourlyRate;

        /// <summary>
        /// The collection of roles associated with the user.  When authenticating against an application, only the roles for the user in the context of that application will be returned.
        /// </summary>
        [JsonProperty("roles")]
        public List<SecurityRoleModel> Roles 
        { 
            get 
            {
                return this.roles; 
            } 
            set 
            {
                this.roles = value;
                onPropertyChanged("Roles");
            }
        }

        /// <summary>
        /// Indicates if a user has been activated within the platform
        /// </summary>
        [JsonProperty("isActivated")]
        public bool IsActivated 
        { 
            get 
            {
                return this.isActivated; 
            } 
            set 
            {
                this.isActivated = value;
                onPropertyChanged("IsActivated");
            }
        }

        /// <summary>
        /// Indicates if the user is able to login to the platform
        /// </summary>
        [JsonProperty("isEnabled")]
        public bool IsEnabled 
        { 
            get 
            {
                return this.isEnabled; 
            } 
            set 
            {
                this.isEnabled = value;
                onPropertyChanged("IsEnabled");
            }
        }

        /// <summary>
        /// The hourly Rate
        /// </summary>
        [JsonProperty("hourlyRate")]
        public double? HourlyRate 
        { 
            get 
            {
                return this.hourlyRate; 
            } 
            set 
            {
                this.hourlyRate = value;
                onPropertyChanged("HourlyRate");
            }
        }
    }
} 