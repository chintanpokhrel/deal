/*
 * Deal
 *
 * Limited time deals
 *
 * OpenAPI spec version: 1.0.0
 * Contact: chintan@pokhrel.io
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

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Deal : IEquatable<Deal>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>

        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets ItemId
        /// </summary>

        [DataMember(Name="itemId")]
        public long? ItemId { get; set; }

        /// <summary>
        /// Gets or Sets TotalItems
        /// </summary>

        [DataMember(Name="totalItems")]
        public long? TotalItems { get; set; }

        /// <summary>
        /// deal effective time in YYYYMMDDHHMMSS
        /// </summary>
        /// <value>deal effective time in YYYYMMDDHHMMSS</value>

        [DataMember(Name="dealEffective")]
        public string DealEffective { get; set; }

        /// <summary>
        /// deal expiry time in YYYYMMDDHHMMSS
        /// </summary>
        /// <value>deal expiry time in YYYYMMDDHHMMSS</value>

        [DataMember(Name="dealExpiry")]
        public string DealExpiry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Deal {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  TotalItems: ").Append(TotalItems).Append("\n");
            sb.Append("  DealEffective: ").Append(DealEffective).Append("\n");
            sb.Append("  DealExpiry: ").Append(DealExpiry).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Deal)obj);
        }

        /// <summary>
        /// Returns true if Deal instances are equal
        /// </summary>
        /// <param name="other">Instance of Deal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Deal other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    ItemId == other.ItemId ||
                    ItemId != null &&
                    ItemId.Equals(other.ItemId)
                ) && 
                (
                    TotalItems == other.TotalItems ||
                    TotalItems != null &&
                    TotalItems.Equals(other.TotalItems)
                ) && 
                (
                    DealEffective == other.DealEffective ||
                    DealEffective != null &&
                    DealEffective.Equals(other.DealEffective)
                ) && 
                (
                    DealExpiry == other.DealExpiry ||
                    DealExpiry != null &&
                    DealExpiry.Equals(other.DealExpiry)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (ItemId != null)
                    hashCode = hashCode * 59 + ItemId.GetHashCode();
                    if (TotalItems != null)
                    hashCode = hashCode * 59 + TotalItems.GetHashCode();
                    if (DealEffective != null)
                    hashCode = hashCode * 59 + DealEffective.GetHashCode();
                    if (DealExpiry != null)
                    hashCode = hashCode * 59 + DealExpiry.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Deal left, Deal right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Deal left, Deal right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
