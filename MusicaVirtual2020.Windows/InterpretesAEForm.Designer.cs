namespace MusicaVirtual2020.Windows
{
    partial class InterpretesAEForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.interpreteTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.paisesComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.agregarPaisButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Intérprete:";
            // 
            // interpreteTextBox
            // 
            this.interpreteTextBox.Location = new System.Drawing.Point(122, 57);
            this.interpreteTextBox.MaxLength = 50;
            this.interpreteTextBox.Name = "interpreteTextBox";
            this.interpreteTextBox.Size = new System.Drawing.Size(421, 20);
            this.interpreteTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "País:";
            // 
            // paisesComboBox
            // 
            this.paisesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paisesComboBox.FormattingEnabled = true;
            this.paisesComboBox.Location = new System.Drawing.Point(122, 110);
            this.paisesComboBox.Name = "paisesComboBox";
            this.paisesComboBox.Size = new System.Drawing.Size(332, 21);
            this.paisesComboBox.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CancelButton
            // 
            this.CancelButton.Image = global::MusicaVirtual2020.Windows.Properties.Resources.Cancelar;
            this.CancelButton.Location = new System.Drawing.Point(449, 185);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 53);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Image = global::MusicaVirtual2020.Windows.Properties.Resources.Aceptar;
            this.OkButton.Location = new System.Drawing.Point(64, 185);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(94, 53);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "OK";
            this.OkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // agregarPaisButton
            // 
            this.agregarPaisButton.Image = global::MusicaVirtual2020.Windows.Properties.Resources.AgregarAE;
            this.agregarPaisButton.Location = new System.Drawing.Point(470, 104);
            this.agregarPaisButton.Name = "agregarPaisButton";
            this.agregarPaisButton.Size = new System.Drawing.Size(31, 30);
            this.agregarPaisButton.TabIndex = 13;
            this.agregarPaisButton.UseVisualStyleBackColor = true;
            this.agregarPaisButton.Click += new System.EventHandler(this.agregarPaisButton_Click);
            // 
            // InterpretesAEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 270);
            this.ControlBox = false;
            this.Controls.Add(this.agregarPaisButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.paisesComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.interpreteTextBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(626, 309);
            this.MinimumSize = new System.Drawing.Size(626, 309);
            this.Name = "InterpretesAEForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterpretesAEForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox interpreteTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox paisesComboBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button agregarPaisButton;
    }
}