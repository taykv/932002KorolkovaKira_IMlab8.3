using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8randomevents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] probT, probEx;
        int N; 
        int[] stat;
		double a;
		Random R = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            probT = new double[5]; 
            probEx = new double[5];  
            stat = new int[5];
            N = (int)tbN.Value;
            probT[0] = (double)tbpr1.Value; 
            probT[1] = (double)tbpr2.Value; 
            probT[2] = (double)tbpr3.Value;
            probT[3] = (double)tbpr4.Value; 
            probT[4] = 1; 

            
            for (int i = 0; i < 4; i++) probT[4] -= probT[i]; 
            
            tbpr7.Text = probT[4].ToString();

            for (int i = 0; i < N; i++) 
            {
                a = R.NextDouble();
                double summ = 0;
                
                for (int k = 0; k < 5; k++) 
                {
                    summ += probT[k];

                    if (a <= summ) 
                    { 
                        stat[k]++; 
                        break; 
                    }
                }
            }

            for(int i = 0; i < 5; i++) 
            {
                probEx[i] = stat[i] / (double)N;
            }

            chart1.Series[0].Points.Clear();       
            for (int i = 0; i < 5; i++) chart1.Series[0].Points.AddXY(i+1, probEx[i]);
        } 
    }
}
