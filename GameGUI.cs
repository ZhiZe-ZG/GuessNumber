using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GuessNumber
{
    public class GameGUI : Game
    {
        private GameManager _currentGame;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private TextRender _textRender;
        private string _guessText = "";

        private string _hintText = "Welcome to Guess Number!";

        public GameGUI()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            // Text Render
            _textRender = new TextRender();
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _currentGame = new GameManager();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            _textRender.LoadContent(Content);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            if (!_currentGame.GameStop)
            {
                _currentGame.Update(Keyboard.GetState(), out _hintText, out _guessText);
            }
            else{
                if(Keyboard.GetState().IsKeyDown(Keys.Enter)){
                    _currentGame = new GameManager();
                }
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _textRender.Draw(_spriteBatch, new Vector2(0, 0), _hintText);
            _textRender.Draw(_spriteBatch, new Vector2(0, 50), _guessText);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
