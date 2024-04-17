namespace LenghtonAntForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            startButton = new Button();
            textBox1 = new TextBox();
            saveButton = new Button();
            saveFileDialog1 = new SaveFileDialog();
            delayBar = new TrackBar();
            delayLabel = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            sizeBar = new TrackBar();
            sizeLabel = new Label();
            ruleTextBox = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            rateBar = new TrackBar();
            rateLabel = new Label();
            limitRate = new CheckBox();
            resetButton = new Button();
            ((System.ComponentModel.ISupportInitialize)delayBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sizeBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rateBar).BeginInit();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            startButton.Location = new Point(687, 15);
            startButton.Name = "startButton";
            startButton.Size = new Size(94, 29);
            startButton.TabIndex = 1;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(556, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "step: 0";
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            saveButton.Location = new Point(687, 50);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 3;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click_1;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileName = "image.png";
            saveFileDialog1.Filter = "PNG file | *.png";
            // 
            // delayBar
            // 
            delayBar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            delayBar.LargeChange = 10;
            delayBar.Location = new Point(606, 128);
            delayBar.Maximum = 1000;
            delayBar.Name = "delayBar";
            delayBar.Size = new Size(130, 56);
            delayBar.TabIndex = 4;
            delayBar.Scroll += delayBar_Scroll;
            // 
            // delayLabel
            // 
            delayLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            delayLabel.AutoSize = true;
            delayLabel.Location = new Point(619, 105);
            delayLabel.Name = "delayLabel";
            delayLabel.Size = new Size(85, 20);
            delayLabel.TabIndex = 5;
            delayLabel.Text = "Delay: 0 ms";
            delayLabel.Click += delayLabel_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 529);
            panel1.TabIndex = 6;
            // 
            // sizeBar
            // 
            sizeBar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sizeBar.Location = new Point(606, 190);
            sizeBar.Minimum = 1;
            sizeBar.Name = "sizeBar";
            sizeBar.Size = new Size(130, 56);
            sizeBar.TabIndex = 7;
            sizeBar.Value = 1;
            sizeBar.Scroll += sizeBar_Scroll;
            // 
            // sizeLabel
            // 
            sizeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new Point(619, 167);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new Size(51, 20);
            sizeLabel.TabIndex = 8;
            sizeLabel.Text = "Size: 1";
            // 
            // ruleTextBox
            // 
            ruleTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ruleTextBox.Location = new Point(556, 15);
            ruleTextBox.Name = "ruleTextBox";
            ruleTextBox.Size = new Size(125, 27);
            ruleTextBox.TabIndex = 9;
            ruleTextBox.Text = "RL";
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // rateBar
            // 
            rateBar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rateBar.Location = new Point(606, 252);
            rateBar.Maximum = 1000;
            rateBar.Minimum = 1;
            rateBar.Name = "rateBar";
            rateBar.Size = new Size(130, 56);
            rateBar.TabIndex = 10;
            rateBar.Value = 1;
            rateBar.Scroll += rateBar_Scroll;
            // 
            // rateLabel
            // 
            rateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rateLabel.AutoSize = true;
            rateLabel.Location = new Point(620, 226);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new Size(54, 20);
            rateLabel.TabIndex = 11;
            rateLabel.Text = "Rate: 1";
            // 
            // limitRate
            // 
            limitRate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            limitRate.AutoSize = true;
            limitRate.Location = new Point(619, 284);
            limitRate.Name = "limitRate";
            limitRate.Size = new Size(151, 24);
            limitRate.TabIndex = 12;
            limitRate.Text = "Limit Update Rate";
            limitRate.UseVisualStyleBackColor = true;
            limitRate.CheckedChanged += limitRate_CheckedChanged;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(556, 512);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(232, 29);
            resetButton.TabIndex = 13;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(resetButton);
            Controls.Add(limitRate);
            Controls.Add(rateLabel);
            Controls.Add(rateBar);
            Controls.Add(ruleTextBox);
            Controls.Add(sizeLabel);
            Controls.Add(sizeBar);
            Controls.Add(panel1);
            Controls.Add(delayLabel);
            Controls.Add(delayBar);
            Controls.Add(saveButton);
            Controls.Add(textBox1);
            Controls.Add(startButton);
            MinimumSize = new Size(818, 497);
            Name = "Form1";
            Text = "LangthonsAnt";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)delayBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sizeBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)rateBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button startButton;
        private TextBox textBox1;
        private Button saveButton;
        private SaveFileDialog saveFileDialog1;
        private TrackBar delayBar;
        private Label delayLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TrackBar sizeBar;
        private Label sizeLabel;
        private TextBox ruleTextBox;
        private System.Windows.Forms.Timer timer1;
        private TrackBar rateBar;
        private Label rateLabel;
        private CheckBox limitRate;
        private Button resetButton;
    }
}