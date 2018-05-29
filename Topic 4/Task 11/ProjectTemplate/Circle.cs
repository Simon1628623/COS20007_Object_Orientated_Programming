using System;
using SwinGameSDK;

namespace MyGame
{
	public class Circle : Shape
	{
		private int _radius;

		public Circle (int radius)
		{
			_radius = radius;
		}

		public Circle ()
		{
			_radius = 50;
		}

		public int Radius
		{
			get
			{
				return _radius;
			}
			set
			{
				_radius = value;
			}
		}

		public override void Draw()
		{
			if (Selected)
				DrawOutline ();
			SwinGame.FillCircle (Color, X, Y, _radius);
		}

		public override void DrawOutline()
		{
			SwinGame.DrawCircle (Color, X - 1, Y - 1, _radius + 2);
		}

		public override bool IsAt(SwinGameSDK.Point2D pt)
		{
			return SwinGameSDK.SwinGame.PointInCircle (pt, X, Y, (float)_radius);
		}

	}
}

