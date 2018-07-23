namespace TowerDefense
{
	class Map
	{
		public readonly int Width;
		public readonly int Height;

		//constructor method below:
		public Map(int width, int height)
		{
			Width = width;
			Height = height;
		}

		public bool OnMap(Point point)
		{
			bool inBounds = point.x >= 0 && point.x < width && point.y >=0 && point.y < height;
			
			return inBounds;
		}
	}
}