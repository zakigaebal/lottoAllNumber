using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int i = 0;
			int a =1;
			int b =1;
			int c =1;
			int d =1;
			int f =1;
			int g =1;
			int[] array1 = { a, b, c, d, f, g };

			for (a = 1; a <= 40; ++a)
			{
				for (b = a + 1; b <= 41; ++b)
				{
					for (c = b + 1; c <= 42; ++c)
					{
						for (d = c + 1; d <= 43; ++d)
						{
							for (f = d + 1; f <= 44; ++f)
							{
								for (g = f + 1; g <= 45; ++g)
								{
								string lotto = a.ToString() + b.ToString() + c.ToString() + d.ToString() + f.ToString() + g.ToString();
								Console.WriteLine(lotto);
								i++;
							
								}
							}
						}
					}
				} }

			Console.WriteLine(i);

		}
			}
		}
