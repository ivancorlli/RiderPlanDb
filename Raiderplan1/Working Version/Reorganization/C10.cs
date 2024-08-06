
//               File: C10
//        Description: Conversion for table TrayectoViaje
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
   public class c10
   {
      public event ReorganizationMessageEventHandler messageHandler;

      public c10( ref DataStore ds )
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
         cmdBuffer=" SET IDENTITY_INSERT [GXA0010] ON "
         ;
         RGZ = connDefault.GetCommand(cmdBuffer,false);
         RGZ.IDbCommand.CommandTimeout = 0;
         RGZ.ExecuteStmt() ;
         cmC102 = connDefault.GetCommand("SELECT [Orden], [Instrucciones], [TrayectoDestino], [EstadoCarretera], [CombustibleConsumido], [TiempoEstimado], [Trayectokm], [TrayectoLongitudDestino], [TrayectoLatidudDestino], [TrayectoLongitudOrigen], [TayectoLatitudOrigen], [TrayectoOrigen], [ViajeID], [TrayectoViajeID] FROM [TrayectoViaje] ",false);
         cmC102.ErrorMask = cmC102.ErrorMask  |  ErrorMask.Lock;
         C102 = cmC102.FetchData();
         while ( cmC102.HasMoreRows )
         {
            m_Orden = dsDefault.Db.GetInt32(C102, 0, ref m__OrdenIsNull) ;
            m_Instrucciones = dsDefault.Db.GetString(C102, 1, ref m__InstruccionesIsNull) ;
            m_TrayectoDestino = dsDefault.Db.GetString(C102, 2, ref m__TrayectoDestinoIsNull) ;
            m_EstadoCarretera = dsDefault.Db.GetString(C102, 3, ref m__EstadoCarreteraIsNull) ;
            m_CombustibleConsumido = dsDefault.Db.GetDecimal(C102, 4, ref m__CombustibleConsumidoIsNull) ;
            m_TiempoEstimado = dsDefault.Db.GetDecimal(C102, 5, ref m__TiempoEstimadoIsNull) ;
            m_Trayectokm = dsDefault.Db.GetDecimal(C102, 6, ref m__TrayectokmIsNull) ;
            m_TrayectoLongitudDestino = dsDefault.Db.GetDecimal(C102, 7, ref m__TrayectoLongitudDestinoIsNull) ;
            m_TrayectoLatidudDestino = dsDefault.Db.GetDecimal(C102, 8, ref m__TrayectoLatidudDestinoIsNull) ;
            m_TrayectoLongitudOrigen = dsDefault.Db.GetDecimal(C102, 9, ref m__TrayectoLongitudOrigenIsNull) ;
            m_TayectoLatitudOrigen = dsDefault.Db.GetDecimal(C102, 10, ref m__TayectoLatitudOrigenIsNull) ;
            m_TrayectoOrigen = dsDefault.Db.GetString(C102, 11, ref m__TrayectoOrigenIsNull) ;
            m_ViajeID = dsDefault.Db.GetInt64(C102, 12, ref m__ViajeIDIsNull) ;
            m_TrayectoViajeID = dsDefault.Db.GetInt32(C102, 13, ref m__TrayectoViajeIDIsNull) ;
            //
               // INSERT RECORD ON TABLE GXA0010
               //
            //
            AV2Trayect = m_TrayectoViajeID ;
            AV3ViajeID = m_ViajeID ;
            if ( C102.IsDBNull(11) )
            {
               AV4Trayect = "" ;
               nV4Trayect = true ;
            }
            else
            {
               AV4Trayect = m_TrayectoOrigen ;
               nV4Trayect = false ;
            }
            if ( C102.IsDBNull(10) )
            {
               AV5Tayecto = (decimal)(0M) ;
               nV5Tayecto = true ;
            }
            else
            {
               AV5Tayecto = m_TayectoLatitudOrigen ;
               nV5Tayecto = false ;
            }
            if ( C102.IsDBNull(9) )
            {
               AV6Trayect = (decimal)(0M) ;
               nV6Trayect = true ;
            }
            else
            {
               AV6Trayect = m_TrayectoLongitudOrigen ;
               nV6Trayect = false ;
            }
            if ( C102.IsDBNull(8) )
            {
               AV7Trayect = (decimal)(0M) ;
               nV7Trayect = true ;
            }
            else
            {
               AV7Trayect = m_TrayectoLatidudDestino ;
               nV7Trayect = false ;
            }
            if ( C102.IsDBNull(7) )
            {
               AV8Trayect = (decimal)(0M) ;
               nV8Trayect = true ;
            }
            else
            {
               AV8Trayect = m_TrayectoLongitudDestino ;
               nV8Trayect = false ;
            }
            if ( C102.IsDBNull(6) )
            {
               AV9Trayect = (decimal)(0M) ;
               nV9Trayect = true ;
            }
            else
            {
               AV9Trayect = m_Trayectokm ;
               nV9Trayect = false ;
            }
            if ( C102.IsDBNull(5) )
            {
               AV10Tiempo = (decimal)(0M) ;
               nV10Tiempo = true ;
            }
            else
            {
               AV10Tiempo = m_TiempoEstimado ;
               nV10Tiempo = false ;
            }
            if ( C102.IsDBNull(4) )
            {
               AV11Combus = (decimal)(0M) ;
               nV11Combus = true ;
            }
            else
            {
               AV11Combus = m_CombustibleConsumido ;
               nV11Combus = false ;
            }
            if ( C102.IsDBNull(3) )
            {
               AV12Estado = "" ;
               nV12Estado = true ;
            }
            else
            {
               AV12Estado = m_EstadoCarretera ;
               nV12Estado = false ;
            }
            AV13Trayec = m_TrayectoDestino ;
            if ( C102.IsDBNull(1) )
            {
               AV14Instru = "" ;
               nV14Instru = true ;
            }
            else
            {
               AV14Instru = m_Instrucciones ;
               nV14Instru = false ;
            }
            if ( C102.IsDBNull(0) )
            {
               AV15Orden = 0 ;
               nV15Orden = true ;
            }
            else
            {
               AV15Orden = m_Orden ;
               nV15Orden = false ;
            }
            AV16EsOrig = " " ;
            cmC103 = connDefault.GetCommand("INSERT INTO [GXA0010] ([TrayectoViajeID], [ViajeID], [TrayectoOrigen], [TayectoLatitudOrigen], [TrayectoLongitudOrigen], [TrayectoLatidudDestino], [TrayectoLongitudDestino], [Trayectokm], [TiempoEstimado], [CombustibleConsumido], [EstadoCarretera], [TrayectoDestino], [Instrucciones], [Orden], [EsOrigen]) VALUES (@TrayectoViajeID, @ViajeID, @TrayectoOrigen, @TayectoLatitudOrigen, @TrayectoLongitudOrigen, @TrayectoLatidudDestino, @TrayectoLongitudDestino, @Trayectokm, @TiempoEstimado, @CombustibleConsumido, @EstadoCarretera, @TrayectoDestino, @Instrucciones, @Orden, @EsOrigen)",false);
            if ( ( cmC103.IDbCommand.Parameters.Count == 0 ) )
            {
               cmC103.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoViajeID", System.Data.DbType.Int32));
               cmC103.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
               cmC103.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoOrigen", System.Data.DbType.AnsiString,150));
               cmC103.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TayectoLatitudOrigen", System.Data.DbType.Decimal));
               cmC103.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoLongitudOrigen", System.Data.DbType.Decimal));
               cmC103.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoLatidudDestino", System.Data.DbType.Decimal));
               cmC103.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoLongitudDestino", System.Data.DbType.Decimal));
               cmC103.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@Trayectokm", System.Data.DbType.Currency));
               cmC103.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TiempoEstimado", System.Data.DbType.Currency));
               cmC103.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@CombustibleConsumido", System.Data.DbType.Currency));
               cmC103.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@EstadoCarretera", System.Data.DbType.AnsiString,100));
               cmC103.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoDestino", System.Data.DbType.AnsiString,50));
               cmC103.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@Instrucciones", System.Data.DbType.AnsiString));
               cmC103.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@Orden", System.Data.DbType.Int32));
               cmC103.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@EsOrigen", System.Data.DbType.AnsiString,1));
            }
            cmC103.ErrorMask = cmC103.ErrorMask  |  ErrorMask.DuplicateKeyError;
            // Using cursor C103
            cmC103.SetParameter(0, AV2Trayect);
            cmC103.SetParameter(1, AV3ViajeID);
            cmC103.SetParameter(2, AV4Trayect, nV4Trayect);
            cmC103.SetParameter(3, AV5Tayecto, nV5Tayecto);
            cmC103.SetParameter(4, AV6Trayect, nV6Trayect);
            cmC103.SetParameter(5, AV7Trayect, nV7Trayect);
            cmC103.SetParameter(6, AV8Trayect, nV8Trayect);
            cmC103.SetParameter(7, AV9Trayect, nV9Trayect);
            cmC103.SetParameter(8, AV10Tiempo, nV10Tiempo);
            cmC103.SetParameter(9, AV11Combus, nV11Combus);
            cmC103.SetParameter(10, AV12Estado, nV12Estado);
            cmC103.SetParameter(11, AV13Trayec);
            cmC103.SetParameter(12, AV14Instru, nV14Instru);
            cmC103.SetParameter(13, AV15Orden, nV15Orden);
            cmC103.SetParameter(14, AV16EsOrig);
            cmC103.ExecuteStmt();
            if ( cmC103.DupKey )
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
            cmC102.HasMoreRows = C102.Read();
         }
         C102.Close();
         cmdBuffer=" SET IDENTITY_INSERT [GXA0010] OFF "
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
         m__OrdenIsNull = false ;
         m_Orden = 0 ;
         m__InstruccionesIsNull = false ;
         m_Instrucciones = "" ;
         m__TrayectoDestinoIsNull = false ;
         m_TrayectoDestino = "" ;
         m__EstadoCarreteraIsNull = false ;
         m_EstadoCarretera = "" ;
         m__CombustibleConsumidoIsNull = false ;
         m_CombustibleConsumido = (decimal)(0M) ;
         m__TiempoEstimadoIsNull = false ;
         m_TiempoEstimado = (decimal)(0M) ;
         m__TrayectokmIsNull = false ;
         m_Trayectokm = (decimal)(0M) ;
         m__TrayectoLongitudDestinoIsNull = false ;
         m_TrayectoLongitudDestino = (decimal)(0M) ;
         m__TrayectoLatidudDestinoIsNull = false ;
         m_TrayectoLatidudDestino = (decimal)(0M) ;
         m__TrayectoLongitudOrigenIsNull = false ;
         m_TrayectoLongitudOrigen = (decimal)(0M) ;
         m__TayectoLatitudOrigenIsNull = false ;
         m_TayectoLatitudOrigen = (decimal)(0M) ;
         m__TrayectoOrigenIsNull = false ;
         m_TrayectoOrigen = "" ;
         m__ViajeIDIsNull = false ;
         m_ViajeID = 0 ;
         m__TrayectoViajeIDIsNull = false ;
         m_TrayectoViajeID = 0 ;
         GIGXA0010 = 0 ;
         AV2Trayect = 0 ;
         AV3ViajeID = 0 ;
         AV4Trayect = "" ;
         nV4Trayect = false ;
         AV5Tayecto = (decimal)(0M) ;
         nV5Tayecto = false ;
         AV6Trayect = (decimal)(0M) ;
         nV6Trayect = false ;
         AV7Trayect = (decimal)(0M) ;
         nV7Trayect = false ;
         AV8Trayect = (decimal)(0M) ;
         nV8Trayect = false ;
         AV9Trayect = (decimal)(0M) ;
         nV9Trayect = false ;
         AV10Tiempo = (decimal)(0M) ;
         nV10Tiempo = false ;
         AV11Combus = (decimal)(0M) ;
         nV11Combus = false ;
         AV12Estado = "" ;
         nV12Estado = false ;
         AV13Trayec = "" ;
         AV14Instru = "" ;
         nV14Instru = false ;
         AV15Orden = 0 ;
         nV15Orden = false ;
         AV16EsOrig = "" ;
         Gx_err = 0 ;
         Gx_emsg = "" ;
         // GeneXus formulas.
         Gx_err = 0 ;
      }

      private short Gx_err ;
      private int m_Orden ;
      private int m_TrayectoViajeID ;
      private int GIGXA0010 ;
      private int AV2Trayect ;
      private int AV15Orden ;
      private long m_ViajeID ;
      private long AV3ViajeID ;
      private decimal m_CombustibleConsumido ;
      private decimal m_TiempoEstimado ;
      private decimal m_Trayectokm ;
      private decimal m_TrayectoLongitudDestino ;
      private decimal m_TrayectoLatidudDestino ;
      private decimal m_TrayectoLongitudOrigen ;
      private decimal m_TayectoLatitudOrigen ;
      private decimal AV5Tayecto ;
      private decimal AV6Trayect ;
      private decimal AV7Trayect ;
      private decimal AV8Trayect ;
      private decimal AV9Trayect ;
      private decimal AV10Tiempo ;
      private decimal AV11Combus ;
      private String cmdBuffer ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private bool m__OrdenIsNull ;
      private bool m__InstruccionesIsNull ;
      private bool m__TrayectoDestinoIsNull ;
      private bool m__EstadoCarreteraIsNull ;
      private bool m__CombustibleConsumidoIsNull ;
      private bool m__TiempoEstimadoIsNull ;
      private bool m__TrayectokmIsNull ;
      private bool m__TrayectoLongitudDestinoIsNull ;
      private bool m__TrayectoLatidudDestinoIsNull ;
      private bool m__TrayectoLongitudOrigenIsNull ;
      private bool m__TayectoLatitudOrigenIsNull ;
      private bool m__TrayectoOrigenIsNull ;
      private bool m__ViajeIDIsNull ;
      private bool m__TrayectoViajeIDIsNull ;
      private bool nV4Trayect ;
      private bool nV5Tayecto ;
      private bool nV6Trayect ;
      private bool nV7Trayect ;
      private bool nV8Trayect ;
      private bool nV9Trayect ;
      private bool nV10Tiempo ;
      private bool nV11Combus ;
      private bool nV12Estado ;
      private bool nV14Instru ;
      private bool nV15Orden ;
      private String m_Instrucciones ;
      private String AV14Instru ;
      private String m_TrayectoDestino ;
      private String m_EstadoCarretera ;
      private String m_TrayectoOrigen ;
      private String AV4Trayect ;
      private String AV12Estado ;
      private String AV13Trayec ;
      private String AV16EsOrig ;
      private DataStore dsDefault ;
      private System.Resources.ResourceManager resourceManager ;
      private System.Resources.ResourceManager resourceManagerTables ;
      private ReadWriteConnection connDefault ;
      private ReadWriteCommand RGZ ;
      private ReadWriteCommand cmC102 ;
      private IDataReader C102 ;
      private ReadWriteCommand cmC103 ;
   }

}
