﻿
namespace WorldSkillsMart.View
{
    partial class ForumPage
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
            this.AdminPanelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminPanelButton
            // 
            this.AdminPanelButton.Location = new System.Drawing.Point(309, 12);
            this.AdminPanelButton.Name = "AdminPanelButton";
            this.AdminPanelButton.Size = new System.Drawing.Size(160, 49);
            this.AdminPanelButton.TabIndex = 0;
            this.AdminPanelButton.Text = "Администраторская панель";
            this.AdminPanelButton.UseVisualStyleBackColor = true;
            this.AdminPanelButton.Visible = false;
            this.AdminPanelButton.Click += new System.EventHandler(this.AdminPanelButtonClick);
            // 
            // ForumPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminPanelButton);
            this.Name = "ForumPage";
            this.Text = "ForumPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdminPanelButton;
    }
}