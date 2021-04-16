
namespace Base64
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtstring64 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDiretorio = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtEncoder = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblDirArq = new System.Windows.Forms.Label();
            this.btnSelArq = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtstring64);
            this.groupBox1.Location = new System.Drawing.Point(8, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base64 para PDF";
            // 
            // txtstring64
            // 
            this.txtstring64.Location = new System.Drawing.Point(6, 22);
            this.txtstring64.Name = "txtstring64";
            this.txtstring64.Size = new System.Drawing.Size(746, 52);
            this.txtstring64.TabIndex = 0;
            this.txtstring64.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnDiretorio);
            this.groupBox2.Location = new System.Drawing.Point(8, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 64);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salvar PDF";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(608, 31);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(142, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Converter para PDF";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "C:\\temp\\decode.pdf";
            // 
            // btnDiretorio
            // 
            this.btnDiretorio.Location = new System.Drawing.Point(6, 35);
            this.btnDiretorio.Name = "btnDiretorio";
            this.btnDiretorio.Size = new System.Drawing.Size(99, 23);
            this.btnDiretorio.TabIndex = 0;
            this.btnDiretorio.Text = "Seleciona Dir.";
            this.btnDiretorio.UseVisualStyleBackColor = true;
            this.btnDiretorio.Click += new System.EventHandler(this.btnDiretorio_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(772, 190);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Base64 para PDF";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCopiar);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(12, 220);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(772, 218);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Arquivo para Base64";
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(616, 185);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(142, 27);
            this.btnCopiar.TabIndex = 7;
            this.btnCopiar.Text = "Copiar Base64";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtEncoder);
            this.groupBox7.Location = new System.Drawing.Point(6, 92);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(758, 80);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Base64";
            // 
            // txtEncoder
            // 
            this.txtEncoder.Location = new System.Drawing.Point(6, 22);
            this.txtEncoder.Name = "txtEncoder";
            this.txtEncoder.Size = new System.Drawing.Size(746, 52);
            this.txtEncoder.TabIndex = 0;
            this.txtEncoder.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnConverter);
            this.groupBox5.Controls.Add(this.lblDirArq);
            this.groupBox5.Controls.Add(this.btnSelArq);
            this.groupBox5.Location = new System.Drawing.Point(8, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(758, 64);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Salvar PDF";
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(608, 31);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(142, 23);
            this.btnConverter.TabIndex = 2;
            this.btnConverter.Text = "Converter para Base64";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblDirArq
            // 
            this.lblDirArq.AutoSize = true;
            this.lblDirArq.Location = new System.Drawing.Point(120, 39);
            this.lblDirArq.Name = "lblDirArq";
            this.lblDirArq.Size = new System.Drawing.Size(0, 15);
            this.lblDirArq.TabIndex = 1;
            // 
            // btnSelArq
            // 
            this.btnSelArq.Location = new System.Drawing.Point(6, 35);
            this.btnSelArq.Name = "btnSelArq";
            this.btnSelArq.Size = new System.Drawing.Size(99, 23);
            this.btnSelArq.TabIndex = 0;
            this.btnSelArq.Text = "Sel. Arquivo";
            this.btnSelArq.UseVisualStyleBackColor = true;
            this.btnSelArq.Click += new System.EventHandler(this.btnSelArq_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.richTextBox1);
            this.groupBox6.Location = new System.Drawing.Point(7, 103);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(758, 122);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Base64";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(746, 52);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(628, 452);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(144, 24);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 488);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base64 Encoder | Decoder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDiretorio;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RichTextBox txtstring64;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox txtEncoder;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblDirArq;
        private System.Windows.Forms.Button btnSelArq;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox c;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Button btnSair;
    }
}

