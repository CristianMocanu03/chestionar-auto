using System;

namespace chestionar_auto
{
    public partial class Form1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int totalQuestions = 25;
        public int seconds;
        public int minutes;
        public DateTime endTime;
        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions= 26;
            lblIntrebariRamase.Text = totalQuestions.ToString();
          

        }



        private void btnInainte_Click(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            questionNumber++;
            askQuestion(questionNumber);
            rbtVarianta1.Checked = false;
            rbtVarianta2.Checked = false;
            rbtVarianta3.Checked = false;
            totalQuestions = totalQuestions - 1;
            lblIntrebariRamase.Text = totalQuestions.ToString();
        }

        
        private void btnInapoi_Click(object sender, EventArgs e)
        {
            var senderObject1 = (Button)sender;
            int buttonTag1 = Convert.ToInt32(senderObject1.Tag);
            questionNumber--;
            askQuestion(questionNumber);
            rbtVarianta1.Checked = false;
            rbtVarianta2.Checked = false;
            rbtVarianta3.Checked = false;
            totalQuestions = totalQuestions + 1;
            lblIntrebariRamase.Text = totalQuestions.ToString();
        }
        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:

                    lblIntrebare.Text = "Asta este prima intrebare";
                    rbtVarianta1.Text = "Asta e varianta 1";
                    rbtVarianta2.Text = "Asta e varianta 2";
                    rbtVarianta3.Text = "Asta e varianta 3";
                    break;

                case 2:

                    lblIntrebare.Text = "Asta e a2-a intrebare";
                    rbtVarianta1.Text = "Asta e varianta 11";
                    rbtVarianta2.Text = "Asta e varianta 22";
                    rbtVarianta3.Text = "Asta e varianta 33";
                    break;
              
            }
        }

        public void tmrCountdown_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = endTime - DateTime.UtcNow;
            if (remainingTime <= TimeSpan.Zero)
            {
                lblTimer.Text = "Done!";
                tmrCountdown.Enabled = false;
            }
            else
            {
                lblTimer.Text = remainingTime.ToString(@"mm\:ss");
            }
        }

    }
}

