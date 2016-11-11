namespace HeloWorldUnity
{
    partial class Shell
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.HelloLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HelloLabel
            // 
            this.HelloLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloLabel.Location = new System.Drawing.Point(0, 0);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(284, 262);
            this.HelloLabel.TabIndex = 0;
            this.HelloLabel.Text = "This label shoud say hello";
            this.HelloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Shell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.HelloLabel);
            this.Name = "Shell";
            this.Text = "Shell";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HelloLabel;
    }
}

