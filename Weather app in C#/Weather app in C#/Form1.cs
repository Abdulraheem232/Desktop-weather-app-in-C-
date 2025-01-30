using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using System.Net.Http;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Weather_app_in_C_
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();

            // Prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private async void Submit_Click(object sender, EventArgs e)
        {
            string apiKey = "f2c1629ce072cfa662000f6863a76d40";
            string city = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Please enter a city name.");
                return;
            }

            string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}";

                var jsonResponse = await client.GetStringAsync(apiUrl);
                dynamic weatherData = JsonConvert.DeserializeObject(jsonResponse);

                // Display temperature in Kelvin
                double tempK = weatherData.main.temp;
                double tempC = tempK - 273.15; // Convert to Celsius

            label1.Text = $"{weatherData.name}";
            label2.Text = $"Temperature : {tempC:F1}°C";
            label3.Text = $"Humidity : {weatherData.main.humidity} %";
            label4.Text = $"{weatherData.weather[0].description}";

            if (weatherData.weather[0].main == "Clouds")
            {
                pictureBox1.Image = Image.FromFile("images/clouds.png");
                }
            else if (weatherData.weather[0].main == "Drizzle")
            {
                pictureBox1.Image = Image.FromFile("images/clouds.png");
            }
            else if (weatherData.weather[0].main == "Mist")
            {
                pictureBox1.Image = Image.FromFile("images/clouds.png");
            }
            else if (weatherData.weather[0].main == "Clear")
            {
                pictureBox1.Image = Image.FromFile("images/clouds.png");
            }
            else if (weatherData.weather[0].main == "Rain")
            {
                pictureBox1.Image = Image.FromFile("images/clouds.png");
            }


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
