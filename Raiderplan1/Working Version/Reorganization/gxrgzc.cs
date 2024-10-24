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
namespace Raiderplan1.Reorg {
   public class gxrgzc
   {
      public event ReorganizationMessageEventHandler messageHandler;

      public gxrgzc( DataStore ds ,
                     ReorganizationMessageEventHandler messageHandler )
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
         executePrivate();
      }

      void executePrivate( )
      {
         //
            //
            // This program controls table creation either for the creation or
            // reorganization processes.
            //
            //
            // Rename auxiliary tables to the appropriate name.
         //
         AddMsg( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("rgzrnmtbl"), new   object[]  {"6"}) );
         AddMsg( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("fileren"), new   object[]  {"GXA0008", "Viaje"}) );
         //
            //
            // Drop table in SQLServer with FKs
            //
         //
         cmsysreferencesSelect3 = connDefault.GetCommand("SELECT OBJECT_NAME(constid), OBJECT_NAME(fkeyid), [rkeyid] FROM [sysreferences] WHERE [rkeyid] = OBJECT_ID('[Viaje]') ",true);
         cmsysreferencesSelect3.ErrorMask = cmsysreferencesSelect3.ErrorMask  |  ErrorMask.Lock;
         sysreferencesSelect3 = cmsysreferencesSelect3.FetchData();
         while ( cmsysreferencesSelect3.HasMoreRows )
         {
            constid = dsDefault.Db.GetString(sysreferencesSelect3, 0, ref nconstid) ;
            fkeyid = dsDefault.Db.GetString(sysreferencesSelect3, 1, ref nfkeyid) ;
            rkeyid = dsDefault.Db.GetInt32(sysreferencesSelect3, 2, ref nrkeyid) ;
            cmdBuffer = "ALTER TABLE " + "[" + fkeyid + "] DROP CONSTRAINT " + constid ;
            RGZ = connDefault.GetCommand(cmdBuffer,false);
            RGZ.IDbCommand.CommandTimeout = 0;
            RGZ.ExecuteStmt() ;
            cmsysreferencesSelect3.HasMoreRows = sysreferencesSelect3.Read();
         }
         sysreferencesSelect3.Close();
         cmdBuffer=" DROP TABLE [Viaje] "
         ;
         RGZ = connDefault.GetCommand(cmdBuffer,false);
         RGZ.IDbCommand.CommandTimeout = 0;
         RGZ.ErrorMask = RGZ.ErrorMask  |  ErrorMask.FileNotFound;
         RGZ.ExecuteStmt() ;
         //
            //
            // END Drop table in SQLServer with FKs
            //
         //
         RGZ = connDefault.GetNewCommand("sp_rename", false);
         RGZ.IDbCommand.CommandType = CommandType.StoredProcedure;
         RGZ.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@objname", "[GXA0008]"));
         RGZ.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@newname", "Viaje"));
         RGZ.ExecuteStmt();
         RGZ.IDbCommand.CommandType = CommandType.Text;
         cmdBuffer=" ALTER TABLE [Viaje] ADD PRIMARY KEY([ViajeID]) "
         ;
         RGZ = connDefault.GetCommand(cmdBuffer,false);
         RGZ.IDbCommand.CommandTimeout = 0;
         RGZ.ExecuteStmt() ;
         // Adding attributes to tables' structure.
         AddMsg( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("rgzbldidx"), new   object[]  {"7"}) );
         // Indices for table Viaje
         AddMsg( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("creaindx"), new   object[]  {"IViaje"}) );
         AddMsg( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("creaindx"), new   object[]  {"IViaje1"}) );
         cmdBuffer=" DROP INDEX [Viaje].[IViaje1] "
         ;
         RGZ = connDefault.GetCommand(cmdBuffer,false);
         RGZ.IDbCommand.CommandTimeout = 0;
         RGZ.ErrorMask = RGZ.ErrorMask  |  ErrorMask.FileNotFound;
         RGZ.ExecuteStmt() ;
         cmdBuffer=" CREATE NONCLUSTERED INDEX [IViaje1] ON [Viaje] ([UsuarioID] ) "
         ;
         RGZ = connDefault.GetCommand(cmdBuffer,false);
         RGZ.IDbCommand.CommandTimeout = 0;
         RGZ.ExecuteStmt() ;
         // Referential constraints on table Viaje
         cmdBuffer=" ALTER TABLE [Viaje] DROP CONSTRAINT IViaje1 "
         ;
         RGZ = connDefault.GetCommand(cmdBuffer,false);
         RGZ.IDbCommand.CommandTimeout = 0;
         RGZ.ErrorMask = RGZ.ErrorMask  |  ErrorMask.FileNotFound;
         RGZ.ExecuteStmt() ;
         cmdBuffer=" ALTER TABLE [Viaje] ADD CONSTRAINT IViaje1 FOREIGN KEY ([UsuarioID]) REFERENCES [Usuario] ([UsuarioID]) "
         ;
         RGZ = connDefault.GetCommand(cmdBuffer,false);
         RGZ.IDbCommand.CommandTimeout = 0;
         RGZ.ExecuteStmt() ;
         // Referential constraints on table TrayectoViaje
         cmdBuffer=" ALTER TABLE [TrayectoViaje] DROP CONSTRAINT ITrayectoViaje2 "
         ;
         RGZ = connDefault.GetCommand(cmdBuffer,false);
         RGZ.IDbCommand.CommandTimeout = 0;
         RGZ.ErrorMask = RGZ.ErrorMask  |  ErrorMask.FileNotFound;
         RGZ.ExecuteStmt() ;
         cmdBuffer=" ALTER TABLE [TrayectoViaje] ADD CONSTRAINT ITrayectoViaje2 FOREIGN KEY ([ViajeID]) REFERENCES [Viaje] ([ViajeID]) "
         ;
         RGZ = connDefault.GetCommand(cmdBuffer,false);
         RGZ.IDbCommand.CommandTimeout = 0;
         RGZ.ExecuteStmt() ;
         // Referential constraints on table ComentarioViaje
         cmdBuffer=" ALTER TABLE [ComentarioViaje] DROP CONSTRAINT IComentarioViaje1 "
         ;
         RGZ = connDefault.GetCommand(cmdBuffer,false);
         RGZ.IDbCommand.CommandTimeout = 0;
         RGZ.ErrorMask = RGZ.ErrorMask  |  ErrorMask.FileNotFound;
         RGZ.ExecuteStmt() ;
         cmdBuffer=" ALTER TABLE [ComentarioViaje] ADD CONSTRAINT IComentarioViaje1 FOREIGN KEY ([ViajeID]) REFERENCES [Viaje] ([ViajeID]) "
         ;
         RGZ = connDefault.GetCommand(cmdBuffer,false);
         RGZ.IDbCommand.CommandTimeout = 0;
         RGZ.ExecuteStmt() ;
         AddMsg( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("rgzdroptbl"), new   object[]  {"8"}) );
         // Dropping attributes from tables' structure.
         // Dropping removed tables
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
         constid = "" ;
         fkeyid = "" ;
         rkeyid = 0 ;
         scmdbuf = "" ;
         nconstid = false ;
         nfkeyid = false ;
         nrkeyid = false ;
         cmdBuffer = "" ;
         // GeneXus formulas.
      }

      protected int rkeyid ;
      protected String scmdbuf ;
      protected String cmdBuffer ;
      protected bool nconstid ;
      protected bool nfkeyid ;
      protected bool nrkeyid ;
      protected String constid ;
      protected String fkeyid ;
      protected DataStore dsDefault ;
      protected System.Resources.ResourceManager resourceManager ;
      protected System.Resources.ResourceManager resourceManagerTables ;
      protected ReadWriteConnection connDefault ;
      protected ReadWriteCommand cmsysreferencesSelect3 ;
      protected IDataReader sysreferencesSelect3 ;
      protected ReadWriteCommand RGZ ;
   }

}
