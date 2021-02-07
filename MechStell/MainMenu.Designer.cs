namespace MechStell
{
    partial class formMainMenu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMainMenu));
            this.inputAdress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.radioADorf = new System.Windows.Forms.RadioButton();
            this.boxStellwerk = new System.Windows.Forms.GroupBox();
            this.radioBkABerg = new System.Windows.Forms.RadioButton();
            this.radioCStadt = new System.Windows.Forms.RadioButton();
            this.radioBHeim = new System.Windows.Forms.RadioButton();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.numericPort = new System.Windows.Forms.NumericUpDown();
            this.labelStatus = new System.Windows.Forms.Label();
            this.boxStellwerk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPort)).BeginInit();
            this.SuspendLayout();
            // 
            // inputAdress
            // 
            this.inputAdress.Location = new System.Drawing.Point(195, 162);
            this.inputAdress.Name = "inputAdress";
            this.inputAdress.Size = new System.Drawing.Size(172, 20);
            this.inputAdress.TabIndex = 0;
            this.inputAdress.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP-Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Enabled = false;
            this.buttonConnect.Location = new System.Drawing.Point(195, 228);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(172, 23);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Verbinden";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // radioADorf
            // 
            this.radioADorf.AutoSize = true;
            this.radioADorf.Location = new System.Drawing.Point(6, 19);
            this.radioADorf.Name = "radioADorf";
            this.radioADorf.Size = new System.Drawing.Size(55, 17);
            this.radioADorf.TabIndex = 5;
            this.radioADorf.TabStop = true;
            this.radioADorf.Text = "A-Dorf";
            this.radioADorf.UseVisualStyleBackColor = true;
            this.radioADorf.CheckedChanged += new System.EventHandler(this.radioStellwerk_CheckedChanged);
            // 
            // boxStellwerk
            // 
            this.boxStellwerk.Controls.Add(this.radioBkABerg);
            this.boxStellwerk.Controls.Add(this.radioCStadt);
            this.boxStellwerk.Controls.Add(this.radioBHeim);
            this.boxStellwerk.Controls.Add(this.radioADorf);
            this.boxStellwerk.Location = new System.Drawing.Point(12, 146);
            this.boxStellwerk.Name = "boxStellwerk";
            this.boxStellwerk.Size = new System.Drawing.Size(174, 126);
            this.boxStellwerk.TabIndex = 6;
            this.boxStellwerk.TabStop = false;
            this.boxStellwerk.Text = "Stellwerk";
            // 
            // radioBkABerg
            // 
            this.radioBkABerg.AutoSize = true;
            this.radioBkABerg.Location = new System.Drawing.Point(6, 42);
            this.radioBkABerg.Name = "radioBkABerg";
            this.radioBkABerg.Size = new System.Drawing.Size(73, 17);
            this.radioBkABerg.TabIndex = 8;
            this.radioBkABerg.TabStop = true;
            this.radioBkABerg.Text = "Bk A-Berg";
            this.radioBkABerg.UseVisualStyleBackColor = true;
            this.radioBkABerg.CheckedChanged += new System.EventHandler(this.radioStellwerk_CheckedChanged);
            // 
            // radioCStadt
            // 
            this.radioCStadt.AutoSize = true;
            this.radioCStadt.Location = new System.Drawing.Point(6, 88);
            this.radioCStadt.Name = "radioCStadt";
            this.radioCStadt.Size = new System.Drawing.Size(60, 17);
            this.radioCStadt.TabIndex = 7;
            this.radioCStadt.TabStop = true;
            this.radioCStadt.Text = "C-Stadt";
            this.radioCStadt.UseVisualStyleBackColor = true;
            this.radioCStadt.CheckedChanged += new System.EventHandler(this.radioStellwerk_CheckedChanged);
            // 
            // radioBHeim
            // 
            this.radioBHeim.AutoSize = true;
            this.radioBHeim.Location = new System.Drawing.Point(6, 65);
            this.radioBHeim.Name = "radioBHeim";
            this.radioBHeim.Size = new System.Drawing.Size(59, 17);
            this.radioBHeim.TabIndex = 6;
            this.radioBHeim.TabStop = true;
            this.radioBHeim.Text = "B-Heim";
            this.radioBHeim.UseVisualStyleBackColor = true;
            this.radioBHeim.CheckedChanged += new System.EventHandler(this.radioStellwerk_CheckedChanged);
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(512, 128);
            this.pictureLogo.TabIndex = 7;
            this.pictureLogo.TabStop = false;
            // 
            // numericPort
            // 
            this.numericPort.Location = new System.Drawing.Point(195, 202);
            this.numericPort.Maximum = new decimal(new int[] {
            65555,
            0,
            0,
            0});
            this.numericPort.Name = "numericPort";
            this.numericPort.Size = new System.Drawing.Size(172, 20);
            this.numericPort.TabIndex = 8;
            this.numericPort.Value = new decimal(new int[] {
            25025,
            0,
            0,
            0});
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(192, 254);
            this.labelStatus.MaximumSize = new System.Drawing.Size(172, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(48, 13);
            this.labelStatus.TabIndex = 9;
            this.labelStatus.Text = "Getrennt";
            // 
            // formMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(538, 284);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.numericPort);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.boxStellwerk);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputAdress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMainMenu";
            this.Text = "MechStell - Hauptmenü";
            this.Load += new System.EventHandler(this.Mainmenu_Load);
            this.boxStellwerk.ResumeLayout(false);
            this.boxStellwerk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.RadioButton radioADorf;
        private System.Windows.Forms.GroupBox boxStellwerk;
        private System.Windows.Forms.RadioButton radioBHeim;
        private System.Windows.Forms.RadioButton radioCStadt;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.RadioButton radioBkABerg;
        private System.Windows.Forms.NumericUpDown numericPort;
        private System.Windows.Forms.Label labelStatus;
    }
}

