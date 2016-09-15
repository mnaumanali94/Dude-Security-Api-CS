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
    public class BaseAuditModel : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private DateTime? createdDateTime;
        private BaseUserModel createdByUser;
        private DateTime? updatedDateTime;
        private BaseUserModel updatedByUser;

        /// <summary>
        /// The date and time in ISO-8601 format the record was created.
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
        /// The date and time in ISO-8601 format the record was last updated.
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