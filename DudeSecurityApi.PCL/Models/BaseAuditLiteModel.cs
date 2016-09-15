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
    public class BaseAuditLiteModel : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private AuditInfoModel audit;

        /// <summary>
        /// Represents a light-weight audit object with base properties.
        /// </summary>
        [JsonProperty("audit")]
        public AuditInfoModel Audit 
        { 
            get 
            {
                return this.audit; 
            } 
            set 
            {
                this.audit = value;
                onPropertyChanged("Audit");
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