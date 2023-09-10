using System;
using sprint0test;
namespace sprint0test
{
	public class MouseController : IController
	{
		public MouseController()
		{
		}
		public int Update(int gameState, MouseState mouseState)
		{
			Vector2 position = new Vector2(mouseState.X, mouseState.Y);
			if (mouseState.LeftButton == ButtonState.Pressed)
			{
				if (position.X <= 400)
				{
					if (position.Y <= 200)
					{
						return 1;
					}
					else
					{
						return 3;
					}

				}
				else
				{
					if (position.Y <= 200)
					{
						return 2;
					}
					else
					{
						return 4;
					}
				}

			}
			else if (mouseState.RightButton == ButtonState.Pressed)
			{
				return 0;
			}
			else
			{
				return gameState;
			}
        }
    }

}

