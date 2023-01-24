
namespace WorldSkillsMart.View
{
    partial class UpdateClientPassword
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
            this.PasswordTextNow = new System.Windows.Forms.TextBox();
            this.NewPasswordText = new System.Windows.Forms.TextBox();
            this.NewPasswordTextSecond = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswordTextNow
            // 
            this.PasswordTextNow.Location = new System.Drawing.Point(54, 35);
            this.PasswordTextNow.Name = "PasswordTextNow";
            this.PasswordTextNow.Size = new System.Drawing.Size(215, 27);
            this.PasswordTextNow.TabIndex = 0;
            // 
            // NewPasswordText
            // 
            this.NewPasswordText.Location = new System.Drawing.Point(54, 98);
            this.NewPasswordText.Name = "NewPasswordText";
            this.NewPasswordText.Size = new System.Drawing.Size(215, 27);
            this.NewPasswordText.TabIndex = 1;
            // 
            // NewPasswordTextSecond
            // 
            this.NewPasswordTextSecond.Location = new System.Drawing.Point(54, 164);
            this.NewPasswordTextSecond.Name = "NewPasswordTextSecond";
            this.NewPasswordTextSecond.Size = new System.Drawing.Size(215, 27);
            this.NewPasswordTextSecond.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Текущий пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Новый пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Повторите новый пароль";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Смена пароля";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UpdatePasswordButtonClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UpdateClientPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 285);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewPasswordTextSecond);
            this.Controls.Add(this.NewPasswordText);
            this.Controls.Add(this.PasswordTextNow);
            this.Name = "UpdateClientPassword";
            this.Text = "UpdateClientPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordTextNow;
        private System.Windows.Forms.TextBox NewPasswordText;
        private System.Windows.Forms.TextBox NewPasswordTextSecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}