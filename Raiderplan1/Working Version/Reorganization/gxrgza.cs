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
         Status = 0 ;
         new gxrtctls(ref dsDefault).execute( ref  Status) ;
         if ( ( Status != 0 ) )
         {
            throw new CannotExecuteReorganizationException( resourceManager.GetString("invalidreorg")) ;
         }
         // Load data into tables.
         // Drop integrity constraints (if any).
         AddMsg( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("rgzdic"), new   object[]  {"2"}) );
         AddMsg( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("rgzd1c"), new   object[]  {"ComentarioViaje"}) );
         // Create new and temporary tables.
         AddMsg( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("rgzctnt"), new   object[]  {"3"}) );
         AddMsg( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("filecrea"), new   object[]  {"GXA0013", ""}) );
         //
            //
            // Drop table in SQLServer with FKs
            //
         //
         cmsysreferencesSelect1 = connDefault.GetCommand("SELECT OBJECT_NAME(constid), OBJECT_NAME(fkeyid), [rkeyid] FROM [sysreferences] WHERE [rkeyid] = OBJECT_ID('[GXA0013]') ",true);
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
         cmdBuffer=" DROP TABLE [GXA0013] "
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
         cmdBuffer=" CREATE TABLE [GXA0013] ([ComentarioViajeID] int NOT null  IDENTITY(1,1), [ComentarioLatitud] decimal( 17, 5) NOT null , [ComentarioLongitud] decimal( 17, 5) NOT null , [ComentarioTexto] varchar(250) NOT null , [ComentarioImagen] varchar(250) null , [CVTrayectoID] int null , [ViajeID] bigint NOT null )  "
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
      [Serializable()]
      public class CannotExecuteReorganizationException : Deklarit.Exception
      {
         public CannotExecuteReorganizationException( )
         {
         }

         public CannotExecuteReorganizationException( string message ) : base(message)
         {
         }

         public CannotExecuteReorganizationException( string message ,
                                                      Exception inner ) : base(message, inner)
         {
         }

      }

      public void Initialize( )
      {
         resourceManager = Deklarit.Utils.ResourceManager.Instance ;
         resourceManagerTables = new System.Resources.ResourceManager( "Deklarit.Tables", System.Reflection.Assembly.GetExecutingAssembly()) ;
         Status = 0 ;
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

      protected short Status ;
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
      protected ReadWriteCommand cmsysreferencesSelect1 ;
      protected IDataReader sysreferencesSelect1 ;
      protected ReadWriteCommand RGZ ;
   }

}
