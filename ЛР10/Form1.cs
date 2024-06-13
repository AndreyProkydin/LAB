using System;
using System.Numerics; // Для работы с BigInteger
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Org.BouncyCastle.Crypto.Digests;

namespace lab10_1
{
    public partial class Form1 : Form
    {
        Thread thread1;
        Thread thread2;
        Thread thread3;

        public Form1()
        {
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button3.Click += new System.EventHandler(this.button3_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            thread1 = new Thread(new ThreadStart(MadrygaEncryption));
            thread1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            thread2 = new Thread(new ThreadStart(MD4Hashing));
            thread2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            thread3 = new Thread(new ThreadStart(RabinEncryption));
            thread3.Start();
        }

        private void MadrygaEncryption()
        {
            try
            {
                string plainText = "Some plain text for MADRYGA";
                string key = "MADRYGA_KEY_128"; 
                string encryptedText = MadrygaEncrypt(plainText, key);

                richTextBox1.Invoke((MethodInvoker)delegate
                {
                    richTextBox1.Text += $"MADRYGA Encrypted: {encryptedText}\n";
                });
            }
            catch (Exception ex)
            {
                richTextBox1.Invoke((MethodInvoker)delegate
                {
                    richTextBox1.Text += $"MADRYGA Error: {ex.Message}\n";
                });
            }
        }

        private void MD4Hashing()
        {
            try
            {
                string data = "Some data to hash with MD-4";
                string hash = ComputeMD4Hash(data);

                richTextBox1.Invoke((MethodInvoker)delegate
                {
                    richTextBox1.Text += $"MD-4 Hash: {hash}\n";
                });
            }
            catch (Exception ex)
            {
                richTextBox1.Invoke((MethodInvoker)delegate
                {
                    richTextBox1.Text += $"MD-4 Error: {ex.Message}\n";
                });
            }
        }

        private void RabinEncryption()
        {
            try
            {
                
                BigInteger p = 139;
                BigInteger q = 149;
                BigInteger n = p * q;
                string plainText = "Hello, Rabin!";

             
                BigInteger m = new BigInteger(Encoding.UTF8.GetBytes(plainText));

             
                BigInteger encrypted = RabinEncrypt(m, n);

                richTextBox1.Invoke((MethodInvoker)delegate
                {
                    richTextBox1.Text += $"Rabin Encrypted: {encrypted}\n";
                });
            }
            catch (Exception ex)
            {
                richTextBox1.Invoke((MethodInvoker)delegate
                {
                    richTextBox1.Text += $"Rabin Error: {ex.Message}\n";
                });
            }
        }

       
        private string MadrygaEncrypt(string plainText, string key)
        {
           
            byte[] data = Encoding.UTF8.GetBytes(plainText);
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] encrypted = new byte[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                encrypted[i] = (byte)(data[i] ^ keyBytes[i % keyBytes.Length]); 
            }

            return Convert.ToBase64String(encrypted); 
        }


        private string ComputeMD4Hash(string input)
        {
            MD4Digest md4 = new MD4Digest(); 
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            md4.BlockUpdate(inputBytes, 0, inputBytes.Length);
            byte[] result = new byte[md4.GetDigestSize()];
            md4.DoFinal(result, 0);
            return BitConverter.ToString(result).Replace("-", "").ToLower();
        }


        private BigInteger RabinEncrypt(BigInteger m, BigInteger n)
        {
           
            return BigInteger.ModPow(m, 2, n);
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            thread1?.Abort();
            thread2?.Abort();
            thread3?.Abort();
        }
    }
}
