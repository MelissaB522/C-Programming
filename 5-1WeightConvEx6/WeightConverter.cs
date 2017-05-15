using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1WeightConvEx6
{
    class WeightConverter
    {
        // declare variables for conversions, with grams as default
        // by converting from the initial weight measurement to a default (grams) and then to 
        // the required weight measurement a method for each conversion is not required
        static decimal gramsToPounds = 0.002205M;
        static decimal gramsToKilograms = 0.001M;
        static decimal gramsToOunces = 0.035274M;

        /// <summary>
        /// A convert method that takes the user's input amount, 
        /// weight measurement we are converting from, 
        /// and weight measurement we are converting to 
        /// and performs conversion.
        /// </summary>
        /// <param name="inputAmount"></param>
        /// <param name="fromType"></param>
        /// <param name="toType"></param>
        /// <returns></returns>
        public static decimal convert(decimal inputAmount, string fromType, string toType)
        {
            // gets the conversion rate variable from the switch statement for the weight measurement we are converting from
            decimal fromConversionRate = conversionRate(fromType);
            // gets the conversion rate variable from the switch statement for the weight measurement we are converting to
            decimal toConversionRate = conversionRate(toType);
            
            // does the math required to convert and returns the answer
            return inputAmount * toConversionRate / fromConversionRate;
            
        }

        /// <summary>
        /// A conversion rate method that uses a switch statement to get the weight measurement type
        /// from the form and return the appropriate variable for the conversion
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static decimal conversionRate (string type)
        {
            switch (type)
            {
                case "Pounds":
                    return gramsToPounds;
                case "Kilograms":
                    return gramsToKilograms;
                case "Ounces":
                    return gramsToOunces;
                default:
                    return 1;
            }
        }     
    }
}
