using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace CursorSpeed_0._1
{
    public partial class Speed : Form
    {
        public bool regular = false;
        public Speed()
        {
            InitializeComponent();
            new Thread(new ThreadStart(LoadInfo)).Start();
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
            InfoCursor.CheckKeyboard = MouseOption.GetAcelerationKeyBoard() > 0 || MouseOption.GetDelayKeyBoard() > 0;
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
                if (InfoCursor.GetNewSensi > 0)
                {
                    MouseOption.SetMouseSpeed(trackBar1.Value);
                    label2.Text = string.Format("Ponteiro novo: {0}", InfoCursor.GetNewSensi);
                    MessageBox.Show("Função Alterada com sucesso.");
                    // WindowState = FormWindowState.Minimized;
                }
                else
                {
                    MessageBox.Show("Você precisa realizar alguma função para ocorrer a mudança.");
                }
            }
            else
            {
                MessageBox.Show("Escolha um botão de suspender nas configurações.");
            }
        }

        private void Speed_MouseMove(object sender, MouseEventArgs e)
        {
            label6.Text = "Position Test: " + Cursor.Position;
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
                        label4.Text = string.Concat(trackBar1.Value); Cursor.Hide();

                    }
                    else
                    {
                        regular = false;
                        MouseOption.SetMouseSpeed(InfoCursor.GetNewSensi);
                        trackBar1.Value = InfoCursor.GetNewSensi;
                        label2.Text = string.Format("Ponteiro novo: {0}", InfoCursor.GetNewSensi);
                        label4.Text = string.Concat(trackBar1.Value);
                        Cursor.Show();
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
                            MessageBox.Show(string.Format("Tecla suspender adicionada com sucesso. {0}", (Keys)value));
                            break;
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MouseOption.SetPoimprovepointer(1) == 1)
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Mouse", true))
                {
                    key.SetValue("MouseThreshold1", 0, RegistryValueKind.String);
                    key.SetValue("MouseThreshold2", 0, RegistryValueKind.String);
                    key.Close();
                }
                MessageBox.Show(string.Format("Você vai precisar reiniciar seu pc!"));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MouseOption.SetMouseSpeed(10);
            trackBar1.Value = 10;
            label2.Text = string.Format("Ponteiro novo: {0}", trackBar1.Value);
            label4.Text = string.Concat(trackBar1.Value);
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"Computador\HKEY_CURRENT_USER\Control Panel\Mouse", true))
            {
                key.SetValue("MouseThreshold1", 6);
                key.SetValue("MouseThreshold2", 16);
            }
            MessageBox.Show(string.Format("Você vai precisar reiniciar seu pc!"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (InfoCursor.CheckKeyboard)
            {
                MouseOption.SetAcelerationKeyBoard(0, 0);
                MessageBox.Show("Função Alterada com sucesso.");
            }
            else
            {
                MessageBox.Show("Você já alterou essa função.");
            }
        }
    }
}