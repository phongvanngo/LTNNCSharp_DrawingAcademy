﻿namespace Drawing_Academy.Views.SettingView
{
    partial class MainSettingView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "cài đặt";
            // 
            // button1_back
            // 
            this.button1_back.Location = new System.Drawing.Point(144, 179);
            this.button1_back.Name = "button1_back";
            this.button1_back.Size = new System.Drawing.Size(75, 36);
            this.button1_back.TabIndex = 1;
            this.button1_back.Text = "quay lại";
            this.button1_back.UseVisualStyleBackColor = true;
            this.button1_back.Click += new System.EventHandler(this.button1_back_Click);
            // 
            // MainSettingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1_back);
            this.Controls.Add(this.label1);
            this.Name = "MainSettingView";
            this.Size = new System.Drawing.Size(379, 260);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_back;
    }
}
