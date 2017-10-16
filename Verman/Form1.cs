using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            encrypt(tboxEncrypt.Text);
        }

        private void encrypt(string input)
        {
            List<string> binary = new List<string>();
            List<string> key;
            List<string> xor;
            byte[] ascii = Encoding.ASCII.GetBytes(input);

            for (int i = 0; i < ascii.Length; i++)
            {
                binary.Add(toBinary(ascii[i],7));
            }

            key = generateKey(binary.Count);

            tboxKey.Text = listToString(key);

            xor = xorLists(binary, key);
            
            

            tboxOut.Text = listToString(xor);

        }

        private void decrypt(string input, string key)
        {
            List<string> inputList = stringToList(input);
            List<string> inputKey = stringToList(key);
            List<string> xor = xorLists(inputList, inputKey);
            string output = string.Empty;

            output = listBinToString(xor);

            tboxOut.Text = output;
        }

        /*
        private string keyToString(List<string> key)
        {



            return 
        }
        */

        private string binToString(string bin)
        {
            string output = string.Empty;

            byte[] bytes = new byte[1];
            bytes[0] = Convert.ToByte(bin, 2);
            output += (Encoding.ASCII.GetString(bytes));

            return output;
        }


        private string listBinToString(List<string> bin)
        {

            string output = string.Empty;

            foreach(string binary in bin)
            {
                byte[] bytes = new byte[1];
                bytes[0] = Convert.ToByte(binary, 2);
                output += (Encoding.ASCII.GetString(bytes));
            }

            return output;
        }
        
        private List<string> stringToList(string str)
        {
            List<string> output = new List<string>();

            for(int i = 0; i < str.Length; i+= 7)
            {
                string sub = str.Substring(i, 7);
                output.Add(sub);
            }

            return output;
        }

        private string listToString(List<string> list)
        {
            string output = string.Empty;

            foreach (string str in list)
            {
                output += str;
            }

            return output;
        }

        private List<string> xorLists(List<string> binary, List<string> key)
        {

            List<string> xor = new List<string>();

            for(int i = 0; i < binary.Count; i++)
            {
                string curBinary = binary[i];
                string curKey = key[i];
                string curXor = string.Empty;

                for (int j = 0; j < curBinary.Length; j++)
                {
                    char binBit = curBinary[j];
                    char binKey = curKey[j];

                    if (binBit != binKey)
                    {
                        curXor += "1";
                    }
                    else
                    {
                        curXor += "0";
                    }
                }

                xor.Add(curXor);
            }
            
            return xor;
        }

        private List<string> generateKey(int maxlength)
        {
            Random rnd = new Random();
            List<string> ascii = new List<string>();

            for (int i = 0; i < maxlength; i++)
            {
                string randomAscii = toBinary(rnd.Next(97, 123));

                ascii.Add(randomAscii);
            }

            ascii.Reverse();

            return ascii;

        }
        
        private string toBinary(int decimalNumber)
        {
            int remainder;
            string binaryStr = string.Empty;
            List<int> binary = new List<int>();

            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                binary.Add(remainder);
                decimalNumber = decimalNumber / 2;
            }

            binary.Reverse();

            foreach(int i in binary)
            {
                binaryStr = binaryStr + Convert.ToString(i);
            }

            return binaryStr;
        }

        private string toBinary(int decimalNumber, int paddingLength)
        {
            int remainder;
            string binaryStr = string.Empty;
            List<int> binary = new List<int>();

            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                binary.Add(remainder);
                decimalNumber = decimalNumber / 2;
            }

            if(binary.Count != paddingLength)
            {
                int padding = paddingLength - binary.Count;
                for(int i = 0; i < padding; i++)
                {
                    binary.Add(0);
                }
            }

            binary.Reverse();

            foreach (int i in binary)
            {
                binaryStr = binaryStr + Convert.ToString(i);
            }

            return binaryStr;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            decrypt(tboxEncrypt.Text, tboxKey.Text);
        }
    }
}

