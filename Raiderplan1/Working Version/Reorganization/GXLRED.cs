
//               File: GXLRED
//        Description: Load redundancy procedure
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5_0.002
//       Program type: Callable routine
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1.Reorg {
   using System;
   using System.Collections;
   using Deklarit.Utils;
   using System.Threading;
   using Deklarit.Reorganization;
   using Raiderplan1.Reorg;
   using System.Data;
   using System.Data.SqlClient;
   using System.Data.Common;
   using Deklarit.Data;
   using System.Xml.Serialization;
   using System.Data.SqlTypes;
   public class gxlred
   {
      public event ReorganizationMessageEventHandler messageHandler;

      public gxlred( ref DataStore ds )
      {
         this.dsDefault = ds ;
         this.messageHandler = messageHandler ;
         connDefault = dsDefault.GetReadWriteConnection() ;
         Initialize( ) ;
      }

      public void AddMsg( string message )
      {
         if ( ( this.messageHandler != null ) )
         {
            this.messageHandler( this, new ReorganizationMessageEventArgs( message)) ;
         }
      }

      public void execute( )
      {
         Initialize();
         executePrivate();
      }

      void executePrivate( )
      {
         // DeKlarit formulas
         this.Cleanup();
      }

      protected void Cleanup( )
      {
      }

      // Custom Exceptions
      public void Initialize( )
      {
         resourceManager = Deklarit.Utils.ResourceManager.Instance ;
         resourceManagerTables = new System.Resources.ResourceManager( "Deklarit.Tables", System.Reflection.Assembly.GetExecutingAssembly()) ;
         // GeneXus formulas.
         Gx_err = 0 ;
      }

      private short Gx_err ;
      private DataStore dsDefault ;
      private System.Resources.ResourceManager resourceManager ;
      private System.Resources.ResourceManager resourceManagerTables ;
      private ReadWriteConnection connDefault ;
   }

}
