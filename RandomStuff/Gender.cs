using System;
namespace RandomStuff
{
    /// <summary>
    /// The gender class. Used with the person class.
    /// </summary>
    public class Gender
    {
        /// <summary>
        /// The gender itself.
        /// </summary>
        private string gender;
        
        /// <summary>
        /// Used to determine if the gender is male. If it is false, it is a female.
        /// </summary>
        public bool IsMale
        {
            set
            {
                if (value)
                {
                    gender = "male";
                }
                else
                {
                    gender = "female";
                }
            }
            get
            {
                if (gender == "male")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Used to return the gender in a string.
        /// </summary>
        /// <returns>The gender.</returns>
        public string StringGender() => gender;

        /// <summary>
        /// The constructor.
        /// </summary>
        /// <param name="isMale">Used to determine if the gender is male. If it is false, it is female.</param>
        public Gender(bool isMale)
        {
            IsMale = isMale;
        }
    }
}
