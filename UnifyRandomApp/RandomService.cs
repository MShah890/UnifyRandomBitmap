using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Linq;

namespace UnifyRandomApp
{
    public class RandomService
    {
        private static string url = "https://www.random.org/";

        public static Byte[] GetRandomIntegers()
        {
            //Getting 100 different random numbers in range 0 to 255 to use for R,G,B values
            string r_url = url + "integers/?num=100&min=0&max=255&col=1&base=10&format=plain&rnd=new";

            HttpClient client = new HttpClient();

            HttpResponseMessage response = client.GetAsync(r_url).Result;

            string output = response.Content.ReadAsStringAsync().Result;

            //splitting plain-text by \n to get numbers
            string[] random_nos = output.Split('\n');

            byte[] random_array = new byte[100];

            for (int i = 0; i < 100; i++)
            {
                random_array[i] = Convert.ToByte(random_nos[i]);
            }

            return random_array;
        }
    }
}
