namespace Raiderplan1.Reorg
{
   using System;
   using Deklarit.Reorganization;

   public class ConsoleReorganization
   {
      public static int Main( )
      {
         IReorganizationProvider rp = new Reorganization();
         rp.MessageHandler += new ReorganizationMessageEventHandler(ConsoleReorganization.DisplayMessage);
         try
         {
            rp.Execute();
         }
         catch (Exception e)
         {
            Console.WriteLine(e.Message);
             return 4;
         }
      return 0;
      }

      public static void DisplayMessage(object sender, ReorganizationMessageEventArgs msg)
      {
           Console.WriteLine(msg.Message);
      }
   }
}
