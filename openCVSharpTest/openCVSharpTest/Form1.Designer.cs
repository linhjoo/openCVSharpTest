namespace openCVSharpTest
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
            this.pictureBox_view = new System.Windows.Forms.PictureBox();
            this.button_load = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_view)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_view
            // 
            this.pictureBox_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_view.Location = new System.Drawing.Point(10, 10);
            this.pictureBox_view.Name = "pictureBox_view";
            this.pictureBox_view.Size = new System.Drawing.Size(380, 380);
            this.pictureBox_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_view.TabIndex = 0;
            this.pictureBox_view.TabStop = false;
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(222, 400);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(80, 20);
            this.button_load.TabIndex = 1;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(308, 400);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(80, 20);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(400, 430);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.pictureBox_view);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox_view;
        private Button button_load;
        private Button button_exit;
    }
}