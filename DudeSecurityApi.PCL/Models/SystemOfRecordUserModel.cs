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
    public class SystemOfRecordUserModel : ApiClientAuditModel 
    {
        // These fields hold the values for the public properties.
        private string userName;
        private string sourceAbbreviation;
        private int userSummaryId;

        /// <summary>
        /// The user name for the system of record user.
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
        /// The dude platform user.
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
    }
} 