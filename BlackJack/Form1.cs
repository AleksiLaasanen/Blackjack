using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {

        int voitot = 0;
        int häviöt = 0;
        //Luodaan Pakka luokasta uusi objekti nimeltään "playDeck". "playDeck" pitää sisällään pelin jaettavissa olevat kortit.
        Pakka playDeck = new Pakka();
        //Luodaan objekti jakajan korteille.
        Pakka dealerCards = new Pakka();
        //luodaan objekti pelaajan korteille.
        Pakka playerCards = new Pakka();

        Pakka calculateOddsDeck = new Pakka();

        //Luo Timer objektin Timers luokasta
        private System.Timers.Timer timer = null;
        bool autoPlay = false;

        public static Dictionary<string, Bitmap> CARD_PICTURES =
            new Dictionary<string, Bitmap>();
        //Constructor
        public Form1()
        {
            InitializeComponent();
            //Tekee fillDeck metodin, joka generoi pakkaan kortti objektit.
            playDeck.fillDeck();
            //Tekee Shuffle metodin, joka sekoitaa pakan kortit.
            playDeck.Shuffle();
            foreach (Kortti c in playDeck.cardsList)
            {
                string key = c.getPictureKey();
                CARD_PICTURES.Add(key, Kortti.GetPictureResx(key));
            }
            playDeck.fillDeck();
            playDeck.fillDeck();
            playDeck.fillDeck();
            playDeck.fillDeck();
            calculateOddsDeck.fillDeck();
            label1peite.Visible = false;
            kortti1peite.Visible = false;
            label5.Parent = pictureBox1;
            stayOdds.Parent = pictureBox1;
            todennäköisyys.Parent = pictureBox1;
            wincount.Parent = pictureBox1;
            losscount.Parent = pictureBox1;

        }
        public void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e){}
        private void draw_Click(object sender, EventArgs e){}

        //Aloitus nappi
        private void aloita_Click(object sender, EventArgs e)
        {
            if (autoPlay != true)
            {
                play();
            }
        }
        //Nostaa kortin pelaajalle
        private void nosta_Click(object sender, EventArgs e)
        {
            draw();
        }
        private void stay_Click(object sender, EventArgs e)
        {
            pass();
        }
        //Lisää pelaajan kortin seuraavaan aukeaan labeliin
        private void updateScene()
        {
            if (autoPlay != true)
            {
                todennäköisyys.Text = string.Format("{0:0.00}", OddsCalculator.Overdraw(playerCards, calculateOddsDeck)) + "%";
                stayOdds.Text = string.Format("{0:0.00}", OddsCalculator.DealerWins(dealerCards.cardsList[1], playerCards.countPoints()) + "%");
            }


            //Lista kaikista pelaajan labeleistä.
            List<Label> playerLabels = new List<Label>
            {
                label1pelaaja,
                label2pelaaja,
                label3pelaaja,
                label4pelaaja,
                label5pelaaja,
            };
            List<Label> dealerLabels = new List<Label>
            {
                label1jakaja,
                label2jakaja,
                label3jakaja,
                label4jakaja,
                label5jakaja,
            };
            List<PictureBox> playerBoxes = new List<PictureBox>
            {
                pictureBox1pelaaja,
                pictureBox2pelaaja,
                pictureBox3pelaaja,
                pictureBox4pelaaja,
                pictureBox5pelaaja,
            };
            List<PictureBox> dealerBoxes = new List<PictureBox>
            {
                pictureBox1jakaja,
                pictureBox2jakaja,
                pictureBox3jakaja,
                pictureBox4jakaja,
                pictureBox5jakaja,
            };

            pisteetjakaja.Text = "Jakajan pisteet: " + dealerCards.countPoints().ToString();
            pisteetpelaaja.Text = "Pelaajan pisteet: " + playerCards.countPoints().ToString();
            renderCards(playerLabels, playerBoxes, playerCards.cardsList);
            renderCards(dealerLabels, dealerBoxes, dealerCards.cardsList);
        }
        private void renderCards (List<Label> labels, List<PictureBox> boxes, List<Kortti> cards)
        {
            //Enumerator
            IEnumerator enumerator = cards.GetEnumerator();
            IEnumerator enumeratorBoxes = boxes.GetEnumerator();
            foreach (Label L in labels)
            {
                Kortti c = enumerator.MoveNext()
                    ? (Kortti)enumerator.Current : null;
                PictureBox pb = enumeratorBoxes.MoveNext()
                   ? (PictureBox)enumeratorBoxes.Current : null;
                if (c != null)
                {
                    L.Text = (c.value.ToString() + " " + c.Suite);
                    pb.Image = Kortti.GetPictureResx(c.getPictureKey());
                }
                else
                {
                    L.Text = "";
                    pb.Image = null;
                }
            }
        }
        //reset funktio
        private void reset()
        {
            if (autoPlay)
            {
                updateScene();
            }

            kortti1peite.Visible = false;
            label1jakaja.Visible = true;
            label1peite.Visible = false;
            pisteetjakaja.Visible = true;
            autoOFF.Visible = true;
            autoON.Visible = true;
            numericUpDown1.Visible = true;
            //Tyhjentää pelaajan ja jakajan kortit
            playerCards.cardsList.Clear();
            dealerCards.cardsList.Clear();

            //Tekee updateScene funktion, joka tässä tapauksessa
            //Paljastaa aloitus napin ja piilottaa muut
            aloita.Visible = true;
            nosta.Visible = false;
            stay.Visible = false;
            if (playDeck.cardsList.Count <= 110)
            {
                playDeck.cardsList.Clear();
                playDeck.fillDeck();
                playDeck.fillDeck();
                playDeck.fillDeck();
                playDeck.fillDeck();
                playDeck.fillDeck();
            }
            wincount.Text = "Voitot: " + voitot;
            losscount.Text = "Häviöt: " + häviöt;
        }


        //Voitto funktio
        private void voitto()
        {
            label1.Visible = true;
            //Asettaa voitto
            voitot += 1;
            //Asettaa 'Voitto/Häviö' labeliin "Voitit pelin" tekstin.
            label1.Text = "Voitit pelin";
            if (autoPlay == false)
            {
                //Pelaaja saa message box ilmoituksen "Voitit pelin!"
                MessageBox.Show("Voitit pelin!");
            }
            //tekee reset funktion
            reset();
        }


        //Häviö funktio
        private void häviö()
        {
            label1.Visible = true;
            //Asettaa häviö muuttujan
            häviöt += 1;
            //Asettaa 'Voitto/Häviö' labelin punaiseksi.
            label1.ForeColor = Color.Red;
            //Asettaa 'Voitto/Häviö' labeliin "Hävisit pelin" tekstin.
            label1.Text = "Hävisit pelin";
            if (autoPlay == false)
            {
                //Pelaaja saa message box ilmoituksen "Hävisit pelin!"
                MessageBox.Show("Hävisit pelin!");
            }
            //tekee reset funktion
            reset();
        }

        private void autoON_Click(object sender, EventArgs e)
        {
            if (autoPlay != true)
            {
                autoPlay = true;
                timer = new System.Timers.Timer((double)numericUpDown1.Value);
                timer.Elapsed += autoPlayTimerEvent;
                timer.AutoReset = true;
                timer.Enabled = true;
            }
        }
        private void autoPlayTimerEvent(Object source, ElapsedEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                play();
            }));
            //Tekee updateScene metodin.
            if (!autoPlay)
            {
                updateScene();
            }
        }
        private void play()
        {
            label1.Visible = false;
            //Asettaa 'voitto/häviö' labelin värin oletuksena vihreäksi.
            label1.ForeColor = Color.YellowGreen;
            //Tyhjentää 'voitto/häviö' labelin.
            label1.Text = "";
            //Piilottaa aloitus napin, ja paljastaa muut napit
            aloita.Visible = false;
            nosta.Visible = true;
            stay.Visible = true;
            kortti1peite.Visible = true;
            label1jakaja.Visible = false;
            label1peite.Visible = true;
            pisteetjakaja.Visible = false;
            autoOFF.Visible = false;
            autoON.Visible = false;
            numericUpDown1.Visible = false;

            //Valitsee yhden kortin pakasta ja tallentaa sen "temp" muuttujaan, josta se
            //annetaan jakajalle.
            Kortti temp = playDeck.pickCard();
            //lisää "temp" kortin jakajalle.
            dealerCards.cardsList.Add(temp);
            //Sama juttu
            temp = playDeck.pickCard();
            dealerCards.cardsList.Add(temp);

            //Tallentaa satunnaisen kortin "temp" muuttujaan.
            temp = playDeck.pickCard();
            //Lisää temp kortin pelaajalle.
            playerCards.cardsList.Add(temp);
            //Tallentaa satunnaisen kortin "temp" muuttujaan.
            temp = playDeck.pickCard();
            //Lisää temp kortin pelaajalle.
            playerCards.cardsList.Add(temp);

            //Tekee updateScene metodin.
            if (!autoPlay)
            {
                updateScene();
            }
            if (playerCards.countPoints() == 21)
            {
                voitto();
            }
            else if (autoPlay == true)
            {
                autoPlayHit();
            }
            if (dealerCards.countPoints() == 21)
            {
                häviö();
            }
            //Paljastaa "Häviö%" labelin
            label5.Visible = true;
        }
        private void autoPlayHit()
        {
            bool passing = false;
            while (passing == false)
            {
                if (OddsCalculator.DealerWins(dealerCards.cardsList[1], playerCards.countPoints()) < 50)
                {
                    passing = true;
                }
                else if (OddsCalculator.Overdraw(playerCards, calculateOddsDeck) < OddsCalculator.DealerWins(dealerCards.cardsList[1],playerCards.countPoints()))
                {
                    draw();
                }
                else
                {
                    passing = true;
                }
            }
            if (playerCards.countPoints() > 21)
            {
                häviö();
            }
            else
            {
                pass();
            }
        }
        private void draw()
        {
            //Tallentaa satunnaisen kortin "temp" muuttujaan.
            Kortti temp = playDeck.pickCard();
            //Lisää temp kortin pelaajalle
            playerCards.cardsList.Add(temp);
            //Tekee updateScene metodin.
            if (!autoPlay)
            {
                updateScene();
            }
            //Tarkistaa jos pelaaja meni yli 21.
            //Jos meni, tekee häviö metodin, jos tasan, voitto.
            if (playerCards.countPoints() > 21 && !autoPlay)
            { häviö(); }

            if (playerCards.countPoints() == 21 && !autoPlay)
            { voitto(); }
        }
        private void pass()
        {
            //Jos jakajan pisteet ovat alle 17,
            while (dealerCards.countPoints() <= 16)
            {
                Kortti temp = playDeck.pickCard();
                //Asettaa labeliin kortin arvon ja maan.
                label3jakaja.Text = (temp.value.ToString() + " " + temp.Suite);
                //Lisää temp kortin jakajalle
                dealerCards.cardsList.Add(temp);
                //Tekee updateScene metodin.
                if (!autoPlay)
                {
                    updateScene();
                }
            }
            //Jos jakajan pisteet ovat yli 21, pelaajaa voittaa.
            if (dealerCards.countPoints() > 21)
            { voitto(); }

            //Jos ei ollut yli 21
            else if (dealerCards.countPoints() >= playerCards.countPoints())
            {
                häviö();
            }
            else
            {
                voitto();
            }
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Normal;
            this.Focus(); this.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void wincount_Click(object sender, EventArgs e)
        {

        }

        private void losscount_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void autoOFF_Click(object sender, EventArgs e)
        {
            if(autoPlay == true)
            {
                timer.Enabled = false;
                timer.Stop();
                timer = null;
            }
            autoPlay = false;
            häviö();
            häviöt -= 1;
        }
    }
}