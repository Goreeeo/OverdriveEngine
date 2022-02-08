using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace OverdriveEngine.Demos
{
    class DemoGame : Engine
    {
        private LevelMap Tilemap;

        private Object2D Player;

        private Vector2 lastPos = new Vector2();

        private float speed = 5f;

        private AudioPlayer music;

        public DemoGame() : base(new Vector2Int(615, 515), "Demo Game")
        {

        }

        public override void Start()
        {
            BackgroundColor = Color.Black;

            Tilemap = new LevelMap();

            Input.SetAxis("Shoot", new InputAxis(null, Keys.Space));

            music = new AudioPlayer(new Audio("Vampire", "Vampire"));
            music.PlayAudio("Vampire");

            WaitForPlayer();

            Player = Tilemap.Player;
        }

        private void WaitForPlayer()
        {
            while (Tilemap.Player == null)
            {
                Thread.Sleep(10);
            }
        }

        public override void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Player.Transform.Position.X += horizontal * speed;
            Player.Transform.Position.Y += vertical * speed;

            if (Player.IsColliding("Ground") != null)
            {
                Player.Transform.Position.X = lastPos.X;
                Player.Transform.Position.Y = lastPos.Y;
            }
            else
            {
                lastPos.X = Player.Transform.Position.X;
                lastPos.Y = Player.Transform.Position.Y;
            }
        }

        public override void EarlyUpdate()
        {

        }
    }
}
