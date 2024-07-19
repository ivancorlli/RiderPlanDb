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
   public class gxrgza
   {
      public event ReorganizationMessageEventHandler messageHandler;

      public gxrgza( DataStore ds ,
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
            // This is the first program in the reorganization process.
            // It must be compiled and run before any other reorganization
            // program.
            //
         //
         // API odbc Driver qesqlserver does not require or allow remote
         // database creation.
         // Lock tables
         AddMsg( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("rgzlcktb"), new   object[]  {"1"}) );
         // Load data into tables.
         // Drop integrity constraints (if any).
         AddMsg( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("rgzdic"), new   object[]  {"2"}) );
         AddMsg( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("rgzd1c"), new   object[]  {"TrayectoViaje"}) );
         cmdBuffer=" ALTER TABLE [TrayectoViaje] DROP CONSTRAINT ITrayectoViaje2 "
         ;
         RGZ = connDefault.GetCommand(cmdBuffer,false);
         RGZ.IDbCommand.CommandTimeout = 0;
         RGZ.ErrorMask = RGZ.ErrorMask  |  ErrorMask.FileNotFound;
         RGZ.ExecuteStmt() ;
         // Create new and temporary tables.
         AddMsg( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("rgzctnt"), new   object[]  {"3"}) );
         AddMsg( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("filecrea"), new   object[]  {"GXA0010", ""}) );
         //
            //
            // Drop table in SQLServer with FKs
            //
         //
         cmsysreferencesSelect1 = connDefault.GetCommand("SELECT OBJECT_NAME(constid), OBJECT_NAME(fkeyid), [rkeyid] FROM [sysreferences] WHERE [rkeyid] = OBJECT_ID('[GXA0010]') ",true);
         cmsysreferencesSelect1.ErrorMask = cmsysreferencesSelect1.ErrorMask  |  ErrorMask.Lock;
         sysreferencesSelect1 = cmsysreferencesSelect1.FetchData();
         while ( cmsysreferencesSelect1.HasMoreRows )
         {
            constid = dsDefault.Db.GetString(sysreferencesSelect1, 0, ref nconstid) ;
            fkeyid = dsDefault.Db.GetString(sysreferencesSelect1, 1, ref nfkeyid) ;
            rkeyid = dsDefault.Db.GetInt32(sysreferencesSelect1, 2, ref nrkeyid) ;
            cmdBuffer = "ALTER TABLE " + "[" + fkeyid + "] DROP CONSTRAINT " + constid ;
            RGZ = connDefault.GetCommand(cmdBuffer,false);
            RGZ.IDbCommand.CommandTimeout = 0;
            RGZ.ExecuteStmt() ;
            cmsysreferencesSelect1.HasMoreRows = sysreferencesSelect1.Read();
         }
         sysreferencesSelect1.Close();
         cmdBuffer=" DROP TABLE [GXA0010] "
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
         cmdBuffer=" CREATE TABLE [GXA0010] ([TrayectoViajeID] int NOT null  IDENTITY(1,1), [ViajeID] bigint NOT null , [TrayectoOrigen] varchar(150) null , [TayectoLatitudOrigen] decimal( 17, 15) null , [TrayectoLongitudOrigen] decimal( 17, 15) null , [TrayectoLatidudDestino] decimal( 17, 15) null , [TrayectoLongitudDestino] decimal( 17, 15) null , [Trayectokm] smallmoney null , [TiempoEstimado] smallmoney null , [CombustibleConsumido] smallmoney null , [EstadoCarretera] varchar(100) null , [TrayectoDestino] varchar(50) NOT null , [Instrucciones] varchar(MAX) null , [Orden] int null )  "
         ;
         RGZ = connDefault.GetCommand(cmdBuffer,false);
         RGZ.IDbCommand.CommandTimeout = 0;
         RGZ.ExecuteStmt() ;
         // Creating temporary indexes.
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
         constid = "" ;
         fkeyid = "" ;
         rkeyid = 0 ;
         scmdbuf = "" ;
         nconstid = false ;
         nfkeyid = false ;
         nrkeyid = false ;
         // GeneXus formulas.
      }

      protected int rkeyid ;
      protected String cmdBuffer ;
      protected String scmdbuf ;
      protected bool nconstid ;
      protected bool nfkeyid ;
      protected bool nrkeyid ;
      protected String constid ;
      protected String fkeyid ;
      protected DataStore dsDefault ;
      protected System.Resources.ResourceManager resourceManager ;
      protected System.Resources.ResourceManager resourceManagerTables ;
      protected ReadWriteConnection connDefault ;
      protected ReadWriteCommand RGZ ;
      protected ReadWriteCommand cmsysreferencesSelect1 ;
      protected IDataReader sysreferencesSelect1 ;
   }

}
