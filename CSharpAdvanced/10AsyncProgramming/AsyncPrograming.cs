using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced._10AsyncProgramming
{
    //Synchronous Program Execution -> Program is executed line by line, one at a time.
    //When a function is called, program execution has to wait until the function returns a value.

    //Asynchronous Program Execution -> When a function is called, program execution continues to the next line WITHOUT waiting for the function to complete.
    //Async improves the responsivenss of the application
    //Ex - Browser, Media Player

    //How to achieve?
    //Traditionally -> Multi Threading, Callbacks -> tough to learn
    //.NET 4.5 approach -> Async / Await -> Task based asynchronous application
    internal class AsyncPrograming
    {

        //Synchronouus
        public void DownloadHTML(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter("dfdfdf"))
            {
                streamWriter.Write(html);
            }
        }

        //Return Task -> A task is an object that encapsulates the state of an asynchronous operation. Has two forms -> genric and normal -> use genric in case of a retuern type, non generic if void return.
        public async Task DownloadHTMLAsync (string url) //add Async as suffix for async methods
        {

            //almost every operation has a async version of it now
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url); // add await operator that helps the compiler know that this task is gonna take time so it returns the control immediately so the compiler can move forward. and then use the Async method.
            //await operatior can only be used in an async method.
            using (var streamWriter = new StreamWriter("dfdfdf"))
            {
                await streamWriter.WriteAsync(html);
            }
        }

        public async Task<string> GetHtmlAsync(string url)
        {
            var webC = new WebClient();
            return await webC.DownloadStringTaskAsync(url);
        }
    }
}
