using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Munkaxd
{
    public partial class Form1 : Form
    {
        private float _ticks;
        private int _ticks2;
        private int katt;
        private int _ticks3 = 0;
        private int _ticks4 = 0;
        int k = 0;

        public Form1()
        {
            InitializeComponent();
        }

        
        //**************************************GOMBOK***************************************//


        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            this.BackgroundImage = Properties.Resources.White;
            MessageBox.Show("Noah:\nAhh...mi történhetett?");
            MessageBox.Show("És hol vagyok?");
            MessageBox.Show("*Kiáltva* Halló...Valaki van itt?");
            MessageBox.Show("Na mindegy lássuk mire is emlékszem mielőtt ide kerültem volna...");
            button4.Visible = true;

        }
            private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Üdvözöllek a játék leírásában!\n\nEz a játék egy kaland,sci-fi keverék, szóval lesznek benne bizarr dolgok ne ijedj meg!\n\n Amit a játék kínál a játékosnak:\n -10 arany kezdésnek\n -1 darab fáklya \n -Ruhadarabok(szövetruha,régi kopott kapucnis kabát)\n -Egy térkép darab\n-Fegyverként egy ostor");
            MessageBox.Show("Történet(Dióhéjban): A főszereplőt Noah Walker-t elrabolják miközben lerobban az autója egy sikátoros utca mellett.\n\nInnen a történet választás opcionális, ahogy a játékos(Te) választ azon törénet szerint fog a játék folyni.\nVálasztási lehetőségek: \n-Időutazás\n-Sivatagi veszedelem\n\nIdőutazás:\nTörténet lényege, hogy a sikátorban lévő ember elrabolt és berakott egy időgépbe majd visszarepültél az időben, pontosabban 1545-be. Egyetlen módja annak, hogy haza tudj jutni az az, hogy meg kell találnod egy nagyon ritka ásványt és összezúznod és közben gondolnod kell arra az időpontra, ahova vissza akarsz jutni. Az ásvány megtalálásához át kell küzdened magad különböző akadályokon. Ha ezeket leküzdötted akkor tudsz értelem szerűen közelebb kerülni a célhoz.A játék során elrejtett a fejlesztő(Daweed) egy Easter Egg-et(Húsvéti tojást) aminek a megtalálásával több időt nyerhetsz, hogy véghez vidd a célod.\n\nSivatagi veszedelem:\nKitesznek a Szaharába. A cél itt az, hogy juss el Egyiptomig és mássz fel a piramis tetejére, ahol megleled a visszautat, ahonnan elraboltak téged. Persze itt a fejlesztő(Daweed) a pályán elrejtett pár Easter Egget, amit előszeretettel lehet megtalálni(ha megtudod).");
            
            button1.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
            button3.Visible = false;
            this.BackgroundImage = Properties.Resources.cig;
            MessageBox.Show("Noah:\nDe sajnos meg kellett állnom mert lerobbant az autóm.");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            
            this.BackgroundImage = Properties.Resources.EjszakaiUt;
            timer1.Start();
            MessageBox.Show("Noah:\nElőször is munkából tartottam hazafelé");
        }
        private void button5_Click(object sender, EventArgs e)
        {
           
            this.BackgroundImage = Properties.Resources.Szabi2;
            button5.Visible = false;
            button6.Visible = true;
            button7.Visible = true;
            
           
        }
        private void button6_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Sajnálattal közlöm, hogy ez a pálya még nincs elkészítve!");
            
        }
        private void button7_Click(object sender, EventArgs e)
        {
            //Alap, ami szerint csinálom a picturebox-os témát
            /*Size JobbraMenni1 = new Size(78, 153);
            JobbraMegy1.Size = JobbraMenni1;
            JobbraMegy1.Image = Projekt_Munkaxd.Properties.Resources.JobbraMegy1;
            JobbraMegy1.Location = new Point(12,241);
            */
            button6.Visible = false;
            button7.Visible = false;
            JobbraMegy1.Visible = true;

            this.BackgroundImage = Properties.Resources.Mezo1;
            Size JobbraMenni1 = new Size(104, 198);
            JobbraMegy1.Size = JobbraMenni1;
            JobbraMegy1.Image = Projekt_Munkaxd.Properties.Resources.JobbraMegy1;       //Ha oszthato maradék nélkul akkor 1 ha nem akkor 2(Magamnak)
            JobbraMegy1.Location = new Point(k,193);
            JobbraMegy1.Visible = true;
            timer3.Start();

        }

        



        //**************************************************************TIMER*********************************************************************//



        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            button3.Visible = true;
            


            
            if (_ticks == 1.0) {
                
                this.BackgroundImage = Properties.Resources._0;
            }
            if (_ticks == 1.5)
            {
                this.BackgroundImage = Properties.Resources._1;

            }
            if (_ticks == 2.0)
            {
                this.BackgroundImage = Properties.Resources._2;
            }
            if (_ticks == 2.5)
            {
                this.BackgroundImage = Properties.Resources._3;
            }
            if (_ticks == 3.0)
            {
                this.BackgroundImage = Properties.Resources._4;
            }
            if (_ticks == 3.5)
            {
                this.BackgroundImage = Properties.Resources._5;
            }
            if (_ticks == 4.0)
            {
                this.BackgroundImage = Properties.Resources._6;
            }
            if (_ticks == 4.5)
            {
                this.BackgroundImage = Properties.Resources._7;
            }
            if (_ticks == 5.0)
            {
                this.BackgroundImage = Properties.Resources._8;

            }
            if (_ticks == 5.5)
            {
                this.BackgroundImage = Properties.Resources._9;
            }
            if (_ticks == 6.0)
            {
                this.BackgroundImage = Properties.Resources._10;
            }
            if (_ticks == 6.5)
            {
                this.BackgroundImage = Properties.Resources._11;
            }
            if (_ticks == 7.0)
            {
                this.BackgroundImage = Properties.Resources._12;
            }
            if (_ticks == 7.5)
            {
                this.BackgroundImage = Properties.Resources._13;

            }
            if (_ticks == 8.0)
            {
                this.BackgroundImage = Properties.Resources._14;
            }
            if (_ticks == 8.5)
            {
                this.BackgroundImage = Properties.Resources._15;
            }
            if (_ticks == 9.0)
            {
                this.BackgroundImage = Properties.Resources._16;
            }
            if (_ticks == 9.5)
            {
                this.BackgroundImage = Properties.Resources._17;
            }
            if (_ticks ==10.0)
            {
                this.BackgroundImage = Properties.Resources._18;
            }
            if (_ticks == 10.5)
            {
                this.BackgroundImage = Properties.Resources._19;
            }
            if (_ticks == 11.0)
            {
                this.BackgroundImage = Properties.Resources._20;
            }

            if (_ticks == 11.5)
            {
                this.BackgroundImage = Properties.Resources._21;
            }
            if (_ticks == 12.0)
            {
                this.BackgroundImage = Properties.Resources._22;
            }
            if (_ticks == 12.5)
            {
                this.BackgroundImage = Properties.Resources._23;
            }
            if (_ticks == 13.0)
            {
                this.BackgroundImage = Properties.Resources._24;
            }
            if (_ticks == 13.5)
            {
                this.BackgroundImage = Properties.Resources._25;
            }
            if (_ticks == 14.0)
            {
                this.BackgroundImage = Properties.Resources._26;
            }
            if (_ticks == 14.5)
            {
                this.BackgroundImage = Properties.Resources._27;
            }
            if (_ticks == 15.0)
            {
                this.BackgroundImage = Properties.Resources._28;
            }
            if (_ticks == 15.5)
            {
                this.BackgroundImage = Properties.Resources._29;
            }
            if (_ticks == 16.0)
            {
                this.BackgroundImage = Properties.Resources._30;
            }
            if (_ticks == 16.5)
            {
                this.BackgroundImage = Properties.Resources._31;
            }
            if (_ticks == 17.0)
            {
                this.BackgroundImage = Properties.Resources._32;
            }
            if (_ticks == 17.5)
            {
                this.BackgroundImage = Properties.Resources._33;
            }
            if (_ticks == 18.0)
            {
                this.BackgroundImage = Properties.Resources._34;
            }
            if (_ticks == 18.5)
            {
                this.BackgroundImage = Properties.Resources._35;
            }
            if (_ticks == 19.0)
            {
                this.BackgroundImage = Properties.Resources._36;
            }
            if (_ticks == 19.5)
            {
                this.BackgroundImage = Properties.Resources._37;
            }
            if (_ticks == 20.0)
            {
                this.BackgroundImage = Properties.Resources._38;
            }
            if (_ticks == 20.5)
            {
                this.BackgroundImage = Properties.Resources._39;
            }
            if (_ticks == 21.0)
            {
                this.BackgroundImage = Properties.Resources._40;
            }
            if (_ticks == 21.5)
            {
                this.BackgroundImage = Properties.Resources._41;
            }
            if (_ticks == 22.0)
            {
                this.BackgroundImage = Properties.Resources._42;
            }
            if (_ticks == 22.5)
            {
                this.BackgroundImage = Properties.Resources._43;
            }
            if (_ticks == 23.0)
            {
                this.BackgroundImage = Properties.Resources._44;
            }
            if (_ticks == 23.5)
            {
                this.BackgroundImage = Properties.Resources._45;
            }
            if (_ticks == 24.0)
            {
                this.BackgroundImage = Properties.Resources._46;
                timer1.Stop();

            }
          

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            _ticks2++;
            if (_ticks2 == 3)
            {
                this.BackgroundImage = Properties.Resources.cig2;
            }
            if (_ticks2 == 4) {
                MessageBox.Show("Meghallottam egy zajt a sikátorból.\nBekiáltottam egyet a sötét helyre 'VAN OTT VALAKI?', majd beljebb merészkedtem, mert azt gondoltam talán tudna nekem segíteni.");
            }
            if (_ticks2 == 8) {
                this.BackgroundImage = Properties.Resources.cig3;
            }
            if (_ticks2 == 9)
            {
                this.BackgroundImage = Properties.Resources.cig4;
            }
            if (_ticks2 == 10)
            {
                this.BackgroundImage = Properties.Resources.cig5;
            }
            if (_ticks2 == 11)
            {
                this.BackgroundImage = Properties.Resources.cig6;
                MessageBox.Show("Noah:\nLáttam egy embert a földön és ez az utolso emlékem mielőtt minden elsötétült.");
            }
            if (_ticks2 == 14) {
                
                this.BackgroundImage = Properties.Resources.black;
                timer2.Stop();
                button5.Visible = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            /*
            this.BackgroundImage = Properties.Resources.Mezo1;
            Size JobbraMenni1 = new Size(104, 198);
            JobbraMegy1.Size = JobbraMenni1;
            JobbraMegy1.Image = Projekt_Munkaxd.Properties.Resources.JobbraMegy1;       //Ha oszthato maradék nélkul akkor 1 ha nem akkor 2(Magamnak)
            JobbraMegy1.Location = new Point(0, 193);
            */

            _ticks3++;

            while (true) {
                if (_ticks3 <= 13)
                {
                    if (_ticks3 % 2 == 0)
                    {


                        JobbraMegy1.Image = Projekt_Munkaxd.Properties.Resources.JobbraMegy1;

                        k = k + 50;
                        JobbraMegy1.Location = new Point(k, 193);
                    }
                    else
                    {

                        JobbraMegy1.Image = Projekt_Munkaxd.Properties.Resources.JobbraMegy2;
                        k = k + 50;
                        JobbraMegy1.Location = new Point(k, 193);
                    }
                    break;
                }
                else {
                    
                    timer3.Stop();
                    timer4.Start();
                }
            }

            
           

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            _ticks4++;
            this.BackgroundImage = Properties.Resources.Mezo2;
            while (true)
            {
                if (_ticks3 <= 13)
                {
                    if (_ticks3 % 2 == 0)
                    {


                        JobbraMegy1.Image = Projekt_Munkaxd.Properties.Resources.JobbraMegy1;

                        k = k + 50;
                        JobbraMegy1.Location = new Point(k, 193);
                    }
                    else
                    {

                        JobbraMegy1.Image = Projekt_Munkaxd.Properties.Resources.JobbraMegy2;
                        k = k + 50;
                        JobbraMegy1.Location = new Point(k, 193);
                    }
                    break;
                }
                else
                {

                    timer4.Stop();
                }
            }   }   
    }
}