using Newtonsoft.Json;

namespace ebayLoginAndCheck.Models
{
    public class PreferenceRoot
    {
        public NewTabPage NewTabPage { get; set; }
        public int account_id_migration_state { get; set; } = 2;
        public string account_tracker_service_last_update { get; set; } = "13340255514044035";
        public bool ack_existing_ntp_extensions { get; set; } = true;
        public AlternateErrorPages alternate_error_pages { get; set; }
        public string announcement_notification_service_first_run_time { get; set; } = "13340295472256486";
        public AppsPreferences apps { get; set; }
        public Autocomplete autocomplete { get; set; }
        public Autofill autofill { get; set; }
        public BookmarkBar bookmark_bar { get; set; }
        public BookmarkEditor bookmark_editor { get; set; }
        public Bookmarks bookmarks { get; set; }
        public Browser browser { get; set; }
        public int countryid_at_install { get; set; } = 21077;
        public bool credentials_enable_service { get; set; } = true;
        public CustomLinks custom_links { get; set; }
        public int default_apps_install_state { get; set; } = 3;
        public string dips_timer_last_update { get; set; } = "13340307617766658";
        public DomainDiversity domain_diversity { get; set; }
        public ExtensionsPreferences extensions { get; set; }
        public GaiaCookie gaia_cookie { get; set; }
        public Gcm gcm { get; set; }
        public Gologin gologin { get; set; }
        public Google google { get; set; }
        public History history { get; set; }
        public Intl intl { get; set; }
        public Invalidation invalidation { get; set; }
        public Media media { get; set; }
        public MediaRouter media_router { get; set; }
        public Ntp ntp { get; set; }
        public OptimizationGuide optimization_guide { get; set; }
        public PrivacySandbox privacy_sandbox { get; set; }
        public ProfilePreferences profile { get; set; }
        public Safebrowsing safebrowsing { get; set; }

        public SegmentationPlatform segmentation_platform { get; set; } = new SegmentationPlatform();
        public Sessions sessions { get; set; }
        public SettingsPreferences settings { get; set; }
        public Signin signin { get; set; }
        public Spellcheck spellcheck { get; set; }
        public SupervisedUser supervised_user { get; set; }
        public Sync sync { get; set; }
        public List<object> translate_site_blacklist { get; set; } = new List<object> { };
        public TranslateSiteBlacklistWithTime translate_site_blacklist_with_time { get; set; } = new TranslateSiteBlacklistWithTime();
        public TranslateSiteBlocklistWithTime translate_site_blocklist_with_time { get; set; } = new TranslateSiteBlocklistWithTime();
        public UnifiedConsent unified_consent { get; set; }
        public WebApps web_apps { get; set; }
        public Webauthn webauthn { get; set; }
        public Zerosuggest zerosuggest { get; set; }
    }

    public class SegmentationPlatform
    {
        public DeviceSwitcherUtil device_switcher_util { get; set; } = new DeviceSwitcherUtil();
        public string last_db_compaction_time { get; set; } = "13340159999000000";
    }

    public class DeviceSwitcherUtil
    {
        public Result result { get; set; } = new Result();
    }

    public class Result
    {
        public List<string> labels { get; set; } = new List<string>() { "NotSynced" };
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class ActivePermissionsahfgeienlih
    {
        public List<string> api { get; set; } = new List<string>() { "management",
            "system.display",
            "system.storage",
            "webstorePrivate",
            "system.cpu",
            "system.memory",
            "system.network"};
        public List<object> explicit_host { get; set; } = new List<object>();
        public List<object> manifest_permissions { get; set; } = new List<object>();
        public List<object> scriptable_host { get; set; } = new List<object>();
    }

    public class Ahfgeienlihckogmohjhadlkjgocpleb
    {
        public ActivePermissionsahfgeienlih active_permissions { get; set; } = new ActivePermissionsahfgeienlih();
        public string app_launcher_ordinal { get; set; } = "t";
        public CommandsExtensions commands { get; set; } = new CommandsExtensions();
        public List<object> content_settings { get; set; } = new List<object>();
        public int creation_flags { get; set; } = 1;
        public List<object> events { get; set; } = new List<object>();
        public string first_install_time { get; set; } = "13340295472257337";
        public bool from_webstore { get; set; } = false;
        public List<object> incognito_content_settings { get; set; } = new List<object>();
        public IncognitoPreferences incognito_preferences { get; set; } = new IncognitoPreferences();
        public string last_update_time { get; set; } = "13340295472257337";
        public int location { get; set; } = 5;
        public Manifestahfgeienlih manifest { get; set; } = new Manifestahfgeienlih();
        public bool needs_sync { get; set; } = true;
        public string page_ordinal { get; set; } = "n";
        public string path { get; set; }
        public Preferences preferences { get; set; } = new Preferences();
        public RegularOnlyPreferences regular_only_preferences { get; set; } = new RegularOnlyPreferences();
        public int state { get; set; } = 1;
        public bool was_installed_by_default { get; set; } = false;
        public bool was_installed_by_oem { get; set; } = false;
    }

    public class Alerts
    {
        public bool initialized { get; set; } = true;
    }

    public class App
    {
        public Launch launch { get; set; } = new Launch();
        public List<string> urls { get; set; } = new List<string>() { "https://chrome.google.com/webstore" };
    }

    public class Background
    {
        public bool persistent { get; set; }
        public List<string> scripts { get; set; }
        public string page { get; set; }
    }

    public class Commands
    {
        [JsonProperty("windows:Ctrl+Shift+F")]
        public WindowsCtrlShiftF windowsCtrlShiftF { get; set; } = new WindowsCtrlShiftF();

        [JsonProperty("windows:Ctrl+Shift+Q")]
        public WindowsCtrlShiftQ windowsCtrlShiftQ { get; set; } = new WindowsCtrlShiftQ();
    }

    public class CommandsExtensions
    {

    }

    public class ExtensionsPreferences
    {
        public Alerts alerts { get; set; } = new Alerts();
        public ChromeUrlOverrides chrome_url_overrides { get; set; } = new ChromeUrlOverrides();
        public Commands commands { get; set; } = new Commands();
        public string last_chrome_version { get; set; } = "115.0.5790.82";
        public Settings settings { get; set; } = new Settings();
    }

    public class ExternallyConnectable
    {
        public List<string> matches { get; set; } = new List<string> { "https://*.google.com/*" };
    }

    public class Icons
    {
        [JsonProperty("16")]
        public string _16 { get; set; } = "webstore_icon_16.png";

        [JsonProperty("128")]
        public string _128 { get; set; } = "webstore_icon_128.png";
    }

    public class IncognitoPreferences
    {
    }

    public class Launch
    {
        public string web_url { get; set; } = "https://chrome.google.com/webstore";
    }

    public class Manifestahfgeienlih
    {
        public App app { get; set; } = new App();
        public string description { get; set; } = "Discover great apps, games, extensions and themes for Orbita.";
        public Icons icons { get; set; } = new Icons();
        public string key { get; set; } = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCtl3tO0osjuzRsf6xtD2SKxPlTfuoy7AWoObysitBPvH5fE1NaAA1/2JkPWkVDhdLBWLaIBPYeXbzlHp3y4Vv/4XG+aN5qFE3z+1RU/NqkzVYHtIpVScf3DjTYtKVL66mzVGijSoAIwbFCC3LpGdaoe6Q1rSRDp76wR6jjFzsYwQIDAQAB";
        public string name { get; set; } = "Web Store";
        public List<string> permissions { get; set; } = new List<string>() {"webstorePrivate",
            "management",
            "system.cpu",
            "system.display",
            "system.memory",
            "system.network",
            "system.storage" };
        public string version { get; set; } = "0.2";

    }
    public class ActivePermissionsMhjfbmdgc
    {
        public List<string> api { get; set; } = new List<string>() { "contentSettings",
            "fileSystem",
            "fileSystem.write",
            "metricsPrivate",
            "tabs",
            "resourcesPrivate",
            "pdfViewerPrivate"};
        public List<object> explicit_host { get; set; } = new List<object>() { "chrome://resources/*",
            "chrome://webui-test/*"};
        public List<object> manifest_permissions { get; set; } = new List<object>();
        public List<object> scriptable_host { get; set; } = new List<object>();
    }

    public class ManifestMhjfbmdgcfj
    {
        public string content_security_policy { get; set; } = "script-src 'self' 'wasm-eval' blob: filesystem: chrome://resources chrome://webui-test; object-src * blob: externalfile: file: filesystem: data:";
        public string description { get; set; } = "";
        public string incognito { get; set; } = "split";
        public string key { get; set; } = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDN6hM0rsDYGbzQPQfOygqlRtQgKUXMfnSjhIBL7LnReAVBEd7ZmKtyN2qmSasMl4HZpMhVe2rPWVVwBDl6iyNE/Kok6E6v6V3vCLGsOpQAuuNVye/3QxzIldzG/jQAdWZiyXReRVapOhZtLjGfywCvlWq7Sl/e3sbc0vWybSDI2QIDAQAB";
        public int manifest_version { get; set; } = 2;
        public List<string> mime_types { get; set; } = new List<string>() { "application/pdf" };
        public string mime_types_handler { get; set; } = "index.html";
        public string name { get; set; } = "Chromium PDF Viewer";
        public bool offline_enabled { get; set; } = true;
        public List<object> permissions { get; set; } = new List<object>() {
            "chrome://resources/",
            "chrome://webui-test/",
            "contentSettings",
            "metricsPrivate",
            "pdfViewerPrivate",
            "resourcesPrivate",
            "tabs",
            new Rootpermissions{fileSystem= new List<string>(){"write" } }
        };
        public string version { get; set; } = "1";
    }

    public class Rootpermissions
    {
        public List<string> fileSystem { get; set; }
    }



    public class Mhjfbmdgcfjbbpaeojofohoefgiehjai
    {
        public ActivePermissionsMhjfbmdgc active_permissions { get; set; } = new ActivePermissionsMhjfbmdgc();
        public CommandsExtensions commands { get; set; } = new CommandsExtensions();
        public List<object> content_settings { get; set; } = new List<object>() { };
        public int creation_flags { get; set; } = 1;
        public List<object> events { get; set; } = new List<object>() { };
        public string first_install_time { get; set; } = "13340295472258159";
        public bool from_webstore { get; set; } = false;
        public List<object> incognito_content_settings { get; set; } = new List<object>() { };
        public IncognitoPreferences incognito_preferences { get; set; } = new IncognitoPreferences();
        public string last_update_time { get; set; } = "13340295472258159";
        public int location { get; set; } = 5;
        public ManifestMhjfbmdgcfj manifest { get; set; } = new ManifestMhjfbmdgcfj();
        public string path { get; set; }
        public Preferences preferences { get; set; } = new Preferences();
        public RegularOnlyPreferences regular_only_preferences { get; set; } = new RegularOnlyPreferences();
        public int state { get; set; } = 1;
        public bool was_installed_by_default { get; set; } = false;
        public bool was_installed_by_oem { get; set; } = false;
    }

    public class ActivePermissionsNeajdppkdc
    {
        public List<string> api { get; set; } = new List<string>() {
            "systemPrivate",
            "ttsEngine"};
        public List<object> explicit_host { get; set; } = new List<object>() { "https://www.google.com/*" };
        public List<object> manifest_permissions { get; set; } = new List<object>();
        public List<object> scriptable_host { get; set; } = new List<object>();
    }

    public class ManifestNeajdppkdcdip
    {
        public BackgroundNeajdppkdcdip background { get; set; } = new BackgroundNeajdppkdcdip();
        public string description { get; set; } = "Component extension providing speech via the Google network text-to-speech service.";
        public string key { get; set; } = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEA8GSbNUMGygqQTNDMFGIjZNcwXsHLzkNkHjWbuY37PbNdSDZ4VqlVjzbWqODSe+MjELdv5Keb51IdytnoGYXBMyqKmWpUrg+RnKvQ5ibWr4MW9pyIceOIdp9GrzC1WZGgTmZismYR3AjaIpufZ7xDdQQv+XrghPWCkdVqLN+qZDA1HU+DURznkMICiDDSH2sU0egm9UbWfS218bZqzKeQDiC3OnTPlaxcbJtKUuupIm5knjze3Wo9Ae9poTDMzKgchg0VlFCv3uqox+wlD8sjXBoyBCCK9HpImdVAF1a7jpdgiUHpPeV/26oYzM9/grltwNR3bzECQgSpyXp0eyoegwIDAQAB";
        public int manifest_version { get; set; } = 2;
        public string name { get; set; } = "Google Network Speech";
        public List<string> permissions { get; set; } = new List<string>() { "systemPrivate",
            "ttsEngine",
            "https://www.google.com/"};
        public TtsEngine tts_engine { get; set; } = new TtsEngine();
        public string version { get; set; } = "1.0";
    }

    public class BackgroundNeajdppkdcdip
    {
        public bool persistent { get; set; } = false;
        public List<string> scripts { get; set; } = new List<string> { "tts_extension.js" };
    }

    public class Neajdppkdcdipfabeoofebfddakdcjhd
    {
        public ActivePermissionsNeajdppkdc active_permissions { get; set; } = new ActivePermissionsNeajdppkdc();
        public CommandsExtensions commands { get; set; } = new CommandsExtensions();
        public List<object> content_settings { get; set; } = new List<object>() { };
        public int creation_flags { get; set; } = 1;
        public List<string> events { get; set; } = new List<string> {"ttsEngine.onPause",
          "ttsEngine.onResume",
          "ttsEngine.onSpeak",
          "ttsEngine.onStop" };
        public string first_install_time { get; set; } = "13340295472259240";
        public bool from_webstore { get; set; } = false;
        public List<object> incognito_content_settings { get; set; } = new List<object> { };
        public IncognitoPreferences incognito_preferences { get; set; } = new IncognitoPreferences();
        public string last_update_time { get; set; } = "13340295472259240";
        public int location { get; set; } = 5;
        public ManifestNeajdppkdcdip manifest { get; set; } = new ManifestNeajdppkdcdip();
        public string path { get; set; }
        public Preferences preferences { get; set; } = new Preferences();
        public RegularOnlyPreferences regular_only_preferences { get; set; } = new RegularOnlyPreferences();
        public int state { get; set; } = 1;
        public bool was_installed_by_default { get; set; } = false;
        public bool was_installed_by_oem { get; set; } = false;
    }

    public class ActivePermissionsNkeimhogjdpnp
    {
        public List<string> api { get; set; } = new List<string>() {
            "desktopCapture",
            "processes",
            "webrtcAudioPrivate",
            "webrtcDesktopCapturePrivate",
            "webrtcLoggingPrivate",
            "system.cpu",
            "enterprise.hardwarePlatform"};
        public List<object> explicit_host { get; set; } = new List<object>() { };
        public List<object> manifest_permissions { get; set; } = new List<object>();
        public List<object> scriptable_host { get; set; } = new List<object>();
    }

    public class BackgroundNkeimhogjdpnp
    {
        public string page { get; set; } = "background.html";
        public bool persistent { get; set; } = false;
    }

    public class ManifestNkeimhogjdpnp
    {
        public BackgroundNkeimhogjdpnp background { get; set; } = new BackgroundNkeimhogjdpnp();
        public ExternallyConnectable externally_connectable { get; set; } = new ExternallyConnectable();
        public string incognito { get; set; } = "split";
        public string key { get; set; } = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDAQt2ZDdPfoSe/JI6ID5bgLHRCnCu9T36aYczmhw/tnv6QZB2I6WnOCMZXJZlRdqWc7w9jo4BWhYS50Vb4weMfh/I0On7VcRwJUgfAxW2cHB+EkmtI1v4v/OU24OqIa1Nmv9uRVeX0GjhQukdLNhAE6ACWooaf5kqKlCeK+1GOkQIDAQAB";
        public int manifest_version { get; set; } = 2;
        public string name { get; set; } = "Google Hangouts";
        public List<string> permissions { get; set; } = new List<string> {"desktopCapture",
            "enterprise.hardwarePlatform",
            "processes",
            "system.cpu",
            "webrtcAudioPrivate",
            "webrtcDesktopCapturePrivate",
            "webrtcLoggingPrivate" };
        public string version { get; set; } = "1.3.21";
    }

    public class Nkeimhogjdpnpccoofpliimaahmaaome
    {
        public ActivePermissionsNkeimhogjdpnp active_permissions { get; set; } = new ActivePermissionsNkeimhogjdpnp();
        public CommandsExtensions commands { get; set; } = new CommandsExtensions();
        public List<object> content_settings { get; set; } = new List<object> { };
        public int creation_flags { get; set; } = 1;
        public List<string> events { get; set; } = new List<string> { "runtime.onConnectExternal" };
        public string first_install_time { get; set; } = "13340295472258712";
        public bool from_webstore { get; set; } = false;
        public List<object> incognito_content_settings { get; set; } = new List<object> { };
        public IncognitoPreferences incognito_preferences { get; set; } = new IncognitoPreferences();
        public string last_update_time { get; set; } = "13340295472258712";
        public int location { get; set; } = 5;
        public ManifestNkeimhogjdpnp manifest { get; set; } = new ManifestNkeimhogjdpnp();
        public string path { get; set; }
        public Preferences preferences { get; set; } = new Preferences();
        public RegularOnlyPreferences regular_only_preferences { get; set; } = new RegularOnlyPreferences();
        public int state { get; set; } = 1;
        public bool was_installed_by_default { get; set; } = false;
        public bool was_installed_by_oem { get; set; } = false;
    }

    public class Preferences
    {
    }

    public class SettingsPreferences
    {
        public A11y a11y { get; set; } = new A11y();
    }

    public class RegularOnlyPreferences
    {
    }

    public class Settings
    {
        public Ahfgeienlihckogmohjhadlkjgocpleb ahfgeienlihckogmohjhadlkjgocpleb { get; set; }
        public Mhjfbmdgcfjbbpaeojofohoefgiehjai mhjfbmdgcfjbbpaeojofohoefgiehjai { get; set; }
        public Neajdppkdcdipfabeoofebfddakdcjhd neajdppkdcdipfabeoofebfddakdcjhd { get; set; }
        public Nkeimhogjdpnpccoofpliimaahmaaome nkeimhogjdpnpccoofpliimaahmaaome { get; set; }
    }

    public class TtsEngine
    {
        public List<Voice> voices { get; set; } = new List<Voice>() {
              new Voice{
                event_types = new List<string>{
                  "start",
                  "end",
                  "error"
                },
                gender= "female",
                lang= "de-DE",
                remote= true,
                voice_name= "Google Deutsch"
              },
              new Voice{
                event_types= new List<string>{
                  "start",
                  "end",
                  "error"
                },
                gender= "female",
                lang= "en-US",
                remote= true,
                voice_name= "Google US English"
              },
              new Voice{
                event_types= new List<string>{
                  "start",
                  "end",
                  "error"
                },
                gender= "female",
                lang= "en-GB",
                remote= true,
                voice_name= "Google UK English Female"
              },
              new Voice{
                event_types= new List<string>{
                  "start",
                  "end",
                  "error"
                },
                gender= "male",
                lang= "en-GB",
                remote= true,
                voice_name= "Google UK English Male"
              },
              new Voice{
                event_types= new List<string>{
                  "start",
                  "end",
                  "error"
                },
                gender= "female",
                lang= "es-ES",
                remote= true,
                voice_name= "Google español"
              },
              new Voice{
                event_types= new List<string>{
                  "start",
                  "end",
                  "error"
                },
                gender= "female",
                lang= "es-US",
                remote= true,
                voice_name= "Google español de Estados Unidos"
              },
              new Voice{
                event_types= new List<string>{
                  "start",
                  "end",
                  "error"
                },
                gender= "female",
                lang= "fr-FR",
                remote= true,
                voice_name= "Google français"
              },
              new Voice{
                event_types= new List<string>{
                  "start",
                  "end",
                  "error"
                },
                gender= "female",
                lang= "hi-IN",
                remote= true,
                voice_name= "Google हिन्दी"
              },
              new Voice{
                event_types= new List<string>{
                  "start",
                  "end",
                  "error"
                },
                gender= "female",
                lang= "id-ID",
                remote= true,
                voice_name= "Google Bahasa Indonesia"
              },
              new Voice{
                event_types= new List<string>{
                  "start",
                  "end",
                  "error"
                },
                gender= "female",
                lang= "it-IT",
                remote= true,
                voice_name= "Google italiano"
              },
              new Voice{
                event_types= new List<string>{
                  "start",
                  "end",
                  "error"
                },
                gender= "female",
                lang= "ja-JP",
                remote= true,
                voice_name= "Google 日本語"
              },
              new Voice{
                event_types= new List<string>{
                  "start",
                  "end",
                  "error"
                },
                gender= "female",
                lang= "ko-KR",
                remote= true,
                voice_name= "Google 한국의"
              },
              new Voice{
                event_types= new List<string>{
                  "start",
                  "end",
                  "error"
                },
                gender= "female",
                lang= "nl-NL",
                remote= true,
                voice_name= "Google Nederlands"
              },
              new Voice{
                event_types= new List<string>{
                  "start",
                  "end",
                  "error"
                },
                gender= "female",
                lang= "pl-PL",
                remote= true,
                voice_name= "Google polski"
              },
              new Voice{
                event_types= new List<string>{
                  "start",
                  "end",
                  "error"
                },
                gender= "female",
                lang= "pt-BR",
                remote= true,
                voice_name= "Google português do Brasil"
              },
              new Voice{
                event_types= new List<string>{
                  "start",
                  "end",
                  "error"
                },
                gender= "female",
                lang= "ru-RU",
                remote= true,
                voice_name= "Google русский"
              },
              new Voice{
                event_types= new List<string>{
                  "start",
                  "end",
                  "error"
                },
                gender= "female",
                lang= "zh-CN",
                remote= true,
                voice_name= "Google 普通话（中国大陆）"
              },
              new Voice{
                event_types= new List<string>{
                  "start",
                  "end",
                  "error"
                },
                gender= "female",
                lang= "zh-HK",
                remote= true,
                voice_name= "Google 粤語（香港）"
              },
              new Voice{
                event_types= new List<string>{
                  "start",
                  "end",
                  "error"
                },
                gender= "female",
                lang= "zh-TW",
                remote= true,
                voice_name= "Google 國語（臺灣）"
              }
        };
    }

    public class Voice
    {
        public List<string> event_types { get; set; }
        public string gender { get; set; }
        public string lang { get; set; }
        public bool remote { get; set; }
        public string voice_name { get; set; }
    }

    public class WindowsCtrlShiftF
    {
        public string command_name { get; set; } = "humanTyping";
        public string extension { get; set; } = "mcbnaiajkcblmmgpioceilinjjlhgfdj";
        public bool global { get; set; } = false;
    }

    public class WindowsCtrlShiftQ
    {
        public string command_name { get; set; } = "automationTask";
        public string extension { get; set; } = "mcbnaiajkcblmmgpioceilinjjlhgfdj";
        public bool global { get; set; } = false;
    }




    public class _1013309121859
    {
    }

    public class _8181035976
    {
    }

    public class A11y
    {
        public bool apply_page_colors_only_on_increased_contrast { get; set; } = true;
    }

    public class AccessibilityEvents
    {
    }


    public class AlternateErrorPages
    {
        public bool backup { get; set; } = true;
    }

    public class AntiAbuse
    {
    }

    public class AppBanner
    {
    }

    public class AppsPreferences
    {
        public string shortcuts_arch { get; set; } = "";
        public int shortcuts_version { get; set; } = 0;
    }

    public class Ar
    {
    }

    public class Autocomplete
    {
        public int retention_policy_last_version { get; set; } = 115;
    }

    public class Autofill
    {
        public bool orphan_rows_removed { get; set; } = true;
    }

    public class AutomaticDownloads
    {
    }

    public class Autoplay
    {
    }

    public class AutoSelectCertificate
    {
    }

    public class BackgroundSync
    {
    }

    public class BluetoothChooserData
    {
    }

    public class BluetoothGuard
    {
    }

    public class BluetoothScanning
    {
    }

    public class BookmarkBar
    {
        public bool show_on_all_tabs { get; set; } = false;
    }

    public class BookmarkEditor
    {
        public List<object> expanded_nodes { get; set; } = new List<object>() { };
    }

    public class Bookmarks
    {
        public bool editing_enabled { get; set; } = true;
    }

    public class Browser
    {
        public bool enable_spellchecking { get; set; } = false;
        public bool has_seen_welcome_page { get; set; } = true;
        public bool should_reset_check_default_browser { get; set; } = false;
        public WindowPlacement window_placement { get; set; }
    }

    public class CameraPanTiltZoom
    {
    }

    public class ChromeUrlOverrides
    {
    }

    public class ClientHints
    {
        [JsonProperty("https://iphey.com:443,*")]
        public HttpsIpheyCom443 httpsipheycom443 { get; set; } = new HttpsIpheyCom443();
    }

    public class Clipboard
    {
    }

    public class ContentSettings
    {
        public EnableQuietPermissionUiEnablingMethod enable_quiet_permission_ui_enabling_method { get; set; } = new EnableQuietPermissionUiEnablingMethod();
        public Exceptions exceptions { get; set; } = new Exceptions();
        public int pref_version { get; set; } = 1;
    }

    public class Cookies
    {
    }

    public class CustomLinkObject
    {
        public bool isMostVisited { get; set; }
        public string title { get; set; }
        public string url { get; set; }
    }

    public class CustomLinks
    {
        public bool initialized { get; set; } = true;
        public List<CustomLinkObject> list { get; set; } = new List<CustomLinkObject> {
            new CustomLinkObject{isMostVisited= false,title= "Facebook",url= "https://www.facebook.com/"},
            new CustomLinkObject{isMostVisited= false,title= "Google Ads",url= "https://ads.google.com/"},
            new CustomLinkObject{
            isMostVisited= false,
            title= "TikTok",
            url= "https://www.tiktok.com/"
            },
            new CustomLinkObject{
            isMostVisited= false,
            title= "Amazon",
            url= "https://www.amazon.com/"
            },
            new CustomLinkObject{
            isMostVisited= false,
            title= "eBay",
            url= "https://ebay.com/"
            },
            new CustomLinkObject{
            isMostVisited= false,
            title= "YouTube",
            url= "https://www.youtube.com/"
            },
            new CustomLinkObject{
            isMostVisited= false,
            title= "Coinlist",
            url= "https://coinlist.co/"
            },
            new CustomLinkObject{
            isMostVisited= false,
            title= "Huobi",
            url= "https://www.huobi.com/"
            },
            new CustomLinkObject{
            isMostVisited= false,
            title= "bet365",
            url= "https://www.bet365.com/"
            },
            new CustomLinkObject{
            isMostVisited= false,
            title= "PayPal",
            url= "https://paypal.com/"
            }
        };
    }

    public class DomainDiversity
    {
        public string last_reporting_timestamp { get; set; } = "13340307617901261";
    }

    public class DurableStorage
    {
    }

    public class EnableQuietPermissionUiEnablingMethod
    {
        public int notifications { get; set; } = 1;
    }

    public class Engagement
    {
        public int schema_version { get; set; } = 5;
    }

    public class EventLog
    {
        public bool crashed { get; set; }
        public string time { get; set; }
        public int type { get; set; }
    }

    public class EventTimestamps
    {
    }

    public class Exceptions
    {
        public AccessibilityEvents accessibility_events { get; set; } = new AccessibilityEvents();
        public AntiAbuse anti_abuse { get; set; } = new AntiAbuse();
        public AppBanner app_banner { get; set; } = new AppBanner();
        public Ar ar { get; set; } = new Ar();
        public AutoSelectCertificate auto_select_certificate { get; set; } = new AutoSelectCertificate();
        public AutomaticDownloads automatic_downloads { get; set; } = new AutomaticDownloads();
        public Autoplay autoplay { get; set; } = new Autoplay();
        public BackgroundSync background_sync { get; set; } = new BackgroundSync();
        public BluetoothChooserData bluetooth_chooser_data { get; set; } = new BluetoothChooserData();
        public BluetoothGuard bluetooth_guard { get; set; } = new BluetoothGuard();
        public BluetoothScanning bluetooth_scanning { get; set; } = new BluetoothScanning();
        public CameraPanTiltZoom camera_pan_tilt_zoom { get; set; } = new CameraPanTiltZoom();
        public ClientHints client_hints { get; set; } = new ClientHints();
        public Clipboard clipboard { get; set; } = new Clipboard();
        public Cookies cookies { get; set; } = new Cookies();
        public DurableStorage durable_storage { get; set; } = new DurableStorage();
        public FedcmActiveSession fedcm_active_session { get; set; } = new FedcmActiveSession();
        public FedcmIdpRegistration fedcm_idp_registration { get; set; } = new FedcmIdpRegistration();
        public FedcmIdpSignin fedcm_idp_signin { get; set; } = new FedcmIdpSignin();
        public FedcmShare fedcm_share { get; set; } = new FedcmShare();
        public FileSystemAccessChooserData file_system_access_chooser_data { get; set; } = new FileSystemAccessChooserData();
        public FileSystemLastPickedDirectory file_system_last_picked_directory { get; set; } = new FileSystemLastPickedDirectory();
        public FileSystemReadGuard file_system_read_guard { get; set; } = new FileSystemReadGuard();
        public FileSystemWriteGuard file_system_write_guard { get; set; } = new FileSystemWriteGuard();
        public FormfillMetadata formfill_metadata { get; set; } = new FormfillMetadata();
        public GeolocationExceptions geolocation { get; set; } = new GeolocationExceptions();
        public GetDisplayMediaSetSelectAllScreens get_display_media_set_select_all_screens { get; set; } = new GetDisplayMediaSetSelectAllScreens();
        public HidChooserData hid_chooser_data { get; set; } = new HidChooserData();
        public HidGuard hid_guard { get; set; } = new HidGuard();
        public HttpAllowed http_allowed { get; set; } = new HttpAllowed();
        public HttpsEnforced https_enforced { get; set; } = new HttpsEnforced();
        public IdleDetection idle_detection { get; set; } = new IdleDetection();
        public Images images { get; set; } = new Images();
        public ImportantSiteInfo important_site_info { get; set; } = new ImportantSiteInfo();
        public InsecurePrivateNetwork insecure_private_network { get; set; } = new InsecurePrivateNetwork();
        public IntentPickerAutoDisplay intent_picker_auto_display { get; set; } = new IntentPickerAutoDisplay();
        public Javascript javascript { get; set; } = new Javascript();
        public JavascriptJit javascript_jit { get; set; } = new JavascriptJit();
        public LegacyCookieAccess legacy_cookie_access { get; set; } = new LegacyCookieAccess();
        public LocalFonts local_fonts { get; set; } = new LocalFonts();
        public MediaEngagement media_engagement { get; set; } = new MediaEngagement();
        public MediaStreamCamera media_stream_camera { get; set; } = new MediaStreamCamera();
        public MediaStreamMic media_stream_mic { get; set; } = new MediaStreamMic();
        public MidiSysex midi_sysex { get; set; } = new MidiSysex();
        public MixedScript mixed_script { get; set; } = new MixedScript();
        public NfcDevices nfc_devices { get; set; } = new NfcDevices();
        public NotificationInteractions notification_interactions { get; set; } = new NotificationInteractions();
        public NotificationPermissionReview notification_permission_review { get; set; } = new NotificationPermissionReview();
        public Notifications notifications { get; set; } = new Notifications();
        public PasswordProtection password_protection { get; set; } = new PasswordProtection();
        public PaymentHandler payment_handler { get; set; } = new PaymentHandler();
        public PermissionAutoblockingData permission_autoblocking_data { get; set; } = new PermissionAutoblockingData();
        public PermissionAutorevocationData permission_autorevocation_data { get; set; } = new PermissionAutorevocationData();
        public Popups popups { get; set; } = new Popups();
        public PrivateNetworkChooserData private_network_chooser_data { get; set; } = new PrivateNetworkChooserData();
        public PrivateNetworkGuard private_network_guard { get; set; } = new PrivateNetworkGuard();
        public ProtectedMediaIdentifier protected_media_identifier { get; set; } = new ProtectedMediaIdentifier();
        public ProtocolHandler protocol_handler { get; set; } = new ProtocolHandler();
        public ReducedAcceptLanguage reduced_accept_language { get; set; } = new ReducedAcceptLanguage();
        public SafeBrowsingUrlCheckData safe_browsing_url_check_data { get; set; } = new SafeBrowsingUrlCheckData();
        public Sensors sensors { get; set; } = new Sensors();
        public SerialChooserData serial_chooser_data { get; set; } = new SerialChooserData();
        public SerialGuard serial_guard { get; set; } = new SerialGuard();
        public SiteEngagement site_engagement { get; set; } = new SiteEngagement();
        public Sound sound { get; set; } = new Sound();
        public SslCertDecisions ssl_cert_decisions { get; set; } = new SslCertDecisions();
        public StorageAccess storage_access { get; set; } = new StorageAccess();
        public SubresourceFilter subresource_filter { get; set; } = new SubresourceFilter();
        public SubresourceFilterData subresource_filter_data { get; set; } = new SubresourceFilterData();
        public ThirdPartyStoragePartitioning third_party_storage_partitioning { get; set; } = new ThirdPartyStoragePartitioning();
        public TopLevelStorageAccess top_level_storage_access { get; set; } = new TopLevelStorageAccess();
        public UnusedSitePermissions unused_site_permissions { get; set; } = new UnusedSitePermissions();
        public UsbChooserData usb_chooser_data { get; set; } = new UsbChooserData();
        public UsbGuard usb_guard { get; set; } = new UsbGuard();
        public Vr vr { get; set; } = new Vr();
        public WebidApi webid_api { get; set; } = new WebidApi();
        public WebidAutoReauthn webid_auto_reauthn { get; set; } = new WebidAutoReauthn();
        public WindowPlacementExceptions window_placement { get; set; } = new WindowPlacementExceptions();
    }

    public class FedcmActiveSession
    {
    }

    public class FedcmIdpRegistration
    {
    }

    public class WindowPlacementExceptions { }

    public class GeolocationExceptions
    {

    }
    public class FedcmIdpSignin
    {
    }

    public class FedcmShare
    {
    }

    public class FileSystemAccessChooserData
    {
    }

    public class FileSystemLastPickedDirectory
    {
    }

    public class FileSystemReadGuard
    {
    }

    public class FileSystemWriteGuard
    {
    }

    public class FormfillMetadata
    {
    }

    public class GaiaCookie
    {
        public double changed_time { get; set; } = 1658333661.108506;
        public string hash { get; set; } = "2jmj7l5rSw0yVb/vlWAYkK/YBwk=";
        public string last_list_accounts_data { get; set; } = "[\"gaia.l.a.r\",[]]";
    }

    public class Gcm
    {
        public string product_category_for_subtypes { get; set; } = "com.orbita.macosx";
    }

    public class GeoLocationPreferences
    {
        public int accuracy { get; set; } = 100;
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string mode { get; set; }
    }

    public class Geolocation2
    {
    }

    public class GetDisplayMediaSetSelectAllScreens
    {
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AudioContextPreferences
    {
        public bool enable { get; set; }
        public double noiseValue { get; set; }
    }



    public class Gologin
    {
        public AudioContextPreferences audioContext { get; set; }
        public string canvasMode { get; set; }
        public double canvasNoise { get; set; }
        public bool client_rects_noise_enable { get; set; }
        public int deviceMemory { get; set; }
        public string dns { get; set; }
        public bool doNotTrack { get; set; }
        public GeoLocationPreferences geoLocation { get; set; }
        public double getClientRectsNoice { get; set; }
        public double get_client_rects_noise { get; set; }
        public int hardwareConcurrency { get; set; }
        public bool is_m1 { get; set; } = false;
        public string langHeader { get; set; }
        public string languages { get; set; } = "en-US,en";
        public MediaDevicesPreferences mediaDevices { get; set; }
        public Mobile mobile { get; set; }
        public string name { get; set; }
        public NavigatorPreferences navigator { get; set; }
        public PluginsGologin plugins { get; set; }
        public string profile_id { get; set; }
        public ProxyPreferences proxy { get; set; }
        public int screenHeight { get; set; }
        public int screenWidth { get; set; }
        public string startupUrl { get; set; } = "";
        public List<string> startup_urls { get; set; } = new List<string> { };
        public StoragePreferences storage { get; set; } = new StoragePreferences();
        public TimezonePreferences timezone { get; set; }
        public List<string> unpinable_extension_names { get; set; } = new List<string> { "passwords-ext" };
        public string userAgent { get; set; }
        public WebGl webGl { get; set; }
        public WebRtc webRtc { get; set; }
        public Webgl2 webgl { get; set; }
        public bool webglNoiceEnable { get; set; } = false;
        public double webglNoiseValue { get; set; }
        public WebglParams webglParams { get; set; }
        public bool webgl_noice_enable { get; set; } = false;
        public bool webgl_noise_enable { get; set; } = false;
        public double webgl_noise_value { get; set; }
    }

    public class TimezonePreferences
    {
        public string id { get; set; }
    }

    public class StoragePreferences
    {
        public bool enable { get; set; } = true;
    }

    public class ProxyPreferences
    {
        public string password { get; set; }
        public string username { get; set; }
    }


    public class NavigatorPreferences
    {
        public int max_touch_points { get; set; }
        public string platform { get; set; }
    }

    public class MediaDevicesPreferences
    {
        public bool enable { get; set; }
        public int videoInputs { get; set; }
        public int audioInputs { get; set; }
        public int audioOutputs { get; set; }
        public string uid { get; set; }
    }

    public class PluginsGologin
    {
        public bool all_enable { get; set; } = true;

        public bool flash_enable { get; set; } = true;
    }

    public class Google
    {
        public Services services { get; set; } = new Services();
    }

    public class HidChooserData
    {
    }

    public class HidGuard
    {
    }

    public class History
    {
        public bool saving_disabled { get; set; } = false;
    }

    public class HttpAllowed
    {
    }

    public class HttpsEnforced
    {
    }


    public class IdleDetection
    {
    }

    public class Images
    {
    }

    public class ImportantSiteInfo
    {
    }


    public class InsecurePrivateNetwork
    {
    }

    public class IntentPickerAutoDisplay
    {
    }

    public class Intl
    {
        public string accept_languages { get; set; } = "en-US,en";
        public string selected_languages { get; set; } = "en-US,en";
    }

    public class Invalidation
    {
        public PerSenderTopicsToHandler per_sender_topics_to_handler { get; set; } = new PerSenderTopicsToHandler();
    }

    public class Javascript
    {
    }

    public class JavascriptJit
    {
    }

    public class LegacyCookieAccess
    {
    }

    public class List
    {
        public bool isMostVisited { get; set; }
        public string title { get; set; }
        public string url { get; set; }
    }

    public class LocalFonts
    {
    }

    public class Managed
    {
        public int banner_state { get; set; } = 2;
    }

    public class Media
    {
        public string device_id_salt { get; set; } = "9246CFB4087E47F5724693E39B959ECE";
        public Engagement engagement { get; set; } = new Engagement();
    }

    public class MediaEngagement
    {
    }

    public class MediaRouter
    {
        public string receiver_id_hash_token { get; set; } = "TD5WRlbzbmfauxtSP+dr6puFLclkMy4UrYw1Z0r5APrnQtE5WAsfnUPvGXxBa/lH7F/NC/FTYHzOOzbplCKTyA==";
    }

    public class MediaStreamCamera
    {
    }

    public class MediaStreamMic
    {
    }

    public class Metadata
    {
        public bool mode { get; set; }
        public string renderer { get; set; }
        public string vendor { get; set; }
    }

    public class Metrics
    {
        public int day_id { get; set; } = 154401;
    }

    public class MidiSysex
    {
    }

    public class MixedScript
    {
    }

    public class Mobile
    {
        public double device_scale_factor { get; set; } = 1.25;
        public bool enable { get; set; } = false;
        public int height { get; set; }
        public int width { get; set; }
    }

    public class NewTabPage
    {
        public string PrevNavigationTime { get; set; } = "13340255513988093";
    }

    public class NfcDevices
    {
    }


    public class NotificationInteractions
    {
    }

    public class NotificationPermissionReview
    {
    }

    public class Notifications
    {
    }

    public class Ntp
    {
        public int num_personal_suggestions { get; set; } = 10;
    }

    public class Predictionmodelfetcher
    {
        public string last_fetch_attempt { get; set; } = "13340307809732695";
    }

    public class OptimizationGuide
    {
        public Predictionmodelfetcher predictionmodelfetcher { get; set; } = new Predictionmodelfetcher();
        public PreviouslyRegisteredOptimizationTypes previously_registered_optimization_types { get; set; } = new PreviouslyRegisteredOptimizationTypes();
        public StoreFilePathsToDelete store_file_paths_to_delete { get; set; } = new StoreFilePathsToDelete();
    }

    public class PasswordAccountStorageSettings
    {
    }

    public class PasswordProtection
    {
    }

    public class PaymentHandler
    {
    }

    public class PermissionAutoblockingData
    {
    }

    public class PermissionAutorevocationData
    {
    }

    public class PerSenderTopicsToHandler
    {
        [JsonProperty("1013309121859")]
        public _1013309121859 _1013309121859 { get; set; } = new _1013309121859();

        [JsonProperty("8181035976")]
        public _8181035976 _8181035976 { get; set; } = new _8181035976();
    }


    public class Popups
    {
    }

    public class PreviouslyRegisteredOptimizationTypes
    {
        public bool ABOUT_THIS_SITE { get; set; } = true;
        public bool HISTORY_CLUSTERS { get; set; } = true;
    }

    public class PrivacySandbox
    {
        public bool anti_abuse_initialized { get; set; } = true;
    }

    public class PrivateNetworkChooserData
    {
    }

    public class PrivateNetworkGuard
    {
    }


    public class ProtectedMediaIdentifier
    {
    }

    public class ProtocolHandler
    {
    }

    public class ReducedAcceptLanguage
    {
    }

    public class Safebrowsing
    {
        public EventTimestamps event_timestamps { get; set; } = new EventTimestamps();
        public string metrics_last_log_time { get; set; } = "13340295472";
    }

    public class SafeBrowsingUrlCheckData
    {
    }

    public class Sensors
    {
    }

    public class SerialChooserData
    {
    }

    public class SerialGuard
    {
    }

    public class Services
    {
        public bool consented_to_sync { get; set; }
        public string signin_scoped_device_id { get; set; } = "5a8b92c7-1f7e-47d8-a916-96fb0e91215e";
    }

    public class Sessions
    {
        public List<object> event_log { get; set; } = new List<object> {
          new EventLog{
            crashed= false,
            time= "13340295472250696",
            type= 0
          },
          new EventLog{
            crashed= true,
            time= "13340307617706525",
            type= 0
          },
          new RestoreBrowser{
            restore_browser= true,
            synchronous= false,
            time= "13340307617844927",
            type= 5
          },
          new ErroredReading{
            errored_reading= false,
            tab_count= 3,
            time= "13340307617985504",
            type= 1,
            window_count= 1
          },
          new DidScheduleCommand{
            did_schedule_command= false,
            first_session_service= true,
            tab_count= 2,
            time= "13340307912924436",
            type= 2,
            window_count= 1
          }
        };
        public int session_data_status { get; set; } = 3;
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class RestoreBrowser
    {
        public bool restore_browser { get; set; }
        public bool synchronous { get; set; }
        public string time { get; set; }
        public int type { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class DidScheduleCommand
    {
        public bool did_schedule_command { get; set; }
        public bool first_session_service { get; set; }
        public int tab_count { get; set; }
        public string time { get; set; }
        public int type { get; set; }
        public int window_count { get; set; }
    }



    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class ErroredReading
    {
        public bool errored_reading { get; set; }
        public int tab_count { get; set; }
        public string time { get; set; }
        public int type { get; set; }
        public int window_count { get; set; }
    }



    public class Signin
    {
        public bool allowed { get; set; } = false;
    }

    public class SiteEngagement
    {
    }

    public class Sound
    {
    }

    public class Spellcheck
    {
        public List<object> dictionaries { get; set; } = new List<object> { };
        public string dictionary { get; set; } = "";
        public bool use_spelling_service { get; set; } = false;
    }

    public class SslCertDecisions
    {
    }


    public class StorageAccess
    {
    }

    public class StoreFilePathsToDelete
    {
    }

    public class SubresourceFilter
    {
    }

    public class SubresourceFilterData
    {
    }

    public class SupervisedUser
    {
        public Metrics metrics { get; set; } = new Metrics();
    }


    public class Sync
    {
        public bool requested { get; set; } = false;
    }

    public class ThirdPartyStoragePartitioning
    {
    }

    public class TopLevelStorageAccess
    {
    }

    public class Touchid
    {
        public string metadata_secret { get; set; } = "FAs08eDqvux1A4NYorVc4ZHDwnhqyLknX9ef3JS4DLg=";
    }

    public class TranslateSiteBlacklistWithTime
    {
    }

    public class TranslateSiteBlocklistWithTime
    {
    }

    public class UnifiedConsent
    {
        public int migration_state { get; set; } = 10;
    }

    public class UnusedSitePermissions
    {
    }

    public class UsbChooserData
    {
    }

    public class UsbGuard
    {
    }

    public class Vr
    {
    }

    public class WebApps
    {
        public List<string> did_migrate_default_chrome_apps { get; set; } = new List<string>
        {
            "MigrateDefaultChromeAppToWebAppsGSuite",
            "MigrateDefaultChromeAppToWebAppsNonGSuite"
        };
        public string last_preinstall_synchronize_version { get; set; } = "115";
        public int system_web_app_failure_count { get; set; } = 0;
        public string system_web_app_last_attempted_language { get; set; } = "en-US";
        public string system_web_app_last_attempted_update { get; set; } = "103.0.5060.53";
        public string system_web_app_last_installed_language { get; set; } = "en-US";
        public string system_web_app_last_update { get; set; } = "103.0.5060.53";
    }

    public class Webauthn
    {
        public Touchid touchid { get; set; } = new Touchid();
    }

    public class WebGl
    {
        public bool mode { get; set; }
        public string renderer { get; set; }
        public string vendor { get; set; }
    }

    public class Webgl2
    {
        public Metadata metadata { get; set; }
    }

    public class WebidApi
    {
    }

    public class WebidAutoReauthn
    {
    }

    public class WebRtc
    {
        public bool fill_based_on_ip { get; set; }
        public bool local_ip_masking { get; set; }
        public string mode { get; set; }
        public string public_ip { get; set; }
    }

    public class WindowPlacement
    {
        public int bottom { get; set; }
        public int left { get; set; }
        public bool maximized { get; set; } = false;
        public int right { get; set; }
        public int top { get; set; }
        public int work_area_bottom { get; set; } = 816;
        public int work_area_left { get; set; } = 0;
        public int work_area_right { get; set; } = 1536;
        public int work_area_top { get; set; } = 0;
    }

    public class Zerosuggest
    {
        public string cachedresults { get; set; } = ")]}'\n[\"\",[],[],[],{\"google:clientdata\":{\"bpc\":false,\"tlw\":false},\"google:suggesttype\":[],\"google:verbatimrelevance\":851}]";
    }




    public class HttpsIpheyCom443
    {
        public string last_modified { get; set; } = "13340307626268495";
        public SettingHints setting { get; set; } = new SettingHints();
    }


    public class ProfilePreferences
    {
        public int avatar_index { get; set; } = 26;
        public ContentSettings content_settings { get; set; } = new ContentSettings();
        public string created_by_version { get; set; } = "103.0.5060.53";
        public string creation_time { get; set; } = "13302807096310804";
        public string exit_type { get; set; } = "Normal";
        public string last_engagement_time { get; set; } = "13340307846591259";
        public double last_time_obsolete_http_credentials_removed { get; set; } = 1695834077.700779;
        public double last_time_password_store_metrics_reported { get; set; } = 1695821902.249318;
        public Managed managed { get; set; } = new Managed();
        public string managed_user_id { get; set; } = "";
        public string name { get; set; } = "Person 1";
        public PasswordAccountStorageSettings password_account_storage_settings { get; set; } = new PasswordAccountStorageSettings();
        public bool were_old_google_logins_removed { get; set; } = true;
    }


    public class SettingHints
    {
        public List<int> client_hints { get; set; } = new List<int> { 8,
                9,
                10,
                11,
                12,
                13,
                14,
                16 };
    }
}
