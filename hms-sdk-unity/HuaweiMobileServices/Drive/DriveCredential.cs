using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class DriveCredential : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public DriveCredential(AndroidJavaObject javaObject) : base(javaObject) {  }

        private const string CLASS_NAME = "com.huawei.hms.ads.reward.RewardAd";

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);


    }
}
