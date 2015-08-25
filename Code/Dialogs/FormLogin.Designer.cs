namespace PrettyCheckout.Dialogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this._buttonAccept = new System.Windows.Forms.Button();
            this._groupBox1 = new System.Windows.Forms.GroupBox();
            this._textBoxPassword = new System.Windows.Forms.TextBox();
            this._textBoxUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _buttonAccept
            // 
            this._buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonAccept.Location = new System.Drawing.Point(286, 120);
            this._buttonAccept.Name = "_buttonAccept";
            this._buttonAccept.Size = new System.Drawing.Size(100, 30);
            this._buttonAccept.TabIndex = 3;
            this._buttonAccept.Text = "Anmelden";
            this._buttonAccept.UseVisualStyleBackColor = true;
            this._buttonAccept.Click += new System.EventHandler(this.ButtonAcceptClick);
            // 
            // _groupBox1
            // 
            this._groupBox1.Controls.Add(this._textBoxPassword);
            this._groupBox1.Controls.Add(this._textBoxUser);
            this._groupBox1.Controls.Add(this.label1);
            this._groupBox1.Controls.Add(this.label3);
            this._groupBox1.Location = new System.Drawing.Point(12, 12);
            this._groupBox1.Name = "_groupBox1";
            this._groupBox1.Size = new System.Drawing.Size(374, 102);
            this._groupBox1.TabIndex = 8;
            this._groupBox1.TabStop = false;
            this._groupBox1.Text = "Anmelden";
            // 
            // _textBoxPassword
            // 
            this._textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxPassword.Location = new System.Drawing.Point(132, 59);
            this._textBoxPassword.Name = "_textBoxPassword";
            this._textBoxPassword.Size = new System.Drawing.Size(221, 22);
            this._textBoxPassword.TabIndex = 2;
            this._textBoxPassword.UseSystemPasswordChar = true;
            // 
            // _textBoxUser
            // 
            this._textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxUser.Location = new System.Drawing.Point(132, 24);
            this._textBoxUser.Name = "_textBoxUser";
            this._textBoxUser.Size = new System.Drawing.Size(221, 22);
            this._textBoxUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Passwort:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Benutzer:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormLogin
            // 
            this.AcceptButton = this._buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 164);
            this.Controls.Add(this._buttonAccept);
            this.Controls.Add(this._groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anmeldung";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this._groupBox1.ResumeLayout(false);
            this._groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonAccept;
        private System.Windows.Forms.GroupBox _groupBox1;
        private System.Windows.Forms.TextBox _textBoxPassword;
        private System.Windows.Forms.TextBox _textBoxUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}