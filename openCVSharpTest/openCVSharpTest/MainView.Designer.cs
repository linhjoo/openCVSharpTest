namespace openCVSharpTest
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox_view = new System.Windows.Forms.PictureBox();
            this.button_load = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.label_xy = new System.Windows.Forms.Label();
            this.label_grayval = new System.Windows.Forms.Label();
            this.contextMenuPicture = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setROIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_view)).BeginInit();
            this.contextMenuPicture.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_view
            // 
            this.pictureBox_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_view.Location = new System.Drawing.Point(10, 10);
            this.pictureBox_view.Name = "pictureBox_view";
            this.pictureBox_view.Size = new System.Drawing.Size(380, 380);
            this.pictureBox_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_view.TabIndex = 0;
            this.pictureBox_view.TabStop = false;
            this.pictureBox_view.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox_view_DragDrop);
            this.pictureBox_view.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_view_MouseDown);
            this.pictureBox_view.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_view_MouseMove);
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
            // label_xy
            // 
            this.label_xy.AutoSize = true;
            this.label_xy.Location = new System.Drawing.Point(10, 400);
            this.label_xy.Name = "label_xy";
            this.label_xy.Size = new System.Drawing.Size(90, 15);
            this.label_xy.TabIndex = 3;
            this.label_xy.Text = "Mouse Position";
            // 
            // label_grayval
            // 
            this.label_grayval.AutoSize = true;
            this.label_grayval.Location = new System.Drawing.Point(396, 10);
            this.label_grayval.Name = "label_grayval";
            this.label_grayval.Size = new System.Drawing.Size(39, 15);
            this.label_grayval.TabIndex = 4;
            this.label_grayval.Text = "label1";
            // 
            // contextMenuPicture
            // 
            this.contextMenuPicture.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.saveImageToolStripMenuItem,
            this.setROIToolStripMenuItem});
            this.contextMenuPicture.Name = "contextMenuPicture";
            this.contextMenuPicture.Size = new System.Drawing.Size(138, 70);
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            // 
            // setROIToolStripMenuItem
            // 
            this.setROIToolStripMenuItem.Name = "setROIToolStripMenuItem";
            this.setROIToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.setROIToolStripMenuItem.Text = "Set ROI";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(629, 430);
            this.Controls.Add(this.label_grayval);
            this.Controls.Add(this.label_xy);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.pictureBox_view);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_view)).EndInit();
            this.contextMenuPicture.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox_view;
        private Button button_load;
        private Button button_exit;
        private Label label_xy;
        private Label label_grayval;
        private ContextMenuStrip contextMenuPicture;
        private ToolStripMenuItem loadImageToolStripMenuItem;
        private ToolStripMenuItem saveImageToolStripMenuItem;
        private ToolStripMenuItem setROIToolStripMenuItem;
    }
}