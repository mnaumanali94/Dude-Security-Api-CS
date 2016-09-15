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
    public class AuditInfoModel : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private DateTime createdDateTime;
        private DateTime updatedDateTime;
        private int createdByApiClientId;
        private int updatedByApiClientId;
        private int? createdByUserId;
        private int? updatedByUserId;

        /// <summary>
        /// The date and time in ISO-8601 format that the record was created.
        /// </summary>
        [JsonProperty("createdDateTime")]
        public DateTime CreatedDateTime 
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
        /// The date and time in ISO-8601 format that the record was last updated.
        /// </summary>
        [JsonProperty("updatedDateTime")]
        public DateTime UpdatedDateTime 
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

        /// <summary>
        /// The Id of the Api Client that created the record.
        /// </summary>
        [JsonProperty("createdByApiClientId")]
        public int CreatedByApiClientId 
        { 
            get 
            {
                return this.createdByApiClientId; 
            } 
            set 
            {
                this.createdByApiClientId = value;
                onPropertyChanged("CreatedByApiClientId");
            }
        }

        /// <summary>
        /// The Id of the Api Client that last modified the record.
        /// </summary>
        [JsonProperty("updatedByApiClientId")]
        public int UpdatedByApiClientId 
        { 
            get 
            {
                return this.updatedByApiClientId; 
            } 
            set 
            {
                this.updatedByApiClientId = value;
                onPropertyChanged("UpdatedByApiClientId");
            }
        }

        /// <summary>
        /// The Id of the User who created the record.
        /// </summary>
        [JsonProperty("createdByUserId")]
        public int? CreatedByUserId 
        { 
            get 
            {
                return this.createdByUserId; 
            } 
            set 
            {
                this.createdByUserId = value;
                onPropertyChanged("CreatedByUserId");
            }
        }

        /// <summary>
        /// The Id of the User who last modified the record.
        /// </summary>
        [JsonProperty("updatedByUserId")]
        public int? UpdatedByUserId 
        { 
            get 
            {
                return this.updatedByUserId; 
            } 
            set 
            {
                this.updatedByUserId = value;
                onPropertyChanged("UpdatedByUserId");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 