using System;

namespace RandomStuff
{
    /// <summary>
    /// The person class.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// The age. Changeable.
        /// </summary>
        public double age;
        /// <summary>
        /// The name. Changeable.
        /// </summary>
        public string name;
        /// <summary>
        /// Favourite food. Does literraly nothing, but you can do something with it.
        /// </summary>
        public string[] favouriteFood;
        /// <summary>
        /// Disliked food. Does literraly nothing, but you can do something with it.
        /// </summary>
        public string[] dislikedFood;
        /// <summary>
        /// The gender.
        /// </summary>
        public Gender gender;
        /// <summary>
        /// The saturation itself.
        /// </summary>
        protected double saturatation;
        /// <summary>
        /// The hydration itself.
        /// </summary>
        protected double hydration;
        /// <summary>
        /// The fun itself.
        /// </summary>
        protected double fun;
        /// <summary>
        /// The need to go on the toilet itself.
        /// </summary>
        protected double needToGoOnTheToilet;
        /// <summary>
        /// The energy itself.
        /// </summary>
        protected double energy;
        
        /// <summary>
        /// Saturation points. Use the <code>consume()</code> function to saturate.
        /// </summary>
        public virtual double Saturation
        {
            set
            {
                if (value > 100)
                {
                    saturatation = 100;
                }
                else if (value < 0)
                {
                    saturatation = 0;
                }
                else
                {
                    saturatation = value;
                }
            }
            get => saturatation;
        }

        /// <summary>
        /// Hydration points. Use the <code>Consume()</code> function to hydrate.
        /// </summary>
        public virtual double Hydration
        {
            set
            {
                if (value > 100)
                {
                    hydration = 100;
                }
                else if (value < 0)
                {
                    hydration = 0;
                }
                else
                {
                    hydration = value;
                }
            }
            get => saturatation;
        }

        /// <summary>
        /// Fun points. Use the <code>Play()</code> function to play a game.
        /// </summary>
        public virtual double Fun
        {
            set
            {
                if (value > 100)
                {
                    fun = 100;
                }
                else if (value < 0)
                {
                    fun = 0;
                }
                else
                {
                    fun = value;
                }
            }
            get => fun;
        }

        /// <summary>
        /// The need to go on the toilet. Use the <code>UseTheToilet()</code> function to use the toilet. 
        /// </summary>
        public virtual double NeedToGoOnTheToilet
        {
            set
            {
                if (value > 100)
                {
                    needToGoOnTheToilet = 100;
                }
                else if (value < 0)
                {
                    needToGoOnTheToilet = 0;
                }
                else
                {
                    needToGoOnTheToilet = value;
                }
            }
            get => needToGoOnTheToilet;
        }

        /// <summary>
        /// The energy. Use the <code>Sleep()</code> function to sleep.
        /// </summary>
        public virtual double Energy
        {
            set
            {
                if (value > 100)
                {
                    energy = 100;
                }
                else if (value < 0)
                {
                    energy = 0;
                }
                else
                {
                    energy = value;
                }
            }
            get => energy;
        }

        /// <summary>
        /// Consumes a consumable to add saturation and hydration points.
        /// </summary>
        /// <param name="consumedThing">The thing consumed</param>
        /// <param name="announce">By default set to false, determines if the consuming will be announced to the console.</param>
        virtual public void Consume(Consumable consumedThing, bool announce = false)
        {
            string msg;

            if (consumedThing.Saturation + saturatation > 100)
            {
                saturatation = 100;
            }
            else
            {
                saturatation += consumedThing.Saturation;
            }

            if (consumedThing.Hydration + hydration > 100)
            {
                hydration = 100;
            }
            else
            {
                hydration += consumedThing.Hydration;
            }

            if (consumedThing.Energy + energy > 100)
            {
                energy = 100;
            }
            else
            {
                energy += consumedThing.Energy;
            }
            if (announce)
            {
                if (consumedThing.IsFood)
                {
                    msg = $"{name} ate {consumedThing.name}";
                }
                else
                {
                    msg = $"{name} drunk {consumedThing.name}";
                }
                Console.WriteLine(msg);
            }
        }

        /// <summary>
        /// Plays a game. Used to increase fun.
        /// </summary>
        /// <param name="game">The game to play</param>
        /// <param name="announce">By default set to false, determines if the playing will be announced to the console.</param>
        virtual public void Play(Game game, bool announce = false)
        {
            if (game.Fun + fun > 100)
            {
                fun = 100;
            }
            else
            {
                fun += game.Fun;
            }

            if (announce)
            {
                Console.WriteLine($"{name} played {game.name}");
            }
        }

        /// <summary>
        /// Uses the toilet. Used to lower the need to go on the toilet.
        /// </summary>
        /// <param name="howMuch">By default set to 100. Used to determine the level of using the toilet. (the need will be lowered by howMuch)</param>
        /// <param name="announce">By default set to false, determines if using the toilet will be announced to the console.</param>
        virtual public void UseTheToilet(double howMuch = 100, bool announce = false)
        {
            if (needToGoOnTheToilet - howMuch < 0)
            {
                needToGoOnTheToilet = 0;
            }
            else
            {
                needToGoOnTheToilet -= howMuch;
            }
            
            if (announce)
            {
                Console.WriteLine($"{name} used the toilet.");
            }
        }

        /// <summary>
        /// Writes basic info to the console in this format: Hello! I'm (name). I'm a (gender).
        /// </summary>
        virtual public void Greeting()
        {
            Console.WriteLine($"Hello! I'm {name}. I'm a {gender.StringGender()}.");
        }

        /// <summary>
        /// Passes time. Lowers needs and adds age by the time. (NeedToGoOnTheToilet is highered.)
        /// </summary>
        /// <param name="HowLong">The time. Fun is lowered by HowLong × 2 and NeedToGoOnTheToiled is highered by HowLong × 3.</param>
        virtual public void TimePass(double HowLong)
        {
            age += HowLong;
            Saturation -= HowLong;
            Hydration -= HowLong;
            Fun -= (HowLong * 2);
            NeedToGoOnTheToilet += (HowLong * 3);
            Energy -= HowLong;
        }
        
        /// <summary>
        /// Prints info to the console.
        /// </summary>
        virtual public void PrintInfo()
        {
            Console.WriteLine($"Name: {name}, Gender: {gender.StringGender()}, Saturation: {saturatation}, Hydration: {hydration}, fun: {fun}, Need to go on the toilet: {needToGoOnTheToilet}, energy: {energy}. ");
        }

        /// <summary>
        /// The constructor.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="gender">The gender.</param>
        public Person(string name, Gender gender)
        {
            this.name = name;
            this.gender = gender;
            Saturation = 100;
            Hydration = 100;
            Fun = 100;
            NeedToGoOnTheToilet = 0;
            Energy = 100;
            age = 0;
        }
    }
}
