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
            label1.Text = string.Format("Ponteiro antigo: {0}", InfoCursor.GetOldSensi);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            InfoCursor.GetNewSensi = trackBar1.Value;
            label4.Text = string.Concat(trackBar1.Value);
        }

        private void Speed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChangerFctn();
            }
        }
        private void ChangerFctn()
        {
            if (checkBox3.Checked)
            {
                MessageBox.Show("O Botão Backup só funciona se você desejar sair do programa sem perder nada, das configurações anteriores. \n" +
                    "ajuda: ative o botão backup e feche o programa.");
                return;
            }

            if (InfoCursor.GetNewSensi > 0)
            {
                MouseOption.SetMouseSpeed(trackBar1.Value);
                label2.Text = string.Format("Ponteiro novo: {0}", InfoCursor.GetNewSensi);
                if (!checkBox2.Checked)
                {
                    MouseOption.SetAcelerationMouse();
                }
                MessageBox.Show("Função Alterada com sucesso.");
            }
            else
            {
                MessageBox.Show("Você precisa realizar alguma função para ocorrer a mudança.");
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

        private void Speed_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkBox3.Checked)
            {
                MouseOption.SetMouseSpeed(InfoCursor.GetOldSensi);
                MessageBox.Show("Seu Mouse voltou ao padrão que você definiu, antes de usar esse programa.");
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
                    }
                    else
                    {
                        regular = false;
                        MouseOption.SetMouseSpeed(InfoCursor.GetNewSensi);
                        trackBar1.Value = InfoCursor.GetNewSensi;
                        label2.Text = string.Format("Ponteiro novo: {0}", InfoCursor.GetNewSensi);
                        label4.Text = string.Concat(trackBar1.Value);
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
                    }
                    break;
                }
            }
        }
    }
}