﻿
namespace XmlYazma
{
    partial class DbToXmlForm
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
            this.btnUrunXml = new System.Windows.Forms.Button();
            this.btnTedarikciXml = new System.Windows.Forms.Button();
            this.btnUrunlerListele = new System.Windows.Forms.Button();
            this.btnTedarikcilerListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUrunXml
            // 
            this.btnUrunXml.Location = new System.Drawing.Point(24, 26);
            this.btnUrunXml.Name = "btnUrunXml";
            this.btnUrunXml.Size = new System.Drawing.Size(149, 23);
            this.btnUrunXml.TabIndex = 0;
            this.btnUrunXml.Text = "Ürünler İçin Xml Oluştur";
            this.btnUrunXml.UseVisualStyleBackColor = true;
            this.btnUrunXml.Click += new System.EventHandler(this.btnUrunXml_Click);
            // 
            // btnTedarikciXml
            // 
            this.btnTedarikciXml.Location = new System.Drawing.Point(198, 25);
            this.btnTedarikciXml.Name = "btnTedarikciXml";
            this.btnTedarikciXml.Size = new System.Drawing.Size(159, 23);
            this.btnTedarikciXml.TabIndex = 1;
            this.btnTedarikciXml.Text = "Tedarikçiler için Xml Oluştur";
            this.btnTedarikciXml.UseVisualStyleBackColor = true;
            this.btnTedarikciXml.Click += new System.EventHandler(this.btnTedarikciXml_Click);
            // 
            // btnUrunlerListele
            // 
            this.btnUrunlerListele.Location = new System.Drawing.Point(24, 76);
            this.btnUrunlerListele.Name = "btnUrunlerListele";
            this.btnUrunlerListele.Size = new System.Drawing.Size(149, 46);
            this.btnUrunlerListele.TabIndex = 2;
            this.btnUrunlerListele.Text = "Ürünler Xml Dosyasını Listele";
            this.btnUrunlerListele.UseVisualStyleBackColor = true;
            this.btnUrunlerListele.Click += new System.EventHandler(this.btnUrunlerListele_Click);
            // 
            // btnTedarikcilerListele
            // 
            this.btnTedarikcilerListele.Location = new System.Drawing.Point(198, 76);
            this.btnTedarikcilerListele.Name = "btnTedarikcilerListele";
            this.btnTedarikcilerListele.Size = new System.Drawing.Size(159, 46);
            this.btnTedarikcilerListele.TabIndex = 2;
            this.btnTedarikcilerListele.Text = "Tedarikçiler Xml Dosyasını Listele";
            this.btnTedarikcilerListele.UseVisualStyleBackColor = true;
            this.btnTedarikcilerListele.Click += new System.EventHandler(this.btnTedarikcilerListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 310);
            this.dataGridView1.TabIndex = 3;
            // 
            // DbToXmlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTedarikcilerListele);
            this.Controls.Add(this.btnUrunlerListele);
            this.Controls.Add(this.btnTedarikciXml);
            this.Controls.Add(this.btnUrunXml);
            this.Name = "DbToXmlForm";
            this.Text = "DbToXmlForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUrunXml;
        private System.Windows.Forms.Button btnTedarikciXml;
        private System.Windows.Forms.Button btnUrunlerListele;
        private System.Windows.Forms.Button btnTedarikcilerListele;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}