using System;

namespace TubeHaus.External.Tfl
{
    public class TflApiConfig
    {
        public string AppId { get; }

        public string AppKey { get; }

        public string BaseUri { get; }

        public TflApiConfig(string appId, string appKey, string baseUri = "https://api.tfl.gov.uk")
        {
            AppId = appId ?? throw new ArgumentNullException(nameof(appId));
            AppKey = appKey ?? throw new ArgumentNullException(nameof(appKey));
            BaseUri = baseUri;
        }
    }
}