using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FS = System.IO.FileStream;

/// <summary>
/// 파일은 컴퓨터 저장 매체에 기록되는 데이터의 묶음입니다.
/// 디렉토리는 파일이 우치하는 주소로 파일을 담는다는 의미에서 폴더라고 부릅니다.
/// 
/// </summary>
namespace WindowsFormsApp7
{
	public partial class Form1 : Form
	{
		//랜덤함수 정의
		Random random = new Random();
		public Form1()
		{
			InitializeComponent();
		}
		void lottoFileAll()
		{
			textBox3.Text = textBox3.Text + "\r\n String Format방식: \r\n 시작시간: " + DateTime.Now.ToString("yyyyy-MM-dd HH:mm:ss.fff");
			StreamWriter sw = new StreamWriter(new FileStream("stringFormattLotto.txt", FileMode.Create));

			//0번째부터
			int i = 0;
			// 넣을 초기값
			int a = 1;
			int b = 1;
			int c = 1;
			int d = 1;
			int f = 1;
			int g = 1;
			// 6자리 배열 생성
			//int[] array1 = { a, b, c, d, f, g };

			//로또는 1~45 자연수를 가지고 있음
			//6개를 맞추는거임
			//45C6 이라는 계산식을 가지고 있음
			//(45*44*43*42*41*40)/(6*5*4*3*2*1)계산식이 45C6임
			//for문으로 123456을 가져옴 1 돌리고 2돌리고 3돌려서 마지막 40,41,42,43,44,45만 가지고 오면
			// 갯수 8145060을 가져옴

			//// 복합 형식 지정 Format 
			var stopWatch = Stopwatch.StartNew();  //객체 선언
			stopWatch.Start(); // 시간측정 시작
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
									//보간식을 쓰는게 더 빠를까?
									sw.WriteLine(lotto);
									
								}
							}
						}
					}
				}
			}
			sw.Close();
			stopWatch.Stop(); //시간측정 끝
			textBox3.Text = textBox3.Text + "\r\n 종료시간: " + DateTime.Now.ToString("yyyyy-MM-dd HH:mm:ss.fff");
			textBox3.Text = textBox3.Text + "\r\n time    : " + stopWatch.ElapsedMilliseconds / 1000d + "초";
			//보간식을 쓰는게 더 빠를까?
			// 문자열 보간 String Interpolation 
		}
		void lottoFileAll2()
		{
			textBox3.Text = textBox3.Text + "\r\n 보간법 방식: \r\n 시작시간: " + DateTime.Now.ToString("yyyyy-MM-dd HH:mm:ss.fff");

			//0번째부터
			int i = 0;
			// 넣을 초기값
			int a = 1;
			int b = 1;
			int c = 1;
			int d = 1;
			int f = 1;
			int g = 1;
			// 6자리 배열 생성
			//int[] array1 = { a, b, c, d, f, g };

			//로또는 1~45 자연수를 가지고 있음
			//6개를 맞추는거임
			//45C6 이라는 계산식을 가지고 있음
			//(45*44*43*42*41*40)/(6*5*4*3*2*1)계산식이 45C6임
			//for문으로 123456을 가져옴 1 돌리고 2돌리고 3돌려서 마지막 40,41,42,43,44,45만 가지고 오면
			// 갯수 8145060을 가져옴

			//// 복합 형식 지정 Format 
			var stopWatch = Stopwatch.StartNew();  //객체 선언
			StreamWriter sw = new StreamWriter(new FileStream("llotto.txt", FileMode.Create));

			//보간식을 쓰는게 더 빠를까?
			// 문자열 보간 String Interpolation 
			stopWatch = Stopwatch.StartNew();
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
									string lotto2 = $"{a,0:#,00}{b,0:#,00}{c,0:#,00}{d,0:#,00}{f,0:#,00}{g,0:#,00}";
									sw.WriteLine(lotto2);
									//Console.WriteLine(lotto2);
								}
							}
						}
					}
				}
			}
			sw.Close();
			stopWatch.Stop();
			textBox3.Text = textBox3.Text + "\r\n 종료시간: " + DateTime.Now.ToString("yyyyy-MM-dd HH:mm:ss.fff");
			textBox3.Text = textBox3.Text + "\r\n time    : " + stopWatch.ElapsedMilliseconds / 1000d + "초";
			//보간식이 빠른가
			//string.fromat이 빠른가
			//보간식이 더 빠르다
		}

		///
		///텍스트파일 바이너리 두번 저장
		///텍스트로 1000을 숫자입력
		///1000번째 있는 숫자를 제거하기
		///다시 저장하기
		///텍스트박스를 하나 생성해서 문자열을 입력하는데 로또번호 10 15 20 35 38 40 입력받아서 찾아서 지우기하고 파일 새로운이름으로 저장
		///


		//목적 : 가장빠르게 파일을 저장하고 원하는데이터를 찾는 방법을 알자
		// 어떻게하면 파일생성을 빠르게 생성할건가
		// 어떻게 용량을 적게 할건가
		// Writeline을 쓰는게 빠른지, format형식을 안쓰는게 빠른지
		// 1안 => 800만개내용 파일카피해서 프로그램에 나타내는방법
		//lottoAll2()메소드 만들기 새롭게 파일생성하는방법찾기 그리고 소요시간을 또 쓰기
		//lottoAll3()메소드 만들기 새롭게 파일생성하는방법찾기 그리고 소요시간을 또 쓰기
		//1000번째 찾는 로직을 계속 찾기


		// 방법 생각 4/1일
		private void button1_Click(object sender, EventArgs e)
		{
			Stopwatch stopwatch = new Stopwatch(); //객체 선언
			stopwatch.Start(); // 시간측정 시작

			lottoFileAll();
			lottoFileAll2();

			stopwatch.Stop(); //시간측정 끝
			System.Console.WriteLine("time : " + stopwatch.ElapsedMilliseconds / 1000d + "초");
			label1.Text = stopwatch.ElapsedMilliseconds.ToString(); //레이블1에 보여주기


			using (StreamReader sr = new StreamReader(new FileStream("lotto.txt", FileMode.Open)))
			{
				Console.WriteLine($"File size : {sr.BaseStream.Length} bytes");
			}
			//using (BinaryReader br = new BinaryReader(new FileStream("lotto.dat", FileMode.Open)))
			//{
			//	Console.WriteLine($"File size : {br.BaseStream.Length} bytes");
			//}
		}

		private void lottoBinaryAll()
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

			//텍스트파일저장
			//fileText(ls[2].ToString());
		}

		class LottoSerialize
		{
			public string lottoNumber;
		}


		//using을 사용하면 자원의 수명을 세부적으로 조절을 할 수 있다.
		//스트림라이터를 사용해서 쓰기
		void fileText1(string lottoString)
		{
			using (StreamWriter sw = new StreamWriter(new FileStream("lotto.txt", FileMode.Create)))
			{
				sw.WriteLine(lottoString);
			}
		}
		//바이너리파일 사용하기
		//바이너리라이터는 스트림에 이진 데이터를 기록하기 위한 목적으로 쓴다
		void fileText2(string lottoString)
		{
			using (BinaryWriter bw = new BinaryWriter(new FileStream("lotto.dat", FileMode.Create)))
			{
				bw.Write(lottoString);
			}
		}


		static void OnWrongPathType(string type)
		{
			Console.WriteLine($"{type} is wrong type");
			return;
		}


		private static void binaryAppendData(string filename, string stringData)
		{
			using (var fileStream = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.None))
			using (var bw = new BinaryWriter(fileStream))
			{
				bw.Write(stringData);
			}
		}

		void serialBinary(string lottoString)
		{

			Stream ws = new FileStream("a.dat", FileMode.Create);
			BinaryFormatter serializer = new BinaryFormatter();

			LottoSerialize ls = new LottoSerialize();
			ls.lottoNumber = lottoString;

			serializer.Serialize(ws, ls);
			ws.Close();

			Stream rs = new FileStream("a.dat", FileMode.Open);
			BinaryFormatter deserialize = new BinaryFormatter();

			LottoSerialize ls2;
			ls2 = (LottoSerialize)deserialize.Deserialize(rs);
			rs.Close();
			Console.WriteLine($"lotto : { ls2.lottoNumber }");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			//BinaryWriter bw = new BinaryWriter(new FileStream("a.dat", FileMode.Create));
			//bw.Write(lotto);
			//bw.Close();


		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			{
				Stopwatch stopwatch = new Stopwatch(); //객체 선언
				stopwatch.Start(); // 시간측정 시작

				lottoFileAll22();

				stopwatch.Stop(); //시간측정 끝
				System.Console.WriteLine("time : " + stopwatch.ElapsedMilliseconds + "ms"); //콘솔로그
				label1.Text = stopwatch.ElapsedMilliseconds.ToString(); //레이블1에 보여주기

				using (BinaryReader br = new BinaryReader(new FileStream("lotto.dat", FileMode.Open)))
				{
					Console.WriteLine($"File size : {br.BaseStream.Length} bytes");
				}

			}
		}

		private void lottoFileAll22()
		{
			//0번째부터
			int i = 0;
			// 넣을 초기값
			int a = 1;
			int b = 1;
			int c = 1;
			int d = 1;
			int f = 1;
			int g = 1;
			// 6자리 배열 생성
			int[] array1 = { a, b, c, d, f, g };

			//로또는 1~45 자연수를 가지고 있음
			//6개를 맞추는거임
			//45C6 이라는 계산식을 가지고 있음
			//(45*44*43*42*41*40)/(6*5*4*3*2*1)계산식이 45C6임
			//for문으로 123456을 가져옴 1 돌리고 2돌리고 3돌려서 마지막 40,41,42,43,44,45만 가지고 오면
			// 갯수 8145060을 가져옴
			//Stopwatch stopwatch = new Stopwatch(); //객체 선언
			//stopwatch.Start(); // 시간측정 시작
			int index = 0;
			for (array1[0] = 1; array1[0] <= 40; ++array1[0])
			{
				for (array1[1] = array1[0] + 1; array1[1] <= 41; ++array1[1])
				{
					for (array1[2] = array1[1] + 1; array1[2] <= 42; ++array1[2])
					{
						for (array1[3] = array1[2] + 1; array1[3] <= 43; ++array1[3])
						{
							for (array1[4] = array1[3] + 1; array1[4] <= 44; ++array1[4])
							{
								for (array1[5] = array1[4] + 1; array1[5] <= 45; ++array1[5])
								{
									string lotto = string.Format("{0:#,00}", array1[0]) + string.Format("{0:#,00}", array1[1]) + string.Format("{0:#,00}", array1[2]) + string.Format("{0:#,00}", array1[3])
											+ string.Format("{0:#,00}", array1[4]) + string.Format("{0:#,00}", array1[5]);

									index++;
									//Console.WriteLine(index);
									//텍스트파일저장하기
									fileText2(lotto);
									//Console.WriteLine(lotto);
									i++;


								}


							}
						}
					}
				}
			}
			//stopwatch.Stop(); //시간측정 끝
			//System.Console.WriteLine("time : " +
			//stopwatch.ElapsedMilliseconds + "ms");
			//MessageBox.Show("시간측정 : " + stopwatch.ElapsedMilliseconds + "ms");
			//8145060
			Console.WriteLine(i);



		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			BinaryWriter bw = new BinaryWriter(new FileStream("a.dot", FileMode.Create));
			bw.Write(int.MaxValue);
			bw.Write("Good Morning");
			bw.Write(uint.MaxValue);
			bw.Write("안녕하세요");
			bw.Write(double.MaxValue);
			bw.Close();

			BinaryWriter bw1 = new BinaryWriter(new FileStream("b.dot", FileMode.Create));
			bw1.Write(1);
			bw1.Close();

			BinaryWriter b1 = new BinaryWriter(new FileStream("b1.dot", FileMode.Create));
			b1.Write(1);
			b1.Close();

			BinaryWriter b2 = new BinaryWriter(new FileStream("b2.dot", FileMode.Create));
			b2.Write(-1);
			b2.Close();

			BinaryWriter b3 = new BinaryWriter(new FileStream("b3.dot", FileMode.Create));
			b3.Write(255);
			b3.Close();




			BinaryWriter bw2 = new BinaryWriter(new FileStream("c.dot", FileMode.Create));
			bw2.Write("Good Morning");
			bw2.Close();

			BinaryWriter bw3 = new BinaryWriter(new FileStream("d.dot", FileMode.Create));
			bw3.Write(uint.MaxValue);
			bw3.Close();

			BinaryWriter bw4 = new BinaryWriter(new FileStream("e.dot", FileMode.Create));
			bw4.Write('f');
			bw4.Close();

			BinaryWriter bw5 = new BinaryWriter(new FileStream("f.dot", FileMode.Create));
			bw5.Write("fe");
			bw5.Close();

			byte sa1 = 1;
			byte[] byte2 = new byte[] { 1, 2, 3, 4, 5, 6 };
			string string3 = "010203040506";

			BinaryWriter bw7 = new BinaryWriter(new FileStream("gg.dot", FileMode.Create));
			bw7.Write(byte2);
			bw7.Close();

			BinaryWriter bw6 = new BinaryWriter(new FileStream("g.dot", FileMode.Create));
			bw6.Write(string3);
			bw6.Close();

			fileText1(string3);

			//텍스트는 010102 아스키코드

			//바이너리는 바이트타입으로
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Stopwatch stopwatch = new Stopwatch(); //객체 선언
			stopwatch.Start(); // 시간측정 시작

			StreamWriter sw = new StreamWriter(new FileStream("lotto.txt", FileMode.Append));
			int a;
			int b;
			int c;
			int d;
			int f;
			int g;
			for (a = 1; a <= 40; a++)
			{
				for (b = a + 1; b <= 41; b++)
				{
					for (c = b + 1; c <= 42; c++)
					{
						for (d = c + 1; d <= 43; d++)
						{
							for (f = d + 1; f <= 44; f++)
							{
								for (g = f + 1; g <= 45; g++)
								{
									string lotto = $"{a,0:#,00}{b,0:#,00}{c,0:#,00}{d,0:#,00}{f,0:#,00}{g,0:#,00}";
									sw.WriteLine(lotto);
								}
							}
						}
					}
				}
			}
			sw.Close();
			stopwatch.Stop(); //시간측정 끝
			System.Console.WriteLine("time : " + stopwatch.ElapsedMilliseconds / 1000d + "초");
			label1.Text = stopwatch.ElapsedMilliseconds.ToString(); //레이블1에 보여주기

			using (StreamReader sr = new StreamReader(new FileStream("lotto.txt", FileMode.Open)))
			{
				Console.WriteLine($"File size : {sr.BaseStream.Length} bytes");
			}
			//12초
		}

		private void button7_Click(object sender, EventArgs e)
		{
			//위치찾기
		 string[] spl = textBox2.Text.Split(',');
			int[] numAni = new int[6];
			for (int i = 0; i < spl.Length; i++)
			{
				numAni[i] = int.Parse(spl[i]);
			}
			int ret1 = 0;
			int ret2;
			int ret3;
			int ret4;
			int ret5;
			int ret6;
			int a = numAni[0];
			int b = numAni[1];
			int c = numAni[2];
			int d = numAni[3];
			int f = numAni[4];
			int g = numAni[5];


			ret1 = (g - (g-f));
			//g는 40이다
			//f는 35이다
			//g-f는 5이다

			//ret1은 35번째이다.
			//35번째값은 1 2 3 4 5 40이다.

			ret2 = 40+(f - (f-d));
			//f는 35이다
			//d는 27이다
			//f-d는 8이다

			//ret2는 27번째이다

			ret3 = (d - (d-c));
			//d는 27이다
			//c는 25이다
			//d-c는 2이다

			//ret3는 25번째이다.

			ret4 = (c - (c-b));
			ret5 = (b - (b-a));


			//
			//ret2 = (f - (f - d));
			//ret3 = (d - (d - c));
			//ret4 = (c - (c - b));
			//ret5 = (b - (b - a));

			int result = ret1 * ret2;
			//

			//textBox3.Text = textBox3.Text + " " + ret1.ToString()+ " " + ret2.ToString() + " " + ret3.ToString() + " " + ret4.ToString() + " " + ret5.ToString();

		textBox4.Text = result.ToString();
	//		textBox4.Text = ret.ToString();





		}
	}
}
