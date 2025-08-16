using System.Windows.Forms;

namespace WindowsFormsApp2
{
        partial class Form1 : Form
    {
            /// <summary>
            /// Variable del diseñador necesaria.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Limpiar los recursos que se estén usando.
            /// </summary>
            /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
                this.tabControl1 = new System.Windows.Forms.TabControl();
                this.tabPageIMC = new System.Windows.Forms.TabPage();
                this.btnCalcularIMC = new System.Windows.Forms.Button();
                this.txtAltura = new System.Windows.Forms.TextBox();
                this.txtPeso = new System.Windows.Forms.TextBox();
                this.label2 = new System.Windows.Forms.Label();
                this.label1 = new System.Windows.Forms.Label();
                this.tabPageContador = new System.Windows.Forms.TabPage();
                this.lblContador = new System.Windows.Forms.Label();
                this.btnClic = new System.Windows.Forms.Button();
                this.tabPageConversor = new System.Windows.Forms.TabPage();
                this.btnConvertir = new System.Windows.Forms.Button();
                this.rbFtoC = new System.Windows.Forms.RadioButton();
                this.rbCtoF = new System.Windows.Forms.RadioButton();
                this.txtTemperatura = new System.Windows.Forms.TextBox();
                this.label3 = new System.Windows.Forms.Label();
                this.tabControl1.SuspendLayout();
                this.tabPageIMC.SuspendLayout();
                this.tabPageContador.SuspendLayout();
                this.tabPageConversor.SuspendLayout();
                this.SuspendLayout();
                // 
                // tabControl1
                // 
                this.tabControl1.Controls.Add(this.tabPageIMC);
                this.tabControl1.Controls.Add(this.tabPageContador);
                this.tabControl1.Controls.Add(this.tabPageConversor);
                this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
                this.tabControl1.Location = new System.Drawing.Point(0, 0);
                this.tabControl1.Name = "tabControl1";
                this.tabControl1.SelectedIndex = 0;
                this.tabControl1.Size = new System.Drawing.Size(400, 300);
                this.tabControl1.TabIndex = 0;
                // 
                // tabPageIMC
                // 
                this.tabPageIMC.Controls.Add(this.btnCalcularIMC);
                this.tabPageIMC.Controls.Add(this.txtAltura);
                this.tabPageIMC.Controls.Add(this.txtPeso);
                this.tabPageIMC.Controls.Add(this.label2);
                this.tabPageIMC.Controls.Add(this.label1);
                this.tabPageIMC.Location = new System.Drawing.Point(4, 22);
                this.tabPageIMC.Name = "tabPageIMC";
                this.tabPageIMC.Padding = new System.Windows.Forms.Padding(3);
                this.tabPageIMC.Size = new System.Drawing.Size(392, 274);
                this.tabPageIMC.TabIndex = 0;
                this.tabPageIMC.Text = "IMC";
                this.tabPageIMC.UseVisualStyleBackColor = true;
                // 
                // btnCalcularIMC
                // 
                this.btnCalcularIMC.Location = new System.Drawing.Point(130, 150);
                this.btnCalcularIMC.Name = "btnCalcularIMC";
                this.btnCalcularIMC.Size = new System.Drawing.Size(120, 30);
                this.btnCalcularIMC.TabIndex = 4;
                this.btnCalcularIMC.Text = "Calcular IMC";
                this.btnCalcularIMC.UseVisualStyleBackColor = true;
                this.btnCalcularIMC.Click += new System.EventHandler(this.btnCalcularIMC_Click);
                // 
                // txtAltura
                // 
                this.txtAltura.Location = new System.Drawing.Point(130, 100);
                this.txtAltura.Name = "txtAltura";
                this.txtAltura.Size = new System.Drawing.Size(120, 20);
                this.txtAltura.TabIndex = 3;
                // 
                // txtPeso
                // 
                this.txtPeso.Location = new System.Drawing.Point(130, 60);
                this.txtPeso.Name = "txtPeso";
                this.txtPeso.Size = new System.Drawing.Size(120, 20);
                this.txtPeso.TabIndex = 2;
                // 
                // label2
                // 
                this.label2.AutoSize = true;
                this.label2.Location = new System.Drawing.Point(60, 103);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(37, 13);
                this.label2.TabIndex = 1;
                this.label2.Text = "Altura:";
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Location = new System.Drawing.Point(60, 63);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(34, 13);
                this.label1.TabIndex = 0;
                this.label1.Text = "Peso:";
                // 
                // tabPageContador
                // 
                this.tabPageContador.Controls.Add(this.lblContador);
                this.tabPageContador.Controls.Add(this.btnClic);
                this.tabPageContador.Location = new System.Drawing.Point(4, 22);
                this.tabPageContador.Name = "tabPageContador";
                this.tabPageContador.Padding = new System.Windows.Forms.Padding(3);
                this.tabPageContador.Size = new System.Drawing.Size(392, 274);
                this.tabPageContador.TabIndex = 1;
                this.tabPageContador.Text = "Contador";
                this.tabPageContador.UseVisualStyleBackColor = true;
                // 
                // lblContador
                // 
                this.lblContador.AutoSize = true;
                this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
                this.lblContador.Location = new System.Drawing.Point(200, 100);
                this.lblContador.Name = "lblContador";
                this.lblContador.Size = new System.Drawing.Size(20, 24);
                this.lblContador.TabIndex = 1;
                this.lblContador.Text = "0";
                // 
                // btnClic
                // 
                this.btnClic.Location = new System.Drawing.Point(80, 95);
                this.btnClic.Name = "btnClic";
                this.btnClic.Size = new System.Drawing.Size(100, 35);
                this.btnClic.TabIndex = 0;
                this.btnClic.Text = "Clic";
                this.btnClic.UseVisualStyleBackColor = true;
                this.btnClic.Click += new System.EventHandler(this.btnClic_Click);
                // 
                // tabPageConversor
                // 
                this.tabPageConversor.Controls.Add(this.btnConvertir);
                this.tabPageConversor.Controls.Add(this.rbFtoC);
                this.tabPageConversor.Controls.Add(this.rbCtoF);
                this.tabPageConversor.Controls.Add(this.txtTemperatura);
                this.tabPageConversor.Controls.Add(this.label3);
                this.tabPageConversor.Location = new System.Drawing.Point(4, 22);
                this.tabPageConversor.Name = "tabPageConversor";
                this.tabPageConversor.Padding = new System.Windows.Forms.Padding(3);
                this.tabPageConversor.Size = new System.Drawing.Size(392, 274);
                this.tabPageConversor.TabIndex = 2;
                this.tabPageConversor.Text = "Conversor";
                this.tabPageConversor.UseVisualStyleBackColor = true;
                // 
                // btnConvertir
                // 
                this.btnConvertir.Location = new System.Drawing.Point(130, 150);
                this.btnConvertir.Name = "btnConvertir";
                this.btnConvertir.Size = new System.Drawing.Size(120, 30);
                this.btnConvertir.TabIndex = 4;
                this.btnConvertir.Text = "Convertir";
                this.btnConvertir.UseVisualStyleBackColor = true;
                this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
                // 
                // rbFtoC
                // 
                this.rbFtoC.AutoSize = true;
                this.rbFtoC.Location = new System.Drawing.Point(230, 100);
                this.rbFtoC.Name = "rbFtoC";
                this.rbFtoC.Size = new System.Drawing.Size(82, 17);
                this.rbFtoC.TabIndex = 3;
                this.rbFtoC.TabStop = true;
                this.rbFtoC.Text = "F a Celsius";
                this.rbFtoC.UseVisualStyleBackColor = true;
                // 
                // rbCtoF
                // 
                this.rbCtoF.AutoSize = true;
                this.rbCtoF.Location = new System.Drawing.Point(130, 100);
                this.rbCtoF.Name = "rbCtoF";
                this.rbCtoF.Size = new System.Drawing.Size(82, 17);
                this.rbCtoF.TabIndex = 2;
                this.rbCtoF.TabStop = true;
                this.rbCtoF.Text = "C a Fahren.";
                this.rbCtoF.UseVisualStyleBackColor = true;
                // 
                // txtTemperatura
                // 
                this.txtTemperatura.Location = new System.Drawing.Point(130, 60);
                this.txtTemperatura.Name = "txtTemperatura";
                this.txtTemperatura.Size = new System.Drawing.Size(120, 20);
                this.txtTemperatura.TabIndex = 1;
                // 
                // label3
                // 
                this.label3.AutoSize = true;
                this.label3.Location = new System.Drawing.Point(40, 63);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(73, 13);
                this.label3.TabIndex = 0;
                this.label3.Text = "Temperatura:";
                // 
                // Form1
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(400, 300);
                this.Controls.Add(this.tabControl1);
                this.Name = "Form1";
                this.Text = "Ejercicios";
                this.tabControl1.ResumeLayout(false);
                this.tabPageIMC.ResumeLayout(false);
                this.tabPageIMC.PerformLayout();
                this.tabPageContador.ResumeLayout(false);
                this.tabPageContador.PerformLayout();
                this.tabPageConversor.ResumeLayout(false);
                this.tabPageConversor.PerformLayout();
                this.ResumeLayout(false);
            }

            #endregion

            private System.Windows.Forms.TabControl tabControl1;
            private System.Windows.Forms.TabPage tabPageIMC;
            private System.Windows.Forms.TabPage tabPageContador;
            private System.Windows.Forms.TabPage tabPageConversor;
            private System.Windows.Forms.Button btnCalcularIMC;
            private System.Windows.Forms.TextBox txtAltura;
            private System.Windows.Forms.TextBox txtPeso;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Label lblContador;
            private System.Windows.Forms.Button btnClic;
            private System.Windows.Forms.Button btnConvertir;
            private System.Windows.Forms.RadioButton rbFtoC;
            private System.Windows.Forms.RadioButton rbCtoF;
            private System.Windows.Forms.TextBox txtTemperatura;
            private System.Windows.Forms.Label label3;
        }
    }
