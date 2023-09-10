using System;
using sprint0test;

namespace sprint0test
{
    public class KeyBoardController : IController
    {
        public KeyBoardController()
        {

        }
        public int Update(int gameState, MouseState mouseState)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.D0))
            {
                return 0;
            }
            else if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.D1))
            {
                return 1;
            }
            else if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.D2))
            {
                return 2;
            }
            else if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.D3))
            {
                return 3;
            }
            else if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.D4))
            {
                return 4;
            }
            else
            {
                return gameState;
            }
        }
    }
}


