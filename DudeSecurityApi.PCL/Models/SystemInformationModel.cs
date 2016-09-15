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
    public class SystemInformationModel : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string application;
        private string version;
        private string apiVersion;
        private HeartbeatModel vitals;
        private List<SystemLinksModel> links;

        /// <summary>
        /// The name of the application.
        /// </summary>
        [JsonProperty("application")]
        public string Application 
        { 
            get 
            {
                return this.application; 
            } 
            set 
            {
                this.application = value;
                onPropertyChanged("Application");
            }
        }

        /// <summary>
        /// The assembly version.
        /// </summary>
        [JsonProperty("version")]
        public string Version 
        { 
            get 
            {
                return this.version; 
            } 
            set 
            {
                this.version = value;
                onPropertyChanged("Version");
            }
        }

        /// <summary>
        /// The API version.
        /// </summary>
        [JsonProperty("apiVersion")]
        public string ApiVersion 
        { 
            get 
            {
                return this.apiVersion; 
            } 
            set 
            {
                this.apiVersion = value;
                onPropertyChanged("ApiVersion");
            }
        }

        /// <summary>
        /// Represents a heartbeat response.
        /// </summary>
        [JsonProperty("vitals")]
        public HeartbeatModel Vitals 
        { 
            get 
            {
                return this.vitals; 
            } 
            set 
            {
                this.vitals = value;
                onPropertyChanged("Vitals");
            }
        }

        /// <summary>
        /// The API routes.
        /// </summary>
        [JsonProperty("links")]
        public List<SystemLinksModel> Links 
        { 
            get 
            {
                return this.links; 
            } 
            set 
            {
                this.links = value;
                onPropertyChanged("Links");
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