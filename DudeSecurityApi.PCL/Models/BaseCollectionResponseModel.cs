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
    public class BaseCollectionResponseModel : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int page;
        private int pageSize;
        private int dataSize;
        private int total;

        /// <summary>
        /// The current page provided in the response data.
        /// </summary>
        [JsonProperty("page")]
        public int Page 
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
        /// The page size returned in the response data.
        /// </summary>
        [JsonProperty("pageSize")]
        public int PageSize 
        { 
            get 
            {
                return this.pageSize; 
            } 
            set 
            {
                this.pageSize = value;
                onPropertyChanged("PageSize");
            }
        }

        /// <summary>
        /// The total records returned in the response.
        /// </summary>
        [JsonProperty("dataSize")]
        public int DataSize 
        { 
            get 
            {
                return this.dataSize; 
            } 
            set 
            {
                this.dataSize = value;
                onPropertyChanged("DataSize");
            }
        }

        /// <summary>
        /// The total number of records available in the collection.
        /// </summary>
        [JsonProperty("total")]
        public int Total 
        { 
            get 
            {
                return this.total; 
            } 
            set 
            {
                this.total = value;
                onPropertyChanged("Total");
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