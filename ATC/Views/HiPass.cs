using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATC
{
    public partial class HiPass : Form
    {
        Random random;
        Questions Questions;
        Ansewrs Ansewrs;

        int KindQuestion = 0;
        int Question = 1;
        string Answer;
        string[] tmpa;
        string[] tmpq;
        int countc = 0;
        int countw = 0;
        List<int> iterw;
        List<int> iterc;
        Label lab;
        ComboBox[] BDP;
        int k30 = 30;
        int step = 0;
        string FIO;
        string N_group;

        int RightAnswer = 0;
        int ErrorAnswer = 0;
        public HiPass(string FIO, string N_group)
        {
            InitializeComponent();
            this.FIO = FIO;
            this.N_group = N_group;
            iterw = new List<int>();
            iterc = new List<int>();
            for (int i = 0; i < 7; i++)
            {
                iterw.Add(i);
            }
            for (int i = 0; i < 3; i++)
            {
                iterc.Add(i);
            }
            Questions = new Questions();
            Ansewrs = new Ansewrs();
            random = new Random(DateTime.Now.Millisecond);
        }


        public void Next()
        {
            RightPanel.Controls.Clear();
            LeftPanel.Controls.Clear();
            AnswerTextBox.Clear();
            NextButton.Enabled = false;
            KindQuestion = random.Next(0, 2);
            switch (KindQuestion)
            {
                case 0:
                    {
                        if (countw > 6)
                            goto case 1;
                        CounterLabel.Text = (Question) + "/10";
                        step = random.Next(0, iterw.Count);
                        iterw.Remove(iterw[step]);
                        LabelQuestions.Text = Questions.Getquestionword(TypeATC.Hipass, step);
                        Answer = Ansewrs.Getanswerword(TypeATC.Hipass, step);
                        Labelquestion.Visible = true;
                        AnswerTextBox.Visible = true;
                        countw++;
                        break;
                    }
                case 1:
                    {
                        if (countc > 2)
                            goto case 0;
                        CounterLabel.Text = Question + "/10";
                        NextButton.Enabled = true;
                        AnswerTextBox.Visible = false;
                        Labelquestion.Visible = false;
                        step = random.Next(0, iterc.Count);
                        iterc.Remove(iterc[step]);
                        Answer = Questions.GetquestionComparison(TypeATC.Hipass, step);
                        tmpq = new string[Answer.Length * 2];
                        tmpq = Answer.Split('|');
                        LabelQuestions.Text = tmpq[0];
                        k30 = 70;
                        for (int i = 1; i < tmpq.Length; i++)
                        {
                            lab = new Label();
                            lab.Text = i + ". " + tmpq[i];
                            lab.Location = new Point(10, -60 + k30);
                            lab.MaximumSize = new Size(400, 150);
                            lab.AutoSize = true;
                            lab.ForeColor = Color.Black;
                            lab.TextAlign = ContentAlignment.MiddleLeft;
                            LeftPanel.Controls.Add(lab);
                            k30 += 70;
                        }
                        k30 = 70;
                        Answer = Ansewrs.GetanswerComparison(TypeATC.Hipass, step);
                        tmpa = new string[Answer.Length * 2];
                        tmpa = Answer.Split('^');
                        for (int i = 0; i < tmpa.Length; i++)
                        {
                            lab = new Label();
                            lab.Text = tmpa[i];
                            lab.Location = new Point(120, -60 + k30);
                            lab.AutoSize = true;
                            lab.ForeColor = Color.Black;
                            lab.TextAlign = ContentAlignment.TopLeft;
                            lab.MaximumSize = new Size(320, 150);
                            RightPanel.Controls.Add(lab);
                            k30 += 70;
                        }
                        k30 = 70;
                        BDP = new ComboBox[tmpa.Length];
                        for (int i = 0; i < tmpa.Length; i++)
                        {
                            BDP[i] = new ComboBox();
                            for (int j = 1; j <= tmpa.Length; j++)
                            {
                                BDP[i].Items.Add(j);
                            }
                            BDP[i].Width = 100;
                            BDP[i].Location = new System.Drawing.Point(10, -60 + k30);
                            BDP[i].Text = "Выберите";
                            RightPanel.Controls.Add(BDP[i]);
                            k30 += 70;
                        }
                        k30 = 70;
                        Answer = Ansewrs.GetOtvetu(TypeATC.Hipass, step);
                        tmpa = Answer.Split('^');
                        countc++;
                        break;
                    }
            }
            if (Question == 10)
            {
                NextButton.Text = "Завершить";
            }
        }
        private void Rezultat()
        {
            this.Close();
            Rezult rez = new Rezult();
            rez.Show();
            rez.FioLabel.Text = "Курсант:" + FIO;
            rez.N_groupLabel.Text = "№ учебной группы:" + N_group;
            rez.AnswerLabel.Text = RightAnswer.ToString();
            if ((RightAnswer / Question) * 100 >= 90)
                rez.mark.Text = 5.ToString();
            if ((RightAnswer / Question) * 100 >= 80 && (RightAnswer / 21) * 100 <= 90)
                rez.mark.Text = 4.ToString();
            if ((RightAnswer / Question) * 100 >= 70 && (RightAnswer / 21) * 100 <= 80)
                rez.mark.Text = 3.ToString();
            else
                rez.mark.Text = 2.ToString();
        }
        private void Cast()
        {
            int count = 0;
            try
            {
                if (KindQuestion == 0)
                {
                    if (AnswerTextBox.Text.ToLower().Replace(" ", "").Replace(",", "").Replace("-", "") == Answer)
                    {
                        AnswerRightPanel.BackColor = Color.Green;
                        RightAnswer++;
                    }
                    else
                    {
                        ErrorAnswer++;
                        AnswerRightPanel.BackColor = Color.Red;
                    }
                }
                else
                {
                    for (int i = 0; i < BDP.Length; i++)
                    {
                        if (Convert.ToString(BDP[i].SelectedItem) == tmpa[i])
                            count++;
                    }
                    if (count == Answer.Length)
                    {
                        AnswerRightPanel.BackColor = Color.Green;
                        RightAnswer++;
                    }
                    else
                    {
                        ErrorAnswer++;
                        AnswerRightPanel.BackColor = Color.Red;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите правильный ответ");
            }

        }

        private void HiPass_Load(object sender, EventArgs e)
        {
            countw++;
            step = random.Next(0, iterw.Count);
            iterw.Remove(iterw[step]);
            LabelQuestions.Text = Questions.Getquestionword(TypeATC.Hipass, step);
            Answer = Ansewrs.Getanswerword(TypeATC.Hipass, step);
            Labelquestion.Visible = true;
            AnswerTextBox.Visible = true;
            CounterLabel.Text = Question + "/10";
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Question++;
            if (Question == 11)
            {
                Cast();
                Rezultat();
                goto next;
            }
            Cast();
            Next();
        next: { }
        }

        private void StopTest_Click(object sender, EventArgs e)
        {
            Rezultat();
        }

        private void AnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AnswerTextBox.Text.Length != 0)
                NextButton.Enabled = true;
            if (AnswerTextBox.Text.Length == 0)
                NextButton.Enabled = false;
        }
    }
}
