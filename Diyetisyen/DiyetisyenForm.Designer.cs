
namespace DiyetisyenApp
{
    partial class DiyetForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.HastaList = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CB_Uygulanacak_Diyet = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CB_Hastalik_Tipi = new System.Windows.Forms.ComboBox();
            this.txt_hasta_yas = new System.Windows.Forms.TextBox();
            this.btnHastaEkle = new System.Windows.Forms.Button();
            this.txt_hasta_kilo = new System.Windows.Forms.TextBox();
            this.txt_hasta_tc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_hasta_soyad = new System.Windows.Forms.TextBox();
            this.txt_hasta_ad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Diyetisyen_Adi = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.HastaList);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1569, 862);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(46)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(731, 521);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(767, 46);
            this.button1.TabIndex = 54;
            this.button1.Text = "Rapor Yazdır";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HastaList
            // 
            this.HastaList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
            this.HastaList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.HastaList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastaList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HastaList.FullRowSelect = true;
            this.HastaList.HideSelection = false;
            this.HastaList.Location = new System.Drawing.Point(731, 142);
            this.HastaList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HastaList.MultiSelect = false;
            this.HastaList.Name = "HastaList";
            this.HastaList.Size = new System.Drawing.Size(767, 355);
            this.HastaList.TabIndex = 46;
            this.HastaList.UseCompatibleStateImageBehavior = false;
            this.HastaList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tc:";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adi:";
            this.columnHeader1.Width = 97;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyadi:";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hastalık Tipi";
            this.columnHeader3.Width = 128;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ugulanan Diyet";
            this.columnHeader4.Width = 150;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(869, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 32);
            this.label9.TabIndex = 45;
            this.label9.Text = "Kayıtlı Hastalar";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.CB_Uygulanacak_Diyet);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.CB_Hastalik_Tipi);
            this.panel3.Controls.Add(this.txt_hasta_yas);
            this.panel3.Controls.Add(this.btnHastaEkle);
            this.panel3.Controls.Add(this.txt_hasta_kilo);
            this.panel3.Controls.Add(this.txt_hasta_tc);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txt_hasta_soyad);
            this.panel3.Controls.Add(this.txt_hasta_ad);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(35, 106);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(617, 720);
            this.panel3.TabIndex = 9;
            // 
            // CB_Uygulanacak_Diyet
            // 
            this.CB_Uygulanacak_Diyet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.CB_Uygulanacak_Diyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Uygulanacak_Diyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Uygulanacak_Diyet.ForeColor = System.Drawing.Color.White;
            this.CB_Uygulanacak_Diyet.FormattingEnabled = true;
            this.CB_Uygulanacak_Diyet.Items.AddRange(new object[] {
            "Deniz Ürünleri",
            "Yeşillikler Dünyası",
            "Gluten Free",
            "Akdeniz"});
            this.CB_Uygulanacak_Diyet.Location = new System.Drawing.Point(285, 502);
            this.CB_Uygulanacak_Diyet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_Uygulanacak_Diyet.Name = "CB_Uygulanacak_Diyet";
            this.CB_Uygulanacak_Diyet.Size = new System.Drawing.Size(268, 37);
            this.CB_Uygulanacak_Diyet.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(85, 70);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(432, 2);
            this.panel4.TabIndex = 10;
            // 
            // CB_Hastalik_Tipi
            // 
            this.CB_Hastalik_Tipi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.CB_Hastalik_Tipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Hastalik_Tipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Hastalik_Tipi.ForeColor = System.Drawing.Color.White;
            this.CB_Hastalik_Tipi.FormattingEnabled = true;
            this.CB_Hastalik_Tipi.Items.AddRange(new object[] {
            "Obez",
            "Çölyak",
            "Şeker"});
            this.CB_Hastalik_Tipi.Location = new System.Drawing.Point(285, 449);
            this.CB_Hastalik_Tipi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_Hastalik_Tipi.Name = "CB_Hastalik_Tipi";
            this.CB_Hastalik_Tipi.Size = new System.Drawing.Size(268, 37);
            this.CB_Hastalik_Tipi.TabIndex = 24;
            // 
            // txt_hasta_yas
            // 
            this.txt_hasta_yas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txt_hasta_yas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hasta_yas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hasta_yas.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_hasta_yas.Location = new System.Drawing.Point(203, 330);
            this.txt_hasta_yas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_hasta_yas.MaximumSize = new System.Drawing.Size(666, 500);
            this.txt_hasta_yas.MinimumSize = new System.Drawing.Size(2, 26);
            this.txt_hasta_yas.Name = "txt_hasta_yas";
            this.txt_hasta_yas.Size = new System.Drawing.Size(326, 34);
            this.txt_hasta_yas.TabIndex = 53;
            this.txt_hasta_yas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hasta_yas_KeyPress);
            // 
            // btnHastaEkle
            // 
            this.btnHastaEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(46)))));
            this.btnHastaEkle.FlatAppearance.BorderSize = 0;
            this.btnHastaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaEkle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHastaEkle.ForeColor = System.Drawing.Color.White;
            this.btnHastaEkle.Location = new System.Drawing.Point(35, 638);
            this.btnHastaEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHastaEkle.Name = "btnHastaEkle";
            this.btnHastaEkle.Size = new System.Drawing.Size(549, 62);
            this.btnHastaEkle.TabIndex = 5;
            this.btnHastaEkle.Text = "Onayla";
            this.btnHastaEkle.UseVisualStyleBackColor = false;
            this.btnHastaEkle.Click += new System.EventHandler(this.btnHastaEkle_Click);
            // 
            // txt_hasta_kilo
            // 
            this.txt_hasta_kilo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txt_hasta_kilo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hasta_kilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hasta_kilo.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_hasta_kilo.Location = new System.Drawing.Point(203, 281);
            this.txt_hasta_kilo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_hasta_kilo.MaximumSize = new System.Drawing.Size(666, 500);
            this.txt_hasta_kilo.MinimumSize = new System.Drawing.Size(2, 26);
            this.txt_hasta_kilo.Name = "txt_hasta_kilo";
            this.txt_hasta_kilo.Size = new System.Drawing.Size(326, 34);
            this.txt_hasta_kilo.TabIndex = 52;
            this.txt_hasta_kilo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hasta_kilo_KeyPress);
            // 
            // txt_hasta_tc
            // 
            this.txt_hasta_tc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txt_hasta_tc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hasta_tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hasta_tc.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_hasta_tc.Location = new System.Drawing.Point(203, 229);
            this.txt_hasta_tc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_hasta_tc.MaximumSize = new System.Drawing.Size(666, 500);
            this.txt_hasta_tc.MinimumSize = new System.Drawing.Size(2, 26);
            this.txt_hasta_tc.Name = "txt_hasta_tc";
            this.txt_hasta_tc.Size = new System.Drawing.Size(326, 34);
            this.txt_hasta_tc.TabIndex = 51;
            this.txt_hasta_tc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hasta_tc_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(29, 505);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 28);
            this.label8.TabIndex = 10;
            this.label8.Text = "Uygulanacak Diyet:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_hasta_soyad
            // 
            this.txt_hasta_soyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txt_hasta_soyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hasta_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hasta_soyad.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_hasta_soyad.Location = new System.Drawing.Point(203, 178);
            this.txt_hasta_soyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_hasta_soyad.MaximumSize = new System.Drawing.Size(666, 500);
            this.txt_hasta_soyad.MinimumSize = new System.Drawing.Size(2, 26);
            this.txt_hasta_soyad.Name = "txt_hasta_soyad";
            this.txt_hasta_soyad.Size = new System.Drawing.Size(326, 34);
            this.txt_hasta_soyad.TabIndex = 50;
            // 
            // txt_hasta_ad
            // 
            this.txt_hasta_ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txt_hasta_ad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hasta_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hasta_ad.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_hasta_ad.Location = new System.Drawing.Point(203, 130);
            this.txt_hasta_ad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_hasta_ad.MaximumSize = new System.Drawing.Size(666, 500);
            this.txt_hasta_ad.MinimumSize = new System.Drawing.Size(2, 26);
            this.txt_hasta_ad.Name = "txt_hasta_ad";
            this.txt_hasta_ad.Size = new System.Drawing.Size(326, 34);
            this.txt_hasta_ad.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(29, 452);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 28);
            this.label14.TabIndex = 10;
            this.label14.Text = "Hastalık Tipi:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(89, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "Yaşı      :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(89, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kilosu  :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(165, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hastanın Bilgileri";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(89, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "TC         :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(89, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adi        :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(89, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soyadi :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lbl_Diyetisyen_Adi);
            this.panel2.Controls.Add(this.lblClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1569, 66);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DiyetisyenApp.Properties.Resources.exit_52px;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_Diyetisyen_Adi
            // 
            this.lbl_Diyetisyen_Adi.AutoSize = true;
            this.lbl_Diyetisyen_Adi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Diyetisyen_Adi.Location = new System.Drawing.Point(780, 15);
            this.lbl_Diyetisyen_Adi.Name = "lbl_Diyetisyen_Adi";
            this.lbl_Diyetisyen_Adi.Size = new System.Drawing.Size(230, 34);
            this.lbl_Diyetisyen_Adi.TabIndex = 2;
            this.lbl_Diyetisyen_Adi.Text = "Diyetisyen_Adi";
            this.lbl_Diyetisyen_Adi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(1501, 12);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(40, 38);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(582, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Merhabalar,";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // DiyetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 862);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DiyetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiyetForm";
            this.Load += new System.EventHandler(this.DiyetForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHastaEkle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Diyetisyen_Adi;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_hasta_yas;
        private System.Windows.Forms.TextBox txt_hasta_kilo;
        private System.Windows.Forms.TextBox txt_hasta_tc;
        private System.Windows.Forms.TextBox txt_hasta_soyad;
        private System.Windows.Forms.TextBox txt_hasta_ad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CB_Hastalik_Tipi;
        private System.Windows.Forms.ComboBox CB_Uygulanacak_Diyet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListView HastaList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}