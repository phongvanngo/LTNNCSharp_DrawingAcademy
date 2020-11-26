namespace Drawing_Academy.Views.ResultView
{
    partial class MainResultView
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
            this.button1_continue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kết quả";
            // 
            // button1_continue
            // 
            this.button1_continue.Location = new System.Drawing.Point(169, 104);
            this.button1_continue.Name = "button1_continue";
            this.button1_continue.Size = new System.Drawing.Size(68, 37);
            this.button1_continue.TabIndex = 2;
            this.button1_continue.Text = "tiếp tục";
            this.button1_continue.UseVisualStyleBackColor = true;
            this.button1_continue.Click += new System.EventHandler(this.button1_continue_Click);
            // 
            // MainResultView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1_continue);
            this.Controls.Add(this.label1);
            this.Name = "MainResultView";
            this.Size = new System.Drawing.Size(407, 245);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_continue;
    }
}
