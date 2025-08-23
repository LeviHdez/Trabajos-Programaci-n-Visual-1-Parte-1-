namespace WindowsFormsApp3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Control principal
        private System.Windows.Forms.TextBox txtDisplay;

        /// <summary>
        /// Limpiar los recursos que se estén usando
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(420, 50);
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Calculadora Científica";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
