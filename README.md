

# Weather App in C#

A simple Windows Forms Application (Desktop App) built with C# that fetches real-time weather data from the OpenWeatherMap API and displays it to the user. The app shows temperature, humidity, weather conditions, and an appropriate weather icon based on the data.

---

## Features
- Fetches weather data using the OpenWeatherMap API.
- Displays the temperature (in Celsius), humidity, and weather conditions.
- Displays a corresponding image depending on the weather condition (e.g., clouds, rain, clear skies).
- Prevents window resizing to maintain the app's design integrity.
  
---

## Requirements
- .NET Framework 4.7.2 or later (Windows Forms Application)
- NuGet Packages:
  - `Newtonsoft.Json` for JSON parsing.
  - `HttpClient` for making API requests.
  
---

## Setup Instructions

1. Clone the repository to your local machine:
    ```bash
    git clone https://github.com/your-username/WeatherApp.git
    ```
  
2. Open the project in **Visual Studio**.

3. Install the required NuGet packages:
    - Open **Tools > NuGet Package Manager > Manage NuGet Packages for Solution**.
    - Install `Newtonsoft.Json` and ensure `HttpClient` is available by default.

4. **API Key**:
    - You’ll need to sign up for an API key from [OpenWeatherMap](https://openweathermap.org/api).
    - Once you have the key, replace the placeholder in the code:
      ```csharp
      string apiKey = "f2c1629ce072cfa662000f6863a76d40"; // Replace with your API key
      ```

5. **Images**:
    - The app uses images located in the `images` folder (like `clouds.png`).
    - Make sure you have appropriate image files or download icons for each weather condition from the web and store them in the `images` directory.

6. Build and run the app in **Visual Studio**.

---

## Usage

1. Open the app, and input the name of the city in the provided text box.
2. Click **Submit** to fetch the weather data.
3. The app will display:
    - The city name.
    - Temperature in Celsius.
    - Humidity percentage.
    - Weather description (e.g., Clear, Cloudy, Rainy).
    - A weather icon (based on the weather condition).

---

## Example Screenshots
(Optional: Add screenshots of the app here)

---

## Contributing
Feel free to fork the repository, submit issues, or create pull requests.

---

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

### Example of Weather App Workflow:

1. **Input:** Enter city name (e.g., "London").
2. **Action:** Click **Submit**.
3. **Result:**
   - The app fetches weather data from the OpenWeatherMap API.
   - It displays information like temperature in Celsius, humidity percentage, and weather condition description.
   - It shows an appropriate weather image based on the current weather.

---

