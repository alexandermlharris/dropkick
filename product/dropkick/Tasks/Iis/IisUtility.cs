﻿using System;
using dropkick.DeploymentModel;

namespace dropkick.Tasks.Iis
{
    public static class IisUtility
    {
        public static void CheckForIis7(DeploymentResult result)
        {
            int shouldBe6 = Environment.OSVersion.Version.Major;
            if (shouldBe6 != 6)
                result.AddAlert("This machine does not have IIS7 on it");
        }

    }
}
