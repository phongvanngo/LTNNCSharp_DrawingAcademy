namespace Drawing_Academy.Views.MapView
{
    partial class MainMapView
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
            this.button1_round1 = new System.Windows.Forms.Button();
            this.button2_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bản đồ";
            // 
            // button1_round1
            // 
            this.button1_round1.Location = new System.Drawing.Point(247, 70);
            this.button1_round1.Name = "button1_round1";
            this.button1_round1.Size = new System.Drawing.Size(68, 37);
            this.button1_round1.TabIndex = 1;
            this.button1_round1.Text = "vòng 1";
            this.button1_round1.UseVisualStyleBackColor = true;
            this.button1_round1.Click += new System.EventHandler(this.button1_round1_Click);
            // 
            // button2_back
            // 
            this.button2_back.Location = new System.Drawing.Point(126, 70);
            this.button2_back.Name = "button2_back";
            this.button2_back.Size = new System.Drawing.Size(88, 37);
            this.button2_back.TabIndex = 2;
            this.button2_back.Text = "quay lại";
            this.button2_back.UseVisualStyleBackColor = true;
            this.button2_back.Click += new System.EventHandler(this.button2_back_Click);
            // 
            // MainMapView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2_back);
            this.Controls.Add(this.button1_round1);
            this.Controls.Add(this.label1);
            this.Name = "MainMapView";
            this.Size = new System.Drawing.Size(554, 212);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_round1;
        private System.Windows.Forms.Button button2_back;
    }
}
