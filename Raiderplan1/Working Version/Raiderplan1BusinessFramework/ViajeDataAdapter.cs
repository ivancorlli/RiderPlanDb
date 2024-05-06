
//               File: ViajeDataAdapter
//        Description: Viaje
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5_0.002
//       Program type: Deklarit Business Component
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   using System;
   using System.Collections;
   using Deklarit.Utils;
   using System.Data;
   using System.Data.SqlClient;
   using System.Data.Common;
   using Deklarit.Data;
   using System.ComponentModel.Design;
   using System.Runtime.Serialization;
   using System.Security.Permissions;
   using System.Data.SqlTypes;
   public partial class ViajeDataAdapter : System.Data.IDataAdapter, IViajeDataAdapter
   {
      private ViajeDataSet ViajeSet ;
      private IDbTransaction daCurrentTransaction ;
      private ViajeDataSet.ViajeRow rowViaje ;
      public ViajeDataAdapter( )
      {
      }

      private void InitializeMembers( )
      {
         ViajeSet = new ViajeDataSet() ;
         this.Initialize( ) ;
         dsDefault = new DataStore( new SqlServer2005Handler( ), "System.Data.SqlClient", Raiderplan1.Configuration.ConnectionString, DeklaritTransaction.TransactionSlotName) ;
      }

      ///  <summary>
      ///   Gets or sets the Transaction object to be used  by  ViajeDataAdapterclasses to commit
      ///    changes to the Database.
      ///  </summary>
      public IDbTransaction Transaction
      {
         get {
            return daCurrentTransaction ;
         }

         set {
            daCurrentTransaction = value ;
         }

      }

      ///  <summary>
      ///   Gets or sets the missing mapping action.
      ///  </summary>
      public MissingMappingAction MissingMappingAction
      {
         get {
            return System.Data.MissingMappingAction.Passthrough ;
         }

         set {
         }

      }

      ///  <summary>
      ///   Gets or sets the missing schema action.
      ///  </summary>
      public MissingSchemaAction MissingSchemaAction
      {
         get {
            return System.Data.MissingSchemaAction.Ignore ;
         }

         set {
         }

      }

      ///  <summary>
      ///   Gets the table mappings.
      ///  </summary>
      public ITableMappingCollection TableMappings
      {
         get {
            System.Data.Common.DataTableMappingCollection tableMaps ;
            tableMaps = new System.Data.Common.DataTableMappingCollection() ;
            return tableMaps ;
         }

      }

      ///  <summary>
      ///   Fills the schema for the datasource.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="schemaType">Schema type</param>
      public virtual DataTable[] FillSchema( DataSet dataSet ,
                                             SchemaType schemaType )
      {
         DataTable[] dataTables ;
         dataTables = new DataTable[dataSet.Tables.Count]  ;
         dataSet.Tables.CopyTo( dataTables, dataSet.Tables.Count) ;
         return dataTables ;
      }


      ///  <summary>
      ///   (2) Fills the specified Dataset with the record matching ViajeID field(s) of the
      ///    given IDataRecord
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="dataRecord">Data Record</param>
      public virtual int Fill( ViajeDataSet dataSet ,
                               IDataRecord dataRecord )
      {
         return Fill(dataSet, ((long)(dataRecord["ViajeID"]))) ;
      }

      ///  <summary>
      ///   (3) Fills the specified Dataset with the record matching ViajeID field(s) of the
      ///    given DataRow
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="dataRecord">Data Row</param>
      public virtual int Fill( ViajeDataSet dataSet ,
                               DataRow dataRecord )
      {
         return Fill(dataSet, ((long)(dataRecord["ViajeID"]))) ;
      }

      ///  <summary>
      ///   (4) Fills the specified Dataset with the record matching ViajeID, if the record is
      ///    not found , throws an exception.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="viajeID">Viaje ID</param>
      public virtual int Fill( ViajeDataSet dataSet ,
                               long viajeID )
      {
         if ( ! FillByViajeID( dataSet, viajeID) )
         {
            throw new ViajeNotFoundException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("inex"), new   object[]  {resourceManagerTables.GetString("Viaje")})) ;
         }
         return 0 ;
      }


      ///  <summary>
      ///   (5) Fills the specified Dataset with the record matching ViajeID in the fillDataParameters
      ///    array, if the array is null, it fills the Dataset loading all records in the table.
      ///
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Fill( ViajeDataSet dataSet )
      {
         if ( ( fillDataParameters != null ) )
         {
            Fill( dataSet, System.Int64.Parse( fillDataParameters[0].Value.ToString())) ;
         }
         else
         {
            try
            {
               InitializeMembers( ) ;
               connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
               ViajeSet = dataSet ;
               LoadChildViaje( 0, -1) ;
               dataSet.AcceptChanges( ) ;
            }
            finally
            {
               this.Cleanup();
            }
         }
         return 0 ;
      }


      ///  <summary>
      ///   (6) Fills the specified dataset filtered by ViajeIDfield(s).
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="viajeID">Viaje ID</param>
      public virtual bool FillByViajeID( ViajeDataSet dataSet ,
                                         long viajeID )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         ViajeSet = dataSet ;
         rowViaje = ViajeSet.Viaje.NewViajeRow() ;
         rowViaje.ViajeID = viajeID ;
         try
         {
            LoadByViajeID( 0, -1) ;
            dataSet.AcceptChanges( ) ;
         }
         finally
         {
            this.Cleanup();
         }
         if ( ( RcdFound8 == 0 ) )
         {
            return false ;
         }
         return true ;
      }


      ///  <summary>
      ///   (6) Fills the specified dataset filtered by UsuarioIDfield(s).
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="usuarioID">Usuario ID</param>
      public virtual int FillByUsuarioID( ViajeDataSet dataSet ,
                                          int usuarioID )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         ViajeSet = dataSet ;
         rowViaje = ViajeSet.Viaje.NewViajeRow() ;
         rowViaje.UsuarioID = usuarioID ;
         try
         {
            LoadByUsuarioID( 0, -1) ;
            dataSet.AcceptChanges( ) ;
         }
         finally
         {
            this.Cleanup();
         }
         return 0 ;
      }


      ///  <summary>
      ///   (6) Fills a page of up to maxRows rows into the specified dataset filtered by UsuarioIDfield(s)starting
      ///    at startRow
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="usuarioID">Usuario ID</param>
      ///  <param name="startRow">Starting row</param>
      ///  <param name="maxRows">Max number of rows to load</param>
      public virtual int FillPageByUsuarioID( ViajeDataSet dataSet ,
                                              int usuarioID ,
                                              int startRow ,
                                              int maxRows )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         ViajeSet = dataSet ;
         rowViaje = ViajeSet.Viaje.NewViajeRow() ;
         rowViaje.UsuarioID = usuarioID ;
         try
         {
            LoadByUsuarioID( startRow, maxRows) ;
            dataSet.AcceptChanges( ) ;
         }
         finally
         {
            this.Cleanup();
         }
         return 0 ;
      }


      ///  <summary>
      ///   (9) Gets the record count filtered by UsuarioIDfield(s).
      ///  </summary>
      ///  <param name="usuarioID">Usuario ID</param>
      public virtual int GetRecordCountByUsuarioID( int usuarioID )
      {
         int m_Count ;
         try
         {
            InitializeMembers( ) ;
            m_Count = GetInternalRecordCountByUsuarioID( usuarioID ) ;
         }
         finally
         {
            this.Cleanup();
         }
         return m_Count ;
      }

      private int GetInternalRecordCountByUsuarioID( int usuarioID )
      {
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmViajeSelect1 = connDefault.GetCommand("SELECT COUNT(*) FROM [Viaje] WITH (NOLOCK) WHERE [UsuarioID] = @UsuarioID ", false) ;
         if ( ( cmViajeSelect1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmViajeSelect1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioID", System.Data.DbType.Int32));
         }
         cmViajeSelect1.SetParameter(0, usuarioID);
         ViajeSelect1 = cmViajeSelect1.FetchData() ;
         recordCount = ( ( ViajeSelect1.IsDBNull(0) )  ? (int)(0) : ViajeSelect1.GetInt32(0) ) ;
         ViajeSelect1.Close();
         return recordCount ;
      }

      ///  <summary>
      ///   (8) Fills the specified dataset with the record matching ViajeID in the the fillDataParameters
      ///    array, if the array is null, it fills the Dataset loading all records in the table.
      ///
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Fill( DataSet dataSet )
      {
         ViajeSet = dataSet as ViajeDataSet ;
         if ( ( ViajeSet != null ) )
         {
            return Fill( ViajeSet) ;
         }
         else
         {
            ViajeSet = new ViajeDataSet() ;
            Fill( ViajeSet) ;
            dataSet.Merge( ViajeSet) ;
            return 0 ;
         }
      }

      ///  <summary>
      ///   (11) Fills a page of up to maxRows rows into the specified dataset starting at startRow
      ///
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="startRow">Starting row</param>
      ///  <param name="maxRows">Max number of rows to load</param>
      public virtual int FillPage( ViajeDataSet dataSet ,
                                   int startRow ,
                                   int maxRows )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         ViajeSet = dataSet ;
         try
         {
            LoadChildViaje( startRow, maxRows) ;
            dataSet.AcceptChanges( ) ;
         }
         finally
         {
            this.Cleanup();
         }
         return 0 ;
      }


      ///  <summary>
      ///   (9) Gets the total record count.
      ///  </summary>
      public virtual int GetRecordCount( )
      {
         int m_Count ;
         try
         {
            InitializeMembers( ) ;
            m_Count = GetInternalRecordCount(  ) ;
         }
         finally
         {
            this.Cleanup();
         }
         return m_Count ;
      }

      private int GetInternalRecordCount( )
      {
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmViajeSelect2 = connDefault.GetCommand("SELECT COUNT(*) FROM [Viaje] WITH (NOLOCK) ", false) ;
         ViajeSelect2 = cmViajeSelect2.FetchData() ;
         recordCount = ( ( ViajeSelect2.IsDBNull(0) )  ? (int)(0) : ViajeSelect2.GetInt32(0) ) ;
         ViajeSelect2.Close();
         return recordCount ;
      }

      ///  <summary>
      ///   Gets the fill parameters array.
      ///  </summary>
      public virtual IDataParameter[] GetFillParameters( )
      {
         if ( ( fillDataParameters == null ) )
         {
            DbProviderFactory factory = System.Data.Common.DbProviderFactories.GetFactory( "System.Data.SqlClient") ;
            DbParameter parm0ViajeID ;
            parm0ViajeID = factory.CreateParameter() ;
            parm0ViajeID.ParameterName = "ViajeID" ;
            parm0ViajeID.DbType = System.Data.DbType.Int64 ;
            fillDataParameters = new  DbParameter[]  {parm0ViajeID} ;
         }
         return fillDataParameters ;
      }

      private DbParameter[] fillDataParameters ;

      ///  <summary>
      ///   Inserts, Updates or Deletes records from the specified ViajeDataSet object.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Update( DataSet dataSet )
      {
         InitializeMembers( ) ;
         ViajeSet = dataSet as ViajeDataSet ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         if ( ( ViajeSet != null ) )
         {
            try
            {
               connDefault.BeginTransaction();
               foreach( ViajeDataSet.ViajeRow row in ViajeSet.Viaje )
               {
                  rowViaje = row ;
                  if ( Deklarit.Data.Helpers.IsRowChanged(rowViaje) )
                  {
                     ReadRowViaje( ) ;
                     if ( ( rowViaje.RowState == System.Data.DataRowState.Added ) )
                     {
                        InsertViaje( ) ;
                     }
                     else
                     {
                        if ( _Gxremove )
                        {
                           Delete( ) ;
                        }
                        else
                        {
                           UpdateViaje( ) ;
                        }
                     }
                  }
               }

               dataSet.AcceptChanges( ) ;
               connDefault.Commit();
            }
            catch ( Exception  )
            {
               connDefault.Rollback();
               throw  ;
            }
            finally
            {
               this.Cleanup();
            }
         }
         else
         {
            throw new System.ArgumentException( resourceManager.GetString("nulldset")) ;
         }
         return 0 ;
      }

      private void LoadRowViaje( )
      {
         AddRowViaje( ) ;
      }

      private void ReadRowViaje( )
      {
         Gx_mode = Deklarit.Utils.Mode.FromRowState(rowViaje.RowState) ;
         if ( ( rowViaje.RowState != System.Data.DataRowState.Deleted ) )
         {
            rowViaje["FechaSalidaProgramada"] = Deklarit.Utils.DateTimeUtil.ResetMillisecondsObject(rowViaje["FechaSalidaProgramada"]) ;
            rowViaje["FechaLlegadaProgramada"] = Deklarit.Utils.DateTimeUtil.ResetMillisecondsObject(rowViaje["FechaLlegadaProgramada"]) ;
            rowViaje["FechaSalidaEfectiva"] = Deklarit.Utils.DateTimeUtil.ResetMillisecondsObject(rowViaje["FechaSalidaEfectiva"]) ;
            rowViaje["FechaLlegadaEfectiva"] = Deklarit.Utils.DateTimeUtil.ResetMillisecondsObject(rowViaje["FechaLlegadaEfectiva"]) ;
         }
         if ( ( rowViaje.RowState != System.Data.DataRowState.Added ) )
         {
            m__VaijeNombreOriginal = rowViaje["VaijeNombre", System.Data.DataRowVersion.Original] ;
            m__FechaSalidaProgramadaOriginal = rowViaje["FechaSalidaProgramada", System.Data.DataRowVersion.Original] ;
            m__FechaLlegadaProgramadaOriginal = rowViaje["FechaLlegadaProgramada", System.Data.DataRowVersion.Original] ;
            m__FechaSalidaEfectivaOriginal = rowViaje["FechaSalidaEfectiva", System.Data.DataRowVersion.Original] ;
            m__FechaLlegadaEfectivaOriginal = rowViaje["FechaLlegadaEfectiva", System.Data.DataRowVersion.Original] ;
            m__LugarPartidaOriginal = rowViaje["LugarPartida", System.Data.DataRowVersion.Original] ;
            m__LugarllegadaOriginal = rowViaje["Lugarllegada", System.Data.DataRowVersion.Original] ;
            m__LongitudPartidaOriginal = rowViaje["LongitudPartida", System.Data.DataRowVersion.Original] ;
            m__LatitudPartidaOriginal = rowViaje["LatitudPartida", System.Data.DataRowVersion.Original] ;
            m__LongitudLegadaOriginal = rowViaje["LongitudLegada", System.Data.DataRowVersion.Original] ;
            m__LatitudLlegadaOriginal = rowViaje["LatitudLlegada", System.Data.DataRowVersion.Original] ;
            m__kmTotalesEstimadoOriginal = rowViaje["kmTotalesEstimado", System.Data.DataRowVersion.Original] ;
            m__MotocilcetaMarcaOriginal = rowViaje["MotocilcetaMarca", System.Data.DataRowVersion.Original] ;
            m__MotociletaModeloOriginal = rowViaje["MotociletaModelo", System.Data.DataRowVersion.Original] ;
            m__UsuarioIDOriginal = rowViaje["UsuarioID", System.Data.DataRowVersion.Original] ;
         }
         else
         {
            m__VaijeNombreOriginal = rowViaje["VaijeNombre"] ;
            m__FechaSalidaProgramadaOriginal = rowViaje["FechaSalidaProgramada"] ;
            m__FechaLlegadaProgramadaOriginal = rowViaje["FechaLlegadaProgramada"] ;
            m__FechaSalidaEfectivaOriginal = rowViaje["FechaSalidaEfectiva"] ;
            m__FechaLlegadaEfectivaOriginal = rowViaje["FechaLlegadaEfectiva"] ;
            m__LugarPartidaOriginal = rowViaje["LugarPartida"] ;
            m__LugarllegadaOriginal = rowViaje["Lugarllegada"] ;
            m__LongitudPartidaOriginal = rowViaje["LongitudPartida"] ;
            m__LatitudPartidaOriginal = rowViaje["LatitudPartida"] ;
            m__LongitudLegadaOriginal = rowViaje["LongitudLegada"] ;
            m__LatitudLlegadaOriginal = rowViaje["LatitudLlegada"] ;
            m__kmTotalesEstimadoOriginal = rowViaje["kmTotalesEstimado"] ;
            m__MotocilcetaMarcaOriginal = rowViaje["MotocilcetaMarca"] ;
            m__MotociletaModeloOriginal = rowViaje["MotociletaModelo"] ;
            m__UsuarioIDOriginal = rowViaje["UsuarioID"] ;
         }
         _Gxremove = (bool)((rowViaje.RowState==System.Data.DataRowState.Deleted)) ;
         if ( _Gxremove )
         {
            rowViaje = ((ViajeDataSet.ViajeRow)(Deklarit.Utils.DataSetUtil.CloneOriginalDataRow(rowViaje)));
         }
      }

      private void CheckIntegrityErrorsViaje( )
      {
          IDataReader UsuarioSelect1 ;
          ReadWriteCommand cmUsuarioSelect1 ;
         cmUsuarioSelect1 = connDefault.GetCommand("SELECT [UsuarioID] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioID] = @UsuarioID ", false) ;
         if ( ( cmUsuarioSelect1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmUsuarioSelect1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioID", System.Data.DbType.Int32));
         }
         cmUsuarioSelect1.SetParameter(0, rowViaje["UsuarioID"]);
         UsuarioSelect1 = cmUsuarioSelect1.FetchData() ;
         if ( !cmUsuarioSelect1.HasMoreRows )
         {
            UsuarioSelect1.Close();
            throw new UsuarioForeignKeyNotFoundException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("inex"), new   object[]  {resourceManagerTables.GetString("Usuario")})) ;
         }
         UsuarioSelect1.Close();
         throw new ForeignKeyNotFoundException( resourceManager.GetString("refinterror")) ;
      }

      private void GetByPrimaryKey( )
      {
          IDataReader ViajeSelect3 ;
          ReadWriteCommand cmViajeSelect3 ;
         cmViajeSelect3 = connDefault.GetCommand("SELECT [ViajeID], [VaijeNombre], [FechaSalidaProgramada], [FechaLlegadaProgramada], [FechaSalidaEfectiva], [FechaLlegadaEfectiva], [LugarPartida], [Lugarllegada], [LongitudPartida], [LatitudPartida], [LongitudLegada], [LatitudLlegada], [kmTotalesEstimado], [MotocilcetaMarca], [MotociletaModelo], [UsuarioID] FROM [Viaje] WITH (NOLOCK) WHERE [ViajeID] = @ViajeID ", false) ;
         if ( ( cmViajeSelect3.IDbCommand.Parameters.Count == 0 ) )
         {
            cmViajeSelect3.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
         }
         cmViajeSelect3.SetParameter(0, rowViaje["ViajeID"]);
         ViajeSelect3 = cmViajeSelect3.FetchData() ;
         if ( cmViajeSelect3.HasMoreRows )
         {
            RcdFound8 = 1 ;
            rowViaje["ViajeID"] = dsDefault.Db.GetInt64(ViajeSelect3, 0) ;
            rowViaje["VaijeNombre"] = dsDefault.Db.GetString(ViajeSelect3, 1) ;
            rowViaje["FechaSalidaProgramada"] = dsDefault.Db.GetDateTime(ViajeSelect3, 2) ;
            rowViaje["FechaLlegadaProgramada"] = dsDefault.Db.GetDateTime(ViajeSelect3, 3) ;
            rowViaje["FechaSalidaEfectiva"] = dsDefault.Db.GetDateTime(ViajeSelect3, 4) ;
            rowViaje["FechaLlegadaEfectiva"] = dsDefault.Db.GetDateTime(ViajeSelect3, 5) ;
            rowViaje["LugarPartida"] = dsDefault.Db.GetString(ViajeSelect3, 6) ;
            rowViaje["Lugarllegada"] = dsDefault.Db.GetString(ViajeSelect3, 7) ;
            rowViaje["LongitudPartida"] = dsDefault.Db.GetDecimal(ViajeSelect3, 8) ;
            rowViaje["LatitudPartida"] = dsDefault.Db.GetDecimal(ViajeSelect3, 9) ;
            rowViaje["LongitudLegada"] = dsDefault.Db.GetDecimal(ViajeSelect3, 10) ;
            rowViaje["LatitudLlegada"] = dsDefault.Db.GetDecimal(ViajeSelect3, 11) ;
            rowViaje["kmTotalesEstimado"] = dsDefault.Db.GetDecimal(ViajeSelect3, 12) ;
            rowViaje["MotocilcetaMarca"] = dsDefault.Db.GetString(ViajeSelect3, 13) ;
            rowViaje["MotociletaModelo"] = dsDefault.Db.GetString(ViajeSelect3, 14) ;
            rowViaje["UsuarioID"] = dsDefault.Db.GetInt32(ViajeSelect3, 15) ;
            sMode8 = Gx_mode ;
            Gx_mode = Mode.Display ;
            Gx_mode = sMode8 ;
         }
         else
         {
            RcdFound8 = 0 ;
         }
         ViajeSelect3.Close();
      }

      private void CheckOptimisticConcurrencyViaje( )
      {
          IDataReader ViajeSelect4 ;
          ReadWriteCommand cmViajeSelect4 ;
         if ( ( Gx_mode != Mode.Insert ) )
         {
            cmViajeSelect4 = connDefault.GetCommand("SELECT [ViajeID], [VaijeNombre], [FechaSalidaProgramada], [FechaLlegadaProgramada], [FechaSalidaEfectiva], [FechaLlegadaEfectiva], [LugarPartida], [Lugarllegada], [LongitudPartida], [LatitudPartida], [LongitudLegada], [LatitudLlegada], [kmTotalesEstimado], [MotocilcetaMarca], [MotociletaModelo], [UsuarioID] FROM [Viaje] WITH (UPDLOCK) WHERE [ViajeID] = @ViajeID ", false) ;
            if ( ( cmViajeSelect4.IDbCommand.Parameters.Count == 0 ) )
            {
               cmViajeSelect4.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
            }
            cmViajeSelect4.SetParameter(0, rowViaje["ViajeID"]);
            ViajeSelect4 = cmViajeSelect4.FetchData() ;
            if ( cmViajeSelect4.Locked )
            {
               ViajeSelect4.Close();
               throw new ViajeDataLockedException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("lock"), new   object[]  {resourceManagerTables.GetString("Viaje")})) ;
            }
            _Condition = false ;
            if ( !cmViajeSelect4.HasMoreRows || ( ! StringUtil.ObjectStringEquals(m__VaijeNombreOriginal,dsDefault.Db.GetString(ViajeSelect4, 1)) ) || ( ! DateTimeUtil.ObjectDateTimeEquals(m__FechaSalidaProgramadaOriginal,dsDefault.Db.GetDateTime(ViajeSelect4, 2)) ) || ( ! DateTimeUtil.ObjectDateTimeEquals(m__FechaLlegadaProgramadaOriginal,dsDefault.Db.GetDateTime(ViajeSelect4, 3)) ) || ( ! DateTimeUtil.ObjectDateTimeEquals(m__FechaSalidaEfectivaOriginal,dsDefault.Db.GetDateTime(ViajeSelect4, 4)) ) || ( ! DateTimeUtil.ObjectDateTimeEquals(m__FechaLlegadaEfectivaOriginal,dsDefault.Db.GetDateTime(ViajeSelect4, 5)) ) )
            {
               _Condition = true ;
            }
            if ( _Condition || ( ! StringUtil.ObjectStringEquals(m__LugarPartidaOriginal,dsDefault.Db.GetString(ViajeSelect4, 6)) ) || ( ! StringUtil.ObjectStringEquals(m__LugarllegadaOriginal,dsDefault.Db.GetString(ViajeSelect4, 7)) ) || ( ! m__LongitudPartidaOriginal.Equals(dsDefault.Db.GetDecimal(ViajeSelect4, 8)) ) || ( ! m__LatitudPartidaOriginal.Equals(dsDefault.Db.GetDecimal(ViajeSelect4, 9)) ) || ( ! m__LongitudLegadaOriginal.Equals(dsDefault.Db.GetDecimal(ViajeSelect4, 10)) ) )
            {
               _Condition = true ;
            }
            if ( _Condition || ( ! m__LatitudLlegadaOriginal.Equals(dsDefault.Db.GetDecimal(ViajeSelect4, 11)) ) || ( ! m__kmTotalesEstimadoOriginal.Equals(dsDefault.Db.GetDecimal(ViajeSelect4, 12)) ) || ( ! StringUtil.ObjectStringEquals(m__MotocilcetaMarcaOriginal,dsDefault.Db.GetString(ViajeSelect4, 13)) ) || ( ! StringUtil.ObjectStringEquals(m__MotociletaModeloOriginal,dsDefault.Db.GetString(ViajeSelect4, 14)) ) || ( ! m__UsuarioIDOriginal.Equals(dsDefault.Db.GetInt32(ViajeSelect4, 15)) ) )
            {
               ViajeSelect4.Close();
               throw new ViajeDataChangedException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("waschg"), new   object[]  {resourceManagerTables.GetString("Viaje")})) ;
            }
            ViajeSelect4.Close();
         }
      }

      private void InsertViaje( )
      {
          IDataReader ViajeInsert1 ;
          ReadWriteCommand cmViajeInsert1 ;
         CheckOptimisticConcurrencyViaje( ) ;
         AfterConfirmViaje( ) ;
         cmViajeInsert1 = connDefault.GetCommand("INSERT INTO [Viaje] ([VaijeNombre], [FechaSalidaProgramada], [FechaLlegadaProgramada], [FechaSalidaEfectiva], [FechaLlegadaEfectiva], [LugarPartida], [Lugarllegada], [LongitudPartida], [LatitudPartida], [LongitudLegada], [LatitudLlegada], [kmTotalesEstimado], [MotocilcetaMarca], [MotociletaModelo], [UsuarioID]) VALUES (@VaijeNombre, @FechaSalidaProgramada, @FechaLlegadaProgramada, @FechaSalidaEfectiva, @FechaLlegadaEfectiva, @LugarPartida, @Lugarllegada, @LongitudPartida, @LatitudPartida, @LongitudLegada, @LatitudLlegada, @kmTotalesEstimado, @MotocilcetaMarca, @MotociletaModelo, @UsuarioID); SELECT SCOPE_IDENTITY()", false) ;
         if ( ( cmViajeInsert1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@VaijeNombre", System.Data.DbType.AnsiString,180));
            cmViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@FechaSalidaProgramada", System.Data.DbType.DateTime));
            cmViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@FechaLlegadaProgramada", System.Data.DbType.DateTime));
            cmViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@FechaSalidaEfectiva", System.Data.DbType.DateTime));
            cmViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@FechaLlegadaEfectiva", System.Data.DbType.DateTime));
            cmViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LugarPartida", System.Data.DbType.AnsiString,150));
            cmViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@Lugarllegada", System.Data.DbType.AnsiString,150));
            cmViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LongitudPartida", System.Data.DbType.Decimal));
            cmViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LatitudPartida", System.Data.DbType.Decimal));
            cmViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LongitudLegada", System.Data.DbType.Decimal));
            cmViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LatitudLlegada", System.Data.DbType.Decimal));
            cmViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@kmTotalesEstimado", System.Data.DbType.Currency));
            cmViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@MotocilcetaMarca", System.Data.DbType.AnsiString,30));
            cmViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@MotociletaModelo", System.Data.DbType.AnsiString,50));
            cmViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioID", System.Data.DbType.Int32));
         }
         cmViajeInsert1.ErrorMask = cmViajeInsert1.ErrorMask  |  ErrorMask.ForeignKeyError;
         cmViajeInsert1.ErrorMask = cmViajeInsert1.ErrorMask  |  ErrorMask.DuplicateKeyError;
         cmViajeInsert1.SetParameter(0, rowViaje["VaijeNombre"]);
         cmViajeInsert1.SetParameterDateTimeObject(1, rowViaje["FechaSalidaProgramada"]);
         cmViajeInsert1.SetParameterDateTimeObject(2, rowViaje["FechaLlegadaProgramada"]);
         cmViajeInsert1.SetParameterDateTimeObject(3, rowViaje["FechaSalidaEfectiva"]);
         cmViajeInsert1.SetParameterDateTimeObject(4, rowViaje["FechaLlegadaEfectiva"]);
         cmViajeInsert1.SetParameter(5, rowViaje["LugarPartida"]);
         cmViajeInsert1.SetParameter(6, rowViaje["Lugarllegada"]);
         cmViajeInsert1.SetParameter(7, rowViaje["LongitudPartida"]);
         cmViajeInsert1.SetParameter(8, rowViaje["LatitudPartida"]);
         cmViajeInsert1.SetParameter(9, rowViaje["LongitudLegada"]);
         cmViajeInsert1.SetParameter(10, rowViaje["LatitudLlegada"]);
         cmViajeInsert1.SetParameter(11, rowViaje["kmTotalesEstimado"]);
         cmViajeInsert1.SetParameter(12, rowViaje["MotocilcetaMarca"]);
         cmViajeInsert1.SetParameter(13, rowViaje["MotociletaModelo"]);
         cmViajeInsert1.SetParameter(14, rowViaje["UsuarioID"]);
         ViajeInsert1 = cmViajeInsert1.FetchData() ;
         if ( ! ( cmViajeInsert1.ForeignKeyError || cmViajeInsert1.DupKey ) )
         {
            rowViaje.ViajeID = (long)(ViajeInsert1.GetDecimal(0)) ;
            ViajeInsert1.Close();
         }
         if ( cmViajeInsert1.ForeignKeyError )
         {
            CheckIntegrityErrorsViaje( ) ;
         }
         // Start of After( Insert) rules
         // End of After( Insert) rules
         OnViajeUpdated( new ViajeEventArgs( rowViaje, Mode.Insert)) ;
         // Save values for previous() function.
         EndLevelViaje( ) ;
      }

      private void UpdateViaje( )
      {
          ReadWriteCommand cmViajeUpdate1 ;
         CheckOptimisticConcurrencyViaje( ) ;
         AfterConfirmViaje( ) ;
         cmViajeUpdate1 = connDefault.GetCommand("UPDATE [Viaje] SET [VaijeNombre]=@VaijeNombre, [FechaSalidaProgramada]=@FechaSalidaProgramada, [FechaLlegadaProgramada]=@FechaLlegadaProgramada, [FechaSalidaEfectiva]=@FechaSalidaEfectiva, [FechaLlegadaEfectiva]=@FechaLlegadaEfectiva, [LugarPartida]=@LugarPartida, [Lugarllegada]=@Lugarllegada, [LongitudPartida]=@LongitudPartida, [LatitudPartida]=@LatitudPartida, [LongitudLegada]=@LongitudLegada, [LatitudLlegada]=@LatitudLlegada, [kmTotalesEstimado]=@kmTotalesEstimado, [MotocilcetaMarca]=@MotocilcetaMarca, [MotociletaModelo]=@MotociletaModelo, [UsuarioID]=@UsuarioID  WHERE [ViajeID] = @ViajeID", false) ;
         if ( ( cmViajeUpdate1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@VaijeNombre", System.Data.DbType.AnsiString,180));
            cmViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@FechaSalidaProgramada", System.Data.DbType.DateTime));
            cmViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@FechaLlegadaProgramada", System.Data.DbType.DateTime));
            cmViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@FechaSalidaEfectiva", System.Data.DbType.DateTime));
            cmViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@FechaLlegadaEfectiva", System.Data.DbType.DateTime));
            cmViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LugarPartida", System.Data.DbType.AnsiString,150));
            cmViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@Lugarllegada", System.Data.DbType.AnsiString,150));
            cmViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LongitudPartida", System.Data.DbType.Decimal));
            cmViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LatitudPartida", System.Data.DbType.Decimal));
            cmViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LongitudLegada", System.Data.DbType.Decimal));
            cmViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LatitudLlegada", System.Data.DbType.Decimal));
            cmViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@kmTotalesEstimado", System.Data.DbType.Currency));
            cmViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@MotocilcetaMarca", System.Data.DbType.AnsiString,30));
            cmViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@MotociletaModelo", System.Data.DbType.AnsiString,50));
            cmViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioID", System.Data.DbType.Int32));
            cmViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
         }
         cmViajeUpdate1.ErrorMask = cmViajeUpdate1.ErrorMask  |  ErrorMask.ForeignKeyError;
         // Using cursor ViajeUpdate1
         cmViajeUpdate1.SetParameter(0, rowViaje["VaijeNombre"]);
         cmViajeUpdate1.SetParameterDateTimeObject(1, rowViaje["FechaSalidaProgramada"]);
         cmViajeUpdate1.SetParameterDateTimeObject(2, rowViaje["FechaLlegadaProgramada"]);
         cmViajeUpdate1.SetParameterDateTimeObject(3, rowViaje["FechaSalidaEfectiva"]);
         cmViajeUpdate1.SetParameterDateTimeObject(4, rowViaje["FechaLlegadaEfectiva"]);
         cmViajeUpdate1.SetParameter(5, rowViaje["LugarPartida"]);
         cmViajeUpdate1.SetParameter(6, rowViaje["Lugarllegada"]);
         cmViajeUpdate1.SetParameter(7, rowViaje["LongitudPartida"]);
         cmViajeUpdate1.SetParameter(8, rowViaje["LatitudPartida"]);
         cmViajeUpdate1.SetParameter(9, rowViaje["LongitudLegada"]);
         cmViajeUpdate1.SetParameter(10, rowViaje["LatitudLlegada"]);
         cmViajeUpdate1.SetParameter(11, rowViaje["kmTotalesEstimado"]);
         cmViajeUpdate1.SetParameter(12, rowViaje["MotocilcetaMarca"]);
         cmViajeUpdate1.SetParameter(13, rowViaje["MotociletaModelo"]);
         cmViajeUpdate1.SetParameter(14, rowViaje["UsuarioID"]);
         cmViajeUpdate1.SetParameter(15, rowViaje["ViajeID"]);
         cmViajeUpdate1.ExecuteStmt();
         if ( cmViajeUpdate1.ForeignKeyError )
         {
            CheckIntegrityErrorsViaje( ) ;
         }
         // Start of After( update) rules
         // End of After( update) rules
         OnViajeUpdated( new ViajeEventArgs( rowViaje, Mode.Update)) ;
         EndLevelViaje( ) ;
      }

      private void Delete( )
      {
          ReadWriteCommand cmViajeDelete1 ;
         Gx_mode = Mode.Delete ;
         CheckOptimisticConcurrencyViaje( ) ;
         // No cascading delete specified.
         AfterConfirmViaje( ) ;
         cmViajeDelete1 = connDefault.GetCommand("DELETE FROM [Viaje]  WHERE [ViajeID] = @ViajeID", false) ;
         if ( ( cmViajeDelete1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmViajeDelete1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
         }
         cmViajeDelete1.ErrorMask = cmViajeDelete1.ErrorMask  |  ErrorMask.ForeignKeyError;
         // Using cursor ViajeDelete1
         cmViajeDelete1.SetParameter(0, rowViaje["ViajeID"]);
         cmViajeDelete1.ExecuteStmt();
         if ( cmViajeDelete1.ForeignKeyError )
         {
            CheckDeleteErrorsViaje( ) ;
         }
         // Start of After( delete) rules
         // End of After( delete) rules
         OnViajeUpdated( new ViajeEventArgs( rowViaje, Mode.Delete)) ;
         rowViaje.Delete( ) ;
         sMode8 = Gx_mode ;
         Gx_mode = Mode.Delete ;
         EndLevelViaje( ) ;
         Gx_mode = sMode8 ;
      }

      private void CheckDeleteErrorsViaje( )
      {
          IDataReader TrayectoViajeSelect1 ;
          ReadWriteCommand cmTrayectoViajeSelect1 ;
         cmTrayectoViajeSelect1 = connDefault.GetCommand("SELECT TOP 1 [TrayectoViajeID] FROM [TrayectoViaje] WITH (NOLOCK) WHERE [ViajeID] = @ViajeID ", false) ;
         if ( ( cmTrayectoViajeSelect1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmTrayectoViajeSelect1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
         }
         cmTrayectoViajeSelect1.SetParameter(0, rowViaje["ViajeID"]);
         TrayectoViajeSelect1 = cmTrayectoViajeSelect1.FetchData() ;
         if ( cmTrayectoViajeSelect1.HasMoreRows )
         {
            TrayectoViajeSelect1.Close();
            throw new TrayectoViajeInvalidDeleteException( string.Format(resourceManager.GetString("del"), new   object[]  {"TrayectoViaje"})) ;
         }
         TrayectoViajeSelect1.Close();
      }

      private void EndLevelViaje( )
      {
         // Execute 'After Trn' event if defined.
         IsModified = 0 ;
      }

      private void ScanByViajeID( int startRow ,
                                  int maxRows )
      {
         m_WhereString = " WHERE TM1.[ViajeID] = @ViajeID" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString8 + "  FROM [Viaje] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[ViajeID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString8 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[ViajeID] ) AS DK_PAGENUM   FROM [Viaje] TM1 WITH (NOLOCK) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString8 + " FROM [Viaje] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[ViajeID] " ;
         }
         cmViajeSelect5 = connDefault.GetCommand(scmdbuf, false) ;
         if ( ( cmViajeSelect5.IDbCommand.Parameters.Count == 0 ) )
         {
            cmViajeSelect5.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
         }
         cmViajeSelect5.SetParameter(0, rowViaje["ViajeID"]);
         ViajeSelect5 = cmViajeSelect5.FetchData() ;
         RcdFound8 = 0 ;
         ScanLoadViaje( ) ;
         LoadDataViaje( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanByUsuarioID( int startRow ,
                                    int maxRows )
      {
         m_WhereString = " WHERE TM1.[UsuarioID] = @UsuarioID" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString8 + "  FROM [Viaje] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[ViajeID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString8 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[ViajeID] ) AS DK_PAGENUM   FROM [Viaje] TM1 WITH (NOLOCK) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString8 + " FROM [Viaje] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[ViajeID] " ;
         }
         cmViajeSelect5 = connDefault.GetCommand(scmdbuf, false) ;
         if ( ( cmViajeSelect5.IDbCommand.Parameters.Count == 0 ) )
         {
            cmViajeSelect5.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioID", System.Data.DbType.Int32));
         }
         cmViajeSelect5.SetParameter(0, rowViaje["UsuarioID"]);
         ViajeSelect5 = cmViajeSelect5.FetchData() ;
         RcdFound8 = 0 ;
         ScanLoadViaje( ) ;
         LoadDataViaje( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanStartViaje( int startRow ,
                                   int maxRows )
      {
         m_WhereString = "" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString8 + "  FROM [Viaje] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[ViajeID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString8 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[ViajeID] ) AS DK_PAGENUM   FROM [Viaje] TM1 WITH (NOLOCK) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString8 + " FROM [Viaje] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[ViajeID] " ;
         }
         cmViajeSelect5 = connDefault.GetCommand(scmdbuf, false) ;
         ViajeSelect5 = cmViajeSelect5.FetchData() ;
         RcdFound8 = 0 ;
         ScanLoadViaje( ) ;
         LoadDataViaje( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanNextViaje( )
      {
         cmViajeSelect5.HasMoreRows = ViajeSelect5.Read() ;
         RcdFound8 = 0 ;
         ScanLoadViaje( ) ;
      }

      private void ScanLoadViaje( )
      {
         Gx_mode = Mode.Display ;
         if ( cmViajeSelect5.HasMoreRows )
         {
            RcdFound8 = 1 ;
            rowViaje["ViajeID"] = dsDefault.Db.GetInt64(ViajeSelect5, 0) ;
            rowViaje["VaijeNombre"] = dsDefault.Db.GetString(ViajeSelect5, 1) ;
            rowViaje["FechaSalidaProgramada"] = dsDefault.Db.GetDateTime(ViajeSelect5, 2) ;
            rowViaje["FechaLlegadaProgramada"] = dsDefault.Db.GetDateTime(ViajeSelect5, 3) ;
            rowViaje["FechaSalidaEfectiva"] = dsDefault.Db.GetDateTime(ViajeSelect5, 4) ;
            rowViaje["FechaLlegadaEfectiva"] = dsDefault.Db.GetDateTime(ViajeSelect5, 5) ;
            rowViaje["LugarPartida"] = dsDefault.Db.GetString(ViajeSelect5, 6) ;
            rowViaje["Lugarllegada"] = dsDefault.Db.GetString(ViajeSelect5, 7) ;
            rowViaje["LongitudPartida"] = dsDefault.Db.GetDecimal(ViajeSelect5, 8) ;
            rowViaje["LatitudPartida"] = dsDefault.Db.GetDecimal(ViajeSelect5, 9) ;
            rowViaje["LongitudLegada"] = dsDefault.Db.GetDecimal(ViajeSelect5, 10) ;
            rowViaje["LatitudLlegada"] = dsDefault.Db.GetDecimal(ViajeSelect5, 11) ;
            rowViaje["kmTotalesEstimado"] = dsDefault.Db.GetDecimal(ViajeSelect5, 12) ;
            rowViaje["MotocilcetaMarca"] = dsDefault.Db.GetString(ViajeSelect5, 13) ;
            rowViaje["MotociletaModelo"] = dsDefault.Db.GetString(ViajeSelect5, 14) ;
            rowViaje["UsuarioID"] = dsDefault.Db.GetInt32(ViajeSelect5, 15) ;
         }
      }

      private void ScanEndViaje( )
      {
         ViajeSelect5.Close();
      }

      private void AfterConfirmViaje( )
      {
         // After Confirm Rules
         OnViajeUpdating( new ViajeEventArgs( rowViaje, Gx_mode)) ;
      }

      private void CreateNewRowViaje( )
      {
         rowViaje = ViajeSet.Viaje.NewViajeRow() ;
      }

      private void LoadChildViaje( int startRow ,
                                   int maxRows )
      {
         CreateNewRowViaje( ) ;
         bool tmpConstraintState = ViajeSet.EnforceConstraints ;
         ViajeSet.Viaje.BeginLoadData( ) ;
         ScanStartViaje( startRow, maxRows) ;
         ViajeSet.Viaje.EndLoadData( ) ;
         this.ViajeSet.EnforceConstraints = tmpConstraintState ;
      }

      private void LoadDataViaje( int maxRows )
      {
         int loadedRows = 0 ;
         if ( ( RcdFound8 != 0 ) )
         {
            ScanLoadViaje( ) ;
            while ( ( RcdFound8 != 0 ) && ( loadedRows != maxRows ) )
            {
               loadedRows++ ;
               LoadRowViaje( ) ;
               CreateNewRowViaje( ) ;
               ScanNextViaje( ) ;
            }
         }
         if ( ( loadedRows > 0 ) )
         {
            RcdFound8 = 1 ;
         }
         ScanEndViaje( ) ;
         if ( ( ViajeSet.Viaje.Count > 0 ) )
         {
            rowViaje = ViajeSet.Viaje[ViajeSet.Viaje.Count -1] ;
         }
      }

      private void LoadByViajeID( int startRow ,
                                  int maxRows )
      {
         bool tmpConstraintState = ViajeSet.EnforceConstraints ;
         ViajeSet.Viaje.BeginLoadData( ) ;
         ScanByViajeID( startRow, maxRows) ;
         ViajeSet.Viaje.EndLoadData( ) ;
         this.ViajeSet.EnforceConstraints = tmpConstraintState ;
         if ( ( ViajeSet.Viaje.Count > 0 ) )
         {
            rowViaje = ViajeSet.Viaje[ViajeSet.Viaje.Count -1] ;
         }
      }

      private void LoadByUsuarioID( int startRow ,
                                    int maxRows )
      {
         bool tmpConstraintState = ViajeSet.EnforceConstraints ;
         ViajeSet.Viaje.BeginLoadData( ) ;
         ScanByUsuarioID( startRow, maxRows) ;
         ViajeSet.Viaje.EndLoadData( ) ;
         this.ViajeSet.EnforceConstraints = tmpConstraintState ;
         if ( ( ViajeSet.Viaje.Count > 0 ) )
         {
            rowViaje = ViajeSet.Viaje[ViajeSet.Viaje.Count -1] ;
         }
      }

      private void AddRowViaje( )
      {
         ViajeSet.Viaje.AddViajeRow( rowViaje) ;
      }

      private readonly string m_SelectString8 = "TM1.[ViajeID], TM1.[VaijeNombre], TM1.[FechaSalidaProgramada], TM1.[FechaLlegadaProgramada], TM1.[FechaSalidaEfectiva], TM1.[FechaLlegadaEfectiva], TM1.[LugarPartida], TM1.[Lugarllegada], TM1.[LongitudPartida], TM1.[LatitudPartida], TM1.[LongitudLegada], TM1.[LatitudLlegada], TM1.[kmTotalesEstimado], TM1.[MotocilcetaMarca], TM1.[MotociletaModelo], TM1.[UsuarioID]" ;


      public delegate  void ViajeUpdateEventHandler( object sender ,
                                                     ViajeEventArgs e );
      public event ViajeUpdateEventHandler ViajeUpdated ;
      private void OnViajeUpdated( ViajeEventArgs e )
      {
         if ( ( this.ViajeUpdated != null ) )
         {
            this.ViajeUpdated( this, e) ;
         }
      }

      public event ViajeUpdateEventHandler ViajeUpdating ;
      private void OnViajeUpdating( ViajeEventArgs e )
      {
         if ( ( this.ViajeUpdating != null ) )
         {
            this.ViajeUpdating( this, e) ;
         }
      }

      public class ViajeEventArgs : EventArgs
      {
         private System.Data.StatementType m_statementType ;
         private ViajeDataSet.ViajeRow m_dataRow ;
         public ViajeEventArgs( ViajeDataSet.ViajeRow row ,
                                StatementType statementType )
         {
            m_dataRow = row ;
            m_statementType = statementType ;
         }

         public System.Data.StatementType StatementType
         {
            get {
               return m_statementType ;
            }

         }

         public ViajeDataSet.ViajeRow Row
         {
            get {
               return m_dataRow ;
            }

            set {
               m_dataRow = value ;
            }

         }

      }


      // Custom Exceptions
      [Serializable()]
      public class ViajeNotFoundException : Deklarit.DataNotFoundException
      {
         public ViajeNotFoundException( )
         {
         }

         public ViajeNotFoundException( string message ) : base(message)
         {
         }

         public ViajeNotFoundException( string message ,
                                        Exception inner ) : base(message, inner)
         {
         }

         protected ViajeNotFoundException( SerializationInfo info ,
                                           StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class UsuarioForeignKeyNotFoundException : Deklarit.ForeignKeyNotFoundException
      {
         public UsuarioForeignKeyNotFoundException( )
         {
         }

         public UsuarioForeignKeyNotFoundException( string message ) : base(message)
         {
         }

         public UsuarioForeignKeyNotFoundException( string message ,
                                                    Exception inner ) : base(message, inner)
         {
         }

         protected UsuarioForeignKeyNotFoundException( SerializationInfo info ,
                                                       StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class ForeignKeyNotFoundException : Deklarit.ForeignKeyNotFoundException
      {
         public ForeignKeyNotFoundException( )
         {
         }

         public ForeignKeyNotFoundException( string message ) : base(message)
         {
         }

         public ForeignKeyNotFoundException( string message ,
                                             Exception inner ) : base(message, inner)
         {
         }

         protected ForeignKeyNotFoundException( SerializationInfo info ,
                                                StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class ViajeDataLockedException : Deklarit.DataLockedException
      {
         public ViajeDataLockedException( )
         {
         }

         public ViajeDataLockedException( string message ) : base(message)
         {
         }

         public ViajeDataLockedException( string message ,
                                          Exception inner ) : base(message, inner)
         {
         }

         protected ViajeDataLockedException( SerializationInfo info ,
                                             StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class ViajeDataChangedException : Deklarit.DataChangedException
      {
         public ViajeDataChangedException( )
         {
         }

         public ViajeDataChangedException( string message ) : base(message)
         {
         }

         public ViajeDataChangedException( string message ,
                                           Exception inner ) : base(message, inner)
         {
         }

         protected ViajeDataChangedException( SerializationInfo info ,
                                              StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class TrayectoViajeInvalidDeleteException : Deklarit.InvalidDeleteException
      {
         public TrayectoViajeInvalidDeleteException( )
         {
         }

         public TrayectoViajeInvalidDeleteException( string message ) : base(message)
         {
         }

         public TrayectoViajeInvalidDeleteException( string message ,
                                                     Exception inner ) : base(message, inner)
         {
         }

         protected TrayectoViajeInvalidDeleteException( SerializationInfo info ,
                                                        StreamingContext context ) : base(info, context)
         {
         }

      }


      protected void Cleanup( )
      {
         dsDefault.Dispose();
      }


      private void Initialize( )
      {
         resourceManager = Deklarit.Utils.ResourceManager.Instance ;
         resourceManagerTables = new System.Resources.ResourceManager( "Deklarit.Tables", System.Reflection.Assembly.GetExecutingAssembly()) ;
         RcdFound8 = 0 ;
         scmdbuf = "" ;
         recordCount = 0 ;
         _Gxremove = false ;
         m__VaijeNombreOriginal = new object();
         m__FechaSalidaProgramadaOriginal = new object();
         m__FechaLlegadaProgramadaOriginal = new object();
         m__FechaSalidaEfectivaOriginal = new object();
         m__FechaLlegadaEfectivaOriginal = new object();
         m__LugarPartidaOriginal = new object();
         m__LugarllegadaOriginal = new object();
         m__LongitudPartidaOriginal = new object();
         m__LatitudPartidaOriginal = new object();
         m__LongitudLegadaOriginal = new object();
         m__LatitudLlegadaOriginal = new object();
         m__kmTotalesEstimadoOriginal = new object();
         m__MotocilcetaMarcaOriginal = new object();
         m__MotociletaModeloOriginal = new object();
         m__UsuarioIDOriginal = new object();
         _Condition = false ;
         IsModified = 0 ;
         m_WhereString = "" ;
         if ( ( this.Transaction == null ) )
         {
            this.Transaction = ((System.Data.IDbTransaction)(System.Threading.Thread.GetData(System.Threading.Thread.GetNamedDataSlot(DeklaritTransaction.TransactionSlotName)) ));
         }
      }

      private short RcdFound8 ;
      private short IsModified ;
      private int recordCount ;
      private String scmdbuf ;
      private String m_WhereString ;
      private bool _Gxremove ;
      private bool _Condition ;
      private DataStore dsDefault ;
      private System.Resources.ResourceManager resourceManager ;
      private System.Resources.ResourceManager resourceManagerTables ;
      private ReadWriteConnection connDefault ;
      private ReadWriteCommand cmViajeSelect1 ;
      private IDataReader ViajeSelect1 ;
      private ReadWriteCommand cmViajeSelect2 ;
      private IDataReader ViajeSelect2 ;
      private ReadWriteCommand cmViajeSelect5 ;
      private IDataReader ViajeSelect5 ;
      private System.Data.StatementType Gx_mode ;
      private System.Data.StatementType sMode8 ;
      private object m__VaijeNombreOriginal ;
      private object m__FechaSalidaProgramadaOriginal ;
      private object m__FechaLlegadaProgramadaOriginal ;
      private object m__FechaSalidaEfectivaOriginal ;
      private object m__FechaLlegadaEfectivaOriginal ;
      private object m__LugarPartidaOriginal ;
      private object m__LugarllegadaOriginal ;
      private object m__LongitudPartidaOriginal ;
      private object m__LatitudPartidaOriginal ;
      private object m__LongitudLegadaOriginal ;
      private object m__LatitudLlegadaOriginal ;
      private object m__kmTotalesEstimadoOriginal ;
      private object m__MotocilcetaMarcaOriginal ;
      private object m__MotociletaModeloOriginal ;
      private object m__UsuarioIDOriginal ;
   }

   public class ViajeDataReader : System.IDisposable
   {
      public ViajeDataReader( )
      {
      }

      private void init_reader( )
      {
         this.Initialize( ) ;
         dsDefault = new DataStore( new SqlServer2005Handler( ), "System.Data.SqlClient", Raiderplan1.Configuration.ConnectionString, DeklaritTransaction.TransactionSlotName) ;
         m_Disposed = false ;
         m_Closed = true ;
      }

      private IDbTransaction daCurrentTransaction ;
      ///  <summary>
      ///   Gets or sets the Transaction object to be used  by  ViajeDataReaderDeklarit DataReaderclasses
      ///    to commit changes to the Database.
      ///  </summary>
      public IDbTransaction Transaction
      {
         get {
            return daCurrentTransaction ;
         }

         set {
            daCurrentTransaction = value ;
         }

      }

      public IDataReader Open( )
      {
         init_reader( ) ;
         m_Closed = false ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmViajeSelect6 = connDefault.GetCommand("SELECT TM1.[ViajeID], TM1.[VaijeNombre], TM1.[FechaSalidaProgramada], TM1.[FechaLlegadaProgramada], TM1.[FechaSalidaEfectiva], TM1.[FechaLlegadaEfectiva], TM1.[LugarPartida], TM1.[Lugarllegada], TM1.[LongitudPartida], TM1.[LatitudPartida], TM1.[LongitudLegada], TM1.[LatitudLlegada], TM1.[kmTotalesEstimado], TM1.[MotocilcetaMarca], TM1.[MotociletaModelo], TM1.[UsuarioID] FROM [Viaje] TM1 WITH (NOLOCK) ORDER BY TM1.[ViajeID] ", false) ;
         ViajeSelect6 = cmViajeSelect6.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return ViajeSelect6 ;
      }

      public IDataReader OpenByViajeID( long viajeID )
      {
         init_reader( ) ;
         m_Closed = false ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmViajeSelect6 = connDefault.GetCommand("SELECT TM1.[ViajeID], TM1.[VaijeNombre], TM1.[FechaSalidaProgramada], TM1.[FechaLlegadaProgramada], TM1.[FechaSalidaEfectiva], TM1.[FechaLlegadaEfectiva], TM1.[LugarPartida], TM1.[Lugarllegada], TM1.[LongitudPartida], TM1.[LatitudPartida], TM1.[LongitudLegada], TM1.[LatitudLlegada], TM1.[kmTotalesEstimado], TM1.[MotocilcetaMarca], TM1.[MotociletaModelo], TM1.[UsuarioID] FROM [Viaje] TM1 WITH (NOLOCK) WHERE TM1.[ViajeID] = @ViajeID ORDER BY TM1.[ViajeID] ", false) ;
         if ( ( cmViajeSelect6.IDbCommand.Parameters.Count == 0 ) )
         {
            cmViajeSelect6.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
         }
         cmViajeSelect6.SetParameter(0, viajeID);
         ViajeSelect6 = cmViajeSelect6.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return ViajeSelect6 ;
      }

      public IDataReader OpenByUsuarioID( int usuarioID )
      {
         init_reader( ) ;
         m_Closed = false ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmViajeSelect6 = connDefault.GetCommand("SELECT TM1.[ViajeID], TM1.[VaijeNombre], TM1.[FechaSalidaProgramada], TM1.[FechaLlegadaProgramada], TM1.[FechaSalidaEfectiva], TM1.[FechaLlegadaEfectiva], TM1.[LugarPartida], TM1.[Lugarllegada], TM1.[LongitudPartida], TM1.[LatitudPartida], TM1.[LongitudLegada], TM1.[LatitudLlegada], TM1.[kmTotalesEstimado], TM1.[MotocilcetaMarca], TM1.[MotociletaModelo], TM1.[UsuarioID] FROM [Viaje] TM1 WITH (NOLOCK) WHERE TM1.[UsuarioID] = @UsuarioID ORDER BY TM1.[ViajeID] ", false) ;
         if ( ( cmViajeSelect6.IDbCommand.Parameters.Count == 0 ) )
         {
            cmViajeSelect6.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioID", System.Data.DbType.Int32));
         }
         cmViajeSelect6.SetParameter(0, usuarioID);
         ViajeSelect6 = cmViajeSelect6.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return ViajeSelect6 ;
      }

      public int DeleteByUsuarioID( int usuarioID )
      {
         init_reader( ) ;
         int intCount = 0 ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmViajeDelete2 = connDefault.GetCommand("DELETE FROM [Viaje]  WHERE [UsuarioID] = @UsuarioID", false) ;
         if ( ( cmViajeDelete2.IDbCommand.Parameters.Count == 0 ) )
         {
            cmViajeDelete2.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioID", System.Data.DbType.Int32));
         }
         // Using cursor ViajeDelete2
         cmViajeDelete2.SetParameter(0, usuarioID);
         intCount = cmViajeDelete2.ExecuteStmt() ;
         return intCount ;
      }

      public void Dispose( )
      {
         if ( ! m_Disposed )
         {
            m_Disposed = true ;
            try
            {
               if ( ! m_Closed && ( ViajeSelect6 != null ) )
               {
                  m_Closed = true ;
                  ViajeSelect6.Close();
               }
            }
            finally
            {
               try
               {
                  connDefault.Close();
               }
               finally
               {
                  this.Cleanup();
               }
            }
         }
      }

      public void Close( )
      {
         this.Dispose( ) ;
      }


      protected void Cleanup( )
      {
         dsDefault.Dispose();
      }


      private void Initialize( )
      {
         m_Disposed = false ;
         m_Closed = false ;
         scmdbuf = "" ;
         if ( ( this.Transaction == null ) )
         {
            this.Transaction = ((System.Data.IDbTransaction)(System.Threading.Thread.GetData(System.Threading.Thread.GetNamedDataSlot(DeklaritTransaction.TransactionSlotName)) ));
         }
      }

      private String scmdbuf ;
      private bool m_Disposed ;
      private bool m_Closed ;
      private DataStore dsDefault ;
      private ReadWriteConnection connDefault ;
      private ReadWriteCommand cmViajeSelect6 ;
      private IDataReader ViajeSelect6 ;
      private ReadWriteCommand cmViajeDelete2 ;
   }

}
