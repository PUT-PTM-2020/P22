using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ptm_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Data", typeof(string));
            table.Columns.Add("Godzina", typeof(string));
            table.Columns.Add("Fotografia", typeof(string));

            dataGridView1.DataSource = table;
        }

        bool isListeningIncidents = false;
        bool IfListeningIncidents(bool isListeningIncidents)
        {
            if (isListeningIncidents == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        IncidentSearcher searcher = new IncidentSearcher();

        private void button1_Click(object sender, EventArgs e)
        {
                Console.WriteLine("clicked uruchom - listenIncidents running");
                isListeningIncidents = true;
                while (IfListeningIncidents(isListeningIncidents) != false)
                { 
                    Console.WriteLine("....listen incidents....\n");
                    
                if (searcher.isIncidentFound() == true || IfListeningIncidents(isListeningIncidents) == false)
                {

                    break;
                }
                Console.WriteLine("....listen incidents....still running...\n");
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked *zatrzymaj*");
            isListeningIncidents = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked *odśwież*");

            if (File.Exists(@"incidents.txt"))
            {
                table.Clear();
                string[] lines = File.ReadAllLines(@"incidents.txt");
                string[] values;

                for (int i = 0; i < lines.Length; i++)
                {
                    values = lines[i].ToString().Split();
                    string[] row = new string[values.Length];

                    for (int j = 0; j < values.Length; j++)
                    {
                        row[j] = values[j].Trim();
                        
                        if (j == 3)
                        {
                            
                        }
                    }
                    

                    table.Rows.Add(row);
                }
            }
            else
            {
                string messageInfo = "Nie znaleziono żadnych incydentów.";
                string titleInfo = "Info";
                MessageBox.Show(messageInfo, titleInfo);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked *informacje*");
            string messaageInfo = "Projekt Fotopułapki wykonany na zajęcia z przedmiotu Podstawy Techniki Mikroprocesorowej.\n\n Autorzy:\n  Patryk Miedziaszczyk, Szymon Kiszka";
            string titleInfo = "Informacje o programie";
            MessageBox.Show(messaageInfo, titleInfo);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddButtonColumn()
        {
            DataGridViewButtonColumn buttons = new DataGridViewButtonColumn();
            {
                buttons.HeaderText = "Wyświetl";
                buttons.Text = "Wyświetl";
                buttons.UseColumnTextForButtonValue = true;
                buttons.AutoSizeMode =
                
                DataGridViewAutoSizeColumnMode.AllCells;
                buttons.FlatStyle = FlatStyle.Standard;
                buttons.CellTemplate.Style.BackColor = Color.Honeydew;
                buttons.DisplayIndex = 0;
            }

            dataGridView1.Columns.Add(buttons);
        }
     

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
