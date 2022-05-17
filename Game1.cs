using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogame_first_project
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D dinoTexture;
        Texture2D barbarianTexture;
        Texture2D goblinTexture;
        Texture2D giantTexture;
        Texture2D AlCaponeTexture;
        Texture2D cellTexture;


        






        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            this.Window.Title = "My First Monogame Project";
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            dinoTexture = Content.Load<Texture2D>("dino");
            barbarianTexture = Content.Load<Texture2D>("barbarian");
            goblinTexture = Content.Load<Texture2D>("Goblin");
            giantTexture = Content.Load<Texture2D>("Giant");
            AlCaponeTexture = Content.Load<Texture2D>("Al");
            cellTexture = Content.Load<Texture2D>("Cell");
            

          
            

            
            
            
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
            GraphicsDevice.Clear(Color.White);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            //_spriteBatch.Draw(dinoTexture, new Vector2(300, 30), Color.Red);
            _spriteBatch.Draw(cellTexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(barbarianTexture, new Vector2(100, 30), Color.White);
            _spriteBatch.Draw(goblinTexture, new Vector2(400, 30), Color.White);
            _spriteBatch.Draw(giantTexture, new Vector2(100, 300), Color.White);
            _spriteBatch.Draw(AlCaponeTexture, new Vector2(400, 300), Color.White);
            
            



            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
