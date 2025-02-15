// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Properties of data center and transport preference validation response. </summary>
    public partial class PreferencesValidationResult : DataBoxValidationInputResult
    {
        /// <summary> Initializes a new instance of <see cref="PreferencesValidationResult"/>. </summary>
        internal PreferencesValidationResult()
        {
            ValidationType = DataBoxValidationInputDiscriminator.ValidatePreferences;
        }

        /// <summary> Initializes a new instance of <see cref="PreferencesValidationResult"/>. </summary>
        /// <param name="validationType"> Identifies the type of validation response. </param>
        /// <param name="error"> Error code and message of validation response. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="status"> Validation status of requested data center and transport. </param>
        internal PreferencesValidationResult(DataBoxValidationInputDiscriminator validationType, ResponseError error, IDictionary<string, BinaryData> serializedAdditionalRawData, DataBoxValidationStatus? status) : base(validationType, error, serializedAdditionalRawData)
        {
            Status = status;
            ValidationType = validationType;
        }

        /// <summary> Validation status of requested data center and transport. </summary>
        public DataBoxValidationStatus? Status { get; }
    }
}
