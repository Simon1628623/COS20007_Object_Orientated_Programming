﻿using System;
using Color = SwinGameSDK.Color;//System.Drawing.Color;
using SwinGameSDK;

namespace MyGame
{
	public abstract class Shape
	{

		private Color _color;
		private float _x, _y;
		private bool _selected;

		public Shape ()
		{
			_color = Color.Green;
			_x = SwinGame.MouseX();
			_y = SwinGame.MouseY();

			_selected = false;
		}

		public Shape(SwinGameSDK.Color clr)
		{
			_color = clr;
			_x = SwinGame.MouseX();
			_y = SwinGame.MouseY();

		}

		public abstract void Draw ();

		public abstract bool IsAt (SwinGameSDK.Point2D pt);


		public abstract void DrawOutline ();



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

