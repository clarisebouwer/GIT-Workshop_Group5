namespace Git_Group5_WorkshopHomework
{
    partial class Clarise
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
            this.txtRan = new System.Windows.Forms.TextBox();
            this.btnRan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRan
            // 
            this.txtRan.Location = new System.Drawing.Point(68, 140);
            this.txtRan.Name = "txtRan";
            this.txtRan.Size = new System.Drawing.Size(100, 20);
            this.txtRan.TabIndex = 5;
            this.txtRan.TextChanged += new System.EventHandler(this.txtRan_TextChanged);
            // 
            // btnRan
            // 
            this.btnRan.Location = new System.Drawing.Point(80, 166);
            this.btnRan.Name = "btnRan";
            this.btnRan.Size = new System.Drawing.Size(75, 23);
            this.btnRan.TabIndex = 4;
            this.btnRan.Text = "Random";
            this.btnRan.UseVisualStyleBackColor = true;
            this.btnRan.Click += new System.EventHandler(this.btnRan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hi! My name is Clarise Bouwer. \r\nI am a 3rd year IT student. \r\nMy hometown is Kle" +
    "rksdorp.\r\nMy student number: 26152673";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Clarise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtRan);
            this.Controls.Add(this.btnRan);
            this.Controls.Add(this.label1);
            this.Name = "Clarise";
            this.Text = "Clarise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRan;
        private System.Windows.Forms.Button btnRan;
        private System.Windows.Forms.Label label1;
    }
}