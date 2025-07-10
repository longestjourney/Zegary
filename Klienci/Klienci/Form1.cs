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


        //nic
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
        private void buttonStart1_Click(object sender, EventArgs e)
        {

            if (x == 0)
            {
                start = DateTime.Now;
                //buttonStart1.Text = "Stop";
                label3.Text = start.ToString();
                label4.Text = "End Time";
                x = 1;
                timer1.Start();

            }
            else
            {
                end = DateTime.Now;
                //buttonStart1.Text = "Start";
                label4.Text = end.ToString();
                x = 0;
                timer1.Stop();
                //label5.Text = timer1.T
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label3.Text = "Start Time";
            label4.Text = "End Time";
        }

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

            }
            else
            {
                end = DateTime.Now;
                //button5.Text = "Start";
                label10.Text = end.ToString();
                y = 0;
                timer2.Stop();
                //label5.Text = timer1.T
            }

        }

        //problem jest taki, że gdy leci czas to resetuje też inne zegary gdy klikany jest reset
        //np leci zegar 1 leci zastopowany jest zegar 2 a nastepnie resetowany i wtedy resetuje także zegar 1


        //zegar nr 3
        private void button8_Click(object sender, EventArgs e)
        {

            if (z == 0)
            {
                anyTimer(timer3, z, button8, label13, label15, this.start3, this.end3);
                z = 1;
            }
            else
            {
                anyTimer(timer3, z, button8, label13, label15, this.start3, this.end3);
                z = 0;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - start3;
            label12.Text = span.ToString(@"mm\:ss\.ff");
            button8.Text = span.ToString(@"mm\:ss\.ff");
            ButtonStart3.Text = span.ToString(@"hh\:mm\:ss");
        }

        //zegar nr 4

        private void button11_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                anyTimer(timer4, a, button11, label18, label20, this.start3, this.end3);
                a = 1;
            }
            else
            {
                anyTimer(timer4, a, button11, label18, label20, this.start3, this.end3);
                a = 0;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - start4;
            label17.Text = span.ToString(@"mm\:ss\.ff");
            button11.Text = span.ToString(@"mm\:ss\.ff");
            ButtonStart4.Text = span.ToString(@"hh\:mm\:ss");
        }

        //Funkcja skracajaca wywolywanie kolejnych zegarów
        private void anyTimer(System.Windows.Forms.Timer timers, int values, System.Windows.Forms.Button buttons, System.Windows.Forms.Label labelStart, System.Windows.Forms.Label labelEnd, DateTime start, DateTime end)
        {
            if (values == 0)
            {
                start = DateTime.Now;
                //buttons.Text = "Stop";
                labelStart.Text = start.ToString();
                timers.Start();

            }
            else
            {
                end = DateTime.Now;
                //buttons.Text = "Start";
                labelEnd.Text = end.ToString();
                timers.Stop();
                //label5.Text = timer1.T
            }
        }

        private void buttonStartOLD1_Click(object sender, EventArgs e)
        {

        }
        //Event - naciśnięcie przycisku startu w timer nr 1. Plus timer ticker, żeby pokazywało sam stopper
        private void ButtonStart1_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
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
            TimeSpan span = DateTime.Now - start;
            label5.Text = span.ToString(@"\:hh\:mm\:ss\.ff");
            buttonStartOLD1.Text = span.ToString(@"mm\:ss\.ff");
            ButtonStart1.Text = span.ToString(@"hh\:mm\:ss");
        }

        //Event - naciśnięcie przycisku startu w timer nr 2 tick
        private void ButtonStart2_Click(object sender, EventArgs e)
        {
            if (y == 0)
            {
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
                y = 0;
                timer2.Stop();
                //label5.Text = timer1.T
            }

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - start2;
            label7.Text = span.ToString(@"mm\:ss\.ff");
            //ButtonStart2.Text = span.ToString(@"mm\:ss\.ff");
            ButtonStart2.Text = span.ToString(@"hh\:mm\:ss");
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
                start3 = DateTime.Now;
                //button5.Text = "Stop";
                //label8.Text = start2.ToString();
                z = 1;
                timer3.Start();

            }
            else
            {
                end3 = DateTime.Now;
                //button5.Text = "Start";
                //label10.Text = end3.ToString();
                z = 0;
                timer3.Stop();
                //label5.Text = timer1.T
            }
        }

        private void ButtonStart4_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                start4 = DateTime.Now;
                //button5.Text = "Stop";
                //label8.Text = start2.ToString();
                a = 1;
                timer4.Start();

            }
            else
            {
                end4 = DateTime.Now;
                //button5.Text = "Start";
                //label10.Text = end3.ToString();
                a = 0;
                timer4.Stop();
                //label5.Text = timer1.T
            }
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
        private void SaveButton()
        {

        }
    }
}
