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
    public class GetSystemOfRecordUserInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int userId;
        private bool? includeAudit;

        /// <summary>
        /// The id of the Dude Platform user.
        /// </summary>
        [JsonProperty("userId")]
        public int UserId 
        { 
            get 
            {
                return this.userId; 
            } 
            set 
            {
                this.userId = value;
                onPropertyChanged("UserId");
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