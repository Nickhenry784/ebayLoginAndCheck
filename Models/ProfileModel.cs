namespace ebayLoginAndCheck.Models
{
    public class AudioContext
    {
        public string mode { get; set; }
        public double noise { get; set; }
    }

    public class Canvas
    {
        public string mode { get; set; }
        public double noise { get; set; }
    }

    public class Child
    {
        public List<Child> children { get; set; }
        public string date_added { get; set; }
        public string date_last_used { get; set; }
        public string date_modified { get; set; }
        public string guid { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class ClientRects
    {
        public string mode { get; set; }
        public double noise { get; set; }
    }

    public class Extensions
    {
        public bool enabled { get; set; }
        public bool preloadCustom { get; set; }
        public List<object> names { get; set; }
    }

    public class Fonts
    {
        public bool enableMasking { get; set; }
        public bool enableDomRect { get; set; }
        public List<string> families { get; set; }
    }

    public class Geolocation
    {
        public string mode { get; set; }
        public bool enabled { get; set; }
        public bool customize { get; set; }
        public bool fillBasedOnIp { get; set; }
        public int latitude { get; set; }
        public int longitude { get; set; }
        public int accuracy { get; set; }
        public bool isCustomCoordinates { get; set; }
    }

    public class GlParamValue
    {
        public object name { get; set; }
        public object value { get; set; }
    }

    public class MediaDevices
    {
        public bool enableMasking { get; set; }
        public int videoInputs { get; set; }
        public int audioInputs { get; set; }
        public int audioOutputs { get; set; }
        public string uid { get; set; }
    }

    public class Navigator
    {
        public int hardwareConcurrency { get; set; }
        public bool doNotTrack { get; set; }
        public int deviceMemory { get; set; }
        public string userAgent { get; set; }
        public string resolution { get; set; }
        public string language { get; set; }
        public string platform { get; set; }
    }

    public class Other
    {
        public List<object> children { get; set; }
        public string date_added { get; set; }
        public string date_last_used { get; set; }
        public string date_modified { get; set; }
        public string guid { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Permissions
    {
        public bool transferProfile { get; set; }
        public bool transferToMyWorkspace { get; set; }
        public bool shareProfile { get; set; }
        public bool manageFolders { get; set; }
        public bool editProfile { get; set; }
        public bool deleteProfile { get; set; }
        public bool cloneProfile { get; set; }
        public bool exportProfile { get; set; }
        public bool updateUA { get; set; }
        public bool addVpnUfoProxy { get; set; }
        public bool runProfile { get; set; }
        public bool viewProfile { get; set; }
        public bool addProfileTag { get; set; }
        public bool removeProfileTag { get; set; }
    }

    public class Plugins
    {
        public bool enableVulnerable { get; set; }
        public bool enableFlash { get; set; }
    }

    public class Proxy
    {
        public string mode { get; set; }
        public int port { get; set; }
        public string host { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string autoProxyRegion { get; set; }
        public string torProxyRegion { get; set; }
    }

    public class ProfileData
    {
        public string name { get; set; }
        public string id { get; set; }
        public string notes { get; set; }
        public string browserType { get; set; }
        public bool canBeRunning { get; set; }
        public string os { get; set; }
        public bool isM1 { get; set; } = false;
        public string startUrl { get; set; }
        public Bookmarks bookmarks { get; set; }
        public bool googleServicesEnabled { get; set; }
        public bool isBookmarksSynced { get; set; }
        public bool autoLang { get; set; }
        public bool lockEnabled { get; set; }
        public bool debugMode { get; set; }
        public Navigator navigator { get; set; }
        public Storage storage { get; set; }
        public bool proxyEnabled { get; set; }
        public string autoProxyServer { get; set; }
        public string autoProxyUsername { get; set; }
        public string autoProxyPassword { get; set; }
        public Proxy proxy { get; set; }
        public string dns { get; set; }
        public Plugins plugins { get; set; }
        public Timezone timezone { get; set; }
        public Geolocation geolocation { get; set; }
        public AudioContext audioContext { get; set; }
        public Canvas canvas { get; set; }
        public Fonts fonts { get; set; }
        public MediaDevices mediaDevices { get; set; }
        public WebRTC webRTC { get; set; }
        public WebGL webGL { get; set; }
        public ClientRects clientRects { get; set; }
        public WebGLMetadata webGLMetadata { get; set; }
        public WebglParams webglParams { get; set; }
        public Extensions extensions { get; set; }
        public string s3Path { get; set; }
        public DateTime? s3Date { get; set; }
        public int devicePixelRatio { get; set; }
        public string owner { get; set; }
        public bool checkCookies { get; set; }
        public List<object> chromeExtensions { get; set; }
        public List<object> userChromeExtensions { get; set; }
        public Permissions permissions { get; set; }
    }

    public class Storage
    {
        public bool local { get; set; }
        public bool extensions { get; set; }
        public bool bookmarks { get; set; }
        public bool history { get; set; }
        public bool passwords { get; set; }
        public bool session { get; set; }
        public bool indexedDb { get; set; }
    }

    public class SupportedFunction
    {
        public string name { get; set; }
        public bool supported { get; set; }
    }

    public class Synced
    {
        public List<object> children { get; set; }
        public string date_added { get; set; }
        public string date_last_used { get; set; }
        public string date_modified { get; set; }
        public string guid { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Timezone
    {
        public bool enabled { get; set; }
        public bool fillBasedOnIp { get; set; }
        public string timezone { get; set; }
    }

    public class WebGL
    {
        public string mode { get; set; }
        public double noise { get; set; }
        public double getClientRectsNoise { get; set; }
    }

    public class WebGLMetadata
    {
        public string mode { get; set; }
        public string vendor { get; set; }
        public string renderer { get; set; }
    }

    public class WebglParams
    {
        public List<SupportedFunction> supportedFunctions { get; set; }
        public List<GlParamValue> glParamValues { get; set; }
        public int? textureMaxAnisotropyExt { get; set; } = 16;
        public List<string> extensions { get; set; }
        public string glCanvas { get; set; } = "webgl2";
        public bool antialiasing { get; set; } = true;
        public string shaiderPrecisionFormat { get; set; } = "highp/highp";
    }

    public class WebRTC
    {
        public string mode { get; set; }
        public bool enabled { get; set; }
        public bool customize { get; set; }
        public bool localIpMasking { get; set; }
        public bool fillBasedOnIp { get; set; }
        public string publicIp { get; set; }
        public List<object> localIps { get; set; }
    }
}
