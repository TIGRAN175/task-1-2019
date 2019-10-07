using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RTS_game
{
    [Serializable]
    public class Map
    {


        //Create constants in the “Map class”   (research what a constant is)

        List<UNIT> units = new List<UNIT>();
        
        Random r = new Random();
        int numUnits = 0;
        TextBox Infotxt;

        public List<UNIT> Units
        {
            get { return units; }
            set { units = value; }
        }

       

        public Map(int n, TextBox txt)
        {
            numUnits = n;
            Infotxt = txt;
        }


      


        

        public void Generate()
        {
            for (int i = 0; i < numUnits; i++)
            {
                if (r.Next(0, 2) == 0) //Generate MeleeUnit
                {
                    MeleeUnit m = new MeleeUnit(r.Next(0, 20),
                                                r.Next(0, 20),
                                                100,
                                                50,
                                                10,
                                                10,

                                                (i % 2 == 0 ? 1 : 0),
                                                "M",
                                                  ///unit name added to constructers Uname
                                                  "knight");
                    units.Add(m);
                }
                else //Generate RangedUnit
                {
                    RangedUnit ru = new RangedUnit(r.Next(0, 20),
                                                   r.Next(0, 20),
                                                   100,
                                                   1,
                                                   20,
                                                   5,
                                                   (i % 2 == 0 ? 1 : 0),
                                                   "R",
                                                    ///unit name added to constructers Uname
                                                    "archer");
                    units.Add(ru);

                }
               
                




            }

        }



        



        public void Display(GroupBox groupBox)
        {
            groupBox.Controls.Clear();
            foreach (UNIT u in units)
            {
                Button b = new Button();
                if (u is MeleeUnit)
                {
                    MeleeUnit mu = (MeleeUnit)u;
                    mu.Symbol = "M";
                    b.Size = new Size(20, 20);
                    b.Location = new Point(mu.Xpos * 20, mu.Ypos * 20);
                    b.Text = mu.Symbol;


                    if (mu.Faction == 0)
                    {
                        b.ForeColor = Color.Red;
                    }
                    else
                    {
                        b.ForeColor = Color.Green;
                    }

                }
                else
                {
                    RangedUnit ru = (RangedUnit)u;
                    ru.Symbol = "R.";
                    b.Size = new Size(20, 20);
                    b.Location = new Point(ru.Xpos * 20, ru.Ypos * 20);
                    b.Text = ru.Symbol;

                    if (ru.Faction == 0)
                    {
                        b.ForeColor = Color.Red;
                    }
                    else
                    {
                        b.ForeColor = Color.Green;
                    }



                    {

                        b.Click += Unit_Click;
                        groupBox.Controls.Add(b);






                    }
                }

            }
        }
        public void Unit_Click(object sender, EventArgs e)
        {
            int x, y;
            Button b = (Button)sender;
            x = b.Location.X / 20;
            y = b.Location.Y / 20;
            foreach (UNIT u in units)
            {
                if (u is RangedUnit)
                {
                    RangedUnit ru = (RangedUnit)u;    // ranged unit
                    if (ru.Xpos == x && ru.Ypos == y)
                    {
                        Infotxt.Text = "R";
                        Infotxt.Text = ru.ToString();
                    }
                    else if (u is MeleeUnit)
                    {
                        MeleeUnit mu = (MeleeUnit)u;      //melee unit
                        if (mu.Xpos == x && mu.Ypos == y)
                        {
                            Infotxt.Text = "M";
                            Infotxt.Text = mu.ToString();
                        }

                    }

                   


                }
            }
        }
    }
}

        
    

            
        









