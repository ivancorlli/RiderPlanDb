
//               File: TrayectoViajeDataAdapter
//        Description: TrayectoViaje
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
   public partial class TrayectoViajeDataAdapter : System.Data.IDataAdapter, ITrayectoViajeDataAdapter
   {
      private TrayectoViajeDataSet TrayectoViajeSet ;
      private IDbTransaction daCurrentTransaction ;
      private TrayectoViajeDataSet.TrayectoViajeRow rowTrayectoViaje ;
      public TrayectoViajeDataAdapter( )
      {
      }

      private void InitializeMembers( )
      {
         TrayectoViajeSet = new TrayectoViajeDataSet() ;
         this.Initialize( ) ;
         dsDefault = new DataStore( new SqlServer2005Handler( ), "System.Data.SqlClient", Raiderplan1.Configuration.ConnectionString, DeklaritTransaction.TransactionSlotName) ;
      }

      ///  <summary>
      ///   Gets or sets the Transaction object to be used  by  TrayectoViajeDataAdapterclasses
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
      ///   (2) Fills the specified Dataset with the record matching TrayectoViajeID field(s)
      ///    of the given IDataRecord
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="dataRecord">Data Record</param>
      public virtual int Fill( TrayectoViajeDataSet dataSet ,
                               IDataRecord dataRecord )
      {
         return Fill(dataSet, ((int)(dataRecord["TrayectoViajeID"]))) ;
      }

      ///  <summary>
      ///   (3) Fills the specified Dataset with the record matching TrayectoViajeID field(s)
      ///    of the given DataRow
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="dataRecord">Data Row</param>
      public virtual int Fill( TrayectoViajeDataSet dataSet ,
                               DataRow dataRecord )
      {
         return Fill(dataSet, ((int)(dataRecord["TrayectoViajeID"]))) ;
      }

      ///  <summary>
      ///   (4) Fills the specified Dataset with the record matching TrayectoViajeID, if the
      ///    record is not found , throws an exception.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="trayectoViajeID">Trayecto Viaje ID</param>
      public virtual int Fill( TrayectoViajeDataSet dataSet ,
                               int trayectoViajeID )
      {
         if ( ! FillByTrayectoViajeID( dataSet, trayectoViajeID) )
         {
            throw new TrayectoViajeNotFoundException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("inex"), new   object[]  {resourceManagerTables.GetString("TrayectoViaje")})) ;
         }
         return 0 ;
      }


      ///  <summary>
      ///   (5) Fills the specified Dataset with the record matching TrayectoViajeID in the fillDataParameters
      ///    array, if the array is null, it fills the Dataset loading all records in the table.
      ///
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Fill( TrayectoViajeDataSet dataSet )
      {
         if ( ( fillDataParameters != null ) )
         {
            Fill( dataSet, System.Int32.Parse( fillDataParameters[0].Value.ToString())) ;
         }
         else
         {
            try
            {
               InitializeMembers( ) ;
               connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
               TrayectoViajeSet = dataSet ;
               LoadChildTrayectoviaje( 0, -1) ;
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
      ///   (6) Fills the specified dataset filtered by TrayectoViajeIDfield(s).
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="trayectoViajeID">Trayecto Viaje ID</param>
      public virtual bool FillByTrayectoViajeID( TrayectoViajeDataSet dataSet ,
                                                 int trayectoViajeID )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         TrayectoViajeSet = dataSet ;
         rowTrayectoViaje = TrayectoViajeSet.TrayectoViaje.NewTrayectoViajeRow() ;
         rowTrayectoViaje.TrayectoViajeID = trayectoViajeID ;
         try
         {
            LoadByTrayectoViajeID( 0, -1) ;
            dataSet.AcceptChanges( ) ;
         }
         finally
         {
            this.Cleanup();
         }
         if ( ( RcdFound10 == 0 ) )
         {
            return false ;
         }
         return true ;
      }


      ///  <summary>
      ///   (6) Fills the specified dataset filtered by ViajeIDfield(s).
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="viajeID">Viaje ID</param>
      public virtual int FillByViajeID( TrayectoViajeDataSet dataSet ,
                                        long viajeID )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         TrayectoViajeSet = dataSet ;
         rowTrayectoViaje = TrayectoViajeSet.TrayectoViaje.NewTrayectoViajeRow() ;
         rowTrayectoViaje.ViajeID = viajeID ;
         try
         {
            LoadByViajeID( 0, -1) ;
            dataSet.AcceptChanges( ) ;
         }
         finally
         {
            this.Cleanup();
         }
         return 0 ;
      }


      ///  <summary>
      ///   (6) Fills a page of up to maxRows rows into the specified dataset filtered by ViajeIDfield(s)starting
      ///    at startRow
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="viajeID">Viaje ID</param>
      ///  <param name="startRow">Starting row</param>
      ///  <param name="maxRows">Max number of rows to load</param>
      public virtual int FillPageByViajeID( TrayectoViajeDataSet dataSet ,
                                            long viajeID ,
                                            int startRow ,
                                            int maxRows )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         TrayectoViajeSet = dataSet ;
         rowTrayectoViaje = TrayectoViajeSet.TrayectoViaje.NewTrayectoViajeRow() ;
         rowTrayectoViaje.ViajeID = viajeID ;
         try
         {
            LoadByViajeID( startRow, maxRows) ;
            dataSet.AcceptChanges( ) ;
         }
         finally
         {
            this.Cleanup();
         }
         return 0 ;
      }


      ///  <summary>
      ///   (9) Gets the record count filtered by ViajeIDfield(s).
      ///  </summary>
      ///  <param name="viajeID">Viaje ID</param>
      public virtual int GetRecordCountByViajeID( long viajeID )
      {
         int m_Count ;
         try
         {
            InitializeMembers( ) ;
            m_Count = GetInternalRecordCountByViajeID( viajeID ) ;
         }
         finally
         {
            this.Cleanup();
         }
         return m_Count ;
      }

      private int GetInternalRecordCountByViajeID( long viajeID )
      {
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmTrayectoViajeSelect1 = connDefault.GetCommand("SELECT COUNT(*) FROM [TrayectoViaje] WITH (NOLOCK) WHERE [ViajeID] = @ViajeID ", false) ;
         if ( ( cmTrayectoViajeSelect1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmTrayectoViajeSelect1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
         }
         cmTrayectoViajeSelect1.SetParameter(0, viajeID);
         TrayectoViajeSelect1 = cmTrayectoViajeSelect1.FetchData() ;
         recordCount = ( ( TrayectoViajeSelect1.IsDBNull(0) )  ? (int)(0) : TrayectoViajeSelect1.GetInt32(0) ) ;
         TrayectoViajeSelect1.Close();
         return recordCount ;
      }

      ///  <summary>
      ///   (8) Fills the specified dataset with the record matching TrayectoViajeID in the the
      ///    fillDataParameters array, if the array is null, it fills the Dataset loading all
      ///    records in the table.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Fill( DataSet dataSet )
      {
         TrayectoViajeSet = dataSet as TrayectoViajeDataSet ;
         if ( ( TrayectoViajeSet != null ) )
         {
            return Fill( TrayectoViajeSet) ;
         }
         else
         {
            TrayectoViajeSet = new TrayectoViajeDataSet() ;
            Fill( TrayectoViajeSet) ;
            dataSet.Merge( TrayectoViajeSet) ;
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
      public virtual int FillPage( TrayectoViajeDataSet dataSet ,
                                   int startRow ,
                                   int maxRows )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         TrayectoViajeSet = dataSet ;
         try
         {
            LoadChildTrayectoviaje( startRow, maxRows) ;
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
         cmTrayectoViajeSelect2 = connDefault.GetCommand("SELECT COUNT(*) FROM [TrayectoViaje] WITH (NOLOCK) ", false) ;
         TrayectoViajeSelect2 = cmTrayectoViajeSelect2.FetchData() ;
         recordCount = ( ( TrayectoViajeSelect2.IsDBNull(0) )  ? (int)(0) : TrayectoViajeSelect2.GetInt32(0) ) ;
         TrayectoViajeSelect2.Close();
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
            DbParameter parm0TrayectoViajeID ;
            parm0TrayectoViajeID = factory.CreateParameter() ;
            parm0TrayectoViajeID.ParameterName = "TrayectoViajeID" ;
            parm0TrayectoViajeID.DbType = System.Data.DbType.Int32 ;
            fillDataParameters = new  DbParameter[]  {parm0TrayectoViajeID} ;
         }
         return fillDataParameters ;
      }

      private DbParameter[] fillDataParameters ;

      ///  <summary>
      ///   Inserts, Updates or Deletes records from the specified TrayectoViajeDataSet object.
      ///
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Update( DataSet dataSet )
      {
         InitializeMembers( ) ;
         TrayectoViajeSet = dataSet as TrayectoViajeDataSet ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         if ( ( TrayectoViajeSet != null ) )
         {
            try
            {
               connDefault.BeginTransaction();
               foreach( TrayectoViajeDataSet.TrayectoViajeRow row in TrayectoViajeSet.TrayectoViaje )
               {
                  rowTrayectoViaje = row ;
                  if ( Deklarit.Data.Helpers.IsRowChanged(rowTrayectoViaje) )
                  {
                     ReadRowTrayectoviaje( ) ;
                     if ( ( rowTrayectoViaje.RowState == System.Data.DataRowState.Added ) )
                     {
                        InsertTrayectoviaje( ) ;
                     }
                     else
                     {
                        if ( _Gxremove )
                        {
                           Delete( ) ;
                        }
                        else
                        {
                           UpdateTrayectoviaje( ) ;
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

      private void LoadRowTrayectoviaje( )
      {
         AddRowTrayectoviaje( ) ;
      }

      private void ReadRowTrayectoviaje( )
      {
         Gx_mode = Deklarit.Utils.Mode.FromRowState(rowTrayectoViaje.RowState) ;
         if ( ( rowTrayectoViaje.RowState != System.Data.DataRowState.Added ) )
         {
            m__TrayectoOrigenOriginal = rowTrayectoViaje["TrayectoOrigen", System.Data.DataRowVersion.Original] ;
            m__TrayectoDestinoOriginal = rowTrayectoViaje["TrayectoDestino", System.Data.DataRowVersion.Original] ;
            m__TayectoLatitudOrigenOriginal = rowTrayectoViaje["TayectoLatitudOrigen", System.Data.DataRowVersion.Original] ;
            m__TrayectoLongitudOrigenOriginal = rowTrayectoViaje["TrayectoLongitudOrigen", System.Data.DataRowVersion.Original] ;
            m__TrayectoLatidudDestinoOriginal = rowTrayectoViaje["TrayectoLatidudDestino", System.Data.DataRowVersion.Original] ;
            m__TrayectoLongitudDestinoOriginal = rowTrayectoViaje["TrayectoLongitudDestino", System.Data.DataRowVersion.Original] ;
            m__TrayectokmOriginal = rowTrayectoViaje["Trayectokm", System.Data.DataRowVersion.Original] ;
            m__TiempoEstimadoOriginal = rowTrayectoViaje["TiempoEstimado", System.Data.DataRowVersion.Original] ;
            m__CombustibleConsumidoOriginal = rowTrayectoViaje["CombustibleConsumido", System.Data.DataRowVersion.Original] ;
            m__EstadoCarreteraOriginal = rowTrayectoViaje["EstadoCarretera", System.Data.DataRowVersion.Original] ;
            m__InstruccionesOriginal = rowTrayectoViaje["Instrucciones", System.Data.DataRowVersion.Original] ;
            m__OrdenOriginal = rowTrayectoViaje["Orden", System.Data.DataRowVersion.Original] ;
            m__ViajeIDOriginal = rowTrayectoViaje["ViajeID", System.Data.DataRowVersion.Original] ;
         }
         else
         {
            m__TrayectoOrigenOriginal = rowTrayectoViaje["TrayectoOrigen"] ;
            m__TrayectoDestinoOriginal = rowTrayectoViaje["TrayectoDestino"] ;
            m__TayectoLatitudOrigenOriginal = rowTrayectoViaje["TayectoLatitudOrigen"] ;
            m__TrayectoLongitudOrigenOriginal = rowTrayectoViaje["TrayectoLongitudOrigen"] ;
            m__TrayectoLatidudDestinoOriginal = rowTrayectoViaje["TrayectoLatidudDestino"] ;
            m__TrayectoLongitudDestinoOriginal = rowTrayectoViaje["TrayectoLongitudDestino"] ;
            m__TrayectokmOriginal = rowTrayectoViaje["Trayectokm"] ;
            m__TiempoEstimadoOriginal = rowTrayectoViaje["TiempoEstimado"] ;
            m__CombustibleConsumidoOriginal = rowTrayectoViaje["CombustibleConsumido"] ;
            m__EstadoCarreteraOriginal = rowTrayectoViaje["EstadoCarretera"] ;
            m__InstruccionesOriginal = rowTrayectoViaje["Instrucciones"] ;
            m__OrdenOriginal = rowTrayectoViaje["Orden"] ;
            m__ViajeIDOriginal = rowTrayectoViaje["ViajeID"] ;
         }
         _Gxremove = (bool)((rowTrayectoViaje.RowState==System.Data.DataRowState.Deleted)) ;
         if ( _Gxremove )
         {
            rowTrayectoViaje = ((TrayectoViajeDataSet.TrayectoViajeRow)(Deklarit.Utils.DataSetUtil.CloneOriginalDataRow(rowTrayectoViaje)));
         }
      }

      private void CheckIntegrityErrorsTrayectoviaje( )
      {
          IDataReader ViajeSelect1 ;
          ReadWriteCommand cmViajeSelect1 ;
         cmViajeSelect1 = connDefault.GetCommand("SELECT [ViajeID] FROM [Viaje] WITH (NOLOCK) WHERE [ViajeID] = @ViajeID ", false) ;
         if ( ( cmViajeSelect1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmViajeSelect1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
         }
         cmViajeSelect1.SetParameter(0, rowTrayectoViaje["ViajeID"]);
         ViajeSelect1 = cmViajeSelect1.FetchData() ;
         if ( !cmViajeSelect1.HasMoreRows )
         {
            ViajeSelect1.Close();
            throw new ViajeForeignKeyNotFoundException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("inex"), new   object[]  {resourceManagerTables.GetString("Viaje")})) ;
         }
         ViajeSelect1.Close();
         throw new ForeignKeyNotFoundException( resourceManager.GetString("refinterror")) ;
      }

      private void GetByPrimaryKey( )
      {
          IDataReader TrayectoViajeSelect3 ;
          ReadWriteCommand cmTrayectoViajeSelect3 ;
         cmTrayectoViajeSelect3 = connDefault.GetCommand("SELECT [TrayectoViajeID], [TrayectoOrigen], [TrayectoDestino], [TayectoLatitudOrigen], [TrayectoLongitudOrigen], [TrayectoLatidudDestino], [TrayectoLongitudDestino], [Trayectokm], [TiempoEstimado], [CombustibleConsumido], [EstadoCarretera], [Instrucciones], [Orden], [ViajeID] FROM [TrayectoViaje] WITH (NOLOCK) WHERE [TrayectoViajeID] = @TrayectoViajeID ", false) ;
         if ( ( cmTrayectoViajeSelect3.IDbCommand.Parameters.Count == 0 ) )
         {
            cmTrayectoViajeSelect3.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoViajeID", System.Data.DbType.Int32));
         }
         cmTrayectoViajeSelect3.SetParameter(0, rowTrayectoViaje["TrayectoViajeID"]);
         TrayectoViajeSelect3 = cmTrayectoViajeSelect3.FetchData() ;
         if ( cmTrayectoViajeSelect3.HasMoreRows )
         {
            RcdFound10 = 1 ;
            rowTrayectoViaje["TrayectoViajeID"] = dsDefault.Db.GetInt32(TrayectoViajeSelect3, 0) ;
            rowTrayectoViaje["TrayectoOrigen"] = dsDefault.Db.GetString(TrayectoViajeSelect3, 1) ;
            rowTrayectoViaje["TrayectoDestino"] = dsDefault.Db.GetString(TrayectoViajeSelect3, 2) ;
            rowTrayectoViaje["TayectoLatitudOrigen"] = dsDefault.Db.GetDecimal(TrayectoViajeSelect3, 3) ;
            rowTrayectoViaje["TrayectoLongitudOrigen"] = dsDefault.Db.GetDecimal(TrayectoViajeSelect3, 4) ;
            rowTrayectoViaje["TrayectoLatidudDestino"] = dsDefault.Db.GetDecimal(TrayectoViajeSelect3, 5) ;
            rowTrayectoViaje["TrayectoLongitudDestino"] = dsDefault.Db.GetDecimal(TrayectoViajeSelect3, 6) ;
            rowTrayectoViaje["Trayectokm"] = dsDefault.Db.GetDecimal(TrayectoViajeSelect3, 7) ;
            rowTrayectoViaje["TiempoEstimado"] = dsDefault.Db.GetDecimal(TrayectoViajeSelect3, 8) ;
            rowTrayectoViaje["CombustibleConsumido"] = dsDefault.Db.GetDecimal(TrayectoViajeSelect3, 9) ;
            rowTrayectoViaje["EstadoCarretera"] = dsDefault.Db.GetString(TrayectoViajeSelect3, 10) ;
            rowTrayectoViaje["Instrucciones"] = dsDefault.Db.GetString(TrayectoViajeSelect3, 11) ;
            rowTrayectoViaje["Orden"] = dsDefault.Db.GetInt32(TrayectoViajeSelect3, 12) ;
            rowTrayectoViaje["ViajeID"] = dsDefault.Db.GetInt64(TrayectoViajeSelect3, 13) ;
            sMode10 = Gx_mode ;
            Gx_mode = Mode.Display ;
            Gx_mode = sMode10 ;
         }
         else
         {
            RcdFound10 = 0 ;
         }
         TrayectoViajeSelect3.Close();
      }

      private void CheckOptimisticConcurrencyTrayectoviaje( )
      {
          IDataReader TrayectoViajeSelect4 ;
          ReadWriteCommand cmTrayectoViajeSelect4 ;
         if ( ( Gx_mode != Mode.Insert ) )
         {
            cmTrayectoViajeSelect4 = connDefault.GetCommand("SELECT [TrayectoViajeID], [TrayectoOrigen], [TrayectoDestino], [TayectoLatitudOrigen], [TrayectoLongitudOrigen], [TrayectoLatidudDestino], [TrayectoLongitudDestino], [Trayectokm], [TiempoEstimado], [CombustibleConsumido], [EstadoCarretera], [Instrucciones], [Orden], [ViajeID] FROM [TrayectoViaje] WITH (UPDLOCK) WHERE [TrayectoViajeID] = @TrayectoViajeID ", false) ;
            if ( ( cmTrayectoViajeSelect4.IDbCommand.Parameters.Count == 0 ) )
            {
               cmTrayectoViajeSelect4.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoViajeID", System.Data.DbType.Int32));
            }
            cmTrayectoViajeSelect4.SetParameter(0, rowTrayectoViaje["TrayectoViajeID"]);
            TrayectoViajeSelect4 = cmTrayectoViajeSelect4.FetchData() ;
            if ( cmTrayectoViajeSelect4.Locked )
            {
               TrayectoViajeSelect4.Close();
               throw new TrayectoViajeDataLockedException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("lock"), new   object[]  {resourceManagerTables.GetString("TrayectoViaje")})) ;
            }
            _Condition = false ;
            if ( !cmTrayectoViajeSelect4.HasMoreRows || ( ! StringUtil.ObjectStringEquals(m__TrayectoOrigenOriginal,dsDefault.Db.GetString(TrayectoViajeSelect4, 1)) ) || ( ! StringUtil.ObjectStringEquals(m__TrayectoDestinoOriginal,dsDefault.Db.GetString(TrayectoViajeSelect4, 2)) ) || ( ! m__TayectoLatitudOrigenOriginal.Equals(dsDefault.Db.GetDecimal(TrayectoViajeSelect4, 3)) ) || ( ! m__TrayectoLongitudOrigenOriginal.Equals(dsDefault.Db.GetDecimal(TrayectoViajeSelect4, 4)) ) || ( ! m__TrayectoLatidudDestinoOriginal.Equals(dsDefault.Db.GetDecimal(TrayectoViajeSelect4, 5)) ) )
            {
               _Condition = true ;
            }
            if ( _Condition || ( ! m__TrayectoLongitudDestinoOriginal.Equals(dsDefault.Db.GetDecimal(TrayectoViajeSelect4, 6)) ) || ( ! m__TrayectokmOriginal.Equals(dsDefault.Db.GetDecimal(TrayectoViajeSelect4, 7)) ) || ( ! m__TiempoEstimadoOriginal.Equals(dsDefault.Db.GetDecimal(TrayectoViajeSelect4, 8)) ) || ( ! m__CombustibleConsumidoOriginal.Equals(dsDefault.Db.GetDecimal(TrayectoViajeSelect4, 9)) ) || ( ! StringUtil.ObjectStringEquals(m__EstadoCarreteraOriginal,dsDefault.Db.GetString(TrayectoViajeSelect4, 10)) ) )
            {
               _Condition = true ;
            }
            if ( _Condition || ( ! StringUtil.ObjectStringEquals(m__InstruccionesOriginal,dsDefault.Db.GetString(TrayectoViajeSelect4, 11)) ) || ( ! m__OrdenOriginal.Equals(dsDefault.Db.GetInt32(TrayectoViajeSelect4, 12)) ) || ( ! m__ViajeIDOriginal.Equals(dsDefault.Db.GetInt64(TrayectoViajeSelect4, 13)) ) )
            {
               TrayectoViajeSelect4.Close();
               throw new TrayectoViajeDataChangedException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("waschg"), new   object[]  {resourceManagerTables.GetString("TrayectoViaje")})) ;
            }
            TrayectoViajeSelect4.Close();
         }
      }

      private void InsertTrayectoviaje( )
      {
          IDataReader TrayectoViajeInsert1 ;
          ReadWriteCommand cmTrayectoViajeInsert1 ;
         CheckOptimisticConcurrencyTrayectoviaje( ) ;
         AfterConfirmTrayectoviaje( ) ;
         cmTrayectoViajeInsert1 = connDefault.GetCommand("INSERT INTO [TrayectoViaje] ([TrayectoOrigen], [TrayectoDestino], [TayectoLatitudOrigen], [TrayectoLongitudOrigen], [TrayectoLatidudDestino], [TrayectoLongitudDestino], [Trayectokm], [TiempoEstimado], [CombustibleConsumido], [EstadoCarretera], [Instrucciones], [Orden], [ViajeID]) VALUES (@TrayectoOrigen, @TrayectoDestino, @TayectoLatitudOrigen, @TrayectoLongitudOrigen, @TrayectoLatidudDestino, @TrayectoLongitudDestino, @Trayectokm, @TiempoEstimado, @CombustibleConsumido, @EstadoCarretera, @Instrucciones, @Orden, @ViajeID); SELECT SCOPE_IDENTITY()", false) ;
         if ( ( cmTrayectoViajeInsert1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmTrayectoViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoOrigen", System.Data.DbType.AnsiString,150));
            cmTrayectoViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoDestino", System.Data.DbType.AnsiString,50));
            cmTrayectoViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TayectoLatitudOrigen", System.Data.DbType.Decimal));
            cmTrayectoViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoLongitudOrigen", System.Data.DbType.Decimal));
            cmTrayectoViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoLatidudDestino", System.Data.DbType.Decimal));
            cmTrayectoViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoLongitudDestino", System.Data.DbType.Decimal));
            cmTrayectoViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@Trayectokm", System.Data.DbType.Currency));
            cmTrayectoViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TiempoEstimado", System.Data.DbType.Currency));
            cmTrayectoViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@CombustibleConsumido", System.Data.DbType.Currency));
            cmTrayectoViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@EstadoCarretera", System.Data.DbType.AnsiString,100));
            cmTrayectoViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@Instrucciones", System.Data.DbType.AnsiString));
            cmTrayectoViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@Orden", System.Data.DbType.Int32));
            cmTrayectoViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
         }
         cmTrayectoViajeInsert1.ErrorMask = cmTrayectoViajeInsert1.ErrorMask  |  ErrorMask.ForeignKeyError;
         cmTrayectoViajeInsert1.ErrorMask = cmTrayectoViajeInsert1.ErrorMask  |  ErrorMask.DuplicateKeyError;
         cmTrayectoViajeInsert1.SetParameter(0, rowTrayectoViaje["TrayectoOrigen"]);
         cmTrayectoViajeInsert1.SetParameter(1, rowTrayectoViaje["TrayectoDestino"]);
         cmTrayectoViajeInsert1.SetParameter(2, rowTrayectoViaje["TayectoLatitudOrigen"]);
         cmTrayectoViajeInsert1.SetParameter(3, rowTrayectoViaje["TrayectoLongitudOrigen"]);
         cmTrayectoViajeInsert1.SetParameter(4, rowTrayectoViaje["TrayectoLatidudDestino"]);
         cmTrayectoViajeInsert1.SetParameter(5, rowTrayectoViaje["TrayectoLongitudDestino"]);
         cmTrayectoViajeInsert1.SetParameter(6, rowTrayectoViaje["Trayectokm"]);
         cmTrayectoViajeInsert1.SetParameter(7, rowTrayectoViaje["TiempoEstimado"]);
         cmTrayectoViajeInsert1.SetParameter(8, rowTrayectoViaje["CombustibleConsumido"]);
         cmTrayectoViajeInsert1.SetParameter(9, rowTrayectoViaje["EstadoCarretera"]);
         cmTrayectoViajeInsert1.SetParameter(10, rowTrayectoViaje["Instrucciones"]);
         cmTrayectoViajeInsert1.SetParameter(11, rowTrayectoViaje["Orden"]);
         cmTrayectoViajeInsert1.SetParameter(12, rowTrayectoViaje["ViajeID"]);
         TrayectoViajeInsert1 = cmTrayectoViajeInsert1.FetchData() ;
         if ( ! ( cmTrayectoViajeInsert1.ForeignKeyError || cmTrayectoViajeInsert1.DupKey ) )
         {
            rowTrayectoViaje.TrayectoViajeID = (int)(TrayectoViajeInsert1.GetDecimal(0)) ;
            TrayectoViajeInsert1.Close();
         }
         if ( cmTrayectoViajeInsert1.ForeignKeyError )
         {
            CheckIntegrityErrorsTrayectoviaje( ) ;
         }
         // Start of After( Insert) rules
         // End of After( Insert) rules
         OnTrayectoViajeUpdated( new TrayectoViajeEventArgs( rowTrayectoViaje, Mode.Insert)) ;
         // Save values for previous() function.
         EndLevelTrayectoviaje( ) ;
      }

      private void UpdateTrayectoviaje( )
      {
          ReadWriteCommand cmTrayectoViajeUpdate1 ;
         CheckOptimisticConcurrencyTrayectoviaje( ) ;
         AfterConfirmTrayectoviaje( ) ;
         cmTrayectoViajeUpdate1 = connDefault.GetCommand("UPDATE [TrayectoViaje] SET [TrayectoOrigen]=@TrayectoOrigen, [TrayectoDestino]=@TrayectoDestino, [TayectoLatitudOrigen]=@TayectoLatitudOrigen, [TrayectoLongitudOrigen]=@TrayectoLongitudOrigen, [TrayectoLatidudDestino]=@TrayectoLatidudDestino, [TrayectoLongitudDestino]=@TrayectoLongitudDestino, [Trayectokm]=@Trayectokm, [TiempoEstimado]=@TiempoEstimado, [CombustibleConsumido]=@CombustibleConsumido, [EstadoCarretera]=@EstadoCarretera, [Instrucciones]=@Instrucciones, [Orden]=@Orden, [ViajeID]=@ViajeID  WHERE [TrayectoViajeID] = @TrayectoViajeID", false) ;
         if ( ( cmTrayectoViajeUpdate1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmTrayectoViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoOrigen", System.Data.DbType.AnsiString,150));
            cmTrayectoViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoDestino", System.Data.DbType.AnsiString,50));
            cmTrayectoViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TayectoLatitudOrigen", System.Data.DbType.Decimal));
            cmTrayectoViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoLongitudOrigen", System.Data.DbType.Decimal));
            cmTrayectoViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoLatidudDestino", System.Data.DbType.Decimal));
            cmTrayectoViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoLongitudDestino", System.Data.DbType.Decimal));
            cmTrayectoViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@Trayectokm", System.Data.DbType.Currency));
            cmTrayectoViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TiempoEstimado", System.Data.DbType.Currency));
            cmTrayectoViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@CombustibleConsumido", System.Data.DbType.Currency));
            cmTrayectoViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@EstadoCarretera", System.Data.DbType.AnsiString,100));
            cmTrayectoViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@Instrucciones", System.Data.DbType.AnsiString));
            cmTrayectoViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@Orden", System.Data.DbType.Int32));
            cmTrayectoViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
            cmTrayectoViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoViajeID", System.Data.DbType.Int32));
         }
         cmTrayectoViajeUpdate1.ErrorMask = cmTrayectoViajeUpdate1.ErrorMask  |  ErrorMask.ForeignKeyError;
         // Using cursor TrayectoViajeUpdate1
         cmTrayectoViajeUpdate1.SetParameter(0, rowTrayectoViaje["TrayectoOrigen"]);
         cmTrayectoViajeUpdate1.SetParameter(1, rowTrayectoViaje["TrayectoDestino"]);
         cmTrayectoViajeUpdate1.SetParameter(2, rowTrayectoViaje["TayectoLatitudOrigen"]);
         cmTrayectoViajeUpdate1.SetParameter(3, rowTrayectoViaje["TrayectoLongitudOrigen"]);
         cmTrayectoViajeUpdate1.SetParameter(4, rowTrayectoViaje["TrayectoLatidudDestino"]);
         cmTrayectoViajeUpdate1.SetParameter(5, rowTrayectoViaje["TrayectoLongitudDestino"]);
         cmTrayectoViajeUpdate1.SetParameter(6, rowTrayectoViaje["Trayectokm"]);
         cmTrayectoViajeUpdate1.SetParameter(7, rowTrayectoViaje["TiempoEstimado"]);
         cmTrayectoViajeUpdate1.SetParameter(8, rowTrayectoViaje["CombustibleConsumido"]);
         cmTrayectoViajeUpdate1.SetParameter(9, rowTrayectoViaje["EstadoCarretera"]);
         cmTrayectoViajeUpdate1.SetParameter(10, rowTrayectoViaje["Instrucciones"]);
         cmTrayectoViajeUpdate1.SetParameter(11, rowTrayectoViaje["Orden"]);
         cmTrayectoViajeUpdate1.SetParameter(12, rowTrayectoViaje["ViajeID"]);
         cmTrayectoViajeUpdate1.SetParameter(13, rowTrayectoViaje["TrayectoViajeID"]);
         cmTrayectoViajeUpdate1.ExecuteStmt();
         if ( cmTrayectoViajeUpdate1.ForeignKeyError )
         {
            CheckIntegrityErrorsTrayectoviaje( ) ;
         }
         // Start of After( update) rules
         // End of After( update) rules
         OnTrayectoViajeUpdated( new TrayectoViajeEventArgs( rowTrayectoViaje, Mode.Update)) ;
         EndLevelTrayectoviaje( ) ;
      }

      private void Delete( )
      {
          ReadWriteCommand cmTrayectoViajeDelete1 ;
         Gx_mode = Mode.Delete ;
         CheckOptimisticConcurrencyTrayectoviaje( ) ;
         // No cascading delete specified.
         AfterConfirmTrayectoviaje( ) ;
         cmTrayectoViajeDelete1 = connDefault.GetCommand("DELETE FROM [TrayectoViaje]  WHERE [TrayectoViajeID] = @TrayectoViajeID", false) ;
         if ( ( cmTrayectoViajeDelete1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmTrayectoViajeDelete1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoViajeID", System.Data.DbType.Int32));
         }
         cmTrayectoViajeDelete1.ErrorMask = cmTrayectoViajeDelete1.ErrorMask  |  ErrorMask.ForeignKeyError;
         // Using cursor TrayectoViajeDelete1
         cmTrayectoViajeDelete1.SetParameter(0, rowTrayectoViaje["TrayectoViajeID"]);
         cmTrayectoViajeDelete1.ExecuteStmt();
         // Start of After( delete) rules
         // End of After( delete) rules
         OnTrayectoViajeUpdated( new TrayectoViajeEventArgs( rowTrayectoViaje, Mode.Delete)) ;
         rowTrayectoViaje.Delete( ) ;
         sMode10 = Gx_mode ;
         Gx_mode = Mode.Delete ;
         EndLevelTrayectoviaje( ) ;
         Gx_mode = sMode10 ;
      }

      private void EndLevelTrayectoviaje( )
      {
         // Execute 'After Trn' event if defined.
         IsModified = 0 ;
      }

      private void ScanByTrayectoViajeID( int startRow ,
                                          int maxRows )
      {
         m_WhereString = " WHERE TM1.[TrayectoViajeID] = @TrayectoViajeID" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString10 + "  FROM [TrayectoViaje] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[TrayectoViajeID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString10 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[TrayectoViajeID] ) AS DK_PAGENUM   FROM [TrayectoViaje] TM1 WITH (NOLOCK) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString10 + " FROM [TrayectoViaje] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[TrayectoViajeID] " ;
         }
         cmTrayectoViajeSelect5 = connDefault.GetCommand(scmdbuf, false) ;
         if ( ( cmTrayectoViajeSelect5.IDbCommand.Parameters.Count == 0 ) )
         {
            cmTrayectoViajeSelect5.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoViajeID", System.Data.DbType.Int32));
         }
         cmTrayectoViajeSelect5.SetParameter(0, rowTrayectoViaje["TrayectoViajeID"]);
         TrayectoViajeSelect5 = cmTrayectoViajeSelect5.FetchData() ;
         RcdFound10 = 0 ;
         ScanLoadTrayectoviaje( ) ;
         LoadDataTrayectoviaje( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanByViajeID( int startRow ,
                                  int maxRows )
      {
         m_WhereString = " WHERE TM1.[ViajeID] = @ViajeID" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString10 + "  FROM [TrayectoViaje] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[TrayectoViajeID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString10 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[TrayectoViajeID] ) AS DK_PAGENUM   FROM [TrayectoViaje] TM1 WITH (NOLOCK) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString10 + " FROM [TrayectoViaje] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[TrayectoViajeID] " ;
         }
         cmTrayectoViajeSelect5 = connDefault.GetCommand(scmdbuf, false) ;
         if ( ( cmTrayectoViajeSelect5.IDbCommand.Parameters.Count == 0 ) )
         {
            cmTrayectoViajeSelect5.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
         }
         cmTrayectoViajeSelect5.SetParameter(0, rowTrayectoViaje["ViajeID"]);
         TrayectoViajeSelect5 = cmTrayectoViajeSelect5.FetchData() ;
         RcdFound10 = 0 ;
         ScanLoadTrayectoviaje( ) ;
         LoadDataTrayectoviaje( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanStartTrayectoviaje( int startRow ,
                                           int maxRows )
      {
         m_WhereString = "" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString10 + "  FROM [TrayectoViaje] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[TrayectoViajeID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString10 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[TrayectoViajeID] ) AS DK_PAGENUM   FROM [TrayectoViaje] TM1 WITH (NOLOCK) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString10 + " FROM [TrayectoViaje] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[TrayectoViajeID] " ;
         }
         cmTrayectoViajeSelect5 = connDefault.GetCommand(scmdbuf, false) ;
         TrayectoViajeSelect5 = cmTrayectoViajeSelect5.FetchData() ;
         RcdFound10 = 0 ;
         ScanLoadTrayectoviaje( ) ;
         LoadDataTrayectoviaje( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanNextTrayectoviaje( )
      {
         cmTrayectoViajeSelect5.HasMoreRows = TrayectoViajeSelect5.Read() ;
         RcdFound10 = 0 ;
         ScanLoadTrayectoviaje( ) ;
      }

      private void ScanLoadTrayectoviaje( )
      {
         Gx_mode = Mode.Display ;
         if ( cmTrayectoViajeSelect5.HasMoreRows )
         {
            RcdFound10 = 1 ;
            rowTrayectoViaje["TrayectoViajeID"] = dsDefault.Db.GetInt32(TrayectoViajeSelect5, 0) ;
            rowTrayectoViaje["TrayectoOrigen"] = dsDefault.Db.GetString(TrayectoViajeSelect5, 1) ;
            rowTrayectoViaje["TrayectoDestino"] = dsDefault.Db.GetString(TrayectoViajeSelect5, 2) ;
            rowTrayectoViaje["TayectoLatitudOrigen"] = dsDefault.Db.GetDecimal(TrayectoViajeSelect5, 3) ;
            rowTrayectoViaje["TrayectoLongitudOrigen"] = dsDefault.Db.GetDecimal(TrayectoViajeSelect5, 4) ;
            rowTrayectoViaje["TrayectoLatidudDestino"] = dsDefault.Db.GetDecimal(TrayectoViajeSelect5, 5) ;
            rowTrayectoViaje["TrayectoLongitudDestino"] = dsDefault.Db.GetDecimal(TrayectoViajeSelect5, 6) ;
            rowTrayectoViaje["Trayectokm"] = dsDefault.Db.GetDecimal(TrayectoViajeSelect5, 7) ;
            rowTrayectoViaje["TiempoEstimado"] = dsDefault.Db.GetDecimal(TrayectoViajeSelect5, 8) ;
            rowTrayectoViaje["CombustibleConsumido"] = dsDefault.Db.GetDecimal(TrayectoViajeSelect5, 9) ;
            rowTrayectoViaje["EstadoCarretera"] = dsDefault.Db.GetString(TrayectoViajeSelect5, 10) ;
            rowTrayectoViaje["Instrucciones"] = dsDefault.Db.GetString(TrayectoViajeSelect5, 11) ;
            rowTrayectoViaje["Orden"] = dsDefault.Db.GetInt32(TrayectoViajeSelect5, 12) ;
            rowTrayectoViaje["ViajeID"] = dsDefault.Db.GetInt64(TrayectoViajeSelect5, 13) ;
         }
      }

      private void ScanEndTrayectoviaje( )
      {
         TrayectoViajeSelect5.Close();
      }

      private void AfterConfirmTrayectoviaje( )
      {
         // After Confirm Rules
         OnTrayectoViajeUpdating( new TrayectoViajeEventArgs( rowTrayectoViaje, Gx_mode)) ;
      }

      private void CreateNewRowTrayectoviaje( )
      {
         rowTrayectoViaje = TrayectoViajeSet.TrayectoViaje.NewTrayectoViajeRow() ;
      }

      private void LoadChildTrayectoviaje( int startRow ,
                                           int maxRows )
      {
         CreateNewRowTrayectoviaje( ) ;
         bool tmpConstraintState = TrayectoViajeSet.EnforceConstraints ;
         TrayectoViajeSet.TrayectoViaje.BeginLoadData( ) ;
         ScanStartTrayectoviaje( startRow, maxRows) ;
         TrayectoViajeSet.TrayectoViaje.EndLoadData( ) ;
         this.TrayectoViajeSet.EnforceConstraints = tmpConstraintState ;
      }

      private void LoadDataTrayectoviaje( int maxRows )
      {
         int loadedRows = 0 ;
         if ( ( RcdFound10 != 0 ) )
         {
            ScanLoadTrayectoviaje( ) ;
            while ( ( RcdFound10 != 0 ) && ( loadedRows != maxRows ) )
            {
               loadedRows++ ;
               LoadRowTrayectoviaje( ) ;
               CreateNewRowTrayectoviaje( ) ;
               ScanNextTrayectoviaje( ) ;
            }
         }
         if ( ( loadedRows > 0 ) )
         {
            RcdFound10 = 1 ;
         }
         ScanEndTrayectoviaje( ) ;
         if ( ( TrayectoViajeSet.TrayectoViaje.Count > 0 ) )
         {
            rowTrayectoViaje = TrayectoViajeSet.TrayectoViaje[TrayectoViajeSet.TrayectoViaje.Count -1] ;
         }
      }

      private void LoadByTrayectoViajeID( int startRow ,
                                          int maxRows )
      {
         bool tmpConstraintState = TrayectoViajeSet.EnforceConstraints ;
         TrayectoViajeSet.TrayectoViaje.BeginLoadData( ) ;
         ScanByTrayectoViajeID( startRow, maxRows) ;
         TrayectoViajeSet.TrayectoViaje.EndLoadData( ) ;
         this.TrayectoViajeSet.EnforceConstraints = tmpConstraintState ;
         if ( ( TrayectoViajeSet.TrayectoViaje.Count > 0 ) )
         {
            rowTrayectoViaje = TrayectoViajeSet.TrayectoViaje[TrayectoViajeSet.TrayectoViaje.Count -1] ;
         }
      }

      private void LoadByViajeID( int startRow ,
                                  int maxRows )
      {
         bool tmpConstraintState = TrayectoViajeSet.EnforceConstraints ;
         TrayectoViajeSet.TrayectoViaje.BeginLoadData( ) ;
         ScanByViajeID( startRow, maxRows) ;
         TrayectoViajeSet.TrayectoViaje.EndLoadData( ) ;
         this.TrayectoViajeSet.EnforceConstraints = tmpConstraintState ;
         if ( ( TrayectoViajeSet.TrayectoViaje.Count > 0 ) )
         {
            rowTrayectoViaje = TrayectoViajeSet.TrayectoViaje[TrayectoViajeSet.TrayectoViaje.Count -1] ;
         }
      }

      private void AddRowTrayectoviaje( )
      {
         TrayectoViajeSet.TrayectoViaje.AddTrayectoViajeRow( rowTrayectoViaje) ;
      }

      private readonly string m_SelectString10 = "TM1.[TrayectoViajeID], TM1.[TrayectoOrigen], TM1.[TrayectoDestino], TM1.[TayectoLatitudOrigen], TM1.[TrayectoLongitudOrigen], TM1.[TrayectoLatidudDestino], TM1.[TrayectoLongitudDestino], TM1.[Trayectokm], TM1.[TiempoEstimado], TM1.[CombustibleConsumido], TM1.[EstadoCarretera], TM1.[Instrucciones], TM1.[Orden], TM1.[ViajeID]" ;


      public delegate  void TrayectoViajeUpdateEventHandler( object sender ,
                                                             TrayectoViajeEventArgs e );
      public event TrayectoViajeUpdateEventHandler TrayectoViajeUpdated ;
      private void OnTrayectoViajeUpdated( TrayectoViajeEventArgs e )
      {
         if ( ( this.TrayectoViajeUpdated != null ) )
         {
            this.TrayectoViajeUpdated( this, e) ;
         }
      }

      public event TrayectoViajeUpdateEventHandler TrayectoViajeUpdating ;
      private void OnTrayectoViajeUpdating( TrayectoViajeEventArgs e )
      {
         if ( ( this.TrayectoViajeUpdating != null ) )
         {
            this.TrayectoViajeUpdating( this, e) ;
         }
      }

      public class TrayectoViajeEventArgs : EventArgs
      {
         private System.Data.StatementType m_statementType ;
         private TrayectoViajeDataSet.TrayectoViajeRow m_dataRow ;
         public TrayectoViajeEventArgs( TrayectoViajeDataSet.TrayectoViajeRow row ,
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

         public TrayectoViajeDataSet.TrayectoViajeRow Row
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
      public class TrayectoViajeNotFoundException : Deklarit.DataNotFoundException
      {
         public TrayectoViajeNotFoundException( )
         {
         }

         public TrayectoViajeNotFoundException( string message ) : base(message)
         {
         }

         public TrayectoViajeNotFoundException( string message ,
                                                Exception inner ) : base(message, inner)
         {
         }

         protected TrayectoViajeNotFoundException( SerializationInfo info ,
                                                   StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class ViajeForeignKeyNotFoundException : Deklarit.ForeignKeyNotFoundException
      {
         public ViajeForeignKeyNotFoundException( )
         {
         }

         public ViajeForeignKeyNotFoundException( string message ) : base(message)
         {
         }

         public ViajeForeignKeyNotFoundException( string message ,
                                                  Exception inner ) : base(message, inner)
         {
         }

         protected ViajeForeignKeyNotFoundException( SerializationInfo info ,
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
      public class TrayectoViajeDataLockedException : Deklarit.DataLockedException
      {
         public TrayectoViajeDataLockedException( )
         {
         }

         public TrayectoViajeDataLockedException( string message ) : base(message)
         {
         }

         public TrayectoViajeDataLockedException( string message ,
                                                  Exception inner ) : base(message, inner)
         {
         }

         protected TrayectoViajeDataLockedException( SerializationInfo info ,
                                                     StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class TrayectoViajeDataChangedException : Deklarit.DataChangedException
      {
         public TrayectoViajeDataChangedException( )
         {
         }

         public TrayectoViajeDataChangedException( string message ) : base(message)
         {
         }

         public TrayectoViajeDataChangedException( string message ,
                                                   Exception inner ) : base(message, inner)
         {
         }

         protected TrayectoViajeDataChangedException( SerializationInfo info ,
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
         RcdFound10 = 0 ;
         scmdbuf = "" ;
         recordCount = 0 ;
         _Gxremove = false ;
         m__TrayectoOrigenOriginal = new object();
         m__TrayectoDestinoOriginal = new object();
         m__TayectoLatitudOrigenOriginal = new object();
         m__TrayectoLongitudOrigenOriginal = new object();
         m__TrayectoLatidudDestinoOriginal = new object();
         m__TrayectoLongitudDestinoOriginal = new object();
         m__TrayectokmOriginal = new object();
         m__TiempoEstimadoOriginal = new object();
         m__CombustibleConsumidoOriginal = new object();
         m__EstadoCarreteraOriginal = new object();
         m__InstruccionesOriginal = new object();
         m__OrdenOriginal = new object();
         m__ViajeIDOriginal = new object();
         _Condition = false ;
         IsModified = 0 ;
         m_WhereString = "" ;
         if ( ( this.Transaction == null ) )
         {
            this.Transaction = ((System.Data.IDbTransaction)(System.Threading.Thread.GetData(System.Threading.Thread.GetNamedDataSlot(DeklaritTransaction.TransactionSlotName)) ));
         }
      }

      private short RcdFound10 ;
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
      private ReadWriteCommand cmTrayectoViajeSelect1 ;
      private IDataReader TrayectoViajeSelect1 ;
      private ReadWriteCommand cmTrayectoViajeSelect2 ;
      private IDataReader TrayectoViajeSelect2 ;
      private ReadWriteCommand cmTrayectoViajeSelect5 ;
      private IDataReader TrayectoViajeSelect5 ;
      private System.Data.StatementType Gx_mode ;
      private System.Data.StatementType sMode10 ;
      private object m__TrayectoOrigenOriginal ;
      private object m__TrayectoDestinoOriginal ;
      private object m__TayectoLatitudOrigenOriginal ;
      private object m__TrayectoLongitudOrigenOriginal ;
      private object m__TrayectoLatidudDestinoOriginal ;
      private object m__TrayectoLongitudDestinoOriginal ;
      private object m__TrayectokmOriginal ;
      private object m__TiempoEstimadoOriginal ;
      private object m__CombustibleConsumidoOriginal ;
      private object m__EstadoCarreteraOriginal ;
      private object m__InstruccionesOriginal ;
      private object m__OrdenOriginal ;
      private object m__ViajeIDOriginal ;
   }

   public class TrayectoViajeDataReader : System.IDisposable
   {
      public TrayectoViajeDataReader( )
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
      ///   Gets or sets the Transaction object to be used  by  TrayectoViajeDataReaderDeklarit
      ///    DataReaderclasses to commit changes to the Database.
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
         cmTrayectoViajeSelect6 = connDefault.GetCommand("SELECT TM1.[TrayectoViajeID], TM1.[TrayectoOrigen], TM1.[TrayectoDestino], TM1.[TayectoLatitudOrigen], TM1.[TrayectoLongitudOrigen], TM1.[TrayectoLatidudDestino], TM1.[TrayectoLongitudDestino], TM1.[Trayectokm], TM1.[TiempoEstimado], TM1.[CombustibleConsumido], TM1.[EstadoCarretera], TM1.[Instrucciones], TM1.[Orden], TM1.[ViajeID] FROM [TrayectoViaje] TM1 WITH (NOLOCK) ORDER BY TM1.[TrayectoViajeID] ", false) ;
         TrayectoViajeSelect6 = cmTrayectoViajeSelect6.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return TrayectoViajeSelect6 ;
      }

      public IDataReader OpenByTrayectoViajeID( int trayectoViajeID )
      {
         init_reader( ) ;
         m_Closed = false ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmTrayectoViajeSelect6 = connDefault.GetCommand("SELECT TM1.[TrayectoViajeID], TM1.[TrayectoOrigen], TM1.[TrayectoDestino], TM1.[TayectoLatitudOrigen], TM1.[TrayectoLongitudOrigen], TM1.[TrayectoLatidudDestino], TM1.[TrayectoLongitudDestino], TM1.[Trayectokm], TM1.[TiempoEstimado], TM1.[CombustibleConsumido], TM1.[EstadoCarretera], TM1.[Instrucciones], TM1.[Orden], TM1.[ViajeID] FROM [TrayectoViaje] TM1 WITH (NOLOCK) WHERE TM1.[TrayectoViajeID] = @TrayectoViajeID ORDER BY TM1.[TrayectoViajeID] ", false) ;
         if ( ( cmTrayectoViajeSelect6.IDbCommand.Parameters.Count == 0 ) )
         {
            cmTrayectoViajeSelect6.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoViajeID", System.Data.DbType.Int32));
         }
         cmTrayectoViajeSelect6.SetParameter(0, trayectoViajeID);
         TrayectoViajeSelect6 = cmTrayectoViajeSelect6.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return TrayectoViajeSelect6 ;
      }

      public IDataReader OpenByViajeID( long viajeID )
      {
         init_reader( ) ;
         m_Closed = false ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmTrayectoViajeSelect6 = connDefault.GetCommand("SELECT TM1.[TrayectoViajeID], TM1.[TrayectoOrigen], TM1.[TrayectoDestino], TM1.[TayectoLatitudOrigen], TM1.[TrayectoLongitudOrigen], TM1.[TrayectoLatidudDestino], TM1.[TrayectoLongitudDestino], TM1.[Trayectokm], TM1.[TiempoEstimado], TM1.[CombustibleConsumido], TM1.[EstadoCarretera], TM1.[Instrucciones], TM1.[Orden], TM1.[ViajeID] FROM [TrayectoViaje] TM1 WITH (NOLOCK) WHERE TM1.[ViajeID] = @ViajeID ORDER BY TM1.[TrayectoViajeID] ", false) ;
         if ( ( cmTrayectoViajeSelect6.IDbCommand.Parameters.Count == 0 ) )
         {
            cmTrayectoViajeSelect6.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
         }
         cmTrayectoViajeSelect6.SetParameter(0, viajeID);
         TrayectoViajeSelect6 = cmTrayectoViajeSelect6.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return TrayectoViajeSelect6 ;
      }

      public int DeleteByViajeID( long viajeID )
      {
         init_reader( ) ;
         int intCount = 0 ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmTrayectoViajeDelete2 = connDefault.GetCommand("DELETE FROM [TrayectoViaje]  WHERE [ViajeID] = @ViajeID", false) ;
         if ( ( cmTrayectoViajeDelete2.IDbCommand.Parameters.Count == 0 ) )
         {
            cmTrayectoViajeDelete2.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
         }
         // Using cursor TrayectoViajeDelete2
         cmTrayectoViajeDelete2.SetParameter(0, viajeID);
         intCount = cmTrayectoViajeDelete2.ExecuteStmt() ;
         return intCount ;
      }

      public void Dispose( )
      {
         if ( ! m_Disposed )
         {
            m_Disposed = true ;
            try
            {
               if ( ! m_Closed && ( TrayectoViajeSelect6 != null ) )
               {
                  m_Closed = true ;
                  TrayectoViajeSelect6.Close();
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
      private ReadWriteCommand cmTrayectoViajeSelect6 ;
      private IDataReader TrayectoViajeSelect6 ;
      private ReadWriteCommand cmTrayectoViajeDelete2 ;
   }

}
