namespace ebayLoginAndCheck.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class CaptchaToken
    {
        public string guid { get; set; }
        public string provider { get; set; }
        public string appName { get; set; }
        public string iid { get; set; }
        public long pvt { get; set; }
        public long cvt { get; set; } = 1705910747194;
        public long crt { get; set; } = 1705910955632;
        public string token { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class InputValue
    {
        public string guid { get; set; }
        public string provider { get; set; }
        public string fallback { get; set; }
        public string hCaptchaJsUrl { get; set; }
        public string captchaJsUrl { get; set; }
        public string siteKey { get; set; }
        public string ui { get; set; }
        public string captchaDataInputDomId { get; set; }
        public string form { get; set; }
        public string cbFn { get; set; }
        public string appName { get; set; }
        public string iid { get; set; }
        public string cbOnRenderedFn { get; set; }
        public string captchasvc { get; set; }
    }


}
