
//               File: C7
//        Description: Conversion for table Usuario
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
   public class c7
   {
      public event ReorganizationMessageEventHandler messageHandler;

      public c7( ref DataStore ds )
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
         // Optimized copy (Insert w/Subselect).
         cmdBuffer=" SET IDENTITY_INSERT [GXA0007] ON "
         ;
         RGZ = connDefault.GetCommand(cmdBuffer,false);
         RGZ.IDbCommand.CommandTimeout = 0;
         RGZ.ExecuteStmt() ;
         cmC72 = connDefault.GetCommand("INSERT INTO [GXA0007] ([UsuarioID], [UsuarioNombre], [UsuarioActivo], [UsuarioEmail], [UsuarioPasword], [UsuarioFechaAlta], [PersonaID], [CodigoValidation]) SELECT [UsuarioID], [UsuarioNombre], [UsuarioActivo], [UsuarioEmail], [UsuarioPasword], [UsuarioFechaAlta], [PersonaID], [CodigoValidation]  FROM [Usuario]",false);
         // Using cursor C72
         cmC72.ExecuteStmt();
         cmdBuffer=" SET IDENTITY_INSERT [GXA0007] OFF "
         ;
         RGZ = connDefault.GetCommand(cmdBuffer,false);
         RGZ.IDbCommand.CommandTimeout = 0;
         RGZ.ExecuteStmt() ;
         // End optimized group.
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
         cmdBuffer = "" ;
         // GeneXus formulas.
         Gx_err = 0 ;
      }

      private short Gx_err ;
      private String cmdBuffer ;
      private DataStore dsDefault ;
      private System.Resources.ResourceManager resourceManager ;
      private System.Resources.ResourceManager resourceManagerTables ;
      private ReadWriteConnection connDefault ;
      private ReadWriteCommand RGZ ;
      private ReadWriteCommand cmC72 ;
   }

}
