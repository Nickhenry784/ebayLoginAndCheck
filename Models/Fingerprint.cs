namespace ebayLoginAndCheck.Models
{
    public class Fingerprint
    {
        public Navigator navigator { get; set; }
        public Canvas canvas { get; set; }
        public MediaDevices mediaDevices { get; set; }
        public WebRTC webRTC { get; set; }
        public WebGLMetadata webGLMetadata { get; set; }
        public WebglParams webglParams { get; set; }
        public WebGL webGL { get; set; }
        public ClientRects clientRects { get; set; }
        public string os { get; set; }
        public double devicePixelRatio { get; set; }
        public List<string> fonts { get; set; }
        public List<object> extensionsToNewProfiles { get; set; }
        public List<object> userExtensionsToNewProfiles { get; set; }
        public bool autoLang { get; set; }
    }
}
