
//               File: ComentarioViajeDataAdapter
//        Description: ComentarioViaje
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
   public partial class ComentarioViajeDataAdapter : System.Data.IDataAdapter, IComentarioViajeDataAdapter
   {
      private ComentarioViajeDataSet ComentarioViajeSet ;
      private IDbTransaction daCurrentTransaction ;
      private ComentarioViajeDataSet.ComentarioViajeRow rowComentarioViaje ;
      public ComentarioViajeDataAdapter( )
      {
      }

      private void InitializeMembers( )
      {
         ComentarioViajeSet = new ComentarioViajeDataSet() ;
         this.Initialize( ) ;
         dsDefault = new DataStore( new SqlServer2005Handler( ), "System.Data.SqlClient", Raiderplan1.Configuration.ConnectionString, DeklaritTransaction.TransactionSlotName) ;
      }

      ///  <summary>
      ///   Gets or sets the Transaction object to be used  by  ComentarioViajeDataAdapterclasses
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
      ///   (2) Fills the specified Dataset with the record matching ComentarioViajeID field(s)
      ///    of the given IDataRecord
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="dataRecord">Data Record</param>
      public virtual int Fill( ComentarioViajeDataSet dataSet ,
                               IDataRecord dataRecord )
      {
         return Fill(dataSet, ((int)(dataRecord["ComentarioViajeID"]))) ;
      }

      ///  <summary>
      ///   (3) Fills the specified Dataset with the record matching ComentarioViajeID field(s)
      ///    of the given DataRow
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="dataRecord">Data Row</param>
      public virtual int Fill( ComentarioViajeDataSet dataSet ,
                               DataRow dataRecord )
      {
         return Fill(dataSet, ((int)(dataRecord["ComentarioViajeID"]))) ;
      }

      ///  <summary>
      ///   (4) Fills the specified Dataset with the record matching ComentarioViajeID, if the
      ///    record is not found , throws an exception.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="comentarioViajeID">Comentario Viaje ID</param>
      public virtual int Fill( ComentarioViajeDataSet dataSet ,
                               int comentarioViajeID )
      {
         if ( ! FillByComentarioViajeID( dataSet, comentarioViajeID) )
         {
            throw new ComentarioViajeNotFoundException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("inex"), new   object[]  {resourceManagerTables.GetString("ComentarioViaje")})) ;
         }
         return 0 ;
      }


      ///  <summary>
      ///   (5) Fills the specified Dataset with the record matching ComentarioViajeID in the
      ///    fillDataParameters array, if the array is null, it fills the Dataset loading all
      ///    records in the table.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Fill( ComentarioViajeDataSet dataSet )
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
               ComentarioViajeSet = dataSet ;
               LoadChildComentarioviaje( 0, -1) ;
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
      ///   (6) Fills the specified dataset filtered by ComentarioViajeIDfield(s).
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="comentarioViajeID">Comentario Viaje ID</param>
      public virtual bool FillByComentarioViajeID( ComentarioViajeDataSet dataSet ,
                                                   int comentarioViajeID )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         ComentarioViajeSet = dataSet ;
         rowComentarioViaje = ComentarioViajeSet.ComentarioViaje.NewComentarioViajeRow() ;
         rowComentarioViaje.ComentarioViajeID = comentarioViajeID ;
         try
         {
            LoadByComentarioViajeID( 0, -1) ;
            dataSet.AcceptChanges( ) ;
         }
         finally
         {
            this.Cleanup();
         }
         if ( ( RcdFound13 == 0 ) )
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
      public virtual int FillByViajeID( ComentarioViajeDataSet dataSet ,
                                        long viajeID )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         ComentarioViajeSet = dataSet ;
         rowComentarioViaje = ComentarioViajeSet.ComentarioViaje.NewComentarioViajeRow() ;
         rowComentarioViaje.ViajeID = viajeID ;
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
      public virtual int FillPageByViajeID( ComentarioViajeDataSet dataSet ,
                                            long viajeID ,
                                            int startRow ,
                                            int maxRows )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         ComentarioViajeSet = dataSet ;
         rowComentarioViaje = ComentarioViajeSet.ComentarioViaje.NewComentarioViajeRow() ;
         rowComentarioViaje.ViajeID = viajeID ;
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
         cmComentarioViajeSelect1 = connDefault.GetCommand("SELECT COUNT(*) FROM [ComentarioViaje] WITH (NOLOCK) WHERE [ViajeID] = @ViajeID ", false) ;
         if ( ( cmComentarioViajeSelect1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmComentarioViajeSelect1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
         }
         cmComentarioViajeSelect1.SetParameter(0, viajeID);
         ComentarioViajeSelect1 = cmComentarioViajeSelect1.FetchData() ;
         recordCount = ( ( ComentarioViajeSelect1.IsDBNull(0) )  ? (int)(0) : ComentarioViajeSelect1.GetInt32(0) ) ;
         ComentarioViajeSelect1.Close();
         return recordCount ;
      }

      ///  <summary>
      ///   (8) Fills the specified dataset with the record matching ComentarioViajeID in the
      ///    the fillDataParameters array, if the array is null, it fills the Dataset loading
      ///    all records in the table.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Fill( DataSet dataSet )
      {
         ComentarioViajeSet = dataSet as ComentarioViajeDataSet ;
         if ( ( ComentarioViajeSet != null ) )
         {
            return Fill( ComentarioViajeSet) ;
         }
         else
         {
            ComentarioViajeSet = new ComentarioViajeDataSet() ;
            Fill( ComentarioViajeSet) ;
            dataSet.Merge( ComentarioViajeSet) ;
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
      public virtual int FillPage( ComentarioViajeDataSet dataSet ,
                                   int startRow ,
                                   int maxRows )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         ComentarioViajeSet = dataSet ;
         try
         {
            LoadChildComentarioviaje( startRow, maxRows) ;
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
         cmComentarioViajeSelect2 = connDefault.GetCommand("SELECT COUNT(*) FROM [ComentarioViaje] WITH (NOLOCK) ", false) ;
         ComentarioViajeSelect2 = cmComentarioViajeSelect2.FetchData() ;
         recordCount = ( ( ComentarioViajeSelect2.IsDBNull(0) )  ? (int)(0) : ComentarioViajeSelect2.GetInt32(0) ) ;
         ComentarioViajeSelect2.Close();
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
            DbParameter parm0ComentarioViajeID ;
            parm0ComentarioViajeID = factory.CreateParameter() ;
            parm0ComentarioViajeID.ParameterName = "ComentarioViajeID" ;
            parm0ComentarioViajeID.DbType = System.Data.DbType.Int32 ;
            fillDataParameters = new  DbParameter[]  {parm0ComentarioViajeID} ;
         }
         return fillDataParameters ;
      }

      private DbParameter[] fillDataParameters ;

      ///  <summary>
      ///   Inserts, Updates or Deletes records from the specified ComentarioViajeDataSet object.
      ///
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Update( DataSet dataSet )
      {
         InitializeMembers( ) ;
         ComentarioViajeSet = dataSet as ComentarioViajeDataSet ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         if ( ( ComentarioViajeSet != null ) )
         {
            try
            {
               connDefault.BeginTransaction();
               foreach( ComentarioViajeDataSet.ComentarioViajeRow row in ComentarioViajeSet.ComentarioViaje )
               {
                  rowComentarioViaje = row ;
                  if ( Deklarit.Data.Helpers.IsRowChanged(rowComentarioViaje) )
                  {
                     ReadRowComentarioviaje( ) ;
                     if ( ( rowComentarioViaje.RowState == System.Data.DataRowState.Added ) )
                     {
                        InsertComentarioviaje( ) ;
                     }
                     else
                     {
                        if ( _Gxremove )
                        {
                           Delete( ) ;
                        }
                        else
                        {
                           UpdateComentarioviaje( ) ;
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

      private void LoadRowComentarioviaje( )
      {
         AddRowComentarioviaje( ) ;
      }

      private void ReadRowComentarioviaje( )
      {
         Gx_mode = Deklarit.Utils.Mode.FromRowState(rowComentarioViaje.RowState) ;
         if ( ( rowComentarioViaje.RowState != System.Data.DataRowState.Added ) )
         {
            m__ComentarioLatitudOriginal = rowComentarioViaje["ComentarioLatitud", System.Data.DataRowVersion.Original] ;
            m__ComentarioLongitudOriginal = rowComentarioViaje["ComentarioLongitud", System.Data.DataRowVersion.Original] ;
            m__ComentarioTextoOriginal = rowComentarioViaje["ComentarioTexto", System.Data.DataRowVersion.Original] ;
            m__ComentarioImagenOriginal = rowComentarioViaje["ComentarioImagen", System.Data.DataRowVersion.Original] ;
            m__CVTrayectoIDOriginal = rowComentarioViaje["CVTrayectoID", System.Data.DataRowVersion.Original] ;
            m__ViajeIDOriginal = rowComentarioViaje["ViajeID", System.Data.DataRowVersion.Original] ;
         }
         else
         {
            m__ComentarioLatitudOriginal = rowComentarioViaje["ComentarioLatitud"] ;
            m__ComentarioLongitudOriginal = rowComentarioViaje["ComentarioLongitud"] ;
            m__ComentarioTextoOriginal = rowComentarioViaje["ComentarioTexto"] ;
            m__ComentarioImagenOriginal = rowComentarioViaje["ComentarioImagen"] ;
            m__CVTrayectoIDOriginal = rowComentarioViaje["CVTrayectoID"] ;
            m__ViajeIDOriginal = rowComentarioViaje["ViajeID"] ;
         }
         _Gxremove = (bool)((rowComentarioViaje.RowState==System.Data.DataRowState.Deleted)) ;
         if ( _Gxremove )
         {
            rowComentarioViaje = ((ComentarioViajeDataSet.ComentarioViajeRow)(Deklarit.Utils.DataSetUtil.CloneOriginalDataRow(rowComentarioViaje)));
         }
      }

      private void CheckIntegrityErrorsComentarioviaje( )
      {
          IDataReader ViajeSelect1 ;
          ReadWriteCommand cmViajeSelect1 ;
         cmViajeSelect1 = connDefault.GetCommand("SELECT [ViajeID] FROM [Viaje] WITH (NOLOCK) WHERE [ViajeID] = @ViajeID ", false) ;
         if ( ( cmViajeSelect1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmViajeSelect1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
         }
         cmViajeSelect1.SetParameter(0, rowComentarioViaje["ViajeID"]);
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
          IDataReader ComentarioViajeSelect3 ;
          ReadWriteCommand cmComentarioViajeSelect3 ;
         cmComentarioViajeSelect3 = connDefault.GetCommand("SELECT [ComentarioViajeID], [ComentarioLatitud], [ComentarioLongitud], [ComentarioTexto], [ComentarioImagen], [CVTrayectoID], [ViajeID] FROM [ComentarioViaje] WITH (NOLOCK) WHERE [ComentarioViajeID] = @ComentarioViajeID ", false) ;
         if ( ( cmComentarioViajeSelect3.IDbCommand.Parameters.Count == 0 ) )
         {
            cmComentarioViajeSelect3.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ComentarioViajeID", System.Data.DbType.Int32));
         }
         cmComentarioViajeSelect3.SetParameter(0, rowComentarioViaje["ComentarioViajeID"]);
         ComentarioViajeSelect3 = cmComentarioViajeSelect3.FetchData() ;
         if ( cmComentarioViajeSelect3.HasMoreRows )
         {
            RcdFound13 = 1 ;
            rowComentarioViaje["ComentarioViajeID"] = dsDefault.Db.GetInt32(ComentarioViajeSelect3, 0) ;
            rowComentarioViaje["ComentarioLatitud"] = dsDefault.Db.GetDecimal(ComentarioViajeSelect3, 1) ;
            rowComentarioViaje["ComentarioLongitud"] = dsDefault.Db.GetDecimal(ComentarioViajeSelect3, 2) ;
            rowComentarioViaje["ComentarioTexto"] = dsDefault.Db.GetString(ComentarioViajeSelect3, 3) ;
            rowComentarioViaje["ComentarioImagen"] = dsDefault.Db.GetString(ComentarioViajeSelect3, 4) ;
            rowComentarioViaje["CVTrayectoID"] = dsDefault.Db.GetInt32(ComentarioViajeSelect3, 5) ;
            rowComentarioViaje["ViajeID"] = dsDefault.Db.GetInt64(ComentarioViajeSelect3, 6) ;
            sMode13 = Gx_mode ;
            Gx_mode = Mode.Display ;
            Gx_mode = sMode13 ;
         }
         else
         {
            RcdFound13 = 0 ;
         }
         ComentarioViajeSelect3.Close();
      }

      private void CheckOptimisticConcurrencyComentarioviaje( )
      {
          IDataReader ComentarioViajeSelect4 ;
          ReadWriteCommand cmComentarioViajeSelect4 ;
         if ( ( Gx_mode != Mode.Insert ) )
         {
            cmComentarioViajeSelect4 = connDefault.GetCommand("SELECT [ComentarioViajeID], [ComentarioLatitud], [ComentarioLongitud], [ComentarioTexto], [ComentarioImagen], [CVTrayectoID], [ViajeID] FROM [ComentarioViaje] WITH (UPDLOCK) WHERE [ComentarioViajeID] = @ComentarioViajeID ", false) ;
            if ( ( cmComentarioViajeSelect4.IDbCommand.Parameters.Count == 0 ) )
            {
               cmComentarioViajeSelect4.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ComentarioViajeID", System.Data.DbType.Int32));
            }
            cmComentarioViajeSelect4.SetParameter(0, rowComentarioViaje["ComentarioViajeID"]);
            ComentarioViajeSelect4 = cmComentarioViajeSelect4.FetchData() ;
            if ( cmComentarioViajeSelect4.Locked )
            {
               ComentarioViajeSelect4.Close();
               throw new ComentarioViajeDataLockedException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("lock"), new   object[]  {resourceManagerTables.GetString("ComentarioViaje")})) ;
            }
            _Condition = false ;
            if ( !cmComentarioViajeSelect4.HasMoreRows || ( ! m__ComentarioLatitudOriginal.Equals(dsDefault.Db.GetDecimal(ComentarioViajeSelect4, 1)) ) || ( ! m__ComentarioLongitudOriginal.Equals(dsDefault.Db.GetDecimal(ComentarioViajeSelect4, 2)) ) || ( ! StringUtil.ObjectStringEquals(m__ComentarioTextoOriginal,dsDefault.Db.GetString(ComentarioViajeSelect4, 3)) ) || ( ! StringUtil.ObjectStringEquals(m__ComentarioImagenOriginal,dsDefault.Db.GetString(ComentarioViajeSelect4, 4)) ) || ( ! m__CVTrayectoIDOriginal.Equals(dsDefault.Db.GetInt32(ComentarioViajeSelect4, 5)) ) )
            {
               _Condition = true ;
            }
            if ( _Condition || ( ! m__ViajeIDOriginal.Equals(dsDefault.Db.GetInt64(ComentarioViajeSelect4, 6)) ) )
            {
               ComentarioViajeSelect4.Close();
               throw new ComentarioViajeDataChangedException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("waschg"), new   object[]  {resourceManagerTables.GetString("ComentarioViaje")})) ;
            }
            ComentarioViajeSelect4.Close();
         }
      }

      private void InsertComentarioviaje( )
      {
          IDataReader ComentarioViajeInsert1 ;
          ReadWriteCommand cmComentarioViajeInsert1 ;
         CheckOptimisticConcurrencyComentarioviaje( ) ;
         AfterConfirmComentarioviaje( ) ;
         cmComentarioViajeInsert1 = connDefault.GetCommand("INSERT INTO [ComentarioViaje] ([ComentarioLatitud], [ComentarioLongitud], [ComentarioTexto], [ComentarioImagen], [CVTrayectoID], [ViajeID]) VALUES (@ComentarioLatitud, @ComentarioLongitud, @ComentarioTexto, @ComentarioImagen, @CVTrayectoID, @ViajeID); SELECT SCOPE_IDENTITY()", false) ;
         if ( ( cmComentarioViajeInsert1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmComentarioViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ComentarioLatitud", System.Data.DbType.Decimal));
            cmComentarioViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ComentarioLongitud", System.Data.DbType.Decimal));
            cmComentarioViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ComentarioTexto", System.Data.DbType.AnsiString,250));
            cmComentarioViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ComentarioImagen", System.Data.DbType.AnsiString,250));
            cmComentarioViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@CVTrayectoID", System.Data.DbType.Int32));
            cmComentarioViajeInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
         }
         cmComentarioViajeInsert1.ErrorMask = cmComentarioViajeInsert1.ErrorMask  |  ErrorMask.ForeignKeyError;
         cmComentarioViajeInsert1.ErrorMask = cmComentarioViajeInsert1.ErrorMask  |  ErrorMask.DuplicateKeyError;
         cmComentarioViajeInsert1.SetParameter(0, rowComentarioViaje["ComentarioLatitud"]);
         cmComentarioViajeInsert1.SetParameter(1, rowComentarioViaje["ComentarioLongitud"]);
         cmComentarioViajeInsert1.SetParameter(2, rowComentarioViaje["ComentarioTexto"]);
         cmComentarioViajeInsert1.SetParameter(3, rowComentarioViaje["ComentarioImagen"]);
         cmComentarioViajeInsert1.SetParameter(4, rowComentarioViaje["CVTrayectoID"]);
         cmComentarioViajeInsert1.SetParameter(5, rowComentarioViaje["ViajeID"]);
         ComentarioViajeInsert1 = cmComentarioViajeInsert1.FetchData() ;
         if ( ! ( cmComentarioViajeInsert1.ForeignKeyError || cmComentarioViajeInsert1.DupKey ) )
         {
            rowComentarioViaje.ComentarioViajeID = (int)(ComentarioViajeInsert1.GetDecimal(0)) ;
            ComentarioViajeInsert1.Close();
         }
         if ( cmComentarioViajeInsert1.ForeignKeyError )
         {
            CheckIntegrityErrorsComentarioviaje( ) ;
         }
         // Start of After( Insert) rules
         // End of After( Insert) rules
         OnComentarioViajeUpdated( new ComentarioViajeEventArgs( rowComentarioViaje, Mode.Insert)) ;
         // Save values for previous() function.
         EndLevelComentarioviaje( ) ;
      }

      private void UpdateComentarioviaje( )
      {
          ReadWriteCommand cmComentarioViajeUpdate1 ;
         CheckOptimisticConcurrencyComentarioviaje( ) ;
         AfterConfirmComentarioviaje( ) ;
         cmComentarioViajeUpdate1 = connDefault.GetCommand("UPDATE [ComentarioViaje] SET [ComentarioLatitud]=@ComentarioLatitud, [ComentarioLongitud]=@ComentarioLongitud, [ComentarioTexto]=@ComentarioTexto, [ComentarioImagen]=@ComentarioImagen, [CVTrayectoID]=@CVTrayectoID, [ViajeID]=@ViajeID  WHERE [ComentarioViajeID] = @ComentarioViajeID", false) ;
         if ( ( cmComentarioViajeUpdate1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmComentarioViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ComentarioLatitud", System.Data.DbType.Decimal));
            cmComentarioViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ComentarioLongitud", System.Data.DbType.Decimal));
            cmComentarioViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ComentarioTexto", System.Data.DbType.AnsiString,250));
            cmComentarioViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ComentarioImagen", System.Data.DbType.AnsiString,250));
            cmComentarioViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@CVTrayectoID", System.Data.DbType.Int32));
            cmComentarioViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
            cmComentarioViajeUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ComentarioViajeID", System.Data.DbType.Int32));
         }
         cmComentarioViajeUpdate1.ErrorMask = cmComentarioViajeUpdate1.ErrorMask  |  ErrorMask.ForeignKeyError;
         // Using cursor ComentarioViajeUpdate1
         cmComentarioViajeUpdate1.SetParameter(0, rowComentarioViaje["ComentarioLatitud"]);
         cmComentarioViajeUpdate1.SetParameter(1, rowComentarioViaje["ComentarioLongitud"]);
         cmComentarioViajeUpdate1.SetParameter(2, rowComentarioViaje["ComentarioTexto"]);
         cmComentarioViajeUpdate1.SetParameter(3, rowComentarioViaje["ComentarioImagen"]);
         cmComentarioViajeUpdate1.SetParameter(4, rowComentarioViaje["CVTrayectoID"]);
         cmComentarioViajeUpdate1.SetParameter(5, rowComentarioViaje["ViajeID"]);
         cmComentarioViajeUpdate1.SetParameter(6, rowComentarioViaje["ComentarioViajeID"]);
         cmComentarioViajeUpdate1.ExecuteStmt();
         if ( cmComentarioViajeUpdate1.ForeignKeyError )
         {
            CheckIntegrityErrorsComentarioviaje( ) ;
         }
         // Start of After( update) rules
         // End of After( update) rules
         OnComentarioViajeUpdated( new ComentarioViajeEventArgs( rowComentarioViaje, Mode.Update)) ;
         EndLevelComentarioviaje( ) ;
      }

      private void Delete( )
      {
          ReadWriteCommand cmComentarioViajeDelete1 ;
         Gx_mode = Mode.Delete ;
         CheckOptimisticConcurrencyComentarioviaje( ) ;
         // No cascading delete specified.
         AfterConfirmComentarioviaje( ) ;
         cmComentarioViajeDelete1 = connDefault.GetCommand("DELETE FROM [ComentarioViaje]  WHERE [ComentarioViajeID] = @ComentarioViajeID", false) ;
         if ( ( cmComentarioViajeDelete1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmComentarioViajeDelete1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ComentarioViajeID", System.Data.DbType.Int32));
         }
         cmComentarioViajeDelete1.ErrorMask = cmComentarioViajeDelete1.ErrorMask  |  ErrorMask.ForeignKeyError;
         // Using cursor ComentarioViajeDelete1
         cmComentarioViajeDelete1.SetParameter(0, rowComentarioViaje["ComentarioViajeID"]);
         cmComentarioViajeDelete1.ExecuteStmt();
         // Start of After( delete) rules
         // End of After( delete) rules
         OnComentarioViajeUpdated( new ComentarioViajeEventArgs( rowComentarioViaje, Mode.Delete)) ;
         rowComentarioViaje.Delete( ) ;
         sMode13 = Gx_mode ;
         Gx_mode = Mode.Delete ;
         EndLevelComentarioviaje( ) ;
         Gx_mode = sMode13 ;
      }

      private void EndLevelComentarioviaje( )
      {
         // Execute 'After Trn' event if defined.
         IsModified = 0 ;
      }

      private void ScanByComentarioViajeID( int startRow ,
                                            int maxRows )
      {
         m_WhereString = " WHERE TM1.[ComentarioViajeID] = @ComentarioViajeID" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString13 + "  FROM [ComentarioViaje] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[ComentarioViajeID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString13 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[ComentarioViajeID] ) AS DK_PAGENUM   FROM [ComentarioViaje] TM1 WITH (NOLOCK) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString13 + " FROM [ComentarioViaje] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[ComentarioViajeID] " ;
         }
         cmComentarioViajeSelect5 = connDefault.GetCommand(scmdbuf, false) ;
         if ( ( cmComentarioViajeSelect5.IDbCommand.Parameters.Count == 0 ) )
         {
            cmComentarioViajeSelect5.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ComentarioViajeID", System.Data.DbType.Int32));
         }
         cmComentarioViajeSelect5.SetParameter(0, rowComentarioViaje["ComentarioViajeID"]);
         ComentarioViajeSelect5 = cmComentarioViajeSelect5.FetchData() ;
         RcdFound13 = 0 ;
         ScanLoadComentarioviaje( ) ;
         LoadDataComentarioviaje( maxRows) ;
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
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString13 + "  FROM [ComentarioViaje] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[ComentarioViajeID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString13 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[ComentarioViajeID] ) AS DK_PAGENUM   FROM [ComentarioViaje] TM1 WITH (NOLOCK) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString13 + " FROM [ComentarioViaje] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[ComentarioViajeID] " ;
         }
         cmComentarioViajeSelect5 = connDefault.GetCommand(scmdbuf, false) ;
         if ( ( cmComentarioViajeSelect5.IDbCommand.Parameters.Count == 0 ) )
         {
            cmComentarioViajeSelect5.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
         }
         cmComentarioViajeSelect5.SetParameter(0, rowComentarioViaje["ViajeID"]);
         ComentarioViajeSelect5 = cmComentarioViajeSelect5.FetchData() ;
         RcdFound13 = 0 ;
         ScanLoadComentarioviaje( ) ;
         LoadDataComentarioviaje( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanStartComentarioviaje( int startRow ,
                                             int maxRows )
      {
         m_WhereString = "" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString13 + "  FROM [ComentarioViaje] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[ComentarioViajeID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString13 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[ComentarioViajeID] ) AS DK_PAGENUM   FROM [ComentarioViaje] TM1 WITH (NOLOCK) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString13 + " FROM [ComentarioViaje] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[ComentarioViajeID] " ;
         }
         cmComentarioViajeSelect5 = connDefault.GetCommand(scmdbuf, false) ;
         ComentarioViajeSelect5 = cmComentarioViajeSelect5.FetchData() ;
         RcdFound13 = 0 ;
         ScanLoadComentarioviaje( ) ;
         LoadDataComentarioviaje( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanNextComentarioviaje( )
      {
         cmComentarioViajeSelect5.HasMoreRows = ComentarioViajeSelect5.Read() ;
         RcdFound13 = 0 ;
         ScanLoadComentarioviaje( ) ;
      }

      private void ScanLoadComentarioviaje( )
      {
         Gx_mode = Mode.Display ;
         if ( cmComentarioViajeSelect5.HasMoreRows )
         {
            RcdFound13 = 1 ;
            rowComentarioViaje["ComentarioViajeID"] = dsDefault.Db.GetInt32(ComentarioViajeSelect5, 0) ;
            rowComentarioViaje["ComentarioLatitud"] = dsDefault.Db.GetDecimal(ComentarioViajeSelect5, 1) ;
            rowComentarioViaje["ComentarioLongitud"] = dsDefault.Db.GetDecimal(ComentarioViajeSelect5, 2) ;
            rowComentarioViaje["ComentarioTexto"] = dsDefault.Db.GetString(ComentarioViajeSelect5, 3) ;
            rowComentarioViaje["ComentarioImagen"] = dsDefault.Db.GetString(ComentarioViajeSelect5, 4) ;
            rowComentarioViaje["CVTrayectoID"] = dsDefault.Db.GetInt32(ComentarioViajeSelect5, 5) ;
            rowComentarioViaje["ViajeID"] = dsDefault.Db.GetInt64(ComentarioViajeSelect5, 6) ;
         }
      }

      private void ScanEndComentarioviaje( )
      {
         ComentarioViajeSelect5.Close();
      }

      private void AfterConfirmComentarioviaje( )
      {
         // After Confirm Rules
         OnComentarioViajeUpdating( new ComentarioViajeEventArgs( rowComentarioViaje, Gx_mode)) ;
      }

      private void CreateNewRowComentarioviaje( )
      {
         rowComentarioViaje = ComentarioViajeSet.ComentarioViaje.NewComentarioViajeRow() ;
      }

      private void LoadChildComentarioviaje( int startRow ,
                                             int maxRows )
      {
         CreateNewRowComentarioviaje( ) ;
         bool tmpConstraintState = ComentarioViajeSet.EnforceConstraints ;
         ComentarioViajeSet.ComentarioViaje.BeginLoadData( ) ;
         ScanStartComentarioviaje( startRow, maxRows) ;
         ComentarioViajeSet.ComentarioViaje.EndLoadData( ) ;
         this.ComentarioViajeSet.EnforceConstraints = tmpConstraintState ;
      }

      private void LoadDataComentarioviaje( int maxRows )
      {
         int loadedRows = 0 ;
         if ( ( RcdFound13 != 0 ) )
         {
            ScanLoadComentarioviaje( ) ;
            while ( ( RcdFound13 != 0 ) && ( loadedRows != maxRows ) )
            {
               loadedRows++ ;
               LoadRowComentarioviaje( ) ;
               CreateNewRowComentarioviaje( ) ;
               ScanNextComentarioviaje( ) ;
            }
         }
         if ( ( loadedRows > 0 ) )
         {
            RcdFound13 = 1 ;
         }
         ScanEndComentarioviaje( ) ;
         if ( ( ComentarioViajeSet.ComentarioViaje.Count > 0 ) )
         {
            rowComentarioViaje = ComentarioViajeSet.ComentarioViaje[ComentarioViajeSet.ComentarioViaje.Count -1] ;
         }
      }

      private void LoadByComentarioViajeID( int startRow ,
                                            int maxRows )
      {
         bool tmpConstraintState = ComentarioViajeSet.EnforceConstraints ;
         ComentarioViajeSet.ComentarioViaje.BeginLoadData( ) ;
         ScanByComentarioViajeID( startRow, maxRows) ;
         ComentarioViajeSet.ComentarioViaje.EndLoadData( ) ;
         this.ComentarioViajeSet.EnforceConstraints = tmpConstraintState ;
         if ( ( ComentarioViajeSet.ComentarioViaje.Count > 0 ) )
         {
            rowComentarioViaje = ComentarioViajeSet.ComentarioViaje[ComentarioViajeSet.ComentarioViaje.Count -1] ;
         }
      }

      private void LoadByViajeID( int startRow ,
                                  int maxRows )
      {
         bool tmpConstraintState = ComentarioViajeSet.EnforceConstraints ;
         ComentarioViajeSet.ComentarioViaje.BeginLoadData( ) ;
         ScanByViajeID( startRow, maxRows) ;
         ComentarioViajeSet.ComentarioViaje.EndLoadData( ) ;
         this.ComentarioViajeSet.EnforceConstraints = tmpConstraintState ;
         if ( ( ComentarioViajeSet.ComentarioViaje.Count > 0 ) )
         {
            rowComentarioViaje = ComentarioViajeSet.ComentarioViaje[ComentarioViajeSet.ComentarioViaje.Count -1] ;
         }
      }

      private void AddRowComentarioviaje( )
      {
         ComentarioViajeSet.ComentarioViaje.AddComentarioViajeRow( rowComentarioViaje) ;
      }

      private readonly string m_SelectString13 = "TM1.[ComentarioViajeID], TM1.[ComentarioLatitud], TM1.[ComentarioLongitud], TM1.[ComentarioTexto], TM1.[ComentarioImagen], TM1.[CVTrayectoID], TM1.[ViajeID]" ;


      public delegate  void ComentarioViajeUpdateEventHandler( object sender ,
                                                               ComentarioViajeEventArgs e );
      public event ComentarioViajeUpdateEventHandler ComentarioViajeUpdated ;
      private void OnComentarioViajeUpdated( ComentarioViajeEventArgs e )
      {
         if ( ( this.ComentarioViajeUpdated != null ) )
         {
            this.ComentarioViajeUpdated( this, e) ;
         }
      }

      public event ComentarioViajeUpdateEventHandler ComentarioViajeUpdating ;
      private void OnComentarioViajeUpdating( ComentarioViajeEventArgs e )
      {
         if ( ( this.ComentarioViajeUpdating != null ) )
         {
            this.ComentarioViajeUpdating( this, e) ;
         }
      }

      public class ComentarioViajeEventArgs : EventArgs
      {
         private System.Data.StatementType m_statementType ;
         private ComentarioViajeDataSet.ComentarioViajeRow m_dataRow ;
         public ComentarioViajeEventArgs( ComentarioViajeDataSet.ComentarioViajeRow row ,
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

         public ComentarioViajeDataSet.ComentarioViajeRow Row
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
      public class ComentarioViajeNotFoundException : Deklarit.DataNotFoundException
      {
         public ComentarioViajeNotFoundException( )
         {
         }

         public ComentarioViajeNotFoundException( string message ) : base(message)
         {
         }

         public ComentarioViajeNotFoundException( string message ,
                                                  Exception inner ) : base(message, inner)
         {
         }

         protected ComentarioViajeNotFoundException( SerializationInfo info ,
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
      public class ComentarioViajeDataLockedException : Deklarit.DataLockedException
      {
         public ComentarioViajeDataLockedException( )
         {
         }

         public ComentarioViajeDataLockedException( string message ) : base(message)
         {
         }

         public ComentarioViajeDataLockedException( string message ,
                                                    Exception inner ) : base(message, inner)
         {
         }

         protected ComentarioViajeDataLockedException( SerializationInfo info ,
                                                       StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class ComentarioViajeDataChangedException : Deklarit.DataChangedException
      {
         public ComentarioViajeDataChangedException( )
         {
         }

         public ComentarioViajeDataChangedException( string message ) : base(message)
         {
         }

         public ComentarioViajeDataChangedException( string message ,
                                                     Exception inner ) : base(message, inner)
         {
         }

         protected ComentarioViajeDataChangedException( SerializationInfo info ,
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
         RcdFound13 = 0 ;
         scmdbuf = "" ;
         recordCount = 0 ;
         _Gxremove = false ;
         m__ComentarioLatitudOriginal = new object();
         m__ComentarioLongitudOriginal = new object();
         m__ComentarioTextoOriginal = new object();
         m__ComentarioImagenOriginal = new object();
         m__CVTrayectoIDOriginal = new object();
         m__ViajeIDOriginal = new object();
         _Condition = false ;
         IsModified = 0 ;
         m_WhereString = "" ;
         if ( ( this.Transaction == null ) )
         {
            this.Transaction = ((System.Data.IDbTransaction)(System.Threading.Thread.GetData(System.Threading.Thread.GetNamedDataSlot(DeklaritTransaction.TransactionSlotName)) ));
         }
      }

      private short RcdFound13 ;
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
      private ReadWriteCommand cmComentarioViajeSelect1 ;
      private IDataReader ComentarioViajeSelect1 ;
      private ReadWriteCommand cmComentarioViajeSelect2 ;
      private IDataReader ComentarioViajeSelect2 ;
      private ReadWriteCommand cmComentarioViajeSelect5 ;
      private IDataReader ComentarioViajeSelect5 ;
      private System.Data.StatementType Gx_mode ;
      private System.Data.StatementType sMode13 ;
      private object m__ComentarioLatitudOriginal ;
      private object m__ComentarioLongitudOriginal ;
      private object m__ComentarioTextoOriginal ;
      private object m__ComentarioImagenOriginal ;
      private object m__CVTrayectoIDOriginal ;
      private object m__ViajeIDOriginal ;
   }

   public class ComentarioViajeDataReader : System.IDisposable
   {
      public ComentarioViajeDataReader( )
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
      ///   Gets or sets the Transaction object to be used  by  ComentarioViajeDataReaderDeklarit
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
         cmComentarioViajeSelect6 = connDefault.GetCommand("SELECT TM1.[ComentarioViajeID], TM1.[ComentarioLatitud], TM1.[ComentarioLongitud], TM1.[ComentarioTexto], TM1.[ComentarioImagen], TM1.[CVTrayectoID], TM1.[ViajeID] FROM [ComentarioViaje] TM1 WITH (NOLOCK) ORDER BY TM1.[ComentarioViajeID] ", false) ;
         ComentarioViajeSelect6 = cmComentarioViajeSelect6.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return ComentarioViajeSelect6 ;
      }

      public IDataReader OpenByComentarioViajeID( int comentarioViajeID )
      {
         init_reader( ) ;
         m_Closed = false ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmComentarioViajeSelect6 = connDefault.GetCommand("SELECT TM1.[ComentarioViajeID], TM1.[ComentarioLatitud], TM1.[ComentarioLongitud], TM1.[ComentarioTexto], TM1.[ComentarioImagen], TM1.[CVTrayectoID], TM1.[ViajeID] FROM [ComentarioViaje] TM1 WITH (NOLOCK) WHERE TM1.[ComentarioViajeID] = @ComentarioViajeID ORDER BY TM1.[ComentarioViajeID] ", false) ;
         if ( ( cmComentarioViajeSelect6.IDbCommand.Parameters.Count == 0 ) )
         {
            cmComentarioViajeSelect6.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ComentarioViajeID", System.Data.DbType.Int32));
         }
         cmComentarioViajeSelect6.SetParameter(0, comentarioViajeID);
         ComentarioViajeSelect6 = cmComentarioViajeSelect6.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return ComentarioViajeSelect6 ;
      }

      public IDataReader OpenByViajeID( long viajeID )
      {
         init_reader( ) ;
         m_Closed = false ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmComentarioViajeSelect6 = connDefault.GetCommand("SELECT TM1.[ComentarioViajeID], TM1.[ComentarioLatitud], TM1.[ComentarioLongitud], TM1.[ComentarioTexto], TM1.[ComentarioImagen], TM1.[CVTrayectoID], TM1.[ViajeID] FROM [ComentarioViaje] TM1 WITH (NOLOCK) WHERE TM1.[ViajeID] = @ViajeID ORDER BY TM1.[ComentarioViajeID] ", false) ;
         if ( ( cmComentarioViajeSelect6.IDbCommand.Parameters.Count == 0 ) )
         {
            cmComentarioViajeSelect6.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
         }
         cmComentarioViajeSelect6.SetParameter(0, viajeID);
         ComentarioViajeSelect6 = cmComentarioViajeSelect6.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return ComentarioViajeSelect6 ;
      }

      public int DeleteByViajeID( long viajeID )
      {
         init_reader( ) ;
         int intCount = 0 ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmComentarioViajeDelete2 = connDefault.GetCommand("DELETE FROM [ComentarioViaje]  WHERE [ViajeID] = @ViajeID", false) ;
         if ( ( cmComentarioViajeDelete2.IDbCommand.Parameters.Count == 0 ) )
         {
            cmComentarioViajeDelete2.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
         }
         // Using cursor ComentarioViajeDelete2
         cmComentarioViajeDelete2.SetParameter(0, viajeID);
         intCount = cmComentarioViajeDelete2.ExecuteStmt() ;
         return intCount ;
      }

      public void Dispose( )
      {
         if ( ! m_Disposed )
         {
            m_Disposed = true ;
            try
            {
               if ( ! m_Closed && ( ComentarioViajeSelect6 != null ) )
               {
                  m_Closed = true ;
                  ComentarioViajeSelect6.Close();
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
      private ReadWriteCommand cmComentarioViajeSelect6 ;
      private IDataReader ComentarioViajeSelect6 ;
      private ReadWriteCommand cmComentarioViajeDelete2 ;
   }

}
