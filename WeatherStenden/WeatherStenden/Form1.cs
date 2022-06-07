using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Diagnostics;
using Newtonsoft.Json;
using MySql.Data.MySqlClient;
using System.Threading;

namespace WeatherStenden
{
    public partial class Form1 : Form
    {
        // API URL
        private const string currentURL = "http://api.openweathermap.org/data/2.5/weather?q=";
        private const string API_KEY = "&appid=7f6ac6bd566b6aae811b5b2e260d4362";
        // Path to the database
        private const string path = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pepelito\\Desktop\\Year 1\\Period 4\\WeatherStenden\\WeatherStenden\\Northwind.mdf;Integrated Security=True;Connect Timeout=30";

        double dt;
        string conve = "&units=imperial";
        string city = "Emmen, NL";
        System.Windows.Forms.Timer theTimer = new System.Windows.Forms.Timer();
        Boolean metric = false;

        // Starting the application
        public Form1()
        {

            // Showing and creatinng splash screen
            Thread t = new Thread(new ThreadStart(StartSplashForm));
            t.Start();
            Thread.Sleep(6000);
            InitializeComponent();
            t.Abort();
            getWeather();
            //theTimer.Interval = 300000 5 minutes
            theTimer.Interval = 60000;
            theTimer.Tick += new System.EventHandler(theTimer_Tick);
            theTimer.Start();
            forecasting();
            chart();
        }

        public void StartSplashForm()
        {
            Application.Run(new SplashScreen());
        }

        public void theTimer_Tick(object sender, EventArgs e)
        {
            this.metric = false;
            getWeather();
            forecasting();
            chart();
            convention.Text = "\u0080 F";
        }

        // This method is for generating the graph for the Trend page
        private void chart()
        {
            // Clearing the graph from any previous data
            this.temperatureGraph.Series["Temperature (C)"].Points.Clear();
            this.temperatureGraph.Series["Temperature (F)"].Points.Clear();
            // Make a connection to the database to query all the 5 datas
            SqlConnection conn = new SqlConnection(path);
            try
            {
                conn.Open();
                if (this.metric == true)
                {
                    SqlCommand cmd = new SqlCommand("SELECT TOP 5 dt, Celcius FROM TEMP WHERE id > (SELECT COUNT(*) FROM TEMP) - 5", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    int x = 0;
                    while (reader.Read())
                    {
                        // Convert the value dt to milisecond
                        double dt = Convert.ToDouble(reader.GetValue(0)) + 950400000;
                        dt = -x;
                        this.temperatureGraph.Series["Temperature (C)"].Points.AddXY(getDateTime(dt).ToString(), reader.GetValue(1));
                        x += 86400000;
                    }
                    reader.Close();
                }
                else if (this.metric == false)
                {
                    SqlCommand cmd = new SqlCommand("SELECT TOP 5 dt, Fahrenheit FROM TEMP WHERE id > (SELECT COUNT(*) FROM TEMP) - 5", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    int x = 0;
                    while (reader.Read())
                    {
                        double dt = Convert.ToDouble(reader.GetValue(0)) + 950400000;
                        dt = -x;
                        this.temperatureGraph.Series["Temperature (F)"].Points.AddXY(getDateTime(dt).ToString(), reader.GetValue(1));
                        x += 86400000;
                    }
                    reader.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error: " + ex.Message, "Chart error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                
            }
            
        }

        // This method is running the forecast API and inserting it to the database
        private void forecasting()
        {
            // Select the next 4 days, because the first data is from today's weather
            int days = 4;
            string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?q={0}&appid=7f6ac6bd566b6aae811b5b2e260d4362&cnt={1}&units=imperial", this.city, days);
            
            try
            {
                using (WebClient web = new WebClient())
                {
                    // Get the json response from the API
                    string json = web.DownloadString(url);
                    
                    var obj = JsonConvert.DeserializeObject<dynamic>(json);

                    // We get 4 objects because we selected 4 days, this for loop will iterate from the 1st obj to the 4th obj
                    for (int i = 0; i <= 3; i++)
                    {
                        // Getting the required values from the obj
                        int fah = obj.list[i].main.temp;
                        int cel = Convert.ToInt32((fah - 32) / 1.8);
                        int dt = obj.list[i].dt;
                        // Insert the main values to the databse, when the foor loop ends we should get 4 datas inserted to the database
                        string query = "INSERT INTO TEMP(Celcius, Fahrenheit, dt) VALUES (" + cel + ", " + fah + ", " + dt + ")";
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, path);
                        DataTable table = new DataTable();
                        dataAdapter.Fill(table);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception occured:\n" + ex.Message, "Forecasting error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // This method will be executed when the OK button is clicked in the Option page
        private void optionOk_Click(object sender, EventArgs e)
        {
            if (location.Text != null && interval.Value > 0)
            {
                // Gather the input city
                this.city = location.Text;
                // Gather the input interval
                int n = Convert.ToInt32(interval.Value);
                this.theTimer.Interval = n * 1000;

                // Checking the selected measuring system and storing it in a boolean variable
                if (celcius.Checked)
                {
                    convention.Text = "\u0080 C";
                    this.metric = true;
                }
                else if (fahrenheit.Checked)
                {
                    this.metric = false;
                    convention.Text = "\u0080 F";
                }

                // Reusing the main 3 method again to display the datas
                getWeather();
                forecasting();
                chart();
            }
            else
            {
                MessageBox.Show("Please fill in all the input", "Empty input", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // This method is displaying all the necessary datas we get from the API to the Current page
        public void getWeather()
        {
            // Access the API using web client
            using (WebClient client = new WebClient())
            {
                // Checking which measurement system the user wants to be displayed
                if (this.metric == true)
                {
                    this.conve = "&units=metric";
                    convention.Text = "\u0080 C";
                }
                else if (this.metric == false)
                {
                    this.conve = "&units=imperial";
                    convention.Text = "\u0080 F";
                }
                // Form the necessary URL
                string URL = string.Format(currentURL + this.city + API_KEY + this.conve);
                try
                {
                    // Download the output string we requested from the API
                    string json = client.DownloadString(URL);
                    // Desentralize the object just like shown in the C# tutorial and storing it to our C# sub-class root in the class weatherInfo
                    var obj = JsonConvert.DeserializeObject<dynamic>(json);

                    var result = JsonConvert.DeserializeObject<weatherInfo.root>(json);
                    weatherInfo.root output = result;

                    // Showing the datas the to the labels in the Current page
                    textLocation.Text = string.Format("{0}", output.Name) + ", " + string.Format("{0}", output.sys.Country);
                    temperature.Text = string.Format("{0} \u0080", output.main.Temp);
                    humidty.Text = string.Format("{0}", output.main.Humidity + " %");
                    windSpeed.Text = string.Format("{0}", output.wind.Speed);
                    windDirection.Text = string.Format("{0}", output.wind.Deg);
                    cloud.Text = string.Format("{0}", obj.weather[0].description);
                   //lastUpdate.Text = string.Format("{0}", getDate(output.dt));
                   currentTempToolStripMenuItem.Text = string.Format("{0}", output.main.Temp);
                    this.dt = output.dt;
                    currentTempToolStripMenuItem.Text += (this.metric == true) ? " C" : " F";
                    DateTime dt = DateTime.Now;
                    lastUpdate.Text = dt.ToString();

                    // For inserting the first data (current date) to the database, so it will make 5 forecast datas, from today to the next 4 days
                    int date = Convert.ToInt32(output.dt);
                    int temp1 = Convert.ToInt32(output.main.Temp);
                    int temp2 = 0;
                    string query = "";
                    if (this.metric == true)
                    {
                        temp2 = Convert.ToInt32((temp1 * 1.8) + 32);
                        query = "INSERT INTO TEMP(Celcius, Fahrenheit, dt) VALUES (" + temp1 + ", " + temp2 + ", " + date + ")";
                    }
                    else if (this.metric == false)
                    {
                        temp2 = Convert.ToInt32((temp1 - 32) / 1.8);
                        query = "INSERT INTO TEMP(Celcius, Fahrenheit, dt) VALUES (" + temp2 + ", " + temp1 + ", " + date + ")";
                    }

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, path);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception occured:\n" + ex.Message, "IO exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // This method is from one of the requirements, when closing the application, a popup warning message should appear to make sure the user is sure of their choice
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Do you want to close this application?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        // This method is for showing the 2nd Windows Form which is an About Page
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formTwo = new About();
            this.Hide();
            formTwo.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            option.Show();
            tabPages.SelectedTab = option;
            this.Show();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getWeather();
            forecasting();
            chart();
        }

        // Converting to DateTime from miliseconds
        DateTime getDate(double miliSeconds)
        {
            DateTime day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(miliSeconds).ToLocalTime();

            return day;
        }

        // Same output but with different approach
        string getDateTime(double miliseconds)
        {
            TimeSpan timeSpan = TimeSpan.FromMilliseconds(miliseconds);
            string now = DateTime.Now.Add(timeSpan).ToString("yyyy-MM-dd");
            return now;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.WindowState = FormWindowState.Minimized;
                e.Cancel = true;
            }
        }

    }
}
