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
    public class UpdateUserModel : UserModel 
    {
        // These fields hold the values for the public properties.
        private List<UserPhoneModel> phones;

        /// <summary>
        /// The collection of phone numbers for the user.
        /// </summary>
        [JsonProperty("phones")]
        public List<UserPhoneModel> Phones 
        { 
            get 
            {
                return this.phones; 
            } 
            set 
            {
                this.phones = value;
                onPropertyChanged("Phones");
            }
        }
    }
} 