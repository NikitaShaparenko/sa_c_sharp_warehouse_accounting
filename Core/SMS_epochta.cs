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
    class SMS_epochta
    {
        public string XML = "";

        public string sms_sender;
        public string sms_username;
        public string sms_password;
        public string sms_number;
        public string sms_message;


        public SMS_epochta(string sender, string username, string password, string number, string message)
        {
            XML = "XML=<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" +
                           "<SMS>\n" +
                           "<operations>\n" +
                           "<operation>SEND</operation>\n" +
                           "</operations>\n" +
                           "<authentification>\n" +
                           "<username>" + username + "</username>\n" +
                           "<password>" + password + "</password>\n" +
                           "</authentification>\n" +
                           "<message>\n" +
                           "<sender>" + sender + "</sender>\n" +
                           "<text>" + message + "</text>\n" +
                           "</message>\n" +
                           "<numbers>\n" +
                           "<number messageID=\"msg11\">" + number + "</number>\n" +
                           "</numbers>\n" +
                           "</SMS>\n";

            sms_username = username;
            sms_password = password;
            sms_number = number;
            sms_message = username;
            sms_sender = sender;
        }

        public void SendSMS(string message_prefix = "msg11")
        {
            XML = "XML=<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" +
                           "<SMS>\n" +
                           "<operations>\n" +
                           "<operation>SEND</operation>\n" +
                           "</operations>\n" +
                           "<authentification>\n" +
                           "<username>" + sms_username + "</username>\n" +
                           "<password>" + sms_password + "</password>\n" +
                           "</authentification>\n" +
                           "<message>\n" +
                           "<sender>" + sms_sender + "</sender>\n" +
                           "<text>" + sms_message + "</text>\n" +
                           "</message>\n" +
                           "<numbers>\n" +
                           "<number messageID=\"" + message_prefix + "\">" + sms_number + "</number>\n" +
                           "</numbers>\n" +
                           "</SMS>\n";
            PostXml(XML, message_prefix);
        }

        public string Status(string message_prefix)
        {
            XML = "XML=<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" +
                            "<SMS>\n" +
                            "<operations>\n" +
                            "<operation>GETPRICE</operation>\n" +
                            "</operations>\n" +
                            "<authentification>\n" +
                            "<username>" + sms_username + "</username>\n" +
                            "<password>" + sms_password +"</password>\n" +
                            "</authentification>\n" +
                            "<statistics>\n" +
                            "<messageid>" + message_prefix + "</messageid>\n" +
                            "</statistics>\n" +
                            "</SMS>\n";
            return PostXml(XML, message_prefix);
        }

        public string Price(string message_prefix)
        {
            XML = "XML=<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" +
                            "<SMS>\n" +
                            "<operations>\n" +
                            "<operation>GETPRICE</operation>\n" +
                            "</operations>\n" +
                            "<authentification>\n" +
                            "<username>" + sms_username + "</username>\n" +
                            "<password>" + sms_password + "</password>\n" +
                            "</authentification>\n" +
                            "<message>\n" +
                            "<sender>" + sms_sender + "</sender>\n" +
                            "<text>" + sms_message + "</text>\n" +
                            "</message>\n" +
                            "<numbers>\n" +
                            "<number messageID=\"" + message_prefix +"\">" + sms_number + "</number>\n" +
                            "</numbers>\n" +
                            "</SMS>\n";
            return PostXml(XML, message_prefix);
        }


        public string Balance()
        {
            XML = "XML=<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" +
                         "<SMS>\n" +
                         "<operations>\n" +
                         "<operation>BALANCE</operation>\n" +
                         "</operations>\n" +
                         "<authentification>\n" +
                         "<username>" + sms_username + "</username>\n" +
                         "<password>" + sms_password + "</password>\n" +
                         "</authentification>\n" +
                         "</SMS>\n";
            return PostXml(XML, "Balance");
        }

        string PostXml(string rawXml, string prefix)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create("http://api.myatompark.com/members/sms/xml.php") as HttpWebRequest;
                request.Method = "Post";
                request.ContentType = "application/x-www-form-urlencoded";
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] data = encoding.GetBytes(XML);
                request.ContentLength = data.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(data, 0, data.Length);
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception(String.Format(
                             "Server error (HTTP {0}: {1}).",
                             response.StatusCode,
                             response.StatusDescription));
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    return (reader.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                SMS sms = new SMS(sms_sender, sms_username, sms_password, sms_number, sms_message);
                sms.Error_register(prefix, ex.ToString());
                return "ex";
            }

        }
    }
}
