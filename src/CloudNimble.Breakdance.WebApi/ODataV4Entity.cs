﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace CloudNimble.Breakdance.WebApi
{

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ODataV4Entity<T>
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("@odata.type")]
        public string ODataType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("@odata.id")]
        public string ODataId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("@odata.editLink")]
        public string ODataEditLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Id@odata.type")]
        public string ODataIdType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("value")]
        public List<T> Items { get; set; }

    }

}