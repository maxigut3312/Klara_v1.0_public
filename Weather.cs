using System.Net;
using System.Xml;

namespace Main
{
    class Weather
    {
        public static string APIkey = "<YOUR API-KEY>";
        public static string city = "<YOUR CITY>";
        string weburl = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&mode=xml&APPID=" + APIkey + "&units=metric";

        public string getTemperature()
        {
            string xmlTemp = new WebClient().DownloadString(weburl);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlTemp);
            string Temp = doc.DocumentElement.SelectSingleNode("temperature").Attributes["value"].Value;
            return Temp;
        }

        public string getWeather()
        {
            string xmlWeather = new WebClient().DownloadString(weburl);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlWeather);
            string Weather = doc.DocumentElement.SelectSingleNode("weather").Attributes["value"].Value;
            return Weather;
        }

        public string getHumidity()
        {
            string xmlHumidity = new WebClient().DownloadString(weburl);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlHumidity);
            string Humidity = doc.DocumentElement.SelectSingleNode("humidity").Attributes["value"].Value;
            return Humidity;
        }

        public string getPressure()
        {
            string xmlPressure = new WebClient().DownloadString(weburl);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlPressure);
            string Pressure = doc.DocumentElement.SelectSingleNode("pressure").Attributes["value"].Value;
            return Pressure;
        }

        public string getSunrise()
        {
            string xmlSunrise = new WebClient().DownloadString(weburl);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlSunrise);
            string SunriseUn = doc.DocumentElement.SelectSingleNode("city/sun").Attributes["rise"].Value;
            char[] chars = SunriseUn.ToCharArray(11, 5);
            string Sunrise = (chars[0].ToString() + chars[1].ToString() + chars[2].ToString() + chars[3].ToString() + chars[4].ToString());
            return Sunrise;
        }

        public string getSunset()
        {
            string xmlSunset = new WebClient().DownloadString(weburl);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlSunset);
            string SunsetUn = doc.DocumentElement.SelectSingleNode("city/sun").Attributes["set"].Value;
            char[] chars = SunsetUn.ToCharArray(11, 5);
            string Sunset = (chars[0].ToString() + chars[1].ToString() + chars[2].ToString() + chars[3].ToString() + chars[4].ToString());
            return Sunset;
        }
    }
}
