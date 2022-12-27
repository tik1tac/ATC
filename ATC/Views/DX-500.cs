
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ATC
{
    public partial class DX_500 : Form
    {
        Random random;
        Questions Questions;
        Ansewrs Ansewrs;

        int N = 0;
        int Question = 1;
        string Answer;
        string[] tmpa;
        string[] tmpq;
        int count = 0;
        List<int> iterw;
        List<int> iterc;
        Label lab;
        ComboBox[] BDP;
        int k30 = 30;
        int step = 0;
        string FIO { get; set; }
        string N_group { get; set; }

        int RightAnswer = 0;
        int erroranswer = 0;
        public DX_500(string FIO, string N_group)
        {
            this.FIO = FIO;
            this.N_group = N_group;
            InitializeComponent();
            iterw = new List<int>();
            iterc = new List<int>();
            for (int i = 0; i < 16; i++)
            {
                iterw.Add(i);
            }
            for (int i = 0; i < 5; i++)
            {
                iterc.Add(i);
            }
            Questions = new Questions();
            Ansewrs = new Ansewrs();
            random = new Random(DateTime.Now.Millisecond);
        }

        private void DX_500_Load(object sender, EventArgs e)
        {
            step = random.Next(0, iterw.Count);
            iterw.Remove(iterw[step]);
            LabelQuestions.Text = Questions.Getquestionword(TypeATC.DX_500, step);
            Answer = Ansewrs.Getanswerword(TypeATC.DX_500, step);
            Labelquest.Visible = true;
            AnswerTextBox.Visible = true;
            LabelCounter.Text = (Question) + "/21";
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            Question++;
            if (Question == 22)
            {
                Cast();
                Rezultat();
                goto next;
            }
            Cast();
            Next();
        next: { }
        }

        private void Cast()
        {
            int count = 0;
            try
            {
                if (N == 0)
                {
                    if (AnswerTextBox.Text.ToLower().Replace(" ", "").Replace(",", "").Replace("-", "") == Answer)
                    {
                        AnswerRightPanel.BackColor = Color.Green;
                        RightAnswer++;
                    }

                    else
                    {
                        AnswerRightPanel.BackColor = Color.Red;
                        erroranswer++;
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
                        AnswerRightPanel.BackColor = Color.Red;
                        erroranswer++;
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите правильный ответ");
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

        public void Next()
        {
            RightPanel.Controls.Clear();
            LeftPanel.Controls.Clear();
            AnswerTextBox.Clear();
            NextButton.Enabled = false;
            N = random.Next(0, 2);
            switch (N)
            {
                case 0:
                    {
                        LabelCounter.Text = (Question) + "/21";
                        //так как разные вопросы то следует сделать разные массивы
                        step = random.Next(0, iterw.Count);
                        iterw.Remove(iterw[step]);
                        LabelQuestions.Text = Questions.Getquestionword(TypeATC.DX_500, step);
                        Answer = Ansewrs.Getanswerword(TypeATC.DX_500, step);
                        Labelquest.Visible = true;
                        AnswerTextBox.Visible = true;
                        break;
                    }
                case 1:
                    {
                        count++;
                        if (count > 5)
                            goto case 0;
                        LabelCounter.Text = (Question) + "/21";
                        NextButton.Enabled = true;
                        AnswerTextBox.Visible = false;
                        Labelquest.Visible = false;
                        step = random.Next(0, iterc.Count);
                        iterc.Remove(iterc[step]);
                        Answer = Questions.GetquestionComparison(TypeATC.DX_500, step);
                        tmpq = new string[Answer.Length * 2];
                        tmpq = Answer.Split('|');
                        LabelQuestions.Text = tmpq[0];
                        if (tmpq.Length == 1)
                        {
                            goto Next;
                        }
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
                    Next:
                        k30 = 70;
                        Answer = Ansewrs.GetanswerComparison(TypeATC.DX_500, step);
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
                        Answer = Ansewrs.GetOtvetu(TypeATC.DX_500, step);
                        tmpa = Answer.Split('^');
                        break;
                    }
            }
            if (Question == 21)
            {
                NextButton.Text = "Завершить";
            }
        }
        private void AnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AnswerTextBox.Text.Length != 0)
                NextButton.Enabled = true;
            if (AnswerTextBox.Text.Length == 0)
                NextButton.Enabled = false;
        }

        private void StopTest_Click(object sender, EventArgs e)
        {
            Rezultat();
        }
    }
}
