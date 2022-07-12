using System;

namespace CourseProjectRazor.Models.Cars
{
	public class Car
	{
		public string Name { get; private set; }
		public int Price { get; private set; }
		public string Desc { get; private set; }
		public string Image { get; private set; }
		public string Tags { get; private set; }
		public string Id { get; private set; }
		public Car(string name, 
			int price, string desc, 
			string image, string tags, string id)
		{
			Name = name;
			Price = price;
			Desc = desc;
			Image = image;
			Tags = tags;
			Id = id;
		}
	}
}
