using System;

namespace chestionar_auto
{
    public partial class Form1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int totalQuestions = 26;
        public int seconds;
        public int minutes;
        public DateTime endTime;
        List<Intrebare> intrebari = new List<Intrebare>();
        int raspunsuriCorecte = 0;
        int raspunsuriGresite = 0;
        public Form1()
        {
            InitializeComponent();
            IncarcaIntrebari(@"E:\\Mocanu Cristian Nicholas\\test intrebari.txt");
            askQuestion(questionNumber);
            totalQuestions = 26;
            lblIntrebariRamase.Text = $"Numar intrebari ramase : {totalQuestions.ToString()}";
            
            
        }



        private void btnInainte_Click(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (questionNumber >= 1 && questionNumber <= intrebari.Count)
            {
                int selected = -1;
                if (rbtVarianta1.Checked) selected = 0;
                else if (rbtVarianta2.Checked) selected = 1;
                else if (rbtVarianta3.Checked) selected = 2;

                var intrebare = intrebari[questionNumber - 1];

                if (selected == intrebare.IndexCorect)
                {
                    raspunsuriCorecte++;
                }
                else
                {
                    
                    if(selected != -1)
                    {
                        raspunsuriGresite++;
                    }

                    
                        
                        
                    
                }

                lblCorecte.Text = $"Raspunsuri Corecte: {raspunsuriCorecte}";
                lblGresite.Text = $"Raspunsuri Gresite: {raspunsuriGresite}";

            }
            if (raspunsuriGresite >= 4)
            {
                MessageBox.Show("Ai picat examenul");
                btnInainte.Enabled = false;
                btnInapoi.Enabled = false;
            }
            questionNumber++;
            askQuestion(questionNumber);
            rbtVarianta1.Checked = false;
            rbtVarianta2.Checked = false;
            rbtVarianta3.Checked = false;
            totalQuestions = totalQuestions - 1;
            lblIntrebariRamase.Text = $"Numar intrebari ramase : {totalQuestions.ToString()}";
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
            lblIntrebariRamase.Text = $"Numar intrebari ramase : {totalQuestions.ToString()}";
        }
        private void askQuestion(int qnum)
        {
            if (qnum < 1 || qnum > intrebari.Count)
                return;

            var intrebare = intrebari[qnum - 1];

            lblIntrebare.Text = intrebare.Text;
            rbtVarianta1.Text = intrebare.Variante[0];
            rbtVarianta2.Text = intrebare.Variante[1];
            rbtVarianta3.Text = intrebare.Variante[2];
        }

        public void tmrCountdown_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = endTime - DateTime.UtcNow;
            if (remainingTime <= TimeSpan.Zero)
            {
                lblTimer.Text = "Gata!";
                tmrCountdown.Enabled = false;
            }
            else
            {
                lblTimer.Text = remainingTime.ToString(@"mm\:ss");
            }
        }
        private void IncarcaIntrebari(string path)
        {
            var linii = File.ReadAllLines(path);
            for (int i = 0; i < linii.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(linii[i]))
                    continue;
                if (i + 3 >= linii.Length)
                    break;

                string text = linii[i];
                string[] varianteOriginale = { linii[i + 1].Trim(), linii[i + 2].Trim(), linii[i + 3].Trim() };
                List<string> variante = new List<string>();
                int indexCorect = -1;

                for (int j = 0; j < 3; j++)
                {
                    string varianta = varianteOriginale[j];
                    if (varianta.StartsWith("!"))
                    {
                        varianta = varianta.Substring(1);
                        indexCorect = j;
                    }
                    variante.Add(varianta);
                }

                intrebari.Add(new Intrebare
                {
                    Text = text,
                    Variante = variante,
                    IndexCorect = indexCorect

                });

                i += 3;
            }
            Random rnd = new Random();
            intrebari = intrebari.OrderBy(q => rnd.Next()).ToList();
            intrebari = intrebari.Take(26).ToList();
        }

        
    }
}

