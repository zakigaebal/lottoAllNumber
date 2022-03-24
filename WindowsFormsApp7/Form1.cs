using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
			Stopwatch stopwatch = new Stopwatch(); //객체 선언
			stopwatch.Start(); // 시간측정 시작
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
									string lotto = string.Format("{0:#,00}", a) + string.Format("{0:#,00}", b) + string.Format("{0:#,00}", c) + string.Format("{0:#,00}", d)
											+ string.Format("{0:#,00}", f) + string.Format("{0:#,00}", g);
								//Console.WriteLine(lotto);
								i++;
							
								}
							}
						}
					}
				} }
			stopwatch.Stop(); //시간측정 끝
			System.Console.WriteLine("time : " +
			stopwatch.ElapsedMilliseconds + "ms");

			//8145060
			Console.WriteLine(i);
			///
			///텍스트파일 바이너리 두번 저장
			///텍스트로 1000을 숫자입력
			///1000번째 있는 숫자를 제거하기
			///다시 저장하기
			///텍스트박스를 하나 생성해서 문자열을 입력하는데 로또번호 10 15 20 35 38 40 입력받아서 찾아서 지우기하고 파일 새로운이름으로 저장
			///
		}
			}
		}
