namespace Git_Group5_WorkshopHomework
{
    partial class Qform
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click me!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(101, 242);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(245, 22);
            this.txtnum.TabIndex = 2;
            this.txtnum.Text = "Please enter a number between 5 and 20 ";
            this.txtnum.Click += new System.EventHandler(this.txtnum_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 61);
            this.button2.TabIndex = 3;
            this.button2.Text = "Calculate Sum!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Qform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 378);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Qform";
            this.Text = "Qform";
            this.Load += new System.EventHandler(this.Qform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button button2;
    }
}