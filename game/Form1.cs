namespace game
{
    public partial class Form1 : Form
    {
        private int stepV1 = 20;
        private int stepV2 = 10;
        private int stepV3 = 30;
        private int xcor, ycor;
        public void NewGame()
        {
            villain1.Top = 50;
            villain1.Left = 150;
            villain2.Top = 200;
            villain2.Left = 150;
            villain3.Top = 350;
            villain3.Left = 150;
            hero.Top = 200;
            hero.Left = 450;
            timer.Start();
            hero.Left = Cursor.Position.X;
            hero.Top = Cursor.Position.Y;
        }
        public Form1()
        {
            InitializeComponent();
            NewGame();
        }
        public void Caught(PictureBox vil)
        {
            if (hero.Left > vil.Left && hero.Left < vil.Right && hero.Top > vil.Top && hero.Top < vil.Bottom)
            {
                vil.Left = -200;
            }
        }
        private void Tick(object sender, EventArgs e)
        {
            villain1.Left += stepV1;
            villain2.Left += stepV2;
            villain3.Left += stepV3;
            if (villain1.Left > 1000 || villain2.Left > 1000 || villain3.Left > 1000) { timer.Stop(); }
            Caught(villain1);
            Caught(villain2);
            Caught(villain3);
            hero.Left = xcor;
            hero.Top = ycor;
        }
        private void MouseMove(object sender, MouseEventArgs e)
        {
            xcor = e.X;
            ycor = e.Y;
        }
    }
}