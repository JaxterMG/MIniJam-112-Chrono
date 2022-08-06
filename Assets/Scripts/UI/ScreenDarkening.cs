using System;
using System.Collections;
using System.Collections.Generic;
using UI;
using UnityEngine;

public class ScreenDarkening : UIWindow
{
   public static ScreenDarkening Instance;
   private void Start()
   {
      Instance = this;
   }

   public void EnableDarkScreen()
   {
      ShowWindow("EnableDarkScreen");
   }
   public void DisableDarkScreen()
   {
      ShowWindow("DisableDarkScreen");
   }
}
