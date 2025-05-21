namespace DesignPatterns.Observer
{
    public static class HowToCallObserver
    {
        public static void CallObserver()
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

            // Other display if required
            //StatisticsConditionsDisplay currentConditionsDisplay = new StatisticsConditionsDisplay(weatherData);
            //ForecastConditionsDisplay currentConditionsDisplay = new ForecastConditionsDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);
        }
    }
}
