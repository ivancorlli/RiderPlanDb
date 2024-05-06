
//               File: TrayectoTipoDetalleDataAdapter
//        Description: TipoDetalle
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
   public partial class TrayectoTipoDetalleDataAdapter : System.Data.IDataAdapter, ITrayectoTipoDetalleDataAdapter
   {
      private TrayectoTipoDetalleDataSet TrayectoTipoDetalleSet ;
      private IDbTransaction daCurrentTransaction ;
      private TrayectoTipoDetalleDataSet.TrayectoTipoDetalleRow rowTrayectoTipoDetalle ;
      public TrayectoTipoDetalleDataAdapter( )
      {
      }

      private void InitializeMembers( )
      {
         TrayectoTipoDetalleSet = new TrayectoTipoDetalleDataSet() ;
         this.Initialize( ) ;
         dsDefault = new DataStore( new SqlServer2005Handler( ), "System.Data.SqlClient", Raiderplan1.Configuration.ConnectionString, DeklaritTransaction.TransactionSlotName) ;
      }

      ///  <summary>
      ///   Gets or sets the Transaction object to be used  by  TrayectoTipoDetalleDataAdapterclasses
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
      ///   (2) Fills the specified Dataset with the record matching TrayectoTipoDetalleID field(s)
      ///    of the given IDataRecord
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="dataRecord">Data Record</param>
      public virtual int Fill( TrayectoTipoDetalleDataSet dataSet ,
                               IDataRecord dataRecord )
      {
         return Fill(dataSet, ((int)(dataRecord["TrayectoTipoDetalleID"]))) ;
      }

      ///  <summary>
      ///   (3) Fills the specified Dataset with the record matching TrayectoTipoDetalleID field(s)
      ///    of the given DataRow
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="dataRecord">Data Row</param>
      public virtual int Fill( TrayectoTipoDetalleDataSet dataSet ,
                               DataRow dataRecord )
      {
         return Fill(dataSet, ((int)(dataRecord["TrayectoTipoDetalleID"]))) ;
      }

      ///  <summary>
      ///   (4) Fills the specified Dataset with the record matching TrayectoTipoDetalleID, if
      ///    the record is not found , throws an exception.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="trayectoTipoDetalleID">Trayecto Tipo Detalle ID</param>
      public virtual int Fill( TrayectoTipoDetalleDataSet dataSet ,
                               int trayectoTipoDetalleID )
      {
         if ( ! FillByTrayectoTipoDetalleID( dataSet, trayectoTipoDetalleID) )
         {
            throw new TrayectoTipoDetalleNotFoundException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("inex"), new   object[]  {resourceManagerTables.GetString("TrayectoTipoDetalle")})) ;
         }
         return 0 ;
      }


      ///  <summary>
      ///   (5) Fills the specified Dataset with the record matching TrayectoTipoDetalleID in
      ///    the fillDataParameters array, if the array is null, it fills the Dataset loading
      ///    all records in the table.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Fill( TrayectoTipoDetalleDataSet dataSet )
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
               TrayectoTipoDetalleSet = dataSet ;
               LoadChildTrayectotipodetalle( 0, -1) ;
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
      ///   (6) Fills the specified dataset filtered by TrayectoTipoDetalleIDfield(s).
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="trayectoTipoDetalleID">Trayecto Tipo Detalle ID</param>
      public virtual bool FillByTrayectoTipoDetalleID( TrayectoTipoDetalleDataSet dataSet ,
                                                       int trayectoTipoDetalleID )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         TrayectoTipoDetalleSet = dataSet ;
         rowTrayectoTipoDetalle = TrayectoTipoDetalleSet.TrayectoTipoDetalle.NewTrayectoTipoDetalleRow() ;
         rowTrayectoTipoDetalle.TrayectoTipoDetalleID = trayectoTipoDetalleID ;
         try
         {
            LoadByTrayectoTipoDetalleID( 0, -1) ;
            dataSet.AcceptChanges( ) ;
         }
         finally
         {
            this.Cleanup();
         }
         if ( ( RcdFound12 == 0 ) )
         {
            return false ;
         }
         return true ;
      }


      ///  <summary>
      ///   (8) Fills the specified dataset with the record matching TrayectoTipoDetalleID in
      ///    the the fillDataParameters array, if the array is null, it fills the Dataset loading
      ///    all records in the table.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Fill( DataSet dataSet )
      {
         TrayectoTipoDetalleSet = dataSet as TrayectoTipoDetalleDataSet ;
         if ( ( TrayectoTipoDetalleSet != null ) )
         {
            return Fill( TrayectoTipoDetalleSet) ;
         }
         else
         {
            TrayectoTipoDetalleSet = new TrayectoTipoDetalleDataSet() ;
            Fill( TrayectoTipoDetalleSet) ;
            dataSet.Merge( TrayectoTipoDetalleSet) ;
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
      public virtual int FillPage( TrayectoTipoDetalleDataSet dataSet ,
                                   int startRow ,
                                   int maxRows )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         TrayectoTipoDetalleSet = dataSet ;
         try
         {
            LoadChildTrayectotipodetalle( startRow, maxRows) ;
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
         cmTrayectoTipoDetalleSelect1 = connDefault.GetCommand("SELECT COUNT(*) FROM [TrayectoTipoDetalle] WITH (NOLOCK) ", false) ;
         TrayectoTipoDetalleSelect1 = cmTrayectoTipoDetalleSelect1.FetchData() ;
         recordCount = ( ( TrayectoTipoDetalleSelect1.IsDBNull(0) )  ? (int)(0) : TrayectoTipoDetalleSelect1.GetInt32(0) ) ;
         TrayectoTipoDetalleSelect1.Close();
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
            DbParameter parm0TrayectoTipoDetalleID ;
            parm0TrayectoTipoDetalleID = factory.CreateParameter() ;
            parm0TrayectoTipoDetalleID.ParameterName = "TrayectoTipoDetalleID" ;
            parm0TrayectoTipoDetalleID.DbType = System.Data.DbType.Int32 ;
            fillDataParameters = new  DbParameter[]  {parm0TrayectoTipoDetalleID} ;
         }
         return fillDataParameters ;
      }

      private DbParameter[] fillDataParameters ;

      ///  <summary>
      ///   Inserts, Updates or Deletes records from the specified TrayectoTipoDetalleDataSet
      ///    object.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Update( DataSet dataSet )
      {
         InitializeMembers( ) ;
         TrayectoTipoDetalleSet = dataSet as TrayectoTipoDetalleDataSet ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         if ( ( TrayectoTipoDetalleSet != null ) )
         {
            try
            {
               connDefault.BeginTransaction();
               foreach( TrayectoTipoDetalleDataSet.TrayectoTipoDetalleRow row in TrayectoTipoDetalleSet.TrayectoTipoDetalle )
               {
                  rowTrayectoTipoDetalle = row ;
                  if ( Deklarit.Data.Helpers.IsRowChanged(rowTrayectoTipoDetalle) )
                  {
                     ReadRowTrayectotipodetalle( ) ;
                     if ( ( rowTrayectoTipoDetalle.RowState == System.Data.DataRowState.Added ) )
                     {
                        InsertTrayectotipodetalle( ) ;
                     }
                     else
                     {
                        if ( _Gxremove )
                        {
                           Delete( ) ;
                        }
                        else
                        {
                           UpdateTrayectotipodetalle( ) ;
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

      private void LoadRowTrayectotipodetalle( )
      {
         AddRowTrayectotipodetalle( ) ;
      }

      private void ReadRowTrayectotipodetalle( )
      {
         Gx_mode = Deklarit.Utils.Mode.FromRowState(rowTrayectoTipoDetalle.RowState) ;
         if ( ( rowTrayectoTipoDetalle.RowState != System.Data.DataRowState.Added ) )
         {
            m__TTipoDetalleCategoriaOriginal = rowTrayectoTipoDetalle["TTipoDetalleCategoria", System.Data.DataRowVersion.Original] ;
            m__TTipoDetalleIconoOriginal = rowTrayectoTipoDetalle["TTipoDetalleIcono", System.Data.DataRowVersion.Original] ;
         }
         else
         {
            m__TTipoDetalleCategoriaOriginal = rowTrayectoTipoDetalle["TTipoDetalleCategoria"] ;
            m__TTipoDetalleIconoOriginal = rowTrayectoTipoDetalle["TTipoDetalleIcono"] ;
         }
         _Gxremove = (bool)((rowTrayectoTipoDetalle.RowState==System.Data.DataRowState.Deleted)) ;
         if ( _Gxremove )
         {
            rowTrayectoTipoDetalle = ((TrayectoTipoDetalleDataSet.TrayectoTipoDetalleRow)(Deklarit.Utils.DataSetUtil.CloneOriginalDataRow(rowTrayectoTipoDetalle)));
         }
      }

      private void GetByPrimaryKey( )
      {
          IDataReader TrayectoTipoDetalleSelect2 ;
          ReadWriteCommand cmTrayectoTipoDetalleSelect2 ;
         cmTrayectoTipoDetalleSelect2 = connDefault.GetCommand("SELECT [TrayectoTipoDetalleID], [TTipoDetalleCategoria], [TTipoDetalleIcono] FROM [TrayectoTipoDetalle] WITH (NOLOCK) WHERE [TrayectoTipoDetalleID] = @TrayectoTipoDetalleID ", false) ;
         if ( ( cmTrayectoTipoDetalleSelect2.IDbCommand.Parameters.Count == 0 ) )
         {
            cmTrayectoTipoDetalleSelect2.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoTipoDetalleID", System.Data.DbType.Int32));
         }
         cmTrayectoTipoDetalleSelect2.SetParameter(0, rowTrayectoTipoDetalle["TrayectoTipoDetalleID"]);
         TrayectoTipoDetalleSelect2 = cmTrayectoTipoDetalleSelect2.FetchData() ;
         if ( cmTrayectoTipoDetalleSelect2.HasMoreRows )
         {
            RcdFound12 = 1 ;
            rowTrayectoTipoDetalle["TrayectoTipoDetalleID"] = dsDefault.Db.GetInt32(TrayectoTipoDetalleSelect2, 0) ;
            rowTrayectoTipoDetalle["TTipoDetalleCategoria"] = dsDefault.Db.GetString(TrayectoTipoDetalleSelect2, 1) ;
            rowTrayectoTipoDetalle["TTipoDetalleIcono"] = dsDefault.Db.GetString(TrayectoTipoDetalleSelect2, 2) ;
            sMode12 = Gx_mode ;
            Gx_mode = Mode.Display ;
            Gx_mode = sMode12 ;
         }
         else
         {
            RcdFound12 = 0 ;
         }
         TrayectoTipoDetalleSelect2.Close();
      }

      private void CheckOptimisticConcurrencyTrayectotipodetalle( )
      {
          IDataReader TrayectoTipoDetalleSelect3 ;
          ReadWriteCommand cmTrayectoTipoDetalleSelect3 ;
         if ( ( Gx_mode != Mode.Insert ) )
         {
            cmTrayectoTipoDetalleSelect3 = connDefault.GetCommand("SELECT [TrayectoTipoDetalleID], [TTipoDetalleCategoria], [TTipoDetalleIcono] FROM [TrayectoTipoDetalle] WITH (UPDLOCK) WHERE [TrayectoTipoDetalleID] = @TrayectoTipoDetalleID ", false) ;
            if ( ( cmTrayectoTipoDetalleSelect3.IDbCommand.Parameters.Count == 0 ) )
            {
               cmTrayectoTipoDetalleSelect3.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoTipoDetalleID", System.Data.DbType.Int32));
            }
            cmTrayectoTipoDetalleSelect3.SetParameter(0, rowTrayectoTipoDetalle["TrayectoTipoDetalleID"]);
            TrayectoTipoDetalleSelect3 = cmTrayectoTipoDetalleSelect3.FetchData() ;
            if ( cmTrayectoTipoDetalleSelect3.Locked )
            {
               TrayectoTipoDetalleSelect3.Close();
               throw new TrayectoTipoDetalleDataLockedException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("lock"), new   object[]  {resourceManagerTables.GetString("TrayectoTipoDetalle")})) ;
            }
            if ( !cmTrayectoTipoDetalleSelect3.HasMoreRows || ( ! StringUtil.ObjectStringEquals(m__TTipoDetalleCategoriaOriginal,dsDefault.Db.GetString(TrayectoTipoDetalleSelect3, 1)) ) || ( ! StringUtil.ObjectStringEquals(m__TTipoDetalleIconoOriginal,dsDefault.Db.GetString(TrayectoTipoDetalleSelect3, 2)) ) )
            {
               TrayectoTipoDetalleSelect3.Close();
               throw new TrayectoTipoDetalleDataChangedException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("waschg"), new   object[]  {resourceManagerTables.GetString("TrayectoTipoDetalle")})) ;
            }
            TrayectoTipoDetalleSelect3.Close();
         }
      }

      private void InsertTrayectotipodetalle( )
      {
          ReadWriteCommand cmTrayectoTipoDetalleInsert1 ;
         CheckOptimisticConcurrencyTrayectotipodetalle( ) ;
         AfterConfirmTrayectotipodetalle( ) ;
         cmTrayectoTipoDetalleInsert1 = connDefault.GetCommand("INSERT INTO [TrayectoTipoDetalle] ([TrayectoTipoDetalleID], [TTipoDetalleCategoria], [TTipoDetalleIcono]) VALUES (@TrayectoTipoDetalleID, @TTipoDetalleCategoria, @TTipoDetalleIcono)", false) ;
         if ( ( cmTrayectoTipoDetalleInsert1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmTrayectoTipoDetalleInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoTipoDetalleID", System.Data.DbType.Int32));
            cmTrayectoTipoDetalleInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TTipoDetalleCategoria", System.Data.DbType.AnsiString,60));
            cmTrayectoTipoDetalleInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TTipoDetalleIcono", System.Data.DbType.AnsiString,50));
         }
         cmTrayectoTipoDetalleInsert1.ErrorMask = cmTrayectoTipoDetalleInsert1.ErrorMask  |  ErrorMask.DuplicateKeyError;
         // Using cursor TrayectoTipoDetalleInsert1
         cmTrayectoTipoDetalleInsert1.SetParameter(0, rowTrayectoTipoDetalle["TrayectoTipoDetalleID"]);
         cmTrayectoTipoDetalleInsert1.SetParameter(1, rowTrayectoTipoDetalle["TTipoDetalleCategoria"]);
         cmTrayectoTipoDetalleInsert1.SetParameter(2, rowTrayectoTipoDetalle["TTipoDetalleIcono"]);
         cmTrayectoTipoDetalleInsert1.ExecuteStmt();
         if ( cmTrayectoTipoDetalleInsert1.DupKey )
         {
            throw new TrayectoTipoDetalleDuplicateKeyException( resourceManager.GetString("noupdate")) ;
         }
         // Start of After( Insert) rules
         // End of After( Insert) rules
         OnTrayectoTipoDetalleUpdated( new TrayectoTipoDetalleEventArgs( rowTrayectoTipoDetalle, Mode.Insert)) ;
         // Save values for previous() function.
         EndLevelTrayectotipodetalle( ) ;
      }

      private void UpdateTrayectotipodetalle( )
      {
          ReadWriteCommand cmTrayectoTipoDetalleUpdate1 ;
         CheckOptimisticConcurrencyTrayectotipodetalle( ) ;
         AfterConfirmTrayectotipodetalle( ) ;
         cmTrayectoTipoDetalleUpdate1 = connDefault.GetCommand("UPDATE [TrayectoTipoDetalle] SET [TTipoDetalleCategoria]=@TTipoDetalleCategoria, [TTipoDetalleIcono]=@TTipoDetalleIcono  WHERE [TrayectoTipoDetalleID] = @TrayectoTipoDetalleID", false) ;
         if ( ( cmTrayectoTipoDetalleUpdate1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmTrayectoTipoDetalleUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TTipoDetalleCategoria", System.Data.DbType.AnsiString,60));
            cmTrayectoTipoDetalleUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TTipoDetalleIcono", System.Data.DbType.AnsiString,50));
            cmTrayectoTipoDetalleUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoTipoDetalleID", System.Data.DbType.Int32));
         }
         // Using cursor TrayectoTipoDetalleUpdate1
         cmTrayectoTipoDetalleUpdate1.SetParameter(0, rowTrayectoTipoDetalle["TTipoDetalleCategoria"]);
         cmTrayectoTipoDetalleUpdate1.SetParameter(1, rowTrayectoTipoDetalle["TTipoDetalleIcono"]);
         cmTrayectoTipoDetalleUpdate1.SetParameter(2, rowTrayectoTipoDetalle["TrayectoTipoDetalleID"]);
         cmTrayectoTipoDetalleUpdate1.ExecuteStmt();
         // Start of After( update) rules
         // End of After( update) rules
         OnTrayectoTipoDetalleUpdated( new TrayectoTipoDetalleEventArgs( rowTrayectoTipoDetalle, Mode.Update)) ;
         EndLevelTrayectotipodetalle( ) ;
      }

      private void Delete( )
      {
          ReadWriteCommand cmTrayectoTipoDetalleDelete1 ;
         Gx_mode = Mode.Delete ;
         CheckOptimisticConcurrencyTrayectotipodetalle( ) ;
         // No cascading delete specified.
         AfterConfirmTrayectotipodetalle( ) ;
         cmTrayectoTipoDetalleDelete1 = connDefault.GetCommand("DELETE FROM [TrayectoTipoDetalle]  WHERE [TrayectoTipoDetalleID] = @TrayectoTipoDetalleID", false) ;
         if ( ( cmTrayectoTipoDetalleDelete1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmTrayectoTipoDetalleDelete1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoTipoDetalleID", System.Data.DbType.Int32));
         }
         cmTrayectoTipoDetalleDelete1.ErrorMask = cmTrayectoTipoDetalleDelete1.ErrorMask  |  ErrorMask.ForeignKeyError;
         // Using cursor TrayectoTipoDetalleDelete1
         cmTrayectoTipoDetalleDelete1.SetParameter(0, rowTrayectoTipoDetalle["TrayectoTipoDetalleID"]);
         cmTrayectoTipoDetalleDelete1.ExecuteStmt();
         if ( cmTrayectoTipoDetalleDelete1.ForeignKeyError )
         {
            CheckDeleteErrorsTrayectotipodetalle( ) ;
         }
         // Start of After( delete) rules
         // End of After( delete) rules
         OnTrayectoTipoDetalleUpdated( new TrayectoTipoDetalleEventArgs( rowTrayectoTipoDetalle, Mode.Delete)) ;
         rowTrayectoTipoDetalle.Delete( ) ;
         sMode12 = Gx_mode ;
         Gx_mode = Mode.Delete ;
         EndLevelTrayectotipodetalle( ) ;
         Gx_mode = sMode12 ;
      }

      private void CheckDeleteErrorsTrayectotipodetalle( )
      {
          IDataReader TrayectoViajeTrayectoSelect1 ;
          ReadWriteCommand cmTrayectoViajeTrayectoSelect1 ;
         cmTrayectoViajeTrayectoSelect1 = connDefault.GetCommand("SELECT TOP 1 [TrayectoViajeID], [TrayectoDetalleID] FROM [TrayectoViajeTrayecto] WITH (NOLOCK) WHERE [TrayectoTipoDetalleID] = @TrayectoTipoDetalleID ", false) ;
         if ( ( cmTrayectoViajeTrayectoSelect1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmTrayectoViajeTrayectoSelect1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoTipoDetalleID", System.Data.DbType.Int32));
         }
         cmTrayectoViajeTrayectoSelect1.SetParameter(0, rowTrayectoTipoDetalle["TrayectoTipoDetalleID"]);
         TrayectoViajeTrayectoSelect1 = cmTrayectoViajeTrayectoSelect1.FetchData() ;
         if ( cmTrayectoViajeTrayectoSelect1.HasMoreRows )
         {
            TrayectoViajeTrayectoSelect1.Close();
            throw new TrayectoViajeTrayectoInvalidDeleteException( string.Format(resourceManager.GetString("del"), new   object[]  {"Trayecto"})) ;
         }
         TrayectoViajeTrayectoSelect1.Close();
      }

      private void EndLevelTrayectotipodetalle( )
      {
         // Execute 'After Trn' event if defined.
         IsModified = 0 ;
      }

      private void ScanByTrayectoTipoDetalleID( int startRow ,
                                                int maxRows )
      {
         m_WhereString = " WHERE TM1.[TrayectoTipoDetalleID] = @TrayectoTipoDetalleID" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString12 + "  FROM [TrayectoTipoDetalle] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[TrayectoTipoDetalleID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString12 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[TrayectoTipoDetalleID] ) AS DK_PAGENUM   FROM [TrayectoTipoDetalle] TM1 WITH (NOLOCK) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString12 + " FROM [TrayectoTipoDetalle] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[TrayectoTipoDetalleID] " ;
         }
         cmTrayectoTipoDetalleSelect4 = connDefault.GetCommand(scmdbuf, false) ;
         if ( ( cmTrayectoTipoDetalleSelect4.IDbCommand.Parameters.Count == 0 ) )
         {
            cmTrayectoTipoDetalleSelect4.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoTipoDetalleID", System.Data.DbType.Int32));
         }
         cmTrayectoTipoDetalleSelect4.SetParameter(0, rowTrayectoTipoDetalle["TrayectoTipoDetalleID"]);
         TrayectoTipoDetalleSelect4 = cmTrayectoTipoDetalleSelect4.FetchData() ;
         RcdFound12 = 0 ;
         ScanLoadTrayectotipodetalle( ) ;
         LoadDataTrayectotipodetalle( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanStartTrayectotipodetalle( int startRow ,
                                                 int maxRows )
      {
         m_WhereString = "" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString12 + "  FROM [TrayectoTipoDetalle] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[TrayectoTipoDetalleID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString12 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[TrayectoTipoDetalleID] ) AS DK_PAGENUM   FROM [TrayectoTipoDetalle] TM1 WITH (NOLOCK) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString12 + " FROM [TrayectoTipoDetalle] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[TrayectoTipoDetalleID] " ;
         }
         cmTrayectoTipoDetalleSelect4 = connDefault.GetCommand(scmdbuf, false) ;
         TrayectoTipoDetalleSelect4 = cmTrayectoTipoDetalleSelect4.FetchData() ;
         RcdFound12 = 0 ;
         ScanLoadTrayectotipodetalle( ) ;
         LoadDataTrayectotipodetalle( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanNextTrayectotipodetalle( )
      {
         cmTrayectoTipoDetalleSelect4.HasMoreRows = TrayectoTipoDetalleSelect4.Read() ;
         RcdFound12 = 0 ;
         ScanLoadTrayectotipodetalle( ) ;
      }

      private void ScanLoadTrayectotipodetalle( )
      {
         Gx_mode = Mode.Display ;
         if ( cmTrayectoTipoDetalleSelect4.HasMoreRows )
         {
            RcdFound12 = 1 ;
            rowTrayectoTipoDetalle["TrayectoTipoDetalleID"] = dsDefault.Db.GetInt32(TrayectoTipoDetalleSelect4, 0) ;
            rowTrayectoTipoDetalle["TTipoDetalleCategoria"] = dsDefault.Db.GetString(TrayectoTipoDetalleSelect4, 1) ;
            rowTrayectoTipoDetalle["TTipoDetalleIcono"] = dsDefault.Db.GetString(TrayectoTipoDetalleSelect4, 2) ;
         }
      }

      private void ScanEndTrayectotipodetalle( )
      {
         TrayectoTipoDetalleSelect4.Close();
      }

      private void AfterConfirmTrayectotipodetalle( )
      {
         // After Confirm Rules
         OnTrayectoTipoDetalleUpdating( new TrayectoTipoDetalleEventArgs( rowTrayectoTipoDetalle, Gx_mode)) ;
      }

      private void CreateNewRowTrayectotipodetalle( )
      {
         rowTrayectoTipoDetalle = TrayectoTipoDetalleSet.TrayectoTipoDetalle.NewTrayectoTipoDetalleRow() ;
      }

      private void LoadChildTrayectotipodetalle( int startRow ,
                                                 int maxRows )
      {
         CreateNewRowTrayectotipodetalle( ) ;
         bool tmpConstraintState = TrayectoTipoDetalleSet.EnforceConstraints ;
         TrayectoTipoDetalleSet.TrayectoTipoDetalle.BeginLoadData( ) ;
         ScanStartTrayectotipodetalle( startRow, maxRows) ;
         TrayectoTipoDetalleSet.TrayectoTipoDetalle.EndLoadData( ) ;
         this.TrayectoTipoDetalleSet.EnforceConstraints = tmpConstraintState ;
      }

      private void LoadDataTrayectotipodetalle( int maxRows )
      {
         int loadedRows = 0 ;
         if ( ( RcdFound12 != 0 ) )
         {
            ScanLoadTrayectotipodetalle( ) ;
            while ( ( RcdFound12 != 0 ) && ( loadedRows != maxRows ) )
            {
               loadedRows++ ;
               LoadRowTrayectotipodetalle( ) ;
               CreateNewRowTrayectotipodetalle( ) ;
               ScanNextTrayectotipodetalle( ) ;
            }
         }
         if ( ( loadedRows > 0 ) )
         {
            RcdFound12 = 1 ;
         }
         ScanEndTrayectotipodetalle( ) ;
         if ( ( TrayectoTipoDetalleSet.TrayectoTipoDetalle.Count > 0 ) )
         {
            rowTrayectoTipoDetalle = TrayectoTipoDetalleSet.TrayectoTipoDetalle[TrayectoTipoDetalleSet.TrayectoTipoDetalle.Count -1] ;
         }
      }

      private void LoadByTrayectoTipoDetalleID( int startRow ,
                                                int maxRows )
      {
         bool tmpConstraintState = TrayectoTipoDetalleSet.EnforceConstraints ;
         TrayectoTipoDetalleSet.TrayectoTipoDetalle.BeginLoadData( ) ;
         ScanByTrayectoTipoDetalleID( startRow, maxRows) ;
         TrayectoTipoDetalleSet.TrayectoTipoDetalle.EndLoadData( ) ;
         this.TrayectoTipoDetalleSet.EnforceConstraints = tmpConstraintState ;
         if ( ( TrayectoTipoDetalleSet.TrayectoTipoDetalle.Count > 0 ) )
         {
            rowTrayectoTipoDetalle = TrayectoTipoDetalleSet.TrayectoTipoDetalle[TrayectoTipoDetalleSet.TrayectoTipoDetalle.Count -1] ;
         }
      }

      private void AddRowTrayectotipodetalle( )
      {
         TrayectoTipoDetalleSet.TrayectoTipoDetalle.AddTrayectoTipoDetalleRow( rowTrayectoTipoDetalle) ;
      }

      private readonly string m_SelectString12 = "TM1.[TrayectoTipoDetalleID], TM1.[TTipoDetalleCategoria], TM1.[TTipoDetalleIcono]" ;


      public delegate  void TrayectoTipoDetalleUpdateEventHandler( object sender ,
                                                                   TrayectoTipoDetalleEventArgs e );
      public event TrayectoTipoDetalleUpdateEventHandler TrayectoTipoDetalleUpdated ;
      private void OnTrayectoTipoDetalleUpdated( TrayectoTipoDetalleEventArgs e )
      {
         if ( ( this.TrayectoTipoDetalleUpdated != null ) )
         {
            this.TrayectoTipoDetalleUpdated( this, e) ;
         }
      }

      public event TrayectoTipoDetalleUpdateEventHandler TrayectoTipoDetalleUpdating ;
      private void OnTrayectoTipoDetalleUpdating( TrayectoTipoDetalleEventArgs e )
      {
         if ( ( this.TrayectoTipoDetalleUpdating != null ) )
         {
            this.TrayectoTipoDetalleUpdating( this, e) ;
         }
      }

      public class TrayectoTipoDetalleEventArgs : EventArgs
      {
         private System.Data.StatementType m_statementType ;
         private TrayectoTipoDetalleDataSet.TrayectoTipoDetalleRow m_dataRow ;
         public TrayectoTipoDetalleEventArgs( TrayectoTipoDetalleDataSet.TrayectoTipoDetalleRow row ,
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

         public TrayectoTipoDetalleDataSet.TrayectoTipoDetalleRow Row
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
      public class TrayectoTipoDetalleNotFoundException : Deklarit.DataNotFoundException
      {
         public TrayectoTipoDetalleNotFoundException( )
         {
         }

         public TrayectoTipoDetalleNotFoundException( string message ) : base(message)
         {
         }

         public TrayectoTipoDetalleNotFoundException( string message ,
                                                      Exception inner ) : base(message, inner)
         {
         }

         protected TrayectoTipoDetalleNotFoundException( SerializationInfo info ,
                                                         StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class TrayectoTipoDetalleDataLockedException : Deklarit.DataLockedException
      {
         public TrayectoTipoDetalleDataLockedException( )
         {
         }

         public TrayectoTipoDetalleDataLockedException( string message ) : base(message)
         {
         }

         public TrayectoTipoDetalleDataLockedException( string message ,
                                                        Exception inner ) : base(message, inner)
         {
         }

         protected TrayectoTipoDetalleDataLockedException( SerializationInfo info ,
                                                           StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class TrayectoTipoDetalleDataChangedException : Deklarit.DataChangedException
      {
         public TrayectoTipoDetalleDataChangedException( )
         {
         }

         public TrayectoTipoDetalleDataChangedException( string message ) : base(message)
         {
         }

         public TrayectoTipoDetalleDataChangedException( string message ,
                                                         Exception inner ) : base(message, inner)
         {
         }

         protected TrayectoTipoDetalleDataChangedException( SerializationInfo info ,
                                                            StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class TrayectoTipoDetalleDuplicateKeyException : Deklarit.DuplicateKeyException
      {
         public TrayectoTipoDetalleDuplicateKeyException( )
         {
         }

         public TrayectoTipoDetalleDuplicateKeyException( string message ) : base(message)
         {
         }

         public TrayectoTipoDetalleDuplicateKeyException( string message ,
                                                          Exception inner ) : base(message, inner)
         {
         }

         protected TrayectoTipoDetalleDuplicateKeyException( SerializationInfo info ,
                                                             StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class TrayectoViajeTrayectoInvalidDeleteException : Deklarit.InvalidDeleteException
      {
         public TrayectoViajeTrayectoInvalidDeleteException( )
         {
         }

         public TrayectoViajeTrayectoInvalidDeleteException( string message ) : base(message)
         {
         }

         public TrayectoViajeTrayectoInvalidDeleteException( string message ,
                                                             Exception inner ) : base(message, inner)
         {
         }

         protected TrayectoViajeTrayectoInvalidDeleteException( SerializationInfo info ,
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
         RcdFound12 = 0 ;
         scmdbuf = "" ;
         recordCount = 0 ;
         _Gxremove = false ;
         m__TTipoDetalleCategoriaOriginal = new object();
         m__TTipoDetalleIconoOriginal = new object();
         IsModified = 0 ;
         m_WhereString = "" ;
         if ( ( this.Transaction == null ) )
         {
            this.Transaction = ((System.Data.IDbTransaction)(System.Threading.Thread.GetData(System.Threading.Thread.GetNamedDataSlot(DeklaritTransaction.TransactionSlotName)) ));
         }
      }

      private short RcdFound12 ;
      private short IsModified ;
      private int recordCount ;
      private String scmdbuf ;
      private String m_WhereString ;
      private bool _Gxremove ;
      private DataStore dsDefault ;
      private System.Resources.ResourceManager resourceManager ;
      private System.Resources.ResourceManager resourceManagerTables ;
      private ReadWriteConnection connDefault ;
      private ReadWriteCommand cmTrayectoTipoDetalleSelect1 ;
      private IDataReader TrayectoTipoDetalleSelect1 ;
      private ReadWriteCommand cmTrayectoTipoDetalleSelect4 ;
      private IDataReader TrayectoTipoDetalleSelect4 ;
      private System.Data.StatementType Gx_mode ;
      private System.Data.StatementType sMode12 ;
      private object m__TTipoDetalleCategoriaOriginal ;
      private object m__TTipoDetalleIconoOriginal ;
   }

   public class TrayectoTipoDetalleDataReader : System.IDisposable
   {
      public TrayectoTipoDetalleDataReader( )
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
      ///   Gets or sets the Transaction object to be used  by  TrayectoTipoDetalleDataReaderDeklarit
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
         cmTrayectoTipoDetalleSelect5 = connDefault.GetCommand("SELECT TM1.[TrayectoTipoDetalleID], TM1.[TTipoDetalleCategoria], TM1.[TTipoDetalleIcono] FROM [TrayectoTipoDetalle] TM1 WITH (NOLOCK) ORDER BY TM1.[TrayectoTipoDetalleID] ", false) ;
         TrayectoTipoDetalleSelect5 = cmTrayectoTipoDetalleSelect5.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return TrayectoTipoDetalleSelect5 ;
      }

      public IDataReader OpenByTrayectoTipoDetalleID( int trayectoTipoDetalleID )
      {
         init_reader( ) ;
         m_Closed = false ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmTrayectoTipoDetalleSelect5 = connDefault.GetCommand("SELECT TM1.[TrayectoTipoDetalleID], TM1.[TTipoDetalleCategoria], TM1.[TTipoDetalleIcono] FROM [TrayectoTipoDetalle] TM1 WITH (NOLOCK) WHERE TM1.[TrayectoTipoDetalleID] = @TrayectoTipoDetalleID ORDER BY TM1.[TrayectoTipoDetalleID] ", false) ;
         if ( ( cmTrayectoTipoDetalleSelect5.IDbCommand.Parameters.Count == 0 ) )
         {
            cmTrayectoTipoDetalleSelect5.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoTipoDetalleID", System.Data.DbType.Int32));
         }
         cmTrayectoTipoDetalleSelect5.SetParameter(0, trayectoTipoDetalleID);
         TrayectoTipoDetalleSelect5 = cmTrayectoTipoDetalleSelect5.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return TrayectoTipoDetalleSelect5 ;
      }

      public void Dispose( )
      {
         if ( ! m_Disposed )
         {
            m_Disposed = true ;
            try
            {
               if ( ! m_Closed && ( TrayectoTipoDetalleSelect5 != null ) )
               {
                  m_Closed = true ;
                  TrayectoTipoDetalleSelect5.Close();
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
      private ReadWriteCommand cmTrayectoTipoDetalleSelect5 ;
      private IDataReader TrayectoTipoDetalleSelect5 ;
   }

}
