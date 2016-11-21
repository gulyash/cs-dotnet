using System;
using System.Collections.Generic;
using System.Linq;

namespace dotnetlab6.Kitchen
{
    class FillingsGenerator
    {
        private static readonly Random random = new Random();
        
        /// <summary>
        /// generates defined number of fillings
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public List<Filling> generateFillings(int num) {
            List<Filling> result = new List<Filling>();
            for (int i=0; i<num; i++) {
                result.Add(generateFilling());
                //Console.WriteLine(result.Last<Filling>().name);
            }
            return result;

        }

        /// <summary>
        /// generates one filling
        /// </summary>
        /// <returns></returns>
        private Filling generateFilling()
        {
            return new Filling(RandomString(8));
        }

        //генерирует случайную строку длины length
        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    } 
}
