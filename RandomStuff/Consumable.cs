using System;

namespace RandomStuff
{
    /// <summary>
    /// The consumable class. Used to make consumables for the Person to consume.
    /// </summary>
    public class Consumable
    {
        /// <summary>
        /// The type of the consumable itself.
        /// </summary>
        protected string type;
        /// <summary>
        /// The saturation itself.
        /// </summary>
        protected double saturation;
        /// <summary>
        /// The hydration itself.
        /// </summary>
        protected double hydration;
        /// <summary>
        /// The energy itself.
        /// </summary>
        protected double energy;
        /// <summary>
        /// The name of the consumable.
        /// </summary>
        public string name;
        /// <summary>
        /// Used to determine if the consumable is food or a drink.
        /// </summary>
        public bool IsFood
        {
            set
            {
                if (value)
                {
                    type = "food";
                }
                else
                {
                    type = "drink";
                }
            }
            get => type == "food";
        }

        /// <summary>
        /// Used to determine the saturation of the consumable.
        /// </summary>
        public double Saturation
        {
            set
            {
                if (value > 100)
                {
                    saturation = 100;
                }
                else
                {
                    saturation = value;
                }
            }
            get => saturation;
        }

        /// <summary>
        /// Similiar to Saturation, used to determine the Hydration of the consumable.
        /// </summary>
        public double Hydration
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
            get => hydration;
        }

        /// <summary>
        /// Used to determine the energy of the consumable.
        /// </summary>
        public double Energy
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
        /// The constructor.
        /// </summary>
        /// <param name="isFood">Used to determine if the created consumable is food. If it is false, it is a drink.</param>
        /// <param name="name">Used to determine the name of the created consumable.</param>
        /// <param name="saturation">Used to determine the saturation of the created consumable.</param>
        /// <param name="hydration">Used to determine the hydration of the created consumable.</param>
        /// <param name="energy">Used to determine the energy boost of the created consumable.</param>
        public Consumable(bool isFood, string name, double saturation, double hydration, double energy = 0)
        {
            IsFood = isFood;
            this.name = name;
            Saturation = saturation;
            Hydration = hydration;
            Energy = energy;
        }
    }
}
