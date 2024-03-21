namespace PastaKuleOyunu
{
    public partial class Form1 : Form
    {
        int rightBorder;
        int leftBorder;
        Point nokta;
        List<Button> cakes = new List<Button>();
        int i = 0;
        bool isRight;
        public Form1()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            this.BackgroundImage = Resource1.arkaplan;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            platform.Location = new Point((this.Width / 2) - (platform.Width / 2), this.Height - 86);
            platform.BackColor = Color.Brown;
            leftBorder = platform.Location.X;
            rightBorder = platform.Location.X + platform.Width;
            this.AutoScroll = true;
            CreateCake();
            isRight = true;
        }

        private void CreateCake()
        {
            cakes.Add(new Button()
            {
                Enabled = false,
                Width = rightBorder - leftBorder,
                Height = 30,
                BackColor = Color.FromArgb(new Random().Next(255), new Random().Next(255), new Random().Next(255)),
                Location = new Point(platform.Location.X - 250, platform.Location.Y - (30 * (i + 1))),
                FlatStyle = FlatStyle.Popup,
            });
            nokta = cakes[i].Location;
            this.Controls.Add(cakes[i]);
            timer1.Start();

        }
        int step = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cakes[i].Location.X < 80)
            {
                isRight = true;
                step = 0;
            }
            if (cakes[i].Location.X + cakes[i].Width > this.Width - 80)
            {
                isRight = false;
                step = 0;
            }

            if (isRight)
            {

                nokta.X += 7;// todo asdasdsa
                cakes[i].Location = nokta;
            }
            else
            {
                nokta.X -= 7; //todo sadasdasda
                cakes[i].Location = nokta;
            }

        }
        int fark;
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            fark = 0;


            if (cakes[i].Location.X > rightBorder || cakes[i].Location.X + cakes[i].Width < leftBorder)
            {
                timer1.Stop();
                MessageBox.Show("Kaybettiniz");
                System.Environment.Exit(0);
            }

            if (cakes[i].Location.X < leftBorder)
            {
                fark = leftBorder - cakes[i].Location.X;
                cakes[i].Location = new Point(leftBorder, platform.Location.Y - (30 * (i + 1)));
                cakes[i].Width -= fark;
            }

            if (cakes[i].Location.X + cakes[i].Width > rightBorder)
            {
                fark = (cakes[i].Location.X + cakes[i].Width) - rightBorder;
                cakes[i].Width -= fark;
            }

            timer1.Stop();
            leftBorder = cakes[i].Location.X;
            rightBorder = cakes[i].Location.X + cakes[i].Width;
            i++;
            //if (i % 2 == 0 && i!= 0)
            //{
            //    timer1.Interval -= 1;
            //}
            label2.Text = i.ToString();
            CreateCake();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                fark = 0;


                if (cakes[i].Location.X > rightBorder || cakes[i].Location.X + cakes[i].Width < leftBorder)
                {
                    timer1.Stop();
                    MessageBox.Show("Kaybettiniz");
                    System.Environment.Exit(0);
                }

                if (cakes[i].Location.X < leftBorder)
                {
                    fark = leftBorder - cakes[i].Location.X;
                    cakes[i].Location = new Point(leftBorder, platform.Location.Y - (30 * (i + 1)));
                    cakes[i].Width -= fark;
                }

                if (cakes[i].Location.X + cakes[i].Width > rightBorder)
                {
                    fark = (cakes[i].Location.X + cakes[i].Width) - rightBorder;
                    cakes[i].Width -= fark;
                }

                timer1.Stop();
                leftBorder = cakes[i].Location.X;
                rightBorder = cakes[i].Location.X + cakes[i].Width;
                i++;
                //if (i % 2 == 0)
                //{
                //    timer1.Interval -= 2;
                //}
                label2.Text = i.ToString();
                CreateCake();
            }
        }
    }
}
