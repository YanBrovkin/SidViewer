
namespace WindowsFormsApp1
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
            this.sourceSidText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ToBinaryFormButton = new System.Windows.Forms.Button();
            this.ToStringFormButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceSidText
            // 
            this.sourceSidText.Location = new System.Drawing.Point(16, 21);
            this.sourceSidText.Multiline = true;
            this.sourceSidText.Name = "sourceSidText";
            this.sourceSidText.Size = new System.Drawing.Size(398, 97);
            this.sourceSidText.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sourceSidText);
            this.groupBox1.Location = new System.Drawing.Point(30, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source SID";
            // 
            // ToBinaryFormButton
            // 
            this.ToBinaryFormButton.Location = new System.Drawing.Point(46, 184);
            this.ToBinaryFormButton.Name = "ToBinaryFormButton";
            this.ToBinaryFormButton.Size = new System.Drawing.Size(115, 33);
            this.ToBinaryFormButton.TabIndex = 2;
            this.ToBinaryFormButton.Text = "To Binary";
            this.ToBinaryFormButton.UseVisualStyleBackColor = true;
            this.ToBinaryFormButton.Click += new System.EventHandler(this.ToBinaryFormButton_Click);
            // 
            // ToStringFormButton
            // 
            this.ToStringFormButton.Location = new System.Drawing.Point(176, 184);
            this.ToStringFormButton.Name = "ToStringFormButton";
            this.ToStringFormButton.Size = new System.Drawing.Size(116, 33);
            this.ToStringFormButton.TabIndex = 3;
            this.ToStringFormButton.Text = "To String";
            this.ToStringFormButton.UseVisualStyleBackColor = true;
            this.ToStringFormButton.Click += new System.EventHandler(this.ToStringFormButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(346, 184);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(114, 32);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ResultText);
            this.groupBox2.Location = new System.Drawing.Point(30, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 161);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(16, 23);
            this.ResultText.Multiline = true;
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(398, 117);
            this.ResultText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 428);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ToStringFormButton);
            this.Controls.Add(this.ToBinaryFormButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SID Viewer";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox sourceSidText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ToBinaryFormButton;
        private System.Windows.Forms.Button ToStringFormButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ResultText;
    }
}

