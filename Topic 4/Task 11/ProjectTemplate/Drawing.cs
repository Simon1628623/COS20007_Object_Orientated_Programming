using System;
using System.Collections.Generic;
using SwinGameSDK;

namespace MyGame
{
	public class Drawing
	{
		private readonly List<Shape> _shapes;
		private SwinGameSDK.Color _background;

		public Drawing (): this(SwinGame.ColorWhite())
		{
			// Uses constructor initializer if not parameters entered.
		}

		public Drawing (SwinGameSDK.Color background)
		{
			//Implementation
			_shapes = new List<Shape> ();
			_background = background;
			SwinGame.GUISetBackgroundColor(_background);
		}

		public void Draw()
		{
			SwinGame.ClearScreen(_background);

			foreach(Shape s in _shapes)
			{
				s.Draw();
			}
		}


		public SwinGameSDK.Color Colour
		{
			get 
			{
				return _background;
			}
			/*set 
			{
				_background = value;
			}*/
		}


			
		public int ShapeCount
		{
			get
			{
				return _shapes.Count;
			}
		}

		public List<Shape> SelectedShapes
		{
			get
			{
				List<Shape> results = new List<Shape>();

				foreach(Shape s in _shapes)
				{
					if(s.Selected)
					{
						results.Add(s);
					}
				}

				return results;
			}
		}

		public void AddShape (Shape shape)
		{
			//_shapes.Add shape;
			_shapes.Add(shape);
		}



		public void SelectShapesAt (Point2D pt)
		{

			foreach(Shape s in _shapes)
			{
				s.Selected =(s.IsAt(pt));
			}
		} 
		/*
		public void RemoveShape (Shape shape)
		{
			_shapes.Remove (shape);
		}
*/
		public void RemoveShape (Shape shape)
		{
			_shapes.Remove (shape);
		}
	}
}

