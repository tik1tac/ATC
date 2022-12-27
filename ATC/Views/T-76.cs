using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ATC
{
    public partial class T_76 : Form
    {
        Random random;
        Questions Questions;
        Ansewrs Ansewrs;

        int KindQuestion = 0;
        int Question = 1;
        string answ;
        string[] tmpa;
        string[] tmpq;
        int countw = 0;
        int countc = 0;
        List<int> iterw;
        List<int> iterc;
        Label lab;
        ComboBox[] BDP;
        int k30 = 30;
        int step = 0;
        string fio;
        string N_group;
        int RightAnswer = 0;
        int ErrorAnswer = 0;
        public T_76(string fio, string N_group)
        {
            InitializeComponent();
            this.fio = fio;
            this.N_group = N_group;
            iterw = new List<int>();
            iterc = new List<int>();
            for (int i = 0; i < 14; i++)
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
        private void NextButton_Click(object sender, EventArgs e)
        {
            Question++;
            if (Question == 21)
            {
                Cast();
                Rezultat();
                goto next;
            }
            Cast();
            Next();
        next: { }
        }
        private void AnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AnswerTextBox.Text.Length != 0)
                NextButton.Enabled = true;
            if (AnswerTextBox.Text.Length == 0)
                NextButton.Enabled = false;
        }
        private void Cast()
        {
            int count = 0;
            try
            {
                if (Question == 0)
                {
                    if (ImageTextBox_1.Text == "B".ToString() && ImageTextBox_2.Text == "D".ToString() && ImageTextBox_3.Text == "сквозную".ToString())
                    {
                        RightAnswer++;
                        AnswerRightPanel.BackColor = Color.Green;
                        goto next;
                    }
                    else
                    {
                        ErrorAnswer++;
                        AnswerRightPanel.BackColor = Color.Red;
                    }
                }
                if (KindQuestion == 0)
                {
                    if (AnswerTextBox.Text.ToLower().Replace(" ", "").Replace(",", "").Replace("-", "") == answ)
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
                    if (count == answ.Length)
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
            next: { }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите правильный ответ");
            }
        }
        /// <summary>
        /// Выдает результат
        /// </summary>
        private void Rezultat()
        {
            Rezult rez = new Rezult();
            rez.FioLabel.Text = "Курсант:" + fio;
            rez.N_groupLabel.Text = "№ учебной группы:" + N_group;
            rez.Show();
            rez.AnswerLabel.Text = RightAnswer.ToString();
            if ((RightAnswer / Question) * 100 >= 90)
                rez.mark.Text = 5.ToString();
            if ((RightAnswer / Question) * 100 >= 80 && (RightAnswer / 21) * 100 <= 90)
                rez.mark.Text = 4.ToString();
            if ((RightAnswer / Question) * 100 >= 70 && (RightAnswer / 21) * 100 <= 80)
                rez.mark.Text = 3.ToString();
            else
                rez.mark.Text = 2.ToString();
            this.Close();
        }
        /// <summary>
        /// формирование формы
        /// </summary>
        public void Next()
        {
            ImageButton_Question1.Visible = false;
            AnswerTextBox.Visible = false;
            ImageTextBox_3.Visible = false;
            AnswerTextBox.Visible = true;
            Labelquest.Visible = true;
            RightPanel.Visible = true;
            LeftPanel.Visible = true;
            RightPanel.Controls.Clear();
            LeftPanel.Controls.Clear();
            AnswerTextBox.Clear();
            NextButton.Enabled = false;
            KindQuestion = random.Next(0, 2);
            switch (KindQuestion)
            {
                case 0:
                    {
                        countw++;
                        if (countw > 14)
                            goto case 1;
                        CounterLabel.Text = (Question) + "/20";
                        step = random.Next(0, iterw.Count);
                        iterw.Remove(iterw[step]);
                        LabelQuestions.Text = Questions.Getquestionword(TypeATC.T_76, step);
                        answ = Ansewrs.Getanswerword(TypeATC.T_76, step);
                        Labelquest.Visible = true;
                        AnswerTextBox.Visible = true;
                        break;
                    }
                case 1:
                    {
                        countc++;
                        if (countc > 5)
                            goto case 0;
                        CounterLabel.Text = (Question) + "/20";
                        NextButton.Enabled = true;
                        AnswerTextBox.Visible = false;
                        Labelquest.Visible = false;
                        step = random.Next(0, iterc.Count);
                        iterc.Remove(iterc[step]);
                        answ = Questions.GetquestionComparison(TypeATC.T_76, step);
                        tmpq = new string[answ.Length * 2];
                        tmpq = answ.Split('|');
                        LabelQuestions.Text = tmpq[0];
                        if (tmpq.Length == 1)
                        {
                            goto Next;
                        }
                        k30 = 50;
                        for (int i = 1; i < tmpq.Length; i++)
                        {
                            lab = new Label();
                            lab.Text = i + ". " + tmpq[i];
                            lab.Location = new Point(10, -10 + k30);
                            lab.MaximumSize = new Size(400, 150);
                            lab.AutoSize = true;
                            lab.ForeColor = Color.Black;
                            lab.TextAlign = ContentAlignment.MiddleLeft;
                            RightPanel.Controls.Add(lab);
                            k30 += 50;
                        }
                    Next:
                        k30 = 50;
                        answ = Ansewrs.GetanswerComparison(TypeATC.T_76, step);
                        tmpa = new string[answ.Length * 2];
                        tmpa = answ.Split('^');
                        for (int i = 0; i < tmpa.Length; i++)
                        {
                            lab = new Label();
                            lab.Text = tmpa[i];
                            lab.Location = new Point(120, -10 + k30);
                            lab.AutoSize = true;
                            lab.ForeColor = Color.Black;
                            lab.TextAlign = ContentAlignment.TopLeft;
                            lab.MaximumSize = new Size(320, 150);
                            LeftPanel.Controls.Add(lab);
                            k30 += 50;
                        }
                        k30 = 50;
                        BDP = new ComboBox[tmpa.Length];
                        for (int i = 0; i < tmpa.Length; i++)
                        {
                            BDP[i] = new ComboBox();
                            for (int j = 1; j <= tmpa.Length; j++)
                            {
                                BDP[i].Items.Add(j);
                            }
                            BDP[i].Width = 100;
                            BDP[i].Location = new System.Drawing.Point(10, -10 + k30);
                            BDP[i].Text = "Выберите";
                            LeftPanel.Controls.Add(BDP[i]);
                            k30 += 50;
                        }
                        k30 = 50;
                        answ = Ansewrs.GetOtvetu(TypeATC.T_76, step);
                        tmpa = answ.Split('^');
                        break;
                    }
            }
            if (Question == 20)
            {
                NextButton.Text = "Завершить";
            }
        }

        private void T_76_Load(object sender, EventArgs e)
        {
            NextButton.Enabled = true;
            RightPanel.Visible = false;
            LeftPanel.Visible = false;
            AnswerTextBox.Visible = false;
            Labelquest.Visible = false;
            LabelQuestions.Text = "Дополните таблицу (Заполните пустые ячейки)";
            CounterLabel.Text = (Question) + "/20";
        }

        private void StopTest_Click(object sender, EventArgs e)
        {
            Rezultat();
        }
    }
}
