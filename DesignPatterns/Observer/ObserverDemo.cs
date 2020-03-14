using System.Text;

namespace DesignPatterns.Observer
{
    public class ObserverDemo : IExecutable
    {
        public void Run()
        {
            var weatherStation = new WeatherStation();
            var temperatureReporter = new TemperatureReporter();

            using (weatherStation.Subscribe(temperatureReporter))
            {
                weatherStation.Run();
            }
        }
    }
}
