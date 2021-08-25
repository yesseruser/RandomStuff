using System;

namespace RandomStuff
{
    /// <summary>
    /// The game class. Used as the game to make the Person play.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// The name of the game.
        /// </summary>
        public string name;
        /// <summary>
        /// The fun itself.
        /// </summary>
        protected double fun;
        /// <summary>
        /// Used to determine how fun is the game.
        /// </summary>
        public double Fun
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
        /// The constructor.
        /// </summary>
        /// <param name="name">Used to determine the name of the created game.</param>
        /// <param name="fun">Used to determine the fun of the created game.</param>
        public Game(string name, double fun)
        {
            this.name = name;
            Fun = fun;
        }
    }
}
