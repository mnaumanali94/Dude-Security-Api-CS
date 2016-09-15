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
    public class MarketModel : BaseAuditModel 
    {
        // These fields hold the values for the public properties.
        private int id;
        private string name;
        private string marketDescription;

        /// <summary>
        /// The unique ID for the market.
        /// </summary>
        [JsonProperty("id")]
        public int Id 
        { 
            get 
            {
                return this.id; 
            } 
            set 
            {
                this.id = value;
                onPropertyChanged("Id");
            }
        }

        /// <summary>
        /// The name of the market.
        /// </summary>
        [JsonProperty("name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// The description for the market.
        /// </summary>
        [JsonProperty("marketDescription")]
        public string MarketDescription 
        { 
            get 
            {
                return this.marketDescription; 
            } 
            set 
            {
                this.marketDescription = value;
                onPropertyChanged("MarketDescription");
            }
        }
    }
} 