using ebayLoginAndCheck.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace ebayLoginAndCheck.Controllers
{
    class AddPreferenceController
    {

        public string convertPathToString(string currentDirectory)
        {
            string path = currentDirectory.Replace(@"\", "\\");
            Console.WriteLine(path);
            return path;
        }

        public string getUserAgent(string path)
        {
            string[] spliPath = path.Split('/');
            string userAgent = string.Empty;
            for (int i = 0; i < spliPath.Length; i++)
            {
                if (i == spliPath.Length - 2)
                {
                    userAgent += "115.0.5790.82 Safari/";
                }
                else if (i == spliPath.Length - 1)
                {
                    userAgent += spliPath[i];
                }
                else
                {
                    userAgent += spliPath[i] + "/";
                }

            }
            Console.WriteLine(userAgent);
            return userAgent;
        }

        public async Task<ipCheckLocation> checkProxyAddress(string proxy)
        {
            string ipAddress = string.Empty;
            if (!string.IsNullOrEmpty(proxy))
            {
                ipAddress = proxy.Split(':')[0];
            }
            var options = new RestClientOptions("http://ip-api.com/json/" + ipAddress);
            var client = new RestClient(options);
            var request = new RestRequest();
            request.Method = Method.Get;
            request.AddParameter("Accept", "*/*");
            request.AddParameter("Accept-Language", "vi,en-US;q=0.9,en;q=0.8");
            request.AddParameter("Connection", "keep-alive");
            request.AddParameter("Origin", "https://ip-api.com");
            request.AddParameter("Referer", "https://ip-api.com/");
            request.AddParameter("Sec-Fetch-Dest", "empty");
            request.AddParameter("Sec-Fetch-Mode", "cors");
            request.AddParameter("Sec-Fetch-Site", "same-site");
            request.AddParameter("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/115.0.0.0 Safari/537.36");
            request.AddParameter("sec-ch-ua", "\"Google Chrome\";v=\"115\", \"Not;A=Brand\";v=\"8\", \"Chromium\";v=\"115\"");
            request.AddParameter("sec-ch-ua-mobile", "?0");
            request.AddParameter("sec-ch-ua-platform", "\"Windows\"");
            var response = await client.ExecuteAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                ipCheckLocation myDeserializedClass = JsonConvert.DeserializeObject<ipCheckLocation>(response.Content);
                return myDeserializedClass;
            }
            else
            {
                return null;
            }
        }
        public void addPreference(string fileName, string currentDirectory, ProfileData profileData)
        {
            ipCheckLocation ipCheck = checkProxyAddress(profileData.proxy.host).Result;
            Random random = new Random();
            bool audioContextMode = profileData.audioContext.mode.Equals("noise") ? true : false;
            bool clientRectsNoiseEnable = profileData.clientRects.mode.Equals("off") ? false : true;
            bool webGLMode = profileData.webGL.mode.Equals("off") ? false : true;
            bool webGLMetadataMode = profileData.webGLMetadata.mode.Equals("mask") ? true : false;
            string userAgent = getUserAgent(profileData.navigator.userAgent);
            PreferenceRoot preferenceRoot = new PreferenceRoot();
            NewTabPage newTabPage = new NewTabPage();
            preferenceRoot.NewTabPage = newTabPage;
            AlternateErrorPages alternateErrorPages = new AlternateErrorPages();
            preferenceRoot.alternate_error_pages = alternateErrorPages;
            AppsPreferences apps = new AppsPreferences();
            preferenceRoot.apps = apps;
            Autocomplete autocomplete = new Autocomplete();
            preferenceRoot.autocomplete = autocomplete;
            Autofill autofill = new Autofill();
            preferenceRoot.autofill = autofill;
            BookmarkBar bookmarkBar = new BookmarkBar();
            preferenceRoot.bookmark_bar = bookmarkBar;
            BookmarkEditor editor = new BookmarkEditor();
            preferenceRoot.bookmark_editor = editor;
            Bookmarks bookmarks = new Bookmarks();
            preferenceRoot.bookmarks = bookmarks;
            CustomLinks customLinks = new CustomLinks();
            preferenceRoot.custom_links = customLinks;
            WindowPlacement windowPlacement = new WindowPlacement();
            windowPlacement.bottom = random.Next(700, 1000);
            windowPlacement.left = random.Next(0, 40);
            windowPlacement.right = random.Next(1500, 1920);
            windowPlacement.top = random.Next(30, 60);
            Browser browser = new Browser();
            browser.window_placement = windowPlacement;
            preferenceRoot.browser = browser;
            DomainDiversity domainDiversity = new DomainDiversity();
            preferenceRoot.domain_diversity = domainDiversity;
            GaiaCookie gaiaCookie = new GaiaCookie();
            preferenceRoot.gaia_cookie = gaiaCookie;
            Gcm gcm = new Gcm();
            preferenceRoot.gcm = gcm;
            Ahfgeienlihckogmohjhadlkjgocpleb ahfgeienlihckogmohjhadlkjgocpleb = new Ahfgeienlihckogmohjhadlkjgocpleb();
            ahfgeienlihckogmohjhadlkjgocpleb.active_permissions = new ActivePermissionsahfgeienlih();
            ahfgeienlihckogmohjhadlkjgocpleb.path = convertPathToString(currentDirectory + @"\browser\orbita-browser-115\115.0.5790.82\resources\web_store");
            Mhjfbmdgcfjbbpaeojofohoefgiehjai mhjfbmdgcfjbbpaeojofohoefgiehjai = new Mhjfbmdgcfjbbpaeojofohoefgiehjai();
            mhjfbmdgcfjbbpaeojofohoefgiehjai.path = convertPathToString(currentDirectory + @"\browser\orbita-browser-115\115.0.5790.82\resources\pdf");
            Neajdppkdcdipfabeoofebfddakdcjhd neajdppkdcdipfabeoofebfddakdcjhd = new Neajdppkdcdipfabeoofebfddakdcjhd();
            neajdppkdcdipfabeoofebfddakdcjhd.path = convertPathToString(currentDirectory + @"\browser\orbita-browser-115\115.0.5790.82\resources\network_speech_synthesis");
            Nkeimhogjdpnpccoofpliimaahmaaome nkeimhogjdpnpccoofpliimaahmaaome = new Nkeimhogjdpnpccoofpliimaahmaaome();
            nkeimhogjdpnpccoofpliimaahmaaome.path = convertPathToString(currentDirectory + @"\browser\orbita-browser-115\115.0.5790.82\resources\hangout_services");
            Settings settings = new Settings();
            settings.neajdppkdcdipfabeoofebfddakdcjhd = neajdppkdcdipfabeoofebfddakdcjhd;
            settings.nkeimhogjdpnpccoofpliimaahmaaome = nkeimhogjdpnpccoofpliimaahmaaome;
            settings.ahfgeienlihckogmohjhadlkjgocpleb = ahfgeienlihckogmohjhadlkjgocpleb;
            settings.mhjfbmdgcfjbbpaeojofohoefgiehjai = mhjfbmdgcfjbbpaeojofohoefgiehjai;
            ExtensionsPreferences extensionsPreferences = new ExtensionsPreferences();
            Alerts alerts = new Alerts();
            extensionsPreferences.alerts = alerts;
            ChromeUrlOverrides chromeUrlOverrides = new ChromeUrlOverrides();
            extensionsPreferences.chrome_url_overrides = chromeUrlOverrides;
            Commands commands = new Commands();
            WindowsCtrlShiftF windowsCtrlShiftF = new WindowsCtrlShiftF();
            commands.windowsCtrlShiftF = windowsCtrlShiftF;
            WindowsCtrlShiftQ windowsCtrlShiftQ = new WindowsCtrlShiftQ();
            commands.windowsCtrlShiftQ = windowsCtrlShiftQ;
            extensionsPreferences.commands = commands;
            extensionsPreferences.settings = settings;
            preferenceRoot.extensions = extensionsPreferences;
            Gologin gologin = new Gologin();
            gologin.plugins = new PluginsGologin();
            AudioContextPreferences audioContext = new AudioContextPreferences();
            audioContext.enable = true;
            audioContext.noiseValue = profileData.audioContext.noise;
            gologin.audioContext = audioContext;
            gologin.canvasMode = "noise";
            gologin.canvasNoise = profileData.canvas.noise;
            gologin.client_rects_noise_enable = !clientRectsNoiseEnable.ToString().ToLower().Equals("True") ? true : false;
            gologin.deviceMemory = profileData.navigator.deviceMemory * 1024;
            gologin.dns = "";
            gologin.doNotTrack = profileData.navigator.doNotTrack.ToString().ToLower().Equals("True") ? true : false;
            GeoLocationPreferences geolocation = new GeoLocationPreferences();
            geolocation.latitude = ipCheck.lat;
            geolocation.longitude = ipCheck.lon;
            geolocation.mode = profileData.geolocation.mode;
            gologin.geoLocation = geolocation;
            gologin.getClientRectsNoice = profileData.clientRects.noise;
            gologin.get_client_rects_noise = profileData.clientRects.noise;
            gologin.hardwareConcurrency = profileData.navigator.hardwareConcurrency;
            gologin.is_m1 = profileData.isM1.ToString().ToLower().Equals("True") ? true : false;
            gologin.langHeader = profileData.navigator.language;
            MediaDevicesPreferences mediaDevices = new MediaDevicesPreferences();
            mediaDevices.audioInputs = profileData.mediaDevices.audioInputs;
            mediaDevices.audioOutputs = profileData.mediaDevices.audioOutputs;
            mediaDevices.uid = profileData.mediaDevices.uid;
            mediaDevices.videoInputs = profileData.mediaDevices.videoInputs;
            mediaDevices.enable = profileData.mediaDevices.enableMasking.ToString().ToLower().Equals("True") ? true : false;
            gologin.mediaDevices = mediaDevices;
            Mobile mobile = new Mobile();
            mobile.enable = profileData.os.Equals("android") ? true : false;
            mobile.height = Int32.Parse(profileData.navigator.resolution.Split('x')[1]);
            mobile.width = Int32.Parse(profileData.navigator.resolution.Split('x')[0]);
            gologin.mobile = mobile;
            gologin.name = profileData.name;
            NavigatorPreferences navigator = new NavigatorPreferences();
            navigator.max_touch_points = 0;
            navigator.platform = profileData.navigator.platform;
            gologin.navigator = navigator;
            gologin.profile_id = profileData.id;
            ProxyPreferences proxy = new ProxyPreferences();
            proxy.password = profileData.proxy.password;
            proxy.username = profileData.proxy.username;
            gologin.proxy = proxy;
            gologin.screenHeight = Int32.Parse(profileData.navigator.resolution.Split('x')[1]);
            gologin.screenWidth = Int32.Parse(profileData.navigator.resolution.Split('x')[0]);
            TimezonePreferences timezonePreferences = new TimezonePreferences();
            timezonePreferences.id = ipCheck.timezone;
            gologin.timezone = timezonePreferences;
            gologin.userAgent = userAgent;
            WebGl webGl = new WebGl();
            webGl.mode = webGLMode.ToString().ToLower().Equals("True") ? true : false;
            webGl.renderer = profileData.webGLMetadata.renderer;
            webGl.vendor = profileData.webGLMetadata.vendor;
            gologin.webGl = webGl;
            WebRtc webRtc = new WebRtc();
            webRtc.fill_based_on_ip = profileData.webRTC.fillBasedOnIp.ToString().ToLower().Equals("True") ? true : false;
            webRtc.local_ip_masking = profileData.webRTC.localIpMasking.ToString().ToLower().Equals("True") ? true : false;
            webRtc.mode = profileData.webRTC.mode;
            webRtc.public_ip = "";
            gologin.webRtc = webRtc;
            Metadata metadata = new Metadata();
            metadata.mode = webGLMetadataMode.ToString().ToLower().Equals("True") ? true : false;
            metadata.renderer = profileData.webGLMetadata.renderer;
            metadata.vendor = profileData.webGLMetadata.vendor;
            Webgl2 webgl = new Webgl2();
            webgl.metadata = metadata;
            gologin.webgl = webgl;
            gologin.webglNoiseValue = profileData.webGL.noise;
            WebglParams webglParams = new WebglParams();
            List<string> extensions = profileData.webglParams.extensions;
            webglParams.extensions = extensions;
            List<GlParamValue> parameters = profileData.webglParams.glParamValues;
            webglParams.glParamValues = parameters;
            List<SupportedFunction> supportedFunction = profileData.webglParams.supportedFunctions;
            webglParams.supportedFunctions = supportedFunction;
            gologin.webglParams = webglParams;
            gologin.webgl_noise_value = profileData.webGL.noise;
            preferenceRoot.gologin = gologin;
            Models.Google google = new Models.Google();
            preferenceRoot.google = google;
            History history = new History();
            preferenceRoot.history = history;
            Intl intl = new Intl();
            preferenceRoot.intl = intl;
            Invalidation invalidation = new Invalidation();
            preferenceRoot.invalidation = invalidation;
            Media media = new Media();
            preferenceRoot.media = media;
            MediaRouter mediaRouter = new MediaRouter();
            preferenceRoot.media_router = mediaRouter;
            Ntp ntp = new Ntp();
            preferenceRoot.ntp = ntp;
            OptimizationGuide optimizationGuide = new OptimizationGuide();
            preferenceRoot.optimization_guide = optimizationGuide;
            PrivacySandbox privacySandbox = new PrivacySandbox();
            preferenceRoot.privacy_sandbox = privacySandbox;
            ProfilePreferences profile = new ProfilePreferences();
            preferenceRoot.profile = profile;
            Safebrowsing safebrowsing = new Safebrowsing();
            preferenceRoot.safebrowsing = safebrowsing;
            SegmentationPlatform segmentationPlatform = new SegmentationPlatform();
            preferenceRoot.segmentation_platform = segmentationPlatform;
            Sessions sessions = new Sessions();
            preferenceRoot.sessions = sessions;
            SettingsPreferences settings1 = new SettingsPreferences();
            preferenceRoot.settings = settings1;
            Signin signin = new Signin();
            preferenceRoot.signin = signin;
            Spellcheck spellcheck = new Spellcheck();
            preferenceRoot.spellcheck = spellcheck;
            SupervisedUser super = new SupervisedUser();
            preferenceRoot.supervised_user = super;
            Sync sync = new Sync();
            preferenceRoot.sync = sync;
            UnifiedConsent unifiedConsent = new UnifiedConsent();
            preferenceRoot.unified_consent = unifiedConsent;
            WebApps webApps = new WebApps();
            preferenceRoot.web_apps = webApps;
            Webauthn webauthn = new Webauthn();
            preferenceRoot.webauthn = webauthn;
            Zerosuggest zerosuggest = new Zerosuggest();
            preferenceRoot.zerosuggest = zerosuggest;
            string test1 = JsonConvert.SerializeObject(preferenceRoot);
            try
            {
                // Open the stream and read it back.
                using (StreamWriter sr = new StreamWriter(fileName))
                {
                    sr.WriteLine(test1);
                }
                Console.WriteLine("OK");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

        }
    }
}
