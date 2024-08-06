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
         AddMsg( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("runpgm"), new   object[]  {"C8"}) );
         new c8(ref dsDefault).execute( ) ;
         // Creating final tables.
         AddMsg( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("filecrea"), new   object[]  {"TrayectoViaje", ""}) );
         //
            //
            // Drop table in SQLServer with FKs
            //
         //
         cmsysreferencesSelect3 = connDefault.GetCommand("SELECT OBJECT_NAME(constid), OBJECT_NAME(fkeyid), [rkeyid] FROM [sysreferences] WHERE [rkeyid] = OBJECT_ID('[TrayectoViaje]') ",true);
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
         cmdBuffer=" CREATE TABLE [TrayectoViaje] ([TrayectoViajeID] int NOT null  IDENTITY(1,1), [ViajeID] bigint NOT null , [TrayectoOrigen] varchar(150) null , [TayectoLatitudOrigen] decimal( 17, 15) null , [TrayectoLongitudOrigen] decimal( 17, 15) null , [TrayectoLatidudDestino] decimal( 17, 15) null , [TrayectoLongitudDestino] decimal( 17, 15) null , [Trayectokm] smallmoney null , [TiempoEstimado] smallmoney null , [CombustibleConsumido] smallmoney null , [EstadoCarretera] varchar(100) null , [TrayectoDestino] varchar(50) NOT null , [Instrucciones] varchar(MAX) null , [Orden] int null , [EsOrigen] varchar(1) NOT null , PRIMARY KEY([TrayectoViajeID]))  "
         ;
         RGZ = connDefault.GetCommand(cmdBuffer,false);
         RGZ.IDbCommand.CommandTimeout = 0;
         RGZ.ExecuteStmt() ;
         AddMsg( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("filecrea"), new   object[]  {"Viaje", ""}) );
         //
            //
            // Drop table in SQLServer with FKs
            //
         //
         cmsysreferencesSelect4 = connDefault.GetCommand("SELECT OBJECT_NAME(constid), OBJECT_NAME(fkeyid), [rkeyid] FROM [sysreferences] WHERE [rkeyid] = OBJECT_ID('[Viaje]') ",true);
         cmsysreferencesSelect4.ErrorMask = cmsysreferencesSelect4.ErrorMask  |  ErrorMask.Lock;
         sysreferencesSelect4 = cmsysreferencesSelect4.FetchData();
         while ( cmsysreferencesSelect4.HasMoreRows )
         {
            constid = dsDefault.Db.GetString(sysreferencesSelect4, 0, ref nconstid) ;
            fkeyid = dsDefault.Db.GetString(sysreferencesSelect4, 1, ref nfkeyid) ;
            rkeyid = dsDefault.Db.GetInt32(sysreferencesSelect4, 2, ref nrkeyid) ;
            cmdBuffer = "ALTER TABLE " + "[" + fkeyid + "] DROP CONSTRAINT " + constid ;
            RGZ = connDefault.GetCommand(cmdBuffer,false);
            RGZ.IDbCommand.CommandTimeout = 0;
            RGZ.ExecuteStmt() ;
            cmsysreferencesSelect4.HasMoreRows = sysreferencesSelect4.Read();
         }
         sysreferencesSelect4.Close();
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
         cmdBuffer=" CREATE TABLE [Viaje] ([ViajeID] bigint NOT null  IDENTITY(1,1), [FechaSalidaProgramada] datetime null , [FechaLlegadaProgramada] datetime null , [FechaSalidaEfectiva] datetime null , [FechaLlegadaEfectiva] datetime null , [LugarPartida] varchar(150) null , [Lugarllegada] varchar(150) null , [LongitudPartida] decimal( 17, 15) null , [LatitudPartida] decimal( 17, 15) null , [LongitudLegada] decimal( 17, 15) null , [LatitudLlegada] decimal( 17, 15) null , [kmTotalesEstimado] money null , [MotocilcetaMarca] varchar(30) null , [MotociletaModelo] varchar(50) null , [UsuarioID] int NOT null , [ViajeNombre] varchar(25) NOT null , [ViajeImagen] varchar(50) null , [ViajeEstado] varchar(1) NOT null , PRIMARY KEY([ViajeID]))  "
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
      protected ReadWriteCommand cmsysreferencesSelect3 ;
      protected IDataReader sysreferencesSelect3 ;
      protected ReadWriteCommand RGZ ;
      protected ReadWriteCommand cmsysreferencesSelect4 ;
      protected IDataReader sysreferencesSelect4 ;
   }

}
