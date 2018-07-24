using System;

namespace TowerDefense
{
	class Game
	{
		//Main() method will run 1st when program starts
		public static void Main()
		{
			//type of object(Tower), name of object/variable(tower)
			//This creates a new variable called tower with a lowercase t that
			//is of type Tower with an uppercase T and assigns it a newly created Tower object.
			//Tower tower = new Tower();

			Map map = new Map(8, 5);
			//map.Width = 8;
			//map.Height = 5;

			try
			{
				MapLocation mapLocation = new MapLocation(20, 20, map);
			}
			catch(OutOfBoundsException ex)
			{
				Console.WriteLine(ex.Message);
			}
			catch(TowerDefenseException)
			{
				Console.WriteLine("Unhandled TowerDefenseException");
			}
			catch(Exception)
			{
				Console.WriteLine("Unhandled exception");
			}
		}
	}
}