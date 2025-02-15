// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The HostAsset. </summary>
    public partial class HostAsset : InventoryAsset
    {
        /// <summary> Initializes a new instance of <see cref="HostAsset"/>. </summary>
        internal HostAsset()
        {
            IpAddresses = new ChangeTrackingList<ObservedString>();
            WebComponents = new ChangeTrackingList<WebComponent>();
            Headers = new ChangeTrackingList<ObservedHeader>();
            Attributes = new ChangeTrackingList<AttributeDetails>();
            Cookies = new ChangeTrackingList<CookieDetails>();
            SslCerts = new ChangeTrackingList<SslCertAsset>();
            ParentHosts = new ChangeTrackingList<ObservedString>();
            ChildHosts = new ChangeTrackingList<ObservedString>();
            Services = new ChangeTrackingList<AssetService>();
            Cnames = new ChangeTrackingList<ObservedString>();
            Sources = new ChangeTrackingList<SourceDetails>();
            ResourceUrls = new ChangeTrackingList<ResourceUri>();
            ScanMetadata = new ChangeTrackingList<ScanMetadata>();
            Asns = new ChangeTrackingList<ObservedLong>();
            IpBlocks = new ChangeTrackingList<IpBlock>();
            ResponseBodies = new ChangeTrackingList<ObservedString>();
            NsRecord = new ChangeTrackingList<ObservedBoolean>();
            MxRecord = new ChangeTrackingList<ObservedBoolean>();
            Webserver = new ChangeTrackingList<ObservedBoolean>();
            Location = new ChangeTrackingList<ObservedLocation>();
            Nxdomain = new ChangeTrackingList<ObservedBoolean>();
            SslServerConfig = new ChangeTrackingList<SslServerConfig>();
            IsWildcard = new ChangeTrackingList<ObservedBoolean>();
            Banners = new ChangeTrackingList<BannerDetails>();
            Ipv4 = new ChangeTrackingList<ObservedBoolean>();
            Ipv6 = new ChangeTrackingList<ObservedBoolean>();
        }

        /// <summary> Initializes a new instance of <see cref="HostAsset"/>. </summary>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="host"></param>
        /// <param name="domain"></param>
        /// <param name="ipAddresses"></param>
        /// <param name="webComponents"></param>
        /// <param name="headers"></param>
        /// <param name="attributes"></param>
        /// <param name="cookies"></param>
        /// <param name="sslCerts"></param>
        /// <param name="parentHosts"></param>
        /// <param name="childHosts"></param>
        /// <param name="hostCore"></param>
        /// <param name="services"></param>
        /// <param name="cnames"></param>
        /// <param name="sources"></param>
        /// <param name="firstSeen"></param>
        /// <param name="lastSeen"></param>
        /// <param name="count"></param>
        /// <param name="resourceUrls"></param>
        /// <param name="scanMetadata"></param>
        /// <param name="asns"></param>
        /// <param name="ipBlocks"></param>
        /// <param name="responseBodies"></param>
        /// <param name="domainAsset"></param>
        /// <param name="nsRecord"></param>
        /// <param name="mxRecord"></param>
        /// <param name="webserver"></param>
        /// <param name="location"></param>
        /// <param name="nxdomain"></param>
        /// <param name="sslServerConfig"></param>
        /// <param name="isWildcard"></param>
        /// <param name="banners"></param>
        /// <param name="ipv4"></param>
        /// <param name="ipv6"></param>
        internal HostAsset(IDictionary<string, BinaryData> serializedAdditionalRawData, string host, string domain, IReadOnlyList<ObservedString> ipAddresses, IReadOnlyList<WebComponent> webComponents, IReadOnlyList<ObservedHeader> headers, IReadOnlyList<AttributeDetails> attributes, IReadOnlyList<CookieDetails> cookies, IReadOnlyList<SslCertAsset> sslCerts, IReadOnlyList<ObservedString> parentHosts, IReadOnlyList<ObservedString> childHosts, HostCore hostCore, IReadOnlyList<AssetService> services, IReadOnlyList<ObservedString> cnames, IReadOnlyList<SourceDetails> sources, DateTimeOffset? firstSeen, DateTimeOffset? lastSeen, long? count, IReadOnlyList<ResourceUri> resourceUrls, IReadOnlyList<ScanMetadata> scanMetadata, IReadOnlyList<ObservedLong> asns, IReadOnlyList<IpBlock> ipBlocks, IReadOnlyList<ObservedString> responseBodies, DomainAsset domainAsset, IReadOnlyList<ObservedBoolean> nsRecord, IReadOnlyList<ObservedBoolean> mxRecord, IReadOnlyList<ObservedBoolean> webserver, IReadOnlyList<ObservedLocation> location, IReadOnlyList<ObservedBoolean> nxdomain, IReadOnlyList<SslServerConfig> sslServerConfig, IReadOnlyList<ObservedBoolean> isWildcard, IReadOnlyList<BannerDetails> banners, IReadOnlyList<ObservedBoolean> ipv4, IReadOnlyList<ObservedBoolean> ipv6) : base(serializedAdditionalRawData)
        {
            Host = host;
            Domain = domain;
            IpAddresses = ipAddresses;
            WebComponents = webComponents;
            Headers = headers;
            Attributes = attributes;
            Cookies = cookies;
            SslCerts = sslCerts;
            ParentHosts = parentHosts;
            ChildHosts = childHosts;
            HostCore = hostCore;
            Services = services;
            Cnames = cnames;
            Sources = sources;
            FirstSeen = firstSeen;
            LastSeen = lastSeen;
            Count = count;
            ResourceUrls = resourceUrls;
            ScanMetadata = scanMetadata;
            Asns = asns;
            IpBlocks = ipBlocks;
            ResponseBodies = responseBodies;
            DomainAsset = domainAsset;
            NsRecord = nsRecord;
            MxRecord = mxRecord;
            Webserver = webserver;
            Location = location;
            Nxdomain = nxdomain;
            SslServerConfig = sslServerConfig;
            IsWildcard = isWildcard;
            Banners = banners;
            Ipv4 = ipv4;
            Ipv6 = ipv6;
        }

        /// <summary> Gets the host. </summary>
        public string Host { get; }
        /// <summary> Gets the domain. </summary>
        public string Domain { get; }
        /// <summary> Gets the ip addresses. </summary>
        public IReadOnlyList<ObservedString> IpAddresses { get; }
        /// <summary> Gets the web components. </summary>
        public IReadOnlyList<WebComponent> WebComponents { get; }
        /// <summary> Gets the headers. </summary>
        public IReadOnlyList<ObservedHeader> Headers { get; }
        /// <summary> Gets the attributes. </summary>
        public IReadOnlyList<AttributeDetails> Attributes { get; }
        /// <summary> Gets the cookies. </summary>
        public IReadOnlyList<CookieDetails> Cookies { get; }
        /// <summary> Gets the ssl certs. </summary>
        public IReadOnlyList<SslCertAsset> SslCerts { get; }
        /// <summary> Gets the parent hosts. </summary>
        public IReadOnlyList<ObservedString> ParentHosts { get; }
        /// <summary> Gets the child hosts. </summary>
        public IReadOnlyList<ObservedString> ChildHosts { get; }
        /// <summary> Gets the host core. </summary>
        public HostCore HostCore { get; }
        /// <summary> Gets the services. </summary>
        public IReadOnlyList<AssetService> Services { get; }
        /// <summary> Gets the cnames. </summary>
        public IReadOnlyList<ObservedString> Cnames { get; }
        /// <summary> Gets the sources. </summary>
        public IReadOnlyList<SourceDetails> Sources { get; }
        /// <summary> Gets the first seen. </summary>
        public DateTimeOffset? FirstSeen { get; }
        /// <summary> Gets the last seen. </summary>
        public DateTimeOffset? LastSeen { get; }
        /// <summary> Gets the count. </summary>
        public long? Count { get; }
        /// <summary> Gets the resource urls. </summary>
        public IReadOnlyList<ResourceUri> ResourceUrls { get; }
        /// <summary> Gets the scan metadata. </summary>
        public IReadOnlyList<ScanMetadata> ScanMetadata { get; }
        /// <summary> Gets the asns. </summary>
        public IReadOnlyList<ObservedLong> Asns { get; }
        /// <summary> Gets the ip blocks. </summary>
        public IReadOnlyList<IpBlock> IpBlocks { get; }
        /// <summary> Gets the response bodies. </summary>
        public IReadOnlyList<ObservedString> ResponseBodies { get; }
        /// <summary> Gets the domain asset. </summary>
        public DomainAsset DomainAsset { get; }
        /// <summary> Gets the ns record. </summary>
        public IReadOnlyList<ObservedBoolean> NsRecord { get; }
        /// <summary> Gets the mx record. </summary>
        public IReadOnlyList<ObservedBoolean> MxRecord { get; }
        /// <summary> Gets the webserver. </summary>
        public IReadOnlyList<ObservedBoolean> Webserver { get; }
        /// <summary> Gets the location. </summary>
        public IReadOnlyList<ObservedLocation> Location { get; }
        /// <summary> Gets the nxdomain. </summary>
        public IReadOnlyList<ObservedBoolean> Nxdomain { get; }
        /// <summary> Gets the ssl server config. </summary>
        public IReadOnlyList<SslServerConfig> SslServerConfig { get; }
        /// <summary> Gets the is wildcard. </summary>
        public IReadOnlyList<ObservedBoolean> IsWildcard { get; }
        /// <summary> Gets the banners. </summary>
        public IReadOnlyList<BannerDetails> Banners { get; }
        /// <summary> Gets the ipv 4. </summary>
        public IReadOnlyList<ObservedBoolean> Ipv4 { get; }
        /// <summary> Gets the ipv 6. </summary>
        public IReadOnlyList<ObservedBoolean> Ipv6 { get; }
    }
}
