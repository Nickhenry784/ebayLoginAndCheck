using ebayLoginAndCheck.Controllers;
using ebayLoginAndCheck.Models;
using ebayLoginAndCheck.Utils;
using Newtonsoft.Json;
using System.Data.SQLite;

namespace ebayLoginAndCheck.Views
{
    public partial class AddAccount : Form
    {
        UtilsController utilsController;
        SaveData saveData;
        Queue<int> listRunAddAccount;
        Queue<string> listProxy;

        public AddAccount(bool changeProxy)
        {
            InitializeComponent();
            this.StartPosition = Form1.ActiveForm.StartPosition;
            utilsController = new UtilsController();
            saveData = new SaveData();
            if (changeProxy)
            {
                button3.Enabled = false;
                loadAccountFromDatabase();
                textBox1.Enabled = false;
                button2.Text = "Change Proxy";
            }

        }

        #region
        public void loadAccountFromDatabase()
        {
            SQLiteDataReader sQLiteDataReader = saveData.loadDataAccountEbay();
            while (sQLiteDataReader.Read())
            {
                textBox1.AppendText(sQLiteDataReader.GetString(0) + "|" + sQLiteDataReader.GetString(3) + Environment.NewLine);
            }
        }

        public async void addAccount()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Vui lòng thêm tài khoản!", "Thông báo");
                return;
            }
            listProxy = new Queue<string>();
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                if (textBox2.Lines.Length < textBox1.Lines.Length)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn sử dụng lại proxy cho các acc còn lại không? Bấm Yes để sử dụng lại proxy. Bấm No để add thêm proxy", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int k = 0;
                        for (int i = 0; i < textBox1.Lines.Length; i++)
                        {
                            if (textBox2.Lines.Length == k)
                            {
                                k = 0;
                            }
                            if (!string.IsNullOrEmpty(textBox2.Lines[k]))
                                listProxy.Enqueue(textBox2.Lines[k]);
                            k++;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < textBox2.Lines.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(textBox2.Lines[i]))
                            listProxy.Enqueue(textBox2.Lines[i]);
                    }
                }
            }
            for (int j = 0; j < textBox1.Lines.Length; j++)
            {
                string[] stringsVal = textBox1.Lines[j].Split("|");
                saveData.saveAccount(stringsVal[0], stringsVal[1], "Unchecked", listProxy.Dequeue(), "0", "");
            }
            MessageBox.Show("Đã add Account thành công", "Thông báo");
        }

        public void changeAllProxy()
        {
            listProxy = new Queue<string>();
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                if (textBox2.Lines.Length < textBox1.Lines.Length)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn sử dụng lại proxy cho các acc còn lại không? Bấm Yes để sử dụng lại proxy. Bấm No để add thêm proxy", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int k = 0;
                        for (int i = 0; i < textBox1.Lines.Length; i++)
                        {
                            if (textBox2.Lines.Length == k)
                            {
                                k = 0;
                            }
                            if (!string.IsNullOrEmpty(textBox2.Lines[k]))
                                listProxy.Enqueue(textBox2.Lines[k]);
                            k++;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < textBox2.Lines.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(textBox2.Lines[i]))
                            listProxy.Enqueue(textBox2.Lines[i]);
                    }
                }
            }
            listRunAddAccount = new Queue<int>();
            for (int j = 0; j < textBox1.Lines.Length; j++)
            {
                string[] stringsVal = textBox1.Lines[j].Split("|");
                saveData.updateProxyByID(stringsVal[0], listProxy.Dequeue());
            }
            MessageBox.Show("Đã change Proxy thành công", "Thông báo");
        }

        public void readFileAndWriteDatabase()
        {
            while (listRunAddAccount.Count > 0)
            {
                int index = -1;
                try
                {
                    index = listRunAddAccount.Dequeue();
                }
                catch { }
                if (index == -1)
                {
                    return;
                }
                if (!string.IsNullOrEmpty(textBox1.Lines[index]))
                {
                    string[] stringsVal = textBox1.Lines[index].Split('|');
                    if (stringsVal.Length == 1)
                    {
                        try
                        {
                            stringsVal = textBox1.Lines[index].Split(':');
                        }
                        catch { }
                    }
                    try
                    {
                        string proxy = string.Empty;
                        try
                        {
                            proxy = listProxy.Dequeue();
                        }
                        catch { }
                        string[] proxys = proxy.Split(":");
                        string readFile = File.ReadAllText(Directory.GetCurrentDirectory() + @"\Profile\" + stringsVal[1] + @"\Default\Preferences");
                        PreferenceRoot preferenceRoot = JsonConvert.DeserializeObject<PreferenceRoot>(readFile);
                        if (proxys.Length > 2)
                        {
                            preferenceRoot.gologin.proxy.username = proxys[2];
                            preferenceRoot.gologin.proxy.password = proxys[3];
                            string resultChange = JsonConvert.SerializeObject(preferenceRoot);
                            try
                            {
                                File.Delete(Directory.GetCurrentDirectory() + @"\Profile\" + stringsVal[1] + @"\Default\Preferences");
                                Thread.Sleep(1000);
                                File.Create(Directory.GetCurrentDirectory() + @"\Profile\" + stringsVal[1] + @"\Default\Preferences").Dispose();
                            }
                            catch { }
                            finally
                            {
                                File.WriteAllText(Directory.GetCurrentDirectory() + @"\Profile\" + stringsVal[1] + @"\Default\Preferences", resultChange);
                            }
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(preferenceRoot.gologin.proxy.username) && !string.IsNullOrEmpty(preferenceRoot.gologin.proxy.password))
                            {
                                preferenceRoot.gologin.proxy.username = string.Empty;
                                preferenceRoot.gologin.proxy.password = string.Empty;
                                string resultChange = JsonConvert.SerializeObject(preferenceRoot);
                                try
                                {
                                    File.Delete(Directory.GetCurrentDirectory() + @"\Profile\" + stringsVal[1] + @"\Default\Preferences");
                                    Thread.Sleep(1000);
                                    File.Create(Directory.GetCurrentDirectory() + @"\Profile\" + stringsVal[1] + @"\Default\Preferences").Dispose();
                                }
                                catch { }
                                finally
                                {
                                    File.WriteAllText(Directory.GetCurrentDirectory() + @"\Profile\" + stringsVal[1] + @"\Default\Preferences", resultChange);
                                }
                            }
                        }
                        saveData.updateProxyByID(stringsVal[0], proxy);
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err.Message);
                        Console.WriteLine("Error");
                    }
                    Thread.Sleep(1000);
                }
            }
        }

        public void createProfileAndWriteDatabase()
        {
            while (listRunAddAccount.Count > 0)
            {
                int index = -1;
                try
                {
                    index = listRunAddAccount.Dequeue();
                }
                catch { }
                if (index == -1)
                {
                    return;
                }
                if (!string.IsNullOrEmpty(textBox1.Lines[index]))
                {
                    string[] stringsVal = textBox1.Lines[index].Split('|');
                    if (stringsVal.Length == 1)
                    {
                        try
                        {
                            stringsVal = textBox1.Lines[index].Split(':');
                        }
                        catch { }
                    }
                    try
                    {
                        string proxy = string.Empty;
                        try
                        {
                            proxy = listProxy.Dequeue();
                        }
                        catch { }
                        CreateProfileController profile = new CreateProfileController();
                        ProfileResult profileResult = new ProfileResult();
                        if (string.IsNullOrEmpty(proxy))
                        {
                            profileResult = profile.createProfileResult("win", "");
                        }
                        else
                        {
                            profileResult = profile.createProfileResult("win", proxy);
                        }

                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err.Message);
                        Console.WriteLine("Error");
                    }
                }
            }
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string[] strings = File.ReadAllLines(utilsController.getFilePath());
                for (int i = 0; i < strings.Length; i++)
                {
                    if (!string.IsNullOrEmpty(strings[i]))
                    {
                        if (i != strings.Length - 1)
                        {
                            textBox1.AppendText(strings[i] + Environment.NewLine);
                        }
                        else
                        {
                            textBox1.AppendText(strings[i]);
                        }

                    }
                }
            }
            catch { }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string[] strings = File.ReadAllLines(utilsController.getFilePath());
                for (int i = 0; i < strings.Length; i++)
                {
                    if (!string.IsNullOrEmpty(strings[i]))
                    {
                        if (i != strings.Length - 1)
                        {
                            textBox2.AppendText(strings[i] + Environment.NewLine);
                        }
                        else
                        {
                            textBox2.AppendText(strings[i]);
                        }

                    }
                }
            }
            catch { }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text.Equals("Change Proxy"))
            {
                Task.Run(() =>
                {
                    changeAllProxy();
                });
            }
            else
            {
                Task.Run(() =>
                {
                    addAccount();
                });
            }
        }
    }
}
