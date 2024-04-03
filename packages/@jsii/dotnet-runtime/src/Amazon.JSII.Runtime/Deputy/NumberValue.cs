using Newtonsoft.Json;
using System;

namespace Amazon.JSII.Runtime.Deputy
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    internal sealed class NumberValue
    {
        public NumberValue(double number)
        {
            if (double.IsInfinity(number))
            {
                Number = "Infinity";
            }
            else if (double.IsNegativeInfinity(number))
            {
                Number = "-Infinity";
            }
            else if (double.IsNaN(number))
            {
                Number = "NaN";
            }
            else
            {
                Number = number.ToString();
            }
        }

        [JsonProperty("$jsii.number")]
        public string Number { get; }
    }
}
