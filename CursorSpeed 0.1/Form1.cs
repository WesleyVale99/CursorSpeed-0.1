using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace CursorSpeed_0._1
{
    public partial class Speed : Form
    {
        public string Button = "none";
        public bool regular = false;
        public Speed()
        {
            try
            {
                if (MessageBox.Show("Não me responsabilizo por qualquer dano ou alteração em seu Windows, Deseja fazer 1 ponto de restauração? ", "CursorSpeed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (Process process = new Process())
                    {
                        process.StartInfo.FileName = "rstrui.exe";
                        process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                        process.Start();
                        process.Close();
                    }
                }
                InitializeComponent();
                new Thread(new ThreadStart(LoadInfo)).Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangerFctn();
        }
        private void LoadInfo()
        {
            InfoCursor.GetOldSensi = MouseOption.GetMouseSpeed();
            InfoCursor.GetPointerAceleration = MouseOption.GetPointerAcelerarion();
            InfoCursor.GetPointerPerfect = MouseOption.GetPoimprovepointer();
            label1.Text = string.Format("Ponteiro antigo: {0}", InfoCursor.GetOldSensi);
            InfoCursor.CheckKeyboard = MouseOption.GetAcelerationKeyBoard() > 0 || MouseOption.GetDelayKeyBoard() < 4;
            if (Windows().Contains("Windows 7") ||
                Windows().Contains("Windows XP") ||
                Windows().Contains("Windows 2000") ||
                Windows().Contains("Windows 95") ||
               Windows().Contains("Windows 98"))
            {
                btnSetMouse.Enabled = false;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            InfoCursor.GetNewSensi = trackBar1.Value;
            label4.Text = string.Concat(trackBar1.Value);
        }
        private void ChangerFctn()
        {
            if (toolStripComboBox1.SelectedIndex > 0)
            {
                if(Button == "none")
                {
                    MessageBox.Show("Escolha um botão de parada de partida nas configurações.", "CursorSpeed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (InfoCursor.GetNewSensi > 0)
                {
                    MouseOption.SetMouseSpeed(trackBar1.Value);
                    label2.Text = string.Format("Ponteiro novo: {0}", InfoCursor.GetNewSensi);
                    MessageBox.Show("Função Alterada com sucesso.", "CursorSpeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // WindowState = FormWindowState.Minimized;
                }
                else
                {
                    MessageBox.Show("Você precisa realizar alguma função para ocorrer a mudança.", "CursorSpeed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Escolha um botão de suspender nas configurações.", "CursorSpeed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Speed_MouseMove(object sender, MouseEventArgs e)
        {
            label6.Text = string.Format("{0} {1}", Cursor.Position, Cursor.Current);
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChangerFctn();
            }
        }
        private void Speed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChangerFctn();
            }
        }
        private void trackBar1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChangerFctn();
            }
        }
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc); protected override void WndProc(ref Message m)
        {

            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();
                if (id == 1)
                {
                    if (InfoCursor.GetNewSensi == 0)
                        return;
                    if (!regular)
                    {
                        regular = true;
                        MouseOption.SetMouseSpeed(10);
                        trackBar1.Value = 10;
                        label2.Text = string.Format("Ponteiro novo: {0}", 10);
                        label4.Text = string.Concat(trackBar1.Value);
                        SendKeys.Send("{F1}");
                        // Cursor.Hide();

                    }
                    else
                    {
                        if(checkBox1.Checked){
                            for (int i = 0; i < 3; i++)
                                Console.Beep();
                        }
                        SendKeys.Send("{F1}");
                        regular = false;
                        MouseOption.SetMouseSpeed(InfoCursor.GetNewSensi);
                        trackBar1.Value = InfoCursor.GetNewSensi;
                        label2.Text = string.Format("Ponteiro novo: {0}", InfoCursor.GetNewSensi);
                        label4.Text = string.Concat(trackBar1.Value);
                        // Cursor.Show();
                    }
                }
            }
            base.WndProc(ref m);
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Items.Count == 0)
            {
                var Keys = Enum.GetNames(typeof(Keys));
                for (int i = 0; i < Keys.Length; i++)
                {
                    Application.DoEvents();
                    toolStripComboBox1.Items.Add(Keys[i]);
                }
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedIndex > 0)
            {
                string[] Keys = Enum.GetNames(typeof(Keys));
                for (int i = 0; i < Keys.Length; i++)
                {
                    Application.DoEvents();
                    if (Keys[i] == (string)toolStripComboBox1.SelectedItem)
                    {
                        object value = Enum.Parse(typeof(Keys), Keys[i]);
                        bool isRegistry = RegisterHotKey(Handle, 1, 0x0000, (int)value);
                        if (isRegistry)
                        {
                            toolStripComboBox1.Enabled = false;
                            MessageBox.Show("Tecla suspender adicionada com sucesso. ", "CursorSpeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }
                }
            }
        }
        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox2.Items.Count == 0)
            {
                var Keys = Enum.GetNames(typeof(Keys));
                for (int i = 0; i < Keys.Length; i++)
                {
                    Application.DoEvents();
                    toolStripComboBox2.Items.Add(Keys[i]);
                }
            }
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox2.SelectedIndex > 0)
            {
                string[] Keys = Enum.GetNames(typeof(Keys));
                for (int i = 0; i < Keys.Length; i++)
                {
                    Application.DoEvents();
                    if (Keys[i] == (string)toolStripComboBox2.SelectedItem)
                    {
                        Button = Keys[i];
                        toolStripComboBox2.Enabled = false;
                        MessageBox.Show("Tecla parada de partida adicionada com sucesso. ", "CursorSpeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (MouseOption.SetPoimprovepointer(0) == 1)
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Mouse", true))
                {
                    key.SetValue("MouseThreshold1", 0, RegistryValueKind.String);
                    key.SetValue("MouseThreshold2", 0, RegistryValueKind.String);
                    //key.SetValue("SmoothMouseXCurve", new byte[] { 00, 00, 00, 00, 00, 00, 00, 00, 192, 204, 192, 00, 00, 00, 00, 00, 80, 99, 19, 00, 00, 00, 00, 00, 40, 66, 26, 00, 00, 00, 00, 00, 00, 33, 33, 00, 00, 00, 00, 00 }, RegistryValueKind.Binary);
                    //key.SetValue("SmoothMouseYCurve", new byte[] { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 38, 00, 00, 00, 00, 00, 00, 00, 70, 00, 00, 00, 00, 00, 00, 00, 168, 00, 00, 00, 00, 00, 00, 00, 224, 00, 00, 00, 00, 00 }, RegistryValueKind.Binary);

                    key.SetValue("SmoothMouseXCurve", new byte[] { 00, 00, 00, 00, 00, 00, 00, 00, 240, 255, 15, 00, 00, 00, 00, 00, 224, 255, 31, 00, 00, 00, 00, 00, 208, 255, 47, 00, 00, 00, 00, 00, 192, 255, 63, 00, 00, 00, 00, 00 }, RegistryValueKind.Binary);
                    key.SetValue("SmoothMouseYCurve", new byte[] { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 38, 00, 00, 00, 00, 00, 00, 00, 70, 00, 00, 00, 00, 00, 00, 00, 168, 00, 00, 00, 00, 00, 00, 00, 224, 00, 00, 00, 00, 00 }, RegistryValueKind.Binary);
                    key.Close();
                }
                if (InfoCursor.CheckKeyboard)
                {
                    using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Keyboard", true))
                    {
                        key.SetValue("KeyboardDelay", 3, RegistryValueKind.String);
                        key.Close();
                    }
                }
                MessageBox.Show(string.Format("Você vai precisar reiniciar seu pc!"), "CursorSpeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MouseOption.SetMouseSpeed(10);
            trackBar1.Value = 10;
            label2.Text = string.Format("Ponteiro novo: {0}", trackBar1.Value);
            label4.Text = string.Concat(trackBar1.Value);
            if (MouseOption.SetPoimprovepointer(1) == 1)
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Mouse", true))
                {
                    key.SetValue("MouseThreshold1", 6, RegistryValueKind.String);
                    key.SetValue("MouseThreshold2", 10, RegistryValueKind.String);
                    key.SetValue("SmoothMouseXCurve", new byte[] { 00, 00, 00, 00, 00, 00, 00, 00, 15, 110, 00, 00, 00, 00, 00, 00, 00, 40, 01, 00, 00, 00, 00, 00, 29, 220, 03, 00, 00, 00, 00, 00, 00, 00, 28, 00, 00, 00, 00, 00 }, RegistryValueKind.Binary);
                    key.SetValue("SmoothMouseYCurve", new byte[] { 00, 00, 00, 00, 00, 00, 00, 00, 253, 11, 01, 00, 00, 00, 00, 00, 00, 24, 04, 00, 00, 00, 00, 00, 00, 252, 12, 00, 00, 00, 00, 00, 00, 192, 187, 01, 00, 00, 00, 00 }, RegistryValueKind.Binary);
                    key.Close();
                }
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Keyboard", true))
                {
                    key.SetValue("KeyboardDelay", 2, RegistryValueKind.String);
                    key.SetValue("KeyboardSpeed", 15, RegistryValueKind.String);
                    key.Close();
                }
                MessageBox.Show(string.Format("Você vai precisar reiniciar seu pc!"), "CursorSpeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (InfoCursor.CheckKeyboard)
            {
                MouseOption.SetAcelerationKeyBoard(0, 3);
                MessageBox.Show("Função Alterada com sucesso.", "CursorSpeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Você já alterou essa função.", "CursorSpeed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static string Windows()
        {
            string r = "";
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem"))
            {
                ManagementObjectCollection information = searcher.Get();
                if (information != null)
                {
                    foreach (ManagementObject obj in information)
                    {
                        r = obj["Caption"].ToString() + " - " + obj["OSArchitecture"].ToString();
                    }
                }
                r = r.Replace("NT 5.1.2600", "XP");
                r = r.Replace("NT 5.2.3790", "Server 2003");
            }
            return r;
        }

        private void Speed_FormClosing(object sender, FormClosingEventArgs e)
        {
            MouseOption.SetMouseSpeed(InfoCursor.GetOldSensi);
            MouseOption.SetPoimprovepointer(Convert.ToInt32(InfoCursor.GetPointerPerfect));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/wesley.93131/");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/_wslyvale/");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/WesleyVale99");
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            label5.ForeColor = Color.Blue;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            if(toolStripComboBox1.Text == "Digite...")
            {
                toolStripComboBox1.Text = "";
            }
        }

        private void otimizarRamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GC.Collect(2, GCCollectionMode.Forced);
            MessageBox.Show("Limpado com sucesso.", "CursorSpeed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pastasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int clear = 0;
            int NotClear = 0;

            string MainPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            DirectoryInfo Temps = new DirectoryInfo(MainPath + @"\AppData\Local\Temp");
            if (Temps.Exists)
            {
                FileInfo[] array1 = Temps.GetFiles();
                for (int i = 0; i < array1.Length; i++)
                {
                    try
                    {
                        array1[i].Delete();
                        clear++;
                    }
                    catch
                    {
                        NotClear++;
                    }
                }
                DirectoryInfo[] array2 = Temps.GetDirectories();
                for (int i = 0; i < array2.Length; i++)
                {
                    try
                    {
                        array2[i].Delete(true);
                        clear++;
                    }
                    catch
                    {
                        NotClear++;
                    }
                }
            }

            DirectoryInfo Prefetch = new DirectoryInfo(@"c:\\windows\prefetch");
            if (Prefetch.Exists)
            {
                FileInfo[] array1 = Prefetch.GetFiles();
                for (int i = 0; i < array1.Length; i++)
                {
                    try
                    {
                        array1[i].Delete();
                        clear++;
                    }
                    catch
                    {
                        NotClear++;
                    }
                }
            }
            MessageBox.Show(string.Format("Foram Limpados. {0} arquivos inuteis | não limpados {1}", clear, NotClear), "CursorSpeed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}