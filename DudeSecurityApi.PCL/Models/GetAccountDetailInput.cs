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
    public class GetAccountDetailInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int accountId;
        private bool? includeAudit;
        private string accountNumber;
        private string sourceAbbreviation;

        /// <summary>
        /// The Dude Platform account id.
        /// </summary>
        [JsonProperty("accountId")]
        public int AccountId 
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
        /// {INT} The account number for the system of record account.
        /// </summary>
        [JsonProperty("accountNumber")]
        public string AccountNumber 
        { 
            get 
            {
                return this.accountNumber; 
            } 
            set 
            {
                this.accountNumber = value;
                onPropertyChanged("AccountNumber");
            }
        }

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