namespace PetrolSimulation
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LblKasa = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.LblGaz = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblDieselPro = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblDieselMax = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblKursunsuz95 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.TxtPlaka = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.BtnDepoDoldur = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtGazFiyat = new System.Windows.Forms.TextBox();
            this.TxtDieselProFiyat = new System.Windows.Forms.TextBox();
            this.TxtDieselMaxFiyat = new System.Windows.Forms.TextBox();
            this.TxtKursunsuz95Fiyat = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblGazAlis = new System.Windows.Forms.Label();
            this.LblDieselProAlis = new System.Windows.Forms.Label();
            this.LblDieselMaxAlis = new System.Windows.Forms.Label();
            this.LblKursunsuz95Alis = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtGazDoldur = new System.Windows.Forms.TextBox();
            this.TxtDieselProDoldur = new System.Windows.Forms.TextBox();
            this.TxtDieselMaxDoldur = new System.Windows.Forms.TextBox();
            this.TxtKursunsuz95Doldur = new System.Windows.Forms.TextBox();
            this.BtnGazDoldur = new System.Windows.Forms.Button();
            this.BtnDieselProDoldur = new System.Windows.Forms.Button();
            this.BtnDieselMaxDoldur = new System.Windows.Forms.Button();
            this.BtnKursunsuz95Doldur = new System.Windows.Forms.Button();
            this.LblGazKalan = new System.Windows.Forms.Label();
            this.LblDieselProKalan = new System.Windows.Forms.Label();
            this.LblDieselMaxKalan = new System.Windows.Forms.Label();
            this.LblKursunsuz95Kalan = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yakıt Türü:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(205, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Litre Fiyatı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.LblKasa);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.LblGaz);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.LblDieselPro);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LblDieselMax);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LblKursunsuz95);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 342);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(347, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "--------------------------------------------------------------------";
            // 
            // LblKasa
            // 
            this.LblKasa.AutoSize = true;
            this.LblKasa.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKasa.Location = new System.Drawing.Point(237, 277);
            this.LblKasa.Name = "LblKasa";
            this.LblKasa.Size = new System.Drawing.Size(60, 27);
            this.LblKasa.TabIndex = 18;
            this.LblKasa.Text = "0,00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(102, 277);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 27);
            this.label15.TabIndex = 12;
            this.label15.Text = "Kasa:";
            // 
            // LblGaz
            // 
            this.LblGaz.AutoSize = true;
            this.LblGaz.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGaz.Location = new System.Drawing.Point(253, 196);
            this.LblGaz.Name = "LblGaz";
            this.LblGaz.Size = new System.Drawing.Size(26, 27);
            this.LblGaz.TabIndex = 9;
            this.LblGaz.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(106, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 27);
            this.label9.TabIndex = 8;
            this.label9.Text = "Gaz:";
            // 
            // LblDieselPro
            // 
            this.LblDieselPro.AutoSize = true;
            this.LblDieselPro.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDieselPro.Location = new System.Drawing.Point(253, 156);
            this.LblDieselPro.Name = "LblDieselPro";
            this.LblDieselPro.Size = new System.Drawing.Size(26, 27);
            this.LblDieselPro.TabIndex = 7;
            this.LblDieselPro.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(47, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "DieselPro:";
            // 
            // LblDieselMax
            // 
            this.LblDieselMax.AutoSize = true;
            this.LblDieselMax.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDieselMax.Location = new System.Drawing.Point(253, 111);
            this.LblDieselMax.Name = "LblDieselMax";
            this.LblDieselMax.Size = new System.Drawing.Size(26, 27);
            this.LblDieselMax.TabIndex = 5;
            this.LblDieselMax.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(37, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "DieselMax:";
            // 
            // LblKursunsuz95
            // 
            this.LblKursunsuz95.AutoSize = true;
            this.LblKursunsuz95.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKursunsuz95.Location = new System.Drawing.Point(253, 67);
            this.LblKursunsuz95.Name = "LblKursunsuz95";
            this.LblKursunsuz95.Size = new System.Drawing.Size(26, 27);
            this.LblKursunsuz95.TabIndex = 3;
            this.LblKursunsuz95.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kurşunsuz95:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown4);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.TxtPlaka);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.BtnDepoDoldur);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.TxtGazFiyat);
            this.groupBox2.Controls.Add(this.TxtDieselProFiyat);
            this.groupBox2.Controls.Add(this.TxtDieselMaxFiyat);
            this.groupBox2.Controls.Add(this.TxtKursunsuz95Fiyat);
            this.groupBox2.Location = new System.Drawing.Point(400, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 342);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(20, 197);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(145, 22);
            this.numericUpDown4.TabIndex = 16;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(20, 153);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(145, 22);
            this.numericUpDown3.TabIndex = 15;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(20, 105);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(145, 22);
            this.numericUpDown2.TabIndex = 14;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(20, 62);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(145, 22);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // TxtPlaka
            // 
            this.TxtPlaka.Location = new System.Drawing.Point(179, 243);
            this.TxtPlaka.Multiline = true;
            this.TxtPlaka.Name = "TxtPlaka";
            this.TxtPlaka.Size = new System.Drawing.Size(145, 28);
            this.TxtPlaka.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(89, 243);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 27);
            this.label14.TabIndex = 11;
            this.label14.Text = "Plaka:";
            // 
            // BtnDepoDoldur
            // 
            this.BtnDepoDoldur.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDepoDoldur.Location = new System.Drawing.Point(20, 286);
            this.BtnDepoDoldur.Name = "BtnDepoDoldur";
            this.BtnDepoDoldur.Size = new System.Drawing.Size(304, 45);
            this.BtnDepoDoldur.TabIndex = 10;
            this.BtnDepoDoldur.Text = "DepoDoldur";
            this.BtnDepoDoldur.UseVisualStyleBackColor = true;
            this.BtnDepoDoldur.Click += new System.EventHandler(this.BtnDepoDoldur_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(204, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 27);
            this.label11.TabIndex = 9;
            this.label11.Text = "Tutar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(53, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 27);
            this.label12.TabIndex = 8;
            this.label12.Text = "Litre";
            // 
            // TxtGazFiyat
            // 
            this.TxtGazFiyat.Enabled = false;
            this.TxtGazFiyat.Location = new System.Drawing.Point(179, 196);
            this.TxtGazFiyat.Multiline = true;
            this.TxtGazFiyat.Name = "TxtGazFiyat";
            this.TxtGazFiyat.Size = new System.Drawing.Size(145, 28);
            this.TxtGazFiyat.TabIndex = 7;
            // 
            // TxtDieselProFiyat
            // 
            this.TxtDieselProFiyat.Enabled = false;
            this.TxtDieselProFiyat.Location = new System.Drawing.Point(179, 150);
            this.TxtDieselProFiyat.Multiline = true;
            this.TxtDieselProFiyat.Name = "TxtDieselProFiyat";
            this.TxtDieselProFiyat.Size = new System.Drawing.Size(145, 28);
            this.TxtDieselProFiyat.TabIndex = 5;
            // 
            // TxtDieselMaxFiyat
            // 
            this.TxtDieselMaxFiyat.Enabled = false;
            this.TxtDieselMaxFiyat.Location = new System.Drawing.Point(179, 104);
            this.TxtDieselMaxFiyat.Multiline = true;
            this.TxtDieselMaxFiyat.Name = "TxtDieselMaxFiyat";
            this.TxtDieselMaxFiyat.Size = new System.Drawing.Size(145, 28);
            this.TxtDieselMaxFiyat.TabIndex = 3;
            // 
            // TxtKursunsuz95Fiyat
            // 
            this.TxtKursunsuz95Fiyat.Enabled = false;
            this.TxtKursunsuz95Fiyat.Location = new System.Drawing.Point(179, 59);
            this.TxtKursunsuz95Fiyat.Multiline = true;
            this.TxtKursunsuz95Fiyat.Name = "TxtKursunsuz95Fiyat";
            this.TxtKursunsuz95Fiyat.Size = new System.Drawing.Size(145, 28);
            this.TxtKursunsuz95Fiyat.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblGazAlis);
            this.groupBox3.Controls.Add(this.LblDieselProAlis);
            this.groupBox3.Controls.Add(this.LblDieselMaxAlis);
            this.groupBox3.Controls.Add(this.LblKursunsuz95Alis);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.TxtGazDoldur);
            this.groupBox3.Controls.Add(this.TxtDieselProDoldur);
            this.groupBox3.Controls.Add(this.TxtDieselMaxDoldur);
            this.groupBox3.Controls.Add(this.TxtKursunsuz95Doldur);
            this.groupBox3.Controls.Add(this.BtnGazDoldur);
            this.groupBox3.Controls.Add(this.BtnDieselProDoldur);
            this.groupBox3.Controls.Add(this.BtnDieselMaxDoldur);
            this.groupBox3.Controls.Add(this.BtnKursunsuz95Doldur);
            this.groupBox3.Controls.Add(this.LblGazKalan);
            this.groupBox3.Controls.Add(this.LblDieselProKalan);
            this.groupBox3.Controls.Add(this.LblDieselMaxKalan);
            this.groupBox3.Controls.Add(this.LblKursunsuz95Kalan);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.progressBar4);
            this.groupBox3.Controls.Add(this.progressBar3);
            this.groupBox3.Controls.Add(this.progressBar2);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Location = new System.Drawing.Point(21, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(724, 211);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // LblGazAlis
            // 
            this.LblGazAlis.AutoSize = true;
            this.LblGazAlis.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGazAlis.Location = new System.Drawing.Point(640, 148);
            this.LblGazAlis.Name = "LblGazAlis";
            this.LblGazAlis.Size = new System.Drawing.Size(0, 27);
            this.LblGazAlis.TabIndex = 30;
            this.LblGazAlis.Visible = false;
            // 
            // LblDieselProAlis
            // 
            this.LblDieselProAlis.AutoSize = true;
            this.LblDieselProAlis.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDieselProAlis.Location = new System.Drawing.Point(640, 120);
            this.LblDieselProAlis.Name = "LblDieselProAlis";
            this.LblDieselProAlis.Size = new System.Drawing.Size(0, 27);
            this.LblDieselProAlis.TabIndex = 29;
            this.LblDieselProAlis.Visible = false;
            // 
            // LblDieselMaxAlis
            // 
            this.LblDieselMaxAlis.AutoSize = true;
            this.LblDieselMaxAlis.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDieselMaxAlis.Location = new System.Drawing.Point(640, 91);
            this.LblDieselMaxAlis.Name = "LblDieselMaxAlis";
            this.LblDieselMaxAlis.Size = new System.Drawing.Size(0, 27);
            this.LblDieselMaxAlis.TabIndex = 28;
            this.LblDieselMaxAlis.Visible = false;
            // 
            // LblKursunsuz95Alis
            // 
            this.LblKursunsuz95Alis.AutoSize = true;
            this.LblKursunsuz95Alis.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKursunsuz95Alis.Location = new System.Drawing.Point(640, 59);
            this.LblKursunsuz95Alis.Name = "LblKursunsuz95Alis";
            this.LblKursunsuz95Alis.Size = new System.Drawing.Size(0, 27);
            this.LblKursunsuz95Alis.TabIndex = 27;
            this.LblKursunsuz95Alis.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(453, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 27);
            this.label3.TabIndex = 26;
            this.label3.Text = "Depo Doldur";
            // 
            // TxtGazDoldur
            // 
            this.TxtGazDoldur.Location = new System.Drawing.Point(486, 148);
            this.TxtGazDoldur.Name = "TxtGazDoldur";
            this.TxtGazDoldur.Size = new System.Drawing.Size(100, 22);
            this.TxtGazDoldur.TabIndex = 25;
            // 
            // TxtDieselProDoldur
            // 
            this.TxtDieselProDoldur.Location = new System.Drawing.Point(486, 120);
            this.TxtDieselProDoldur.Name = "TxtDieselProDoldur";
            this.TxtDieselProDoldur.Size = new System.Drawing.Size(100, 22);
            this.TxtDieselProDoldur.TabIndex = 24;
            // 
            // TxtDieselMaxDoldur
            // 
            this.TxtDieselMaxDoldur.Location = new System.Drawing.Point(486, 92);
            this.TxtDieselMaxDoldur.Name = "TxtDieselMaxDoldur";
            this.TxtDieselMaxDoldur.Size = new System.Drawing.Size(100, 22);
            this.TxtDieselMaxDoldur.TabIndex = 23;
            // 
            // TxtKursunsuz95Doldur
            // 
            this.TxtKursunsuz95Doldur.Location = new System.Drawing.Point(486, 64);
            this.TxtKursunsuz95Doldur.Name = "TxtKursunsuz95Doldur";
            this.TxtKursunsuz95Doldur.Size = new System.Drawing.Size(100, 22);
            this.TxtKursunsuz95Doldur.TabIndex = 22;
            // 
            // BtnGazDoldur
            // 
            this.BtnGazDoldur.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGazDoldur.Location = new System.Drawing.Point(453, 147);
            this.BtnGazDoldur.Name = "BtnGazDoldur";
            this.BtnGazDoldur.Size = new System.Drawing.Size(27, 23);
            this.BtnGazDoldur.TabIndex = 21;
            this.BtnGazDoldur.Text = "...";
            this.BtnGazDoldur.UseVisualStyleBackColor = true;
            this.BtnGazDoldur.Click += new System.EventHandler(this.BtnGazDoldur_Click);
            // 
            // BtnDieselProDoldur
            // 
            this.BtnDieselProDoldur.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDieselProDoldur.Location = new System.Drawing.Point(453, 119);
            this.BtnDieselProDoldur.Name = "BtnDieselProDoldur";
            this.BtnDieselProDoldur.Size = new System.Drawing.Size(27, 23);
            this.BtnDieselProDoldur.TabIndex = 20;
            this.BtnDieselProDoldur.Text = "...";
            this.BtnDieselProDoldur.UseVisualStyleBackColor = true;
            this.BtnDieselProDoldur.Click += new System.EventHandler(this.BtnDieselProDoldur_Click);
            // 
            // BtnDieselMaxDoldur
            // 
            this.BtnDieselMaxDoldur.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDieselMaxDoldur.Location = new System.Drawing.Point(453, 91);
            this.BtnDieselMaxDoldur.Name = "BtnDieselMaxDoldur";
            this.BtnDieselMaxDoldur.Size = new System.Drawing.Size(27, 23);
            this.BtnDieselMaxDoldur.TabIndex = 19;
            this.BtnDieselMaxDoldur.Text = "...";
            this.BtnDieselMaxDoldur.UseVisualStyleBackColor = true;
            this.BtnDieselMaxDoldur.Click += new System.EventHandler(this.BtnDieselMaxDoldur_Click);
            // 
            // BtnKursunsuz95Doldur
            // 
            this.BtnKursunsuz95Doldur.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKursunsuz95Doldur.Location = new System.Drawing.Point(453, 63);
            this.BtnKursunsuz95Doldur.Name = "BtnKursunsuz95Doldur";
            this.BtnKursunsuz95Doldur.Size = new System.Drawing.Size(27, 23);
            this.BtnKursunsuz95Doldur.TabIndex = 18;
            this.BtnKursunsuz95Doldur.Text = "...";
            this.BtnKursunsuz95Doldur.UseVisualStyleBackColor = true;
            this.BtnKursunsuz95Doldur.Click += new System.EventHandler(this.BtnKursunsuz95Doldur_Click);
            // 
            // LblGazKalan
            // 
            this.LblGazKalan.AutoSize = true;
            this.LblGazKalan.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGazKalan.Location = new System.Drawing.Point(312, 167);
            this.LblGazKalan.Name = "LblGazKalan";
            this.LblGazKalan.Size = new System.Drawing.Size(60, 27);
            this.LblGazKalan.TabIndex = 17;
            this.LblGazKalan.Text = "0,00";
            // 
            // LblDieselProKalan
            // 
            this.LblDieselProKalan.AutoSize = true;
            this.LblDieselProKalan.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDieselProKalan.Location = new System.Drawing.Point(312, 132);
            this.LblDieselProKalan.Name = "LblDieselProKalan";
            this.LblDieselProKalan.Size = new System.Drawing.Size(60, 27);
            this.LblDieselProKalan.TabIndex = 16;
            this.LblDieselProKalan.Text = "0,00";
            // 
            // LblDieselMaxKalan
            // 
            this.LblDieselMaxKalan.AutoSize = true;
            this.LblDieselMaxKalan.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDieselMaxKalan.Location = new System.Drawing.Point(312, 99);
            this.LblDieselMaxKalan.Name = "LblDieselMaxKalan";
            this.LblDieselMaxKalan.Size = new System.Drawing.Size(60, 27);
            this.LblDieselMaxKalan.TabIndex = 15;
            this.LblDieselMaxKalan.Text = "0,00";
            // 
            // LblKursunsuz95Kalan
            // 
            this.LblKursunsuz95Kalan.AutoSize = true;
            this.LblKursunsuz95Kalan.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKursunsuz95Kalan.Location = new System.Drawing.Point(312, 65);
            this.LblKursunsuz95Kalan.Name = "LblKursunsuz95Kalan";
            this.LblKursunsuz95Kalan.Size = new System.Drawing.Size(60, 27);
            this.LblKursunsuz95Kalan.TabIndex = 11;
            this.LblKursunsuz95Kalan.Text = "0,00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(6, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(301, 27);
            this.label13.TabIndex = 10;
            this.label13.Text = "Depo Petrol Doluluk Miktarı";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(6, 166);
            this.progressBar4.Maximum = 10000;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(300, 28);
            this.progressBar4.TabIndex = 3;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(6, 132);
            this.progressBar3.Maximum = 10000;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(300, 28);
            this.progressBar3.TabIndex = 2;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(6, 98);
            this.progressBar2.Maximum = 10000;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(300, 28);
            this.progressBar2.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 64);
            this.progressBar1.Maximum = 10000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 28);
            this.progressBar1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 583);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(414, 40);
            this.label5.TabIndex = 19;
            this.label5.Text = "Developed By Erdem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(748, 631);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Petrol Ofisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblGaz;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblDieselPro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblDieselMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblKursunsuz95;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtGazFiyat;
        private System.Windows.Forms.TextBox TxtDieselProFiyat;
        private System.Windows.Forms.TextBox TxtDieselMaxFiyat;
        private System.Windows.Forms.TextBox TxtKursunsuz95Fiyat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtnDepoDoldur;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LblGazKalan;
        private System.Windows.Forms.Label LblDieselProKalan;
        private System.Windows.Forms.Label LblDieselMaxKalan;
        private System.Windows.Forms.Label LblKursunsuz95Kalan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox TxtPlaka;
        private System.Windows.Forms.Label LblKasa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button BtnGazDoldur;
        private System.Windows.Forms.Button BtnDieselProDoldur;
        private System.Windows.Forms.Button BtnDieselMaxDoldur;
        private System.Windows.Forms.Button BtnKursunsuz95Doldur;
        private System.Windows.Forms.TextBox TxtGazDoldur;
        private System.Windows.Forms.TextBox TxtDieselProDoldur;
        private System.Windows.Forms.TextBox TxtDieselMaxDoldur;
        private System.Windows.Forms.TextBox TxtKursunsuz95Doldur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblGazAlis;
        private System.Windows.Forms.Label LblDieselProAlis;
        private System.Windows.Forms.Label LblDieselMaxAlis;
        private System.Windows.Forms.Label LblKursunsuz95Alis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}

