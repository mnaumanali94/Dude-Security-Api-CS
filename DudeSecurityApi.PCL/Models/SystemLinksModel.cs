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
    public class SystemLinksModel : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string endpoint;
        private string action;
        private string route;

        /// <summary>
        /// The name of the endpoint.
        /// </summary>
        [JsonProperty("endpoint")]
        public string Endpoint 
        { 
            get 
            {
                return this.endpoint; 
            } 
            set 
            {
                this.endpoint = value;
                onPropertyChanged("Endpoint");
            }
        }

        /// <summary>
        /// The REST action.
        /// </summary>
        [JsonProperty("action")]
        public string Action 
        { 
            get 
            {
                return this.action; 
            } 
            set 
            {
                this.action = value;
                onPropertyChanged("Action");
            }
        }

        /// <summary>
        /// The route to the endpoint.
        /// </summary>
        [JsonProperty("route")]
        public string Route 
        { 
            get 
            {
                return this.route; 
            } 
            set 
            {
                this.route = value;
                onPropertyChanged("Route");
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