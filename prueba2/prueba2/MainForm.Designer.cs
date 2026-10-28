/*
 * Creado por SharpDevelop.
 * Usuario: zavala
 * Fecha: 26/10/2026
 * Hora: 07:33 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace prueba2
{
	partial class MainForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.btnsuma = new System.Windows.Forms.Button();
			this.btnresta = new System.Windows.Forms.Button();
			this.btndivi = new System.Windows.Forms.Button();
			this.btnmulti = new System.Windows.Forms.Button();
			this.btnformula = new System.Windows.Forms.Button();
			this.btnmodulo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(42, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Numero 1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(42, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Numero 2";
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(207, 32);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(180, 22);
			this.txt1.TabIndex = 2;
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(207, 84);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(180, 22);
			this.txt2.TabIndex = 3;
			// 
			// btnsuma
			// 
			this.btnsuma.Location = new System.Drawing.Point(30, 201);
			this.btnsuma.Name = "btnsuma";
			this.btnsuma.Size = new System.Drawing.Size(112, 32);
			this.btnsuma.TabIndex = 5;
			this.btnsuma.Text = "suma";
			this.btnsuma.UseVisualStyleBackColor = true;
			this.btnsuma.Click += new System.EventHandler(this.BtnsumaClick);
			// 
			// btnresta
			// 
			this.btnresta.Location = new System.Drawing.Point(207, 206);
			this.btnresta.Name = "btnresta";
			this.btnresta.Size = new System.Drawing.Size(104, 27);
			this.btnresta.TabIndex = 6;
			this.btnresta.Text = "resta";
			this.btnresta.UseVisualStyleBackColor = true;
			this.btnresta.Click += new System.EventHandler(this.BtnrestaClick);
			// 
			// btndivi
			// 
			this.btndivi.Location = new System.Drawing.Point(509, 210);
			this.btndivi.Name = "btndivi";
			this.btndivi.Size = new System.Drawing.Size(100, 23);
			this.btndivi.TabIndex = 7;
			this.btndivi.Text = "divicion";
			this.btndivi.UseVisualStyleBackColor = true;
			this.btndivi.Click += new System.EventHandler(this.BtndiviClick);
			// 
			// btnmulti
			// 
			this.btnmulti.Location = new System.Drawing.Point(352, 208);
			this.btnmulti.Name = "btnmulti";
			this.btnmulti.Size = new System.Drawing.Size(117, 25);
			this.btnmulti.TabIndex = 8;
			this.btnmulti.Text = "multiplicacion";
			this.btnmulti.UseVisualStyleBackColor = true;
			this.btnmulti.Click += new System.EventHandler(this.BtnmultiClick);
			// 
			// btnformula
			// 
			this.btnformula.Location = new System.Drawing.Point(446, 359);
			this.btnformula.Name = "btnformula";
			this.btnformula.Size = new System.Drawing.Size(153, 57);
			this.btnformula.TabIndex = 10;
			this.btnformula.Text = "formula general";
			this.btnformula.UseVisualStyleBackColor = true;
			this.btnformula.Click += new System.EventHandler(this.BtnformulaClick);
			// 
			// btnmodulo
			// 
			this.btnmodulo.Location = new System.Drawing.Point(31, 301);
			this.btnmodulo.Name = "btnmodulo";
			this.btnmodulo.Size = new System.Drawing.Size(111, 31);
			this.btnmodulo.TabIndex = 11;
			this.btnmodulo.Text = "Modulo";
			this.btnmodulo.UseVisualStyleBackColor = true;
			this.btnmodulo.Click += new System.EventHandler(this.BtnmoduloClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(630, 428);
			this.Controls.Add(this.btnmodulo);
			this.Controls.Add(this.btnformula);
			this.Controls.Add(this.btnmulti);
			this.Controls.Add(this.btndivi);
			this.Controls.Add(this.btnresta);
			this.Controls.Add(this.btnsuma);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "prueba2";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnmodulo;
		private System.Windows.Forms.Button btnformula;
		private System.Windows.Forms.Button btnmulti;
		private System.Windows.Forms.Button btndivi;
		private System.Windows.Forms.Button btnresta;
		private System.Windows.Forms.Button btnsuma;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
