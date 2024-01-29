namespace ebayLoginAndCheck.Models
{
    public class ProfilesToDelete
    {
        public List<string> profilesToDelete { get; set; }
    }

    public class Profile
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
        public bool canBeRunning { get; set; }
        public string os { get; set; }
        public Proxy proxy { get; set; }
        public string proxyType { get; set; }
        public string proxyRegion { get; set; }
        public List<object> sharedEmails { get; set; }
        public string shareId { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public DateTime lastActivity { get; set; }
        public List<object> chromeExtensions { get; set; }
        public List<object> userChromeExtensions { get; set; }
        public List<object> tags { get; set; }
        public bool proxyEnabled { get; set; }
    }

    public class ProfileList
    {
        public List<Profile> profiles { get; set; }
        public int allProfilesCount { get; set; }
        public string currentOrbitaMajorV { get; set; }
        public string currentBrowserV { get; set; }
        public string currentTestBrowserV { get; set; }
        public string currentTestOrbitaMajorV { get; set; }
    }
}
