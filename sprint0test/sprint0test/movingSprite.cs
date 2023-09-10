using System;
using System.Threading;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
namespace sprint0test
{
    public class movingSprite
    {
        public Texture2D Texture { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        private int currentFrame;
        private int totalFrames;
        private Vector2 position;
        private int viewWidth;

        public movingSprite(Texture2D texture, int rows, int columns)
        {
            //pass viewportWidth from Game1 with this.GraphicsDevice.Viewport.Width
            Texture = texture;
            Rows = rows;
            Columns = columns;
            currentFrame = 0;
            totalFrames = Rows * Columns;
            position = new Vector2(400, 200);
            
        }
        public void Update()
        {
            currentFrame++;
            // Thread.Sleep(50);
            if (currentFrame == totalFrames)
            {
                currentFrame = 0;
            }
            //Need to update position

            position.X += 1;
            if (position.X > 800)
            {
                position.X = 0;
            }


        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location, int rows, int columns)
        {
            //int width = Texture.Width / Columns;
            //int height = Texture.Height / Rows;
            //int row = currentFrame / Columns;
            //int column = currentFrame % Columns;

            //Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            //Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            //spriteBatch.Begin();
            ////Need to draw with position
            //spriteBatch.Draw(Texture, sourceRectangle, Color.White);
            //spriteBatch.Draw(Texture, position, sourceRectangle, Color.White);
            //spriteBatch.End();
            
            int width = Texture.Width / columns;
            int height = Texture.Height / rows;
            int row = currentFrame / columns;
            int column = currentFrame % columns;

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, width, height);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            //destinationRectangle.X = (int)position.X;
            spriteBatch.End();

        }
    }
}

