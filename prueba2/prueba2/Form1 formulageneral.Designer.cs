/*
 * Creado por SharpDevelop.
 * Usuario: zavala
 * Fecha: 26/10/2026
 * Hora: 06:56 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace prueba2
{
	partial class Form1_formulageneral
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnsalir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txta = new System.Windows.Forms.TextBox();
			this.txtb = new System.Windows.Forms.TextBox();
			this.txtc = new System.Windows.Forms.TextBox();
			this.btncalcular = new System.Windows.Forms.Button();
			this.lblx1 = new System.Windows.Forms.Label();
			this.lblx2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnsalir
			// 
			this.btnsalir.Location = new System.Drawing.Point(204, 418);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(75, 112);
			this.btnsalir.TabIndex = 0;
			this.btnsalir.Text = "Salir";
			this.btnsalir.UseVisualStyleBackColor = true;
			this.btnsalir.Click += new System.EventHandler(this.BtnsalirClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(43, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "valor a";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(43, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "valor b";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(43, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "valor c";
			// 
			// txta
			// 
			this.txta.Location = new System.Drawing.Point(176, 44);
			this.txta.Name = "txta";
			this.txta.Size = new System.Drawing.Size(208, 22);
			this.txta.TabIndex = 4;
			// 
			// txtb
			// 
			this.txtb.Location = new System.Drawing.Point(176, 98);
			this.txtb.Name = "txtb";
			this.txtb.Size = new System.Drawing.Size(208, 22);
			this.txtb.TabIndex = 5;
			// 
			// txtc
			// 
			this.txtc.Location = new System.Drawing.Point(176, 152);
			this.txtc.Name = "txtc";
			this.txtc.Size = new System.Drawing.Size(208, 22);
			this.txtc.TabIndex = 6;
			// 
			// btncalcular
			// 
			this.btncalcular.Location = new System.Drawing.Point(28, 424);
			this.btncalcular.Name = "btncalcular";
			this.btncalcular.Size = new System.Drawing.Size(115, 100);
			this.btncalcular.TabIndex = 7;
			this.btncalcular.Text = "Calcular";
			this.btncalcular.UseVisualStyleBackColor = true;
			this.btncalcular.Click += new System.EventHandler(this.BtncalcularClick);
			// 
			// lblx1
			// 
			this.lblx1.Location = new System.Drawing.Point(28, 219);
			this.lblx1.Name = "lblx1";
			this.lblx1.Size = new System.Drawing.Size(383, 52);
			this.lblx1.TabIndex = 8;
			// 
			// lblx2
			// 
			this.lblx2.Location = new System.Drawing.Point(28, 299);
			this.lblx2.Name = "lblx2";
			this.lblx2.Size = new System.Drawing.Size(398, 55);
			this.lblx2.TabIndex = 9;
			// 
			// Form1_formulageneral
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(511, 565);
			this.Controls.Add(this.lblx2);
			this.Controls.Add(this.lblx1);
			this.Controls.Add(this.btncalcular);
			this.Controls.Add(this.txtc);
			this.Controls.Add(this.txtb);
			this.Controls.Add(this.txta);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnsalir);
			this.Name = "Form1_formulageneral";
			this.Text = "Form1_formulageneral";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblx2;
		private System.Windows.Forms.Label lblx1;
		private System.Windows.Forms.Button btncalcular;
		private System.Windows.Forms.TextBox txtc;
		private System.Windows.Forms.TextBox txtb;
		private System.Windows.Forms.TextBox txta;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnsalir;
	}
}
