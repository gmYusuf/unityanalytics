using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Analystics
{

    public sealed class HiAnalyticsInstance : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public HiAnalyticsInstance(AndroidJavaObject hiAnalyticsInstance) : base(hiAnalyticsInstance) {}

        public void setAnalyticsEnabled(bool enabled)
        {
            Call("setAnalyticsEnabled", enabled);
        }
        public void setAutoCollectionEnabled(bool isEnabled)
        {
            Call("setAutoCollectionEnabled", isEnabled);
        }

        public void setUserId(String id)
        {
            Call("setUserId", id);
        }
        public void setUserProfile(String name, String value)
        {
            Call("setUserProfile", name, value);
        }
        public void setPushToken(String token)
        {
            Call("setPushToken", token);
        }
        public void setMinActivitySessions(long milliseconds)
        {
            Call("setMinActivitySessions", milliseconds);
        }
        public void setSessionDuration(long milliseconds)
        {
            Call("setSessionDuration", milliseconds);
        }
        public void setCurrentActivity(String activityName, String activityClassOverride)
        {
            //AndroidContext activity, 
            Call("setCurrentActivity", activityName, activityClassOverride);
        }
        public void onEvent(String eventId, AndroidBundle androidBundle)
        {
            Call("onEvent", eventId, androidBundle);
        }
        public void clearCachedData()
        {
            Call("clearCachedData");
        }
        public void getAAID()
        {
            //return Call<TaskJavaObjectWrapper<int>>("getAAID");ITask<String>
        }
        //public virtual ITask<String> AAID => CallStaticAsWrapper<TaskJavaObjectWrapper<string>>("getAAID");

        public void regHmsSvcEvent()
        {
            Call("regHmsSvcEvent");
        }
        public void unRegHmsSvcEvent()
        {
            Call("unRegHmsSvcEvent");
        }
        public int getUserProfiles(bool preDefined)
        {
            return 1;
        }
        public void pageStart(String pageName, String pageClassOverride)
        {
            Call("pageStart", pageName, pageClassOverride);
        }
        public void pageEnd(String pageName)
        {
            Call("pageEnd", pageName);
        }



    }

}

