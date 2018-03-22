// Copyright (c) Microsoft. All rights reserved.

namespace Microsoft.Azure.IoTSolutions.IotHubManager.Services.Runtime
{
    public interface IServicesConfig
    {
        string IoTHubConnString { get; set; }
        string StorageAdapterApiUrl { get; set; }
        string DeviceSimulationApiUrl { get; set; }
        string CacheWhiteList { get; }
        // ReSharper disable once InconsistentNaming
        long CacheTTL { get; }
        long CacheRebuildTimeout { get; }
    }

    public class ServicesConfig : IServicesConfig
    {
        public string IoTHubConnString { get; set; }
        public string StorageAdapterApiUrl { get; set; }
        public string DeviceSimulationApiUrl { get; set; }
        public string CacheWhiteList { get; set; }
        public long CacheTTL { get; set; }
        public long CacheRebuildTimeout { get; set; }
    }
}
