namespace Calculator
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
            this.lbla = new System.Windows.Forms.Label();
            this.btnCong = new System.Windows.Forms.Button();
            this.txta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.TextBox();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(55, 26);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(16, 17);
            this.lbla.TabIndex = 0;
            this.lbla.Text = "a";
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(117, 166);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(87, 30);
            this.btnCong.TabIndex = 1;
            this.btnCong.Text = "Cong";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(144, 26);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 22);
            this.txta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "b";
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(144, 62);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 22);
            this.txtb.TabIndex = 2;
            // 
            // lblKetqua
            // 
            this.lblKetqua.AutoSize = true;
            this.lblKetqua.Location = new System.Drawing.Point(55, 94);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(57, 17);
            this.lblKetqua.TabIndex = 0;
            this.lblKetqua.Text = "Ket qua";
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(144, 94);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(100, 22);
            this.txtkq.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.lblKetqua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label lblKetqua;
        private System.Windows.Forms.TextBox txtkq;
    }
}

