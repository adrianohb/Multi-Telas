namespace Multi_Telas
{
    partial class MenuForm
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
            this.btnBoasvindas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBoasvindas
            // 
            this.btnBoasvindas.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoasvindas.Location = new System.Drawing.Point(122, 102);
            this.btnBoasvindas.Name = "btnBoasvindas";
            this.btnBoasvindas.Size = new System.Drawing.Size(591, 212);
            this.btnBoasvindas.TabIndex = 0;
            this.btnBoasvindas.Text = "BOTÃO BOAS VINDAS";
            this.btnBoasvindas.UseVisualStyleBackColor = true;
            this.btnBoasvindas.Click += new System.EventHandler(this.btnBoasvindas_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBoasvindas);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBoasvindas;
    }
}