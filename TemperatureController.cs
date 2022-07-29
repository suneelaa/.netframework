using JokeWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JokeWebApplication.Controllers
{
    public class TemperatureController : Controller
    {
        // /temperature/getTemperature
        public string GetTemperature()
        {
            string temp = "23°C";

            return temp;
        }

        public int GetMaxTemperature()
        {
            return 50;
        }

        public Joke GetAJoke()
        {
            var joke = new Joke
            {
                Id = 1,
                JokeQuestion = "What is ASP?",
                JokeAnswer = "Active Server Pages"
            };

            return joke;
        }
        public Joke GetJokeByID([FromQuery] int id)
        {
            Joke result = null;

            List<Joke> allJokes = new List<Joke>();
            var joke = new Joke
            {
                Id = 1,
                JokeQuestion = "What is ASP?",
                JokeAnswer = "Active Server Pages"
            };

            var joke2 = new Joke
            {
                Id = 2,
                JokeQuestion = "What is JS?",
                JokeAnswer = "Jacascript"
            };

            allJokes.Add(joke);
            allJokes.Add(joke2);

            result = allJokes.FirstOrDefault(j => j.Id == id);

            return result;
        }

        public List<Joke> GetAllJokes()
        {
            List<Joke> allJokes = new List<Joke>();
            var joke = new Joke
            {
                Id = 1,
                JokeQuestion = "What is ASP?",
                JokeAnswer = "Active Server Pages"
            };

            var joke2 = new Joke
            {
                Id = 2,
                JokeQuestion = "What is JS?",
                JokeAnswer = "Jacascript"
            };

            allJokes.Add(joke);
            allJokes.Add(joke2);

            return allJokes;
        }

        [HttpPost]
        public object CreateAJoke([FromBody] Joke joke)
        {
            var myJoke = new Joke
            {
                Id = joke.Id,
                JokeQuestion = joke.JokeQuestion,
                JokeAnswer = joke.JokeAnswer
            };

            return new { status ="OK", message="Received your joke", joke = myJoke };
        }
    }
}
