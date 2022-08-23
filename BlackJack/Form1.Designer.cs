namespace BlackJack
{
    partial class Form1
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
            this.kortitPelaaja = new System.Windows.Forms.TextBox();
            this.kortitJakaja = new System.Windows.Forms.TextBox();
            this.aloita = new System.Windows.Forms.Button();
            this.label1jakaja = new System.Windows.Forms.Label();
            this.label2jakaja = new System.Windows.Forms.Label();
            this.label3jakaja = new System.Windows.Forms.Label();
            this.label4jakaja = new System.Windows.Forms.Label();
            this.label5jakaja = new System.Windows.Forms.Label();
            this.label5pelaaja = new System.Windows.Forms.Label();
            this.label4pelaaja = new System.Windows.Forms.Label();
            this.label3pelaaja = new System.Windows.Forms.Label();
            this.label2pelaaja = new System.Windows.Forms.Label();
            this.label1pelaaja = new System.Windows.Forms.Label();
            this.pisteetpelaaja = new System.Windows.Forms.Label();
            this.pisteetjakaja = new System.Windows.Forms.Label();
            this.nosta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stay = new System.Windows.Forms.Button();
            this.label1peite = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wincount = new System.Windows.Forms.Label();
            this.losscount = new System.Windows.Forms.Label();
            this.todennäköisyys = new System.Windows.Forms.Label();
            this.stayOdds = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.autoON = new System.Windows.Forms.Button();
            this.autoOFF = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.kortti1peite = new System.Windows.Forms.PictureBox();
            this.pictureBox5pelaaja = new System.Windows.Forms.PictureBox();
            this.pictureBox4pelaaja = new System.Windows.Forms.PictureBox();
            this.pictureBox3pelaaja = new System.Windows.Forms.PictureBox();
            this.pictureBox2pelaaja = new System.Windows.Forms.PictureBox();
            this.pictureBox1pelaaja = new System.Windows.Forms.PictureBox();
            this.pictureBox5jakaja = new System.Windows.Forms.PictureBox();
            this.pictureBox4jakaja = new System.Windows.Forms.PictureBox();
            this.pictureBox3jakaja = new System.Windows.Forms.PictureBox();
            this.pictureBox2jakaja = new System.Windows.Forms.PictureBox();
            this.pictureBox1jakaja = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kortti1peite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5pelaaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4pelaaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3pelaaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2pelaaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1pelaaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5jakaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4jakaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3jakaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2jakaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1jakaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kortitPelaaja
            // 
            this.kortitPelaaja.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.kortitPelaaja.Enabled = false;
            this.kortitPelaaja.Location = new System.Drawing.Point(7, 9);
            this.kortitPelaaja.Multiline = true;
            this.kortitPelaaja.Name = "kortitPelaaja";
            this.kortitPelaaja.ReadOnly = true;
            this.kortitPelaaja.Size = new System.Drawing.Size(530, 142);
            this.kortitPelaaja.TabIndex = 1;
            this.kortitPelaaja.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // kortitJakaja
            // 
            this.kortitJakaja.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.kortitJakaja.Enabled = false;
            this.kortitJakaja.Location = new System.Drawing.Point(7, 216);
            this.kortitJakaja.Multiline = true;
            this.kortitJakaja.Name = "kortitJakaja";
            this.kortitJakaja.ReadOnly = true;
            this.kortitJakaja.Size = new System.Drawing.Size(530, 142);
            this.kortitJakaja.TabIndex = 2;
            this.kortitJakaja.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // aloita
            // 
            this.aloita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aloita.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aloita.Location = new System.Drawing.Point(617, 89);
            this.aloita.Name = "aloita";
            this.aloita.Size = new System.Drawing.Size(116, 54);
            this.aloita.TabIndex = 5;
            this.aloita.Text = "Pelaa";
            this.aloita.UseVisualStyleBackColor = true;
            this.aloita.Click += new System.EventHandler(this.aloita_Click);
            // 
            // label1jakaja
            // 
            this.label1jakaja.AutoSize = true;
            this.label1jakaja.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label1jakaja.Location = new System.Drawing.Point(23, 130);
            this.label1jakaja.Name = "label1jakaja";
            this.label1jakaja.Size = new System.Drawing.Size(0, 13);
            this.label1jakaja.TabIndex = 8;
            // 
            // label2jakaja
            // 
            this.label2jakaja.AutoSize = true;
            this.label2jakaja.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label2jakaja.Location = new System.Drawing.Point(122, 130);
            this.label2jakaja.Name = "label2jakaja";
            this.label2jakaja.Size = new System.Drawing.Size(0, 13);
            this.label2jakaja.TabIndex = 9;
            // 
            // label3jakaja
            // 
            this.label3jakaja.AutoSize = true;
            this.label3jakaja.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label3jakaja.Location = new System.Drawing.Point(222, 130);
            this.label3jakaja.Name = "label3jakaja";
            this.label3jakaja.Size = new System.Drawing.Size(0, 13);
            this.label3jakaja.TabIndex = 10;
            // 
            // label4jakaja
            // 
            this.label4jakaja.AutoSize = true;
            this.label4jakaja.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label4jakaja.Location = new System.Drawing.Point(329, 130);
            this.label4jakaja.Name = "label4jakaja";
            this.label4jakaja.Size = new System.Drawing.Size(0, 13);
            this.label4jakaja.TabIndex = 11;
            // 
            // label5jakaja
            // 
            this.label5jakaja.AutoSize = true;
            this.label5jakaja.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label5jakaja.Location = new System.Drawing.Point(451, 130);
            this.label5jakaja.Name = "label5jakaja";
            this.label5jakaja.Size = new System.Drawing.Size(0, 13);
            this.label5jakaja.TabIndex = 12;
            // 
            // label5pelaaja
            // 
            this.label5pelaaja.AutoSize = true;
            this.label5pelaaja.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label5pelaaja.Location = new System.Drawing.Point(451, 336);
            this.label5pelaaja.Name = "label5pelaaja";
            this.label5pelaaja.Size = new System.Drawing.Size(0, 13);
            this.label5pelaaja.TabIndex = 17;
            // 
            // label4pelaaja
            // 
            this.label4pelaaja.AutoSize = true;
            this.label4pelaaja.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label4pelaaja.Location = new System.Drawing.Point(329, 336);
            this.label4pelaaja.Name = "label4pelaaja";
            this.label4pelaaja.Size = new System.Drawing.Size(0, 13);
            this.label4pelaaja.TabIndex = 16;
            // 
            // label3pelaaja
            // 
            this.label3pelaaja.AutoSize = true;
            this.label3pelaaja.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label3pelaaja.Location = new System.Drawing.Point(222, 336);
            this.label3pelaaja.Name = "label3pelaaja";
            this.label3pelaaja.Size = new System.Drawing.Size(0, 13);
            this.label3pelaaja.TabIndex = 15;
            // 
            // label2pelaaja
            // 
            this.label2pelaaja.AutoSize = true;
            this.label2pelaaja.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label2pelaaja.Location = new System.Drawing.Point(122, 336);
            this.label2pelaaja.Name = "label2pelaaja";
            this.label2pelaaja.Size = new System.Drawing.Size(0, 13);
            this.label2pelaaja.TabIndex = 14;
            // 
            // label1pelaaja
            // 
            this.label1pelaaja.AutoSize = true;
            this.label1pelaaja.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label1pelaaja.Location = new System.Drawing.Point(23, 336);
            this.label1pelaaja.Name = "label1pelaaja";
            this.label1pelaaja.Size = new System.Drawing.Size(0, 13);
            this.label1pelaaja.TabIndex = 13;
            // 
            // pisteetpelaaja
            // 
            this.pisteetpelaaja.AutoSize = true;
            this.pisteetpelaaja.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pisteetpelaaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pisteetpelaaja.Location = new System.Drawing.Point(12, 219);
            this.pisteetpelaaja.Name = "pisteetpelaaja";
            this.pisteetpelaaja.Size = new System.Drawing.Size(0, 25);
            this.pisteetpelaaja.TabIndex = 18;
            // 
            // pisteetjakaja
            // 
            this.pisteetjakaja.AutoSize = true;
            this.pisteetjakaja.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pisteetjakaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pisteetjakaja.Location = new System.Drawing.Point(12, 12);
            this.pisteetjakaja.Name = "pisteetjakaja";
            this.pisteetjakaja.Size = new System.Drawing.Size(0, 25);
            this.pisteetjakaja.TabIndex = 19;
            // 
            // nosta
            // 
            this.nosta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nosta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nosta.Location = new System.Drawing.Point(617, 89);
            this.nosta.Name = "nosta";
            this.nosta.Size = new System.Drawing.Size(116, 54);
            this.nosta.TabIndex = 20;
            this.nosta.Text = "Nosta";
            this.nosta.UseVisualStyleBackColor = false;
            this.nosta.Visible = false;
            this.nosta.Click += new System.EventHandler(this.nosta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(199, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 31);
            this.label1.TabIndex = 21;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // stay
            // 
            this.stay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.stay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stay.Location = new System.Drawing.Point(617, 155);
            this.stay.Name = "stay";
            this.stay.Size = new System.Drawing.Size(116, 54);
            this.stay.TabIndex = 22;
            this.stay.Text = "Jää";
            this.stay.UseVisualStyleBackColor = false;
            this.stay.Visible = false;
            this.stay.Click += new System.EventHandler(this.stay_Click);
            // 
            // label1peite
            // 
            this.label1peite.AutoSize = true;
            this.label1peite.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label1peite.Location = new System.Drawing.Point(33, 130);
            this.label1peite.Name = "label1peite";
            this.label1peite.Size = new System.Drawing.Size(25, 13);
            this.label1peite.TabIndex = 34;
            this.label1peite.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(221, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Jakajan kortit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(221, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Sinun korttisi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(602, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 35);
            this.label4.TabIndex = 37;
            this.label4.Text = "Blackjack";
            // 
            // wincount
            // 
            this.wincount.AutoSize = true;
            this.wincount.BackColor = System.Drawing.Color.Transparent;
            this.wincount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wincount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wincount.Location = new System.Drawing.Point(634, 308);
            this.wincount.Name = "wincount";
            this.wincount.Size = new System.Drawing.Size(73, 25);
            this.wincount.TabIndex = 38;
            this.wincount.Text = "Voitot:";
            this.wincount.Click += new System.EventHandler(this.wincount_Click);
            // 
            // losscount
            // 
            this.losscount.AutoSize = true;
            this.losscount.BackColor = System.Drawing.Color.Transparent;
            this.losscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.losscount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.losscount.Location = new System.Drawing.Point(634, 336);
            this.losscount.Name = "losscount";
            this.losscount.Size = new System.Drawing.Size(79, 25);
            this.losscount.TabIndex = 39;
            this.losscount.Text = "Häviöt:";
            this.losscount.Click += new System.EventHandler(this.losscount_Click);
            // 
            // todennäköisyys
            // 
            this.todennäköisyys.AutoSize = true;
            this.todennäköisyys.BackColor = System.Drawing.Color.Transparent;
            this.todennäköisyys.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todennäköisyys.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.todennäköisyys.Location = new System.Drawing.Point(537, 107);
            this.todennäköisyys.Name = "todennäköisyys";
            this.todennäköisyys.Size = new System.Drawing.Size(0, 24);
            this.todennäköisyys.TabIndex = 40;
            // 
            // stayOdds
            // 
            this.stayOdds.AutoSize = true;
            this.stayOdds.BackColor = System.Drawing.Color.Transparent;
            this.stayOdds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stayOdds.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stayOdds.Location = new System.Drawing.Point(537, 172);
            this.stayOdds.Name = "stayOdds";
            this.stayOdds.Size = new System.Drawing.Size(0, 24);
            this.stayOdds.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(543, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "Häviö%";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // autoON
            // 
            this.autoON.BackColor = System.Drawing.SystemColors.ControlLight;
            this.autoON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autoON.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoON.Location = new System.Drawing.Point(332, 385);
            this.autoON.Name = "autoON";
            this.autoON.Size = new System.Drawing.Size(133, 47);
            this.autoON.TabIndex = 44;
            this.autoON.Text = "Start Auto";
            this.autoON.UseVisualStyleBackColor = false;
            this.autoON.Click += new System.EventHandler(this.autoON_Click);
            // 
            // autoOFF
            // 
            this.autoOFF.BackColor = System.Drawing.SystemColors.ControlLight;
            this.autoOFF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autoOFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoOFF.Location = new System.Drawing.Point(608, 385);
            this.autoOFF.Name = "autoOFF";
            this.autoOFF.Size = new System.Drawing.Size(140, 47);
            this.autoOFF.TabIndex = 45;
            this.autoOFF.Text = "Stop Auto";
            this.autoOFF.UseVisualStyleBackColor = false;
            this.autoOFF.Click += new System.EventHandler(this.autoOFF_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(479, 393);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 46;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // kortti1peite
            // 
            this.kortti1peite.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.kortti1peite.Image = global::BlackJack.Resource1.back;
            this.kortti1peite.Location = new System.Drawing.Point(26, 50);
            this.kortti1peite.Name = "kortti1peite";
            this.kortti1peite.Size = new System.Drawing.Size(63, 77);
            this.kortti1peite.TabIndex = 33;
            this.kortti1peite.TabStop = false;
            // 
            // pictureBox5pelaaja
            // 
            this.pictureBox5pelaaja.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pictureBox5pelaaja.Location = new System.Drawing.Point(454, 256);
            this.pictureBox5pelaaja.Name = "pictureBox5pelaaja";
            this.pictureBox5pelaaja.Size = new System.Drawing.Size(63, 77);
            this.pictureBox5pelaaja.TabIndex = 32;
            this.pictureBox5pelaaja.TabStop = false;
            // 
            // pictureBox4pelaaja
            // 
            this.pictureBox4pelaaja.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pictureBox4pelaaja.Location = new System.Drawing.Point(332, 256);
            this.pictureBox4pelaaja.Name = "pictureBox4pelaaja";
            this.pictureBox4pelaaja.Size = new System.Drawing.Size(63, 77);
            this.pictureBox4pelaaja.TabIndex = 31;
            this.pictureBox4pelaaja.TabStop = false;
            // 
            // pictureBox3pelaaja
            // 
            this.pictureBox3pelaaja.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pictureBox3pelaaja.Location = new System.Drawing.Point(225, 256);
            this.pictureBox3pelaaja.Name = "pictureBox3pelaaja";
            this.pictureBox3pelaaja.Size = new System.Drawing.Size(63, 77);
            this.pictureBox3pelaaja.TabIndex = 30;
            this.pictureBox3pelaaja.TabStop = false;
            // 
            // pictureBox2pelaaja
            // 
            this.pictureBox2pelaaja.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pictureBox2pelaaja.Location = new System.Drawing.Point(125, 256);
            this.pictureBox2pelaaja.Name = "pictureBox2pelaaja";
            this.pictureBox2pelaaja.Size = new System.Drawing.Size(63, 77);
            this.pictureBox2pelaaja.TabIndex = 29;
            this.pictureBox2pelaaja.TabStop = false;
            // 
            // pictureBox1pelaaja
            // 
            this.pictureBox1pelaaja.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pictureBox1pelaaja.Location = new System.Drawing.Point(26, 256);
            this.pictureBox1pelaaja.Name = "pictureBox1pelaaja";
            this.pictureBox1pelaaja.Size = new System.Drawing.Size(63, 77);
            this.pictureBox1pelaaja.TabIndex = 28;
            this.pictureBox1pelaaja.TabStop = false;
            // 
            // pictureBox5jakaja
            // 
            this.pictureBox5jakaja.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pictureBox5jakaja.Location = new System.Drawing.Point(454, 50);
            this.pictureBox5jakaja.Name = "pictureBox5jakaja";
            this.pictureBox5jakaja.Size = new System.Drawing.Size(63, 77);
            this.pictureBox5jakaja.TabIndex = 27;
            this.pictureBox5jakaja.TabStop = false;
            // 
            // pictureBox4jakaja
            // 
            this.pictureBox4jakaja.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pictureBox4jakaja.Location = new System.Drawing.Point(332, 50);
            this.pictureBox4jakaja.Name = "pictureBox4jakaja";
            this.pictureBox4jakaja.Size = new System.Drawing.Size(63, 77);
            this.pictureBox4jakaja.TabIndex = 26;
            this.pictureBox4jakaja.TabStop = false;
            // 
            // pictureBox3jakaja
            // 
            this.pictureBox3jakaja.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pictureBox3jakaja.Location = new System.Drawing.Point(225, 50);
            this.pictureBox3jakaja.Name = "pictureBox3jakaja";
            this.pictureBox3jakaja.Size = new System.Drawing.Size(63, 77);
            this.pictureBox3jakaja.TabIndex = 25;
            this.pictureBox3jakaja.TabStop = false;
            // 
            // pictureBox2jakaja
            // 
            this.pictureBox2jakaja.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pictureBox2jakaja.Location = new System.Drawing.Point(125, 50);
            this.pictureBox2jakaja.Name = "pictureBox2jakaja";
            this.pictureBox2jakaja.Size = new System.Drawing.Size(63, 77);
            this.pictureBox2jakaja.TabIndex = 24;
            this.pictureBox2jakaja.TabStop = false;
            // 
            // pictureBox1jakaja
            // 
            this.pictureBox1jakaja.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pictureBox1jakaja.Location = new System.Drawing.Point(26, 50);
            this.pictureBox1jakaja.Name = "pictureBox1jakaja";
            this.pictureBox1jakaja.Size = new System.Drawing.Size(63, 77);
            this.pictureBox1jakaja.TabIndex = 23;
            this.pictureBox1jakaja.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlackJack.Resource1.bg;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(759, 444);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(754, 441);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.autoOFF);
            this.Controls.Add(this.autoON);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stayOdds);
            this.Controls.Add(this.todennäköisyys);
            this.Controls.Add(this.losscount);
            this.Controls.Add(this.wincount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1peite);
            this.Controls.Add(this.kortti1peite);
            this.Controls.Add(this.pictureBox5pelaaja);
            this.Controls.Add(this.pictureBox4pelaaja);
            this.Controls.Add(this.pictureBox3pelaaja);
            this.Controls.Add(this.pictureBox2pelaaja);
            this.Controls.Add(this.pictureBox1pelaaja);
            this.Controls.Add(this.pictureBox5jakaja);
            this.Controls.Add(this.pictureBox4jakaja);
            this.Controls.Add(this.pictureBox3jakaja);
            this.Controls.Add(this.pictureBox2jakaja);
            this.Controls.Add(this.pictureBox1jakaja);
            this.Controls.Add(this.stay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nosta);
            this.Controls.Add(this.pisteetjakaja);
            this.Controls.Add(this.pisteetpelaaja);
            this.Controls.Add(this.label5pelaaja);
            this.Controls.Add(this.label4pelaaja);
            this.Controls.Add(this.label3pelaaja);
            this.Controls.Add(this.label2pelaaja);
            this.Controls.Add(this.label1pelaaja);
            this.Controls.Add(this.label5jakaja);
            this.Controls.Add(this.label4jakaja);
            this.Controls.Add(this.label3jakaja);
            this.Controls.Add(this.label2jakaja);
            this.Controls.Add(this.label1jakaja);
            this.Controls.Add(this.aloita);
            this.Controls.Add(this.kortitJakaja);
            this.Controls.Add(this.kortitPelaaja);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kortti1peite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5pelaaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4pelaaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3pelaaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2pelaaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1pelaaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5jakaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4jakaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3jakaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2jakaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1jakaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox kortitJakaja;
        private System.Windows.Forms.TextBox kortitPelaaja;
        private System.Windows.Forms.Button aloita;
        private System.Windows.Forms.Label label1jakaja;
        private System.Windows.Forms.Label label2jakaja;
        private System.Windows.Forms.Label label3jakaja;
        private System.Windows.Forms.Label label4jakaja;
        private System.Windows.Forms.Label label5jakaja;
        private System.Windows.Forms.Label label5pelaaja;
        private System.Windows.Forms.Label label4pelaaja;
        private System.Windows.Forms.Label label3pelaaja;
        private System.Windows.Forms.Label label2pelaaja;
        private System.Windows.Forms.Label label1pelaaja;
        private System.Windows.Forms.Label pisteetpelaaja;
        private System.Windows.Forms.Label pisteetjakaja;
        private System.Windows.Forms.Button nosta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stay;
        private System.Windows.Forms.PictureBox pictureBox1jakaja;
        private System.Windows.Forms.PictureBox pictureBox2jakaja;
        private System.Windows.Forms.PictureBox pictureBox3jakaja;
        private System.Windows.Forms.PictureBox pictureBox4jakaja;
        private System.Windows.Forms.PictureBox pictureBox5jakaja;
        private System.Windows.Forms.PictureBox pictureBox5pelaaja;
        private System.Windows.Forms.PictureBox pictureBox4pelaaja;
        private System.Windows.Forms.PictureBox pictureBox3pelaaja;
        private System.Windows.Forms.PictureBox pictureBox2pelaaja;
        private System.Windows.Forms.PictureBox pictureBox1pelaaja;
        private System.Windows.Forms.PictureBox kortti1peite;
        private System.Windows.Forms.Label label1peite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label wincount;
        private System.Windows.Forms.Label losscount;
        private System.Windows.Forms.Label todennäköisyys;
        private System.Windows.Forms.Label stayOdds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button autoON;
        private System.Windows.Forms.Button autoOFF;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

