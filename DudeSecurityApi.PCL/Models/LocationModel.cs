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
    public class LocationModel : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string city;
        private string region;
        private string country;
        private double? latitude;
        private double? longitude;
        private string streetAddress;
        private string streetAddressLine2;
        private string postalCode;

        /// <summary>
        /// The city for the location.
        /// </summary>
        [JsonProperty("city")]
        public string City 
        { 
            get 
            {
                return this.city; 
            } 
            set 
            {
                this.city = value;
                onPropertyChanged("City");
            }
        }

        /// <summary>
        /// The region for the location.
        /// </summary>
        [JsonProperty("region")]
        public string Region 
        { 
            get 
            {
                return this.region; 
            } 
            set 
            {
                this.region = value;
                onPropertyChanged("Region");
            }
        }

        /// <summary>
        /// The country for the location.
        /// </summary>
        [JsonProperty("country")]
        public string Country 
        { 
            get 
            {
                return this.country; 
            } 
            set 
            {
                this.country = value;
                onPropertyChanged("Country");
            }
        }

        /// <summary>
        /// The latitude for the location.
        /// </summary>
        [JsonProperty("latitude")]
        public double? Latitude 
        { 
            get 
            {
                return this.latitude; 
            } 
            set 
            {
                this.latitude = value;
                onPropertyChanged("Latitude");
            }
        }

        /// <summary>
        /// The longitude of the location.
        /// </summary>
        [JsonProperty("longitude")]
        public double? Longitude 
        { 
            get 
            {
                return this.longitude; 
            } 
            set 
            {
                this.longitude = value;
                onPropertyChanged("Longitude");
            }
        }

        /// <summary>
        /// The street address for the location.
        /// </summary>
        [JsonProperty("streetAddress")]
        public string StreetAddress 
        { 
            get 
            {
                return this.streetAddress; 
            } 
            set 
            {
                this.streetAddress = value;
                onPropertyChanged("StreetAddress");
            }
        }

        /// <summary>
        /// The second, optional line for street address for the location.
        /// </summary>
        [JsonProperty("streetAddressLine2")]
        public string StreetAddressLine2 
        { 
            get 
            {
                return this.streetAddressLine2; 
            } 
            set 
            {
                this.streetAddressLine2 = value;
                onPropertyChanged("StreetAddressLine2");
            }
        }

        /// <summary>
        /// 1489 (string, required) - The postal code for the location.
        /// </summary>
        [JsonProperty("postalCode")]
        public string PostalCode 
        { 
            get 
            {
                return this.postalCode; 
            } 
            set 
            {
                this.postalCode = value;
                onPropertyChanged("PostalCode");
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