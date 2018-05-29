using System;
using SwinGameSDK;

namespace MyGame
{
	public class Line : Shape
	{
		private float _x2, _y2;

		public Line ()
		{
			Color = Color.Green;
			X = 0;
			Y = 0;
			_x2 = SwinGame.MouseX ();
			_y2 = SwinGame.MouseY ();

		}

		public Line(Color clr, float x, float y, float x2, float y2)
		{
			Color = clr;
			X = x;
			Y = y;
			_x2 = x2;
			_y2 = y2;
		}

		public float X2
		{
			get
			{
				return _x2;
			}
			set
			{
				_x2 = value;
			}
		}

		public float Y2
		{
			get
			{
				return _y2;
			}
			set
			{
				_y2 = value;
			}
		}


		public override void Draw()
		{
			if (Selected)
				DrawOutline ();
			SwinGame.DrawLine (Color, X, Y, _x2, _y2);
		}

		public override void DrawOutline()
		{
			SwinGame.DrawCircle (Color, X, Y, 3);
			SwinGame.DrawCircle (Color, _x2, _y2, 3);
		}

		public override bool IsAt(SwinGameSDK.Point2D pt)
		{
			return SwinGameSDK.SwinGame.PointOnLine (pt, X, Y, _x2, _y2);
		}


	}
}

