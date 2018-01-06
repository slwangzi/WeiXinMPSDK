using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Senparc.Weixin.MP.Sample
{
    public class ConfigInfo
    {
        public static string appId;
        public static string secret;

        static ConfigInfo()
        {
            appId = ConfigurationManager.AppSettings["WeixinAppId"];
            secret = ConfigurationManager.AppSettings["WeixinAppSecret"];
        }
    }
}