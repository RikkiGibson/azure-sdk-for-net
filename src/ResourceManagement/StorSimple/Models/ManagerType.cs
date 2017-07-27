// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StorSimple;
    using Microsoft.Azure.Management.StorSimple.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ManagerType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ManagerType
    {
        [EnumMember(Value = "GardaV1")]
        GardaV1,
        [EnumMember(Value = "HelsinkiV1")]
        HelsinkiV1
    }
    internal static class ManagerTypeEnumExtension
    {
        internal static string ToSerializedValue(this ManagerType? value)
        {
            return value == null ? null : ((ManagerType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ManagerType value)
        {
            switch( value )
            {
                case ManagerType.GardaV1:
                    return "GardaV1";
                case ManagerType.HelsinkiV1:
                    return "HelsinkiV1";
            }
            return null;
        }

        internal static ManagerType? ParseManagerType(this string value)
        {
            switch( value )
            {
                case "GardaV1":
                    return ManagerType.GardaV1;
                case "HelsinkiV1":
                    return ManagerType.HelsinkiV1;
            }
            return null;
        }
    }
}
