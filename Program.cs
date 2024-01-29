using ebayLoginAndCheck.Controllers;
using ebayLoginAndCheck.Models;
using FoxLearn.License;
using System.Security.Cryptography;
using System.Text;

namespace ebayLoginAndCheck
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            SaveData saveData = new SaveData();
            saveData.createTableAccountEbay();
            saveData.createTableCC();
            saveData.createTablesetting();
            string computer = ComputerInfo.GetComputerId();
            GoogleSheetControllers sheetControllers = new GoogleSheetControllers();
            var settings = ebayLoginAndCheck.Properties.Settings.Default;
            LicenseRecord licenseRecord = sheetControllers.findComputerHashFromSheet(settings.GoogleSpreadsheetIdKey, settings.GoogleServiceAccountName1, settings.JsonCredential1, computer);
            if (licenseRecord == null)
            {
                Application.Run(new Form1());
            }
            else
            {
                string hash = settings.hash;
                byte[] data = UTF8Encoding.UTF8.GetBytes(computer.Replace("-", ""));
                using (MD5CryptoServiceProvider mD5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = mD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider triple = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.None })
                    {
                        ICryptoTransform transform = triple.CreateDecryptor();
                        byte[] res = transform.TransformFinalBlock(data, 0, data.Length);
                        string keyEcrypt = settings.keyEcrypt;
                        SKGL.Validate validate = new SKGL.Validate();
                        validate.secretPhase = keyEcrypt;
                        validate.Key = licenseRecord.RandomKey;
                        if (validate.IsValid)
                        {
                            if (licenseRecord.HSD <= 0)
                            {
                                MessageBox.Show("Vui lòng liên hệ admin để gia hạn key!", "Thông báo");
                            }
                            else if (licenseRecord.ActiveKey && licenseRecord.HSD > 0)
                            {
                                string currentDay = DateTime.Now.ToString("M/dd/yyyy") + " 0:00:00";
                                DateTime dateTime10 = Convert.ToDateTime(currentDay);
                                TimeSpan? duration = dateTime10 - licenseRecord.CreationDate;
                                double numberOfDays = duration.Value.TotalDays;
                                double newDayLeft = double.Parse(licenseRecord.DayLeft.ToString()) - numberOfDays;
                                sheetControllers.EditDateLeftToSheetActiveKey(settings.GoogleSpreadsheetIdKey, settings.GoogleServiceAccountName1, settings.JsonCredential1, computer, int.Parse(newDayLeft.ToString()));
                                licenseRecord.HSD = int.Parse(newDayLeft.ToString());
                                Application.Run(new Dashboard(licenseRecord));
                            }
                            else if (!licenseRecord.ActiveKey)
                            {
                                MessageBox.Show("Key chưa active! Liên hệ admin để active key", "Thông báo");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng liên hệ admin để mua key!", "Thông báo");
                            Application.Run(new Form1());
                        }

                    }
                }
            }


        }
    }
}