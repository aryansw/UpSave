using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UpSave
{
    public class Cookies
    {
        public static String cookie_name = "Account ID";

        public static void WriteCookie(string id_string, HttpResponse response)
        {
            HttpCookie cookie = new HttpCookie(Cookies.cookie_name);

            cookie.Value = id_string;

            DateTime current_time = DateTime.Now;
            cookie.Expires = current_time + new TimeSpan(0, 12, 0, 0);
            response.Cookies.Add(cookie);

        }

        public static void DeleteCookie(HttpRequest Request, HttpResponse Response)
        {
            if (Request.Cookies[cookie_name] != null)
            {
                Response.Cookies[cookie_name].Expires = DateTime.Now.AddDays(-1);
            }
        }
        public static string ReadCookie(HttpRequest Request, HttpResponse Response)
        {
            //Grab the cookie
            HttpCookie cookie = Request.Cookies[Cookies.cookie_name];

            //Check to make sure the cookie exists
            if (null == cookie)
            {
                return string.Empty;
            }
            else
            {
                //Write the cookie value
                String strCookieValue = cookie.Value.ToString();
                return strCookieValue;
                //Response.Write("The " + cookieName + " cookie contains: <b>"
                //                      + strCookieValue + "</b><br><hr>");
            }
        }
    }
}