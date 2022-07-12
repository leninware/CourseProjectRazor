using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProjectRazor.Models.Cars;
using System.IO;

namespace CourseProjectRazor.Models.CarPageModel
{
	public class CarPageModel
	{
		public string desc { get; private set; }
		public Car car { get; private set; }
		public CarPageModel(string id)
		{
			string dataPath = @"~/../wwwroot/Cars/Data/CarsData.txt";
			// ищет данные фильма по его номеру
			parseForCar(findData(id, dataPath), id);
		}
		private string findData(string id, string filePath)
		{
			StreamReader read = new StreamReader(filePath);
			string line;
			string idStr;
			while ((line = read.ReadLine()) != null)
			{
				idStr = "";
				foreach (char ch in line)
				{
					if (ch == ' ')
					{
						if (idStr == id)
						{
							read.Close();
							line = line.Substring(idStr.Length + 1);
							return line;
						}
						else break;
					}
					idStr += ch;
				}
			}
			return null;
		}
		private void parseForCar(string data, string id)
		{
			string name = "", desc = "", img = "";
			int price = 0;
			int count = 0;
			string carLine = "";
			foreach (char ch in data)
			{
				if (ch == ' ' || ch == '\n')
				{
					count++;
					switch (count)
					{
						case 0: // номер 
							id = carLine;
							break;
						case 1: // модель машины
							name = carLine.Replace('_', ' '); ;
							break;
						case 2: // цена 
							price = Convert.ToInt32(carLine);
							break;
						case 3: // описание
							desc = carLine.Replace('_', ' ');
							break;
						case 4: // название файла с изображением фильма
							img = carLine;
							break;
					}
					carLine = "";
				}
				else carLine += ch;
			}
			car = new Car(name, price, desc, img, carLine.Replace('_', ' '), id);
		}
	}
}
