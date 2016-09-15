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
    public class SystemOfRecordAccountModel : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int accountNumber;
        private string sourceAbbreviation;
        private string accountGarden;

        /// <summary>
        /// The account number for the system of record.
        /// </summary>
        [JsonProperty("accountNumber")]
        public int AccountNumber 
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
        /// The source abbreviation for the system of record (like SD for School Dude or FD for Facility Dude).
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
        /// The account garden from the system of record.
        /// </summary>
        [JsonProperty("accountGarden")]
        public string AccountGarden 
        { 
            get 
            {
                return this.accountGarden; 
            } 
            set 
            {
                this.accountGarden = value;
                onPropertyChanged("AccountGarden");
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