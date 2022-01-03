namespace RestaurantManagementSystem
{
    partial class FormLogin
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
            this.pnlLoginComponent = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.llblPassword = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.pnlPicture = new System.Windows.Forms.Panel();
            this.pnlLoginComponent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLoginComponent
            // 
            this.pnlLoginComponent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlLoginComponent.Controls.Add(this.lblError);
            this.pnlLoginComponent.Controls.Add(this.btnClear);
            this.pnlLoginComponent.Controls.Add(this.btnLogin);
            this.pnlLoginComponent.Controls.Add(this.txtPassword);
            this.pnlLoginComponent.Controls.Add(this.txtUserID);
            this.pnlLoginComponent.Controls.Add(this.llblPassword);
            this.pnlLoginComponent.Controls.Add(this.lblUserID);
            this.pnlLoginComponent.Location = new System.Drawing.Point(732, 0);
            this.pnlLoginComponent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLoginComponent.Name = "pnlLoginComponent";
            this.pnlLoginComponent.Size = new System.Drawing.Size(357, 428);
            this.pnlLoginComponent.TabIndex = 1;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Black;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(44, 176);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(271, 20);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Invalid User name or Password";
            this.lblError.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(207, 210);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 41);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(55, 210);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(109, 42);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(55, 134);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '&';
            this.txtPassword.Size = new System.Drawing.Size(265, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(55, 60);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(265, 22);
            this.txtUserID.TabIndex = 2;
            // 
            // llblPassword
            // 
            this.llblPassword.AutoSize = true;
            this.llblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.llblPassword.Location = new System.Drawing.Point(51, 113);
            this.llblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblPassword.Name = "llblPassword";
            this.llblPassword.Size = new System.Drawing.Size(77, 17);
            this.llblPassword.TabIndex = 1;
            this.llblPassword.Text = "Password";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserID.Location = new System.Drawing.Point(51, 39);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(62, 17);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "User ID";
            // 
            // pnlPicture
            // 
            this.pnlPicture.BackgroundImage = global::RestaurantManagementSystem.Properties.Resources.images__1_;
            this.pnlPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPicture.Location = new System.Drawing.Point(1, 0);
            this.pnlPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPicture.Name = "pnlPicture";
            this.pnlPicture.Size = new System.Drawing.Size(730, 428);
            this.pnlPicture.TabIndex = 0;
            this.pnlPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPicture_Paint);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 428);
            this.Controls.Add(this.pnlLoginComponent);
            this.Controls.Add(this.pnlPicture);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLoginComponent.ResumeLayout(false);
            this.pnlLoginComponent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPicture;
        private System.Windows.Forms.Panel pnlLoginComponent;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label llblPassword;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblError;
    }
}

