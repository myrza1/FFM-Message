using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFM_Message
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line;


            line = textBox1.Text;

            int dot2 = getSpecifiedIndexOf(line, '.', line.IndexOf(".") + 1);
            int dot3 = getSpecifiedIndexOf(line, '.', dot2);
            int dot4 = getSpecifiedIndexOf(line, '.', dot3);

            textBox2.Text = line.Substring(0, line.IndexOf("/"));
            textBox3.Text = line.Substring(line.IndexOf(".") + 1, dot2 - line.IndexOf(".") - 1);
            textBox4.Text = line.Substring(dot2 + 1, dot3 - dot2 - 1);
            textBox5.Text = line.Substring(dot3 + 1, line.Length - dot3 - 1);
        }

        public static int getSpecifiedIndexOf(string str, char ch, int index)
        {
            int i = 0, o = 1;
            while ((i = str.IndexOf(ch, i)) != -1)
            {
                if (i > index) return i;
                o++;
                i++;
            }
            return 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string stinfff;
            int bir = 0;
            int totalIndexx = 0;
            stinfff = textBox1.Text;
            FFM ffME = new FFM();
            string[] split = stinfff.Split('/');
            ffME.MessageSequenceNumber = 0;
            foreach (string s in split)
            {
                if (s.Trim() != "")
                {
                    if (ffME.Registration == null & bir == 4)
                    {
                        ffME.Registration = s;
                        bir = 5;
                    }

                    if (ffME.Destrination == null & bir == 3)
                    {
                        ffME.Destrination = s;
                        bir = 4;
                    }

                    if (ffME.DayOfOperation == 0 & bir == 2)
                    {
                        ffME.DayOfOperation = Convert.ToInt32(s.Substring(0,2));
                        ffME.MonthOfOperation = s.Substring(2, 3);
                        if (s.Length == 9) ffME.TimeOfScheduledDeparture = s.Substring(5, 4); else ffME.TimeOfScheduledDeparture = "";
                        bir = 3;
                    }

                    if (ffME.FlightIdentifier == null & bir == 1)
                    {
                        ffME.FlightIdentifier = s;
                        bir = 2;
                    }

                    if (ffME.MessageSequenceNumber == 0)
                    {
                        ffME.MessageSequenceNumber = Convert.ToInt32(s);
                        bir = 1;
                    }        

                    Console.WriteLine(s);

                }
            }
            textBox2.Text = ffME.MessageSequenceNumber.ToString();
            textBox3.Text = ffME.FlightIdentifier;
            textBox4.Text = ffME.DayOfOperation.ToString();
            textBox5.Text = ffME.MonthOfOperation.ToString();
            textBox6.Text = ffME.TimeOfScheduledDeparture.ToString();
            textBox7.Text = ffME.Destrination.ToString();
            textBox8.Text = ffME.Registration.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string stinfff;
            int bir = 0;
            bool allCharactersInStringAreDigits;
            int totalIndexx = 0;
            stinfff = textBox9.Text;
            FFM ffME = new FFM();
            string[] split = stinfff.Split('/');
            ffME.MessageSequenceNumber = 0;
            foreach (string s in split)
            {
                if (s.Trim() != "")
                {
                    if (ffME.Goods == null & bir == 2)
                    {
                        ffME.Goods = s;                        
                        bir = 3;
                    }

                    if (ffME.ShipmentDescriptionCode == null & bir == 1)
                    {
                        
                        string[] w = SplitWords(s);
                        foreach (string ss in w)
                        {
                            ffME.ShipmentDescriptionCode = w[1];
                            ffME.Pieces = w[2];
                            ffME.WeightCode = w[3];
                            ffME.Weight = w[4];
                            ffME.VolumeCode = w[5];
                            ffME.Volume = w[6];
                            Console.WriteLine(s);
                        }
                        bir = 2;
                    }

                    if (ffME.AirlineAWBIdentification == null)
                    {
                        ffME.AirlineAWBIdentification = s.Substring(0, 3);
                        ffME.AwbSerialNumber = s.Substring(4, 8);
                        ffME.AwbOrigin = s.Substring(12, 3);
                        ffME.AwbDestination = s.Substring(15, 3);
                        bir = 1;
                    }

                    Console.WriteLine(s);
                }
            }

            textBox10.Text = ffME.AirlineAWBIdentification.ToString();
            textBox11.Text = ffME.AwbSerialNumber.ToString();
            textBox12.Text = ffME.AwbOrigin.ToString();
            textBox13.Text = ffME.AwbDestination.ToString();
            textBox14.Text = ffME.ShipmentDescriptionCode.ToString();
            textBox15.Text = ffME.Pieces.ToString();
            textBox16.Text = ffME.WeightCode.ToString();
            textBox17.Text = ffME.Weight.ToString();
            textBox18.Text = ffME.VolumeCode.ToString();
            textBox19.Text = ffME.Volume.ToString();
            textBox21.Text = ffME.Goods.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string stinfff = textBox23.Text;
            string[] w = SplitWords(stinfff);
            foreach (string s in w)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();


        }
        static string[] SplitWords(string s)
        {
            //
            // Split on all non-word characters.
            // ... Returns an array of all the words.
            //
            return Regex.Split(s, @"(\w)(\d+)(\w)(\d*\.?\d+)(\w\w)(\P{Sc}+)", RegexOptions.Compiled);
            // @      special verbatim string syntax
            // \W+    one or more non-word characters together
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string[]> lst = new List<string[]>();
            textBox20.Text = richTextBox1.Lines[1].ToString();
            string currsar = "";

            
           
                
           
            
        }
    }
}
