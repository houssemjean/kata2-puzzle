using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Mini_puzzle
{
    public partial class Form1 : Form
    {
        public char[] formulation = new char[8];

        public Button[] boutons = new Button[8];


        Point position1 = new Point(14, 13);
        Point position2 = new Point(120, 13);
        Point position3 = new Point(226, 13);
        Point position4 = new Point(14, 120);
        Point position5 = new Point(120, 120);
        Point position6 = new Point(226, 120);
        Point position7 = new Point(14, 225);
        Point position8 = new Point(120, 225);
        Point position9 = new Point(226, 225);

        public Point[] positions = new Point[9];


        public Form1()
        {
            
            remplirTableauPositions(positions);
            

            InitializeComponent();
            remplirTableauBoutons(boutons);
            comboBox1.SelectedItem = comboBox1.Items[0];

            #region evenement pour verification si la grille est bonne

            foreach (Button button in boutons) button.Click += new EventHandler(verifierReponse);
            button2.Click += new EventHandler(verifierReponse);
            #endregion

            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged1);

        }

        private void verifierReponse(object sender, EventArgs e)
        {
            if (buttonA.Location == position1 &&
                buttonB.Location == position2 &&
                buttonC.Location == position3 &&
                buttonD.Location == position4 &&
                buttonE.Location == position5 &&
                buttonF.Location == position6 &&
                buttonG.Location == position7 &&
                buttonH.Location == position8)
            {
                MessageBox.Show("Bravo vous avez résolu la grille");
            }
        }

        private void remplirTableauPositions(Point[] positions)
        {
            positions[0] = position1;
            positions[1] = position2;
            positions[2] = position3;
            positions[3] = position4;
            positions[4] = position5;
            positions[5] = position6;
            positions[6] = position7;
            positions[7] = position8;
            positions[8] = position9;
        }

        private void afficherBoutons(Button[] boutons, Point[] positions)
        {
            boutons[0].Location = positions[0];
            boutons[1].Location = positions[1];
            boutons[2].Location = positions[2];
            boutons[3].Location = positions[3];
            boutons[4].Location = positions[4];
            boutons[5].Location = positions[5];
            boutons[6].Location = positions[6];
            boutons[7].Location = positions[7];
            //boutons[8].Location = positions[8];
            

         
        }

        private void remplirTableau(char[] tableau) {
            tableau[0] = 'A';
            tableau[1] = 'B';
            tableau[2] = 'C';
            tableau[3] = 'D';
            tableau[4] = 'E';
            tableau[5] = 'F';
            tableau[6] = 'G';
            tableau[7] = 'H';
        }

        private void remplirTableauBoutons(Button[] boutons)
        {
            boutons[0] = buttonA;
            boutons[1] = buttonB;
            boutons[2] = buttonC;
            boutons[3] = buttonD;
            boutons[4] = buttonE;
            boutons[5] = buttonF;
            boutons[6] = buttonG;
            boutons[7] = buttonH;

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Array.Sort(positions, new Melangeur());
            Array.Sort(boutons, new Melangeur());
            afficherBoutons(boutons, positions);
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            deplacer(buttonA);
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            deplacer(buttonF);
        }

        private void deplacer(Button button)
        {
            Point a = detecterPlaceVide();
            if ((button.Location.X == a.X && (Math.Abs(button.Location.Y - a.Y) < 120)) ||
                     (Math.Abs(button.Location.X - a.X) < 120 && button.Location.Y == a.Y))//(comboBox1.SelectedItem == comboBox1.Items[0])
            {

                 button.Location = new Point((button.Location.X + a.X) / 2, (button.Location.Y + a.Y) / 2);
                Thread.Sleep(50);


                button.Location = a;
            }
            else
            {
                if ((button.Location.X == a.X && (Math.Abs(button.Location.Y -a.Y) < 120)) ||
                     (Math.Abs(button.Location.X - a.X) < 120 && button.Location.Y == a.Y))
                {
                    

                    button.Location = new Point((button.Location.X + a.X) / 2, (button.Location.Y + a.Y) / 2);
                    Thread.Sleep(50);


                    button.Location = a;
                }
            }
        }

        private Point detecterPlaceVide()
        {
            Point[] positionsDesBoutons = {
                                          boutons[0].Location,
                                          boutons[1].Location,
                                          boutons[2].Location,
                                          boutons[3].Location,
                                          boutons[4].Location,
                                          boutons[5].Location,
                                          boutons[6].Location,
                                          boutons[7].Location,

                                          };
            Point point = new Point(0,0);
            for (int i = 0; i < positions.Length; i++) {
                if (!Array.Exists(positionsDesBoutons, a => a == positions[i]))
                    point = positions[i]; 
            }
            return point;
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            deplacer(buttonB);
            
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            deplacer(buttonC);
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            deplacer(buttonD);
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            deplacer(buttonE);
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            deplacer(buttonG);
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            deplacer(buttonH);
        }

        private void sonOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Array.Sort(positions, new Melangeur());
            Array.Sort(boutons, new Melangeur());
            afficherBoutons(boutons, positions);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonA.Location = position1;
            buttonB.Location = position2;
            buttonC.Location = position3;
            buttonD.Location = position4;
            buttonE.Location = position5;
            buttonF.Location = position6;
            buttonG.Location = position7;
            buttonH.Location = position8;

        }

        private void comboBox1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            MessageBox.Show("Vous avez changé le niveau de difficulté");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }

}
