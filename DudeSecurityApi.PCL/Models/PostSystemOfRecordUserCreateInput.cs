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
    public class PostSystemOfRecordUserCreateInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string sourceAbbreviation;
        private string userName;
        private int userSummaryId;

        /// <summary>
        /// The system of record source abbreviation (SD or FD).
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

        /// <summary>
        /// The user name from the system of record.
        /// </summary>
        [JsonProperty("userName")]
        public string UserName 
        { 
            get 
            {
                return this.userName; 
            } 
            set 
            {
                this.userName = value;
                onPropertyChanged("UserName");
            }
        }

        /// <summary>
        /// The Dude Platform user to map too.
        /// </summary>
        [JsonProperty("userSummaryId")]
        public int UserSummaryId 
        { 
            get 
            {
                return this.userSummaryId; 
            } 
            set 
            {
                this.userSummaryId = value;
                onPropertyChanged("UserSummaryId");
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