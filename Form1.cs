using System.Text;
using System.IO;
using System;
using System.Diagnostics;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace LUW_extractor
{


    public partial class Form1 : Form
    {
        public int counter;
        public string cijelitext;
        public string path2;
        
        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName+".pdf";
                label1.Text = openFileDialog.FileName;
                counter = 0;
                cijelitext = "";

                string path2 = openFileDialog.FileName + ".pdf";

                using (StreamReader reader = new StreamReader(label1.Text))
                {
                    string line;
                    StringBuilder stringBuilder = new StringBuilder();
                    while ((line = reader.ReadLine()) != null)
                    {
                        stringBuilder.Append(line);
                        //| Line-No: 00000001
                        if (line.Contains("Line-No: 00000001"))
                        {
                            Console.WriteLine("Line-No: 00000001");
                            //MessageBox.Show("Line-No: 00000001");
                            counter++;
                        }
                        if (counter > 1)
                        {
                            if (line.Contains("binary"))
                            {
                                cijelitext = cijelitext + line.Substring(31, 80);
                            }
                        }
                    }

                    richTextBox1.Text = stringBuilder.ToString();
                    button2.Enabled = true;
                }
            }


        }





        private void button2_Click(object sender, EventArgs e)
        {
            path2 = textBox1.Text;
            File.WriteAllBytes(path2, StringToByteArray(cijelitext.Replace(" ", String.Empty)));
             if (MessageBox.Show(
    "The file is saved at the following location:\n" + path2 +"\nOPEN?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk
) == DialogResult.Yes)
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = @path2;
                psi.UseShellExecute = true;
                Process.Start(psi);
            }
        }
    }
}