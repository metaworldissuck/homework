using System;
using System.Threading;
using System.Net;

using System.IO;
using System.Runtime.Serialization;

namespace Web2StringTryIt
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string parameter = TextBox1.Text;
        
            string baseUri = "http://localhost:50344/Service1.svc/GetWebContent?weburl=";
            //string baseUri = "https://venus.sod.asu.edu/WSRepository/Services/Web2StringREST/Service1.svc/GetWebContent?weburl=";
            string completeUri = baseUri + parameter;
            string result = "";
            WebClient channel = new WebClient(); // create a channel
            //String result = channel.DownloadString(finalUri); // return a String
            byte[] abc = channel.DownloadData(completeUri); // return byte array
            Stream strm = new MemoryStream(abc); // convert to mem stream
            StreamReader reader = new StreamReader(strm); // Create read object from mem stream
            while (!reader.EndOfStream) 
            { result += reader.ReadLine(); } // Create read object
            Label2.Text = result;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.Text = "";
        }
    }
}