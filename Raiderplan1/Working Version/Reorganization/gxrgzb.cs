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
   public class gxrgzb
   {
      public event ReorganizationMessageEventHandler messageHandler;

      public gxrgzb( DataStore ds ,
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
            // Execute reorganization programs (none if creating the database).
         //
         AddMsg( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("rgzrrpgm"), new   object[]  {"4"}) );
         AddMsg( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("runpgm"), new   object[]  {"C10"}) );
         new c10(ref dsDefault).execute( ) ;
         // Creating final tables.
         AddMsg( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("filecrea"), new   object[]  {"TrayectoViaje", ""}) );
         //
            //
            // Drop table in SQLServer with FKs
            //
         //
         cmsysreferencesSelect2 = connDefault.GetCommand("SELECT OBJECT_NAME(constid), OBJECT_NAME(fkeyid), [rkeyid] FROM [sysreferences] WHERE [rkeyid] = OBJECT_ID('[TrayectoViaje]') ",true);
         cmsysreferencesSelect2.ErrorMask = cmsysreferencesSelect2.ErrorMask  |  ErrorMask.Lock;
         sysreferencesSelect2 = cmsysreferencesSelect2.FetchData();
         while ( cmsysreferencesSelect2.HasMoreRows )
         {
            constid = dsDefault.Db.GetString(sysreferencesSelect2, 0, ref nconstid) ;
            fkeyid = dsDefault.Db.GetString(sysreferencesSelect2, 1, ref nfkeyid) ;
            rkeyid = dsDefault.Db.GetInt32(sysreferencesSelect2, 2, ref nrkeyid) ;
            cmdBuffer = "ALTER TABLE " + "[" + fkeyid + "] DROP CONSTRAINT " + constid ;
            RGZ = connDefault.GetCommand(cmdBuffer,false);
            RGZ.IDbCommand.CommandTimeout = 0;
            RGZ.ExecuteStmt() ;
            cmsysreferencesSelect2.HasMoreRows = sysreferencesSelect2.Read();
         }
         sysreferencesSelect2.Close();
         cmdBuffer=" DROP TABLE [TrayectoViaje] "
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
         cmdBuffer=" CREATE TABLE [TrayectoViaje] ([TrayectoViajeID] int NOT null  IDENTITY(1,1), [ViajeID] bigint NOT null , [TrayectoOrigen] varchar(150) null , [TayectoLatitudOrigen] decimal( 17, 15) null , [TrayectoLongitudOrigen] decimal( 17, 15) null , [TrayectoLatidudDestino] decimal( 17, 15) null , [TrayectoLongitudDestino] decimal( 17, 15) null , [Trayectokm] smallmoney null , [TiempoEstimado] smallmoney null , [CombustibleConsumido] smallmoney null , [EstadoCarretera] varchar(100) null , [TrayectoDestino] varchar(50) NOT null , [Instrucciones] varchar(MAX) null , [Orden] int null , PRIMARY KEY([TrayectoViajeID]))  "
         ;
         RGZ = connDefault.GetCommand(cmdBuffer,false);
         RGZ.IDbCommand.CommandTimeout = 0;
         RGZ.ExecuteStmt() ;
         // Dropping temporary indexes.
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
      protected ReadWriteCommand cmsysreferencesSelect2 ;
      protected IDataReader sysreferencesSelect2 ;
      protected ReadWriteCommand RGZ ;
   }

}
