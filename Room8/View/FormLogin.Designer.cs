namespace Room8
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
            this.labelTitolo = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonAccedi = new System.Windows.Forms.Button();
            this.buttonRegistrati = new System.Windows.Forms.Button();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitolo
            // 
            this.labelTitolo.AutoSize = true;
            this.labelTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelTitolo.Location = new System.Drawing.Point(88, 24);
            this.labelTitolo.Name = "labelTitolo";
            this.labelTitolo.Size = new System.Drawing.Size(143, 42);
            this.labelTitolo.TabIndex = 0;
            this.labelTitolo.Text = "Room8";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(68, 117);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(175, 20);
            this.textBoxMail.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(68, 170);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.Size = new System.Drawing.Size(175, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // buttonAccedi
            // 
            this.buttonAccedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccedi.Location = new System.Drawing.Point(95, 212);
            this.buttonAccedi.Name = "buttonAccedi";
            this.buttonAccedi.Size = new System.Drawing.Size(123, 37);
            this.buttonAccedi.TabIndex = 3;
            this.buttonAccedi.Text = "Accedi";
            this.buttonAccedi.UseVisualStyleBackColor = true;
            this.buttonAccedi.Click += new System.EventHandler(this.buttonAccedi_Click);
            // 
            // buttonRegistrati
            // 
            this.buttonRegistrati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrati.Location = new System.Drawing.Point(95, 255);
            this.buttonRegistrati.Name = "buttonRegistrati";
            this.buttonRegistrati.Size = new System.Drawing.Size(123, 36);
            this.buttonRegistrati.TabIndex = 4;
            this.buttonRegistrati.Text = "Registrati";
            this.buttonRegistrati.UseVisualStyleBackColor = true;
            this.buttonRegistrati.Click += new System.EventHandler(this.buttonRegistrati_Click);
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.Location = new System.Drawing.Point(132, 98);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(49, 16);
            this.labelMail.TabIndex = 5;
            this.labelMail.Text = "E-mail:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(119, 151);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(71, 16);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password:";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 326);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.buttonRegistrati);
            this.Controls.Add(this.buttonAccedi);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.labelTitolo);
            this.MaximumSize = new System.Drawing.Size(329, 364);
            this.MinimumSize = new System.Drawing.Size(329, 364);
            this.Name = "FormLogin";
            this.Text = "Room8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitolo;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonAccedi;
        private System.Windows.Forms.Button buttonRegistrati;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelPassword;
    }
}