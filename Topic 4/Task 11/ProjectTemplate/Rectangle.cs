using System;
using SwinGameSDK;

namespace MyGame
{
	//                     inheriting things from shape
	public class Rectangle : Shape
	{
		private int _width, _height;


		public Rectangle (Color clr, float x, float y, int width, int height) : base(clr)
		{
			Color = clr;
			X = x;
			Y = y;
			Width = width;
			Height = height;
		}

		public Rectangle ()
		{
			Color = Color.Green;
			//X = 0;
			//Y = 0;
			Width = 100;
			Height = 100;
		}

		public int Width
		{
			get
			{
				return _width;
			}
			set
			{
				_width = value;
			}
		}

		public int Height
		{
			get
			{
				return _height;
			}
			set
			{
				_height = value;
			}
		}

		public override bool IsAt(SwinGameSDK.Point2D pt)
		{
			return SwinGameSDK.SwinGame.PointInRect (pt, X, Y, (float)_width, (float)_height);
		}

		public override void Draw()
		{
			SwinGameSDK.SwinGame.FillRectangle (Color, X, Y, _width, _height);

			if(Selected)
			{
				DrawOutline ();
			}
		}

		public override void DrawOutline()
		{
			SwinGameSDK.SwinGame.DrawRectangle (Color, X - 2, Y - 2, _width + 4, _height + 4);
		}
	}
}

