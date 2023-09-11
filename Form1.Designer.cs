namespace CSharp_8
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
            this.button1 = new System.Windows.Forms.Button();
            this.DươngLich = new System.Windows.Forms.Label();
            this.ÂmLich = new System.Windows.Forms.Label();
            this.txtduonglich = new System.Windows.Forms.TextBox();
            this.txtamlich = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(430, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Can Chi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DươngLich
            // 
            this.DươngLich.AutoSize = true;
            this.DươngLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DươngLich.Location = new System.Drawing.Point(22, 226);
            this.DươngLich.Name = "DươngLich";
            this.DươngLich.Size = new System.Drawing.Size(166, 24);
            this.DươngLich.TabIndex = 1;
            this.DươngLich.Text = "Năm Dương Lịch";
            // 
            // ÂmLich
            // 
            this.ÂmLich.AutoSize = true;
            this.ÂmLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ÂmLich.Location = new System.Drawing.Point(22, 282);
            this.ÂmLich.Name = "ÂmLich";
            this.ÂmLich.Size = new System.Drawing.Size(135, 24);
            this.ÂmLich.TabIndex = 2;
            this.ÂmLich.Text = "Năm Âm Lịch";
            // 
            // txtduonglich
            // 
            this.txtduonglich.Location = new System.Drawing.Point(221, 230);
            this.txtduonglich.Name = "txtduonglich";
            this.txtduonglich.Size = new System.Drawing.Size(382, 20);
            this.txtduonglich.TabIndex = 3;
            // 
            // txtamlich
            // 
            this.txtamlich.Location = new System.Drawing.Point(221, 287);
            this.txtamlich.Name = "txtamlich";
            this.txtamlich.Size = new System.Drawing.Size(382, 20);
            this.txtamlich.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(532, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 65);
            this.button2.TabIndex = 5;
            this.button2.Text = "Chuyển Đổi";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 653);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtamlich);
            this.Controls.Add(this.txtduonglich);
            this.Controls.Add(this.ÂmLich);
            this.Controls.Add(this.DươngLich);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DươngLich;
        private System.Windows.Forms.Label ÂmLich;
        private System.Windows.Forms.TextBox txtduonglich;
        private System.Windows.Forms.TextBox txtamlich;
        private System.Windows.Forms.Button button2;
    }
}

