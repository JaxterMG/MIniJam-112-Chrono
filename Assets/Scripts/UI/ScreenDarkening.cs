using UI;

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
