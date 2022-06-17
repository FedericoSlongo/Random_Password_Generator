namespace Random_password_generator_csharp__form_
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lenght_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.c_but = new System.Windows.Forms.RadioButton();
            this.cn_but = new System.Windows.Forms.RadioButton();
            this.cns_but = new System.Windows.Forms.RadioButton();
            this.Generate_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cns_but);
            this.groupBox1.Controls.Add(this.cn_but);
            this.groupBox1.Controls.Add(this.c_but);
            this.groupBox1.Location = new System.Drawing.Point(264, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What type of password do you need";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "How long do you want the password to be?";
            // 
            // lenght_box
            // 
            this.lenght_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lenght_box.Location = new System.Drawing.Point(11, 25);
            this.lenght_box.Name = "lenght_box";
            this.lenght_box.Size = new System.Drawing.Size(247, 20);
            this.lenght_box.TabIndex = 2;
            this.lenght_box.TextChanged += new System.EventHandler(this.lenght_box_TextChanged);
            // 
            // password_box
            // 
            this.password_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.password_box.Location = new System.Drawing.Point(15, 115);
            this.password_box.Name = "password_box";
            this.password_box.ReadOnly = true;
            this.password_box.Size = new System.Drawing.Size(243, 20);
            this.password_box.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "The password is:";
            // 
            // c_but
            // 
            this.c_but.AutoSize = true;
            this.c_but.Location = new System.Drawing.Point(7, 16);
            this.c_but.Name = "c_but";
            this.c_but.Size = new System.Drawing.Size(99, 17);
            this.c_but.TabIndex = 0;
            this.c_but.TabStop = true;
            this.c_but.Text = "Only characters";
            this.c_but.UseVisualStyleBackColor = true;
            // 
            // cn_but
            // 
            this.cn_but.AutoSize = true;
            this.cn_but.Location = new System.Drawing.Point(6, 39);
            this.cn_but.Name = "cn_but";
            this.cn_but.Size = new System.Drawing.Size(140, 17);
            this.cn_but.TabIndex = 1;
            this.cn_but.TabStop = true;
            this.cn_but.Text = "Characters and numbers";
            this.cn_but.UseVisualStyleBackColor = true;
            // 
            // cns_but
            // 
            this.cns_but.AutoSize = true;
            this.cns_but.Location = new System.Drawing.Point(7, 62);
            this.cns_but.Name = "cns_but";
            this.cns_but.Size = new System.Drawing.Size(183, 17);
            this.cns_but.TabIndex = 2;
            this.cns_but.TabStop = true;
            this.cns_but.Text = "Characters, numbers and symbols";
            this.cns_but.UseVisualStyleBackColor = true;
            // 
            // Generate_button
            // 
            this.Generate_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Generate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate_button.Location = new System.Drawing.Point(15, 51);
            this.Generate_button.Name = "Generate_button";
            this.Generate_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Generate_button.Size = new System.Drawing.Size(243, 45);
            this.Generate_button.TabIndex = 5;
            this.Generate_button.Text = "Generate";
            this.Generate_button.UseVisualStyleBackColor = true;
            this.Generate_button.Click += new System.EventHandler(this.Generate_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 160);
            this.Controls.Add(this.Generate_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.lenght_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Password generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cns_but;
        private System.Windows.Forms.RadioButton cn_but;
        private System.Windows.Forms.RadioButton c_but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lenght_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Generate_button;
    }
}

