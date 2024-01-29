using OpenQA.Selenium.Chrome;
using System.IO.Compression;
using System.Text;

namespace ebayLoginAndCheck.Utils
{
    public class UtilsController
    {
        public static ReaderWriterLock locker = new ReaderWriterLock();

        public Dictionary<string, string> GetAllPageCookies(ChromeDriver driver)
        {
            try
            {
                return driver.Manage().Cookies.AllCookies.ToDictionary(cookie => cookie.Name, cookie => cookie.Value);
            }
            catch { return null; }

        }

        public string ToDebugString<TKey, TValue>(Dictionary<TKey, TValue> dictionary)
        {
            return string.Join(";", dictionary.Select(kv => kv.Key + "=" + kv.Value).ToArray());
        }

        public string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public string UnZipProfileAndChangeName(string nameFolder = null)
        {
            try
            {
                string zipPath = Directory.GetCurrentDirectory() + @"\Profile\ProfileMau.zip";
                if (string.IsNullOrEmpty(nameFolder))
                {
                    nameFolder = RandomString(12);
                }

                string extractPath = Directory.GetCurrentDirectory() + @"\Profile\" + nameFolder;
                if (!Directory.Exists(extractPath))
                {
                    Directory.CreateDirectory(extractPath);
                }
                File.Copy(zipPath, Directory.GetCurrentDirectory() + @"\Profile\" + nameFolder + ".zip", true);
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                return Directory.GetCurrentDirectory() + @"\Profile\" + nameFolder;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message.ToString());
                return null;
            }
            finally
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Profile\" + nameFolder + ".zip");
            }

        }



        public string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public string getFilePath()
        {
            string filePath = "";
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Text Document(*.txt)| *.txt";
            choofdlog.FilterIndex = 1;


            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                filePath = choofdlog.FileName.ToString();
            }

            return filePath;
        }

        public string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public List<List<int>> chiaViTri(int soluong)
        {
            List<List<int>> list = new List<List<int>>();
            if (soluong / 2 > 1)
            {
                //luong
                int sodu = soluong % 2;
                Console.WriteLine(sodu.ToString());
                //luong
                int sochia = soluong / 2;
                int boiWith = Int32.Parse(Screen.PrimaryScreen.Bounds.Width.ToString()) / (sochia + sodu);
                int boiHeight = Int32.Parse(Screen.PrimaryScreen.Bounds.Height.ToString()) / 2;
                int j = 0;
                //luong
                for (int i = 0; i < soluong; i++)
                {
                    List<int> temp = new List<int>();
                    if (i < ((soluong / 2) + sodu))
                    {
                        temp.Add(i * boiWith);
                        temp.Add(0);

                    }
                    else
                    {

                        temp.Add(j * boiWith);
                        temp.Add(boiHeight);
                        j++;
                    }
                    list.Add(temp);
                }
            }
            else
            {
                //luong
                int boiWith = Int32.Parse(Screen.PrimaryScreen.Bounds.Width.ToString()) / soluong;
                //luong
                for (int i = 0; i < soluong; i++)
                {
                    List<int> temp = new List<int>();
                    temp.Add(i * boiWith);
                    temp.Add(0);
                    list.Add(temp);
                }
            }
            string ketqua = "";
            for (int k = 0; k < list.Count; k++)
            {
                List<int> temp = list[k];
                string tempString = "[" + temp[0] + "," + temp[1] + "]";
                ketqua += tempString;
            }
            return list;
        }

        public void WriteLogError(string text)
        {
            try
            {
                locker.AcquireWriterLock(int.MaxValue);
                System.IO.File.AppendAllLines(Directory.GetCurrentDirectory() + @"\ExportData\exportError.txt", new[] { text });
            }
            finally
            {
                locker.ReleaseWriterLock();
            }
        }
    }
}
