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
    /// 
    /// </summary>
    [DataContract]
    public partial class Order : IEquatable<Order>
    { 
        /// <summary>
        /// Gets or Sets id
        /// </summary>
        [DataMember(Name="id")]
        public int id { get; set; }

        /// <summary>
        /// Gets or Sets petId
        /// </summary>
        [DataMember(Name="petId")]
        public int petId { get; set; }

        /// <summary>
        /// Gets or Sets quantity
        /// </summary>
        [DataMember(Name="quantity")]
        public int quantity { get; set; }

        /// <summary>
        /// Gets or Sets shipDate
        /// </summary>
        [DataMember(Name="shipDate")]
        public string shipDate { get; set; }

        /// <summary>
        /// Order Status
        /// </summary>
        /// <value>Order Status</value>
        [DataMember(Name="status")]
        public OrderStatusEnum? status { get; set; }

        /// <summary>
        /// Gets or Sets complete
        /// </summary>
        [DataMember(Name="complete")]
        public bool complete { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Order {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  petId: ").Append(petId).Append("\n");
            sb.Append("  quantity: ").Append(quantity).Append("\n");
            sb.Append("  shipDate: ").Append(shipDate).Append("\n");
            sb.Append("  status: ").Append(status).Append("\n");
            sb.Append("  complete: ").Append(complete).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Order)obj);
        }

        /// <summary>
        /// Returns true if Order instances are equal
        /// </summary>
        /// <param name="other">Instance of Order to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Order other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    id == other.id || null != other &&
                    id.Equals(other.id) == true
                ) && 
                (
                    petId == other.petId || null != other &&
                    petId.Equals(other.petId) == true
                ) && 
                (
                    quantity == other.quantity || null != other &&
                    quantity.Equals(other.quantity) == true
                ) && 
                (
                    shipDate == other.shipDate || null != other &&
                    shipDate.Equals(other.shipDate) == true
                ) && 
                (
                    status == other.status || null != other &&
                    status.Equals(other.status) == true
                ) && 
                (
                    complete == other.complete || null != other &&
                    complete.Equals(other.complete) == true
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    
                    hashCode = hashCode * 59 + id.GetHashCode();
                    
                    hashCode = hashCode * 59 + petId.GetHashCode();
                    
                    hashCode = hashCode * 59 + quantity.GetHashCode();
                    
                    hashCode = hashCode * 59 + shipDate.GetHashCode();
                    if (status != null)
                    hashCode = hashCode * 59 + status.GetHashCode();
                    
                    hashCode = hashCode * 59 + complete.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Order left, Order right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Order left, Order right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
