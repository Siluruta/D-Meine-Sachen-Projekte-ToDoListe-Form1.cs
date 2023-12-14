using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ToBuyList
{
    public partial class ToBuyList : Form
    {
        public ToBuyList()
        {
            InitializeComponent();

            BackColor = Color.DarkCyan;
            ListBox.BackColor = Color.Beige;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime ausgewähltesDatum = dateTimePicker1.Value;
        }

        public void buttonadd_Click(object sender, EventArgs e)
        {
            string TextToAdd = textboxprojekt.Text;
            string TextToAdd1 = textboxname.Text;
            string TextToAdd2 = textboxpreis.Text;
            string TextToAdd3 = textboxlink.Text;
            string TextToAdd4 = textboxdatum.Text;
            string TextToAdd5 = textboxpriorität.Text;



            if (!string.IsNullOrWhiteSpace(TextToAdd))
            {
                textboxprojekt.Clear();
            }
            //else
            {
                //   ListBox.Items.Add("");
            }


            if (!string.IsNullOrWhiteSpace(TextToAdd1))
            {
                textboxname.Clear();
            }
            //else
            //{
            //    ListBox.Items.Add("");
            //}

            if (!string.IsNullOrWhiteSpace(TextToAdd2))
            {
                textboxpreis.Clear();
            }
            //else
            //{
            //    ListBox.Items.Add("");
            //}

            if (!string.IsNullOrWhiteSpace(TextToAdd3))
            {
                textboxlink.Clear();
            }
            //else
            //{
            //    ListBox.Items.Add("");
            //}

            if (!string.IsNullOrWhiteSpace(TextToAdd4))
            {
                textboxdatum.Clear();
            }
            //else
            //{
            //    ListBox.Items.Add("");
            //}

            if (!string.IsNullOrWhiteSpace(TextToAdd5))
            {
                textboxpriorität.Clear();
            }
            //else
            //{
            //    ListBox.Items.Add("");
            //}



            if (string.IsNullOrEmpty(TextToAdd))
            {
                TextToAdd = "projektistleer";
            }
            if (string.IsNullOrEmpty(TextToAdd1))
            {
                TextToAdd1 = "nameistleer";
            }
            if (string.IsNullOrEmpty(TextToAdd2))
            {
                TextToAdd2 = "preisistleer";
            }
            if (string.IsNullOrEmpty(TextToAdd3))
            {
                TextToAdd3 = "linkistleer";
            }
            if (string.IsNullOrEmpty(TextToAdd4))
            {
                TextToAdd4 = "datumistleer";
            }

            ListBox.Font = new Font("Arial", 16, FontStyle.Regular);

            ListBox.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            ListBox.Items.Add(string.Concat(" | ", ("PROJEKTNAME: ") + TextToAdd.ToString(), " | ", ("NAME: ") + TextToAdd1.ToString(), " | ", ("PREIS: ") + TextToAdd2.ToString(), " | ", ("LINK: ") + TextToAdd3.ToString(), " | ", ("DATUM: ") + TextToAdd4.ToString(), " | "));
            ListBox.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ListBox Count: " + ListBox.Items.Count);

            for (int i = ListBox.Items.Count; i <= ListBox.Items.Count; i--)
            {
                if (i == ListBox.Items.Count - 3)
                    break;
                ListBox.Items.RemoveAt(i - 1);
            }

            //int countToDelete = Math.Min(3, ListBox.Items.Count);

            //for (int i = 0; i < countToDelete; i++)
            //{
            //    ListBox.Items.RemoveAt(0);
            //}
        }
    }
}
