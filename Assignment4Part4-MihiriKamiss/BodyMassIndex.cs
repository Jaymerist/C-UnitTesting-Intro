namespace Assignment4Part4_MihiriKamiss
{
    public class BodyMassIndex
    {
        private string _name;
        private double _weight;
        private double _height;
        public string Name

        {
            get
            {
                return _name;
            }
            set
            {
                
                if (string.IsNullOrWhiteSpace(value))
                {
                    //_name = value; --an exceptiion should be thrown if the value is null or whitespace
                    throw new Exception("Name cannot be blank");
                }
                else
                {
                    // throw new Exception("Name cannot be blank");
                    //_name = value if the value is not null or white spaces
                    _name = value;
                }
            }
        }
        public double Weight
        {
            get
            {
                //return _height; --incorrect field
                return _weight;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception(//"Weight must be a positive non-zero value" --Test string given in PDF does not match 
                                        "Weight must be a positive non-zero number");
                }
                //Height = value; ---should be nested into an else statement
                else
                {
                    _weight = value;
                }
            }
        }
        public double Height
        {
            get
            {
                //return Height; -- incorrect return statement

                return _height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception(//"Height must be a positive non-zero value" --Test string given in PDF does not match 
                                        "Height must be a positive non-zero number");
                }
                //_height = value; --should be nested in an else statement
                else
                {
                    _height = value;
                }
            }
        }
        public BodyMassIndex(string name, double weight, double height)
        {
            //name = name; -- incorrect declaration 
            Name = name;
            Weight = weight;
            //height = this.Height; ---unnecessary 
            Height = height;
        }

        /// <summary>
        /// Calculate the body mass index (BMI) using the weight and height of the person.
        ///
        /// The BMI of a person is calculated using the formula: BMI = 700 * weight / (height* height)
        /// where weight is in pounds and height is in inches.
        /// </summary>
        /// <returns>the body mass index (BMI) value of the person</returns>
        public double Bmi()
        {
            //double bmiValue = 703 * Weight / Math.Pow(2, Height); --- Incorrect placements of values within Math.Pow. Causes 2^Height
            double bmiValue = 703 * Weight / Math.Pow(Height, 2);
            bmiValue = Math.Round(bmiValue, 1);
            return bmiValue;
        }
        /// <summary>
        /// Determines the BMI Category of the person using their BMI value.
        /// </summary>
        /// <returns>one of following: underweight, normal, overweight, obese.</returns>
        public string BmiCategory()
        {
            string category = "Unknown";
            double bmiValue = Bmi();

            //changed to else if statements
            //only if statements causes every statement to be true unless the number is over 30.0
            if (bmiValue < 18.5)
            {
                category = "underweight";
            }
            else if (bmiValue < 24.9)
            {
                category = "normal";
            }
            else if (bmiValue < 29.9)
            {
                category = "overweight";
            }
            else // if (bmiValue >= 30)
            {
                category = "obese";
            }
            return category;
        }
    }
}


