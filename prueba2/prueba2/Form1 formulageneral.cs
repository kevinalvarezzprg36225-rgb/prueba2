/*
 * Creado por SharpDevelop.
 * Usuario: zavala
 * Fecha: 26/10/2026
 * Hora: 06:56 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace prueba2
{
	/// <summary>
	/// Description of Form1_formulageneral.
	/// </summary>
	public partial class Form1_formulageneral : Form
	{
		public Form1_formulageneral()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnsalirClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void BtncalcularClick(object sender, EventArgs e)
		{
			double num1, num2, num3, x1, x2,raiz;
		
			num1=Convert.ToDouble(txta.Text);
			num2=Convert.ToDouble(txtb.Text);
			num3=Convert.ToDouble(txtc.Text);
			raiz= num2*num2-4*num1*num3;
			x1=(-num2+Math.Sqrt(raiz))/(2*num1);
			x2=(-num2-Math.Sqrt(raiz))/(2*num1);
			lblx1.Text=x1.ToString();
			lblx2.Text=x2.ToString();
		}
	}
}
