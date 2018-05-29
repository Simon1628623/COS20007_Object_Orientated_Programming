using System;
using SwinGameSDK;

namespace MyGame
{
    public class GameMain
    {
        public static void Main()
        {
			Drawing myDrawing = new Drawing ();

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
					SwinGame.FillCircle (Color.AliceBlue, 50, 50, 50);
					Shape myShape = new Shape ();
					myShape.X = SwinGame.MouseX ();
					myShape.Y = SwinGame.MouseY ();
					myDrawing.AddShape (myShape);

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
            }
        }
    }
}