using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Z.AvtorKniga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Ime", 70);
            listView1.Columns.Add("Prezime", 70);
            listView1.Columns.Add("Godina", 70);
            listView1.Columns.Add("Klas", 70);
            listView1.Columns.Add("Makedonski jazik", 70);
            listView1.Columns.Add("Matematika", 70);
            listView1.Columns.Add("Fizicko", 70);
            listView1.Columns.Add("Objektno оrientirano programiranje", 70);
            listView1.Columns.Add("Robotika", 70);
            listView1.Columns.Add("Mikrokompijuteri", 70);
            listView1.Columns.Add("Bazi na podatoci", 70);
            listView1.Columns.Add("Mrezi", 70);

            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            ReadData(sqlite_conn);
            sqlite_conn.Close();
        }

        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source= C:\\Users\\Ucenik2\\Desktop\\SQlite\\vezba.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Problem so povrzuvanjeto so bazata");
            }
            return sqlite_conn;
        }
        void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            SQLiteConnection sqlite_conn;

            sqlite_conn = CreateConnection();
            CreateTable(sqlite_conn);
            sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = "SELECT * FROM Licnosti";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            listView1.Items.Clear();
            while (sqlite_datareader.Read())
            {

                string[] arr = new string[12];
                ListViewItem itm;

                arr[0] = sqlite_datareader.GetValue(0).ToString();
                arr[1] = sqlite_datareader.GetValue(1).ToString();
                arr[2] = sqlite_datareader.GetValue(2).ToString();
                arr[3] = sqlite_datareader.GetValue(3).ToString();
                arr[4] = sqlite_datareader.GetValue(4).ToString();
                arr[5] = sqlite_datareader.GetValue(5).ToString();
                arr[6] = sqlite_datareader.GetValue(6).ToString();
                arr[7] = sqlite_datareader.GetValue(7).ToString();
                arr[8] = sqlite_datareader.GetValue(8).ToString();
                arr[9] = sqlite_datareader.GetValue(9).ToString();
                arr[10] = sqlite_datareader.GetValue(10).ToString();
                arr[11] = sqlite_datareader.GetValue(11).ToString();
                

                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
        }
        static void CreateTable(SQLiteConnection conn)
        {

            SQLiteCommand sqlite_cmd;


            
                string createTable = "CREATE TABLE IF NOT EXISTS Licnosti (ime VARCHAR(20),prezime VARCHAR(40),godina VARCHAR(40), klas VARCHAR(40), makedonski VARCHAR(40),matematika VARCHAR(40),Fizicko VARCHAR(40),programiranje VARCHAR(40),robotika VARCHAR(40),mikrokompijuteri VARCHAR(40),bazipodatoci VARCHAR(40),mrezi VARCHAR(40))";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = createTable;
                sqlite_cmd.ExecuteNonQuery();
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            //CreateTable(sqlite_conn);

            try
            {
                SQLiteCommand cmd;
                cmd = sqlite_conn.CreateCommand();

                cmd.CommandText = @"INSERT INTO Licnosti(ime, prezime, godina, klas, makedonski, matematika, Fizicko, programiranje, robotika, mikrokompijuteri, bazipodatoci, mrezi) VALUES (@Ime, @Prezime, @Godina, @Klas, @Makedonskijazik, @Matematika, @Fizicko, @ObjektnoOrientiranoProgramiranje, @Robotika, @Mikrokompijuteri, @Bazinapodatoci, @Mrezi)";
                cmd.Parameters.AddWithValue("@Ime", tbIme.Text);
                cmd.Parameters.AddWithValue("@Prezime", tbprezime.Text);
                cmd.Parameters.AddWithValue("@Godina", tbgodina.Text);
                cmd.Parameters.AddWithValue("@Klas", tbklas.Text);
                cmd.Parameters.AddWithValue("@Makedonskijazik", tbmakedonski.Text);
                cmd.Parameters.AddWithValue("@Matematika", tbmatematika.Text);
                cmd.Parameters.AddWithValue("@Fizicko", tbfizicko.Text);
                cmd.Parameters.AddWithValue("ObjektnoOrientiranoProgramiranje", tbprogramiranje.Text);
                cmd.Parameters.AddWithValue("@Robotika", tbrobotika.Text);
                cmd.Parameters.AddWithValue("@Mikrokompijuteri", tbmikro.Text);
                cmd.Parameters.AddWithValue("Bazinapodatoci", tbbazi.Text);
                cmd.Parameters.AddWithValue("@Mrezi", tbmrezi.Text);
                cmd.ExecuteNonQuery();
               
                ReadData(sqlite_conn);
                sqlite_conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ima problem" + ex.ToString());
            }
        }

        private void btnPrebarajGodina_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            //CreateTable(sqlite_conn);

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();


            //citanje po odreden kriterium na primer po vozrast
            sqlite_cmd.CommandText = "SELECT * FROM Licnosti WHERE godina=" + tbprebarajgodina.Text;
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            listView1.Items.Clear();
            while (sqlite_datareader.Read())
            {
                string[] arr = new string[12];
                ListViewItem itm;

                arr[0] = sqlite_datareader.GetValue(0).ToString();
                arr[1] = sqlite_datareader.GetValue(1).ToString();
                arr[2] = sqlite_datareader.GetValue(2).ToString();
                arr[3] = sqlite_datareader.GetValue(3).ToString();
                arr[4] = sqlite_datareader.GetValue(4).ToString();
                arr[5] = sqlite_datareader.GetValue(5).ToString();
                arr[6] = sqlite_datareader.GetValue(6).ToString();
                arr[7] = sqlite_datareader.GetValue(7).ToString();
                arr[8] = sqlite_datareader.GetValue(8).ToString();
                arr[9] = sqlite_datareader.GetValue(9).ToString();
                arr[10] = sqlite_datareader.GetValue(10).ToString();
                arr[11] = sqlite_datareader.GetValue(11).ToString();


                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
            sqlite_conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            //CreateTable(sqlite_conn);

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();


            //citanje po odreden kriterium na primer po vozrast
            sqlite_cmd.CommandText = "SELECT * FROM Licnosti WHERE klas=" + tbprebarajklas.Text;
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            listView1.Items.Clear();
            while (sqlite_datareader.Read())
            {
                string[] arr = new string[12];
                ListViewItem itm;

                arr[0] = sqlite_datareader.GetValue(0).ToString();
                arr[1] = sqlite_datareader.GetValue(1).ToString();
                arr[2] = sqlite_datareader.GetValue(2).ToString();
                arr[3] = sqlite_datareader.GetValue(3).ToString();
                arr[4] = sqlite_datareader.GetValue(4).ToString();
                arr[5] = sqlite_datareader.GetValue(5).ToString();
                arr[6] = sqlite_datareader.GetValue(6).ToString();
                arr[7] = sqlite_datareader.GetValue(7).ToString();
                arr[8] = sqlite_datareader.GetValue(8).ToString();
                arr[9] = sqlite_datareader.GetValue(9).ToString();
                arr[10] = sqlite_datareader.GetValue(10).ToString();
                arr[11] = sqlite_datareader.GetValue(11).ToString();


                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
            sqlite_conn.Close();
        }

        private void btnprebarajime_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();

            // Use parameterized query to avoid SQL injection
            sqlite_cmd.CommandText = "SELECT * FROM Licnosti WHERE ime=@ime";
            sqlite_cmd.Parameters.AddWithValue("@ime", tbprebarajime.Text); // Assuming tbprebarajprezime.Text contains the desired prezime value

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            listView1.Items.Clear();
            while (sqlite_datareader.Read())
            {
                string[] arr = new string[12];
                ListViewItem itm;

                // Populate arr array with column values
                for (int i = 0; i < 12; i++)
                {
                    arr[i] = sqlite_datareader.GetValue(i).ToString();
                }

                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
            sqlite_conn.Close();
        }

        private void btnPrezimepobaraj_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();

            // Use parameterized query to avoid SQL injection
            sqlite_cmd.CommandText = "SELECT * FROM Licnosti WHERE prezime=@prezime";
            sqlite_cmd.Parameters.AddWithValue("@prezime", tbprebarajprezime.Text); // Assuming tbprebarajprezime.Text contains the desired prezime value

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            listView1.Items.Clear();
            while (sqlite_datareader.Read())
            {
                string[] arr = new string[12];
                ListViewItem itm;

                // Populate arr array with column values
                for (int i = 0; i < 12; i++)
                {
                    arr[i] = sqlite_datareader.GetValue(i).ToString();
                }

                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
            sqlite_conn.Close();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            ListViewItem item = listView1.SelectedItems[0];
            
            sqlite_cmd.CommandText = "DELETE FROM Licnosti WHERE ime=@Ime AND prezime=@Prezime";
            sqlite_cmd.Parameters.AddWithValue("@Ime", item.SubItems[0].Text); // Assuming tbprosekime.Text contains the first name of the student
            sqlite_cmd.Parameters.AddWithValue("@Prezime", item.SubItems[1].Text);
            listView1.Items.Remove(item);
            sqlite_cmd.ExecuteNonQuery();

        }

        private void btnprosekucenik_Click(object sender, EventArgs e)
        {

            Console.WriteLine("btnprosekucenik_Click method is called.");

            // Check if textboxes are empty
            if (string.IsNullOrEmpty(tbprosekime.Text) || string.IsNullOrEmpty(tbprosekprezime.Text))
            {
                Console.WriteLine("One or both textboxes are empty.");
                MessageBox.Show("Ве молиме пополнете ги сите полиња.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();

            // Use parameterized query to avoid SQL injection
            sqlite_cmd.CommandText = "SELECT makedonski, matematika, Fizicko, programiranje, robotika, mikrokompijuteri, bazipodatoci, mrezi FROM Licnosti WHERE ime=@Ime AND prezime=@Prezime";
            sqlite_cmd.Parameters.AddWithValue("@Ime", tbprosekime.Text); // Assuming tbprosekime.Text contains the first name of the student
            sqlite_cmd.Parameters.AddWithValue("@Prezime", tbprosekprezime.Text); // Assuming tbprosekprezime.Text contains the last name of the student

            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();

            if (!sqlite_datareader.HasRows)
            {
                Console.WriteLine("Ученикот не постои.");
                MessageBox.Show("Ученикот не постои.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlite_datareader.Close();
                sqlite_conn.Close();
                return;
            }

            double sum = 0;
            int count = 0;

            while (sqlite_datareader.Read())
            {
                for (int i = 0; i < sqlite_datareader.FieldCount; i++)
                {
                    if (!sqlite_datareader.IsDBNull(i))
                    {
                        double grade = Convert.ToDouble(sqlite_datareader[i]);
                        sum += grade;
                        count++;
                    }
                }
            }

            sqlite_datareader.Close();

            double average = count > 0 ? sum / count : 0; // To handle division by zero if no grades found

            MessageBox.Show($"Просекот на ученикот {tbprosekime.Text} {tbprosekprezime.Text} изнесува: {average}");

            sqlite_conn.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnprosekklas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbprosekklas.Text))
            {
                MessageBox.Show("Внесете го бројот на класот.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();

            // Use parameterized query to avoid SQL injection
            sqlite_cmd.CommandText = "SELECT makedonski, matematika, Fizicko, programiranje, robotika, mikrokompijuteri, bazipodatoci, mrezi FROM Licnosti WHERE klas=@Klas";
            sqlite_cmd.Parameters.AddWithValue("@Klas", tbprosekklas.Text);

            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();

            if (!sqlite_datareader.HasRows)
            {
                MessageBox.Show("Класот не постои во базата.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlite_datareader.Close();
                sqlite_conn.Close();
                return;
            }

            double sumTotal = 0;
            int countTotal = 0;

            while (sqlite_datareader.Read())
            {
                double sum = 0;
                int count = 0;

                for (int i = 0; i < sqlite_datareader.FieldCount; i++)
                {
                    if (!sqlite_datareader.IsDBNull(i))
                    {
                        double grade = Convert.ToDouble(sqlite_datareader[i]);
                        sum += grade;
                        count++;
                    }
                }

                if (count > 0)
                {
                    sumTotal += sum;
                    countTotal += count;
                }
            }

            sqlite_datareader.Close();

            double averageClass = countTotal > 0 ? sumTotal / countTotal : 0; // To handle division by zero if no grades found

            MessageBox.Show($"Просекот на класот {tbprosekklas.Text} изнесува: {averageClass}");

            sqlite_conn.Close();
        }
    }
}
