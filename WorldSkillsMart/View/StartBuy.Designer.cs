
namespace WorldSkillsMart.View
{
    partial class StartBuy
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.покупкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лодкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аксесуарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.покупкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // покупкаToolStripMenuItem
            // 
            this.покупкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лодкиToolStripMenuItem,
            this.аксесуарыToolStripMenuItem});
            this.покупкаToolStripMenuItem.Name = "покупкаToolStripMenuItem";
            this.покупкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.покупкаToolStripMenuItem.Text = "Покупка";
            // 
            // лодкиToolStripMenuItem
            // 
            this.лодкиToolStripMenuItem.Name = "лодкиToolStripMenuItem";
            this.лодкиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.лодкиToolStripMenuItem.Text = "Лодки ";
            this.лодкиToolStripMenuItem.Click += new System.EventHandler(this.BoatToolStripMenuItemClick);
            // 
            // аксесуарыToolStripMenuItem
            // 
            this.аксесуарыToolStripMenuItem.Name = "аксесуарыToolStripMenuItem";
            this.аксесуарыToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.аксесуарыToolStripMenuItem.Text = "Аксессуары";
            // 
            // StartBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartBuy";
            this.Text = "StartBuy";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem покупкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лодкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аксесуарыToolStripMenuItem;
    }
}