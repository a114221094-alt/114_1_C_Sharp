using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowHighest_Click(object sender, EventArgs e)
        {
           string surname = txtFirstName.Text;
           string givenName = txtLastName.Text;
            int quiz1 , quiz2 , quiz3;
            if(int.TryParse(txtQuiz1.Text, out quiz1) &&
               int.TryParse(txtQuiz2.Text, out quiz2) &&
               int.TryParse(txtQuiz3.Text, out quiz3))
            {
                showrResult(surname, givenName, quiz1, quiz2, quiz3);
            }
            else
            {
                MessageBox.Show("請以整數輸入小考成績。", "輸入錯誤");
                
            }
        }

        private void showrResult(string surname, string givenName, int quiz1, int quiz2, int quiz3)
        {
            int highestScore = 0;

            highestScore = findhighestscore(quiz1, quiz2, quiz3);

            labelResult.Text = string.Format("{0}{1}，你的小考最高分是 {2} 分。", surname, givenName, highestScore);
        }

        private int findhighestscore(int quiz1, int quiz2, int quiz3)
        {
            int highestScore;
            if (quiz1 >= quiz2 && quiz1 >= quiz3)
            {
                highestScore = quiz1;
            }
            else if (quiz2 >= quiz1 && quiz2 >= quiz3)
            {
                highestScore = quiz2;
            }
            else
            {
                highestScore = quiz3;
            }
            return highestScore;
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            txtQuiz1.Clear();
            txtQuiz2.Clear();
            txtQuiz3.Clear();
            txtQuiz1.Focus();

        }
    }
}
