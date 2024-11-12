using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_topic_1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D dinoTexture;
        Texture2D midasTexture;
        Texture2D minecraftBackround;
        Texture2D burger;
        Texture2D boat;
        Texture2D drink;
        //Rectangle 
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            this.Window.Title = "Nates game";
           
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 600; // Sets the width of the window
            _graphics.PreferredBackBufferHeight = 600; // Sets the height of the window
            _graphics.ApplyChanges(); // Applies the new dimensions
            base.Initialize();
        }

        protected override void LoadContent() 
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            dinoTexture = Content.Load<Texture2D>("dino");
            midasTexture = Content.Load<Texture2D>("midas");
            minecraftBackround = Content.Load<Texture2D>("backround");
            burger = Content.Load<Texture2D>("burger");
            boat = Content.Load<Texture2D>("boat");
            drink = Content.Load<Texture2D>("drink");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LawnGreen);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            
            
            _spriteBatch.Draw(minecraftBackround, new Rectangle(0, 0, 600, 600), Color.White);
            
            _spriteBatch.Draw(boat, new Rectangle(0,0, 500, 600), Color.White);
            _spriteBatch.Draw(midasTexture, new Vector2(150, 300), Color.White);
            _spriteBatch.Draw(burger, new Vector2(0, 230), Color.White);
            _spriteBatch.Draw(drink, new Vector2(150, 150), Color.White);
            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
