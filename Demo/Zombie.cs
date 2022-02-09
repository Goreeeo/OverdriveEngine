namespace OverdriveEngine.Demos
{
    public class Zombie
    {
        public Sprite2D Sprite;

        public Transform Transform => Sprite.Transform;

        public Player Player;

        public Zombie(Player player)
        {
            Player = player;
        }

        public void Update()
        {
            if (Transform.Position.X < Player.Transform.Position.X)
            {
                Transform.Position.X += 6f;
            }

            if (Transform.Position.X > Player.Transform.Position.X)
            {
                Transform.Position.X -= 6f;
            }

            if (Transform.Position.Y < Player.Transform.Position.Y)
            {
                Transform.Position.Y += 6f;
            }

            if (Transform.Position.Y > Player.Transform.Position.Y)
            {
                Transform.Position.Y -= 6f;
            }
        }
    }
}
