using ebayLoginAndCheck.Controllers;
using ebayLoginAndCheck.Models;
using ebayLoginAndCheck.Utils;
using ebayLoginAndCheck.Views;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chrome.ChromeDriverExtensions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SeleniumUndetectedChromeDriver;
using System.Data.SQLite;
using System.Diagnostics;
using System.Xml.Linq;
using Point = System.Drawing.Point;

namespace ebayLoginAndCheck
{
    public partial class Dashboard : Form
    {
        SaveData saveData;
        bool isRun = false;
        Queue<int> listRun;
        Queue<int> listCC;

        public Dashboard(LicenseRecord licenseRecord)
        {
            InitializeComponent();
            GridViewCheckBoxColumn gridViewCheckBoxColumn = new GridViewCheckBoxColumn();
            dataGridView1.Columns.Insert(0, gridViewCheckBoxColumn);
            saveData = new SaveData();
            loadDataGridViewCC(dataGridView2);
            loadDataGridView1();
            button8.Enabled = false;
            label15.Text = "Creation Date: " + licenseRecord.CreationDate?.ToString("dd/MM/yyyy");
            DateTime? newTime = licenseRecord.CreationDate?.AddDays(licenseRecord.DayLeft);
            label16.Text = "Expire Date: " + newTime?.ToString("dd/MM/yyyy");
            label17.Text = "Day Left: " + licenseRecord.HSD.ToString();
        }

        #region
        public void addLogToDataGridView1(int indexRow, int indexCell, string log)
        {
            dataGridView1.Invoke(new Action(() =>
            {
                dataGridView1.Rows[indexRow].Cells[indexCell].Value = log;
            }));
        }

        public void deleteThisAccount_Click(object? sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá this account", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int selectedrowindex = dataGridView1.SelectedCells[1].RowIndex;
                saveData.deleteProfileByAccount(dataGridView1.Rows[selectedrowindex].Cells[2].Value.ToString());
                loadDataGridView1();
            }
        }

        public void deleteAllAccount_Click(object? sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá All account", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    saveData.deleteProfileByAccount("");
                }
                catch (Exception ex) { }
                dataGridView1.Rows.Clear();
            }
        }

        public void deleteSelectAccount_Click(object? sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá All account", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (bool.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()))
                    {
                        try
                        {
                            saveData.deleteProfileByAccount(dataGridView1.Rows[i].Cells[2].Value.ToString());
                        }
                        catch (Exception ex) { }
                    }
                }
                loadDataGridView1();
            }
        }

        public void changeQualityThisAccount_Click(object? sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đổi Quality Check this account bằng 0 không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int selectedrowindex = dataGridView1.SelectedCells[1].RowIndex;
                saveData.updateQualityByID(dataGridView1.Rows[selectedrowindex].Cells[2].Value.ToString(), "0");
                loadDataGridView1();
            }
        }

        public void changeQualityAllAccount_Click(object? sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đổi Quality Check All account bằng 0 không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        saveData.updateQualityByID(dataGridView1.Rows[i].Cells[2].Value.ToString(), "0");
                    }
                    catch (Exception ex) { }
                }
                loadDataGridView1();
            }
        }

        public void changeQualitySelectAccount_Click(object? sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đổi Quality Check Select Account bằng 0 không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (bool.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()))
                    {
                        try
                        {
                            saveData.updateQualityByID(dataGridView1.Rows[i].Cells[2].Value.ToString(), "0");
                        }
                        catch (Exception ex) { }
                    }
                }
                loadDataGridView1();
            }
        }

        //deleteThisAccount_Click

        private void addAccount_Click(object sender, EventArgs e)
        {
            this.Enabled = true;
            loadDataGridView1();
        }

        public int getQualityAdd(string username)
        {
            int quality = -1;
            try
            {
                SQLiteDataReader sQLiteDataReader = saveData.getQuality(username);
                while (sQLiteDataReader.Read())
                {
                    quality = int.Parse(sQLiteDataReader.GetString(0));
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
            return quality;
        }

        public void loadDataGridViewCC(DataGridView dataGridView)
        {
            try
            {
                dataGridView.Rows.Clear();
                SQLiteDataReader sQLiteDataReader = saveData.loadDataCC();
                int k = 0;
                while (sQLiteDataReader.Read())
                {
                    dataGridView.Rows.Add(sQLiteDataReader.GetString(1), sQLiteDataReader.GetString(2));
                    if (!string.IsNullOrEmpty(sQLiteDataReader.GetString(2)))
                    {
                        if (sQLiteDataReader.GetString(2).Equals("Success"))
                        {
                            dataGridView.Rows[k].DefaultCellStyle.BackColor = Color.LightGreen;
                        }

                    }
                    k++;
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        public void randomSleep()
        {
            Random random = new Random();
            int rdn = random.Next((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            Thread.Sleep(rdn * 1000);
        }

        public void loadDataGridView1()
        {
            try
            {
                dataGridView1.Rows.Clear();
                SQLiteDataReader sQLiteDataReader = saveData.loadDataAccountEbay();
                int k = 1;
                while (sQLiteDataReader.Read())
                {
                    dataGridView1.Rows.Add(false, k, sQLiteDataReader.GetString(0), sQLiteDataReader.GetString(1), sQLiteDataReader.GetString(2), sQLiteDataReader.GetString(3), sQLiteDataReader.GetString(4), sQLiteDataReader.GetString(5));
                    if (!string.IsNullOrEmpty(sQLiteDataReader.GetString(2)))
                    {
                        if (sQLiteDataReader.GetString(2).Equals("Success"))
                        {
                            dataGridView1.Rows[k - 1].DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                    }
                    k++;
                }

            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        public void createChromeDriverAndLoginAccount(int thread, int PosX, int PoxY)
        {
            while (listRun.Count > 0)
            {
                if (!isRun)
                {
                    return;
                }
                Thread.Sleep(thread * 1000);
                int index = -1;
                try
                {
                    index = listRun.Dequeue();
                }
                catch { }
                if (index == -1)
                {
                    return;
                }
                dataGridView1.Invoke(new Action(() =>
                {
                    dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.Yellow;
                }));
                addLogToDataGridView1(index, 7, "Setting chrome");
                int min = (int)numericUpDown1.Value;
                int max = (int)numericUpDown2.Value;
                ChromeDriverService cService = ChromeDriverService.CreateDefaultService();
                cService.HideCommandPromptWindow = true;
                var options = new ChromeOptions();
                options.AddArgument("disable-infobars");
                if (checkBox1.Checked)
                {
                    options.AddArgument("--blink-settings=imagesEnabled=false");
                }
                options.AddExcludedArgument("enable-automation");
                options.AddArgument("--window-size=600,400");
                options.AddArgument("--no-sandbox");
                options.AddArguments("--disable-notifications"); // to disable notification
                options.AddArguments("--disable-application-cache"); // to disable cache
                options.AddUserProfilePreference("profile.default_content_setting_values.notifications", 2);
                if (!string.IsNullOrEmpty(dataGridView1.Rows[index].Cells[5].Value?.ToString()))
                {
                    string[] proxy = dataGridView1.Rows[index].Cells[5].Value.ToString().Split(':');
                    if (proxy.Length > 2) 
                    {
                        options.AddHttpProxy(proxy[0], int.Parse(proxy[1]), proxy[2], proxy[3]);
                    }
                    else
                    {
                        options.AddArgument("--proxy-server=" + proxy[0] + ":" + proxy[1]);
                    }
                }
                ChromeDriver driver = new ChromeDriver(cService, options);
                //string directoryProfile = string.Empty;
                //if (!string.IsNullOrEmpty(dataGridView1.Rows[index].Cells[5].Value.ToString()))
                //{
                //    directoryProfile = Directory.GetCurrentDirectory() + @"\Profile\profileDefault";
                //}
                //else
                //{
                //    continue;
                //}
                //UndetectedChromeDriver driver = null;
                //try
                //{
                //    driver = UndetectedChromeDriver.Create(options: options, driverExecutablePath: Directory.GetCurrentDirectory() + @"\chromedriver.exe", userDataDir: directoryProfile, browserExecutablePath: Directory.GetCurrentDirectory() + @"\browser\orbita-browser-120\chrome.exe", hideCommandPromptWindow: true, suppressWelcome: false, commandTimeout: TimeSpan.FromSeconds(120));
                //}
                //catch (Exception err) { 
                //    Console.WriteLine(err)
                //}
                if (driver != null)
                {
                    try
                    {
                        addLogToDataGridView1(index, 7, "Setting chrome thành công");
                        EbayController ebayController = new EbayController();
                        driver.Manage().Window.Size = new Size(400, 600);
                        Thread.Sleep(1000);
                        driver.Manage().Window.Position = new Point(PosX, PoxY);
                        Thread.Sleep(1000);
                        driver.Navigate().GoToUrl("https://www.ebay.com/");
                        _ = driver.Manage().Timeouts().ImplicitWait;
                        while (!driver.Url.Contains("https://ppcapp.ebay.com/myppc/wallet/list"))
                        {
                            switch (driver.Url)
                            {
                                case string a when a.Contains("https://ebaypayonboardingweb.ebay.com/"):
                                    addLogToDataGridView1(index, 7, "Dính business seller");
                                    break;
                                case string a when a.Contains("https://www.ebay.com/splashui/captcha?"):
                                    addLogToDataGridView1(index, 7, "Dính Captcha");
                                    bool bypassCaptcha = ebayController.bypassCaptcha(driver, textBox1.Text);
                                    if (bypassCaptcha)
                                    {
                                        addLogToDataGridView1(index, 7, "Giải Captcha thành công");
                                    }
                                    else
                                    {
                                        addLogToDataGridView1(index, 7, "Giải Captcha không thành công");
                                        continue;
                                    }
                                    break;
                                case string c when c.Contains("https://www.ebay.com/signin/"):
                                    addLogToDataGridView1(index, 7, "Bắt đầu login account");
                                    driver.Navigate().GoToUrl("https://signin.ebay.com/ws/eBayISAPI.dll?SignIn");
                                    _ = driver.Manage().Timeouts().ImplicitWait;
                                    bool loginAccountResult = ebayController.loginAccountEbay(driver, min, max, dataGridView1.Rows[index].Cells[2].Value.ToString(), dataGridView1.Rows[index].Cells[3].Value.ToString(), textBox1.Text);
                                    Thread.Sleep(2000);
                                    if (loginAccountResult)
                                    {
                                        driver.Navigate().GoToUrl("https://ppcapp.ebay.com/myppc/wallet/list");
                                        _ = driver.Manage().Timeouts().ImplicitWait;
                                        if (driver.Url.Contains("https://ppcapp.ebay.com/myppc/wallet/list"))
                                        {
                                            addLogToDataGridView1(index, 7, "Login thành công");
                                            try
                                            {
                                                saveData.updateStatusByID(dataGridView1.Rows[index].Cells[2].Value.ToString(), "Success");
                                            }
                                            catch { }
                                            dataGridView1.Invoke(new Action(() =>
                                            {
                                                dataGridView1.Rows[index].Cells[4].Value = "Success";
                                                dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
                                            }));
                                        }
                                    }
                                    break;
                                case string b when b.Contains("https://www.ebay.com/"):
                                    bool loginResult = ebayController.checkLoginEbay(driver, min, max);
                                    if (loginResult)
                                    {
                                        addLogToDataGridView1(index, 7, "Đã Login");
                                        try
                                        {
                                            saveData.updateStatusByID(dataGridView1.Rows[index].Cells[2].Value.ToString(), "Success");
                                        }
                                        catch { }
                                        dataGridView1.Invoke(new Action(() =>
                                        {
                                            dataGridView1.Rows[index].Cells[4].Value = "Success";
                                            dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
                                        }));
                                        driver.Navigate().GoToUrl("https://ppcapp.ebay.com/myppc/wallet/list");
                                        _ = driver.Manage().Timeouts().ImplicitWait;
                                    }
                                    else
                                    {
                                        addLogToDataGridView1(index, 7, "Chưa Login");
                                        driver.Navigate().GoToUrl("https://www.ebay.com/signin/");
                                    }
                                    break;
                                case string d when d.Contains("https://accounts.ebay.com/acctxs/stepup"):
                                    addLogToDataGridView1(index, 7, "Verify It's You");
                                    break;
                                case string d when d.Contains("https://signin.ebay.com/ws/"):
                                    addLogToDataGridView1(index, 7, "Login Again");
                                    loginAccountResult = ebayController.loginAgainAccountEbay(driver, min, max, dataGridView1.Rows[index].Cells[2].Value.ToString(), dataGridView1.Rows[index].Cells[3].Value.ToString(),textBox1.Text);
                                    Thread.Sleep(2000);
                                    if (loginAccountResult)
                                    {
                                        driver.Navigate().GoToUrl("https://ppcapp.ebay.com/myppc/wallet/list");
                                        _ = driver.Manage().Timeouts().ImplicitWait;
                                        if (driver.Url.Contains("https://ppcapp.ebay.com/myppc/wallet/list"))
                                        {
                                            addLogToDataGridView1(index, 7, "Login thành công");
                                            try
                                            {
                                                saveData.updateStatusByID(dataGridView1.Rows[index].Cells[2].Value.ToString(), "Success");
                                            }
                                            catch { }
                                            dataGridView1.Invoke(new Action(() =>
                                            {
                                                dataGridView1.Rows[index].Cells[4].Value = "Success";
                                                dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
                                            }));
                                        }
                                    }
                                    else
                                    {
                                        IWebElement cpatcha = driver.FindElement(By.XPath("//iframe[@id='captchaFrame']"));
                                        if (cpatcha != null)
                                        {
                                            addLogToDataGridView1(index, 7, "Login thất bại");
                                        }
                                    }
                                    break;
                            }
                            if (driver.Url.Contains("https://ebaypayonboardingweb.ebay.com/"))
                            {
                                addLogToDataGridView1(index, 7, "Dính business seller");
                                try
                                {
                                    saveData.updateStatusByID(dataGridView1.Rows[index].Cells[2].Value.ToString(), "SignUp Business Seller");
                                }
                                catch { }
                                dataGridView1.Invoke(new Action(() =>
                                {
                                    dataGridView1.Rows[index].Cells[4].Value = "SignUp Business Seller";
                                    dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.White;
                                }));
                                break;
                            }
                            else if (driver.Url.Contains("https://accounts.ebay.com/acctxs/stepup"))
                            {
                                addLogToDataGridView1(index, 7, "Verify It's You");
                                break;
                            }else if (dataGridView1.Rows[index].Cells[7].Value.ToString().Equals("Login thất bại"))
                            {
                                break;
                            }
                        }
                        if (driver.Url.Contains("https://ebaypayonboardingweb.ebay.com/"))
                        {
                            addLogToDataGridView1(index, 7, "Dính business seller");
                            dataGridView1.Invoke(new Action(() => {
                                dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.White;
                            }));
                        }
                        else if (driver.Url.Contains("https://accounts.ebay.com/acctxs/stepup"))
                        {
                            addLogToDataGridView1(index, 7, "Verify It's You");
                            dataGridView1.Invoke(new Action(() => {
                                dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.White;
                            }));
                        }
                        else if (dataGridView1.Rows[index].Cells[7].Value.ToString().Equals("Login thất bại"))
                        {
                            dataGridView1.Invoke(new Action(() => {
                                dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.White;
                            }));
                        }
                        else
                        {
                            int addVisa = int.Parse(dataGridView1.Rows[index].Cells[6].Value.ToString());
                            if (addVisa < (int)numericUpDown12.Value)
                            {
                                addLogToDataGridView1(index, 7, "Bắt đầu add CC");
                                if (driver.Url.Equals("https://ppcapp.ebay.com/myppc/wallet/list"))
                                {
                                    WebDriverWait driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                                    while (addVisa < (int)numericUpDown12.Value)
                                    {
                                        int indexVisa = -1;
                                        try
                                        {
                                            indexVisa = listCC.Dequeue();
                                        }
                                        catch { }
                                        if (indexVisa < 0)
                                        {
                                            addLogToDataGridView1(index, 7, "Đã hết CC. Vui lòng add vào");
                                            return;
                                        }
                                        dataGridView2.Invoke(new Action(() =>
                                        {
                                            dataGridView2.Rows[indexVisa].DefaultCellStyle.BackColor = Color.Yellow;
                                        }));
                                        driver.Navigate().GoToUrl("https://ppcapp.ebay.com/myppc/wallet/list");
                                        _ = driver.Manage().Timeouts().ImplicitWait;
                                        string addCCResult = ebayController.getResultAddCC(driver, dataGridView2.Rows[indexVisa].Cells[0].Value.ToString());
                                        if (!string.IsNullOrEmpty(addCCResult))
                                        {
                                            if (addCCResult.Equals("You've added a credit card."))
                                            {
                                                saveData.updateStatusCC(dataGridView2.Rows[indexVisa].Cells[0].Value.ToString(), "Success");
                                                dataGridView2.Invoke(new Action(() =>
                                                {
                                                    dataGridView2.Rows[indexVisa].Cells[1].Value = "Success";
                                                    dataGridView2.Rows[indexVisa].DefaultCellStyle.BackColor = Color.LightGreen;
                                                }));

                                                try
                                                {
                                                    addLogToDataGridView1(index, 7, "Send CC");
                                                    GoogleSheetControllers updateLogToGoogleSheet = new GoogleSheetControllers();
                                                    var settings = ebayLoginAndCheck.Properties.Settings.Default;
                                                    bool updateLog = ebayController.sendCCToTelegram(textBox2.Text, textBox3.Text, dataGridView2.Rows[indexVisa].Cells[0].Value.ToString()).Result;
                                                    if (updateLog)
                                                    {
                                                        addLogToDataGridView1(index, 7, "Send CC Success");
                                                    }
                                                    else
                                                    {
                                                        addLogToDataGridView1(index, 7, "Send CC Failed");
                                                    }
                                                    updateLogToGoogleSheet.AddaNewRecordToSheet(settings.GoogleSpreadsheetId2, settings.GoogleServiceAccountName2, settings.JsonCredential2, dataGridView2.Rows[indexVisa].Cells[0].Value.ToString());
                                                }
                                                catch { }

                                            }
                                            else
                                            {
                                                saveData.updateStatusCC(dataGridView2.Rows[indexVisa].Cells[0].Value.ToString(), "Failed");
                                                dataGridView2.Invoke(new Action(() =>
                                                {
                                                    dataGridView2.Rows[indexVisa].Cells[1].Value = "Failed";
                                                    dataGridView2.Rows[indexVisa].DefaultCellStyle.BackColor = Color.Red;
                                                }));
                                            }
                                            addVisa++;
                                            saveData.updateQualityByID(dataGridView1.Rows[index].Cells[2].Value.ToString(), addVisa.ToString());
                                            dataGridView1.Invoke(new Action(() =>
                                            {
                                                dataGridView1.Rows[index].Cells[6].Value = addVisa.ToString();
                                            }));
                                        }
                                        else
                                        {
                                            listCC.Enqueue(indexVisa);
                                            dataGridView2.Invoke(new Action(() =>
                                            {
                                                dataGridView2.Rows[indexVisa].DefaultCellStyle.BackColor = Color.White;
                                            }));
                                        }

                                    }
                                }
                            }
                            addLogToDataGridView1(index, 7, "Xoá thẻ đã add");
                            try
                            {
                                driver.Navigate().GoToUrl("https://ppcapp.ebay.com/myppc/wallet/list");
                                _ = driver.Manage().Timeouts().ImplicitWait;
                                List<IWebElement> listDelete = driver.FindElements(By.XPath("//a[@class='fake-btn link fake-btn--secondary']")).Cast<IWebElement>().ToList();
                                if(listDelete.Count > 0)
                                {
                                    for(int i = 0; i < listDelete.Count; i++)
                                    {
                                        if( i != 0)
                                        {
                                            driver.Navigate().GoToUrl("https://ppcapp.ebay.com/myppc/wallet/list");
                                            _ = driver.Manage().Timeouts().ImplicitWait;
                                        }
                                        listDelete = driver.FindElements(By.XPath("//a[@class='fake-btn link fake-btn--secondary']")).Cast<IWebElement>().ToList();
                                        try
                                        {
                                            driver.ExecuteScript("arguments[0].scrollIntoView(true);", listDelete[0]);
                                            Thread.Sleep(500);
                                            listDelete[0].Click();
                                        }
                                        catch (Exception err)
                                        {
                                            Console.WriteLine(err.Message.ToString());
                                        }
                                        WebDriverWait driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                                        IWebElement iframe = driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//iframe[@class='iframe-dialog__iframe']")));
                                        if (iframe != null)
                                        {
                                            driver.SwitchTo().Frame(iframe);
                                            Thread.Sleep(2000);
                                            driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//a[@aria-label='Delete']"))).Click();
                                            driver.SwitchTo().DefaultContent();
                                            Thread.Sleep(2000);
                                        }
                                    }
                                }
                                
                            }
                            catch { }
                            addLogToDataGridView1(index, 7, "Done");
                        }
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err.Message.ToString());
                        try
                        {
                            driver.Close();
                            driver.Quit();
                            driver.Dispose();
                        }
                        catch { }

                    }
                    finally
                    {
                        try
                        {

                            driver.Close();
                            driver.Quit();
                            driver.Dispose();
                        }
                        catch { }
                    }
                }
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            AddAccount addAccount = new AddAccount(false);
            addAccount.Show();
            addAccount.FormClosed += addAccount_Click;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá hết account Ebay và Profile Account", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Directory.Delete(Directory.GetCurrentDirectory() + @"\Profile", true);
                }
                catch { }
                dataGridView1.Rows.Clear();
                saveData.deleteProfileByAccount(null);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            isRun = false;
            button8.Enabled = false;
            button7.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng import account", "Thông báo");
                return;
            }

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập Api 2Captcha", "Thông báo");
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Vui lòng nhập Api Telegram", "Thông báo");
                return;
            }
            isRun = true;
            button8.Enabled = true;
            button7.Enabled = false;
            listRun = new Queue<int>();
            for (int i = (int)numericUpDown14.Value - 1; i < dataGridView1.Rows.Count; i++)
            {
                if (int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()) < (int)numericUpDown12.Value && !dataGridView1.Rows[i].Cells[4].Value.ToString().Equals("SignUp Business Seller"))
                    listRun.Enqueue(i);
            }
            listCC = new Queue<int>();
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (dataGridView2.Rows[i].Cells[1].Value.ToString().Equals("Unchecked"))
                {
                    listCC.Enqueue(i);
                }
            }
            UtilsController utilsController = new UtilsController();
            List<List<int>> listVitri = utilsController.chiaViTri((int)numericUpDown3.Value);
            List<Task> tasks = new List<Task>();
            Task.Run(() =>
            {
                for (int i = 1; i <= (int)numericUpDown3.Value; i++)
                {
                    int thread = i;
                    List<int> posList = listVitri[i - 1];
                    Task task = Task.Factory.StartNew(() =>
                    {
                        createChromeDriverAndLoginAccount(thread, posList[0], posList[1]);
                    });
                    tasks.Add(task);
                }
                Task.WaitAll(tasks.ToArray());
                this.Invoke(new Action(() =>
                {
                    isRun = false;
                    button8.Enabled = false;
                    button7.Enabled = true;
                }));
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                UtilsController utilsController = new UtilsController();
                string[] strings = File.ReadAllLines(utilsController.getFilePath());

                foreach (string vs in strings)
                {
                    saveData.saveCC(vs, "Unchecked");
                }
                loadDataGridViewCC(dataGridView2);
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá hết CC", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                saveData.deleteTableCC("");
                dataGridView2.Rows.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thay hết Proxy Account không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Enabled = false;
                AddAccount addAccount = new AddAccount(true);
                addAccount.Show();
                addAccount.FormClosed += addAccount_Click;
            }
        }

        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numericUpDown14.Value >= dataGridView1.Rows.Count)
            {
                numericUpDown14.Value = dataGridView1.Rows.Count;
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SQLiteDataReader sQLiteDataReader = saveData.loadDatasetting();
            while (sQLiteDataReader.Read())
            {
                textBox1.Text = sQLiteDataReader.GetString(0);
                textBox2.Text = sQLiteDataReader.GetString(1);
                textBox3.Text = "-" + sQLiteDataReader.GetString(2);
            }
            Process[] processes = Process.GetProcessesByName("chromedriver");

            foreach (Process process in processes)
            {
                process.Kill();
            }
            
            try
            {
                DirectoryInfo d = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\Plugins");
                FileInfo[] Files = d.GetFiles("*.zip"); //Getting Text files

                foreach (FileInfo file in Files)
                {
                    File.Delete(file.FullName);
                }
            }
            catch { }
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("chromedriver");

            foreach (Process process in processes)
            {
                process.Kill();
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                var row = dataGrid.Rows[e.RowIndex];
                dataGrid.CurrentCell = row.Cells[e.ColumnIndex == -1 ? 1 : e.ColumnIndex];
                row.Selected = true;
                dataGrid.Focus();
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    int selectedrowindex = dataGridView1.SelectedCells[1].RowIndex;
                    ContextMenuStrip m = new ContextMenuStrip();
                    m.Items.Add(new ToolStripMenuItem("Delete This Account", null, new EventHandler(deleteThisAccount_Click)));
                    m.Items.Add(new ToolStripMenuItem("Delete Selected Account", null, new EventHandler(deleteSelectAccount_Click)));
                    m.Items.Add(new ToolStripMenuItem("Delete All Account", null, new EventHandler(deleteAllAccount_Click)));
                    m.Items.Add(new ToolStripMenuItem("Change Quality Check This Account = 0", null, new EventHandler(changeQualityThisAccount_Click)));
                    m.Items.Add(new ToolStripMenuItem("Change Quality Check Selected Account = 0", null, new EventHandler(changeQualitySelectAccount_Click)));
                    m.Items.Add(new ToolStripMenuItem("Change Quality Check All Account = 0", null, new EventHandler(changeQualityAllAccount_Click)));
                    m.Show(dataGridView1, new Point(e.X, e.Y));
                }
                catch { }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text))
                {
                    saveData.deleteTablesetting();
                    Thread.Sleep(500);
                    string idChat = textBox3.Text.Replace("-", "");
                    saveData.savesetting(textBox1.Text, textBox2.Text, idChat);
                    MessageBox.Show("Lưu Setting thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ các trường!", "Thông báo");
                }
            }
            catch { }
        }
    }
}
