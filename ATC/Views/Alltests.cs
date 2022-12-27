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
    public partial class Alltests : Form
    {
        Random random;
        Questions Questions;
        Ansewrs Ansewrs;

        int KindQuest = 0;
        int Question = 1;
        string Answer;
        string[] tmpa;
        string[] tmpq;

        List<int> iterw0;
        List<int> iterw1;
        List<int> iterw2;
        List<int> iterw3;

        List<int> iterc0;
        List<int> iterc1;
        List<int> iterc2;
        List<int> iterc3;

        Label lab;
        ComboBox[] BDP;
        int k30 = 30;
        int step = 0;
        string FIO;
        string N_group;

        int RightAnswer = 0;
        int ErrorAnswer = 0;
        public Alltests(string FIO, string N_group)
        {
            random = new Random();
            Questions = new Questions();
            Ansewrs = new Ansewrs();
            this.FIO = FIO;
            this.N_group = N_group;
            InitializeComponent();
            iterw0 = new List<int>();
            iterw1 = new List<int>();
            iterw2 = new List<int>();
            iterw3 = new List<int>();

            iterc0 = new List<int>();
            iterc1 = new List<int>();
            iterc2 = new List<int>();
            iterc3 = new List<int>();
            Parallel.Invoke(
                () =>
            {
                for (int i = 0; i < 16; i++)
                {
                    iterw0.Add(i);
                }
                for (int i = 0; i < 5; i++)
                {
                    iterc0.Add(i);
                }
            },
                () =>
            {
                for (int i = 0; i < 7; i++)
                {
                    iterw1.Add(i);
                }
                for (int i = 0; i < 10; i++)
                {
                    iterc1.Add(i);
                }
            },
                () =>
           {
               for (int i = 0; i < 7; i++)
               {
                   iterw2.Add(i);
               }
               for (int i = 0; i < 3; i++)
               {
                   iterc2.Add(i);
               }
           },
                () =>
           {
               for (int i = 0; i < 14; i++)
               {
                   iterw3.Add(i);
               }
               for (int i = 0; i < 5; i++)
               {
                   iterc3.Add(i);
               }
           });
        }
        private void Cast()
        {
            int count = 0;
            try
            {
                if (KindQuest == 0)
                {
                    if (AnswerTextBox.Text.ToLower().Replace(" ", "").Replace(",", "").Replace("-", "") == Answer)
                    {
                        AnswerRightPanel.BackColor = Color.Green;
                        RightAnswer++;
                    }
                    else
                    {
                        AnswerRightPanel.BackColor = Color.Red;
                        ErrorAnswer++;
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
            LeftPanel.Controls.Clear();
            RightPanel.Controls.Clear();
            AnswerTextBox.Clear();
            NextButton.Enabled = false;
            KindQuest = random.Next(0, 4);
            switch (KindQuest)
            {
                case 0:
                    {
                        if (iterw0.Count == 0 && iterc0.Count == 0)
                            goto case 1;
                        Choose(TypeATC.DX_500, iterw0, iterc0);
                        break;
                    }
                case 1:
                    {
                        if (iterw1.Count == 0 && iterc1.Count == 0)
                            goto case 2;
                        Choose(TypeATC.HiCom, iterw1, iterc1);
                        break;
                    }
                case 2:
                    {
                        if (iterw2.Count == 0 && iterc2.Count == 0)
                            goto case 3;
                        Choose(TypeATC.Hipass, iterw2, iterc2);
                        break;
                    }
                case 3:
                    {
                        if (iterw3.Count == 0 && iterc3.Count == 0)
                            goto case 1;
                        Choose(TypeATC.T_76, iterw3, iterc3);
                        break;
                    }
            }

            if (Question == 50)
            {
                NextButton.Text = "Завершить";
            }
        }

        private void Choose(TypeATC type, List<int> iterw, List<int> iterc)
        {
            KindQuest = random.Next(0, 2);
            switch (KindQuest)
            {
                case 0:
                    {
                        if (iterw.Count == 0)
                            goto case 1;
                        CounterLabel.Text = (Question) + "/50";
                        step = random.Next(0, iterw.Count);
                        iterw.Remove(iterw[step]);
                        QuestLabel.Text = Questions.Getquestionword(type, step);
                        Answer = Ansewrs.Getanswerword(type, step);
                        AnswerTextBox.Visible = true;
                        Labelquest.Visible = true;
                        break;
                    }
                case 1:
                    {
                        if (iterc.Count == 0)
                            goto case 0;
                        CounterLabel.Text = (Question) + "/50";
                        NextButton.Enabled = true;
                        AnswerTextBox.Visible = false;
                        Labelquest.Visible = false;
                        step = random.Next(0, iterc.Count);
                        iterc.Remove(iterc[step]);
                        Answer = Questions.GetquestionComparison(type, step);
                        tmpq = new string[Answer.Length * 2];
                        tmpq = Answer.Split('|');
                        QuestLabel.Text = tmpq[0];
                        if (tmpq.Length == 1)
                        {
                            goto Next;
                        }
                        k30 = 70;
                        for (int i = 1; i < tmpq.Length; i++)
                        {
                            lab = new Label();
                            lab.Text = i + ". " + tmpq[i];
                            lab.Location = new Point(10, -65 + k30);
                            lab.MaximumSize = new Size(570, 150);
                            lab.AutoSize = true;
                            lab.ForeColor = Color.Black;
                            lab.TextAlign = ContentAlignment.TopLeft;
                            RightPanel.Controls.Add(lab);
                            k30 += 70;
                        }
                    Next:
                        k30 = 70;
                        Answer = Ansewrs.GetanswerComparison(type, step);
                        tmpa = new string[Answer.Length * 2];
                        tmpa = Answer.Split('^');
                        for (int i = 0; i < tmpa.Length; i++)
                        {
                            lab = new Label();
                            lab.Text = tmpa[i];
                            lab.Location = new Point(90, -65 + k30);
                            lab.AutoSize = true;
                            lab.ForeColor = Color.Black;
                            lab.TextAlign = ContentAlignment.TopLeft;
                            lab.MaximumSize = new Size(450, 150);
                            LeftPanel.Controls.Add(lab);
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
                            BDP[i].Width = 75;
                            BDP[i].Location = new Point(10, -65 + k30);
                            BDP[i].Text = "Выберите";
                            LeftPanel.Controls.Add(BDP[i]);
                            k30 += 70;
                        }
                        k30 = 70;
                        Answer = Ansewrs.GetOtvetu(type, step);
                        tmpa = Answer.Split('^');
                        break;
                    }
            }
        }
        private void AnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AnswerTextBox.Text.Length != 0)
                NextButton.Enabled = true;
            if (AnswerTextBox.Text.Length == 0)
                NextButton.Enabled = false;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Question++;
            if (Question == 51)
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

        private void Alltests_Load(object sender, EventArgs e)
        {
            step = random.Next(0, iterw0.Count);
            iterw0.Remove(iterw0[step]);
            QuestLabel.Text = Questions.Getquestionword(TypeATC.DX_500, step);
            Answer = Ansewrs.Getanswerword(TypeATC.DX_500, step);
            Labelquest.Visible = true;
            AnswerTextBox.Visible = true;
            CounterLabel.Text = (Question) + "/50";
        }
    }
}
