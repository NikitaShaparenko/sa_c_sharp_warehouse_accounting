using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseAccounting.Core
{
    public class SMS
    {
        string lcl_username = "";
        string lcl_password = "";
        string lcl_number = "";
        string lcl_message = "";
        string lcl_sender = "";

        public SMS(string sender,string username, string password, string number, string message)
        {
            lcl_message = message;
            lcl_number = number;
            lcl_password = password;
            lcl_username = username;
            lcl_sender = sender;
        }

        string error_phrase = "";
        string error_id = "";

        public void Error_register(string id, string text)
        {
            error_id = id;
            error_phrase = text;
        }

        public void SMS_epochta_SendMessage()
        {
            SMS_epochta SMS_e = new SMS_epochta(lcl_sender,lcl_username, lcl_password, lcl_number, lcl_message);
            SMS_e.SendSMS();
        }
        public string SMS_epochta_AskForBalance()
        {
            SMS_epochta SMS_e = new SMS_epochta(lcl_sender, lcl_username, lcl_password, lcl_number, lcl_message);
            return SMS_e.Balance();
        }

        public string SMS_epochta_AskForStatus(string message_id)
        {
            SMS_epochta SMS_e = new SMS_epochta(lcl_sender, lcl_username, lcl_password, lcl_number, lcl_message);
            return SMS_e.Status(message_id);
        }

        public string SMS_epochta_AskForAPrice(string message_id)
        {
            SMS_epochta SMS_e = new SMS_epochta(lcl_sender, lcl_username, lcl_password, lcl_number, lcl_message);
            return SMS_e.Price(message_id);
        }


      
        public void API_SMS_epochta_com_ua()
        {
            //https://www.epochta.com.ua/products/sms/sms-api.php
        }

        public string PostAndGetHTML(string targetURL)
        {
            string html = string.Empty;
            string url = targetURL;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            return html;
        }

        public void PostXml(string destinationUrl, string rawXml)
        {
            var client = new RestClient();
            // string rawXml = @"<?xml version=""1.0"" encoding=""utf-8""?><request><Username></Username><Password></Password></request>";

            client.BaseUrl = new Uri(destinationUrl);
            var request = new RestRequest(Method.POST);

            request.Timeout = 3000;
            request.ReadWriteTimeout = 3000;

            request.AddParameter("text/html", rawXml, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
        }

    }
}
