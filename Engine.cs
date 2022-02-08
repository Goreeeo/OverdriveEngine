using OverdriveEngine.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace OverdriveEngine
{
    class Canvas : Form
    {
        public Canvas()
        {
            DoubleBuffered = true;
        }
    }

    /// <summary>
    /// The Engine itself, games need to inherit from this.
    /// </summary>
    public abstract class Engine
    {
        #region VARS

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_HIDE = 0;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOW = 5;

        private Vector2Int ScreenSize = new Vector2Int(512, 512);
        private string Title = "Game";
        private Canvas Window = null;

        private Thread GameLoopThread = null;

        /// <summary>
        /// Handles all things related to Input.
        /// </summary>
        public static InputManager Input = null;
        /// <summary>
        /// Handles all things related to Physics.
        /// </summary>
        public static PhysicsManager Physics = null;

        private List<Bitmap> AllBitmaps = new List<Bitmap>();

        /// <summary>
        /// The Background Color of the window.
        /// </summary>
        public Color BackgroundColor = Color.White;

        /// <summary>
        /// The position of the camera.
        /// </summary>
        public Vector2 CameraPosition = Vector2.Zero();
        /// <summary>
        /// The angle of the camera.
        /// </summary>
        public float CameraAngle = 0f;
        /// <summary>
        /// The zoom of the camera.
        /// </summary>
        public Vector2 CameraZoom = Vector2.One();

        #endregion

        #region CORE

        /// <summary>
        /// Starts the engine up.
        /// </summary>
        /// <param name="ScreenSize"></param>
        /// <param name="Title"></param>
        public Engine(Vector2Int ScreenSize, string Title)
        {
            IntPtr handle = GetConsoleWindow();

#if DEBUG
            ShowWindow(handle, SW_SHOW);
#else
            if (EngineCore.DebugMode)
            {
                ShowWindow(handle, SW_SHOWMINIMIZED);
            }
            else
            {
                ShowWindow(handle, SW_HIDE);
            }
#endif

            Log.Info("Game is starting...");

            this.ScreenSize = ScreenSize;
            this.Title = Title;

            Input = new InputManager();
            Physics = new PhysicsManager();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Window = new Canvas();
            Window.Size = new Size(this.ScreenSize.X, this.ScreenSize.Y);
            Window.Text = this.Title;
            Window.Paint += Renderer;
            Window.KeyDown += Input.AnyKeyDown;
            Window.KeyUp += Input.AnyKeyUp;
            Window.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Window.FormClosing += Window_FormClosing;

            GameLoopThread = new Thread(GameLoop);
            GameLoopThread.Start();

            Application.Run(Window);
        }

        private void Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            GameLoopThread.Abort();
        }

        private void GameLoop()
        {
            bool WindowFound = true;

            Start();
            while (GameLoopThread.IsAlive)
            {
                try
                {
                    EarlyUpdate();
                    Window.BeginInvoke((MethodInvoker)delegate { Window.Refresh(); });
                    if (WindowFound == false)
                    {
                        Log.Info("Game has been found again.");
                    }
                    WindowFound = true;
                    Input.Update();
                    Update();
                    Thread.Sleep(2);
                }
                catch
                {
                    if (WindowFound)
                    {
                        Log.Error("Game has not been found...");
                    }
                    WindowFound = false;
                }
            }
        }

        private void Renderer(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.Clear(BackgroundColor);

            g.TranslateTransform(CameraPosition.X, CameraPosition.Y);

            g.RotateTransform(CameraAngle);

            g.ScaleTransform(CameraZoom.X, CameraZoom.Y);

            try
            {
                foreach (Object2D obj in EngineCore.AllObjects)
                {
                    if (obj is Shape2D)
                    {
                        Shape2D shape = (Shape2D)obj;
                        g.FillRectangle(new SolidBrush(shape.ShapeColor), shape.Transform.Position.X, shape.Transform.Position.Y, shape.Transform.Scale.X, shape.Transform.Scale.Y);
                    }

                    if (obj is Sprite2D)
                    {
                        Sprite2D sprite = (Sprite2D)obj;

                        if (AllBitmaps.Contains(sprite.Sprite))
                        {
                            g.DrawImage(AllBitmaps.Find(x => sprite.Sprite == x), sprite.Transform.Position.X, sprite.Transform.Position.Y, sprite.Transform.Scale.X, sprite.Transform.Scale.Y);
                        }
                        else
                        {
                            g.DrawImage(sprite.Sprite, sprite.Transform.Position.X, sprite.Transform.Position.Y, sprite.Transform.Scale.X, sprite.Transform.Scale.Y);
                            AllBitmaps.Add(sprite.Sprite);
                        }
                    }

                    if (obj is Text2D)
                    {
                        Text2D text = (Text2D)obj;
                        g.DrawString(text.Text, text.Font, text.Brush, text.Transform.Position.X, text.Transform.Position.Y);
                    }
                }
            }
            catch
            {

            }
        }

        #endregion

        #region BUILTINS

        #endregion

        #region OVERRIDES

        /// <summary>
        /// Executes the first time the game loads.
        /// </summary>
        public abstract void Start();

        /// <summary>
        /// Executes every frame.
        /// </summary>
        public abstract void Update();

        /// <summary>
        /// Executes before the window updates.
        /// </summary>
        public abstract void EarlyUpdate();

        #endregion
    }
}
