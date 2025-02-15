// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> The script action profile. </summary>
    public partial class ScriptActionProfile
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ScriptActionProfile"/>. </summary>
        /// <param name="scriptActionProfileType"> Type of the script action. Supported type is bash scripts. </param>
        /// <param name="name"> Script name. </param>
        /// <param name="uriString"> Url of the script file. </param>
        /// <param name="services"> List of services to apply the script action. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptActionProfileType"/>, <paramref name="name"/>, <paramref name="uriString"/> or <paramref name="services"/> is null. </exception>
        public ScriptActionProfile(string scriptActionProfileType, string name, string uriString, IEnumerable<string> services)
        {
            if (scriptActionProfileType == null)
            {
                throw new ArgumentNullException(nameof(scriptActionProfileType));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (uriString == null)
            {
                throw new ArgumentNullException(nameof(uriString));
            }
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            ScriptActionProfileType = scriptActionProfileType;
            Name = name;
            UriString = uriString;
            Services = services.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ScriptActionProfile"/>. </summary>
        /// <param name="scriptActionProfileType"> Type of the script action. Supported type is bash scripts. </param>
        /// <param name="name"> Script name. </param>
        /// <param name="uriString"> Url of the script file. </param>
        /// <param name="parameters"> Additional parameters for the script action. It should be space-separated list of arguments required for script execution. </param>
        /// <param name="services"> List of services to apply the script action. </param>
        /// <param name="timeoutInMinutes"> Timeout duration for the script action in minutes. </param>
        /// <param name="shouldPersist"> Specify if the script should persist on the cluster. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScriptActionProfile(string scriptActionProfileType, string name, string uriString, string parameters, IList<string> services, int? timeoutInMinutes, bool? shouldPersist, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ScriptActionProfileType = scriptActionProfileType;
            Name = name;
            UriString = uriString;
            Parameters = parameters;
            Services = services;
            TimeoutInMinutes = timeoutInMinutes;
            ShouldPersist = shouldPersist;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ScriptActionProfile"/> for deserialization. </summary>
        internal ScriptActionProfile()
        {
        }

        /// <summary> Type of the script action. Supported type is bash scripts. </summary>
        public string ScriptActionProfileType { get; set; }
        /// <summary> Script name. </summary>
        public string Name { get; set; }
        /// <summary> Url of the script file. </summary>
        public string UriString { get; set; }
        /// <summary> Additional parameters for the script action. It should be space-separated list of arguments required for script execution. </summary>
        public string Parameters { get; set; }
        /// <summary> List of services to apply the script action. </summary>
        public IList<string> Services { get; }
        /// <summary> Timeout duration for the script action in minutes. </summary>
        public int? TimeoutInMinutes { get; set; }
        /// <summary> Specify if the script should persist on the cluster. </summary>
        public bool? ShouldPersist { get; set; }
    }
}
