using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t2b
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            // Convert the text to a byte array using ASCII encoding
            byte[] bytes = Encoding.UTF8.GetBytes(text);

            // Convert each byte to a binary string and concatenate them
            string binary = "";
            foreach (byte b in bytes)
            {
                binary += Convert.ToString(b, 2).PadLeft(8, '0');
            }

            // Display the binary string in the texbox2
            textBox2.Text = binary;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string result = "";

            byte[] bytes = Encoding.UTF8.GetBytes(text);
            StringBuilder sb = new StringBuilder();

            foreach (byte b in bytes)
            {
                sb.Append(b.ToString("X2"));
            }

            result = sb.ToString();
           textBox2.Text = result;
            //string txt = textBox1.Text;
            //StringBuilder sb = new StringBuilder();
            //foreach(char b in txt.ToArray())
            //{
            //    sb.Append(Convert.ToString(b, 16).PadLeft(2, '0'));
            //} textBox2.Text= sb.ToString();
            /* textBox2.Clear();
                        string text = textBox1.Text;
                        string hx = "";
                        // Convert the text to a byte array using ASCII encoding
                        byte[] bytes = Encoding.ASCII.GetBytes(text);

                        // Convert the byte array to a hexadecimal string
                        //##string hexString = BitConverter.ToString(bytes);
                        foreach (byte b in bytes)
                        {
                            hx += Convert.ToString(b, 16).PadLeft(2, '0');
                        }
                        // Display the hexadecimal string in the label
                        textBox2.Text = hx;

                         */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Get the text from the text box
            string text = textBox1.Text;

            // Convert the text to a byte array using ASCII encoding
            byte[] bytes = Encoding.ASCII.GetBytes(text);

            // Convert the byte array to a decimal string
            string decimalString = string.Join(" ", bytes);

            // Display the decimal string in the label
            textBox2.Text = decimalString;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string text = textBox1.Text;

            // Convert the text to a byte array using ASCII encoding
            byte[] bytes = Encoding.ASCII.GetBytes(text);

            // Convert each byte to an octal string and concatenate them
            string octal = "";
            foreach (byte b in bytes)
            {
                octal += Convert.ToString(b, 8).PadLeft(3, '0');
            }

            // Display the octal string in the label
            textBox2.Text = octal;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //hexadecimal
            string hexString = textBox2.Text;
            string result = "";

            for (int i = 0; i < hexString.Length; i += 2)
            {
                string hexValue = hexString.Substring(i, 2);
                byte byteValue = Convert.ToByte(hexValue, 16);
                result += Convert.ToChar(byteValue);
            }

            textBox3.Text = result;
            ////##binary
            //            string binaryText = textBox2.Text;
            //            string result = "";

            //            for (int i = 0; i < binaryText.Length; i += 8)
            //            {
            //                string byteString = binaryText.Substring(i, 8);
            //                int byteValue = Convert.ToInt32(byteString, 2);
            //                char charValue = Convert.ToChar(byteValue);
            //                result += charValue;
            //            }

            //            textBox3.Text = result;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
