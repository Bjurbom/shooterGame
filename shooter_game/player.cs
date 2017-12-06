using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace shooter_game
{
    class player
    {
        Texture2D texture;
        Vector2 posistion, velocity;

        public player(Texture2D player, Vector2 posistion, Vector2 velocity)
        {
            texture = player;
            this.posistion = posistion;
            this.velocity = velocity;
        }
        public void Update()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                //up
                velocity.Y -= 1;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                //down
                velocity.Y += 1;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                //left
                velocity.X -= 1;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                //right
                velocity.X += 1;
            }

            posistion += velocity;
            velocity *= (float)0.95;
        }
        public void Draw(SpriteBatch spiriteBatch)
        {
            spiriteBatch.Draw(texture, posistion, Color.White);
        }
    }
}
