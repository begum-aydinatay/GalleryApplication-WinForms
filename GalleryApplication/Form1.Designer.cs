namespace GalleryApplication
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
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuOpen = new ToolStripMenuItem();
            menuSave = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            menuAdd = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            menuExit = new ToolStripMenuItem();
            flowLayoutPanel = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(757, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.BackColor = SystemColors.Control;
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuOpen, menuSave, toolStripMenuItem1, menuAdd, toolStripMenuItem2, menuExit });
            menuFile.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuFile.ForeColor = SystemColors.ActiveCaptionText;
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(50, 25);
            menuFile.Text = "File";
            // 
            // menuOpen
            // 
            menuOpen.Image = Properties.Resources.open_icon;
            menuOpen.Name = "menuOpen";
            menuOpen.ShortcutKeys = Keys.Control | Keys.Shift | Keys.O;
            menuOpen.Size = new Size(238, 26);
            menuOpen.Text = "Open";
            menuOpen.Click += menuOpen_Click;
            // 
            // menuSave
            // 
            menuSave.Image = Properties.Resources.save_icon;
            menuSave.Name = "menuSave";
            menuSave.ShortcutKeys = Keys.Control | Keys.S;
            menuSave.Size = new Size(238, 26);
            menuSave.Text = "Save";
            menuSave.Click += menuSave_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(235, 6);
            // 
            // menuAdd
            // 
            menuAdd.Image = Properties.Resources.add_todo_item;
            menuAdd.Name = "menuAdd";
            menuAdd.ShortcutKeys = Keys.Control | Keys.N;
            menuAdd.Size = new Size(238, 26);
            menuAdd.Text = "Add";
            menuAdd.Click += menuAdd_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(235, 6);
            // 
            // menuExit
            // 
            menuExit.Image = Properties.Resources.exit_todo_icon;
            menuExit.Name = "menuExit";
            menuExit.ShortcutKeys = Keys.Alt | Keys.F4;
            menuExit.Size = new Size(238, 26);
            menuExit.Text = "Exit";
            menuExit.Click += menuExit_Click;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.BackColor = SystemColors.ControlLight;
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new Point(0, 29);
            flowLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Padding = new Padding(15);
            flowLayoutPanel.Size = new Size(757, 432);
            flowLayoutPanel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(757, 461);
            Controls.Add(flowLayoutPanel);
            Controls.Add(menuStrip1);
            Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Control;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuOpen;
        private ToolStripMenuItem menuSave;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem menuAdd;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem menuExit;
        private FlowLayoutPanel flowLayoutPanel;
    }
}
