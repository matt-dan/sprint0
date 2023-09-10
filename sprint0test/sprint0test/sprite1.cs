using System;
namespace sprint0test
{
	public class sprite1 : ISprite
	{
		public Texture2D Texture{get; set;}
		public int rows { get; set; }
		public int columns { get; set; }
		public int currentFrame;
		public sprite1(Texture2D texture, int row, int column)
		{
			Texture = texture;
			rows = row;
			columns = column;
			currentFrame = 0;
		}
		public void Draw(SpriteBatch spriteBatch, Vector2 location)
		{
			int width = Texture.Width / columns;
			int height = Texture.Height / rows;
			int row = currentFrame / columns;
			int column = currentFrame%columns;

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

           spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();

        }
		public void Update() { }
    }
}

