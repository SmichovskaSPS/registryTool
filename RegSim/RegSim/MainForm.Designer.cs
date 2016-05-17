namespace RegSim
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.simulator = new System.Windows.Forms.PictureBox();
            this.otevritButton = new System.Windows.Forms.Button();
            this.napovedaButton = new System.Windows.Forms.Button();
            this.vyberKey = new System.Windows.Forms.OpenFileDialog();
            this.keyboardOutputTextBox = new System.Windows.Forms.TextBox();
            this.lista = new System.Windows.Forms.PictureBox();
            this.winIcon = new System.Windows.Forms.PictureBox();
            this.notepad = new System.Windows.Forms.PictureBox();
            this.closeNotepadButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.tentoPocitac = new System.Windows.Forms.PictureBox();
            this.kos = new System.Windows.Forms.PictureBox();
            this.folder = new System.Windows.Forms.PictureBox();
            this.sm_notepad = new System.Windows.Forms.PictureBox();
            this.sm_tentoPocitac = new System.Windows.Forms.PictureBox();
            this.sm_kos = new System.Windows.Forms.PictureBox();
            this.sm_folder = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.PictureBox();
            this.language = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.TextBox();
            this.plochaContextNovaSlozka = new System.Windows.Forms.Button();
            this.plochaContextNastaveniZobrazeni = new System.Windows.Forms.Button();
            this.plochaContextPrizpusobit = new System.Windows.Forms.Button();
            this.kosContextOtevrit = new System.Windows.Forms.Button();
            this.kosContextVysypatKos = new System.Windows.Forms.Button();
            this.tentoPCContextOtevrit = new System.Windows.Forms.Button();
            this.tentoPCContextSpravovat = new System.Windows.Forms.Button();
            this.listaContextSpravceUloh = new System.Windows.Forms.Button();
            this.notepadContextOtevrit = new System.Windows.Forms.Button();
            this.folderContextOtevrit = new System.Windows.Forms.Button();
            this.jazykContext = new System.Windows.Forms.Button();
            this.closeDesktopContext = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.simulator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notepad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tentoPocitac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sm_notepad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sm_tentoPocitac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sm_kos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sm_folder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeDesktopContext)).BeginInit();
            this.SuspendLayout();
            // 
            // simulator
            // 
            this.simulator.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.simulator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("simulator.BackgroundImage")));
            this.simulator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simulator.Location = new System.Drawing.Point(1, 53);
            this.simulator.Name = "simulator";
            this.simulator.Size = new System.Drawing.Size(845, 660);
            this.simulator.TabIndex = 0;
            this.simulator.TabStop = false;
            this.simulator.Click += new System.EventHandler(this.simulator_Click);
            this.simulator.MouseClick += new System.Windows.Forms.MouseEventHandler(this.simulator_MouseClick);
            // 
            // otevritButton
            // 
            this.otevritButton.Location = new System.Drawing.Point(26, 13);
            this.otevritButton.Name = "otevritButton";
            this.otevritButton.Size = new System.Drawing.Size(107, 23);
            this.otevritButton.TabIndex = 1;
            this.otevritButton.Text = "Otevřít";
            this.otevritButton.UseVisualStyleBackColor = true;
            this.otevritButton.Click += new System.EventHandler(this.otevritButton_Click);
            // 
            // napovedaButton
            // 
            this.napovedaButton.Location = new System.Drawing.Point(151, 13);
            this.napovedaButton.Name = "napovedaButton";
            this.napovedaButton.Size = new System.Drawing.Size(75, 23);
            this.napovedaButton.TabIndex = 2;
            this.napovedaButton.Text = "Nápověda";
            this.napovedaButton.UseVisualStyleBackColor = true;
            this.napovedaButton.Click += new System.EventHandler(this.napovedaButton_Click);
            // 
            // vyberKey
            // 
            this.vyberKey.FileName = "vyberKey";
            // 
            // keyboardOutputTextBox
            // 
            this.keyboardOutputTextBox.Location = new System.Drawing.Point(137, 178);
            this.keyboardOutputTextBox.Multiline = true;
            this.keyboardOutputTextBox.Name = "keyboardOutputTextBox";
            this.keyboardOutputTextBox.Size = new System.Drawing.Size(544, 374);
            this.keyboardOutputTextBox.TabIndex = 4;
            this.keyboardOutputTextBox.Visible = false;
            // 
            // lista
            // 
            this.lista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lista.BackgroundImage")));
            this.lista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lista.Location = new System.Drawing.Point(1, 652);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(845, 61);
            this.lista.TabIndex = 5;
            this.lista.TabStop = false;
            this.lista.Click += new System.EventHandler(this.lista_Click);
            this.lista.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lista_MouseClick);
            // 
            // winIcon
            // 
            this.winIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.winIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("winIcon.BackgroundImage")));
            this.winIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.winIcon.Location = new System.Drawing.Point(8, 657);
            this.winIcon.Name = "winIcon";
            this.winIcon.Size = new System.Drawing.Size(50, 50);
            this.winIcon.TabIndex = 6;
            this.winIcon.TabStop = false;
            this.winIcon.Click += new System.EventHandler(this.winIcon_Click);
            // 
            // notepad
            // 
            this.notepad.BackColor = System.Drawing.Color.White;
            this.notepad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("notepad.BackgroundImage")));
            this.notepad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.notepad.Location = new System.Drawing.Point(26, 77);
            this.notepad.Name = "notepad";
            this.notepad.Size = new System.Drawing.Size(60, 60);
            this.notepad.TabIndex = 7;
            this.notepad.TabStop = false;
            this.notepad.Click += new System.EventHandler(this.notepad_Click);
            this.notepad.DoubleClick += new System.EventHandler(this.notepad_DoubleClick);
            this.notepad.LostFocus += new System.EventHandler(this.notepad_LostFocus);
            this.notepad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notepad_MouseClick);
            // 
            // closeNotepadButton
            // 
            this.closeNotepadButton.BackColor = System.Drawing.Color.White;
            this.closeNotepadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeNotepadButton.BackgroundImage")));
            this.closeNotepadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeNotepadButton.Location = new System.Drawing.Point(650, 149);
            this.closeNotepadButton.Name = "closeNotepadButton";
            this.closeNotepadButton.Size = new System.Drawing.Size(30, 30);
            this.closeNotepadButton.TabIndex = 8;
            this.closeNotepadButton.UseVisualStyleBackColor = false;
            this.closeNotepadButton.Visible = false;
            this.closeNotepadButton.Click += new System.EventHandler(this.closeNotepadButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(749, 13);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // tentoPocitac
            // 
            this.tentoPocitac.BackColor = System.Drawing.Color.White;
            this.tentoPocitac.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tentoPocitac.BackgroundImage")));
            this.tentoPocitac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tentoPocitac.Location = new System.Drawing.Point(26, 150);
            this.tentoPocitac.Name = "tentoPocitac";
            this.tentoPocitac.Size = new System.Drawing.Size(60, 60);
            this.tentoPocitac.TabIndex = 10;
            this.tentoPocitac.TabStop = false;
            this.tentoPocitac.Click += new System.EventHandler(this.tentoPocitac_Click);
            this.tentoPocitac.DoubleClick += new System.EventHandler(this.tentoPocitac_DoubleClick);
            this.tentoPocitac.LostFocus += new System.EventHandler(this.tentoPocitac_LostFocus);
            this.tentoPocitac.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tentoPocitac_MouseClick);
            // 
            // kos
            // 
            this.kos.BackColor = System.Drawing.Color.White;
            this.kos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kos.BackgroundImage")));
            this.kos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.kos.Location = new System.Drawing.Point(26, 224);
            this.kos.Name = "kos";
            this.kos.Size = new System.Drawing.Size(60, 60);
            this.kos.TabIndex = 11;
            this.kos.TabStop = false;
            this.kos.Click += new System.EventHandler(this.kos_Click);
            this.kos.DoubleClick += new System.EventHandler(this.kos_DoubleClick);
            this.kos.LostFocus += new System.EventHandler(this.kos_LostFocus);
            this.kos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kos_MouseClick);
            // 
            // folder
            // 
            this.folder.BackColor = System.Drawing.Color.White;
            this.folder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("folder.BackgroundImage")));
            this.folder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.folder.Location = new System.Drawing.Point(26, 298);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(60, 60);
            this.folder.TabIndex = 12;
            this.folder.TabStop = false;
            this.folder.Click += new System.EventHandler(this.folder_Click);
            this.folder.DoubleClick += new System.EventHandler(this.folder_DoubleClick);
            this.folder.LostFocus += new System.EventHandler(this.folder_LostFocus);
            this.folder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.folder_MouseClick);
            // 
            // sm_notepad
            // 
            this.sm_notepad.BackColor = System.Drawing.Color.White;
            this.sm_notepad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sm_notepad.BackgroundImage")));
            this.sm_notepad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sm_notepad.Location = new System.Drawing.Point(99, 657);
            this.sm_notepad.Name = "sm_notepad";
            this.sm_notepad.Size = new System.Drawing.Size(50, 50);
            this.sm_notepad.TabIndex = 13;
            this.sm_notepad.TabStop = false;
            this.sm_notepad.Click += new System.EventHandler(this.sm_notepad_Click);
            this.sm_notepad.MouseEnter += new System.EventHandler(this.sm_notepad_MouseEnter);
            this.sm_notepad.MouseLeave += new System.EventHandler(this.sm_notepad_MouseLeave);
            // 
            // sm_tentoPocitac
            // 
            this.sm_tentoPocitac.BackColor = System.Drawing.Color.White;
            this.sm_tentoPocitac.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sm_tentoPocitac.BackgroundImage")));
            this.sm_tentoPocitac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sm_tentoPocitac.Location = new System.Drawing.Point(167, 657);
            this.sm_tentoPocitac.Name = "sm_tentoPocitac";
            this.sm_tentoPocitac.Size = new System.Drawing.Size(50, 50);
            this.sm_tentoPocitac.TabIndex = 14;
            this.sm_tentoPocitac.TabStop = false;
            this.sm_tentoPocitac.Click += new System.EventHandler(this.sm_tentoPocitac_Click);
            this.sm_tentoPocitac.MouseEnter += new System.EventHandler(this.sm_tentoPocitac_MouseEnter);
            this.sm_tentoPocitac.MouseLeave += new System.EventHandler(this.sm_tentoPocitac_MouseLeave);
            // 
            // sm_kos
            // 
            this.sm_kos.BackColor = System.Drawing.Color.White;
            this.sm_kos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sm_kos.BackgroundImage")));
            this.sm_kos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sm_kos.Location = new System.Drawing.Point(235, 657);
            this.sm_kos.Name = "sm_kos";
            this.sm_kos.Size = new System.Drawing.Size(50, 50);
            this.sm_kos.TabIndex = 15;
            this.sm_kos.TabStop = false;
            this.sm_kos.Click += new System.EventHandler(this.sm_kos_Click);
            this.sm_kos.MouseEnter += new System.EventHandler(this.sm_kos_MouseEnter);
            this.sm_kos.MouseLeave += new System.EventHandler(this.sm_kos_MouseLeave);
            // 
            // sm_folder
            // 
            this.sm_folder.BackColor = System.Drawing.Color.White;
            this.sm_folder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sm_folder.BackgroundImage")));
            this.sm_folder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sm_folder.Location = new System.Drawing.Point(302, 657);
            this.sm_folder.Name = "sm_folder";
            this.sm_folder.Size = new System.Drawing.Size(50, 50);
            this.sm_folder.TabIndex = 16;
            this.sm_folder.TabStop = false;
            this.sm_folder.Click += new System.EventHandler(this.sm_folder_Click);
            this.sm_folder.MouseEnter += new System.EventHandler(this.sm_folder_MouseEnter);
            this.sm_folder.MouseLeave += new System.EventHandler(this.sm_folder_MouseLeave);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("start.BackgroundImage")));
            this.start.Location = new System.Drawing.Point(1, 345);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(249, 307);
            this.start.TabIndex = 17;
            this.start.TabStop = false;
            this.start.Visible = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            this.start.LostFocus += new System.EventHandler(this.start_LostFocus);
            // 
            // language
            // 
            this.language.BackColor = System.Drawing.Color.White;
            this.language.Location = new System.Drawing.Point(714, 672);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(30, 23);
            this.language.TabIndex = 19;
            this.language.Text = "CS";
            this.language.UseVisualStyleBackColor = false;
            this.language.Click += new System.EventHandler(this.language_Click);
            this.language.LostFocus += new System.EventHandler(this.language_LostFocus);
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Location = new System.Drawing.Point(755, 674);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(61, 20);
            this.date.TabIndex = 22;
            this.date.Text = "01.01.2016";
            // 
            // plochaContextNovaSlozka
            // 
            this.plochaContextNovaSlozka.Location = new System.Drawing.Point(701, 162);
            this.plochaContextNovaSlozka.Name = "plochaContextNovaSlozka";
            this.plochaContextNovaSlozka.Size = new System.Drawing.Size(123, 23);
            this.plochaContextNovaSlozka.TabIndex = 24;
            this.plochaContextNovaSlozka.Text = "Nová složka";
            this.plochaContextNovaSlozka.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.plochaContextNovaSlozka.UseVisualStyleBackColor = true;
            this.plochaContextNovaSlozka.Visible = false;
            this.plochaContextNovaSlozka.Click += new System.EventHandler(this.plochaContextNovaSlozka_Click);
            // 
            // plochaContextNastaveniZobrazeni
            // 
            this.plochaContextNastaveniZobrazeni.Location = new System.Drawing.Point(701, 185);
            this.plochaContextNastaveniZobrazeni.Name = "plochaContextNastaveniZobrazeni";
            this.plochaContextNastaveniZobrazeni.Size = new System.Drawing.Size(123, 23);
            this.plochaContextNastaveniZobrazeni.TabIndex = 25;
            this.plochaContextNastaveniZobrazeni.Text = "Nastavení zobrazení";
            this.plochaContextNastaveniZobrazeni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.plochaContextNastaveniZobrazeni.UseVisualStyleBackColor = true;
            this.plochaContextNastaveniZobrazeni.Visible = false;
            this.plochaContextNastaveniZobrazeni.Click += new System.EventHandler(this.plochaContextNastaveniZobrazeni_Click);
            // 
            // plochaContextPrizpusobit
            // 
            this.plochaContextPrizpusobit.Location = new System.Drawing.Point(701, 208);
            this.plochaContextPrizpusobit.Name = "plochaContextPrizpusobit";
            this.plochaContextPrizpusobit.Size = new System.Drawing.Size(123, 23);
            this.plochaContextPrizpusobit.TabIndex = 26;
            this.plochaContextPrizpusobit.Text = "Přizpůsobit";
            this.plochaContextPrizpusobit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.plochaContextPrizpusobit.UseVisualStyleBackColor = true;
            this.plochaContextPrizpusobit.Visible = false;
            this.plochaContextPrizpusobit.Click += new System.EventHandler(this.plochaContextPrizpusobit_Click);
            // 
            // kosContextOtevrit
            // 
            this.kosContextOtevrit.Location = new System.Drawing.Point(92, 224);
            this.kosContextOtevrit.Name = "kosContextOtevrit";
            this.kosContextOtevrit.Size = new System.Drawing.Size(75, 23);
            this.kosContextOtevrit.TabIndex = 27;
            this.kosContextOtevrit.Text = "Otevřít";
            this.kosContextOtevrit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kosContextOtevrit.UseVisualStyleBackColor = true;
            this.kosContextOtevrit.Visible = false;
            this.kosContextOtevrit.Click += new System.EventHandler(this.kosContextOtevrit_Click);
            // 
            // kosContextVysypatKos
            // 
            this.kosContextVysypatKos.Location = new System.Drawing.Point(92, 247);
            this.kosContextVysypatKos.Name = "kosContextVysypatKos";
            this.kosContextVysypatKos.Size = new System.Drawing.Size(75, 23);
            this.kosContextVysypatKos.TabIndex = 28;
            this.kosContextVysypatKos.Text = "Vysypat koš";
            this.kosContextVysypatKos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kosContextVysypatKos.UseVisualStyleBackColor = true;
            this.kosContextVysypatKos.Visible = false;
            this.kosContextVysypatKos.Click += new System.EventHandler(this.kosContextVysypatKos_Click);
            // 
            // tentoPCContextOtevrit
            // 
            this.tentoPCContextOtevrit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tentoPCContextOtevrit.Location = new System.Drawing.Point(92, 149);
            this.tentoPCContextOtevrit.Name = "tentoPCContextOtevrit";
            this.tentoPCContextOtevrit.Size = new System.Drawing.Size(75, 23);
            this.tentoPCContextOtevrit.TabIndex = 29;
            this.tentoPCContextOtevrit.Text = "Otevřít";
            this.tentoPCContextOtevrit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tentoPCContextOtevrit.UseVisualStyleBackColor = true;
            this.tentoPCContextOtevrit.Visible = false;
            this.tentoPCContextOtevrit.Click += new System.EventHandler(this.tentoPCContextOtevrit_Click);
            // 
            // tentoPCContextSpravovat
            // 
            this.tentoPCContextSpravovat.Location = new System.Drawing.Point(92, 172);
            this.tentoPCContextSpravovat.Name = "tentoPCContextSpravovat";
            this.tentoPCContextSpravovat.Size = new System.Drawing.Size(75, 23);
            this.tentoPCContextSpravovat.TabIndex = 30;
            this.tentoPCContextSpravovat.Text = "Spravovat";
            this.tentoPCContextSpravovat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tentoPCContextSpravovat.UseVisualStyleBackColor = true;
            this.tentoPCContextSpravovat.Visible = false;
            this.tentoPCContextSpravovat.Click += new System.EventHandler(this.tentoPCContextSpravovat_Click);
            // 
            // listaContextSpravceUloh
            // 
            this.listaContextSpravceUloh.Location = new System.Drawing.Point(473, 642);
            this.listaContextSpravceUloh.Name = "listaContextSpravceUloh";
            this.listaContextSpravceUloh.Size = new System.Drawing.Size(96, 23);
            this.listaContextSpravceUloh.TabIndex = 31;
            this.listaContextSpravceUloh.Text = "Správce úloh";
            this.listaContextSpravceUloh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listaContextSpravceUloh.UseVisualStyleBackColor = true;
            this.listaContextSpravceUloh.Visible = false;
            this.listaContextSpravceUloh.Click += new System.EventHandler(this.listaContextSpravceUloh_Click);
            this.listaContextSpravceUloh.LostFocus += new System.EventHandler(this.listaContextSpravceUloh_LostFocus);
            // 
            // notepadContextOtevrit
            // 
            this.notepadContextOtevrit.Location = new System.Drawing.Point(92, 77);
            this.notepadContextOtevrit.Name = "notepadContextOtevrit";
            this.notepadContextOtevrit.Size = new System.Drawing.Size(75, 23);
            this.notepadContextOtevrit.TabIndex = 32;
            this.notepadContextOtevrit.Text = "Otevřít";
            this.notepadContextOtevrit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notepadContextOtevrit.UseVisualStyleBackColor = true;
            this.notepadContextOtevrit.Visible = false;
            this.notepadContextOtevrit.Click += new System.EventHandler(this.notepadContextOtevrit_Click);
            this.notepadContextOtevrit.LostFocus += new System.EventHandler(this.notepadContextOtevrit_LostFocus);
            // 
            // folderContextOtevrit
            // 
            this.folderContextOtevrit.Location = new System.Drawing.Point(92, 298);
            this.folderContextOtevrit.Name = "folderContextOtevrit";
            this.folderContextOtevrit.Size = new System.Drawing.Size(75, 23);
            this.folderContextOtevrit.TabIndex = 33;
            this.folderContextOtevrit.Text = "Otevřít";
            this.folderContextOtevrit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.folderContextOtevrit.UseVisualStyleBackColor = true;
            this.folderContextOtevrit.Visible = false;
            this.folderContextOtevrit.Click += new System.EventHandler(this.folderContextOtevrit_Click);
            this.folderContextOtevrit.LostFocus += new System.EventHandler(this.folderContextOtevrit_LostFocus);
            // 
            // jazykContext
            // 
            this.jazykContext.Enabled = false;
            this.jazykContext.Location = new System.Drawing.Point(615, 649);
            this.jazykContext.Name = "jazykContext";
            this.jazykContext.Size = new System.Drawing.Size(129, 23);
            this.jazykContext.TabIndex = 34;
            this.jazykContext.Text = "Czech (Czech Republic)";
            this.jazykContext.UseVisualStyleBackColor = true;
            this.jazykContext.Visible = false;
            // 
            // closeDesktopContext
            // 
            this.closeDesktopContext.Location = new System.Drawing.Point(615, 13);
            this.closeDesktopContext.Name = "closeDesktopContext";
            this.closeDesktopContext.Size = new System.Drawing.Size(15, 10);
            this.closeDesktopContext.TabIndex = 35;
            this.closeDesktopContext.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 714);
            this.Controls.Add(this.closeDesktopContext);
            this.Controls.Add(this.jazykContext);
            this.Controls.Add(this.folderContextOtevrit);
            this.Controls.Add(this.notepadContextOtevrit);
            this.Controls.Add(this.listaContextSpravceUloh);
            this.Controls.Add(this.tentoPCContextSpravovat);
            this.Controls.Add(this.tentoPCContextOtevrit);
            this.Controls.Add(this.kosContextVysypatKos);
            this.Controls.Add(this.kosContextOtevrit);
            this.Controls.Add(this.plochaContextPrizpusobit);
            this.Controls.Add(this.plochaContextNastaveniZobrazeni);
            this.Controls.Add(this.plochaContextNovaSlozka);
            this.Controls.Add(this.date);
            this.Controls.Add(this.language);
            this.Controls.Add(this.start);
            this.Controls.Add(this.sm_folder);
            this.Controls.Add(this.sm_kos);
            this.Controls.Add(this.sm_tentoPocitac);
            this.Controls.Add(this.sm_notepad);
            this.Controls.Add(this.folder);
            this.Controls.Add(this.kos);
            this.Controls.Add(this.tentoPocitac);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.closeNotepadButton);
            this.Controls.Add(this.notepad);
            this.Controls.Add(this.winIcon);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.keyboardOutputTextBox);
            this.Controls.Add(this.napovedaButton);
            this.Controls.Add(this.otevritButton);
            this.Controls.Add(this.simulator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "RegSim";
            ((System.ComponentModel.ISupportInitialize)(this.simulator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notepad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tentoPocitac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.folder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sm_notepad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sm_tentoPocitac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sm_kos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sm_folder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeDesktopContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox simulator;
        private System.Windows.Forms.Button otevritButton;
        private System.Windows.Forms.Button napovedaButton;
        private System.Windows.Forms.OpenFileDialog vyberKey;
        private System.Windows.Forms.TextBox keyboardOutputTextBox; 
        private System.Windows.Forms.PictureBox lista;
        private System.Windows.Forms.PictureBox winIcon;
        private System.Windows.Forms.PictureBox notepad;
        private System.Windows.Forms.Button closeNotepadButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.PictureBox tentoPocitac;
        private System.Windows.Forms.PictureBox kos;
        private System.Windows.Forms.PictureBox folder;
        private System.Windows.Forms.PictureBox sm_notepad;
        private System.Windows.Forms.PictureBox sm_tentoPocitac;
        private System.Windows.Forms.PictureBox sm_kos;
        private System.Windows.Forms.PictureBox sm_folder;
        private System.Windows.Forms.PictureBox start;
        private System.Windows.Forms.Button language;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.Button plochaContextNovaSlozka;
        private System.Windows.Forms.Button plochaContextNastaveniZobrazeni;
        private System.Windows.Forms.Button plochaContextPrizpusobit;
        private System.Windows.Forms.Button kosContextOtevrit;
        private System.Windows.Forms.Button kosContextVysypatKos;
        private System.Windows.Forms.Button tentoPCContextOtevrit;
        private System.Windows.Forms.Button tentoPCContextSpravovat;
        private System.Windows.Forms.Button listaContextSpravceUloh;
        private System.Windows.Forms.Button notepadContextOtevrit;
        private System.Windows.Forms.Button folderContextOtevrit;
        private System.Windows.Forms.Button jazykContext;
        private System.Windows.Forms.PictureBox closeDesktopContext;
    }
}

