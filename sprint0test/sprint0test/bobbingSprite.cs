using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
namespace sprint0test
{
    public class bobbingSprite
    {
        public Texture2D Texture { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        private int currentFrame;
        private int totalFrames;
        private Vector2 position;
        private int bobCount;

        public bobbingSprite(Texture2D texture, int rows, int columns)
        {
            Texture = texture;
            Rows = rows;
            Columns = columns;
            currentFrame = 0;
            totalFrames = Rows * Columns;
            position = new Vector2(400, 200);
            bobCount = 0;
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;

            if (bobCount < 10)
            {
                position.Y += 1;
                bobCount += 1;
            } else if (bobCount < 20)
            {
                position.Y -= 1;
                bobCount += 1;
            } else
            {
                bobCount = 0;
            }
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location, int rows, int columns)
        {
         
            int width = Texture.Width / Columns;
            int height = Texture.Height / Rows;
            int column = 0;
            int row = 0;

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

           

          spriteBatch.Begin();
            spriteBatch.Draw(Texture, position, sourceRectangle, Color.White);
           spriteBatch.End();
        }
    }
}

