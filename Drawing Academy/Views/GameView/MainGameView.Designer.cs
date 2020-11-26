namespace Drawing_Academy.Views.GameView
{
    partial class MainGameView
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
            this.button2_result = new System.Windows.Forms.Button();
            this.button1_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "chơi game";
            // 
            // button2_result
            // 
            this.button2_result.Location = new System.Drawing.Point(526, 195);
            this.button2_result.Name = "button2_result";
            this.button2_result.Size = new System.Drawing.Size(88, 37);
            this.button2_result.TabIndex = 3;
            this.button2_result.Text = "kết quả";
            this.button2_result.UseVisualStyleBackColor = true;
            this.button2_result.Click += new System.EventHandler(this.button2_result_Click);
            // 
            // button1_back
            // 
            this.button1_back.Location = new System.Drawing.Point(422, 195);
            this.button1_back.Name = "button1_back";
            this.button1_back.Size = new System.Drawing.Size(88, 37);
            this.button1_back.TabIndex = 4;
            this.button1_back.Text = "Quay lại";
            this.button1_back.UseVisualStyleBackColor = true;
            this.button1_back.Click += new System.EventHandler(this.button1_back_Click);
            // 
            // MainGameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1_back);
            this.Controls.Add(this.button2_result);
            this.Controls.Add(this.label1);
            this.Name = "MainGameView";
            this.Size = new System.Drawing.Size(631, 252);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2_result;
        private System.Windows.Forms.Button button1_back;
    }
}
