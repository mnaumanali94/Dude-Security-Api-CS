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
    public class UserActivationModel : UserDetailModel 
    {
        // These fields hold the values for the public properties.
        private string activationToken;
        private string activationExpires;
        private string activationCompleted;

        /// <summary>
        /// The token that is needed to activate the user
        /// </summary>
        [JsonProperty("activationToken")]
        public string ActivationToken 
        { 
            get 
            {
                return this.activationToken; 
            } 
            set 
            {
                this.activationToken = value;
                onPropertyChanged("ActivationToken");
            }
        }

        /// <summary>
        /// The time at which the activation token will expire
        /// </summary>
        [JsonProperty("activationExpires")]
        public string ActivationExpires 
        { 
            get 
            {
                return this.activationExpires; 
            } 
            set 
            {
                this.activationExpires = value;
                onPropertyChanged("ActivationExpires");
            }
        }

        /// <summary>
        /// The date the activtion process was completed
        /// </summary>
        [JsonProperty("activationCompleted")]
        public string ActivationCompleted 
        { 
            get 
            {
                return this.activationCompleted; 
            } 
            set 
            {
                this.activationCompleted = value;
                onPropertyChanged("ActivationCompleted");
            }
        }
    }
} 