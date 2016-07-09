using HtmlAgilityPack;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


public class UploadToSuar
{
    public static string UploadImage(Image img)
    {
        try
        {
            CookieContainer cookie = new CookieContainer();

            string Token = string.Empty;

            string Url = "https://www.suar.me/";

            RestClient client = new RestClient(Url);

            client.CookieContainer = cookie;

            RestRequest Request = new RestRequest(Method.POST);

            Request.AddHeader("Origin", "https://www.suar.me");
            Request.AddHeader("Accept", "*/*;q=0.5, text/javascript, application/javascript, application/ecmascript, application/x-ecmascript");
            Request.AddHeader("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            Request.AddHeader("Accept-Encoding", "gzip, deflate, br");

            IRestResponse tokenpage = client.Execute(Request);

            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(tokenpage.Content);
            HtmlNode node = doc.DocumentNode.SelectSingleNode("//input[@name='authenticity_token']");

            if (node != null)
            {
                Token = node.GetAttributeValue("value", "");
            }

            string UploadsUrl = "https://suar.me/uploads";

            client.BaseUrl = new Uri(UploadsUrl);

            Request = new RestRequest(Method.POST);

            Request.AddHeader("Origin", "https://www.suar.me");
            Request.AddHeader("Accept", "*/*;q=0.5, text/javascript, application/javascript, application/ecmascript, application/x-ecmascript");
            Request.AddHeader("Content-Type", "multipart/form-data; boundary=----WebKitFormBoundaryiUnbhAIVaTVDEPdZ");
            Request.AddHeader("Accept-Encoding", "gzip, deflate, br");

            Request.AddParameter("utf8", "✓");
            Request.AddParameter("authenticity_token", Token);
            Request.AddFile("upload", AssistOperation.ImageToByteArray(img), "image/png");

            IRestResponse uploaded = client.Execute(Request);

            RootObject upresult = SimpleJson.DeserializeObject<RootObject>(uploaded.Content);

            upresult.upload.cdn_url = string.Format("https:{0}", upresult.upload.cdn_url);

            if (AssistOperation.IsUrl(upresult.upload.cdn_url))
            {
                return upresult.upload.cdn_url;
            }
        }
        catch
        {
        }

        return FreeSnippingTool.CommonStrings.ErrorWhileUploading;
    }
}

