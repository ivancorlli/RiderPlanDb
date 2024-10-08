
//               File: C13
//        Description: Conversion for table ComentarioViaje
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
   public class c13
   {
      public event ReorganizationMessageEventHandler messageHandler;

      public c13( ref DataStore ds )
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
         cmdBuffer=" SET IDENTITY_INSERT [GXA0013] ON "
         ;
         RGZ = connDefault.GetCommand(cmdBuffer,false);
         RGZ.IDbCommand.CommandTimeout = 0;
         RGZ.ExecuteStmt() ;
         cmC132 = connDefault.GetCommand("SELECT [CVTrayectoID], [ComentarioImagen], [ComentarioTexto], [ComentarioLongitud], [ComentarioLatitud], [ComentarioViajeID] FROM [ComentarioViaje] ",false);
         cmC132.ErrorMask = cmC132.ErrorMask  |  ErrorMask.Lock;
         C132 = cmC132.FetchData();
         while ( cmC132.HasMoreRows )
         {
            m_CVTrayectoID = dsDefault.Db.GetInt32(C132, 0, ref m__CVTrayectoIDIsNull) ;
            m_ComentarioImagen = dsDefault.Db.GetString(C132, 1, ref m__ComentarioImagenIsNull) ;
            m_ComentarioTexto = dsDefault.Db.GetString(C132, 2, ref m__ComentarioTextoIsNull) ;
            m_ComentarioLongitud = dsDefault.Db.GetDecimal(C132, 3, ref m__ComentarioLongitudIsNull) ;
            m_ComentarioLatitud = dsDefault.Db.GetDecimal(C132, 4, ref m__ComentarioLatitudIsNull) ;
            m_ComentarioViajeID = dsDefault.Db.GetInt32(C132, 5, ref m__ComentarioViajeIDIsNull) ;
            //
               // INSERT RECORD ON TABLE GXA0013
               //
            //
            AV2Comenta = m_ComentarioViajeID ;
            AV3Comenta = m_ComentarioLatitud ;
            AV4Comenta = m_ComentarioLongitud ;
            AV5Comenta = m_ComentarioTexto ;
            if ( C132.IsDBNull(1) )
            {
               AV6Comenta = "" ;
               nV6Comenta = true ;
            }
            else
            {
               AV6Comenta = m_ComentarioImagen ;
               nV6Comenta = false ;
            }
            if ( C132.IsDBNull(0) )
            {
               AV7CVTraye = 0 ;
               nV7CVTraye = true ;
            }
            else
            {
               AV7CVTraye = m_CVTrayectoID ;
               nV7CVTraye = false ;
            }
            AV8ViajeID = 0 ;
            cmC133 = connDefault.GetCommand("INSERT INTO [GXA0013] ([ComentarioViajeID], [ComentarioLatitud], [ComentarioLongitud], [ComentarioTexto], [ComentarioImagen], [CVTrayectoID], [ViajeID]) VALUES (@ComentarioViajeID, @ComentarioLatitud, @ComentarioLongitud, @ComentarioTexto, @ComentarioImagen, @CVTrayectoID, @ViajeID)",false);
            if ( ( cmC133.IDbCommand.Parameters.Count == 0 ) )
            {
               cmC133.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ComentarioViajeID", System.Data.DbType.Int32));
               cmC133.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ComentarioLatitud", System.Data.DbType.Decimal));
               cmC133.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ComentarioLongitud", System.Data.DbType.Decimal));
               cmC133.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ComentarioTexto", System.Data.DbType.AnsiString,250));
               cmC133.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ComentarioImagen", System.Data.DbType.AnsiString,250));
               cmC133.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@CVTrayectoID", System.Data.DbType.Int32));
               cmC133.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
            }
            cmC133.ErrorMask = cmC133.ErrorMask  |  ErrorMask.DuplicateKeyError;
            // Using cursor C133
            cmC133.SetParameter(0, AV2Comenta);
            cmC133.SetParameter(1, AV3Comenta);
            cmC133.SetParameter(2, AV4Comenta);
            cmC133.SetParameter(3, AV5Comenta);
            cmC133.SetParameter(4, AV6Comenta, nV6Comenta);
            cmC133.SetParameter(5, AV7CVTraye, nV7CVTraye);
            cmC133.SetParameter(6, AV8ViajeID);
            cmC133.ExecuteStmt();
            if ( cmC133.DupKey )
            {
               Gx_err = 1 ;
               Gx_emsg = (String)(resourceManager.GetString("noupdate")) ;
            }
            else
            {
               Gx_err = 0 ;
               Gx_emsg = "" ;
            }
            // End Insert
            cmC132.HasMoreRows = C132.Read();
         }
         C132.Close();
         cmdBuffer=" SET IDENTITY_INSERT [GXA0013] OFF "
         ;
         RGZ = connDefault.GetCommand(cmdBuffer,false);
         RGZ.IDbCommand.CommandTimeout = 0;
         RGZ.ExecuteStmt() ;
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
         scmdbuf = "" ;
         m__CVTrayectoIDIsNull = false ;
         m_CVTrayectoID = 0 ;
         m__ComentarioImagenIsNull = false ;
         m_ComentarioImagen = "" ;
         m__ComentarioTextoIsNull = false ;
         m_ComentarioTexto = "" ;
         m__ComentarioLongitudIsNull = false ;
         m_ComentarioLongitud = (decimal)(0M) ;
         m__ComentarioLatitudIsNull = false ;
         m_ComentarioLatitud = (decimal)(0M) ;
         m__ComentarioViajeIDIsNull = false ;
         m_ComentarioViajeID = 0 ;
         GIGXA0013 = 0 ;
         AV2Comenta = 0 ;
         AV3Comenta = (decimal)(0M) ;
         AV4Comenta = (decimal)(0M) ;
         AV5Comenta = "" ;
         AV6Comenta = "" ;
         nV6Comenta = false ;
         AV7CVTraye = 0 ;
         nV7CVTraye = false ;
         AV8ViajeID = 0 ;
         Gx_err = 0 ;
         Gx_emsg = "" ;
         // GeneXus formulas.
         Gx_err = 0 ;
      }

      private short Gx_err ;
      private int m_CVTrayectoID ;
      private int m_ComentarioViajeID ;
      private int GIGXA0013 ;
      private int AV2Comenta ;
      private int AV7CVTraye ;
      private long AV8ViajeID ;
      private decimal m_ComentarioLongitud ;
      private decimal m_ComentarioLatitud ;
      private decimal AV3Comenta ;
      private decimal AV4Comenta ;
      private String cmdBuffer ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private bool m__CVTrayectoIDIsNull ;
      private bool m__ComentarioImagenIsNull ;
      private bool m__ComentarioTextoIsNull ;
      private bool m__ComentarioLongitudIsNull ;
      private bool m__ComentarioLatitudIsNull ;
      private bool m__ComentarioViajeIDIsNull ;
      private bool nV6Comenta ;
      private bool nV7CVTraye ;
      private String m_ComentarioImagen ;
      private String m_ComentarioTexto ;
      private String AV5Comenta ;
      private String AV6Comenta ;
      private DataStore dsDefault ;
      private System.Resources.ResourceManager resourceManager ;
      private System.Resources.ResourceManager resourceManagerTables ;
      private ReadWriteConnection connDefault ;
      private ReadWriteCommand RGZ ;
      private ReadWriteCommand cmC132 ;
      private IDataReader C132 ;
      private ReadWriteCommand cmC133 ;
   }

}
