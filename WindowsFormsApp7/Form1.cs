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
			//0번째부터
			int i = 0;
			// 넣을 초기값
			int a =1;
			int b =1;
			int c =1;
			int d =1;
			int f =1;
			int g =1;
			// 6자리 배열 생성
			int[] array1 = { a, b, c, d, f, g };

			//로또는 1~45 자연수를 가지고 있음
			//6개를 맞추는거임
			//45C6 이라는 계산식을 가지고 있음
			//(45*44*43*42*41*40)/(6*5*4*3*2*1)계산식이 45C6임
			//for문으로 123456을 가져옴 1 돌리고 2돌리고 3돌려서 마지막 40,41,42,43,44,45만 가지고 오면
			// 갯수 8145060을 가져옴
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

			//8145060
			Console.WriteLine(i);

		}
			}
		}
