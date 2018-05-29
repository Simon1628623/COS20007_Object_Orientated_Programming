using System;
using Color = SwinGameSDK.Color;//System.Drawing.Color;

namespace MyGame
{
	public class Shape
	{

		private Color _color;
		private float _x, _y;
		private int _width, _height;
		private bool _selected;

		public Shape ()
		{
			_color = Color.Green;
			_x = 0;
			_y = 0;
			_width = 100;
			_height = 100;
			_selected = false;
		}

		public Shape(SwinGameSDK.Color clr, float x, float y, int width, int height)
		{
			_color = clr;
			_x = x;
			_y = y;
			_width = width;
			_height = height;
		}

		public void Draw()
		{
			SwinGameSDK.SwinGame.FillRectangle (_color, _x, _y, _width, _height);

			if(Selected)
			{
				DrawOutline ();
			}
		}

		public bool IsAt(SwinGameSDK.Point2D pt)
		{
			return SwinGameSDK.SwinGame.PointInRect (pt, _x, _y, (float)_width, (float)_height);
		}

		public void DrawOutline()
		{
			SwinGameSDK.SwinGame.DrawRectangle (_color, _x - 2, _y - 2, _width + 4, _height + 4);
		}


		public float X
		{
			get
			{
				return _x;
			}
			set
			{
				_x = value;
			}
		}

		public float Y
		{
			get
			{
				return _y;
			}
			set
			{
				_y = value;
			}
		}

		public Color Color
		{
			get
			{
				return _color;
			}
			set
			{
				_color = value;
			}
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

		public bool Selected
		{
			get
			{
				return _selected;
			}
			set
			{
				_selected = value;
			}
		}
	}
}

