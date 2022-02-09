namespace OverdriveEngine.Demos
{
    /// <summary>
    /// A map for the demo level..
    /// </summary>
    public class LevelMap : Tilemap
    {
        /// <summary>
        /// The map..
        /// </summary>
        /// <value></value>
        public static string[,] Map =
        {
          {"dr","lr","lr","lr","lr","lr","lr","dlr","lr","lr","lr","dlr","lr","lr","lr","lr","lr","lr","lr","lr","do","do","dr","lr","lr","lr","lr","lr","lr","lr","lr","lr","lr","lr","lr","lr","lr","lr","lr","lr","lr","lr","lr","dl"},
            {"ud","..","..","..","..","..","..","ud","..","..","..","ud","..","..","..", "4","..","..","..","..","..","..","ud","..","..","..","..","..","..","06","..","..","..","..","..","..","..","..","..","..","..","..","..","ud"},
            {"ud","..","..","..","..","..","..","ud","..","..","..","ud","..","..","..", "4","..","..","..","..","..","..","ud","..","..","..","..","..","..","06","..","..","..","..","..","..","..","..","..","..","..","..","..","ud"},
           {"ud","...","pl","..","..","..","..","ud","..","..","..","03","..","..","..", "4","..","..","..","z4","..","..","ud","..","..","..","..","..","..","06","..","..","..","..","..","..","..","z6","..","..","..","..","..","ud"},
            {"ud","..","..","..","..","..","..","ud","..","..","..","03","..","..","..","ud","..","..","..","..","..","..","05","..","..","..","..","..","..","06","..","..","..","..","..","..","..","..","..","..","..","..","..","ud"},
           {"udr","lr","lr","lr","01","01","01","ud","..","..","..","ud","..","..","..","ud","..","..","..","..","..","..","05","..","..","..","..","..","..","06","..","..","..","..","..","..","..","..","..","..","..","..","..","ud"},
            {"ud","..","..","..","..","..","..","ud","..","..","..","ud","..","..","..","ud","..","..","z4","..","..","..","ud","..","..","..","z5","..","..","06","..","..","..","..","..","..","..","z6","..","..","..","..","..","ud"},
            {"ud","..","..","z1","..","..","..","ud","..","..","..","ud","..","z3","..","ud","..","..","..","..","..","..","ud","..","..","..","..","..","..","06","..","..","..","..","..","..","..","..","..","..","..","..","..","ud"},
            {"ud","..","..","..","..","..","..","ud","..","..","..","ud","..","..","..","ud","..","..","..","z4","..","..","ud","..","..","..","..","..","..","06","..","..","..","..","..","..","..","..","..","..","bo","..","..","ud"},
            {"ud","..","..","..","..","..","..","ud","..","..","..","ud","..","..","..","ud","..","..","..","..","..","..","ud","..","..","z5","..","..","..","06","..","..","..","..","..","..","..","..","..","..","..","..","..","ud"},
            {"ud","02","02","lr","lr","lr","lr","ul","..","..","..","ud","..","..","..","ud","..","..","..","..","..","..","ud","..","..","..","..","..","..","06","..","..","..","..","..","..","..","z6","..","..","..","..","..","ud"},
          {"ud","..","..","..","..","..","..","..","..","..","..","ud","..","..","..","udr","lr","lr","lr","lr","lr","lr","udl","..","..","..","..","..","..","06","..","..","..","..","..","..","..","..","..","..","..","..","..","ud"},
            {"ud","..","..","z2","..","..","..","..","..","..","..","ud","..","z3","..","ud","..","..","..","..","..","..","ud","..","..","..","..","..","..","06","..","..","..","..","..","..","..","..","..","..","..","..","..","ud"},
            {"ud","..","..","..","..","..","..","..","..","..","..","ud","..","..","..","ud","..","..","..","..","..","..","ud","..","..","z5","..","..","..","06","..","..","..","..","..","..","..","z6","..","..","..","..","..","ud"},
            {"ud","..","..","..","..","cn","..","..","z2","..","..","ud","..","..","..","ud","..","..","..","..","..","..","ud","..","..","..","..","..","..","06","..","..","..","..","..","..","..","..","..","..","..","..","..","ud"},
            {"ud","..","..","..","cr","cr","..","..","..","..","..","ud","..","..","..","..","..","..","..","ch","..","..","ud","..","..","..","..","..","..","06","..","..","..","..","..","..","..","..","..","..","..","..","..","ud"},
            {"ud","..","..","..","cn","..","..","..","..","..","..","ud","..","..","..","..","..","..","..","..","..","..","ud","..","..","..","z5","..","..","06","..","..","..","..","..","..","..","..","..","..","..","..","..","ud"},
            {"ud","..","..","..","..","..","..","..","..","..","..","ud","..","..","..","..","..","..","..","..","..","..","ud","..","..","..","..","..","..","06","..","..","..","..","..","..","..","..","..","..","..","..","..","ud"},
          {"ur","lr","lr","lr","lr","lr","lr","lr","lr","lr","lr","ulr","lr","lr","lr","lr","lr","lr","lr","lr","lr","lr","ulr","lr","lr","lr","lr","lr","lr","lr","lr","lr","lr","lr","lr","lr","lr","lr","lr","lr","lr","lr","lr","ul"},
        };

        /// <summary>
        /// Constructs the level map..
        /// </summary>
        /// <returns></returns>
        public LevelMap() : base(Map,
            new Tile("ud", new Sprite2D(Vector2.Zero(), new Vector2(50, 50), "Env/UD", "Wall")),
            new Tile("lr", new Sprite2D(Vector2.Zero(), new Vector2(50, 50), "Env/LR", "Wall")),
            new Tile("ur", new Sprite2D(Vector2.Zero(), new Vector2(50, 50), "Env/UR", "Wall")),
            new Tile("ul", new Sprite2D(Vector2.Zero(), new Vector2(50, 50), "Env/UL", "Wall")),
            new Tile("dr", new Sprite2D(Vector2.Zero(), new Vector2(50, 50), "Env/DR", "Wall")),
            new Tile("dl", new Sprite2D(Vector2.Zero(), new Vector2(50, 50), "Env/DL", "Wall")),
            new Tile("udr", new Sprite2D(Vector2.Zero(), new Vector2(50, 50), "Env/UDR", "Wall")),
            new Tile("dlr", new Sprite2D(Vector2.Zero(), new Vector2(50, 50), "Env/DLR", "Wall")),
            new Tile("ulr", new Sprite2D(Vector2.Zero(), new Vector2(50, 50), "Env/ULR", "Wall")),
            new Tile("udl", new Sprite2D(Vector2.Zero(), new Vector2(50, 50), "Env/UDL", "Wall")),
            new Tile("cn", new Sprite2D(Vector2.Zero(), new Vector2(50, 50), "Env/Crate", "Wall")),
            new Tile("cr", new Sprite2D(Vector2.Zero(), new Vector2(50, 50), "Env/CrateRotated", "Wall")),
            new Tile("pl", new Sprite2D(Vector2.Zero(), new Vector2(50, 50), "Player/Pistol_Right", "Player"), true),
            new Tile("z1", new Sprite2D(Vector2.Zero(), new Vector2(50, 50), "Zombie/Stand_Right", "Zombie1")),
            new Tile("z2", new Sprite2D(Vector2.Zero(), new Vector2(50, 50), "Zombie/Stand_Right", "Zombie2")),
            new Tile("z3", new Sprite2D(Vector2.Zero(), new Vector2(50, 50), "Zombie/Stand_Right", "Zombie3")),
            new Tile("z4", new Sprite2D(Vector2.Zero(), new Vector2(50, 50), "Zombie/Stand_Right", "Zombie4")),
            new Tile("z5", new Sprite2D(Vector2.Zero(), new Vector2(50, 50), "Zombie/Stand_Right", "Zombie5")),
            new Tile("z6", new Sprite2D(Vector2.Zero(), new Vector2(50, 50), "Zombie/Stand_Right", "Zombie6")),
            new Tile("bo", new Sprite2D(Vector2.Zero(), new Vector2(50, 50), "Boss/Stand_Right", "Boss")),
            new Tile("tr", new Sprite2D(Vector2.Zero(), new Vector2(50, 50), "Env/Crate", "Chest")),
            new Tile("do", new Sprite2D(Vector2.Zero(), new Vector2(50, 50), "Env/Door", "Door")),
            new Tile("01", new Shape2D(Vector2.Zero(), new Vector2(50, 50), "Trigger1", ShapeColor: System.Drawing.Color.Transparent)),
            new Tile("02", new Shape2D(Vector2.Zero(), new Vector2(50, 50), "Trigger2", ShapeColor: System.Drawing.Color.Transparent)),
            new Tile("03", new Shape2D(Vector2.Zero(), new Vector2(50, 50), "Trigger3", ShapeColor: System.Drawing.Color.Transparent)),
            new Tile("04", new Shape2D(Vector2.Zero(), new Vector2(50, 50), "Trigger4", ShapeColor: System.Drawing.Color.Transparent)),
            new Tile("05", new Shape2D(Vector2.Zero(), new Vector2(50, 50), "Trigger5", ShapeColor: System.Drawing.Color.Transparent))
        )
        {

        }
    }
}
