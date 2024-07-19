namespace OkulNotSistemi
{
    partial class FrmOgrenciler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbkulup = new System.Windows.Forms.ComboBox();
            this.RadioErkek = new System.Windows.Forms.RadioButton();
            this.radioKiz = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtara = new System.Windows.Forms.TextBox();
            this.btnara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(894, 234);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(921, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 42);
            this.label3.TabIndex = 17;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnguncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguncelle.Location = new System.Drawing.Point(185, 320);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(167, 68);
            this.btnguncelle.TabIndex = 20;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsil.Location = new System.Drawing.Point(358, 320);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(161, 68);
            this.btnsil.TabIndex = 19;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnekle.Location = new System.Drawing.Point(21, 320);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(158, 67);
            this.btnekle.TabIndex = 18;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(602, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(611, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Id:";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(671, 315);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(244, 34);
            this.txtAd.TabIndex = 22;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.Location = new System.Drawing.Point(671, 259);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(244, 34);
            this.txtId.TabIndex = 21;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyad.Location = new System.Drawing.Point(671, 377);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(244, 34);
            this.txtsoyad.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(563, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(569, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Kulüp:";
            // 
            // cmbkulup
            // 
            this.cmbkulup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbkulup.FormattingEnabled = true;
            this.cmbkulup.Location = new System.Drawing.Point(671, 437);
            this.cmbkulup.Name = "cmbkulup";
            this.cmbkulup.Size = new System.Drawing.Size(244, 33);
            this.cmbkulup.TabIndex = 28;
            // 
            // RadioErkek
            // 
            this.RadioErkek.AutoSize = true;
            this.RadioErkek.Location = new System.Drawing.Point(671, 494);
            this.RadioErkek.Name = "RadioErkek";
            this.RadioErkek.Size = new System.Drawing.Size(83, 29);
            this.RadioErkek.TabIndex = 29;
            this.RadioErkek.TabStop = true;
            this.RadioErkek.Text = "Erkek";
            this.RadioErkek.UseVisualStyleBackColor = true;
            this.RadioErkek.CheckedChanged += new System.EventHandler(this.RadioErkek_CheckedChanged);
            // 
            // radioKiz
            // 
            this.radioKiz.AutoSize = true;
            this.radioKiz.Location = new System.Drawing.Point(805, 494);
            this.radioKiz.Name = "radioKiz";
            this.radioKiz.Size = new System.Drawing.Size(61, 29);
            this.radioKiz.TabIndex = 30;
            this.radioKiz.TabStop = true;
            this.radioKiz.Text = "Kız";
            this.radioKiz.UseVisualStyleBackColor = true;
            this.radioKiz.CheckedChanged += new System.EventHandler(this.radioKiz_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(546, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 29);
            this.label6.TabIndex = 31;
            this.label6.Text = "Cinsiyet:";
            // 
            // txtara
            // 
            this.txtara.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtara.Location = new System.Drawing.Point(21, 454);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(273, 34);
            this.txtara.TabIndex = 32;
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnara.Location = new System.Drawing.Point(324, 451);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(161, 37);
            this.btnara.TabIndex = 33;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // FrmOgrenciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(972, 559);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioKiz);
            this.Controls.Add(this.RadioErkek);
            this.Controls.Add(this.cmbkulup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmOgrenciler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ogrenciler";
            this.Load += new System.EventHandler(this.FrmOgrenciler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbkulup;
        private System.Windows.Forms.RadioButton RadioErkek;
        private System.Windows.Forms.RadioButton radioKiz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.Button btnara;
    }
}