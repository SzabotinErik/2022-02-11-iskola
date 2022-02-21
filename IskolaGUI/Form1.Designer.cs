
namespace IskolaGUI
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
            this.btntörlés = new System.Windows.Forms.Button();
            this.btnMentés = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btntörlés
            // 
            this.btntörlés.Location = new System.Drawing.Point(31, 432);
            this.btntörlés.Name = "btntörlés";
            this.btntörlés.Size = new System.Drawing.Size(116, 24);
            this.btntörlés.TabIndex = 0;
            this.btntörlés.Text = "Törlés";
            this.btntörlés.UseVisualStyleBackColor = true;
            this.btntörlés.Click += new System.EventHandler(this.btntörlés_Click);
            // 
            // btnMentés
            // 
            this.btnMentés.Location = new System.Drawing.Point(195, 432);
            this.btnMentés.Name = "btnMentés";
            this.btnMentés.Size = new System.Drawing.Size(125, 24);
            this.btnMentés.TabIndex = 1;
            this.btnMentés.Text = "Mentés";
            this.btnMentés.UseVisualStyleBackColor = true;
            this.btnMentés.Click += new System.EventHandler(this.btnMentés_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(31, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(289, 394);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 489);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnMentés);
            this.Controls.Add(this.btntörlés);
            this.Name = "Form1";
            this.Text = "IskolaGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntörlés;
        private System.Windows.Forms.Button btnMentés;
        private System.Windows.Forms.ListBox listBox1;
    }
}

