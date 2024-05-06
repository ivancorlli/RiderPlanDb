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
   public class gxrgzd
   {
      public event ReorganizationMessageEventHandler messageHandler;

      public gxrgzd( DataStore ds ,
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
         // Class with standard routines for Reorganization.
      }

      public void DropColumnConstraints( String sTableName ,
                                         String sColumnName ,
                                         String sSchemaName )
      {
         cmsysobjectsSelect1 = connDefault.GetCommand("SELECT T1.[name] FROM [sysobjects] T1, [sysobjects] T2, [sysconstraints] T3, [syscolumns] T4 WHERE (T1.[parent_obj] = T2.[id] AND T1.[id] = T3.[constid] AND T3.[colid] = T4.[colid] AND T2.[id] = T4.[id]) AND (T1.[xtype] = 'D' and T2.[name] = @sTableName and T4.[name] = @sColumnName) ",true);
         if ( ( cmsysobjectsSelect1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmsysobjectsSelect1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@sTableName", System.Data.DbType.AnsiStringFixedLength,255));
            cmsysobjectsSelect1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@sColumnName", System.Data.DbType.AnsiStringFixedLength,255));
         }
         cmsysobjectsSelect1.SetParameter(0, sTableName);
         cmsysobjectsSelect1.SetParameter(1, sColumnName);
         cmsysobjectsSelect1.ErrorMask = cmsysobjectsSelect1.ErrorMask  |  ErrorMask.Lock;
         sysobjectsSelect1 = cmsysobjectsSelect1.FetchData();
         while ( cmsysobjectsSelect1.HasMoreRows )
         {
            constraintname = dsDefault.Db.GetString(sysobjectsSelect1, 0, ref nconstrain) ;
            cmdBuffer = "ALTER TABLE " + sSchemaName + " DROP CONSTRAINT " + constraintname ;
            RGZ = connDefault.GetCommand(cmdBuffer,false);
            RGZ.IDbCommand.CommandTimeout = 0;
            RGZ.ExecuteStmt() ;
            cmsysobjectsSelect1.HasMoreRows = sysobjectsSelect1.Read();
         }
         sysobjectsSelect1.Close();
      }

      public void UtilsCleanup( )
      {
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
         sTableName = "" ;
         sColumnName = "" ;
         sSchemaName = "" ;
         xtype = "" ;
         tablename = "" ;
         constraintname = "" ;
         columnname = "" ;
         scmdbuf = "" ;
         nconstrain = false ;
         cmdBuffer = "" ;
         // GeneXus formulas.
      }

      protected String sTableName ;
      protected String sColumnName ;
      protected String sSchemaName ;
      protected String xtype ;
      protected String tablename ;
      protected String constraintname ;
      protected String columnname ;
      protected String scmdbuf ;
      protected String cmdBuffer ;
      protected bool nconstrain ;
      protected DataStore dsDefault ;
      protected System.Resources.ResourceManager resourceManager ;
      protected System.Resources.ResourceManager resourceManagerTables ;
      protected ReadWriteConnection connDefault ;
      protected ReadWriteCommand cmsysobjectsSelect1 ;
      protected IDataReader sysobjectsSelect1 ;
      protected ReadWriteCommand RGZ ;
   }

}
