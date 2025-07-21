using System.Diagnostics.SymbolStore;

namespace Klienci
{
    public partial class Form1 : Form
    {
        int x = 0, y = 0, z = 0, a = 0;
        DateTime start = DateTime.Now, end;
        DateTime start2 = DateTime.Now, end2;
        DateTime start3 = DateTime.Now, end3;
        DateTime start4 = DateTime.Now, end4;
<<<<<<< Updated upstream
=======

        TimeSpan elapsedTime1;
        DateTime lastElapsed1;
        TimeSpan elapsedTime2;
        DateTime lastElapsed2;
        TimeSpan elapsedTime3;
        DateTime lastElapsed3;
        TimeSpan elapsedTime4;
        DateTime lastElapsed4;

        //konstruktor = pusty
>>>>>>> Stashed changes
        public Form1()
        {
            InitializeComponent();

        }
        //kontrolery Always on Top - dają w menu oraz w tray opcje Always on Top
        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlwaysOnTop();
        }


        private void alwaysOnTopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AlwaysOnTop();
        }

        //Funkcja ktora można wywołać wszędzie, żeby wywołać AlwaysOnTop
        private void AlwaysOnTop()
        {
            if (this != null)
            {
                this.TopMost = !this.TopMost;
            }
        }

        //formLoad = czyszczenie i wypelnianie danymi
        private void Form1_Load(object sender, EventArgs e)
        {
            //timer1.Start();
            string[] lines = File.ReadAllLines("KlienciL.txt");
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();
            comboBox7.Items.Clear();
            comboBox8.Items.Clear();
            comboBox5.Items.AddRange(lines);
            comboBox6.Items.AddRange(lines);
            comboBox7.Items.AddRange(lines);
            comboBox8.Items.AddRange(lines);
        }




        //Event - naciśnięcie przycisku startu w timer nr 1. Plus timer ticker, żeby pokazywało sam stopper
        //oraz przycisk resetu
        private void buttonStart1_Click(object sender, EventArgs e) { }
        //{

<<<<<<< Updated upstream
            if (x == 0)
            {
                start = DateTime.Now;
                //buttonStart1.Text = "Stop";
                label3.Text = start.ToString();
                label4.Text = "End Time";
                x = 1;
                timer1.Start();
=======
        //    if (x == 0)
        //    {

        //        start = DateTime.Now;
        //        //buttonStart1.Text = "Stop";
        //        label3.Text = start.ToString();
        //        label4.Text = "End Time";
        //        x = 1;
        //        timer1.Start();
>>>>>>> Stashed changes


        //    }
        //    else
        //    {
        //        end = DateTime.Now;
        //        //buttonStart1.Text = "Start";
        //        label4.Text = end.ToString();
        //        x = 0;
        //        timer1.Stop();
        //        //label5.Text = timer1.T
        //    }
        //}

<<<<<<< Updated upstream
        //Event - naciśnięcie przycisku startu w timer nr 2 tick oraz reset
        private void button5_Click(object sender, EventArgs e)
        {
            if (y == 0)
            {
                start = DateTime.Now;
                //button5.Text = "Stop";
                label8.Text = start.ToString();
                y = 1;
                timer2.Start();
                timer2.Enabled = true;
=======
        private void button3_Click(object sender, EventArgs e) { }
        //{
        //    timer1.Stop();
        //    label3.Text = "Start Time";
        //    label4.Text = "End Time";
        //}
>>>>>>> Stashed changes

        ////Event - naciśnięcie przycisku startu w timer nr 2 tick oraz reset
        private void button5_Click(object sender, EventArgs e) { }
        //{
        //    if (y == 0)
        //    {
        //        lastElapsed = DateTime.Now;
        //        start = DateTime.Now;
        //        //button5.Text = "Stop";
        //        label8.Focus();
        //        label8.Text = lastElapsed.ToString();
        //        y = 1;
        //        timer2.Start();
        //        timer2.Enabled = true;

        //    }
        //    else
        //    {
        //        end = DateTime.Now;
        //        //button5.Text = "Start";
        //        label10.Text = end.ToString();
        //        y = 0;
        //        timer2.Stop();
        //        //label5.Text = timer1.T
        //    }

        //}

        //problem jest taki, że gdy leci czas to resetuje też inne zegary gdy klikany jest reset
        //np leci zegar 1 leci zastopowany jest zegar 2 a nastepnie resetowany i wtedy resetuje także zegar 1


        ////zegar nr 3
        private void button8_Click(object sender, EventArgs e) { }
        //{

        //    if (z == 0)
        //    {
        //        anyTimer(timer3, z, button8, label13, label15, this.start3, this.end3);
        //        z = 1;
        //    }
        //    else
        //    {
        //        anyTimer(timer3, z, button8, label13, label15, this.start3, this.end3);
        //        z = 0;
        //    }
        //}

<<<<<<< Updated upstream
        private void timer3_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - start3;
            label12.Text = span.ToString(@"mm\:ss\.ff");
            button8.Text = span.ToString(@"mm\:ss\.ff");
            ButtonStart3.Text = span.ToString(@"hh\:mm\:ss");
        }
=======

>>>>>>> Stashed changes

        //zegar nr 4

        private void button11_Click(object sender, EventArgs e) { }
        //{
        //    if (a == 0)
        //    {
        //        anyTimer(timer4, a, button11, label18, label20, this.start3, this.end3);
        //        a = 1;
        //    }
        //    else
        //    {
        //        anyTimer(timer4, a, button11, label18, label20, this.start3, this.end3);
        //        a = 0;
        //    }
        //}



        //Funkcja skracajaca wywolywanie kolejnych zegarów
        //private void anyTimer(System.Windows.Forms.Timer timers, int values, System.Windows.Forms.Button buttons, System.Windows.Forms.Label labelStart, System.Windows.Forms.Label labelEnd, DateTime start, DateTime end)
        //{
        //    if (values == 0)
        //    {
        //        start = DateTime.Now;
        //        //buttons.Text = "Stop";
        //        labelStart.Text = start.ToString();
        //        timers.Start();

        //    }
        //    else
        //    {
        //        end = DateTime.Now;
        //        //buttons.Text = "Start";
        //        labelEnd.Text = end.ToString();
        //        timers.Stop();
        //        //label5.Text = timer1.T
        //    }
        //}

        private void buttonStartOLD1_Click(object sender, EventArgs e) { }
        //{

        //}
        //Event - naciśnięcie przycisku startu w timer nr 1. Plus timer ticker, żeby pokazywało sam stopper
        private void ButtonStart1_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
<<<<<<< Updated upstream
=======
                lastElapsed1 = DateTime.Now;
>>>>>>> Stashed changes
                start = DateTime.Now;
                //buttonStart1.Text = "Stop";
                label3.Text = start.ToString();
                label4.Text = "End Time";
                x = 1;
                //timer1.Start();
                timer1.Enabled = true;

            }
            else
            {
                end = DateTime.Now;
                //buttonStart1.Text = "Start";
                label4.Text = end.ToString();
                x = 0;
                //timer1.Stop();
                timer1.Enabled = false;
                //label5.Text = timer1.T
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            TimeSpan span = DateTime.Now - start;
            label5.Text = span.ToString(@"\:hh\:mm\:ss\.ff");
            buttonStartOLD1.Text = span.ToString(@"mm\:ss\.ff");
            ButtonStart1.Text = span.ToString(@"hh\:mm\:ss");
=======
            elapsedTime1 += DateTime.Now - lastElapsed1;
            lastElapsed1 = DateTime.Now;
            //TimeSpan span = DateTime.Now - start3;
            //label12.Text = elapsedTime.ToString(@"mm\:ss\.ff");
            //button8.Text = elapsedTime.ToString(@"mm\:ss\.ff");
            ButtonStart1.Text = elapsedTime1.ToString(@"hh\:mm\:ss");


            //TimeSpan span = DateTime.Now - start;
            //label5.Text = span.ToString(@"\:hh\:mm\:ss\.ff");
            //buttonStartOLD1.Text = span.ToString(@"mm\:ss\.ff");
            //ButtonStart1.Text = span.ToString(@"hh\:mm\:ss");
>>>>>>> Stashed changes
        }

        //Event - naciśnięcie przycisku startu w timer nr 2 tick
        private void ButtonStart2_Click(object sender, EventArgs e)
        {
            if (y == 0)
            {
<<<<<<< Updated upstream
                start2 = DateTime.Now;
                //button5.Text = "Stop";
                label8.Text = start2.ToString();
                y = 1;
                timer2.Start();

            }
            else
            {
                end2 = DateTime.Now;
                //button5.Text = "Start";
                label10.Text = end2.ToString();
=======

                lastElapsed2 = DateTime.Now;
                //start = DateTime.Now;
                //buttonStart1.Text = "Stop";
                //label3.Text = start.ToString();
                //label4.Text = "End Time";
                y = 1;
                //timer1.Start();
                timer2.Enabled = true;
                PauseButton2.BackgroundImage = Image.FromFile("pause.png");


                //start2 = DateTime.Now;
                ////button5.Text = "Stop";
                ////label8.Text = start2.ToString();
                //y = 1;
                //timer2.Start();

                //PauseButton2.BackgroundImage = Image.FromFile("pause.png");

            }
            else
            {
               // end = DateTime.Now;
                //buttonStart1.Text = "Start";
                //label4.Text = end.ToString();
>>>>>>> Stashed changes
                y = 0;
                //timer1.Stop();
                timer2.Enabled = false;
                PauseButton2.BackgroundImage = Image.FromFile("play-button-arrowhead.png");



                //end2 = DateTime.Now;
                ////button5.Text = "Start";
                ////label10.Text = end2.ToString();
                //y = 0;
                //timer2.Stop();
                ////label5.Text = timer1.T
            }

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            elapsedTime2 += DateTime.Now - lastElapsed2;
            lastElapsed2 = DateTime.Now;
            //TimeSpan span = DateTime.Now - start3;
            //label12.Text = elapsedTime.ToString(@"mm\:ss\.ff");
            //button8.Text = elapsedTime.ToString(@"mm\:ss\.ff");
            ButtonStart2.Text = elapsedTime2.ToString(@"hh\:mm\:ss");

            //TimeSpan span = DateTime.Now - start2;
            //label7.Text = span.ToString(@"mm\:ss\.ff");
            ////ButtonStart2.Text = span.ToString(@"mm\:ss\.ff");
            //ButtonStart2.Text = span.ToString(@"hh\:mm\:ss");
        }

        private void ButtonStart1_MouseDown(object sender, MouseEventArgs e)
        {
            //ButtonStart1.Text = "a";
        }

        private void ButtonStart1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void ButtonStart3_Click(object sender, EventArgs e)
        {
            if (z == 0)
            {
<<<<<<< Updated upstream
                start3 = DateTime.Now;
                //button5.Text = "Stop";
                //label8.Text = start2.ToString();
=======
                lastElapsed3 = DateTime.Now;
                start = DateTime.Now;
                //buttonStart1.Text = "Stop";
                //label3.Text = start.ToString();
                //label4.Text = "End Time";
>>>>>>> Stashed changes
                z = 1;
                timer3.Start();

            }
            else
            {
                // end = DateTime.Now;
                //buttonStart1.Text = "Start";
                //label4.Text = end.ToString();
                z = 0;
                //timer1.Stop();
                timer3.Enabled = false;
                PauseButton3.BackgroundImage = Image.FromFile("play-button-arrowhead.png");

                //end3 = DateTime.Now;
                ////button5.Text = "Start";
                ////label10.Text = end3.ToString();
                //z = 0;
                //timer3.Stop();
                ////label5.Text = timer1.T
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {

            elapsedTime3 += DateTime.Now - lastElapsed3;
            lastElapsed3 = DateTime.Now;
            //TimeSpan span = DateTime.Now - start3;
            //label12.Text = elapsedTime.ToString(@"mm\:ss\.ff");
            //button8.Text = elapsedTime.ToString(@"mm\:ss\.ff");
            ButtonStart3.Text = elapsedTime3.ToString(@"hh\:mm\:ss");
        }

        private void ButtonStart4_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                lastElapsed4 = DateTime.Now;
                //start = DateTime.Now;
                //buttonStart1.Text = "Stop";
                //label3.Text = start.ToString();
                //label4.Text = "End Time";
                a = 1;
<<<<<<< Updated upstream
                timer4.Start();
=======
                //timer1.Start();
                timer4.Enabled = true;
                PauseButton4.BackgroundImage = Image.FromFile("pause.png");


                //start4 = DateTime.Now;
                ////button5.Text = "Stop";
                ////label8.Text = start2.ToString();
                //a = 1;
                //timer4.Start();

                //PauseButton4.BackgroundImage = Image.FromFile("pause.png");
>>>>>>> Stashed changes

            }
            else
            {
                // end = DateTime.Now;
                //buttonStart1.Text = "Start";
                //label4.Text = end.ToString();
                a = 0;
                //timer1.Stop();
                timer4.Enabled = false;
                PauseButton4.BackgroundImage = Image.FromFile("play-button-arrowhead.png");


                //end4 = DateTime.Now;
                ////button5.Text = "Start";
                ////label10.Text = end3.ToString();
                //a = 0;
                //timer4.Stop();
                ////label5.Text = timer1.T
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            elapsedTime4 += DateTime.Now - lastElapsed4;
            lastElapsed4 = DateTime.Now;
            //TimeSpan span = DateTime.Now - start3;
            //label12.Text = elapsedTime.ToString(@"mm\:ss\.ff");
            //button8.Text = elapsedTime.ToString(@"mm\:ss\.ff");
            ButtonStart4.Text = elapsedTime4.ToString(@"hh\:mm\:ss");

            //TimeSpan span = DateTime.Now - start4;
            //label17.Text = span.ToString(@"mm\:ss\.ff");
            //button11.Text = span.ToString(@"mm\:ss\.ff");
            //ButtonStart4.Text = span.ToString(@"hh\:mm\:ss");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }
<<<<<<< Updated upstream
        private void SaveButton()
=======

        //save to file
        private void SaveButton(string klient, string time)
        {
            //StringBuilder csv = new StringBuilder();
            DateTime now = DateTime.Now;
            //csv.AppendLine(klient + ";" + time + ";" + now + ";");
            //csv.ToString();
            //File.AppendAllLines("Result.csv", csv.ToString());

            using (StreamWriter sw = new StreamWriter(new FileStream("Result.csv", FileMode.Append, FileAccess.Write)))
            {
                sw.WriteLine(klient + ";" + time + ";" + now + ";");
            }
        }

        private void ResetButton1_Click(object sender, EventArgs e)
        {
                timer1.Stop();
                elapsedTime1 = TimeSpan.Zero ;
                x= 1;
                timer1.Start();

        }

        private void ResetButton2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            elapsedTime2 = TimeSpan.Zero ;
            y = 1;
            timer2.Start();
        }

        private void ResetButton3_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            elapsedTime3 = TimeSpan.Zero;
            z = 1;
            timer3.Start();
        }

        private void ResetButton4_Click(object sender, EventArgs e)
        {
            timer4.Stop();
            elapsedTime4 = TimeSpan.Zero;
            a = 1;
            timer4.Start();
        }

        private void PauseButton1_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                ButtonStart1_Click(sender, e);
                x = 0;
                //lastElapsed = DateTime.Now;
            }
            else 
            {
                ButtonStart1_Click(sender, e);
                x = 1;
            }

        }

        private void PauseButton2_Click(object sender, EventArgs e)
        {
            if (y == 1)
            {
                ButtonStart2_Click(sender, e);
                y = 0;
                //lastElapsed = DateTime.Now;
            }
            else
            {
                ButtonStart2_Click(sender, e);
                y = 1;
            }
        }

        private void PauseButton3_Click(object sender, EventArgs e)
        {
            if (z == 1)
            {
                ButtonStart3_Click(sender, e);
                z = 0;
                //lastElapsed = DateTime.Now;
            }
            else
            {
                ButtonStart3_Click(sender, e);
                z = 1;
            }
        }

        private void PauseButton4_Click(object sender, EventArgs e)
>>>>>>> Stashed changes
        {
            if (a == 1)
            {
                ButtonStart4_Click(sender, e);
                a = 0;
                //lastElapsed = DateTime.Now;
            }
            else
            {
                ButtonStart4_Click(sender, e);
                a = 1;
            }
        }
    }
}
