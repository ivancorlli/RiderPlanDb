
//               File: ProvinciaDataAdapter
//        Description: Provincia
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
   public partial class ProvinciaDataAdapter : System.Data.IDataAdapter, IProvinciaDataAdapter
   {
      private ProvinciaDataSet ProvinciaSet ;
      private IDbTransaction daCurrentTransaction ;
      private ProvinciaDataSet.ProvinciaRow rowProvincia ;
      public ProvinciaDataAdapter( )
      {
      }

      private void InitializeMembers( )
      {
         ProvinciaSet = new ProvinciaDataSet() ;
         this.Initialize( ) ;
         dsDefault = new DataStore( new SqlServer2005Handler( ), "System.Data.SqlClient", Raiderplan1.Configuration.ConnectionString, DeklaritTransaction.TransactionSlotName) ;
      }

      ///  <summary>
      ///   Gets or sets the Transaction object to be used  by  ProvinciaDataAdapterclasses to
      ///    commit changes to the Database.
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
      ///   (2) Fills the specified Dataset with the record matching ProvinciaID field(s) of
      ///    the given IDataRecord
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="dataRecord">Data Record</param>
      public virtual int Fill( ProvinciaDataSet dataSet ,
                               IDataRecord dataRecord )
      {
         return Fill(dataSet, ((int)(dataRecord["ProvinciaID"]))) ;
      }

      ///  <summary>
      ///   (3) Fills the specified Dataset with the record matching ProvinciaID field(s) of
      ///    the given DataRow
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="dataRecord">Data Row</param>
      public virtual int Fill( ProvinciaDataSet dataSet ,
                               DataRow dataRecord )
      {
         return Fill(dataSet, ((int)(dataRecord["ProvinciaID"]))) ;
      }

      ///  <summary>
      ///   (4) Fills the specified Dataset with the record matching ProvinciaID, if the record
      ///    is not found , throws an exception.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="provinciaID">Provincia ID</param>
      public virtual int Fill( ProvinciaDataSet dataSet ,
                               int provinciaID )
      {
         if ( ! FillByProvinciaID( dataSet, provinciaID) )
         {
            throw new ProvinciaNotFoundException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("inex"), new   object[]  {resourceManagerTables.GetString("Provincia")})) ;
         }
         return 0 ;
      }


      ///  <summary>
      ///   (5) Fills the specified Dataset with the record matching ProvinciaID in the fillDataParameters
      ///    array, if the array is null, it fills the Dataset loading all records in the table.
      ///
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Fill( ProvinciaDataSet dataSet )
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
               ProvinciaSet = dataSet ;
               LoadChildProvincia( 0, -1) ;
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
      ///   (6) Fills the specified dataset filtered by ProvinciaIDfield(s).
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="provinciaID">Provincia ID</param>
      public virtual bool FillByProvinciaID( ProvinciaDataSet dataSet ,
                                             int provinciaID )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         ProvinciaSet = dataSet ;
         rowProvincia = ProvinciaSet.Provincia.NewProvinciaRow() ;
         rowProvincia.ProvinciaID = provinciaID ;
         try
         {
            LoadByProvinciaID( 0, -1) ;
            dataSet.AcceptChanges( ) ;
         }
         finally
         {
            this.Cleanup();
         }
         if ( ( RcdFound6 == 0 ) )
         {
            return false ;
         }
         return true ;
      }


      ///  <summary>
      ///   (6) Fills the specified dataset filtered by PaisIDfield(s).
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="paisID">Pais ID</param>
      public virtual int FillByPaisID( ProvinciaDataSet dataSet ,
                                       int paisID )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         ProvinciaSet = dataSet ;
         rowProvincia = ProvinciaSet.Provincia.NewProvinciaRow() ;
         rowProvincia.PaisID = paisID ;
         try
         {
            LoadByPaisID( 0, -1) ;
            dataSet.AcceptChanges( ) ;
         }
         finally
         {
            this.Cleanup();
         }
         return 0 ;
      }


      ///  <summary>
      ///   (6) Fills a page of up to maxRows rows into the specified dataset filtered by PaisIDfield(s)starting
      ///    at startRow
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="paisID">Pais ID</param>
      ///  <param name="startRow">Starting row</param>
      ///  <param name="maxRows">Max number of rows to load</param>
      public virtual int FillPageByPaisID( ProvinciaDataSet dataSet ,
                                           int paisID ,
                                           int startRow ,
                                           int maxRows )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         ProvinciaSet = dataSet ;
         rowProvincia = ProvinciaSet.Provincia.NewProvinciaRow() ;
         rowProvincia.PaisID = paisID ;
         try
         {
            LoadByPaisID( startRow, maxRows) ;
            dataSet.AcceptChanges( ) ;
         }
         finally
         {
            this.Cleanup();
         }
         return 0 ;
      }


      ///  <summary>
      ///   (9) Gets the record count filtered by PaisIDfield(s).
      ///  </summary>
      ///  <param name="paisID">Pais ID</param>
      public virtual int GetRecordCountByPaisID( int paisID )
      {
         int m_Count ;
         try
         {
            InitializeMembers( ) ;
            m_Count = GetInternalRecordCountByPaisID( paisID ) ;
         }
         finally
         {
            this.Cleanup();
         }
         return m_Count ;
      }

      private int GetInternalRecordCountByPaisID( int paisID )
      {
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmProvinciaSelect1 = connDefault.GetCommand("SELECT COUNT(*) FROM [Provincia] WITH (NOLOCK) WHERE [PaisID] = @PaisID ", false) ;
         if ( ( cmProvinciaSelect1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmProvinciaSelect1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PaisID", System.Data.DbType.Int32));
         }
         cmProvinciaSelect1.SetParameter(0, paisID);
         ProvinciaSelect1 = cmProvinciaSelect1.FetchData() ;
         recordCount = ( ( ProvinciaSelect1.IsDBNull(0) )  ? (int)(0) : ProvinciaSelect1.GetInt32(0) ) ;
         ProvinciaSelect1.Close();
         return recordCount ;
      }

      ///  <summary>
      ///   (8) Fills the specified dataset with the record matching ProvinciaID in the the fillDataParameters
      ///    array, if the array is null, it fills the Dataset loading all records in the table.
      ///
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Fill( DataSet dataSet )
      {
         ProvinciaSet = dataSet as ProvinciaDataSet ;
         if ( ( ProvinciaSet != null ) )
         {
            return Fill( ProvinciaSet) ;
         }
         else
         {
            ProvinciaSet = new ProvinciaDataSet() ;
            Fill( ProvinciaSet) ;
            dataSet.Merge( ProvinciaSet) ;
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
      public virtual int FillPage( ProvinciaDataSet dataSet ,
                                   int startRow ,
                                   int maxRows )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         ProvinciaSet = dataSet ;
         try
         {
            LoadChildProvincia( startRow, maxRows) ;
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
         cmProvinciaSelect2 = connDefault.GetCommand("SELECT COUNT(*) FROM [Provincia] WITH (NOLOCK) ", false) ;
         ProvinciaSelect2 = cmProvinciaSelect2.FetchData() ;
         recordCount = ( ( ProvinciaSelect2.IsDBNull(0) )  ? (int)(0) : ProvinciaSelect2.GetInt32(0) ) ;
         ProvinciaSelect2.Close();
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
            DbParameter parm0ProvinciaID ;
            parm0ProvinciaID = factory.CreateParameter() ;
            parm0ProvinciaID.ParameterName = "ProvinciaID" ;
            parm0ProvinciaID.DbType = System.Data.DbType.Int32 ;
            fillDataParameters = new  DbParameter[]  {parm0ProvinciaID} ;
         }
         return fillDataParameters ;
      }

      private DbParameter[] fillDataParameters ;

      ///  <summary>
      ///   Inserts, Updates or Deletes records from the specified ProvinciaDataSet object.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Update( DataSet dataSet )
      {
         InitializeMembers( ) ;
         ProvinciaSet = dataSet as ProvinciaDataSet ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         if ( ( ProvinciaSet != null ) )
         {
            try
            {
               connDefault.BeginTransaction();
               foreach( ProvinciaDataSet.ProvinciaRow row in ProvinciaSet.Provincia )
               {
                  rowProvincia = row ;
                  if ( Deklarit.Data.Helpers.IsRowChanged(rowProvincia) )
                  {
                     ReadRowProvincia( ) ;
                     if ( ( rowProvincia.RowState == System.Data.DataRowState.Added ) )
                     {
                        InsertProvincia( ) ;
                     }
                     else
                     {
                        if ( _Gxremove )
                        {
                           Delete( ) ;
                        }
                        else
                        {
                           UpdateProvincia( ) ;
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

      private void LoadRowProvincia( )
      {
         AddRowProvincia( ) ;
      }

      private void ReadRowProvincia( )
      {
         Gx_mode = Deklarit.Utils.Mode.FromRowState(rowProvincia.RowState) ;
         if ( ( rowProvincia.RowState != System.Data.DataRowState.Added ) )
         {
            m__ProvinciaNombreOriginal = rowProvincia["ProvinciaNombre", System.Data.DataRowVersion.Original] ;
            m__PaisIDOriginal = rowProvincia["PaisID", System.Data.DataRowVersion.Original] ;
         }
         else
         {
            m__ProvinciaNombreOriginal = rowProvincia["ProvinciaNombre"] ;
            m__PaisIDOriginal = rowProvincia["PaisID"] ;
         }
         _Gxremove = (bool)((rowProvincia.RowState==System.Data.DataRowState.Deleted)) ;
         if ( _Gxremove )
         {
            rowProvincia = ((ProvinciaDataSet.ProvinciaRow)(Deklarit.Utils.DataSetUtil.CloneOriginalDataRow(rowProvincia)));
         }
      }

      private void LoadProvincia( )
      {
          IDataReader PaisSelect1 ;
          ReadWriteCommand cmPaisSelect1 ;
         cmPaisSelect1 = connDefault.GetCommand("SELECT [PaisNombre] FROM [Pais] WITH (NOLOCK) WHERE [PaisID] = @PaisID ", false) ;
         if ( ( cmPaisSelect1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmPaisSelect1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PaisID", System.Data.DbType.Int32));
         }
         cmPaisSelect1.SetParameter(0, rowProvincia["PaisID"]);
         PaisSelect1 = cmPaisSelect1.FetchData() ;
         if ( cmPaisSelect1.HasMoreRows )
         {
            rowProvincia["PaisNombre"] = dsDefault.Db.GetString(PaisSelect1, 0) ;
         }
         PaisSelect1.Close();
      }

      private void CheckExtendedTableProvincia( )
      {
          IDataReader PaisSelect2 ;
          ReadWriteCommand cmPaisSelect2 ;
         cmPaisSelect2 = connDefault.GetCommand("SELECT [PaisNombre] FROM [Pais] WITH (NOLOCK) WHERE [PaisID] = @PaisID ", false) ;
         if ( ( cmPaisSelect2.IDbCommand.Parameters.Count == 0 ) )
         {
            cmPaisSelect2.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PaisID", System.Data.DbType.Int32));
         }
         cmPaisSelect2.SetParameter(0, rowProvincia["PaisID"]);
         PaisSelect2 = cmPaisSelect2.FetchData() ;
         if ( !cmPaisSelect2.HasMoreRows )
         {
            PaisSelect2.Close();
            throw new PaisForeignKeyNotFoundException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("inex"), new   object[]  {resourceManagerTables.GetString("Pais")})) ;
         }
         rowProvincia["PaisNombre"] = dsDefault.Db.GetString(PaisSelect2, 0) ;
         PaisSelect2.Close();
      }

      private void GetByPrimaryKey( )
      {
          IDataReader ProvinciaSelect3 ;
          ReadWriteCommand cmProvinciaSelect3 ;
         cmProvinciaSelect3 = connDefault.GetCommand("SELECT [ProvinciaID], [ProvinciaNombre], [PaisID] FROM [Provincia] WITH (NOLOCK) WHERE [ProvinciaID] = @ProvinciaID ", false) ;
         if ( ( cmProvinciaSelect3.IDbCommand.Parameters.Count == 0 ) )
         {
            cmProvinciaSelect3.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ProvinciaID", System.Data.DbType.Int32));
         }
         cmProvinciaSelect3.SetParameter(0, rowProvincia["ProvinciaID"]);
         ProvinciaSelect3 = cmProvinciaSelect3.FetchData() ;
         if ( cmProvinciaSelect3.HasMoreRows )
         {
            RcdFound6 = 1 ;
            rowProvincia["ProvinciaID"] = dsDefault.Db.GetInt32(ProvinciaSelect3, 0) ;
            rowProvincia["ProvinciaNombre"] = dsDefault.Db.GetString(ProvinciaSelect3, 1) ;
            rowProvincia["PaisID"] = dsDefault.Db.GetInt32(ProvinciaSelect3, 2) ;
            sMode6 = Gx_mode ;
            Gx_mode = Mode.Display ;
            LoadProvincia( ) ;
            Gx_mode = sMode6 ;
         }
         else
         {
            RcdFound6 = 0 ;
         }
         ProvinciaSelect3.Close();
      }

      private void CheckOptimisticConcurrencyProvincia( )
      {
          IDataReader ProvinciaSelect4 ;
          ReadWriteCommand cmProvinciaSelect4 ;
         if ( ( Gx_mode != Mode.Insert ) )
         {
            cmProvinciaSelect4 = connDefault.GetCommand("SELECT [ProvinciaID], [ProvinciaNombre], [PaisID] FROM [Provincia] WITH (UPDLOCK) WHERE [ProvinciaID] = @ProvinciaID ", false) ;
            if ( ( cmProvinciaSelect4.IDbCommand.Parameters.Count == 0 ) )
            {
               cmProvinciaSelect4.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ProvinciaID", System.Data.DbType.Int32));
            }
            cmProvinciaSelect4.SetParameter(0, rowProvincia["ProvinciaID"]);
            ProvinciaSelect4 = cmProvinciaSelect4.FetchData() ;
            if ( cmProvinciaSelect4.Locked )
            {
               ProvinciaSelect4.Close();
               throw new ProvinciaDataLockedException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("lock"), new   object[]  {resourceManagerTables.GetString("Provincia")})) ;
            }
            if ( !cmProvinciaSelect4.HasMoreRows || ( ! StringUtil.ObjectStringEquals(m__ProvinciaNombreOriginal,dsDefault.Db.GetString(ProvinciaSelect4, 1)) ) || ( ! m__PaisIDOriginal.Equals(dsDefault.Db.GetInt32(ProvinciaSelect4, 2)) ) )
            {
               ProvinciaSelect4.Close();
               throw new ProvinciaDataChangedException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("waschg"), new   object[]  {resourceManagerTables.GetString("Provincia")})) ;
            }
            ProvinciaSelect4.Close();
         }
      }

      private void InsertProvincia( )
      {
          IDataReader ProvinciaInsert1 ;
          ReadWriteCommand cmProvinciaInsert1 ;
         CheckOptimisticConcurrencyProvincia( ) ;
         CheckExtendedTableProvincia( ) ;
         AfterConfirmProvincia( ) ;
         cmProvinciaInsert1 = connDefault.GetCommand("INSERT INTO [Provincia] ([ProvinciaNombre], [PaisID]) VALUES (@ProvinciaNombre, @PaisID); SELECT SCOPE_IDENTITY()", false) ;
         if ( ( cmProvinciaInsert1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmProvinciaInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ProvinciaNombre", System.Data.DbType.AnsiString,60));
            cmProvinciaInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PaisID", System.Data.DbType.Int32));
         }
         cmProvinciaInsert1.ErrorMask = cmProvinciaInsert1.ErrorMask  |  ErrorMask.DuplicateKeyError;
         cmProvinciaInsert1.SetParameter(0, rowProvincia["ProvinciaNombre"]);
         cmProvinciaInsert1.SetParameter(1, rowProvincia["PaisID"]);
         ProvinciaInsert1 = cmProvinciaInsert1.FetchData() ;
         rowProvincia.ProvinciaID = (int)(ProvinciaInsert1.GetDecimal(0)) ;
         ProvinciaInsert1.Close();
         // Start of After( Insert) rules
         // End of After( Insert) rules
         OnProvinciaUpdated( new ProvinciaEventArgs( rowProvincia, Mode.Insert)) ;
         // Save values for previous() function.
         EndLevelProvincia( ) ;
      }

      private void UpdateProvincia( )
      {
          ReadWriteCommand cmProvinciaUpdate1 ;
         CheckOptimisticConcurrencyProvincia( ) ;
         CheckExtendedTableProvincia( ) ;
         AfterConfirmProvincia( ) ;
         cmProvinciaUpdate1 = connDefault.GetCommand("UPDATE [Provincia] SET [ProvinciaNombre]=@ProvinciaNombre, [PaisID]=@PaisID  WHERE [ProvinciaID] = @ProvinciaID", false) ;
         if ( ( cmProvinciaUpdate1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmProvinciaUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ProvinciaNombre", System.Data.DbType.AnsiString,60));
            cmProvinciaUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PaisID", System.Data.DbType.Int32));
            cmProvinciaUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ProvinciaID", System.Data.DbType.Int32));
         }
         // Using cursor ProvinciaUpdate1
         cmProvinciaUpdate1.SetParameter(0, rowProvincia["ProvinciaNombre"]);
         cmProvinciaUpdate1.SetParameter(1, rowProvincia["PaisID"]);
         cmProvinciaUpdate1.SetParameter(2, rowProvincia["ProvinciaID"]);
         cmProvinciaUpdate1.ExecuteStmt();
         // Start of After( update) rules
         // End of After( update) rules
         OnProvinciaUpdated( new ProvinciaEventArgs( rowProvincia, Mode.Update)) ;
         EndLevelProvincia( ) ;
      }

      private void Delete( )
      {
          ReadWriteCommand cmProvinciaDelete1 ;
         Gx_mode = Mode.Delete ;
         CheckOptimisticConcurrencyProvincia( ) ;
         OnDeleteControlsProvincia( ) ;
         // No cascading delete specified.
         AfterConfirmProvincia( ) ;
         cmProvinciaDelete1 = connDefault.GetCommand("DELETE FROM [Provincia]  WHERE [ProvinciaID] = @ProvinciaID", false) ;
         if ( ( cmProvinciaDelete1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmProvinciaDelete1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ProvinciaID", System.Data.DbType.Int32));
         }
         cmProvinciaDelete1.ErrorMask = cmProvinciaDelete1.ErrorMask  |  ErrorMask.ForeignKeyError;
         // Using cursor ProvinciaDelete1
         cmProvinciaDelete1.SetParameter(0, rowProvincia["ProvinciaID"]);
         cmProvinciaDelete1.ExecuteStmt();
         if ( cmProvinciaDelete1.ForeignKeyError )
         {
            CheckDeleteErrorsProvincia( ) ;
         }
         // Start of After( delete) rules
         // End of After( delete) rules
         OnProvinciaUpdated( new ProvinciaEventArgs( rowProvincia, Mode.Delete)) ;
         rowProvincia.Delete( ) ;
         sMode6 = Gx_mode ;
         Gx_mode = Mode.Delete ;
         EndLevelProvincia( ) ;
         Gx_mode = sMode6 ;
      }

      private void OnDeleteControlsProvincia( )
      {
          IDataReader PaisSelect3 ;
          ReadWriteCommand cmPaisSelect3 ;
         // Delete mode formulas
         cmPaisSelect3 = connDefault.GetCommand("SELECT [PaisNombre] FROM [Pais] WITH (NOLOCK) WHERE [PaisID] = @PaisID ", false) ;
         if ( ( cmPaisSelect3.IDbCommand.Parameters.Count == 0 ) )
         {
            cmPaisSelect3.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PaisID", System.Data.DbType.Int32));
         }
         cmPaisSelect3.SetParameter(0, rowProvincia["PaisID"]);
         PaisSelect3 = cmPaisSelect3.FetchData() ;
         if ( cmPaisSelect3.HasMoreRows )
         {
            rowProvincia["PaisNombre"] = dsDefault.Db.GetString(PaisSelect3, 0) ;
         }
         PaisSelect3.Close();
      }

      private void CheckDeleteErrorsProvincia( )
      {
          IDataReader LocalidadSelect1 ;
          ReadWriteCommand cmLocalidadSelect1 ;
         cmLocalidadSelect1 = connDefault.GetCommand("SELECT TOP 1 [LoacaliadID] FROM [Localidad] WITH (NOLOCK) WHERE [ProvinciaID] = @ProvinciaID ", false) ;
         if ( ( cmLocalidadSelect1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmLocalidadSelect1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ProvinciaID", System.Data.DbType.Int32));
         }
         cmLocalidadSelect1.SetParameter(0, rowProvincia["ProvinciaID"]);
         LocalidadSelect1 = cmLocalidadSelect1.FetchData() ;
         if ( cmLocalidadSelect1.HasMoreRows )
         {
            LocalidadSelect1.Close();
            throw new LocalidadInvalidDeleteException( string.Format(resourceManager.GetString("del"), new   object[]  {"Localidad"})) ;
         }
         LocalidadSelect1.Close();
      }

      private void EndLevelProvincia( )
      {
         // Execute 'After Trn' event if defined.
         IsModified = 0 ;
      }

      private void ScanByProvinciaID( int startRow ,
                                      int maxRows )
      {
         m_WhereString = " WHERE TM1.[ProvinciaID] = @ProvinciaID" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString6 + "  FROM ([Provincia] TM1 WITH (NOLOCK) INNER JOIN [Pais] T2 WITH (NOLOCK) ON T2.[PaisID] = TM1.[PaisID])" + m_WhereString + " ORDER BY TM1.[ProvinciaID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString6 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[ProvinciaID] ) AS DK_PAGENUM   FROM ([Provincia] TM1 WITH (NOLOCK) INNER JOIN [Pais] T2 WITH (NOLOCK) ON T2.[PaisID] = TM1.[PaisID]) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString6 + " FROM ([Provincia] TM1 WITH (NOLOCK) INNER JOIN [Pais] T2 WITH (NOLOCK) ON T2.[PaisID] = TM1.[PaisID])" + m_WhereString + " ORDER BY TM1.[ProvinciaID] " ;
         }
         cmProvinciaSelect5 = connDefault.GetCommand(scmdbuf, false) ;
         if ( ( cmProvinciaSelect5.IDbCommand.Parameters.Count == 0 ) )
         {
            cmProvinciaSelect5.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ProvinciaID", System.Data.DbType.Int32));
         }
         cmProvinciaSelect5.SetParameter(0, rowProvincia["ProvinciaID"]);
         ProvinciaSelect5 = cmProvinciaSelect5.FetchData() ;
         RcdFound6 = 0 ;
         ScanLoadProvincia( ) ;
         LoadDataProvincia( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanByPaisID( int startRow ,
                                 int maxRows )
      {
         m_WhereString = " WHERE TM1.[PaisID] = @PaisID" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString6 + "  FROM ([Provincia] TM1 WITH (NOLOCK) INNER JOIN [Pais] T2 WITH (NOLOCK) ON T2.[PaisID] = TM1.[PaisID])" + m_WhereString + " ORDER BY TM1.[ProvinciaID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString6 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[ProvinciaID] ) AS DK_PAGENUM   FROM ([Provincia] TM1 WITH (NOLOCK) INNER JOIN [Pais] T2 WITH (NOLOCK) ON T2.[PaisID] = TM1.[PaisID]) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString6 + " FROM ([Provincia] TM1 WITH (NOLOCK) INNER JOIN [Pais] T2 WITH (NOLOCK) ON T2.[PaisID] = TM1.[PaisID])" + m_WhereString + " ORDER BY TM1.[ProvinciaID] " ;
         }
         cmProvinciaSelect5 = connDefault.GetCommand(scmdbuf, false) ;
         if ( ( cmProvinciaSelect5.IDbCommand.Parameters.Count == 0 ) )
         {
            cmProvinciaSelect5.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PaisID", System.Data.DbType.Int32));
         }
         cmProvinciaSelect5.SetParameter(0, rowProvincia["PaisID"]);
         ProvinciaSelect5 = cmProvinciaSelect5.FetchData() ;
         RcdFound6 = 0 ;
         ScanLoadProvincia( ) ;
         LoadDataProvincia( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanStartProvincia( int startRow ,
                                       int maxRows )
      {
         m_WhereString = "" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString6 + "  FROM ([Provincia] TM1 WITH (NOLOCK) INNER JOIN [Pais] T2 WITH (NOLOCK) ON T2.[PaisID] = TM1.[PaisID])" + m_WhereString + " ORDER BY TM1.[ProvinciaID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString6 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[ProvinciaID] ) AS DK_PAGENUM   FROM ([Provincia] TM1 WITH (NOLOCK) INNER JOIN [Pais] T2 WITH (NOLOCK) ON T2.[PaisID] = TM1.[PaisID]) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString6 + " FROM ([Provincia] TM1 WITH (NOLOCK) INNER JOIN [Pais] T2 WITH (NOLOCK) ON T2.[PaisID] = TM1.[PaisID])" + m_WhereString + " ORDER BY TM1.[ProvinciaID] " ;
         }
         cmProvinciaSelect5 = connDefault.GetCommand(scmdbuf, false) ;
         ProvinciaSelect5 = cmProvinciaSelect5.FetchData() ;
         RcdFound6 = 0 ;
         ScanLoadProvincia( ) ;
         LoadDataProvincia( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanNextProvincia( )
      {
         cmProvinciaSelect5.HasMoreRows = ProvinciaSelect5.Read() ;
         RcdFound6 = 0 ;
         ScanLoadProvincia( ) ;
      }

      private void ScanLoadProvincia( )
      {
         Gx_mode = Mode.Display ;
         if ( cmProvinciaSelect5.HasMoreRows )
         {
            RcdFound6 = 1 ;
            rowProvincia["ProvinciaID"] = dsDefault.Db.GetInt32(ProvinciaSelect5, 0) ;
            rowProvincia["ProvinciaNombre"] = dsDefault.Db.GetString(ProvinciaSelect5, 1) ;
            rowProvincia["PaisNombre"] = dsDefault.Db.GetString(ProvinciaSelect5, 2) ;
            rowProvincia["PaisID"] = dsDefault.Db.GetInt32(ProvinciaSelect5, 3) ;
            rowProvincia["PaisNombre"] = dsDefault.Db.GetString(ProvinciaSelect5, 2) ;
         }
      }

      private void ScanEndProvincia( )
      {
         ProvinciaSelect5.Close();
      }

      private void AfterConfirmProvincia( )
      {
         // After Confirm Rules
         OnProvinciaUpdating( new ProvinciaEventArgs( rowProvincia, Gx_mode)) ;
      }

      private void CreateNewRowProvincia( )
      {
         rowProvincia = ProvinciaSet.Provincia.NewProvinciaRow() ;
      }

      private void LoadChildProvincia( int startRow ,
                                       int maxRows )
      {
         CreateNewRowProvincia( ) ;
         bool tmpConstraintState = ProvinciaSet.EnforceConstraints ;
         ProvinciaSet.Provincia.BeginLoadData( ) ;
         ScanStartProvincia( startRow, maxRows) ;
         ProvinciaSet.Provincia.EndLoadData( ) ;
         this.ProvinciaSet.EnforceConstraints = tmpConstraintState ;
      }

      private void LoadDataProvincia( int maxRows )
      {
         int loadedRows = 0 ;
         if ( ( RcdFound6 != 0 ) )
         {
            ScanLoadProvincia( ) ;
            while ( ( RcdFound6 != 0 ) && ( loadedRows != maxRows ) )
            {
               loadedRows++ ;
               LoadRowProvincia( ) ;
               CreateNewRowProvincia( ) ;
               ScanNextProvincia( ) ;
            }
         }
         if ( ( loadedRows > 0 ) )
         {
            RcdFound6 = 1 ;
         }
         ScanEndProvincia( ) ;
         if ( ( ProvinciaSet.Provincia.Count > 0 ) )
         {
            rowProvincia = ProvinciaSet.Provincia[ProvinciaSet.Provincia.Count -1] ;
         }
      }

      private void LoadByProvinciaID( int startRow ,
                                      int maxRows )
      {
         bool tmpConstraintState = ProvinciaSet.EnforceConstraints ;
         ProvinciaSet.Provincia.BeginLoadData( ) ;
         ScanByProvinciaID( startRow, maxRows) ;
         ProvinciaSet.Provincia.EndLoadData( ) ;
         this.ProvinciaSet.EnforceConstraints = tmpConstraintState ;
         if ( ( ProvinciaSet.Provincia.Count > 0 ) )
         {
            rowProvincia = ProvinciaSet.Provincia[ProvinciaSet.Provincia.Count -1] ;
         }
      }

      private void LoadByPaisID( int startRow ,
                                 int maxRows )
      {
         bool tmpConstraintState = ProvinciaSet.EnforceConstraints ;
         ProvinciaSet.Provincia.BeginLoadData( ) ;
         ScanByPaisID( startRow, maxRows) ;
         ProvinciaSet.Provincia.EndLoadData( ) ;
         this.ProvinciaSet.EnforceConstraints = tmpConstraintState ;
         if ( ( ProvinciaSet.Provincia.Count > 0 ) )
         {
            rowProvincia = ProvinciaSet.Provincia[ProvinciaSet.Provincia.Count -1] ;
         }
      }

      private void AddRowProvincia( )
      {
         ProvinciaSet.Provincia.AddProvinciaRow( rowProvincia) ;
      }

      private readonly string m_SelectString6 = "TM1.[ProvinciaID], TM1.[ProvinciaNombre], T2.[PaisNombre], TM1.[PaisID]" ;


      public delegate  void ProvinciaUpdateEventHandler( object sender ,
                                                         ProvinciaEventArgs e );
      public event ProvinciaUpdateEventHandler ProvinciaUpdated ;
      private void OnProvinciaUpdated( ProvinciaEventArgs e )
      {
         if ( ( this.ProvinciaUpdated != null ) )
         {
            this.ProvinciaUpdated( this, e) ;
         }
      }

      public event ProvinciaUpdateEventHandler ProvinciaUpdating ;
      private void OnProvinciaUpdating( ProvinciaEventArgs e )
      {
         if ( ( this.ProvinciaUpdating != null ) )
         {
            this.ProvinciaUpdating( this, e) ;
         }
      }

      public class ProvinciaEventArgs : EventArgs
      {
         private System.Data.StatementType m_statementType ;
         private ProvinciaDataSet.ProvinciaRow m_dataRow ;
         public ProvinciaEventArgs( ProvinciaDataSet.ProvinciaRow row ,
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

         public ProvinciaDataSet.ProvinciaRow Row
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
      public class ProvinciaNotFoundException : Deklarit.DataNotFoundException
      {
         public ProvinciaNotFoundException( )
         {
         }

         public ProvinciaNotFoundException( string message ) : base(message)
         {
         }

         public ProvinciaNotFoundException( string message ,
                                            Exception inner ) : base(message, inner)
         {
         }

         protected ProvinciaNotFoundException( SerializationInfo info ,
                                               StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class PaisForeignKeyNotFoundException : Deklarit.ForeignKeyNotFoundException
      {
         public PaisForeignKeyNotFoundException( )
         {
         }

         public PaisForeignKeyNotFoundException( string message ) : base(message)
         {
         }

         public PaisForeignKeyNotFoundException( string message ,
                                                 Exception inner ) : base(message, inner)
         {
         }

         protected PaisForeignKeyNotFoundException( SerializationInfo info ,
                                                    StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class ProvinciaDataLockedException : Deklarit.DataLockedException
      {
         public ProvinciaDataLockedException( )
         {
         }

         public ProvinciaDataLockedException( string message ) : base(message)
         {
         }

         public ProvinciaDataLockedException( string message ,
                                              Exception inner ) : base(message, inner)
         {
         }

         protected ProvinciaDataLockedException( SerializationInfo info ,
                                                 StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class ProvinciaDataChangedException : Deklarit.DataChangedException
      {
         public ProvinciaDataChangedException( )
         {
         }

         public ProvinciaDataChangedException( string message ) : base(message)
         {
         }

         public ProvinciaDataChangedException( string message ,
                                               Exception inner ) : base(message, inner)
         {
         }

         protected ProvinciaDataChangedException( SerializationInfo info ,
                                                  StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class LocalidadInvalidDeleteException : Deklarit.InvalidDeleteException
      {
         public LocalidadInvalidDeleteException( )
         {
         }

         public LocalidadInvalidDeleteException( string message ) : base(message)
         {
         }

         public LocalidadInvalidDeleteException( string message ,
                                                 Exception inner ) : base(message, inner)
         {
         }

         protected LocalidadInvalidDeleteException( SerializationInfo info ,
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
         RcdFound6 = 0 ;
         scmdbuf = "" ;
         recordCount = 0 ;
         _Gxremove = false ;
         m__ProvinciaNombreOriginal = new object();
         m__PaisIDOriginal = new object();
         IsModified = 0 ;
         m_WhereString = "" ;
         if ( ( this.Transaction == null ) )
         {
            this.Transaction = ((System.Data.IDbTransaction)(System.Threading.Thread.GetData(System.Threading.Thread.GetNamedDataSlot(DeklaritTransaction.TransactionSlotName)) ));
         }
      }

      private short RcdFound6 ;
      private short IsModified ;
      private int recordCount ;
      private String scmdbuf ;
      private String m_WhereString ;
      private bool _Gxremove ;
      private DataStore dsDefault ;
      private System.Resources.ResourceManager resourceManager ;
      private System.Resources.ResourceManager resourceManagerTables ;
      private ReadWriteConnection connDefault ;
      private ReadWriteCommand cmProvinciaSelect1 ;
      private IDataReader ProvinciaSelect1 ;
      private ReadWriteCommand cmProvinciaSelect2 ;
      private IDataReader ProvinciaSelect2 ;
      private ReadWriteCommand cmProvinciaSelect5 ;
      private IDataReader ProvinciaSelect5 ;
      private System.Data.StatementType Gx_mode ;
      private System.Data.StatementType sMode6 ;
      private object m__ProvinciaNombreOriginal ;
      private object m__PaisIDOriginal ;
   }

   public class ProvinciaDataReader : System.IDisposable
   {
      public ProvinciaDataReader( )
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
      ///   Gets or sets the Transaction object to be used  by  ProvinciaDataReaderDeklarit DataReaderclasses
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
         cmProvinciaSelect6 = connDefault.GetCommand("SELECT TM1.[ProvinciaID], TM1.[ProvinciaNombre], T2.[PaisNombre], TM1.[PaisID] FROM ([Provincia] TM1 WITH (NOLOCK) LEFT JOIN [Pais] T2 WITH (NOLOCK) ON T2.[PaisID] = TM1.[PaisID]) ORDER BY TM1.[ProvinciaID] ", false) ;
         ProvinciaSelect6 = cmProvinciaSelect6.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return ProvinciaSelect6 ;
      }

      public IDataReader OpenByProvinciaID( int provinciaID )
      {
         init_reader( ) ;
         m_Closed = false ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmProvinciaSelect6 = connDefault.GetCommand("SELECT TM1.[ProvinciaID], TM1.[ProvinciaNombre], T2.[PaisNombre], TM1.[PaisID] FROM ([Provincia] TM1 WITH (NOLOCK) LEFT JOIN [Pais] T2 WITH (NOLOCK) ON T2.[PaisID] = TM1.[PaisID]) WHERE TM1.[ProvinciaID] = @ProvinciaID ORDER BY TM1.[ProvinciaID] ", false) ;
         if ( ( cmProvinciaSelect6.IDbCommand.Parameters.Count == 0 ) )
         {
            cmProvinciaSelect6.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ProvinciaID", System.Data.DbType.Int32));
         }
         cmProvinciaSelect6.SetParameter(0, provinciaID);
         ProvinciaSelect6 = cmProvinciaSelect6.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return ProvinciaSelect6 ;
      }

      public IDataReader OpenByPaisID( int paisID )
      {
         init_reader( ) ;
         m_Closed = false ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmProvinciaSelect6 = connDefault.GetCommand("SELECT TM1.[ProvinciaID], TM1.[ProvinciaNombre], T2.[PaisNombre], TM1.[PaisID] FROM ([Provincia] TM1 WITH (NOLOCK) LEFT JOIN [Pais] T2 WITH (NOLOCK) ON T2.[PaisID] = TM1.[PaisID]) WHERE TM1.[PaisID] = @PaisID ORDER BY TM1.[ProvinciaID] ", false) ;
         if ( ( cmProvinciaSelect6.IDbCommand.Parameters.Count == 0 ) )
         {
            cmProvinciaSelect6.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PaisID", System.Data.DbType.Int32));
         }
         cmProvinciaSelect6.SetParameter(0, paisID);
         ProvinciaSelect6 = cmProvinciaSelect6.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return ProvinciaSelect6 ;
      }

      public int DeleteByPaisID( int paisID )
      {
         init_reader( ) ;
         int intCount = 0 ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmProvinciaDelete2 = connDefault.GetCommand("DELETE FROM [Provincia]  WHERE [PaisID] = @PaisID", false) ;
         if ( ( cmProvinciaDelete2.IDbCommand.Parameters.Count == 0 ) )
         {
            cmProvinciaDelete2.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PaisID", System.Data.DbType.Int32));
         }
         // Using cursor ProvinciaDelete2
         cmProvinciaDelete2.SetParameter(0, paisID);
         intCount = cmProvinciaDelete2.ExecuteStmt() ;
         return intCount ;
      }

      public void Dispose( )
      {
         if ( ! m_Disposed )
         {
            m_Disposed = true ;
            try
            {
               if ( ! m_Closed && ( ProvinciaSelect6 != null ) )
               {
                  m_Closed = true ;
                  ProvinciaSelect6.Close();
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
      private ReadWriteCommand cmProvinciaSelect6 ;
      private IDataReader ProvinciaSelect6 ;
      private ReadWriteCommand cmProvinciaDelete2 ;
   }

}
