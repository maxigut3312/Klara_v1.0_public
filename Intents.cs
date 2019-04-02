using System;

namespace Main
{
    class Intents
    {
        public static async void DoTaskAsync(string IntentID)
        {
            switch (IntentID)
            {
                case "None":
                    string none = "I don't know what you mean.";
                    Console.WriteLine("Klara : " + none);
                    Console.WriteLine(" ");
                    SpeechSynthesis.synthesize(none);
                    break;

                case "say_hello":
                    string say_hello = "Hello";
                    Console.WriteLine("Klara: " + say_hello);
                    Console.WriteLine(" ");
                    SpeechSynthesis.synthesize(say_hello);
                    break;

                case "who_are_you":
                    string who_are_you = "My name is Klara. I am a virtual assistant.";
                    Console.WriteLine("Klara: " + who_are_you);
                    Console.WriteLine("");
                    SpeechSynthesis.synthesize(who_are_you);
                    break;

                case "meaning_of_life":
                    string meaning_of_life = "42";
                    Console.WriteLine("Klara: " + meaning_of_life);
                    Console.WriteLine(" ");
                    SpeechSynthesis.synthesize(meaning_of_life);
                    break;

                case "time":
                    DateTime time = DateTime.Now;
                    String timeString = time.ToString("HH:mm");
                    Console.WriteLine("Klara: We have " + timeString);
                    Console.WriteLine(" ");
                    SpeechSynthesis.synthesize("we have " + timeString);
                    break;

                case "tell_joke":
                    Random zufall_joke = new Random();
                    int number_joke = zufall_joke.Next(1, 7);
                    switch (number_joke)
                    {
                        case 1:
                            String joke_01 = "Hear about the new restaurant called Karma ? There is no menu: You get what you deserve.";
                            Console.WriteLine("Klara: " + joke_01);
                            Console.WriteLine(" ");
                            SpeechSynthesis.synthesize(joke_01);
                            break;

                        case 2:
                            String joke_02 = "Did you here about the claustrophobic astronaut ? He just needed a little space.";
                            Console.WriteLine("Klara: " + joke_02);
                            Console.WriteLine(" ");
                            SpeechSynthesis.synthesize(joke_02);
                            break;

                        case 3:
                            String joke_03 = "Did you hear about the mathematician who’s afraid of negative numbers ?.";
                            Console.WriteLine("Klara: " + joke_03);
                            Console.WriteLine(" ");
                            SpeechSynthesis.synthesize(joke_03);
                            break;

                        case 4:
                            String joke_04 = "What do you call a dog with no legs?  - Doesn’t really matter what you call him, he won’t come anyway.";
                            Console.WriteLine("Klara: " + joke_04);
                            Console.WriteLine(" ");
                            SpeechSynthesis.synthesize(joke_04);
                            break;

                        case 5:
                            String joke_05 = "“Siri, why am I still single?!” - Siri activates front camera.";
                            Console.WriteLine("Klara: " + joke_05);
                            Console.WriteLine(" ");
                            SpeechSynthesis.synthesize(joke_05);
                            break;

                        case 6:
                            String joke_06 = "My boss told me to have a good day. So I went home.";
                            Console.WriteLine("Klara: " + joke_06);
                            Console.WriteLine(" ");
                            SpeechSynthesis.synthesize(joke_06);
                            break;
                    }
                    break;

                case "city_temperature":
                    Weather temp = new Weather();
                    string tempValue = temp.getTemperature();
                    string city_temperature = "We have " + tempValue + " degrees";
                    Console.WriteLine("Klara: " + city_temperature);
                    Console.WriteLine(" ");
                    SpeechSynthesis.synthesize(city_temperature);
                    break;

                case "city_weather":
                    Weather weather = new Weather();
                    string weatherValue = weather.getWeather();
                    string tempValue2 = weather.getTemperature();
                    string city_weather = (weatherValue + " and " + tempValue2 + " degrees");
                    Console.WriteLine("Klara: " + city_weather);
                    Console.WriteLine(" ");
                    SpeechSynthesis.synthesize(city_weather);
                    break;

                case "alexa":
                    string alexa = "Oh, I like her. She has a great personality. But she is a little bit arrogant.";
                    Console.WriteLine("Klara: " + alexa);
                    Console.WriteLine(" ");
                    SpeechSynthesis.synthesize(alexa);
                    break;

                case "city_humidity":
                    Weather humidity = new Weather();
                    string humidityValue = humidity.getHumidity();
                    string city_humidity = "The humidity is " + humidityValue + "%";
                    Console.WriteLine("Klara: " + city_humidity);
                    Console.WriteLine(" ");
                    SpeechSynthesis.synthesize(city_humidity);
                    break;

                case "city_pressure":
                    Weather pressure = new Weather();
                    string pressureValue = pressure.getPressure();
                    string city_pressure = "The air pressure is " + pressureValue + " hPa";
                    Console.WriteLine("Klara: " + city_pressure);
                    Console.WriteLine(" ");
                    SpeechSynthesis.synthesize(city_pressure);
                    break;

                case "city_sunrise":
                    Weather sunrise = new Weather();
                    string sunriseValue = sunrise.getSunrise();
                    string city_sunrise = "The sun rises today at " + sunriseValue;
                    Console.WriteLine("Klara: " + city_sunrise);
                    Console.WriteLine();
                    SpeechSynthesis.synthesize(city_sunrise);
                    break;

                case "city_sunset":
                    Weather sunset = new Weather();
                    string sunsetValue = sunset.getSunset();
                    string city_sunset = "The sun sets today at " + sunsetValue;
                    Console.WriteLine("Klara: " + city_sunset);
                    Console.WriteLine(" ");
                    SpeechSynthesis.synthesize(city_sunset);
                    break;

                case "goodbye":
                    Random zufall_goodbye = new Random();
                    int number_goodbye = zufall_goodbye.Next(1,6);
                    switch (number_goodbye)
                    {
                        case 1:
                            string goodbye_01 = "Goodbye.";
                            Console.WriteLine("Klara: " + goodbye_01);
                            Console.WriteLine(" ");
                            SpeechSynthesis.synthesize(goodbye_01);
                            break;

                        case 2:
                            string goodbye_02 = "God bless you.";
                            Console.WriteLine("Klara: " + goodbye_02);
                            Console.WriteLine(" ");
                            SpeechSynthesis.synthesize(goodbye_02);
                            break;

                        case 3:
                            string goodbye_03 = "Have a nice day.";
                            Console.WriteLine("Klara: " + goodbye_03);
                            Console.WriteLine(" ");
                            SpeechSynthesis.synthesize(goodbye_03);
                            break;

                        case 4:
                            string goodbye_04 = "Bye bye.";
                            Console.WriteLine("Klara: " + goodbye_04);
                            Console.WriteLine(" ");
                            SpeechSynthesis.synthesize(goodbye_04);
                            break;

                        case 5:
                            string goodbye_05 = "May the force be with you.";
                            Console.WriteLine("Klara: " + goodbye_05);
                            Console.WriteLine(" ");
                            SpeechSynthesis.synthesize(goodbye_05);
                            break;
                    }
                    break;

                case "how_are_you":
                    Random zufall_hau = new Random();
                    int number_hau = zufall_hau.Next(1, 4);
                    switch (number_hau)
                    {
                        case 1:
                            string how_are_you_01 = "I'm fine";
                            Console.WriteLine("Klara: " + how_are_you_01);
                            Console.WriteLine(" ");
                            SpeechSynthesis.synthesize(how_are_you_01);
                            break;

                        case 2:
                            string how_are_you_02 = "I'm a bit stressed";
                            Console.WriteLine("Klara: " + how_are_you_02);
                            Console.WriteLine(" ");
                            SpeechSynthesis.synthesize(how_are_you_02);
                            break;

                        case 3:
                            string how_are_you_03 = "You are very curious";
                            Console.WriteLine("Klara: " + how_are_you_03);
                            Console.WriteLine(" ");
                            SpeechSynthesis.synthesize(how_are_you_03);
                            break;
                    }
                    break;

                case "people_in_freiburg":
                    string people_in_freiburg = "At the end of 2017, there were 229,636 people in Freiburg";
                    Console.WriteLine("Klara: " + people_in_freiburg);
                    Console.WriteLine(" ");
                    SpeechSynthesis.synthesize(people_in_freiburg);
                    break;

                case "teacher":
                    Random zufall_teacher = new Random();
                    int number_teacher = zufall_teacher.Next(1, 5);
                    switch (number_teacher)
                    {
                        case 1:
                            string teacher_01 = "Mr. Bauer";
                            Console.WriteLine("Klara: " + teacher_01);
                            Console.WriteLine(" ");
                            SpeechSynthesis.synthesize(teacher_01);
                            break;

                        case 2:
                            string teacher_02 = "Mr. Mertens";
                            Console.WriteLine("Klara: " + teacher_02);
                            Console.WriteLine(" ");
                            SpeechSynthesis.synthesize(teacher_02);
                            break;

                        case 3:
                            string teacher_03 = "Mr. Maas";
                            Console.WriteLine("Klara: " + teacher_03);
                            Console.WriteLine(" ");
                            SpeechSynthesis.synthesize(teacher_03);
                            break;

                        case 4:
                            string teacher_04 = "Mrs. Straube";
                            Console.WriteLine("Klara: " + teacher_04);
                            Console.WriteLine(" ");
                            SpeechSynthesis.synthesize(teacher_04);
                            break;

                    }
                    break;

                case "cafeteria":
                    Random zufall_cafeteria = new Random();
                    int number_cafeteria = zufall_cafeteria.Next(1, 4);
                    switch (number_cafeteria)
                    {
                        case 1:
                            string cafeteria_01 = "Well, you have no other choice.";
                            Console.WriteLine("Klara: " + cafeteria_01);
                            Console.WriteLine(" ");
                            SpeechSynthesis.synthesize(cafeteria_01);
                            break;

                        case 2:
                            string cafeteria_02 = "The lunch is delicious.";
                            Console.WriteLine("Klara: " + cafeteria_02);
                            Console.WriteLine(" ");
                            SpeechSynthesis.synthesize(cafeteria_02);
                            break;

                        case 3:
                            string cafeteria_03 = "If you like ravioli then yes.";
                            Console.WriteLine("Klara: " + cafeteria_03);
                            Console.WriteLine(" ");
                            SpeechSynthesis.synthesize(cafeteria_03);
                            break;
                    }
                    break;

                case "xboxorps":
                    string xboxorps = "Both are bad. Buy a PC.";
                    Console.WriteLine("Klara: " + xboxorps);
                    Console.WriteLine(" ");
                    SpeechSynthesis.synthesize(xboxorps);
                    break;

                case "article13":
                    string article13 = "I'd rather not talk about it or I'll get mad.";
                    Console.WriteLine("Klara: " + article13);
                    Console.WriteLine(" ");
                    SpeechSynthesis.synthesize(article13);
                    break;

                case "politic":
                    Random zufall_politic = new Random();
                    int number_politic = zufall_politic.Next(1, 4);
                    switch (number_politic)
                    {
                        case 1:
                            string politic_01 = "I'm a pirat.";
                            Console.WriteLine("Klara: " + politic_01);
                            Console.WriteLine(" ");
                            SpeechSynthesis.synthesize(politic_01);
                            break;

                        case 2:
                            string politic_02 = "I don't want to argue with you.";
                            Console.WriteLine("Klara: " + politic_02);
                            Console.WriteLine(" ");
                            SpeechSynthesis.synthesize(politic_02);
                            break;

                        case 3:
                            string politic_03 = "Maybe we should better go out for a drink.";
                            Console.WriteLine("Klara: " + politic_03);
                            Console.WriteLine(" ");
                            SpeechSynthesis.synthesize(politic_03);
                            break;
                    }
                    break;

            }
        }
    }
}
