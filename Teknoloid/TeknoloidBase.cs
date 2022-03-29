using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using Teknoloid.AudioVisual;

namespace Teknoloid
{
    public class TeknoloidBase : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private GameContent _gameContent;

        

        public TeknoloidBase()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _gameContent = new GameContent(Content);

            // TODO: use this.Content to load your game content here
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
            GraphicsDevice.Clear(Color.DarkGray);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(_gameContent.LogoGraphic, new Rectangle(50, 50, 256, 256), Color.White);
            _spriteBatch.Draw(_gameContent.NoteGraphic, new Vector2(300, 300), Color.Red);
            _spriteBatch.Draw(_gameContent.NoteOverlayGraphic, new Vector2(300, 300), Color.White);
            _spriteBatch.End();


            base.Draw(gameTime);


        }
    }
}
