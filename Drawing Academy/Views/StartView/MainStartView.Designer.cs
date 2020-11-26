namespace Drawing_Academy.Views.StartView
{
    partial class MainStartView
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
            this.button1_start = new System.Windows.Forms.Button();
            this.button2_setting = new System.Windows.Forms.Button();
            this.button3_exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_start
            // 
            this.button1_start.Location = new System.Drawing.Point(420, 139);
            this.button1_start.Name = "button1_start";
            this.button1_start.Size = new System.Drawing.Size(174, 63);
            this.button1_start.TabIndex = 0;
            this.button1_start.Text = "start";
            this.button1_start.UseVisualStyleBackColor = true;
            this.button1_start.Click += new System.EventHandler(this.button1_start_Click);
            // 
            // button2_setting
            // 
            this.button2_setting.Location = new System.Drawing.Point(420, 217);
            this.button2_setting.Name = "button2_setting";
            this.button2_setting.Size = new System.Drawing.Size(174, 63);
            this.button2_setting.TabIndex = 1;
            this.button2_setting.Text = "setting";
            this.button2_setting.UseVisualStyleBackColor = true;
            this.button2_setting.Click += new System.EventHandler(this.button2_setting_Click);
            // 
            // button3_exit
            // 
            this.button3_exit.Location = new System.Drawing.Point(420, 304);
            this.button3_exit.Name = "button3_exit";
            this.button3_exit.Size = new System.Drawing.Size(174, 63);
            this.button3_exit.TabIndex = 2;
            this.button3_exit.Text = "exit";
            this.button3_exit.UseVisualStyleBackColor = true;
            this.button3_exit.Click += new System.EventHandler(this.button3_exit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bảng xếp hạng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainStartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3_exit);
            this.Controls.Add(this.button2_setting);
            this.Controls.Add(this.button1_start);
            this.Name = "MainStartView";
            this.Size = new System.Drawing.Size(1037, 532);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1_start;
        private System.Windows.Forms.Button button2_setting;
        private System.Windows.Forms.Button button3_exit;
        private System.Windows.Forms.Button button1;
    }
}
