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

		void lottoAll()
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
			Stopwatch stopwatch = new Stopwatch(); //객체 선언
			stopwatch.Start(); // 시간측정 시작
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

							


									List<LottoSerialize> ls = new List<LottoSerialize>();
									LottoSerialize lottoSerialize = new LottoSerialize() { lottoNumber = lotto };
									ls.Add(lottoSerialize);

									//텍스트파일저장하기
									fileText(lotto + "\n");

								//바이너리파일저장하기
									binaryAppendData("lot.bin", lotto + "\n");


									Console.WriteLine(lotto);
									i++;
								

								}
								

							}
						}
					}
				}
			}
			stopwatch.Stop(); //시간측정 끝
			System.Console.WriteLine("time : " +
			stopwatch.ElapsedMilliseconds + "ms");


			MessageBox.Show("시간측정 : " + stopwatch.ElapsedMilliseconds + "ms");
			//8145060
			Console.WriteLine(i);

		

		}



		private void button1_Click(object sender, EventArgs e)
		{

			lottoAll();
			///
			///텍스트파일 바이너리 두번 저장
			///텍스트로 1000을 숫자입력
			///1000번째 있는 숫자를 제거하기
			///다시 저장하기
			///텍스트박스를 하나 생성해서 문자열을 입력하는데 로또번호 10 15 20 35 38 40 입력받아서 찾아서 지우기하고 파일 새로운이름으로 저장
			///
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

		void fileText(string lottoString)
		{
			// 텍스트파일저장하기
			// 파일 경로를 지정 합니다.
			string savePath = @"c:\test.txt";
			// 입력 할 text 값
			string textValue = lottoString + "\n";
			// 기존 파일에 text 값을 추가 합니다.
			System.IO.File.AppendAllText(savePath, textValue, Encoding.Default);
		}

		private static void binaryAppendData(string filename,  string stringData)
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
	}
		}
