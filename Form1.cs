using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominos_Pizzaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal ucret = 0;
            string ekstra = "";
            
            if(chkkavurma.Checked==true)
            {
                ekstra += "kavurma";
                ucret = 4;
                
            }
            else if(chkkasar.Checked==true)
            {
                ekstra += "" + "kasar";
                ucret = 4;
            }
            else if(chkmantar.Checked==true)
            {
                ekstra += "" + "mantar";
                ucret = 4;
            }
            else if(chkmısır.Checked==true)
            {
                ekstra += "" + "mısır";
                ucret = 4;
            }
            else if(chkpeynir.Checked==true)
            {
                ekstra += "" + "peynir";
                ucret = 4;
            }
            else if(chksosis.Checked==true)
            {
                ekstra += "" + "sosis";
                ucret = 4;

            }
            else if(chksucuk.Checked==true)
            {
                ekstra += "" + "sucuk";
                ucret = 4;

            }
            else if(chkzeytin.Checked==true)
            {
                ekstra += "" + "zeytin";
                ucret = 4;

            }

            if (cmbpizzaboy.Text == "Küçük")
            {
                ucret += nmrpizzaadet.Value * 10;  
            }
            else if (cmbpizzaboy.Text== "orta")
            {
                ucret += nmrpizzaadet.Value * 20;
            }
            else if(cmbpizzaboy.Text=="büyük")
            {
                ucret += nmrpizzaadet.Value * 30;
            }

            if(cmbicecekler.Text=="2.5lt Coca Cola")
            {
                ucret += nmricecekadet.Value * 18;
            }
            else if(cmbicecekler.Text=="2lt Fanta")
            {
                ucret += nmricecekadet.Value * 16;
            }
            else if(cmbicecekler.Text=="2lt Sprite")
            {
                ucret += nmricecekadet.Value * 15;
            }

            if(cmbhamurşekli.Text=="İnce")
            {
                ucret += nmrhamurşekliadet.Value * 1;
            }

            else if(cmbhamurşekli.Text=="Normal")
            {
                ucret += nmrhamurşekliadet.Value * 2;

            }

            else if(cmbhamurşekli.Text=="Kalın")
            {
                ucret += nmrhamurşekliadet.Value * 5;
            }

            listadsoyad.Items.Add(textadsoyad);
            listtelno.Items.Add(texttelefon);
            listadres.Items.Add(textadres);
            listboyadet.Items.Add("Adet"+nmrpizzaadet.Value+"Boyut"+cmbpizzaboy.Text);
            listekstra.Items.Add(ekstra);
            listiçecekadet.Items.Add("Adet" + nmricecekadet.Value + cmbicecekler.Text);
            listhamurşekli.Items.Add("Adet" + nmrhamurşekliadet.Value + cmbhamurşekli.Text);
            listücret.Items.Add(ucret+"TL");



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbpizzaboy.Items.Add("Küçük");
            cmbpizzaboy.Items.Add("Orta");
            cmbpizzaboy.Items.Add("Büyük");

            cmbicecekler.Items.Add("2.5lt Coca Cola");
            cmbicecekler.Items.Add("2lt Fanta");
            cmbicecekler.Items.Add("2lt Sprite");

            cmbhamurşekli.Items.Add("İnce");
            cmbhamurşekli.Items.Add("Normal");
            cmbhamurşekli.Items.Add("Kalın");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textadsoyad.Text = "";
            textadres.Text = "";
            texttelefon.Text = "";
            cmbicecekler.Text = "";
            cmbhamurşekli.Text = "";
            cmbpizzaboy.Text = "";
            nmrhamurşekliadet.Value = 0;
            nmricecekadet.Value = 0;
            nmrpizzaadet.Value = 0;
            chkkasar.Checked = false;
            chkkavurma.Checked = false;
            chkmantar.Checked = false;
            chkmısır.Checked = false;
            chkpeynir.Checked = false;
            chksosis.Checked = false;
            chksucuk.Checked = false;
            chkzeytin.Checked = false;
            listadres.Items.Clear();
            listadsoyad.Items.Clear();
            listboyadet.Items.Clear();
            listekstra.Items.Clear();
            listhamurşekli.Items.Clear();
            listiçecekadet.Items.Clear();
            listtelno.Items.Clear();
            listücret.Items.Clear();





        }

        private void button3_Click(object sender, EventArgs e)
        {
            textadsoyad.Text = "";
            textadres.Text = "";
            texttelefon.Text = "";
            cmbicecekler.Text = "";
            cmbhamurşekli.Text = "";
            cmbpizzaboy.Text = "";
            nmrhamurşekliadet.Value = 0;
            nmricecekadet.Value = 0;
            nmrpizzaadet.Value = 0;
            chkkasar.Checked = false;
            chkkavurma.Checked = false;
            chkmantar.Checked = false;
            chkmısır.Checked = false;
            chkpeynir.Checked = false;
            chksosis.Checked = false;
            chksucuk.Checked = false;
            chkzeytin.Checked = false;
        }

        private void textadres_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
