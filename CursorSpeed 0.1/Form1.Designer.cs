
namespace CursorSpeed_0._1
{
    partial class Speed
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Speed));
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.BtnSetSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botãoSuspenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.botãoParaDePartidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.limpezarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otimizarRamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSetMouse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSetBackup = new System.Windows.Forms.Button();
            this.BtnSetKeyboard = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.tecladoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testarVelocidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(9, 232);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(336, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.trackBar1_KeyDown);
            // 
            // BtnSetSave
            // 
            this.BtnSetSave.Location = new System.Drawing.Point(354, 235);
            this.BtnSetSave.Name = "BtnSetSave";
            this.BtnSetSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSetSave.TabIndex = 1;
            this.BtnSetSave.Text = "Salvar";
            this.BtnSetSave.UseVisualStyleBackColor = true;
            this.BtnSetSave.Click += new System.EventHandler(this.button1_Click);
            this.BtnSetSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ponteiro antigo: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ponteiro novo: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ajuda: Aperte enter para fazer a alteração ou tente levar o mouse super lento até" +
    " o Salvar.\r\nLembrando ao fechar esse programa ele volta o pc ao normal.\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "https://github.com/WesleyVale99";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label5_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 176);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CursorSpeed_0._1.Properties.Resources.ClipartKey_243923;
            this.pictureBox2.Location = new System.Drawing.Point(69, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CursorSpeed_0._1.Properties.Resources.searchpng_com_splash_facebook_icon_png_image_free_download;
            this.pictureBox1.Location = new System.Drawing.Point(6, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "-";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(452, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botãoSuspenderToolStripMenuItem,
            this.botãoParaDePartidaToolStripMenuItem,
            this.limpezarToolStripMenuItem,
            this.tecladoToolStripMenuItem});
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            // 
            // botãoSuspenderToolStripMenuItem
            // 
            this.botãoSuspenderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.botãoSuspenderToolStripMenuItem.Name = "botãoSuspenderToolStripMenuItem";
            this.botãoSuspenderToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.botãoSuspenderToolStripMenuItem.Text = "Botão Suspender";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // botãoParaDePartidaToolStripMenuItem
            // 
            this.botãoParaDePartidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.botãoParaDePartidaToolStripMenuItem.Name = "botãoParaDePartidaToolStripMenuItem";
            this.botãoParaDePartidaToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.botãoParaDePartidaToolStripMenuItem.Text = "Botão Parada de Partida";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox2.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox2_SelectedIndexChanged);
            this.toolStripComboBox2.Click += new System.EventHandler(this.toolStripComboBox2_Click);
            // 
            // limpezarToolStripMenuItem
            // 
            this.limpezarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otimizarRamToolStripMenuItem,
            this.pastasToolStripMenuItem});
            this.limpezarToolStripMenuItem.Name = "limpezarToolStripMenuItem";
            this.limpezarToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.limpezarToolStripMenuItem.Text = "Limpeza";
            // 
            // otimizarRamToolStripMenuItem
            // 
            this.otimizarRamToolStripMenuItem.Name = "otimizarRamToolStripMenuItem";
            this.otimizarRamToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otimizarRamToolStripMenuItem.Text = "Otimizar Ram";
            this.otimizarRamToolStripMenuItem.Click += new System.EventHandler(this.otimizarRamToolStripMenuItem_Click);
            // 
            // pastasToolStripMenuItem
            // 
            this.pastasToolStripMenuItem.Name = "pastasToolStripMenuItem";
            this.pastasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pastasToolStripMenuItem.Text = "Otimizar PC";
            this.pastasToolStripMenuItem.Click += new System.EventHandler(this.pastasToolStripMenuItem_Click);
            // 
            // btnSetMouse
            // 
            this.btnSetMouse.Location = new System.Drawing.Point(12, 85);
            this.btnSetMouse.Name = "btnSetMouse";
            this.btnSetMouse.Size = new System.Drawing.Size(129, 23);
            this.btnSetMouse.TabIndex = 13;
            this.btnSetMouse.Text = "Aceleração do mouse";
            this.btnSetMouse.UseVisualStyleBackColor = true;
            this.btnSetMouse.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSetMouse);
            this.groupBox2.Controls.Add(this.BtnSetBackup);
            this.groupBox2.Controls.Add(this.BtnSetKeyboard);
            this.groupBox2.Location = new System.Drawing.Point(293, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 123);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Corrigir";
            // 
            // BtnSetBackup
            // 
            this.BtnSetBackup.Location = new System.Drawing.Point(12, 27);
            this.BtnSetBackup.Name = "BtnSetBackup";
            this.BtnSetBackup.Size = new System.Drawing.Size(129, 23);
            this.BtnSetBackup.TabIndex = 15;
            this.BtnSetBackup.Text = "Padrão";
            this.BtnSetBackup.UseVisualStyleBackColor = true;
            this.BtnSetBackup.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnSetKeyboard
            // 
            this.BtnSetKeyboard.Location = new System.Drawing.Point(12, 56);
            this.BtnSetKeyboard.Name = "BtnSetKeyboard";
            this.BtnSetKeyboard.Size = new System.Drawing.Size(129, 23);
            this.BtnSetKeyboard.TabIndex = 14;
            this.BtnSetKeyboard.Text = "Aceleração do Teclado";
            this.BtnSetKeyboard.UseVisualStyleBackColor = true;
            this.BtnSetKeyboard.Click += new System.EventHandler(this.button3_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(383, 164);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(51, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Beep";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(293, 163);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(88, 17);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "Efeito Mouse";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // tecladoToolStripMenuItem
            // 
            this.tecladoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testarVelocidadeToolStripMenuItem});
            this.tecladoToolStripMenuItem.Name = "tecladoToolStripMenuItem";
            this.tecladoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.tecladoToolStripMenuItem.Text = "Teclado";
            // 
            // testarVelocidadeToolStripMenuItem
            // 
            this.testarVelocidadeToolStripMenuItem.Name = "testarVelocidadeToolStripMenuItem";
            this.testarVelocidadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testarVelocidadeToolStripMenuItem.Text = "Testar Velocidade";
            this.testarVelocidadeToolStripMenuItem.Click += new System.EventHandler(this.testarVelocidadeToolStripMenuItem_Click);
            // 
            // Speed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 311);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSetSave);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Speed";
            this.Text = "Cursor Speed 1.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Speed_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Speed_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Speed_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button BtnSetSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem botãoSuspenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Button btnSetMouse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSetKeyboard;
        private System.Windows.Forms.Button BtnSetBackup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem botãoParaDePartidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripMenuItem limpezarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otimizarRamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastasToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ToolStripMenuItem tecladoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testarVelocidadeToolStripMenuItem;
    }
}

