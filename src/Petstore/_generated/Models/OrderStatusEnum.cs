/*
 * 
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Petstore.GeneratedCode.Models
{ 
        /// <summary>
        /// Order Status
        /// </summary>
        /// <value>Order Status</value>
        
        public enum OrderStatusEnum
        {
            /// <summary>
            /// Enum Placed for placed
            /// </summary>
            [EnumMember(Value = "placed")]
            Placed,
            /// <summary>
            /// Enum Approved for approved
            /// </summary>
            [EnumMember(Value = "approved")]
            Approved,
            /// <summary>
            /// Enum Delivered for delivered
            /// </summary>
            [EnumMember(Value = "delivered")]
            Delivered,
        }
}
