using System;
using System.Threading;
using System.Net;
using System.IO;
using System.Runtime.Serialization;

namespace Web2StringSVC
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetWebContent(string url)
        {

            if (string.IsNullOrEmpty(url))
            {
                return null;
            }
            //string sContent = null;
            try
            {


                WebClient channel = new WebClient(); // create a channel

                String sContent = channel.DownloadString(url); // return byte array
                //Stream strm = new MemoryStream(abc); // convert to mem stream
                //DataContractSerializer obj = new DataContractSerializer(typeof(string));
                //string sContent = obj.ReadObject(strm).ToString(); // convent to string
                return sContent;

            }
            catch
            {
                throw new Exception(string.Format("Request url: {0} failed !", url));
            }
        }
    }
}