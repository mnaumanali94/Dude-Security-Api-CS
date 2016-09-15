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
    public class SystemOfRecordApiClientModel : BaseAuditLiteModel 
    {
        // These fields hold the values for the public properties.
        private string apiClientIdentifier;
        private string sourceAbbreviation;

        /// <summary>
        /// The client identifier for the system of record.
        /// </summary>
        [JsonProperty("apiClientIdentifier")]
        public string ApiClientIdentifier 
        { 
            get 
            {
                return this.apiClientIdentifier; 
            } 
            set 
            {
                this.apiClientIdentifier = value;
                onPropertyChanged("ApiClientIdentifier");
            }
        }

        /// <summary>
        /// The source abbreviation for the system of record.
        /// </summary>
        [JsonProperty("sourceAbbreviation")]
        public string SourceAbbreviation 
        { 
            get 
            {
                return this.sourceAbbreviation; 
            } 
            set 
            {
                this.sourceAbbreviation = value;
                onPropertyChanged("SourceAbbreviation");
            }
        }
    }
} 