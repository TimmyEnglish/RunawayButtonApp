using System;
using System.Drawing;
using System.Windows.Forms;

namespace RunawayButtonApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button runawayButton = new Button
            {
                Text = "Ні",
                Location = new Point(100, 100)
            };
            runawayButton.MouseMove += new MouseEventHandler(RunawayButton_MouseMove);
            runawayButton.Click += new EventHandler(RunawayButton_Click);

            Button yesButton = new Button
            {
                Text = "Так",
                Location = new Point(100, 50)
            };
            yesButton.Click += new EventHandler(YesButton_Click);

            this.Controls.Add(runawayButton);
            this.Controls.Add(yesButton);
        }
        private void RunawayButton_MouseMove(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            Random random = new Random();
            int newX = random.Next(this.ClientSize.Width - button.Width);
            int newY = random.Next(this.ClientSize.Height - button.Height);
            button.Location = new Point(newX, newY);
        }
        private void RunawayButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Як ти це зробив?");
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правильна відповідь, дякуємо");
        }
    }
}
