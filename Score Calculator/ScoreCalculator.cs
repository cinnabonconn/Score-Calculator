using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Score_Calculator
{
    public partial class ScoreCalculator : Form
    {
        public ScoreCalculator()
        {
            InitializeComponent();
        }

        int scoreTotal = 0;
        int scoreCount = 0;
        int score = 0;

        private void btnAd_Click(object sender, EventArgs e)
        {
            score = Convert.ToInt32(this.txtScore.Text);
            scoreTotal = scoreTotal + score;
            scoreCount = scoreCount + 1;
            txtScoreTotal.Text = scoreTotal.ToString();
            txtScoreCount.Text = scoreCount.ToString();
            txtAverage.Text = (scoreTotal / scoreCount).ToString();
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            scoreTotal = 0;
            scoreCount = 0;
            score = 0;
            txtScore.Text = 0.ToString();
            txtScoreTotal.Text = 0.ToString();
            txtScoreCount.Text = 0.ToString();
            txtAverage.Text = 0.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
