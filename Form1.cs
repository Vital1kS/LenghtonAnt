namespace LenghtonAntForm
{
    public partial class Form1 : Form
    {
        public int xSize = 500, ySize = 500, updateRate = 500, step = 0;
        public int delay, pixelSize;
        public int[,] field = new int[0, 0];
        Ant ant;
        List<Color> colors = new List<Color>();
        string rule = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sizeBar.Enabled = true;
            startButton.Enabled = true;
            colors = new List<Color>();
            delay = delayBar.Value;
            pixelSize = sizeBar.Value;
            pictureBox1.Width = xSize * pixelSize;
            pictureBox1.Height = ySize * pixelSize;
            panel1.HorizontalScroll.Value = panel1.HorizontalScroll.Maximum / 2;
            panel1.VerticalScroll.Value = panel1.VerticalScroll.Maximum / 2;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            g.Clear(Color.White);
            field = initArray();
            ant = new Ant(xSize / 2, ySize / 2, 0);

        }

        private int[,] initArray()
        {
            return new int[xSize, ySize];
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            rule = ruleTextBox.Text;
            generateColorList(rule);
            backgroundWorker1.RunWorkerAsync();
            sizeBar.Enabled = false;
            startButton.Enabled = false;
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Image.Save(saveFileDialog1.FileName);
        }

        private void delayBar_Scroll(object sender, EventArgs e)
        {
            delay = delayBar.Value;
            delayLabel.Text = "Delay: " + delay + " ms";
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            moveAnt(ant);
        }

        private void sizeBar_Scroll(object sender, EventArgs e)
        {
            pixelSize = sizeBar.Value;
            pictureBox1.Width = xSize * pixelSize;
            pictureBox1.Height = ySize * pixelSize;
            sizeLabel.Text = "Size: " + pixelSize;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void rateBar_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = rateBar.Value;
            rateLabel.Text = "Rate: " + rateBar.Value + " ms";
        }

        private void limitRate_CheckedChanged(object sender, EventArgs e)
        {
            if (limitRate.Checked) timer1.Enabled = true;
            else timer1.Enabled = false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            step = 0;
            Form1_Load(null, EventArgs.Empty);
            backgroundWorker1.CancelAsync();
        }
        //Ant Behavior
        void moveAnt(Ant ant)
        {
            while (!backgroundWorker1.CancellationPending)
            {
                step++;
                if (ant.XPos > 0 && ant.YPos > 0 && ant.XPos < xSize && ant.YPos < ySize)
                    getNextTurn(ant);
                else backgroundWorker1.CancelAsync();
                textBox1.Invoke((MethodInvoker)delegate
                {
                    textBox1.Text = "step: " + step;
                });
                Thread.Sleep(delay);
            }
        }

        private void getNextTurn(Ant ant)
        {
            int posNum = field[ant.XPos, ant.YPos];
            char move = rule[posNum];
            if (move == 'R')
            {
                ant.RotateRight();
            }
            else if (move == 'L')
            {
                ant.RotateLeft();
            }
            else if (move == 'B')
            {
                ant.RotateRight();
                ant.RotateRight();
            }
            field[ant.XPos, ant.YPos] = (posNum + 1) % rule.Length;
            drawPixel(ant.XPos, ant.YPos);
            ant.Move();
        }

        //Image Processing
        private void generateColorList(String rule)
        {
            List<Color> colors = new List<Color>();
            Random random = new Random();
            colors.Add(Color.White);
            for (int i = 1; i < rule.Length; i++)
            {
                colors.Add(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));
            }
            this.colors = colors;
        }
        private void drawPixel(int x, int y)
        {
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                g.FillRectangle(new SolidBrush(colors.ElementAt(field[x, y])), x * pixelSize, y * pixelSize, pixelSize, pixelSize);
                if (!limitRate.Checked)
                    pictureBox1.Invoke((MethodInvoker)delegate
                    {
                        pictureBox1.Refresh();
                    });
            }
        }

        private void delayLabel_Click(object sender, EventArgs e)
        {

        }
    }
}