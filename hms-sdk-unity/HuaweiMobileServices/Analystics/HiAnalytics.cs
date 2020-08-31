using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Analystics
{
    public class HiAnalytics : JavaObjectWrapper
    {
        // private static AndroidJavaClass analyticsClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.activity.AnalyticsService");
        private static AndroidJavaClass analyticsClass = new AndroidJavaClass("com.huawei.hms.analytics.HiAnalytics");    

        private static HiAnalyticsInstance hiAnalyticsInstance = null;

        public HiAnalytics( ) : base("com.huawei.hms.analytics.HiAnalytics") { }

        public static void enableLog()
        {
            analyticsClass.Call("enableLog");
            return;
        }
       
        public static HiAnalyticsInstance getInstance(AndroidJavaObject context)
        {
            if (hiAnalyticsInstance == null)
            {
                Debug.Log("[HMS] hiAnalyticsInstance getInstancexx");
 
                AndroidJavaObject analyticsClassObject = analyticsClass.CallStatic<AndroidJavaObject>("getInstance",context);//vgetInstance
                hiAnalyticsInstance = new HiAnalyticsInstance(analyticsClassObject);
                
                Debug.Log("[HMS] hiAnalyticsInstance getInstancexx2");

            }
            return hiAnalyticsInstance;
        }
    }
}
