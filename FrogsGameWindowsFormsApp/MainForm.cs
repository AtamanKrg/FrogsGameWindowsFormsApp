using System;
using System.Drawing;
using System.Windows.Forms;

namespace FrogsGameWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private int startEmptyPictureBoxLocationX { get; set; }
        private int countMoves { get; set; } = 0;
        private const int minimumMoves = 24;
        public MainForm()
        {
            InitializeComponent();
            startEmptyPictureBoxLocationX = emptyPictureBox.Location.X;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            menuStrip.BackColor = Color.FromArgb(122, 50, 7);
            menuStrip.ForeColor = Color.AntiqueWhite;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            Swap((PictureBox)sender);
            CheckWinning();
        }

        private void Swap(PictureBox clickedPicture)
        {
            var distance = Math.Abs(clickedPicture.Location.X - emptyPictureBox.Location.X) / emptyPictureBox.Size.Width;

            if (distance > 2)
            {
                MessageBox.Show("Невозможный ход!");
                return;
            }

            (emptyPictureBox.Location, clickedPicture.Location) = (clickedPicture.Location, emptyPictureBox.Location);
            countMoves++;
            countMovesLabel.Text = countMoves.ToString();
        }

        private void CheckWinning()
        {
            if(Iswin())
            {
                if (countMoves == minimumMoves)
                {
                    MessageBox.Show("Поздравляю! Вы выиграли!", "Конец Игры");
                }
                else
                {
                    var result = MessageBox.Show("Вы справились не за оптимальное количество ходов. Хотите начать заново?", "Конец Игры", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    { 
                        Application.Restart();
                    }
                }
            }
        }

        private bool Iswin()
        {
            if (leftPictureBox1.Location.X > emptyPictureBox.Location.X &&
                leftPictureBox2.Location.X > emptyPictureBox.Location.X &&
                leftPictureBox3.Location.X > emptyPictureBox.Location.X &&
                leftPictureBox4.Location.X > emptyPictureBox.Location.X &&
                emptyPictureBox.Location.X == startEmptyPictureBoxLocationX)
            {
                leftPictureBox1.Enabled = false;
                leftPictureBox2.Enabled = false;
                leftPictureBox3.Enabled = false;
                leftPictureBox4.Enabled = false;

                rightPictureBox1.Enabled = false;
                rightPictureBox2.Enabled = false;
                rightPictureBox3.Enabled = false;
                rightPictureBox4.Enabled = false;

                return true;
            }
            return false;
        }

        private void RulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rulesForm = new RulesForm();
            rulesForm.ShowDialog();
        }

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
