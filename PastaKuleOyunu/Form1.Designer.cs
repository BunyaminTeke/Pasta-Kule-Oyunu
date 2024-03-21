namespace PastaKuleOyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            platform = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // platform
            // 
            platform.BackColor = SystemColors.AppWorkspace;
            platform.Enabled = false;
            platform.FlatAppearance.BorderSize = 0;
            platform.FlatStyle = FlatStyle.Popup;
            platform.Location = new Point(282, 503);
            platform.Name = "platform";
            platform.Size = new Size(250, 38);
            platform.TabIndex = 0;
            platform.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Interval = 34;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(21, 45);
            label1.Name = "label1";
            label1.Size = new Size(69, 29);
            label1.TabIndex = 1;
            label1.Text = "Skor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(96, 45);
            label2.Name = "label2";
            label2.Size = new Size(27, 29);
            label2.TabIndex = 2;
            label2.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 953);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(platform);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pasta Oyunu";
            KeyDown += Form1_KeyDown;
            MouseClick += Form1_MouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button platform;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
    }
}
