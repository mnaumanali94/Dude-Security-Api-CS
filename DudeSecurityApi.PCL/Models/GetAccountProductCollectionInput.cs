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
    public class GetAccountProductCollectionInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int accountId;
        private int? page;
        private int? pagesize;
        private string morderby;
        private string q;
        private bool? includeAudit;

        /// <summary>
        /// ID of the account in the form of an integer
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
        /// The page to request from the collection.
        /// </summary>
        [JsonProperty("page")]
        public int? Page 
        { 
            get 
            {
                return this.page; 
            } 
            set 
            {
                this.page = value;
                onPropertyChanged("Page");
            }
        }

        /// <summary>
        /// The number of records to load in a page from the collection.
        /// </summary>
        [JsonProperty("pagesize")]
        public int? Pagesize 
        { 
            get 
            {
                return this.pagesize; 
            } 
            set 
            {
                this.pagesize = value;
                onPropertyChanged("Pagesize");
            }
        }

        /// <summary>
        /// A string describing the ordering to perform on the collection.
        /// </summary>
        [JsonProperty("orderby")]
        public string Orderby 
        { 
            get 
            {
                return this.morderby; 
            } 
            set 
            {
                this.morderby = value;
                onPropertyChanged("Orderby");
            }
        }

        /// <summary>
        /// Queries product name containing this value
        /// </summary>
        [JsonProperty("q")]
        public string Q 
        { 
            get 
            {
                return this.q; 
            } 
            set 
            {
                this.q = value;
                onPropertyChanged("Q");
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