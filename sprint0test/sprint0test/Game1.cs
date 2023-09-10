using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Graphics;

namespace sprint0test;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private Texture2D johnny;
    private Texture2D mario;
    private AnimatedSprite animatedSprite;
    private movingSprite movingSprite;
    private sprite1 stillSprite;
    private Vector2 position;
    private Vector2 position2;
    private bobbingSprite bobbingSprite;
    private int bobCount;
    private int currentSprite;
    private MouseState mouse;
    private MouseController mouseControl;
    private KeyBoardController kbControl;
    private SpriteFont font;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;


    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here
        position = new Vector2(0,0);
        position2 = new Vector2(0, 0);
        bobCount = 0;
        currentSprite = 1;
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
        //Load fonts, load each sprite, load mouse and kb controllers
        font = Content.Load<SpriteFont>("File");
        Texture2D texture = Content.Load<Texture2D>("marioSpriteSheetClean");
        animatedSprite = new AnimatedSprite(texture, 1, 5);
        bobbingSprite = new bobbingSprite(texture, 1, 5);
        stillSprite = new sprite1(texture, 1, 5);
        movingSprite = new movingSprite(texture,1,5);
        mouseControl = new MouseController();
        kbControl = new KeyBoardController();
        //johnny = Content.Load<Texture2D>("IMG_5240");
        mario = Content.Load<Texture2D>("marioSpriteSheetClean");


    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here
        animatedSprite.Update();


        //position.X += 1;
        //if (position.X > this.GraphicsDevice.Viewport.Width)
        //    position.X = 0;


        //if (bobCount < 10)
        //{
        //    position2.Y += 1;
        //    bobCount += 1;
        //}
        //else if (bobCount < 20)
        //{
        //    position2.Y -= 1;
        //    bobCount += 1;
        //}
        //else
        //{
        //    bobCount = 0;
        //}

       mouse = Mouse.GetState();
       currentSprite =  kbControl.Update(currentSprite, mouse);
       currentSprite =  mouseControl.Update(currentSprite, mouse);

        if(currentSprite == 0)
        {
            Exit();
        } else if(currentSprite == 1)
        {
            //call update on fixed sprite
            stillSprite.Update();
        }
        else if (currentSprite == 2)
        {
            //update on animated
            animatedSprite.Update();
        }
        else if (currentSprite == 3)
        {
            //update on bobbing
            bobbingSprite.Update();
        }
        else if (currentSprite == 4)
        {
            //update on moving animated
            movingSprite.Update();
        }

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here
        //animatedSprite.Draw(_spriteBatch, new Vector2(0, 100));
        //bobbingSprite.Draw(_spriteBatch, new Vector2(0, 0),1,5);

        // _spriteBatch.Begin();
        // _spriteBatch.Draw(johnny, new Rectangle(200, 200, 250, 150), Color.White);
        //_spriteBatch.Draw(johnny, position, new Rectangle(200, 200, 250, 150), Color.White);
        // _spriteBatch.Draw(mario, position2, new Rectangle(400, 400, 100, 100), Color.White);
        _spriteBatch.Begin();
        _spriteBatch.DrawString(font, "Credits:Matthew Dannery \n Mario Sprite from Mario Universe", new Vector2(400, 400), Color.Black);
        _spriteBatch.End();
        if (currentSprite == 0)
        {
            Exit();
        }
        else if (currentSprite == 1)
        {
            //call update on fixed sprite
            stillSprite.Draw(_spriteBatch, new Vector2(400,200));
        }
        else if (currentSprite == 2)
        {
            //update on animated
            animatedSprite.Draw(_spriteBatch, new Vector2(400, 200));
        }
        else if (currentSprite == 3)
        {
            //update on bobbing
            bobbingSprite.Draw(_spriteBatch, new Vector2(400, 200),1,5);
        }
        else if (currentSprite == 4)
        {
            //update on moving animated
            movingSprite.Draw(_spriteBatch, new Vector2(400, 200),1,5);
        }

       // _spriteBatch.End();

        base.Draw(gameTime);
    }
}

