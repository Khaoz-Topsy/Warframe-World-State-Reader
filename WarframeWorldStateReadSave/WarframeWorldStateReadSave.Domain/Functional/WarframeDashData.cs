using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace WarframeWorldStateReadSave.Domain.Functional
{
    public class WarframeDashData
    {
        public string readData()
        {
            //var json = new WebClient().DownloadString("http://content.warframe.com/dynamic/worldState.php");
            
            //return json;

            return new WebClient().DownloadString("http://content.warframe.com/dynamic/worldState.php");
        }

        private string RemoveBackSlashes(string corrupted)
        {
            string Result = "";

            return Result;
        }

        private string readDataFromWarframe()
        {
            WebRequest request = WebRequest.Create("http://content.warframe.com/dynamic/worldState.php");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            return reader.ReadToEnd();
        }

        public WarframeWorldStateData readAndConvertWarframeData()
        {
            WebRequest request = WebRequest.Create("http://content.warframe.com/dynamic/worldState.php");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            WarframeWorldStateData WorldState = JsonConvert.DeserializeObject<WarframeWorldStateData>(reader.ReadToEnd());

            if (response.StatusCode.ToString().Equals("OK"))
            {
                return WorldState;
            }

            return null;
        }

        public string WarframeDataFormatted()
        {
            return JValue.Parse(readDataFromWarframe()).ToString(Newtonsoft.Json.Formatting.Indented);
        }
    }
}