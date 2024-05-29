namespace Nesneye_Dayali_Programlama_Odev2
{
    partial class Form1menu
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
            this.label1Cizim = new System.Windows.Forms.Label();
            this.label2Carpisma = new System.Windows.Forms.Label();
            this.comboBox1Cizim = new System.Windows.Forms.ComboBox();
            this.comboBox2Carpisma = new System.Windows.Forms.ComboBox();
            this.button1Ciz = new System.Windows.Forms.Button();
            this.button2Carpistir = new System.Windows.Forms.Button();
            this.richTextBox1cisim1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox2cisim2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3sonuc = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1Cizim
            // 
            this.label1Cizim.AutoSize = true;
            this.label1Cizim.Font = new System.Drawing.Font("Rockwell Nova Cond", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1Cizim.Location = new System.Drawing.Point(130, 27);
            this.label1Cizim.Name = "label1Cizim";
            this.label1Cizim.Size = new System.Drawing.Size(97, 44);
            this.label1Cizim.TabIndex = 0;
            this.label1Cizim.Text = "Çizim";
            this.label1Cizim.Click += new System.EventHandler(this.label1Cizim_Click);
            // 
            // label2Carpisma
            // 
            this.label2Carpisma.AutoSize = true;
            this.label2Carpisma.Font = new System.Drawing.Font("Rockwell Nova Cond", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2Carpisma.Location = new System.Drawing.Point(871, 27);
            this.label2Carpisma.Name = "label2Carpisma";
            this.label2Carpisma.Size = new System.Drawing.Size(153, 44);
            this.label2Carpisma.TabIndex = 1;
            this.label2Carpisma.Text = "Çarpışma ";
            // 
            // comboBox1Cizim
            // 
            this.comboBox1Cizim.FormattingEnabled = true;
            this.comboBox1Cizim.Location = new System.Drawing.Point(12, 92);
            this.comboBox1Cizim.Name = "comboBox1Cizim";
            this.comboBox1Cizim.Size = new System.Drawing.Size(339, 24);
            this.comboBox1Cizim.TabIndex = 2;
            this.comboBox1Cizim.SelectedIndexChanged += new System.EventHandler(this.comboBox1Cizim_SelectedIndexChanged);
            // 
            // comboBox2Carpisma
            // 
            this.comboBox2Carpisma.FormattingEnabled = true;
            this.comboBox2Carpisma.Location = new System.Drawing.Point(780, 92);
            this.comboBox2Carpisma.Name = "comboBox2Carpisma";
            this.comboBox2Carpisma.Size = new System.Drawing.Size(339, 24);
            this.comboBox2Carpisma.TabIndex = 3;
            this.comboBox2Carpisma.SelectedIndexChanged += new System.EventHandler(this.comboBox2Carpisma_SelectedIndexChanged);
            // 
            // button1Ciz
            // 
            this.button1Ciz.Location = new System.Drawing.Point(106, 213);
            this.button1Ciz.Name = "button1Ciz";
            this.button1Ciz.Size = new System.Drawing.Size(121, 74);
            this.button1Ciz.TabIndex = 4;
            this.button1Ciz.Text = "ÇİZ";
            this.button1Ciz.UseVisualStyleBackColor = true;
            this.button1Ciz.Click += new System.EventHandler(this.button1Ciz_Click);
            // 
            // button2Carpistir
            // 
            this.button2Carpistir.Location = new System.Drawing.Point(903, 213);
            this.button2Carpistir.Name = "button2Carpistir";
            this.button2Carpistir.Size = new System.Drawing.Size(121, 74);
            this.button2Carpistir.TabIndex = 5;
            this.button2Carpistir.Text = "ÇARPIŞTIR";
            this.button2Carpistir.UseVisualStyleBackColor = true;
            this.button2Carpistir.Click += new System.EventHandler(this.button2Carpistir_Click);
            // 
            // richTextBox1cisim1
            // 
            this.richTextBox1cisim1.Location = new System.Drawing.Point(12, 397);
            this.richTextBox1cisim1.Name = "richTextBox1cisim1";
            this.richTextBox1cisim1.Size = new System.Drawing.Size(339, 41);
            this.richTextBox1cisim1.TabIndex = 0;
            this.richTextBox1cisim1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gold;
            this.pictureBox1.Location = new System.Drawing.Point(368, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 304);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox2cisim2
            // 
            this.richTextBox2cisim2.Location = new System.Drawing.Point(780, 397);
            this.richTextBox2cisim2.Name = "richTextBox2cisim2";
            this.richTextBox2cisim2.Size = new System.Drawing.Size(339, 41);
            this.richTextBox2cisim2.TabIndex = 7;
            this.richTextBox2cisim2.Text = "";
            this.richTextBox2cisim2.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox3sonuc
            // 
            this.richTextBox3sonuc.Location = new System.Drawing.Point(447, 402);
            this.richTextBox3sonuc.Name = "richTextBox3sonuc";
            this.richTextBox3sonuc.Size = new System.Drawing.Size(223, 36);
            this.richTextBox3sonuc.TabIndex = 8;
            this.richTextBox3sonuc.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(363, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Çarpışma Denetimi ve Çizim İstasyonu";
            // 
            // Form1menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1131, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox3sonuc);
            this.Controls.Add(this.richTextBox2cisim2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1cisim1);
            this.Controls.Add(this.button2Carpistir);
            this.Controls.Add(this.button1Ciz);
            this.Controls.Add(this.comboBox2Carpisma);
            this.Controls.Add(this.comboBox1Cizim);
            this.Controls.Add(this.label2Carpisma);
            this.Controls.Add(this.label1Cizim);
            this.Name = "Form1menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çarpışma Denetleyicisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1Cizim;
        private System.Windows.Forms.Label label2Carpisma;
        private System.Windows.Forms.ComboBox comboBox1Cizim;
        private System.Windows.Forms.ComboBox comboBox2Carpisma;
        private System.Windows.Forms.Button button1Ciz;
        private System.Windows.Forms.Button button2Carpistir;
        private System.Windows.Forms.RichTextBox richTextBox1cisim1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox2cisim2;
        private System.Windows.Forms.RichTextBox richTextBox3sonuc;
        private System.Windows.Forms.Label label1;
    }
}

