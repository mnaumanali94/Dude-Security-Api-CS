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
    public class ApiClientAuditModel : BaseAuditModel 
    {
        // These fields hold the values for the public properties.
        private BaseClientModel createdByApiClient;
        private BaseClientModel updatedByApiClient;

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
    }
} 