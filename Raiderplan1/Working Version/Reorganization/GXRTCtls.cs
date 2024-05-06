
//               File: GXRTCtls
//        Description: Run time reorganization controls
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version eng
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
   public class gxrtctls
   {
      public event ReorganizationMessageEventHandler messageHandler;

      public gxrtctls( ref DataStore ds )
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

      public void execute( ref short aP0_Status )
      {
         this.AV2Status = aP0_Status;
         Initialize();
         executePrivate();
         aP0_Status=this.AV2Status;
      }

      void executePrivate( )
      {
         // DeKlarit formulas
         AV2Status = 0 ;
         // Warning: Status message commands are not valid in C# Objects. Ignored.
         // Warning: Status message commands are not valid in C# Objects. Ignored.
         AV5GXLvl3 = 0 ;
         cmLTCtls2 = connDefault.GetCommand("SELECT TOP 1 [ViajeID] FROM [Viaje] ",false);
         cmLTCtls2.ErrorMask = cmLTCtls2.ErrorMask  |  ErrorMask.Lock;
         LTCtls2 = cmLTCtls2.FetchData();
         while ( cmLTCtls2.HasMoreRows )
         {
            m_ViajeID = dsDefault.Db.GetInt64(LTCtls2, 0, ref m__ViajeIDIsNull) ;
            AV5GXLvl3 = 1 ;
            // Warning: Status message commands are not valid in C# Objects. Ignored.
            AV6GXLvl6 = 0 ;
            cmLTCtls3 = connDefault.GetCommand("SELECT TOP 1 [UsuarioID] FROM [Usuario] WHERE [UsuarioID] = 0 ",false);
            cmLTCtls3.ErrorMask = cmLTCtls3.ErrorMask  |  ErrorMask.Lock;
            LTCtls3 = cmLTCtls3.FetchData();
            while ( cmLTCtls3.HasMoreRows )
            {
               m_UsuarioID = dsDefault.Db.GetInt32(LTCtls3, 0, ref m__UsuarioIDIsNull) ;
               AV6GXLvl6 = 1 ;
               // Warning: Status message commands are not valid in C# Objects. Ignored.
               // Exit For each command. Update data (if necessary), close cursors & exit.
               if (true) break;
               cmLTCtls3.HasMoreRows = LTCtls3.Read();
            }
            LTCtls3.Close();
            if ( ( AV6GXLvl6 == 0 ) )
            {
               AV2Status = 1 ;
               // Warning: Status message commands are not valid in C# Objects. Ignored.
               // Warning: Status message commands are not valid in C# Objects. Ignored.
            }
            // Exit For each command. Update data (if necessary), close cursors & exit.
            if (true) break;
            cmLTCtls2.HasMoreRows = LTCtls2.Read();
         }
         LTCtls2.Close();
         if ( ( AV5GXLvl3 == 0 ) )
         {
            // Warning: Status message commands are not valid in C# Objects. Ignored.
         }
         // Warning: Status message commands are not valid in C# Objects. Ignored.
         // Warning: Status message commands are not valid in C# Objects. Ignored.
         this.Cleanup();
      }

      protected void Cleanup( )
      {
         this.AV2Status = AV2Status;
      }

      // Custom Exceptions
      public void Initialize( )
      {
         resourceManager = Deklarit.Utils.ResourceManager.Instance ;
         resourceManagerTables = new System.Resources.ResourceManager( "Deklarit.Tables", System.Reflection.Assembly.GetExecutingAssembly()) ;
         AV5GXLvl3 = 0 ;
         scmdbuf = "" ;
         m__ViajeIDIsNull = false ;
         m_ViajeID = 0 ;
         AV6GXLvl6 = 0 ;
         m__UsuarioIDIsNull = false ;
         m_UsuarioID = 0 ;
         // GeneXus formulas.
         Gx_err = 0 ;
      }

      private short AV2Status ;
      private short AV5GXLvl3 ;
      private short AV6GXLvl6 ;
      private short Gx_err ;
      private int m_UsuarioID ;
      private long m_ViajeID ;
      private String scmdbuf ;
      private bool m__ViajeIDIsNull ;
      private bool m__UsuarioIDIsNull ;
      private DataStore dsDefault ;
      private System.Resources.ResourceManager resourceManager ;
      private System.Resources.ResourceManager resourceManagerTables ;
      private ReadWriteConnection connDefault ;
      private short aP0_Status ;
      private ReadWriteCommand cmLTCtls2 ;
      private IDataReader LTCtls2 ;
      private ReadWriteCommand cmLTCtls3 ;
      private IDataReader LTCtls3 ;
   }

}
