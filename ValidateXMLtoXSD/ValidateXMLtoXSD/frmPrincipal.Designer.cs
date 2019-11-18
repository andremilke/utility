namespace ValidateXMLtoXSD
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.btnXSD = new System.Windows.Forms.Button();
            this.btnXML = new System.Windows.Forms.Button();
            this.lblXSD = new System.Windows.Forms.Label();
            this.txtCaminhoXSD = new System.Windows.Forms.TextBox();
            this.lblXML = new System.Windows.Forms.Label();
            this.txtCaminhoXML = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBox
            // 
            this.grpBox.CausesValidation = false;
            this.grpBox.Controls.Add(this.btnXSD);
            this.grpBox.Controls.Add(this.btnXML);
            this.grpBox.Controls.Add(this.lblXSD);
            this.grpBox.Controls.Add(this.txtCaminhoXSD);
            this.grpBox.Controls.Add(this.lblXML);
            this.grpBox.Controls.Add(this.txtCaminhoXML);
            this.grpBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.grpBox.Location = new System.Drawing.Point(12, 12);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(573, 155);
            this.grpBox.TabIndex = 0;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Dados para Validação";
            // 
            // btnXSD
            // 
            this.btnXSD.CausesValidation = false;
            this.btnXSD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXSD.Image = global::ValidateXMLtoXSD.Properties.Resources.folder_open;
            this.btnXSD.Location = new System.Drawing.Point(470, 92);
            this.btnXSD.Name = "btnXSD";
            this.btnXSD.Size = new System.Drawing.Size(35, 23);
            this.btnXSD.TabIndex = 5;
            this.btnXSD.UseVisualStyleBackColor = true;
            this.btnXSD.Click += new System.EventHandler(this.btnXSD_Click);
            // 
            // btnXML
            // 
            this.btnXML.CausesValidation = false;
            this.btnXML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXML.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnXML.Image = global::ValidateXMLtoXSD.Properties.Resources.folder_open;
            this.btnXML.Location = new System.Drawing.Point(470, 33);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(35, 23);
            this.btnXML.TabIndex = 4;
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // lblXSD
            // 
            this.lblXSD.AutoSize = true;
            this.lblXSD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblXSD.Location = new System.Drawing.Point(41, 95);
            this.lblXSD.Name = "lblXSD";
            this.lblXSD.Size = new System.Drawing.Size(32, 13);
            this.lblXSD.TabIndex = 3;
            this.lblXSD.Text = "XSD:";
            // 
            // txtCaminhoXSD
            // 
            this.txtCaminhoXSD.CausesValidation = false;
            this.txtCaminhoXSD.Location = new System.Drawing.Point(91, 92);
            this.txtCaminhoXSD.Name = "txtCaminhoXSD";
            this.txtCaminhoXSD.Size = new System.Drawing.Size(373, 20);
            this.txtCaminhoXSD.TabIndex = 2;
            // 
            // lblXML
            // 
            this.lblXML.AutoSize = true;
            this.lblXML.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblXML.Location = new System.Drawing.Point(41, 43);
            this.lblXML.Name = "lblXML";
            this.lblXML.Size = new System.Drawing.Size(32, 13);
            this.lblXML.TabIndex = 1;
            this.lblXML.Text = "XML:";
            // 
            // txtCaminhoXML
            // 
            this.txtCaminhoXML.CausesValidation = false;
            this.txtCaminhoXML.Location = new System.Drawing.Point(91, 36);
            this.txtCaminhoXML.Name = "txtCaminhoXML";
            this.txtCaminhoXML.Size = new System.Drawing.Size(373, 20);
            this.txtCaminhoXML.TabIndex = 0;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(250, 187);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 1;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 222);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.grpBox);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Validação XML contra XSD";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.TextBox txtCaminhoXML;
        private System.Windows.Forms.Label lblXSD;
        private System.Windows.Forms.TextBox txtCaminhoXSD;
        private System.Windows.Forms.Label lblXML;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.Button btnXSD;
    }
}

