using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Analystics
{
    public class AnalyticsService : JavaObjectWrapper
    {
        private const string CLASS_NAME = "org.m0skit0.android.hms.unity.activity.AnalyticsService";

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);


        public AnalyticsService() : base("org.m0skit0.android.hms.unity.activity.AnalyticsService", AndroidContext.ApplicationContext) { }

        public void enableLog()
        {
            Call("enableLog");
        }
        public void setUserProfile(String key, String value)
        {
            /*var map = new Dictionary<string, string>();

            // ... Add some keys and values.
            map.Add("key", "orange");
            map.Add("value", "brown");*/

            Call("setUserProfilet", key,value);
        }
    }
}
