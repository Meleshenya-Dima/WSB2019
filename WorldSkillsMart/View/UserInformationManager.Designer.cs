
namespace WorldSkillsMart.View
{
    partial class UserInformationManager
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
            this.UserDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserRoleTextBox = new System.Windows.Forms.TextBox();
            this.LoginUserTextBox = new System.Windows.Forms.TextBox();
            this.PasswordUserTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmedUserTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.NewConfirmedUserTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordUserTextBox = new System.Windows.Forms.TextBox();
            this.NewLoginUserTextBox = new System.Windows.Forms.TextBox();
            this.NewRoleUserTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.NewPasswordUpdateUserTextBox = new System.Windows.Forms.TextBox();
            this.NewOnlineUserTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserDataGridView
            // 
            this.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGridView.Location = new System.Drawing.Point(12, 39);
            this.UserDataGridView.Name = "UserDataGridView";
            this.UserDataGridView.RowHeadersWidth = 51;
            this.UserDataGridView.RowTemplate.Height = 29;
            this.UserDataGridView.Size = new System.Drawing.Size(932, 222);
            this.UserDataGridView.TabIndex = 0;
            this.UserDataGridView.SelectionChanged += new System.EventHandler(this.UserDataGridViewSelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Все пользователи:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите пользователя для изменения\\удаления";
            // 
            // UserRoleTextBox
            // 
            this.UserRoleTextBox.Location = new System.Drawing.Point(175, 289);
            this.UserRoleTextBox.Name = "UserRoleTextBox";
            this.UserRoleTextBox.Size = new System.Drawing.Size(125, 27);
            this.UserRoleTextBox.TabIndex = 3;
            // 
            // LoginUserTextBox
            // 
            this.LoginUserTextBox.Location = new System.Drawing.Point(176, 337);
            this.LoginUserTextBox.Name = "LoginUserTextBox";
            this.LoginUserTextBox.Size = new System.Drawing.Size(125, 27);
            this.LoginUserTextBox.TabIndex = 4;
            // 
            // PasswordUserTextBox
            // 
            this.PasswordUserTextBox.Location = new System.Drawing.Point(176, 387);
            this.PasswordUserTextBox.Name = "PasswordUserTextBox";
            this.PasswordUserTextBox.Size = new System.Drawing.Size(125, 27);
            this.PasswordUserTextBox.TabIndex = 5;
            // 
            // ConfirmedUserTextBox
            // 
            this.ConfirmedUserTextBox.Location = new System.Drawing.Point(175, 436);
            this.ConfirmedUserTextBox.Name = "ConfirmedUserTextBox";
            this.ConfirmedUserTextBox.Size = new System.Drawing.Size(125, 27);
            this.ConfirmedUserTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Логин пользователя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Роль пользователя:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Пароль пользователя:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Разрешенный:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(452, 436);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(125, 27);
            this.IdTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Id пользователя:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(472, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 16;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(810, 486);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 25;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.InsertButtonClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(675, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Разрешенный:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(625, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Пароль пользователя:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(642, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Роль пользователя:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(633, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Логин пользователя:";
            // 
            // NewConfirmedUserTextBox
            // 
            this.NewConfirmedUserTextBox.Location = new System.Drawing.Point(791, 451);
            this.NewConfirmedUserTextBox.Name = "NewConfirmedUserTextBox";
            this.NewConfirmedUserTextBox.Size = new System.Drawing.Size(125, 27);
            this.NewConfirmedUserTextBox.TabIndex = 20;
            // 
            // NewPasswordUserTextBox
            // 
            this.NewPasswordUserTextBox.Location = new System.Drawing.Point(792, 350);
            this.NewPasswordUserTextBox.Name = "NewPasswordUserTextBox";
            this.NewPasswordUserTextBox.Size = new System.Drawing.Size(125, 27);
            this.NewPasswordUserTextBox.TabIndex = 19;
            // 
            // NewLoginUserTextBox
            // 
            this.NewLoginUserTextBox.Location = new System.Drawing.Point(792, 316);
            this.NewLoginUserTextBox.Name = "NewLoginUserTextBox";
            this.NewLoginUserTextBox.Size = new System.Drawing.Size(125, 27);
            this.NewLoginUserTextBox.TabIndex = 18;
            // 
            // NewRoleUserTextBox
            // 
            this.NewRoleUserTextBox.Location = new System.Drawing.Point(791, 283);
            this.NewRoleUserTextBox.Name = "NewRoleUserTextBox";
            this.NewRoleUserTextBox.Size = new System.Drawing.Size(125, 27);
            this.NewRoleUserTextBox.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(662, 386);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Последний вход:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(638, 420);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Изменение пароля:";
            // 
            // NewPasswordUpdateUserTextBox
            // 
            this.NewPasswordUpdateUserTextBox.Location = new System.Drawing.Point(791, 417);
            this.NewPasswordUpdateUserTextBox.Name = "NewPasswordUpdateUserTextBox";
            this.NewPasswordUpdateUserTextBox.Size = new System.Drawing.Size(125, 27);
            this.NewPasswordUpdateUserTextBox.TabIndex = 28;
            // 
            // NewOnlineUserTextBox
            // 
            this.NewOnlineUserTextBox.Location = new System.Drawing.Point(791, 383);
            this.NewOnlineUserTextBox.Name = "NewOnlineUserTextBox";
            this.NewOnlineUserTextBox.Size = new System.Drawing.Size(125, 27);
            this.NewOnlineUserTextBox.TabIndex = 29;
            // 
            // UserInformationManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 527);
            this.Controls.Add(this.NewOnlineUserTextBox);
            this.Controls.Add(this.NewPasswordUpdateUserTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NewConfirmedUserTextBox);
            this.Controls.Add(this.NewPasswordUserTextBox);
            this.Controls.Add(this.NewLoginUserTextBox);
            this.Controls.Add(this.NewRoleUserTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConfirmedUserTextBox);
            this.Controls.Add(this.PasswordUserTextBox);
            this.Controls.Add(this.LoginUserTextBox);
            this.Controls.Add(this.UserRoleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserDataGridView);
            this.Name = "UserInformationManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserInformationManager";
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UserDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserRoleTextBox;
        private System.Windows.Forms.TextBox LoginUserTextBox;
        private System.Windows.Forms.TextBox PasswordUserTextBox;
        private System.Windows.Forms.TextBox ConfirmedUserTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NewConfirmedUserTextBox;
        private System.Windows.Forms.TextBox NewPasswordUserTextBox;
        private System.Windows.Forms.TextBox NewLoginUserTextBox;
        private System.Windows.Forms.TextBox NewRoleUserTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox NewPasswordUpdateUserTextBox;
        private System.Windows.Forms.TextBox NewOnlineUserTextBox;
    }
}