/*
 * Creado por SharpDevelop.
 * Usuario: zavala
 * Fecha: 26/10/2026
 * Hora: 07:33 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace prueba2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnsumaClick(object sender, EventArgs e)
		{
			double a, b, resultado;
			resultado=0;
			a=Convert.ToDouble(txt1.Text);
			b=Convert.ToDouble(txt2.Text);
			
			resultado= a+b;
			MessageBox.Show("el resultado es: "+ Convert.ToString(resultado));		
		}
		
		void BtnrestaClick(object sender, EventArgs e)
		{
			double a, b, resultado;
			resultado=0;
			a=Convert.ToDouble(txt1.Text);
			b=Convert.ToDouble(txt2.Text);
			
			resultado= a-b;
			MessageBox.Show("el resultado es: "+ Convert.ToString(resultado));			
		}
		
		void BtnmultiClick(object sender, EventArgs e)
		{
			double a, b, resultado;
			resultado=0;
			a=Convert.ToDouble(txt1.Text);
			b=Convert.ToDouble(txt2.Text);
			
			resultado= a*b;
			MessageBox.Show("el resultado es: "+ Convert.ToString(resultado));			
		}
		
		void BtndiviClick(object sender, EventArgs e)
		{
			double a, b, resultado;
			resultado=0;
			a=Convert.ToDouble(txt1.Text);
			b=Convert.ToDouble(txt2.Text);
			
			resultado= a/b;
			MessageBox.Show("el resultado es: "+ Convert.ToString(resultado));			
		}
	}
}
