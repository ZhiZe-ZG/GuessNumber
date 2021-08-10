using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GuessNumber
{
    public class TextRender
    {
        private SpriteFont font;
        public TextRender()
        {
        }

        public void LoadContent(ContentManager content)
        {
            font = content.Load<SpriteFont>("DefaultFont");
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 pos, string text)
        {
            spriteBatch.DrawString(font, text, pos, Color.Black);
        }

    }
}