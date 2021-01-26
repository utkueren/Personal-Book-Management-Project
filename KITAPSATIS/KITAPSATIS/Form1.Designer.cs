
namespace KITAPSATIS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.RB3 = new System.Windows.Forms.RadioButton();
            this.KTur = new System.Windows.Forms.GroupBox();
            this.oztte = new System.Windows.Forms.Button();
            this.oztta = new System.Windows.Forms.Button();
            this.oztro = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbs = new System.Windows.Forms.TextBox();
            this.btnkay = new System.Windows.Forms.Button();
            this.txtye = new System.Windows.Forms.TextBox();
            this.txtSS = new System.Windows.Forms.TextBox();
            this.txtYa = new System.Windows.Forms.TextBox();
            this.txtkad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listkit = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbguzel = new System.Windows.Forms.RadioButton();
            this.rborta = new System.Windows.Forms.RadioButton();
            this.rbkotu = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.KTur.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RB1.Location = new System.Drawing.Point(45, 39);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(101, 34);
            this.RB1.TabIndex = 0;
            this.RB1.TabStop = true;
            this.RB1.Text = "Roman";
            this.RB1.UseVisualStyleBackColor = true;
            this.RB1.CheckedChanged += new System.EventHandler(this.RB1_CheckedChanged);
            // 
            // RB2
            // 
            this.RB2.AutoSize = true;
            this.RB2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.RB2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RB2.Location = new System.Drawing.Point(189, 39);
            this.RB2.Name = "RB2";
            this.RB2.Size = new System.Drawing.Size(80, 34);
            this.RB2.TabIndex = 1;
            this.RB2.TabStop = true;
            this.RB2.Text = "Tarih";
            this.RB2.UseVisualStyleBackColor = false;
            this.RB2.CheckedChanged += new System.EventHandler(this.RB2_CheckedChanged);
            // 
            // RB3
            // 
            this.RB3.AutoSize = true;
            this.RB3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RB3.Location = new System.Drawing.Point(318, 39);
            this.RB3.Name = "RB3";
            this.RB3.Size = new System.Drawing.Size(120, 34);
            this.RB3.TabIndex = 2;
            this.RB3.TabStop = true;
            this.RB3.Text = "Teknoloji";
            this.RB3.UseVisualStyleBackColor = true;
            this.RB3.CheckedChanged += new System.EventHandler(this.RB3_CheckedChanged);
            // 
            // KTur
            // 
            this.KTur.Controls.Add(this.oztte);
            this.KTur.Controls.Add(this.oztta);
            this.KTur.Controls.Add(this.oztro);
            this.KTur.Controls.Add(this.RB1);
            this.KTur.Controls.Add(this.RB3);
            this.KTur.Controls.Add(this.RB2);
            this.KTur.Location = new System.Drawing.Point(30, 12);
            this.KTur.Name = "KTur";
            this.KTur.Size = new System.Drawing.Size(443, 118);
            this.KTur.TabIndex = 3;
            this.KTur.TabStop = false;
            this.KTur.Text = "Kitap Türleri";
            // 
            // oztte
            // 
            this.oztte.Location = new System.Drawing.Point(329, 79);
            this.oztte.Name = "oztte";
            this.oztte.Size = new System.Drawing.Size(94, 29);
            this.oztte.TabIndex = 5;
            this.oztte.Text = "Nedir?";
            this.oztte.UseVisualStyleBackColor = true;
            this.oztte.Click += new System.EventHandler(this.oztte_Click);
            // 
            // oztta
            // 
            this.oztta.Location = new System.Drawing.Point(189, 79);
            this.oztta.Name = "oztta";
            this.oztta.Size = new System.Drawing.Size(94, 29);
            this.oztta.TabIndex = 4;
            this.oztta.Text = "Nedir?";
            this.oztta.UseVisualStyleBackColor = true;
            this.oztta.Click += new System.EventHandler(this.oztta_Click);
            // 
            // oztro
            // 
            this.oztro.Location = new System.Drawing.Point(45, 79);
            this.oztro.Name = "oztro";
            this.oztro.Size = new System.Drawing.Size(94, 29);
            this.oztro.TabIndex = 3;
            this.oztro.Text = "Nedir?";
            this.oztro.UseVisualStyleBackColor = true;
            this.oztro.Click += new System.EventHandler(this.oztro_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbs);
            this.groupBox1.Controls.Add(this.btnkay);
            this.groupBox1.Controls.Add(this.txtye);
            this.groupBox1.Controls.Add(this.txtSS);
            this.groupBox1.Controls.Add(this.txtYa);
            this.groupBox1.Controls.Add(this.txtkad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(30, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 292);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            // 
            // txtbs
            // 
            this.txtbs.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtbs.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbs.Location = new System.Drawing.Point(208, 187);
            this.txtbs.Name = "txtbs";
            this.txtbs.Size = new System.Drawing.Size(125, 36);
            this.txtbs.TabIndex = 24;
            // 
            // btnkay
            // 
            this.btnkay.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnkay.Location = new System.Drawing.Point(208, 229);
            this.btnkay.Name = "btnkay";
            this.btnkay.Size = new System.Drawing.Size(125, 39);
            this.btnkay.TabIndex = 25;
            this.btnkay.Text = "Kaydet";
            this.btnkay.UseVisualStyleBackColor = true;
            this.btnkay.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtye
            // 
            this.txtye.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtye.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtye.Location = new System.Drawing.Point(208, 148);
            this.txtye.Name = "txtye";
            this.txtye.Size = new System.Drawing.Size(125, 36);
            this.txtye.TabIndex = 23;
            // 
            // txtSS
            // 
            this.txtSS.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSS.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSS.Location = new System.Drawing.Point(208, 109);
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(125, 36);
            this.txtSS.TabIndex = 22;
            // 
            // txtYa
            // 
            this.txtYa.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtYa.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtYa.Location = new System.Drawing.Point(208, 70);
            this.txtYa.Name = "txtYa";
            this.txtYa.Size = new System.Drawing.Size(125, 36);
            this.txtYa.TabIndex = 21;
            // 
            // txtkad
            // 
            this.txtkad.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtkad.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtkad.Location = new System.Drawing.Point(208, 32);
            this.txtkad.Name = "txtkad";
            this.txtkad.Size = new System.Drawing.Size(125, 36);
            this.txtkad.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(72, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "Baskı Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(73, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "Yayınevi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(73, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "Sayfa Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(72, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Yazar Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(72, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 30);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kitap Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listkit);
            this.groupBox2.Location = new System.Drawing.Point(479, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 416);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitaplar";
            // 
            // listkit
            // 
            this.listkit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listkit.Cursor = System.Windows.Forms.Cursors.Default;
            this.listkit.FormattingEnabled = true;
            this.listkit.ItemHeight = 20;
            this.listkit.Location = new System.Drawing.Point(6, 26);
            this.listkit.Name = "listkit";
            this.listkit.Size = new System.Drawing.Size(583, 384);
            this.listkit.TabIndex = 0;
            this.listkit.SelectedIndexChanged += new System.EventHandler(this.listkit_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbguzel);
            this.groupBox3.Controls.Add(this.rborta);
            this.groupBox3.Controls.Add(this.rbkotu);
            this.groupBox3.Location = new System.Drawing.Point(30, 434);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 93);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Değerlendirme";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rbguzel
            // 
            this.rbguzel.AutoSize = true;
            this.rbguzel.Location = new System.Drawing.Point(318, 36);
            this.rbguzel.Name = "rbguzel";
            this.rbguzel.Size = new System.Drawing.Size(67, 24);
            this.rbguzel.TabIndex = 2;
            this.rbguzel.TabStop = true;
            this.rbguzel.Text = "Güzel";
            this.rbguzel.UseVisualStyleBackColor = true;
            this.rbguzel.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rborta
            // 
            this.rborta.AutoSize = true;
            this.rborta.Location = new System.Drawing.Point(177, 36);
            this.rborta.Name = "rborta";
            this.rborta.Size = new System.Drawing.Size(59, 24);
            this.rborta.TabIndex = 1;
            this.rborta.TabStop = true;
            this.rborta.Text = "Orta";
            this.rborta.UseVisualStyleBackColor = true;
            // 
            // rbkotu
            // 
            this.rbkotu.AutoSize = true;
            this.rbkotu.Location = new System.Drawing.Point(45, 36);
            this.rbkotu.Name = "rbkotu";
            this.rbkotu.Size = new System.Drawing.Size(61, 24);
            this.rbkotu.TabIndex = 0;
            this.rbkotu.TabStop = true;
            this.rbkotu.Text = "Kötü";
            this.rbkotu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1136, 558);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.KTur);
            this.Name = "Form1";
            this.Text = "Kitap Kayıt Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KTur.ResumeLayout(false);
            this.KTur.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton RB1;
        private System.Windows.Forms.RadioButton RB2;
        private System.Windows.Forms.RadioButton RB3;
        private System.Windows.Forms.GroupBox KTur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnkay;
        private System.Windows.Forms.TextBox txtbs;
        private System.Windows.Forms.TextBox txtye;
        private System.Windows.Forms.TextBox txtSS;
        private System.Windows.Forms.TextBox txtYa;
        private System.Windows.Forms.TextBox txtkad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button oztte;
        private System.Windows.Forms.Button oztta;
        private System.Windows.Forms.Button oztro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listkit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbguzel;
        private System.Windows.Forms.RadioButton rborta;
        private System.Windows.Forms.RadioButton rbkotu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

