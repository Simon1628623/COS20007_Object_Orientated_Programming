using System;
using SwinGameSDK;

namespace MyGame
{
    public class GameMain
    {
		private enum ShapeKind
		{
			Rectangle,
			Circle,
			Line
		}

		public static void Main()
        {
			Drawing myDrawing = new Drawing ();

			ShapeKind kindToAdd = ShapeKind.Circle;

			//Open the game window
            SwinGame.OpenGraphicsWindow("GameMain", 800, 600);
            SwinGame.ShowSwinGameSplashScreen();
            
            //Run the game loop
            while(false == SwinGame.WindowCloseRequested())
            {
				//Fetch the next batch of UI interaction
				SwinGame.ProcessEvents();

				//Clear the screen and draw the framerate
				SwinGame.ClearScreen(Color.White);
				SwinGame.DrawFramerate(0,0);


				myDrawing.Draw ();

				//Draw onto the screen
				SwinGame.RefreshScreen(60);



				if(SwinGame.MouseClicked(MouseButton.LeftButton))
				{
					Shape newShape;

					if(kindToAdd == ShapeKind.Circle)
					{
						Circle newCircle = new Circle ();

						newShape = newCircle;
					}

					else if(kindToAdd == ShapeKind.Line)
					{
						Line newLine = new Line ();

						newShape = newLine;

					}


					else
					{
						Rectangle newRect = new Rectangle ();

						newShape = newRect;
					}

					myDrawing.AddShape (newShape);
				}



				if(SwinGame.KeyTyped(KeyCode.vk_SPACE))
				{
					SwinGame.GUISetBackgroundColor(SwinGame.RandomRGBColor (255));
				}

				if(SwinGame.MouseClicked(MouseButton.RightButton))
				{
					myDrawing.SelectShapesAt (SwinGame.MousePosition());
				}

				if(SwinGame.KeyDown(KeyCode.vk_DELETE))
				{
					foreach (Shape s in myDrawing.SelectedShapes)
					{
						myDrawing.RemoveShape (s);
					}
				}

				if(SwinGame.KeyDown(KeyCode.vk_r))
				{
					kindToAdd = ShapeKind.Rectangle;
				}

				if(SwinGame.KeyDown(KeyCode.vk_c))
				{
					kindToAdd = ShapeKind.Circle;
				}

				if(SwinGame.KeyDown(KeyCode.vk_l))
				{
					kindToAdd = ShapeKind.Line;
				}
            }
        }
    }
}