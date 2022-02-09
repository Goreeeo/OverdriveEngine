using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace OverdriveEngine.Demos
{
    class DemoGame : Engine
    {
        private LevelMap Tilemap;

        private Player Player;

        private AudioPlayer music;

        public bool trigger1;

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

            Player = new Player((Sprite2D)Tilemap.Player, this);
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
            Player.Update();

            if (Player.TilePlayer.IsColliding("Trigger1") != null)
            {

            }
        }

        public override void EarlyUpdate()
        {

        }
    }
}
