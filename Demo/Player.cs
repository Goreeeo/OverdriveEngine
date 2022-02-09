using System.Collections.Generic;

namespace OverdriveEngine.Demos
{
    public class Player
    {
        public Sprite2D TilePlayer;

        public Transform Transform => TilePlayer.Transform;

        private Vector2 lastPos = new Vector2();

        private float speed = 5f;

        public Engine engine;

        private enum PlayerSprites
        {
            GunLeft = 0,
            GunRight = 1,
            GunUp = 2,
            GunDown = 3,
        }

        private List<Sprite2D> playerSpriteList = new List<Sprite2D>()
        {
            new Sprite2D(new Vector2(-10000, -10000), new Vector2(50, 50), "Player/Pistol_Left", "Player"),
            new Sprite2D(new Vector2(-10000, -10000), new Vector2(50, 50), "Player/Pistol_Right", "Player"),
            new Sprite2D(new Vector2(-10000, -10000), new Vector2(50, 50), "Player/Pistol_Up", "Player"),
            new Sprite2D(new Vector2(-10000, -10000), new Vector2(50, 50), "Player/Pistol_Down", "Player"),
        };

        public Player(Sprite2D sprite, Engine engine)
        {
            TilePlayer = sprite;
            this.engine = engine;
        }

        public void Update()
        {
            float horizontal = Engine.Input.GetAxis("Horizontal");
            float vertical = Engine.Input.GetAxis("Vertical");

            Transform.Position.X += horizontal * speed;
            Transform.Position.Y += vertical * speed;

            if (horizontal > 0 && horizontal > vertical)
            {
                TilePlayer.UpdateImage(playerSpriteList[(int)PlayerSprites.GunRight]);
            }
            else if (horizontal < 0 && horizontal < vertical)
            {
                TilePlayer.UpdateImage(playerSpriteList[(int)PlayerSprites.GunLeft]);
            }
            else if (vertical < 0 && vertical < horizontal)
            {
                TilePlayer.UpdateImage(playerSpriteList[(int)PlayerSprites.GunUp]);
            }
            else if (vertical > 0 && vertical > horizontal)
            {
                TilePlayer.UpdateImage(playerSpriteList[(int)PlayerSprites.GunDown]);
            }

            if (TilePlayer.IsColliding("Wall") != null)
            {
                Transform.Position.X = lastPos.X;
                Transform.Position.Y = lastPos.Y;
            }
            else
            {
                lastPos.X = Transform.Position.X;
                lastPos.Y = Transform.Position.Y;
            }

            engine.CameraPosition.X = -Transform.Position.X + engine.ScreenSize.X / 2;
            engine.CameraPosition.Y = -Transform.Position.Y + engine.ScreenSize.Y / 2;
        }

    }
}
