namespace _2_unite_uygulama_9
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSAyi = new System.Windows.Forms.TextBox();
            this.btnKontrol_et = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "kontrol et";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // txtSAyi
            // 
            this.txtSAyi.Location = new System.Drawing.Point(131, 25);
            this.txtSAyi.Name = "txtSAyi";
            this.txtSAyi.Size = new System.Drawing.Size(100, 20);
            this.txtSAyi.TabIndex = 2;
            // 
            // btnKontrol_et
            // 
            this.btnKontrol_et.Location = new System.Drawing.Point(71, 72);
            this.btnKontrol_et.Name = "btnKontrol_et";
            this.btnKontrol_et.Size = new System.Drawing.Size(75, 23);
            this.btnKontrol_et.TabIndex = 3;
            this.btnKontrol_et.Text = "kontrol et";
            this.btnKontrol_et.UseVisualStyleBackColor = true;
            this.btnKontrol_et.Click += new System.EventHandler(this.btnKontrol_et_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.btnKontrol_et);
            this.Controls.Add(this.txtSAyi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSAyi;
        private System.Windows.Forms.Button btnKontrol_et;
    }
}

