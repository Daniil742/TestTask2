using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace TestTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            _ = PostRequestAsync();
            Console.ReadKey();
        }

        private static async Task PostRequestAsync()
        {
            HttpWebRequest request = WebRequest.Create("https://api.stackexchange.com/docs/search#order=desc&sort=activity&intitle=beautiful&filter=default&site=stackoverflow&run=true") as HttpWebRequest;
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                Console.WriteLine(reader.ReadToEnd()); 
            }

            //HttpWebRequest request = WebRequest.Create("https://api.stackexchange.com/docs/search#order=desc&sort=activity&intitle=beautiful&filter=default&site=stackoverflow&run=true") as HttpWebRequest;
            //WebResponse response = await request.GetResponseAsync();
            //using (Stream stream = response.GetResponseStream())
            //{
            //    using (StreamReader reader = new StreamReader(stream))
            //    {
            //        Console.WriteLine(reader.ReadToEnd());
            //    }
            //}
            //response.Close();

            //WebRequest request = WebRequest.Create("https://api.stackexchange.com/docs/search#");
            //request.Method = "POST"; // для отправки используется метод Post
            //                         // данные для отправки
            //string data = "order=desc&max=1&sort=activity&intitle=beautiful&filter=default&site=stackoverflow&run=true";
            //// преобразуем данные в массив байтов
            //byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(data);
            //// устанавливаем тип содержимого - параметр ContentType
            //request.ContentType = "application/x-www-form-urlencoded";
            //// Устанавливаем заголовок Content-Length запроса - свойство ContentLength
            //request.ContentLength = byteArray.Length;

            ////записываем данные в поток запроса
            //using (Stream dataStream = request.GetRequestStream())
            //{
            //    dataStream.Write(byteArray, 0, byteArray.Length);
            //}

            //WebResponse response = await request.GetResponseAsync();
            //using (Stream stream = response.GetResponseStream())
            //{
            //    using (StreamReader reader = new StreamReader(stream))
            //    {
            //        Console.WriteLine(reader.ReadToEnd());
            //    }
            //}
            //response.Close();
            //Console.WriteLine("Запрос выполнен...");
        }
    }
}
