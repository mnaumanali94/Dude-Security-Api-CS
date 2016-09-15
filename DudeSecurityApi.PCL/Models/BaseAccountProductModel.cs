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
    public class BaseAccountProductModel : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private AccountModel account;
        private ProductModel asset;

        /// <summary>
        /// Represents a Dude Platform account
        /// </summary>
        [JsonProperty("account")]
        public AccountModel Account 
        { 
            get 
            {
                return this.account; 
            } 
            set 
            {
                this.account = value;
                onPropertyChanged("Account");
            }
        }

        /// <summary>
        /// Represents a product.
        /// </summary>
        [JsonProperty("asset")]
        public ProductModel Asset 
        { 
            get 
            {
                return this.asset; 
            } 
            set 
            {
                this.asset = value;
                onPropertyChanged("Asset");
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