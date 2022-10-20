namespace GADE6122.PART._1
{
    public partial class GameView : Form
    {
      
        GameEngine gameEngine;
        public GameView()
        {
            InitializeComponent();
            gameEngine = new GameEngine(6, 8, 6, 8, 5);
            UpdateMap();
        }

        private void fillEnemyBox()
        {
           
        }

        public void UpdateMap()
        {
            string mapResult = "";
            const int padWidth = 5;
            for (int y = 0; y < gameEngine.Map.TileMapArray.GetLength(0); y++)
            {
                for (int x = 0; x < gameEngine.Map.TileMapArray.GetLength(1); x++)
                {
                    if (y == 0 || x == 0 || y == gameEngine.Map.TileMapArray.GetLength(0) - 1 || x == gameEngine.Map.TileMapArray.GetLength(1) - 1)
                    {
                        mapResult += $"{"X",padWidth}";
                    }
                    else if (gameEngine.Map.TileMapArray[y, x] == null)
                    {
                        mapResult += $"{".",padWidth}";
                    }
                    else
                    {
                        if (gameEngine.Map.TileMapArray[y, x].TileType0 == Tile.TileType.Hero)
                        {
                            mapResult += $"{"H",padWidth}";
                        }
                        else
                        {
                            mapResult += $"{"S",padWidth}";
                        }
                    }
                }
                mapResult += "\n\n";
            }
            MapLabel.Text = mapResult;
            UpdateHeroStats();
        }

        private void UpdateHeroStats()
        {
            PlayerStats_lbl.Text = gameEngine.Map.Hero0.ToString();
        }

        private void FrmGameView_Load(object sender, EventArgs e)
        {

        }



        private void FrmGameView_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("moved");

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                if (gameEngine.MovePlayer(Character.Movement.Up))
                {
                    gameEngine.Map.UpdateVision();
                }
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                if (gameEngine.MovePlayer(Character.Movement.Down))
                {
                    gameEngine.Map.UpdateVision();
                }
            }
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                if (gameEngine.MovePlayer(Character.Movement.Left))
                {
                    gameEngine.Map.UpdateVision();
                }
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                if (gameEngine.MovePlayer(Character.Movement.Right))
                {
                    gameEngine.Map.UpdateVision();
                }
            }
            UpdateMap();
        }

       

        private Button btnMoveUP;
        private Button btnMoveDown;
        private Button btnMoveRight;
        private Button btnMoveLeft;
        private Button btnAttackUp;
        private Label MapLabel;
        private Label PlayerStats_lbl;
        private Label label1;

        private void btnMoveUP_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(Character.Movement.Up);
            gameEngine.Map.UpdateVision();
            MapLabel.Text = gameEngine.ToString();
            PlayerStats_lbl.Text = gameEngine.Map.Hero0.ToString();
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(Character.Movement.Left);
            gameEngine.Map.UpdateVision();
            MapLabel.Text = gameEngine.ToString();
            PlayerStats_lbl.Text = gameEngine.Map.Hero0.ToString();
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(Character.Movement.Down);
            gameEngine.Map.UpdateVision();
            MapLabel.Text = gameEngine.ToString();
            PlayerStats_lbl.Text = gameEngine.Map.Hero0.ToString();
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(Character.Movement.Right);
            gameEngine.Map.UpdateVision();
            MapLabel.Text = gameEngine.ToString();
            PlayerStats_lbl.Text = gameEngine.Map.Hero0.ToString();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            
        }
    }
}