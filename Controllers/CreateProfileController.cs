using ebayLoginAndCheck.Models;
using ebayLoginAndCheck.Utils;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators.OAuth2;
using System.IO.Compression;
using System.Net;

namespace ebayLoginAndCheck.Controllers
{
    public class CreateProfileController
    {
        public string BASE_URL = "https://api.gologin.com";

        public async Task<bool> deleteProfileCountFromAPI(string apiGologin, string id)
        {
            var authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(
                apiGologin, "Bearer"
            );
            var options = new RestClientOptions(BASE_URL + "/browser/" + id)
            {
                Authenticator = authenticator
            };
            var client = new RestClient(options);
            var request = new RestRequest();
            request.Method = Method.Delete;
            var response = await client.ExecuteAsync(request);
            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task deleteMutiProfileCountFromAPI(string apiGologin, List<string> listId)
        {
            var authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(
                apiGologin, "Bearer"
            );
            var options = new RestClientOptions(BASE_URL + "/browser")
            {
                Authenticator = authenticator
            };
            var client = new RestClient(options);
            var request = new RestRequest();
            request.Method = Method.Delete;
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = RestSharp.DataFormat.Json;
            var profilesToDelete = new { profilesToDelete = listId };
            string rawJson = JsonConvert.SerializeObject(profilesToDelete);
            request.AddParameter("application/json", rawJson, ParameterType.RequestBody);
            var response = await client.ExecuteAsync(request);
            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                Console.WriteLine("Delete 3 profile");
            }
            else
            {
                Console.WriteLine(response.Content);
                Console.WriteLine("Error");
            }
        }
        public async Task<List<string>> getProfileCountFromAPI(string apiGologin)
        {
            List<string> stringsId = new List<string>();
            var authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(
                apiGologin, "Bearer"
            );
            var options = new RestClientOptions(BASE_URL + "/browser/v2")
            {
                Authenticator = authenticator
            };
            var client = new RestClient(options);
            var request = new RestRequest();
            request.Method = Method.Get;
            var response = await client.ExecuteAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                ProfileList myDeserializedClass = JsonConvert.DeserializeObject<ProfileList>(response.Content);
                for (int i = 0; i < myDeserializedClass.allProfilesCount; i++)
                {
                    stringsId.Add(myDeserializedClass.profiles[i].id);
                }
                return stringsId;
            }
            else
            {
                return null;
            }
        }

        public async Task<ProfileData> getProfileData(string apiGologin, string id)
        {
            var authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(
                apiGologin, "Bearer"
            );
            var options = new RestClientOptions(BASE_URL + "/browser/" + id)
            {
                Authenticator = authenticator
            };
            var client = new RestClient(options);
            var request = new RestRequest();
            request.Method = Method.Get;
            var response = await client.ExecuteAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                ProfileData myDeserializedClass = JsonConvert.DeserializeObject<ProfileData>(response.Content);
                return myDeserializedClass;
            }
            else
            {
                return null;
            }
        }

        public async Task<Fingerprint> getNewFingerprint(string apiGologin, string device, bool isM1 = false)
        {
            var authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(
                apiGologin, "Bearer"
            );
            var options = new RestClientOptions(BASE_URL + "/browser/fingerprint?os=" + device + "&isM1=" + isM1)
            {
                Authenticator = authenticator
            };
            var client = new RestClient(options);
            var request = new RestRequest();
            request.Method = Method.Get;
            var response = await client.ExecuteAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Fingerprint myDeserializedClass = JsonConvert.DeserializeObject<Fingerprint>(response.Content);
                return myDeserializedClass;
            }
            else
            {
                return null;
            }
        }

        public async Task<CreateProfileResult> createProfileResquest(string apiGologin, Models.CreateProfile createProfile)
        {
            var authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(
                apiGologin, "Bearer"
            );
            var options = new RestClientOptions(BASE_URL + "/browser")
            {
                Authenticator = authenticator
            };
            var client = new RestClient(options);
            var request = new RestRequest();
            request.Method = Method.Post;
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = RestSharp.DataFormat.Json;
            string rawJson = JsonConvert.SerializeObject(createProfile);
            request.AddParameter("application/json", rawJson, ParameterType.RequestBody);
            var response = await client.ExecuteAsync(request);
            if (response.StatusCode == HttpStatusCode.Created)
            {
                string jsonContent = response.Content;
                return JsonConvert.DeserializeObject<CreateProfileResult>(jsonContent);
            }
            else
            {
                return null;
            }
        }

        public ProfileResult createProfileResult(string system, string proxy)
        {
            Random random = new Random();

            GoogleSheetControllers googleSheet = new GoogleSheetControllers();
            List<string> listApi = googleSheet.getListApiGologinFromSheet(ebayLoginAndCheck.Properties.Settings.Default.GoogleSpreadsheetAPIGologin, ebayLoginAndCheck.Properties.Settings.Default.GoogleServiceAccountAPIGologin, ebayLoginAndCheck.Properties.Settings.Default.JsonCredentialAPIGologin);
            if (listApi.Count == 0)
            {
                return null;
            }
            string apiKey = listApi[random.Next(0, listApi.Count - 1)];
            List<string> qualityProfileCreate = getProfileCountFromAPI(apiKey).Result;
            while (qualityProfileCreate == null || qualityProfileCreate.Count == 3)
            {
                apiKey = listApi[random.Next(0, listApi.Count - 1)];
                qualityProfileCreate = getProfileCountFromAPI(apiKey).Result;
            }
            Task<Fingerprint> fingerprintTask = getNewFingerprint(apiKey, system.Equals("mac|true") ? system.Split('|')[0] : system, system.Equals("mac|true") ? true : false);
            Fingerprint fingerprint = fingerprintTask.Result;
            if (fingerprint != null)
            {
                Models.CreateProfile createProfileModels = new Models.CreateProfile();
                createProfileModels.name = Faker.Name.Last() + " " + Faker.Name.First();
                createProfileModels.notes = string.Empty;
                createProfileModels.browserType = "chrome";
                createProfileModels.os = system.Equals("mac|true") ? system.Split('|')[0] : system;
                createProfileModels.startUrl = "";
                createProfileModels.googleServicesEnabled = false;
                createProfileModels.lockEnabled = false;
                createProfileModels.debugMode = false;
                Geolocation geolocation = new Geolocation();
                geolocation.mode = "prompt";
                geolocation.enabled = true;
                geolocation.customize = true;
                geolocation.fillBasedOnIp = true;
                geolocation.latitude = 0;
                geolocation.longitude = 0;
                geolocation.accuracy = 10;
                createProfileModels.geolocation = geolocation;
                Navigator navigator = new Navigator();
                navigator.userAgent = fingerprint.navigator.userAgent;
                navigator.resolution = fingerprint.navigator.resolution;
                navigator.language = fingerprint.navigator.language;
                navigator.platform = fingerprint.navigator.platform;
                navigator.doNotTrack = false;
                navigator.hardwareConcurrency = fingerprint.navigator.hardwareConcurrency;
                navigator.deviceMemory = fingerprint.navigator.deviceMemory;
                createProfileModels.navigator = navigator;
                Storage storage = new Storage();
                storage.local = true;
                storage.extensions = true;
                storage.bookmarks = true;
                storage.history = true;
                storage.passwords = true;
                storage.session = true;
                createProfileModels.storage = storage;
                if (string.IsNullOrEmpty(proxy))
                {
                    createProfileModels.proxyEnabled = false;
                    Proxy proxy1 = new Proxy();
                    proxy1.mode = "none";
                    proxy1.host = string.Empty;
                    proxy1.port = 80;
                    proxy1.username = string.Empty;
                    proxy1.password = string.Empty;
                    createProfileModels.proxy = proxy1;
                }
                else
                {
                    createProfileModels.proxyEnabled = true;
                    string proxyInformation = proxy;
                    Proxy proxy1 = new Proxy();
                    proxy1.mode = "http";
                    proxy1.host = proxyInformation.Split(':')[0].ToString();
                    proxy1.port = Int32.Parse(proxyInformation.Split(':')[1].ToString());
                    if (proxyInformation.Split(':').Length > 2)
                    {
                        proxy1.username = proxyInformation.Split(':')[2].ToString();
                        proxy1.password = proxyInformation.Split(':')[3].ToString();
                    }
                    else
                    {
                        proxy1.username = string.Empty;
                        proxy1.password = string.Empty;
                    }
                    createProfileModels.proxy = proxy1;
                }
                createProfileModels.dns = string.Empty;
                Plugins plugins = new Plugins();
                plugins.enableVulnerable = true;
                plugins.enableFlash = true;
                createProfileModels.plugins = plugins;
                Timezone timezone = new Timezone();
                timezone.enabled = true;
                timezone.fillBasedOnIp = true;
                timezone.timezone = string.Empty;
                createProfileModels.timezone = timezone;
                AudioContext audioContext = new AudioContext();
                audioContext.mode = "noise";
                createProfileModels.audioContext = audioContext;
                Models.Canvas canvas = new Models.Canvas();
                canvas.mode = fingerprint.canvas.mode;
                createProfileModels.canvas = canvas;
                Fonts fonts = new Fonts();
                List<string> listFonts = new List<string>();
                foreach (string val in fingerprint.fonts)
                {
                    listFonts.Add(val);
                }
                fonts.families = listFonts;
                fonts.enableMasking = true;
                fonts.enableDomRect = true;
                createProfileModels.fonts = fonts;
                MediaDevices mediaDevices = new MediaDevices();
                mediaDevices.enableMasking = false;
                mediaDevices.audioInputs = string.IsNullOrEmpty(fingerprint.mediaDevices.audioInputs.ToString()) ? 0 : fingerprint.mediaDevices.audioInputs;
                mediaDevices.audioOutputs = string.IsNullOrEmpty(fingerprint.mediaDevices.audioOutputs.ToString()) ? 0 : fingerprint.mediaDevices.audioOutputs;
                mediaDevices.videoInputs = string.IsNullOrEmpty(fingerprint.mediaDevices.videoInputs.ToString()) ? 0 : fingerprint.mediaDevices.videoInputs;
                createProfileModels.mediaDevices = mediaDevices;
                WebRTC webRTC = new WebRTC();
                webRTC.mode = "alerted";
                webRTC.enabled = true;
                webRTC.customize = true;
                webRTC.localIpMasking = false;
                webRTC.fillBasedOnIp = true;
                createProfileModels.webRTC = webRTC;
                WebGL webGL = new WebGL();
                webGL.mode = fingerprint.webGL.mode;
                createProfileModels.webGL = webGL;
                ClientRects clientRects = new ClientRects();
                clientRects.mode = fingerprint.clientRects.mode;
                createProfileModels.clientRects = clientRects;
                WebGLMetadata webGLMetadata = new WebGLMetadata();
                webGLMetadata.mode = fingerprint.webGLMetadata.mode.Equals("noise") ? "mask" : fingerprint.webGLMetadata.mode;
                webGLMetadata.vendor = fingerprint.webGLMetadata.vendor;
                webGLMetadata.renderer = fingerprint.webGLMetadata.renderer;
                createProfileModels.webGLMetadata = webGLMetadata;
                createProfileModels.updateExtensions = true;
                WebglParams webglParams = new WebglParams();
                webglParams.textureMaxAnisotropyExt = fingerprint.webglParams.textureMaxAnisotropyExt;
                webglParams.shaiderPrecisionFormat = fingerprint.webglParams.shaiderPrecisionFormat;
                webglParams.antialiasing = fingerprint.webglParams.antialiasing;
                List<string> extensions = new List<string>();
                extensions.AddRange(fingerprint.webglParams.extensions);
                webglParams.extensions = extensions;
                List<GlParamValue> parameters = new List<GlParamValue>();
                parameters.AddRange(fingerprint.webglParams.glParamValues);
                webglParams.glParamValues = parameters;
                List<SupportedFunction> supportedFunctions = new List<SupportedFunction>();
                supportedFunctions.AddRange(fingerprint.webglParams.supportedFunctions);
                webglParams.glCanvas = fingerprint.webglParams.glCanvas;
                webglParams.supportedFunctions = supportedFunctions;
                createProfileModels.webglParams = webglParams;
                CreateProfileResult result = createProfileResquest(apiKey, createProfileModels).Result;
                if (result != null)
                {
                    string currentDirectory = Directory.GetCurrentDirectory();
                    string sourceFile = currentDirectory + @"\browser\profileDefault.zip";
                    string destinationFile = Directory.GetCurrentDirectory() + @"\Profile\";
                    if (!Directory.Exists(destinationFile))
                    {
                        Directory.CreateDirectory(destinationFile);
                    }
                    string extractPath = destinationFile + @"\" + result.id;
                    UtilsController utilsController = new UtilsController();
                    string nameFile = utilsController.RandomString(12) + ".zip";
                    try
                    {
                        Directory.CreateDirectory(extractPath);
                        File.Copy(sourceFile, destinationFile + @"\" + nameFile, true);
                        Thread.Sleep(1000);
                        ZipFile.ExtractToDirectory(destinationFile + @"\" + nameFile, extractPath);

                    }
                    catch (IOException iox)
                    {
                        Console.WriteLine(iox.Message);
                    }
                    finally
                    {
                        File.Delete(destinationFile + @"\" + nameFile);
                    }
                    ProfileData profileData = getProfileData(apiKey, result.id).Result;
                    if (profileData != null)
                    {
                        AddPreferenceController addPreference = new AddPreferenceController();
                        addPreference.addPreference(extractPath + @"\Default\Preferences", currentDirectory, profileData);
                        Thread.Sleep(500);
                        if (deleteProfileCountFromAPI(apiKey, profileData.id).Result)
                        {
                            Console.WriteLine("Delete!");
                        }
                        else
                        {
                            Console.WriteLine("Error!");
                            Thread.Sleep(1000);
                            deleteProfileCountFromAPI(apiKey, profileData.id);
                        }
                        ProfileResult profileResult = new ProfileResult();
                        profileResult.system = system;
                        profileResult.ProfileId = profileData.id;
                        return profileResult;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
