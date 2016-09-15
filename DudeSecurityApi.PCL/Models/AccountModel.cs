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
    public class AccountModel : ApiClientAuditModel 
    {
        // These fields hold the values for the public properties.
        private int id;
        private string name;
        private int number;
        private LocationModel location;
        private MarketModel market;
        private string timeZone;
        private ProductModel assets;
        private string contactFirstName;
        private string contactMiddleName;
        private string contactLastName;
        private string contactPhoneNumber;
        private string contactEmailAddress;
        private SystemOfRecordAccountModel systemOfRecordAccount;

        /// <summary>
        /// The unique ID for the account.
        /// </summary>
        [JsonProperty("id")]
        public int Id 
        { 
            get 
            {
                return this.id; 
            } 
            set 
            {
                this.id = value;
                onPropertyChanged("Id");
            }
        }

        /// <summary>
        /// The name of the account.
        /// </summary>
        [JsonProperty("name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// The number for the account.
        /// </summary>
        [JsonProperty("number")]
        public int Number 
        { 
            get 
            {
                return this.number; 
            } 
            set 
            {
                this.number = value;
                onPropertyChanged("Number");
            }
        }

        /// <summary>
        /// Represents a geo-location point.
        /// </summary>
        [JsonProperty("location")]
        public LocationModel Location 
        { 
            get 
            {
                return this.location; 
            } 
            set 
            {
                this.location = value;
                onPropertyChanged("Location");
            }
        }

        /// <summary>
        /// Represents a market.
        /// </summary>
        [JsonProperty("market")]
        public MarketModel Market 
        { 
            get 
            {
                return this.market; 
            } 
            set 
            {
                this.market = value;
                onPropertyChanged("Market");
            }
        }

        /// <summary>
        /// The time zone for the account.
        /// </summary>
        [JsonProperty("timeZone")]
        public string TimeZone 
        { 
            get 
            {
                return this.timeZone; 
            } 
            set 
            {
                this.timeZone = value;
                onPropertyChanged("TimeZone");
            }
        }

        /// <summary>
        /// Represents a product.
        /// </summary>
        [JsonProperty("assets")]
        public ProductModel Assets 
        { 
            get 
            {
                return this.assets; 
            } 
            set 
            {
                this.assets = value;
                onPropertyChanged("Assets");
            }
        }

        /// <summary>
        /// The first name of the contact person.
        /// </summary>
        [JsonProperty("contactFirstName")]
        public string ContactFirstName 
        { 
            get 
            {
                return this.contactFirstName; 
            } 
            set 
            {
                this.contactFirstName = value;
                onPropertyChanged("ContactFirstName");
            }
        }

        /// <summary>
        /// The middle name of the contact person.
        /// </summary>
        [JsonProperty("contactMiddleName")]
        public string ContactMiddleName 
        { 
            get 
            {
                return this.contactMiddleName; 
            } 
            set 
            {
                this.contactMiddleName = value;
                onPropertyChanged("ContactMiddleName");
            }
        }

        /// <summary>
        /// The last name of the contact person.
        /// </summary>
        [JsonProperty("contactLastName")]
        public string ContactLastName 
        { 
            get 
            {
                return this.contactLastName; 
            } 
            set 
            {
                this.contactLastName = value;
                onPropertyChanged("ContactLastName");
            }
        }

        /// <summary>
        /// The phone number for the contact person.
        /// </summary>
        [JsonProperty("contactPhoneNumber")]
        public string ContactPhoneNumber 
        { 
            get 
            {
                return this.contactPhoneNumber; 
            } 
            set 
            {
                this.contactPhoneNumber = value;
                onPropertyChanged("ContactPhoneNumber");
            }
        }

        /// <summary>
        /// The email address for the contact person.
        /// </summary>
        [JsonProperty("contactEmailAddress")]
        public string ContactEmailAddress 
        { 
            get 
            {
                return this.contactEmailAddress; 
            } 
            set 
            {
                this.contactEmailAddress = value;
                onPropertyChanged("ContactEmailAddress");
            }
        }

        /// <summary>
        /// Represents a system of record account.
        /// </summary>
        [JsonProperty("systemOfRecordAccount")]
        public SystemOfRecordAccountModel SystemOfRecordAccount 
        { 
            get 
            {
                return this.systemOfRecordAccount; 
            } 
            set 
            {
                this.systemOfRecordAccount = value;
                onPropertyChanged("SystemOfRecordAccount");
            }
        }
    }
} 