namespace Raiderplan1.Reorg
{
   using System;
   using System.Collections;
   using Deklarit.Reorganization;

   public class WinFormReorganization
      {
         [STAThread]
         public static void Main( )
         {
            System.Windows.Forms.Application.Run(new FrmReorg(new Reorganization()));
         }
      }
}


