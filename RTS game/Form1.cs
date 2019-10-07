using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace RTS_game
{
    public partial class Form1 : Form
    {

        private int timertracker;
       
        Map mp;
        
 
        public Form1()
        {
            InitializeComponent();
           
        }

        

      public void lblMAP_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblRes.Visible = true;
            

        }
    //creating method for display
       

        private void curROUND_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mapgrp_Enter(object sender, EventArgs e)
        {
           
        }

        private  void btnSTART_Click(object sender, EventArgs e)
        {
            
           // Update(Mapgrp);

            
            
            Map map = new Map(20, infotxt);
            map.Generate();
            map.Display(Mapgrp);
           // map.displayBuildings(Mapgrp);
            
            

          

            
            

           

            




        }

        private void btnPAUSE_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        //int seconds = 0;
       // int minutes = 0;
       // int count;
       


        // trying to stop timer at a certian number so rounds can stop and as a result resorce genaration stops
        // BUT IT JUST WONT
       
      

       

        private void infotxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblResorces_Click(object sender, EventArgs e)
        {
            
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void resourcegrp_Click(object sender, EventArgs e)
        {
           

        }

        // updates text for resources lable when clicked
       

        private void lblROUND_Click(object sender, EventArgs e)
        {

        }

        private void BTNREAD_Click(object sender, EventArgs e)
        {
            
            mp.readmap();
        }
    }
                
    }
    



