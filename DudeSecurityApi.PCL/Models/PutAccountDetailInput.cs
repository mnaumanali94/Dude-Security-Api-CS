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
    public class PutAccountDetailInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private double accountId;
        private AccountModel body;
        private bool? includeAudit;

        /// <summary>
        /// The Dude Platform account id.
        /// </summary>
        [JsonProperty("accountId")]
        public double AccountId 
        { 
            get 
            {
                return this.accountId; 
            } 
            set 
            {
                this.accountId = value;
                onPropertyChanged("AccountId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("body")]
        public AccountModel Body 
        { 
            get 
            {
                return this.body; 
            } 
            set 
            {
                this.body = value;
                onPropertyChanged("Body");
            }
        }

        /// <summary>
        /// Flag to return audit information from the api
        /// </summary>
        [JsonProperty("includeAudit")]
        public bool? IncludeAudit 
        { 
            get 
            {
                return this.includeAudit; 
            } 
            set 
            {
                this.includeAudit = value;
                onPropertyChanged("IncludeAudit");
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