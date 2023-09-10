using System;
namespace sprint0test
{
	public interface ISprite
	{
	
		public void Draw(SpriteBatch spriteBatch, Vector2 location);

		public void Update();

	}
}

