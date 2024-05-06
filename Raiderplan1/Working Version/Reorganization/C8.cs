
//               File: C8
//        Description: Conversion for table Viaje
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
   public class c8
   {
      public event ReorganizationMessageEventHandler messageHandler;

      public c8( ref DataStore ds )
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
         cmdBuffer=" SET IDENTITY_INSERT [GXA0008] ON "
         ;
         RGZ = connDefault.GetCommand(cmdBuffer,false);
         RGZ.IDbCommand.CommandTimeout = 0;
         RGZ.ExecuteStmt() ;
         cmC82 = connDefault.GetCommand("SELECT [VaijeNombre], [MotociletaModelo], [MotocilcetaMarca], [kmTotalesEstimado], [LatitudLlegada], [LongitudLegada], [LatitudPartida], [LongitudPartida], [Lugarllegada], [LugarPartida], [FechaLlegadaEfectiva], [FechaSalidaEfectiva], [FechaLlegadaProgramada], [FechaSalidaProgramada], [ViajeID] FROM [Viaje] ",false);
         cmC82.ErrorMask = cmC82.ErrorMask  |  ErrorMask.Lock;
         C82 = cmC82.FetchData();
         while ( cmC82.HasMoreRows )
         {
            m_VaijeNombre = dsDefault.Db.GetString(C82, 0, ref m__VaijeNombreIsNull) ;
            m_MotociletaModelo = dsDefault.Db.GetString(C82, 1, ref m__MotociletaModeloIsNull) ;
            m_MotocilcetaMarca = dsDefault.Db.GetString(C82, 2, ref m__MotocilcetaMarcaIsNull) ;
            m_kmTotalesEstimado = dsDefault.Db.GetDecimal(C82, 3, ref m__kmTotalesEstimadoIsNull) ;
            m_LatitudLlegada = dsDefault.Db.GetDecimal(C82, 4, ref m__LatitudLlegadaIsNull) ;
            m_LongitudLegada = dsDefault.Db.GetDecimal(C82, 5, ref m__LongitudLegadaIsNull) ;
            m_LatitudPartida = dsDefault.Db.GetDecimal(C82, 6, ref m__LatitudPartidaIsNull) ;
            m_LongitudPartida = dsDefault.Db.GetDecimal(C82, 7, ref m__LongitudPartidaIsNull) ;
            m_Lugarllegada = dsDefault.Db.GetString(C82, 8, ref m__LugarllegadaIsNull) ;
            m_LugarPartida = dsDefault.Db.GetString(C82, 9, ref m__LugarPartidaIsNull) ;
            m_FechaLlegadaEfectiva = dsDefault.Db.GetDateTime(C82, 10, ref m__FechaLlegadaEfectivaIsNull) ;
            m_FechaSalidaEfectiva = dsDefault.Db.GetDateTime(C82, 11, ref m__FechaSalidaEfectivaIsNull) ;
            m_FechaLlegadaProgramada = dsDefault.Db.GetDateTime(C82, 12, ref m__FechaLlegadaProgramadaIsNull) ;
            m_FechaSalidaProgramada = dsDefault.Db.GetDateTime(C82, 13, ref m__FechaSalidaProgramadaIsNull) ;
            m_ViajeID = dsDefault.Db.GetInt64(C82, 14, ref m__ViajeIDIsNull) ;
            //
               // INSERT RECORD ON TABLE GXA0008
               //
            //
            AV2ViajeID = m_ViajeID ;
            if ( C82.IsDBNull(13) )
            {
               AV3FechaSa = (DateTime)(DateTime.MinValue) ;
               nV3FechaSa = true ;
            }
            else
            {
               AV3FechaSa = m_FechaSalidaProgramada ;
               nV3FechaSa = false ;
            }
            if ( C82.IsDBNull(12) )
            {
               AV4FechaLl = (DateTime)(DateTime.MinValue) ;
               nV4FechaLl = true ;
            }
            else
            {
               AV4FechaLl = m_FechaLlegadaProgramada ;
               nV4FechaLl = false ;
            }
            if ( C82.IsDBNull(11) )
            {
               AV5FechaSa = (DateTime)(DateTime.MinValue) ;
               nV5FechaSa = true ;
            }
            else
            {
               AV5FechaSa = m_FechaSalidaEfectiva ;
               nV5FechaSa = false ;
            }
            if ( C82.IsDBNull(10) )
            {
               AV6FechaLl = (DateTime)(DateTime.MinValue) ;
               nV6FechaLl = true ;
            }
            else
            {
               AV6FechaLl = m_FechaLlegadaEfectiva ;
               nV6FechaLl = false ;
            }
            if ( C82.IsDBNull(9) )
            {
               AV7LugarPa = "" ;
               nV7LugarPa = true ;
            }
            else
            {
               AV7LugarPa = m_LugarPartida ;
               nV7LugarPa = false ;
            }
            if ( C82.IsDBNull(8) )
            {
               AV8Lugarll = "" ;
               nV8Lugarll = true ;
            }
            else
            {
               AV8Lugarll = m_Lugarllegada ;
               nV8Lugarll = false ;
            }
            if ( C82.IsDBNull(7) )
            {
               AV9Longitu = (decimal)(0M) ;
               nV9Longitu = true ;
            }
            else
            {
               AV9Longitu = m_LongitudPartida ;
               nV9Longitu = false ;
            }
            if ( C82.IsDBNull(6) )
            {
               AV10Latitu = (decimal)(0M) ;
               nV10Latitu = true ;
            }
            else
            {
               AV10Latitu = m_LatitudPartida ;
               nV10Latitu = false ;
            }
            if ( C82.IsDBNull(5) )
            {
               AV11Longit = (decimal)(0M) ;
               nV11Longit = true ;
            }
            else
            {
               AV11Longit = m_LongitudLegada ;
               nV11Longit = false ;
            }
            if ( C82.IsDBNull(4) )
            {
               AV12Latitu = (decimal)(0M) ;
               nV12Latitu = true ;
            }
            else
            {
               AV12Latitu = m_LatitudLlegada ;
               nV12Latitu = false ;
            }
            if ( C82.IsDBNull(3) )
            {
               AV13kmTota = (decimal)(0M) ;
               nV13kmTota = true ;
            }
            else
            {
               AV13kmTota = m_kmTotalesEstimado ;
               nV13kmTota = false ;
            }
            if ( C82.IsDBNull(2) )
            {
               AV14Motoci = "" ;
               nV14Motoci = true ;
            }
            else
            {
               AV14Motoci = m_MotocilcetaMarca ;
               nV14Motoci = false ;
            }
            if ( C82.IsDBNull(1) )
            {
               AV15Motoci = "" ;
               nV15Motoci = true ;
            }
            else
            {
               AV15Motoci = m_MotociletaModelo ;
               nV15Motoci = false ;
            }
            AV16VaijeN = m_VaijeNombre ;
            AV17Usuari = 0 ;
            cmC83 = connDefault.GetCommand("INSERT INTO [GXA0008] ([ViajeID], [FechaSalidaProgramada], [FechaLlegadaProgramada], [FechaSalidaEfectiva], [FechaLlegadaEfectiva], [LugarPartida], [Lugarllegada], [LongitudPartida], [LatitudPartida], [LongitudLegada], [LatitudLlegada], [kmTotalesEstimado], [MotocilcetaMarca], [MotociletaModelo], [VaijeNombre], [UsuarioID]) VALUES (@ViajeID, @FechaSalidaProgramada, @FechaLlegadaProgramada, @FechaSalidaEfectiva, @FechaLlegadaEfectiva, @LugarPartida, @Lugarllegada, @LongitudPartida, @LatitudPartida, @LongitudLegada, @LatitudLlegada, @kmTotalesEstimado, @MotocilcetaMarca, @MotociletaModelo, @VaijeNombre, @UsuarioID)",false);
            if ( ( cmC83.IDbCommand.Parameters.Count == 0 ) )
            {
               cmC83.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
               cmC83.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@FechaSalidaProgramada", System.Data.DbType.DateTime));
               cmC83.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@FechaLlegadaProgramada", System.Data.DbType.DateTime));
               cmC83.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@FechaSalidaEfectiva", System.Data.DbType.DateTime));
               cmC83.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@FechaLlegadaEfectiva", System.Data.DbType.DateTime));
               cmC83.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LugarPartida", System.Data.DbType.AnsiString,150));
               cmC83.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@Lugarllegada", System.Data.DbType.AnsiString,150));
               cmC83.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LongitudPartida", System.Data.DbType.Decimal));
               cmC83.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LatitudPartida", System.Data.DbType.Decimal));
               cmC83.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LongitudLegada", System.Data.DbType.Decimal));
               cmC83.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LatitudLlegada", System.Data.DbType.Decimal));
               cmC83.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@kmTotalesEstimado", System.Data.DbType.Currency));
               cmC83.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@MotocilcetaMarca", System.Data.DbType.AnsiString,30));
               cmC83.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@MotociletaModelo", System.Data.DbType.AnsiString,50));
               cmC83.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@VaijeNombre", System.Data.DbType.AnsiString,180));
               cmC83.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioID", System.Data.DbType.Int32));
            }
            cmC83.ErrorMask = cmC83.ErrorMask  |  ErrorMask.DuplicateKeyError;
            // Using cursor C83
            cmC83.SetParameter(0, AV2ViajeID);
            cmC83.SetParameterDateTimeObject(1, AV3FechaSa, nV3FechaSa);
            cmC83.SetParameterDateTimeObject(2, AV4FechaLl, nV4FechaLl);
            cmC83.SetParameterDateTimeObject(3, AV5FechaSa, nV5FechaSa);
            cmC83.SetParameterDateTimeObject(4, AV6FechaLl, nV6FechaLl);
            cmC83.SetParameter(5, AV7LugarPa, nV7LugarPa);
            cmC83.SetParameter(6, AV8Lugarll, nV8Lugarll);
            cmC83.SetParameter(7, AV9Longitu, nV9Longitu);
            cmC83.SetParameter(8, AV10Latitu, nV10Latitu);
            cmC83.SetParameter(9, AV11Longit, nV11Longit);
            cmC83.SetParameter(10, AV12Latitu, nV12Latitu);
            cmC83.SetParameter(11, AV13kmTota, nV13kmTota);
            cmC83.SetParameter(12, AV14Motoci, nV14Motoci);
            cmC83.SetParameter(13, AV15Motoci, nV15Motoci);
            cmC83.SetParameter(14, AV16VaijeN);
            cmC83.SetParameter(15, AV17Usuari);
            cmC83.ExecuteStmt();
            if ( cmC83.DupKey )
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
            cmC82.HasMoreRows = C82.Read();
         }
         C82.Close();
         cmdBuffer=" SET IDENTITY_INSERT [GXA0008] OFF "
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
         m__VaijeNombreIsNull = false ;
         m_VaijeNombre = "" ;
         m__MotociletaModeloIsNull = false ;
         m_MotociletaModelo = "" ;
         m__MotocilcetaMarcaIsNull = false ;
         m_MotocilcetaMarca = "" ;
         m__kmTotalesEstimadoIsNull = false ;
         m_kmTotalesEstimado = (decimal)(0M) ;
         m__LatitudLlegadaIsNull = false ;
         m_LatitudLlegada = (decimal)(0M) ;
         m__LongitudLegadaIsNull = false ;
         m_LongitudLegada = (decimal)(0M) ;
         m__LatitudPartidaIsNull = false ;
         m_LatitudPartida = (decimal)(0M) ;
         m__LongitudPartidaIsNull = false ;
         m_LongitudPartida = (decimal)(0M) ;
         m__LugarllegadaIsNull = false ;
         m_Lugarllegada = "" ;
         m__LugarPartidaIsNull = false ;
         m_LugarPartida = "" ;
         m__FechaLlegadaEfectivaIsNull = false ;
         m_FechaLlegadaEfectiva = (DateTime)(DateTime.MinValue) ;
         m__FechaSalidaEfectivaIsNull = false ;
         m_FechaSalidaEfectiva = (DateTime)(DateTime.MinValue) ;
         m__FechaLlegadaProgramadaIsNull = false ;
         m_FechaLlegadaProgramada = (DateTime)(DateTime.MinValue) ;
         m__FechaSalidaProgramadaIsNull = false ;
         m_FechaSalidaProgramada = (DateTime)(DateTime.MinValue) ;
         m__ViajeIDIsNull = false ;
         m_ViajeID = 0 ;
         GIGXA0008 = 0 ;
         AV2ViajeID = 0 ;
         AV3FechaSa = (DateTime)(DateTime.MinValue) ;
         nV3FechaSa = false ;
         AV4FechaLl = (DateTime)(DateTime.MinValue) ;
         nV4FechaLl = false ;
         AV5FechaSa = (DateTime)(DateTime.MinValue) ;
         nV5FechaSa = false ;
         AV6FechaLl = (DateTime)(DateTime.MinValue) ;
         nV6FechaLl = false ;
         AV7LugarPa = "" ;
         nV7LugarPa = false ;
         AV8Lugarll = "" ;
         nV8Lugarll = false ;
         AV9Longitu = (decimal)(0M) ;
         nV9Longitu = false ;
         AV10Latitu = (decimal)(0M) ;
         nV10Latitu = false ;
         AV11Longit = (decimal)(0M) ;
         nV11Longit = false ;
         AV12Latitu = (decimal)(0M) ;
         nV12Latitu = false ;
         AV13kmTota = (decimal)(0M) ;
         nV13kmTota = false ;
         AV14Motoci = "" ;
         nV14Motoci = false ;
         AV15Motoci = "" ;
         nV15Motoci = false ;
         AV16VaijeN = "" ;
         AV17Usuari = 0 ;
         Gx_err = 0 ;
         Gx_emsg = "" ;
         // GeneXus formulas.
         Gx_err = 0 ;
      }

      private short Gx_err ;
      private int GIGXA0008 ;
      private int AV17Usuari ;
      private long m_ViajeID ;
      private long AV2ViajeID ;
      private decimal m_kmTotalesEstimado ;
      private decimal m_LatitudLlegada ;
      private decimal m_LongitudLegada ;
      private decimal m_LatitudPartida ;
      private decimal m_LongitudPartida ;
      private decimal AV9Longitu ;
      private decimal AV10Latitu ;
      private decimal AV11Longit ;
      private decimal AV12Latitu ;
      private decimal AV13kmTota ;
      private String cmdBuffer ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime m_FechaLlegadaEfectiva ;
      private DateTime m_FechaSalidaEfectiva ;
      private DateTime m_FechaLlegadaProgramada ;
      private DateTime m_FechaSalidaProgramada ;
      private DateTime AV3FechaSa ;
      private DateTime AV4FechaLl ;
      private DateTime AV5FechaSa ;
      private DateTime AV6FechaLl ;
      private bool m__VaijeNombreIsNull ;
      private bool m__MotociletaModeloIsNull ;
      private bool m__MotocilcetaMarcaIsNull ;
      private bool m__kmTotalesEstimadoIsNull ;
      private bool m__LatitudLlegadaIsNull ;
      private bool m__LongitudLegadaIsNull ;
      private bool m__LatitudPartidaIsNull ;
      private bool m__LongitudPartidaIsNull ;
      private bool m__LugarllegadaIsNull ;
      private bool m__LugarPartidaIsNull ;
      private bool m__FechaLlegadaEfectivaIsNull ;
      private bool m__FechaSalidaEfectivaIsNull ;
      private bool m__FechaLlegadaProgramadaIsNull ;
      private bool m__FechaSalidaProgramadaIsNull ;
      private bool m__ViajeIDIsNull ;
      private bool nV3FechaSa ;
      private bool nV4FechaLl ;
      private bool nV5FechaSa ;
      private bool nV6FechaLl ;
      private bool nV7LugarPa ;
      private bool nV8Lugarll ;
      private bool nV9Longitu ;
      private bool nV10Latitu ;
      private bool nV11Longit ;
      private bool nV12Latitu ;
      private bool nV13kmTota ;
      private bool nV14Motoci ;
      private bool nV15Motoci ;
      private String m_VaijeNombre ;
      private String m_MotociletaModelo ;
      private String m_MotocilcetaMarca ;
      private String m_Lugarllegada ;
      private String m_LugarPartida ;
      private String AV7LugarPa ;
      private String AV8Lugarll ;
      private String AV14Motoci ;
      private String AV15Motoci ;
      private String AV16VaijeN ;
      private DataStore dsDefault ;
      private System.Resources.ResourceManager resourceManager ;
      private System.Resources.ResourceManager resourceManagerTables ;
      private ReadWriteConnection connDefault ;
      private ReadWriteCommand RGZ ;
      private ReadWriteCommand cmC82 ;
      private IDataReader C82 ;
      private ReadWriteCommand cmC83 ;
   }

}
