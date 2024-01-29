using ebayLoginAndCheck.Controllers;
using ebayLoginAndCheck.Models;
using System.Security.Cryptography;
using System.Text;

namespace ebayLoginAndCheck
{
    public partial class Form1 : Form
    {
        string secterPhase = string.Empty;
        LicenseRecord licenseRecord;
        public Form1()
        {
            InitializeComponent();
        }

        string computer = FoxLearn.License.ComputerInfo.GetComputerId();

        private void button1_Click(object sender, EventArgs e)
        {
            GoogleSheetControllers googleSheetControllers = new GoogleSheetControllers();
            var settings = ebayLoginAndCheck.Properties.Settings.Default;
            LicenseRecord licenseRecordResult = googleSheetControllers.findComputerHashFromSheet(settings.GoogleSpreadsheetIdKey, settings.GoogleServiceAccountName1, settings.JsonCredential1, computer);
            if (licenseRecordResult == null)
            {
                bool sendKey = googleSheetControllers.AddaNewRecordToSheetActiveKey(settings.GoogleSpreadsheetIdKey, settings.GoogleServiceAccountName1, settings.JsonCredential1, licenseRecord);
                if (sendKey)
                {
                    MessageBox.Show("Vui lòng liên hệ Admin để active key");
                    settings.keyEcrypt = secterPhase;
                    settings.Save();
                }
            }
            else
            {
                bool sendKey = googleSheetControllers.EditRecordToSheetActiveKey(settings.GoogleSpreadsheetIdKey, settings.GoogleServiceAccountName1, settings.JsonCredential1, computer, licenseRecord.RandomKey, licenseRecord.CreationDate, licenseRecord.DayLeft);
                if (sendKey)
                {
                    MessageBox.Show("Vui lòng liên hệ Admin để active key");
                    settings.keyEcrypt = secterPhase;
                    settings.Save();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var settings = ebayLoginAndCheck.Properties.Settings.Default;
            string hash = settings.hash;
            byte[] data = UTF8Encoding.UTF8.GetBytes(computer.Replace("-", ""));
            using (MD5CryptoServiceProvider mD5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = mD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider triple = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.None })
                {
                    ICryptoTransform transform = triple.CreateDecryptor();
                    byte[] res = transform.TransformFinalBlock(data, 0, data.Length);
                    secterPhase = Convert.ToBase64String(res, 0, res.Length);
                    SKGL.Generate generate = new SKGL.Generate();
                    generate.secretPhase = secterPhase;
                    textBox1.Text = generate.doKey(Convert.ToInt32(30));
                    SKGL.Validate validate = new SKGL.Validate();
                    validate.secretPhase = secterPhase;
                    validate.Key = textBox1.Text;
                    licenseRecord = new LicenseRecord();
                    licenseRecord.ComputerHash = computer;
                    licenseRecord.RandomKey = textBox1.Text;
                    licenseRecord.CreationDate = validate.CreationDate;
                    licenseRecord.DayLeft = validate.DaysLeft;
                    licenseRecord.HSD = validate.DaysLeft;
                    licenseRecord.ActiveKey = false;
                }
            }
        }
    }
}
