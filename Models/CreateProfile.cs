namespace ebayLoginAndCheck.Models
{
    public class CreateProfile
    {
        public string name { get; set; }
        public string notes { get; set; }
        public string browserType { get; set; }
        public string os { get; set; }
        public string startUrl { get; set; }
        public bool googleServicesEnabled { get; set; }
        public bool lockEnabled { get; set; }
        public bool debugMode { get; set; }
        public Geolocation geolocation { get; set; }
        public Navigator navigator { get; set; }
        public GeoProxyInfo geoProxyInfo { get; set; }
        public Storage storage { get; set; }
        public bool proxyEnabled { get; set; }
        public Proxy proxy { get; set; }
        public string dns { get; set; }
        public Plugins plugins { get; set; }
        public Timezone timezone { get; set; }
        public AudioContext audioContext { get; set; }
        public Canvas canvas { get; set; }
        public Fonts fonts { get; set; }
        public MediaDevices mediaDevices { get; set; }
        public WebRTC webRTC { get; set; }
        public WebGL webGL { get; set; }
        public ClientRects clientRects { get; set; }
        public WebGLMetadata webGLMetadata { get; set; }
        public WebglParams webglParams { get; set; }
        public string profile { get; set; }
        public string googleClientId { get; set; }
        public bool updateExtensions { get; set; }
        public List<string> chromeExtensions { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

    public class CreateProfileResult
    {
        public string name { get; set; }
        public string role { get; set; }
        public string id { get; set; }
        public string notes { get; set; }
        public string browserType { get; set; }
        public bool lockEnabled { get; set; }
        public Timezone timezone { get; set; }
        public Navigator navigator { get; set; }
        public Geolocation geolocation { get; set; }
        public bool debugMode { get; set; }
        public string os { get; set; }
        public Proxy proxy { get; set; }
        public List<object> folders { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public List<string> chromeExtensions { get; set; }
        public List<object> userChromeExtensions { get; set; }
        public List<object> tags { get; set; }
        public bool proxyEnabled { get; set; }
        public bool isBookmarksSynced { get; set; }
        public bool autoLang { get; set; }
        public WebGLMetadata webGLMetadata { get; set; }
        public Fonts fonts { get; set; }
    }

    public class GeoProxyInfo
    {
    }

    public class ProfileResult
    {
        public string ProfileId { get; set; }

        public string system { get; set; }
    }
}
