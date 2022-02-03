using System;
using Business.Interfaces;
using Newtonsoft.Json;

namespace Business.Utils
{
    public static class Extensions
    {
        public static Boolean IsOdd(this int value)
        {
            return value % 2 != 0;
        }

        public static Boolean IsPair(this int value)
        {
            return value % 2 == 0;
        }

        public static T Copy<T>(this T item) where T : ICopy
        {
            if (item.FullCopy)
            {

            }
            else
            {

            }

            string serializado = JsonConvert.SerializeObject(item);
            return JsonConvert.DeserializeObject<T>(serializado);
        }
    }
}