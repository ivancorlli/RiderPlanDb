
//               File: LocalidadDataAdapter
//        Description: Localidad
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
   public partial class LocalidadDataAdapter : System.Data.IDataAdapter, ILocalidadDataAdapter
   {
      private LocalidadDataSet LocalidadSet ;
      private IDbTransaction daCurrentTransaction ;
      private LocalidadDataSet.LocalidadRow rowLocalidad ;
      public LocalidadDataAdapter( )
      {
      }

      private void InitializeMembers( )
      {
         LocalidadSet = new LocalidadDataSet() ;
         this.Initialize( ) ;
         dsDefault = new DataStore( new SqlServer2005Handler( ), "System.Data.SqlClient", Raiderplan1.Configuration.ConnectionString, DeklaritTransaction.TransactionSlotName) ;
      }

      ///  <summary>
      ///   Gets or sets the Transaction object to be used  by  LocalidadDataAdapterclasses to
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
      ///   (2) Fills the specified Dataset with the record matching LoacaliadID field(s) of
      ///    the given IDataRecord
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="dataRecord">Data Record</param>
      public virtual int Fill( LocalidadDataSet dataSet ,
                               IDataRecord dataRecord )
      {
         return Fill(dataSet, ((int)(dataRecord["LoacaliadID"]))) ;
      }

      ///  <summary>
      ///   (3) Fills the specified Dataset with the record matching LoacaliadID field(s) of
      ///    the given DataRow
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="dataRecord">Data Row</param>
      public virtual int Fill( LocalidadDataSet dataSet ,
                               DataRow dataRecord )
      {
         return Fill(dataSet, ((int)(dataRecord["LoacaliadID"]))) ;
      }

      ///  <summary>
      ///   (4) Fills the specified Dataset with the record matching LoacaliadID, if the record
      ///    is not found , throws an exception.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="loacaliadID">Loacaliad ID</param>
      public virtual int Fill( LocalidadDataSet dataSet ,
                               int loacaliadID )
      {
         if ( ! FillByLoacaliadID( dataSet, loacaliadID) )
         {
            throw new LocalidadNotFoundException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("inex"), new   object[]  {resourceManagerTables.GetString("Localidad")})) ;
         }
         return 0 ;
      }


      ///  <summary>
      ///   (5) Fills the specified Dataset with the record matching LoacaliadID in the fillDataParameters
      ///    array, if the array is null, it fills the Dataset loading all records in the table.
      ///
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Fill( LocalidadDataSet dataSet )
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
               LocalidadSet = dataSet ;
               LoadChildLocalidad( 0, -1) ;
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
      ///   (6) Fills the specified dataset filtered by LoacaliadIDfield(s).
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="loacaliadID">Loacaliad ID</param>
      public virtual bool FillByLoacaliadID( LocalidadDataSet dataSet ,
                                             int loacaliadID )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         LocalidadSet = dataSet ;
         rowLocalidad = LocalidadSet.Localidad.NewLocalidadRow() ;
         rowLocalidad.LoacaliadID = loacaliadID ;
         try
         {
            LoadByLoacaliadID( 0, -1) ;
            dataSet.AcceptChanges( ) ;
         }
         finally
         {
            this.Cleanup();
         }
         if ( ( RcdFound5 == 0 ) )
         {
            return false ;
         }
         return true ;
      }


      ///  <summary>
      ///   (6) Fills the specified dataset filtered by ProvinciaIDfield(s).
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="provinciaID">Provincia ID</param>
      public virtual int FillByProvinciaID( LocalidadDataSet dataSet ,
                                            int provinciaID )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         LocalidadSet = dataSet ;
         rowLocalidad = LocalidadSet.Localidad.NewLocalidadRow() ;
         rowLocalidad.ProvinciaID = provinciaID ;
         try
         {
            LoadByProvinciaID( 0, -1) ;
            dataSet.AcceptChanges( ) ;
         }
         finally
         {
            this.Cleanup();
         }
         return 0 ;
      }


      ///  <summary>
      ///   (6) Fills a page of up to maxRows rows into the specified dataset filtered by ProvinciaIDfield(s)starting
      ///    at startRow
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="provinciaID">Provincia ID</param>
      ///  <param name="startRow">Starting row</param>
      ///  <param name="maxRows">Max number of rows to load</param>
      public virtual int FillPageByProvinciaID( LocalidadDataSet dataSet ,
                                                int provinciaID ,
                                                int startRow ,
                                                int maxRows )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         LocalidadSet = dataSet ;
         rowLocalidad = LocalidadSet.Localidad.NewLocalidadRow() ;
         rowLocalidad.ProvinciaID = provinciaID ;
         try
         {
            LoadByProvinciaID( startRow, maxRows) ;
            dataSet.AcceptChanges( ) ;
         }
         finally
         {
            this.Cleanup();
         }
         return 0 ;
      }


      ///  <summary>
      ///   (9) Gets the record count filtered by ProvinciaIDfield(s).
      ///  </summary>
      ///  <param name="provinciaID">Provincia ID</param>
      public virtual int GetRecordCountByProvinciaID( int provinciaID )
      {
         int m_Count ;
         try
         {
            InitializeMembers( ) ;
            m_Count = GetInternalRecordCountByProvinciaID( provinciaID ) ;
         }
         finally
         {
            this.Cleanup();
         }
         return m_Count ;
      }

      private int GetInternalRecordCountByProvinciaID( int provinciaID )
      {
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmLocalidadSelect1 = connDefault.GetCommand("SELECT COUNT(*) FROM [Localidad] WITH (NOLOCK) WHERE [ProvinciaID] = @ProvinciaID ", false) ;
         if ( ( cmLocalidadSelect1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmLocalidadSelect1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ProvinciaID", System.Data.DbType.Int32));
         }
         cmLocalidadSelect1.SetParameter(0, provinciaID);
         LocalidadSelect1 = cmLocalidadSelect1.FetchData() ;
         recordCount = ( ( LocalidadSelect1.IsDBNull(0) )  ? (int)(0) : LocalidadSelect1.GetInt32(0) ) ;
         LocalidadSelect1.Close();
         return recordCount ;
      }

      ///  <summary>
      ///   (8) Fills the specified dataset with the record matching LoacaliadID in the the fillDataParameters
      ///    array, if the array is null, it fills the Dataset loading all records in the table.
      ///
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Fill( DataSet dataSet )
      {
         LocalidadSet = dataSet as LocalidadDataSet ;
         if ( ( LocalidadSet != null ) )
         {
            return Fill( LocalidadSet) ;
         }
         else
         {
            LocalidadSet = new LocalidadDataSet() ;
            Fill( LocalidadSet) ;
            dataSet.Merge( LocalidadSet) ;
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
      public virtual int FillPage( LocalidadDataSet dataSet ,
                                   int startRow ,
                                   int maxRows )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         LocalidadSet = dataSet ;
         try
         {
            LoadChildLocalidad( startRow, maxRows) ;
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
         cmLocalidadSelect2 = connDefault.GetCommand("SELECT COUNT(*) FROM [Localidad] WITH (NOLOCK) ", false) ;
         LocalidadSelect2 = cmLocalidadSelect2.FetchData() ;
         recordCount = ( ( LocalidadSelect2.IsDBNull(0) )  ? (int)(0) : LocalidadSelect2.GetInt32(0) ) ;
         LocalidadSelect2.Close();
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
            DbParameter parm0LoacaliadID ;
            parm0LoacaliadID = factory.CreateParameter() ;
            parm0LoacaliadID.ParameterName = "LoacaliadID" ;
            parm0LoacaliadID.DbType = System.Data.DbType.Int32 ;
            fillDataParameters = new  DbParameter[]  {parm0LoacaliadID} ;
         }
         return fillDataParameters ;
      }

      private DbParameter[] fillDataParameters ;

      ///  <summary>
      ///   Inserts, Updates or Deletes records from the specified LocalidadDataSet object.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Update( DataSet dataSet )
      {
         InitializeMembers( ) ;
         LocalidadSet = dataSet as LocalidadDataSet ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         if ( ( LocalidadSet != null ) )
         {
            try
            {
               connDefault.BeginTransaction();
               foreach( LocalidadDataSet.LocalidadRow row in LocalidadSet.Localidad )
               {
                  rowLocalidad = row ;
                  if ( Deklarit.Data.Helpers.IsRowChanged(rowLocalidad) )
                  {
                     ReadRowLocalidad( ) ;
                     if ( ( rowLocalidad.RowState == System.Data.DataRowState.Added ) )
                     {
                        InsertLocalidad( ) ;
                     }
                     else
                     {
                        if ( _Gxremove )
                        {
                           Delete( ) ;
                        }
                        else
                        {
                           UpdateLocalidad( ) ;
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

      private void LoadRowLocalidad( )
      {
         AddRowLocalidad( ) ;
      }

      private void ReadRowLocalidad( )
      {
         Gx_mode = Deklarit.Utils.Mode.FromRowState(rowLocalidad.RowState) ;
         if ( ( rowLocalidad.RowState != System.Data.DataRowState.Added ) )
         {
            m__LocalidadNombreOriginal = rowLocalidad["LocalidadNombre", System.Data.DataRowVersion.Original] ;
            m__LocalidadCodPosOriginal = rowLocalidad["LocalidadCodPos", System.Data.DataRowVersion.Original] ;
            m__ProvinciaIDOriginal = rowLocalidad["ProvinciaID", System.Data.DataRowVersion.Original] ;
         }
         else
         {
            m__LocalidadNombreOriginal = rowLocalidad["LocalidadNombre"] ;
            m__LocalidadCodPosOriginal = rowLocalidad["LocalidadCodPos"] ;
            m__ProvinciaIDOriginal = rowLocalidad["ProvinciaID"] ;
         }
         _Gxremove = (bool)((rowLocalidad.RowState==System.Data.DataRowState.Deleted)) ;
         if ( _Gxremove )
         {
            rowLocalidad = ((LocalidadDataSet.LocalidadRow)(Deklarit.Utils.DataSetUtil.CloneOriginalDataRow(rowLocalidad)));
         }
      }

      private void LoadLocalidad( )
      {
          IDataReader ProvinciaSelect1 ;
          ReadWriteCommand cmProvinciaSelect1 ;
         cmProvinciaSelect1 = connDefault.GetCommand("SELECT [ProvinciaNombre] FROM [Provincia] WITH (NOLOCK) WHERE [ProvinciaID] = @ProvinciaID ", false) ;
         if ( ( cmProvinciaSelect1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmProvinciaSelect1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ProvinciaID", System.Data.DbType.Int32));
         }
         cmProvinciaSelect1.SetParameter(0, rowLocalidad["ProvinciaID"]);
         ProvinciaSelect1 = cmProvinciaSelect1.FetchData() ;
         if ( cmProvinciaSelect1.HasMoreRows )
         {
            rowLocalidad["ProvinciaNombre"] = dsDefault.Db.GetString(ProvinciaSelect1, 0) ;
         }
         ProvinciaSelect1.Close();
      }

      private void CheckExtendedTableLocalidad( )
      {
          IDataReader ProvinciaSelect2 ;
          ReadWriteCommand cmProvinciaSelect2 ;
         cmProvinciaSelect2 = connDefault.GetCommand("SELECT [ProvinciaNombre] FROM [Provincia] WITH (NOLOCK) WHERE [ProvinciaID] = @ProvinciaID ", false) ;
         if ( ( cmProvinciaSelect2.IDbCommand.Parameters.Count == 0 ) )
         {
            cmProvinciaSelect2.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ProvinciaID", System.Data.DbType.Int32));
         }
         cmProvinciaSelect2.SetParameter(0, rowLocalidad["ProvinciaID"]);
         ProvinciaSelect2 = cmProvinciaSelect2.FetchData() ;
         if ( !cmProvinciaSelect2.HasMoreRows )
         {
            ProvinciaSelect2.Close();
            throw new ProvinciaForeignKeyNotFoundException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("inex"), new   object[]  {resourceManagerTables.GetString("Provincia")})) ;
         }
         rowLocalidad["ProvinciaNombre"] = dsDefault.Db.GetString(ProvinciaSelect2, 0) ;
         ProvinciaSelect2.Close();
      }

      private void GetByPrimaryKey( )
      {
          IDataReader LocalidadSelect3 ;
          ReadWriteCommand cmLocalidadSelect3 ;
         cmLocalidadSelect3 = connDefault.GetCommand("SELECT [LoacaliadID], [LocalidadNombre], [LocalidadCodPos], [ProvinciaID] FROM [Localidad] WITH (NOLOCK) WHERE [LoacaliadID] = @LoacaliadID ", false) ;
         if ( ( cmLocalidadSelect3.IDbCommand.Parameters.Count == 0 ) )
         {
            cmLocalidadSelect3.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LoacaliadID", System.Data.DbType.Int32));
         }
         cmLocalidadSelect3.SetParameter(0, rowLocalidad["LoacaliadID"]);
         LocalidadSelect3 = cmLocalidadSelect3.FetchData() ;
         if ( cmLocalidadSelect3.HasMoreRows )
         {
            RcdFound5 = 1 ;
            rowLocalidad["LoacaliadID"] = dsDefault.Db.GetInt32(LocalidadSelect3, 0) ;
            rowLocalidad["LocalidadNombre"] = dsDefault.Db.GetString(LocalidadSelect3, 1) ;
            rowLocalidad["LocalidadCodPos"] = dsDefault.Db.GetString(LocalidadSelect3, 2) ;
            rowLocalidad["ProvinciaID"] = dsDefault.Db.GetInt32(LocalidadSelect3, 3) ;
            sMode5 = Gx_mode ;
            Gx_mode = Mode.Display ;
            LoadLocalidad( ) ;
            Gx_mode = sMode5 ;
         }
         else
         {
            RcdFound5 = 0 ;
         }
         LocalidadSelect3.Close();
      }

      private void CheckOptimisticConcurrencyLocalidad( )
      {
          IDataReader LocalidadSelect4 ;
          ReadWriteCommand cmLocalidadSelect4 ;
         if ( ( Gx_mode != Mode.Insert ) )
         {
            cmLocalidadSelect4 = connDefault.GetCommand("SELECT [LoacaliadID], [LocalidadNombre], [LocalidadCodPos], [ProvinciaID] FROM [Localidad] WITH (UPDLOCK) WHERE [LoacaliadID] = @LoacaliadID ", false) ;
            if ( ( cmLocalidadSelect4.IDbCommand.Parameters.Count == 0 ) )
            {
               cmLocalidadSelect4.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LoacaliadID", System.Data.DbType.Int32));
            }
            cmLocalidadSelect4.SetParameter(0, rowLocalidad["LoacaliadID"]);
            LocalidadSelect4 = cmLocalidadSelect4.FetchData() ;
            if ( cmLocalidadSelect4.Locked )
            {
               LocalidadSelect4.Close();
               throw new LocalidadDataLockedException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("lock"), new   object[]  {resourceManagerTables.GetString("Localidad")})) ;
            }
            if ( !cmLocalidadSelect4.HasMoreRows || ( ! StringUtil.ObjectStringEquals(m__LocalidadNombreOriginal,dsDefault.Db.GetString(LocalidadSelect4, 1)) ) || ( ! StringUtil.ObjectStringEquals(m__LocalidadCodPosOriginal,dsDefault.Db.GetString(LocalidadSelect4, 2)) ) || ( ! m__ProvinciaIDOriginal.Equals(dsDefault.Db.GetInt32(LocalidadSelect4, 3)) ) )
            {
               LocalidadSelect4.Close();
               throw new LocalidadDataChangedException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("waschg"), new   object[]  {resourceManagerTables.GetString("Localidad")})) ;
            }
            LocalidadSelect4.Close();
         }
      }

      private void InsertLocalidad( )
      {
          IDataReader LocalidadInsert1 ;
          ReadWriteCommand cmLocalidadInsert1 ;
         CheckOptimisticConcurrencyLocalidad( ) ;
         CheckExtendedTableLocalidad( ) ;
         AfterConfirmLocalidad( ) ;
         cmLocalidadInsert1 = connDefault.GetCommand("INSERT INTO [Localidad] ([LocalidadNombre], [LocalidadCodPos], [ProvinciaID]) VALUES (@LocalidadNombre, @LocalidadCodPos, @ProvinciaID); SELECT SCOPE_IDENTITY()", false) ;
         if ( ( cmLocalidadInsert1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmLocalidadInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LocalidadNombre", System.Data.DbType.AnsiString,60));
            cmLocalidadInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LocalidadCodPos", System.Data.DbType.AnsiString,7));
            cmLocalidadInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ProvinciaID", System.Data.DbType.Int32));
         }
         cmLocalidadInsert1.ErrorMask = cmLocalidadInsert1.ErrorMask  |  ErrorMask.DuplicateKeyError;
         cmLocalidadInsert1.SetParameter(0, rowLocalidad["LocalidadNombre"]);
         cmLocalidadInsert1.SetParameter(1, rowLocalidad["LocalidadCodPos"]);
         cmLocalidadInsert1.SetParameter(2, rowLocalidad["ProvinciaID"]);
         LocalidadInsert1 = cmLocalidadInsert1.FetchData() ;
         rowLocalidad.LoacaliadID = (int)(LocalidadInsert1.GetDecimal(0)) ;
         LocalidadInsert1.Close();
         // Start of After( Insert) rules
         // End of After( Insert) rules
         OnLocalidadUpdated( new LocalidadEventArgs( rowLocalidad, Mode.Insert)) ;
         // Save values for previous() function.
         EndLevelLocalidad( ) ;
      }

      private void UpdateLocalidad( )
      {
          ReadWriteCommand cmLocalidadUpdate1 ;
         CheckOptimisticConcurrencyLocalidad( ) ;
         CheckExtendedTableLocalidad( ) ;
         AfterConfirmLocalidad( ) ;
         cmLocalidadUpdate1 = connDefault.GetCommand("UPDATE [Localidad] SET [LocalidadNombre]=@LocalidadNombre, [LocalidadCodPos]=@LocalidadCodPos, [ProvinciaID]=@ProvinciaID  WHERE [LoacaliadID] = @LoacaliadID", false) ;
         if ( ( cmLocalidadUpdate1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmLocalidadUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LocalidadNombre", System.Data.DbType.AnsiString,60));
            cmLocalidadUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LocalidadCodPos", System.Data.DbType.AnsiString,7));
            cmLocalidadUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ProvinciaID", System.Data.DbType.Int32));
            cmLocalidadUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LoacaliadID", System.Data.DbType.Int32));
         }
         // Using cursor LocalidadUpdate1
         cmLocalidadUpdate1.SetParameter(0, rowLocalidad["LocalidadNombre"]);
         cmLocalidadUpdate1.SetParameter(1, rowLocalidad["LocalidadCodPos"]);
         cmLocalidadUpdate1.SetParameter(2, rowLocalidad["ProvinciaID"]);
         cmLocalidadUpdate1.SetParameter(3, rowLocalidad["LoacaliadID"]);
         cmLocalidadUpdate1.ExecuteStmt();
         // Start of After( update) rules
         // End of After( update) rules
         OnLocalidadUpdated( new LocalidadEventArgs( rowLocalidad, Mode.Update)) ;
         EndLevelLocalidad( ) ;
      }

      private void Delete( )
      {
          ReadWriteCommand cmLocalidadDelete1 ;
         Gx_mode = Mode.Delete ;
         CheckOptimisticConcurrencyLocalidad( ) ;
         OnDeleteControlsLocalidad( ) ;
         // No cascading delete specified.
         AfterConfirmLocalidad( ) ;
         cmLocalidadDelete1 = connDefault.GetCommand("DELETE FROM [Localidad]  WHERE [LoacaliadID] = @LoacaliadID", false) ;
         if ( ( cmLocalidadDelete1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmLocalidadDelete1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LoacaliadID", System.Data.DbType.Int32));
         }
         cmLocalidadDelete1.ErrorMask = cmLocalidadDelete1.ErrorMask  |  ErrorMask.ForeignKeyError;
         // Using cursor LocalidadDelete1
         cmLocalidadDelete1.SetParameter(0, rowLocalidad["LoacaliadID"]);
         cmLocalidadDelete1.ExecuteStmt();
         // Start of After( delete) rules
         // End of After( delete) rules
         OnLocalidadUpdated( new LocalidadEventArgs( rowLocalidad, Mode.Delete)) ;
         rowLocalidad.Delete( ) ;
         sMode5 = Gx_mode ;
         Gx_mode = Mode.Delete ;
         EndLevelLocalidad( ) ;
         Gx_mode = sMode5 ;
      }

      private void OnDeleteControlsLocalidad( )
      {
          IDataReader ProvinciaSelect3 ;
          ReadWriteCommand cmProvinciaSelect3 ;
         // Delete mode formulas
         cmProvinciaSelect3 = connDefault.GetCommand("SELECT [ProvinciaNombre] FROM [Provincia] WITH (NOLOCK) WHERE [ProvinciaID] = @ProvinciaID ", false) ;
         if ( ( cmProvinciaSelect3.IDbCommand.Parameters.Count == 0 ) )
         {
            cmProvinciaSelect3.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ProvinciaID", System.Data.DbType.Int32));
         }
         cmProvinciaSelect3.SetParameter(0, rowLocalidad["ProvinciaID"]);
         ProvinciaSelect3 = cmProvinciaSelect3.FetchData() ;
         if ( cmProvinciaSelect3.HasMoreRows )
         {
            rowLocalidad["ProvinciaNombre"] = dsDefault.Db.GetString(ProvinciaSelect3, 0) ;
         }
         ProvinciaSelect3.Close();
      }

      private void EndLevelLocalidad( )
      {
         // Execute 'After Trn' event if defined.
         IsModified = 0 ;
      }

      private void ScanByLoacaliadID( int startRow ,
                                      int maxRows )
      {
         m_WhereString = " WHERE TM1.[LoacaliadID] = @LoacaliadID" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString5 + "  FROM ([Localidad] TM1 WITH (NOLOCK) INNER JOIN [Provincia] T2 WITH (NOLOCK) ON T2.[ProvinciaID] = TM1.[ProvinciaID])" + m_WhereString + " ORDER BY TM1.[LoacaliadID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString5 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[LoacaliadID] ) AS DK_PAGENUM   FROM ([Localidad] TM1 WITH (NOLOCK) INNER JOIN [Provincia] T2 WITH (NOLOCK) ON T2.[ProvinciaID] = TM1.[ProvinciaID]) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString5 + " FROM ([Localidad] TM1 WITH (NOLOCK) INNER JOIN [Provincia] T2 WITH (NOLOCK) ON T2.[ProvinciaID] = TM1.[ProvinciaID])" + m_WhereString + " ORDER BY TM1.[LoacaliadID] " ;
         }
         cmLocalidadSelect5 = connDefault.GetCommand(scmdbuf, false) ;
         if ( ( cmLocalidadSelect5.IDbCommand.Parameters.Count == 0 ) )
         {
            cmLocalidadSelect5.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LoacaliadID", System.Data.DbType.Int32));
         }
         cmLocalidadSelect5.SetParameter(0, rowLocalidad["LoacaliadID"]);
         LocalidadSelect5 = cmLocalidadSelect5.FetchData() ;
         RcdFound5 = 0 ;
         ScanLoadLocalidad( ) ;
         LoadDataLocalidad( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanByProvinciaID( int startRow ,
                                      int maxRows )
      {
         m_WhereString = " WHERE TM1.[ProvinciaID] = @ProvinciaID" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString5 + "  FROM ([Localidad] TM1 WITH (NOLOCK) INNER JOIN [Provincia] T2 WITH (NOLOCK) ON T2.[ProvinciaID] = TM1.[ProvinciaID])" + m_WhereString + " ORDER BY TM1.[LoacaliadID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString5 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[LoacaliadID] ) AS DK_PAGENUM   FROM ([Localidad] TM1 WITH (NOLOCK) INNER JOIN [Provincia] T2 WITH (NOLOCK) ON T2.[ProvinciaID] = TM1.[ProvinciaID]) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString5 + " FROM ([Localidad] TM1 WITH (NOLOCK) INNER JOIN [Provincia] T2 WITH (NOLOCK) ON T2.[ProvinciaID] = TM1.[ProvinciaID])" + m_WhereString + " ORDER BY TM1.[LoacaliadID] " ;
         }
         cmLocalidadSelect5 = connDefault.GetCommand(scmdbuf, false) ;
         if ( ( cmLocalidadSelect5.IDbCommand.Parameters.Count == 0 ) )
         {
            cmLocalidadSelect5.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ProvinciaID", System.Data.DbType.Int32));
         }
         cmLocalidadSelect5.SetParameter(0, rowLocalidad["ProvinciaID"]);
         LocalidadSelect5 = cmLocalidadSelect5.FetchData() ;
         RcdFound5 = 0 ;
         ScanLoadLocalidad( ) ;
         LoadDataLocalidad( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanStartLocalidad( int startRow ,
                                       int maxRows )
      {
         m_WhereString = "" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString5 + "  FROM ([Localidad] TM1 WITH (NOLOCK) INNER JOIN [Provincia] T2 WITH (NOLOCK) ON T2.[ProvinciaID] = TM1.[ProvinciaID])" + m_WhereString + " ORDER BY TM1.[LoacaliadID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString5 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[LoacaliadID] ) AS DK_PAGENUM   FROM ([Localidad] TM1 WITH (NOLOCK) INNER JOIN [Provincia] T2 WITH (NOLOCK) ON T2.[ProvinciaID] = TM1.[ProvinciaID]) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString5 + " FROM ([Localidad] TM1 WITH (NOLOCK) INNER JOIN [Provincia] T2 WITH (NOLOCK) ON T2.[ProvinciaID] = TM1.[ProvinciaID])" + m_WhereString + " ORDER BY TM1.[LoacaliadID] " ;
         }
         cmLocalidadSelect5 = connDefault.GetCommand(scmdbuf, false) ;
         LocalidadSelect5 = cmLocalidadSelect5.FetchData() ;
         RcdFound5 = 0 ;
         ScanLoadLocalidad( ) ;
         LoadDataLocalidad( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanNextLocalidad( )
      {
         cmLocalidadSelect5.HasMoreRows = LocalidadSelect5.Read() ;
         RcdFound5 = 0 ;
         ScanLoadLocalidad( ) ;
      }

      private void ScanLoadLocalidad( )
      {
         Gx_mode = Mode.Display ;
         if ( cmLocalidadSelect5.HasMoreRows )
         {
            RcdFound5 = 1 ;
            rowLocalidad["LoacaliadID"] = dsDefault.Db.GetInt32(LocalidadSelect5, 0) ;
            rowLocalidad["LocalidadNombre"] = dsDefault.Db.GetString(LocalidadSelect5, 1) ;
            rowLocalidad["LocalidadCodPos"] = dsDefault.Db.GetString(LocalidadSelect5, 2) ;
            rowLocalidad["ProvinciaNombre"] = dsDefault.Db.GetString(LocalidadSelect5, 3) ;
            rowLocalidad["ProvinciaID"] = dsDefault.Db.GetInt32(LocalidadSelect5, 4) ;
            rowLocalidad["ProvinciaNombre"] = dsDefault.Db.GetString(LocalidadSelect5, 3) ;
         }
      }

      private void ScanEndLocalidad( )
      {
         LocalidadSelect5.Close();
      }

      private void AfterConfirmLocalidad( )
      {
         // After Confirm Rules
         OnLocalidadUpdating( new LocalidadEventArgs( rowLocalidad, Gx_mode)) ;
      }

      private void CreateNewRowLocalidad( )
      {
         rowLocalidad = LocalidadSet.Localidad.NewLocalidadRow() ;
      }

      private void LoadChildLocalidad( int startRow ,
                                       int maxRows )
      {
         CreateNewRowLocalidad( ) ;
         bool tmpConstraintState = LocalidadSet.EnforceConstraints ;
         LocalidadSet.Localidad.BeginLoadData( ) ;
         ScanStartLocalidad( startRow, maxRows) ;
         LocalidadSet.Localidad.EndLoadData( ) ;
         this.LocalidadSet.EnforceConstraints = tmpConstraintState ;
      }

      private void LoadDataLocalidad( int maxRows )
      {
         int loadedRows = 0 ;
         if ( ( RcdFound5 != 0 ) )
         {
            ScanLoadLocalidad( ) ;
            while ( ( RcdFound5 != 0 ) && ( loadedRows != maxRows ) )
            {
               loadedRows++ ;
               LoadRowLocalidad( ) ;
               CreateNewRowLocalidad( ) ;
               ScanNextLocalidad( ) ;
            }
         }
         if ( ( loadedRows > 0 ) )
         {
            RcdFound5 = 1 ;
         }
         ScanEndLocalidad( ) ;
         if ( ( LocalidadSet.Localidad.Count > 0 ) )
         {
            rowLocalidad = LocalidadSet.Localidad[LocalidadSet.Localidad.Count -1] ;
         }
      }

      private void LoadByLoacaliadID( int startRow ,
                                      int maxRows )
      {
         bool tmpConstraintState = LocalidadSet.EnforceConstraints ;
         LocalidadSet.Localidad.BeginLoadData( ) ;
         ScanByLoacaliadID( startRow, maxRows) ;
         LocalidadSet.Localidad.EndLoadData( ) ;
         this.LocalidadSet.EnforceConstraints = tmpConstraintState ;
         if ( ( LocalidadSet.Localidad.Count > 0 ) )
         {
            rowLocalidad = LocalidadSet.Localidad[LocalidadSet.Localidad.Count -1] ;
         }
      }

      private void LoadByProvinciaID( int startRow ,
                                      int maxRows )
      {
         bool tmpConstraintState = LocalidadSet.EnforceConstraints ;
         LocalidadSet.Localidad.BeginLoadData( ) ;
         ScanByProvinciaID( startRow, maxRows) ;
         LocalidadSet.Localidad.EndLoadData( ) ;
         this.LocalidadSet.EnforceConstraints = tmpConstraintState ;
         if ( ( LocalidadSet.Localidad.Count > 0 ) )
         {
            rowLocalidad = LocalidadSet.Localidad[LocalidadSet.Localidad.Count -1] ;
         }
      }

      private void AddRowLocalidad( )
      {
         LocalidadSet.Localidad.AddLocalidadRow( rowLocalidad) ;
      }

      private readonly string m_SelectString5 = "TM1.[LoacaliadID], TM1.[LocalidadNombre], TM1.[LocalidadCodPos], T2.[ProvinciaNombre], TM1.[ProvinciaID]" ;


      public delegate  void LocalidadUpdateEventHandler( object sender ,
                                                         LocalidadEventArgs e );
      public event LocalidadUpdateEventHandler LocalidadUpdated ;
      private void OnLocalidadUpdated( LocalidadEventArgs e )
      {
         if ( ( this.LocalidadUpdated != null ) )
         {
            this.LocalidadUpdated( this, e) ;
         }
      }

      public event LocalidadUpdateEventHandler LocalidadUpdating ;
      private void OnLocalidadUpdating( LocalidadEventArgs e )
      {
         if ( ( this.LocalidadUpdating != null ) )
         {
            this.LocalidadUpdating( this, e) ;
         }
      }

      public class LocalidadEventArgs : EventArgs
      {
         private System.Data.StatementType m_statementType ;
         private LocalidadDataSet.LocalidadRow m_dataRow ;
         public LocalidadEventArgs( LocalidadDataSet.LocalidadRow row ,
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

         public LocalidadDataSet.LocalidadRow Row
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
      public class LocalidadNotFoundException : Deklarit.DataNotFoundException
      {
         public LocalidadNotFoundException( )
         {
         }

         public LocalidadNotFoundException( string message ) : base(message)
         {
         }

         public LocalidadNotFoundException( string message ,
                                            Exception inner ) : base(message, inner)
         {
         }

         protected LocalidadNotFoundException( SerializationInfo info ,
                                               StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class ProvinciaForeignKeyNotFoundException : Deklarit.ForeignKeyNotFoundException
      {
         public ProvinciaForeignKeyNotFoundException( )
         {
         }

         public ProvinciaForeignKeyNotFoundException( string message ) : base(message)
         {
         }

         public ProvinciaForeignKeyNotFoundException( string message ,
                                                      Exception inner ) : base(message, inner)
         {
         }

         protected ProvinciaForeignKeyNotFoundException( SerializationInfo info ,
                                                         StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class LocalidadDataLockedException : Deklarit.DataLockedException
      {
         public LocalidadDataLockedException( )
         {
         }

         public LocalidadDataLockedException( string message ) : base(message)
         {
         }

         public LocalidadDataLockedException( string message ,
                                              Exception inner ) : base(message, inner)
         {
         }

         protected LocalidadDataLockedException( SerializationInfo info ,
                                                 StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class LocalidadDataChangedException : Deklarit.DataChangedException
      {
         public LocalidadDataChangedException( )
         {
         }

         public LocalidadDataChangedException( string message ) : base(message)
         {
         }

         public LocalidadDataChangedException( string message ,
                                               Exception inner ) : base(message, inner)
         {
         }

         protected LocalidadDataChangedException( SerializationInfo info ,
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
         RcdFound5 = 0 ;
         scmdbuf = "" ;
         recordCount = 0 ;
         _Gxremove = false ;
         m__LocalidadNombreOriginal = new object();
         m__LocalidadCodPosOriginal = new object();
         m__ProvinciaIDOriginal = new object();
         IsModified = 0 ;
         m_WhereString = "" ;
         if ( ( this.Transaction == null ) )
         {
            this.Transaction = ((System.Data.IDbTransaction)(System.Threading.Thread.GetData(System.Threading.Thread.GetNamedDataSlot(DeklaritTransaction.TransactionSlotName)) ));
         }
      }

      private short RcdFound5 ;
      private short IsModified ;
      private int recordCount ;
      private String scmdbuf ;
      private String m_WhereString ;
      private bool _Gxremove ;
      private DataStore dsDefault ;
      private System.Resources.ResourceManager resourceManager ;
      private System.Resources.ResourceManager resourceManagerTables ;
      private ReadWriteConnection connDefault ;
      private ReadWriteCommand cmLocalidadSelect1 ;
      private IDataReader LocalidadSelect1 ;
      private ReadWriteCommand cmLocalidadSelect2 ;
      private IDataReader LocalidadSelect2 ;
      private ReadWriteCommand cmLocalidadSelect5 ;
      private IDataReader LocalidadSelect5 ;
      private System.Data.StatementType Gx_mode ;
      private System.Data.StatementType sMode5 ;
      private object m__LocalidadNombreOriginal ;
      private object m__LocalidadCodPosOriginal ;
      private object m__ProvinciaIDOriginal ;
   }

   public class LocalidadDataReader : System.IDisposable
   {
      public LocalidadDataReader( )
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
      ///   Gets or sets the Transaction object to be used  by  LocalidadDataReaderDeklarit DataReaderclasses
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
         cmLocalidadSelect6 = connDefault.GetCommand("SELECT TM1.[LoacaliadID], TM1.[LocalidadNombre], TM1.[LocalidadCodPos], T2.[ProvinciaNombre], TM1.[ProvinciaID] FROM ([Localidad] TM1 WITH (NOLOCK) LEFT JOIN [Provincia] T2 WITH (NOLOCK) ON T2.[ProvinciaID] = TM1.[ProvinciaID]) ORDER BY TM1.[LoacaliadID] ", false) ;
         LocalidadSelect6 = cmLocalidadSelect6.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return LocalidadSelect6 ;
      }

      public IDataReader OpenByLoacaliadID( int loacaliadID )
      {
         init_reader( ) ;
         m_Closed = false ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmLocalidadSelect6 = connDefault.GetCommand("SELECT TM1.[LoacaliadID], TM1.[LocalidadNombre], TM1.[LocalidadCodPos], T2.[ProvinciaNombre], TM1.[ProvinciaID] FROM ([Localidad] TM1 WITH (NOLOCK) LEFT JOIN [Provincia] T2 WITH (NOLOCK) ON T2.[ProvinciaID] = TM1.[ProvinciaID]) WHERE TM1.[LoacaliadID] = @LoacaliadID ORDER BY TM1.[LoacaliadID] ", false) ;
         if ( ( cmLocalidadSelect6.IDbCommand.Parameters.Count == 0 ) )
         {
            cmLocalidadSelect6.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LoacaliadID", System.Data.DbType.Int32));
         }
         cmLocalidadSelect6.SetParameter(0, loacaliadID);
         LocalidadSelect6 = cmLocalidadSelect6.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return LocalidadSelect6 ;
      }

      public IDataReader OpenByProvinciaID( int provinciaID )
      {
         init_reader( ) ;
         m_Closed = false ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmLocalidadSelect6 = connDefault.GetCommand("SELECT TM1.[LoacaliadID], TM1.[LocalidadNombre], TM1.[LocalidadCodPos], T2.[ProvinciaNombre], TM1.[ProvinciaID] FROM ([Localidad] TM1 WITH (NOLOCK) LEFT JOIN [Provincia] T2 WITH (NOLOCK) ON T2.[ProvinciaID] = TM1.[ProvinciaID]) WHERE TM1.[ProvinciaID] = @ProvinciaID ORDER BY TM1.[LoacaliadID] ", false) ;
         if ( ( cmLocalidadSelect6.IDbCommand.Parameters.Count == 0 ) )
         {
            cmLocalidadSelect6.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ProvinciaID", System.Data.DbType.Int32));
         }
         cmLocalidadSelect6.SetParameter(0, provinciaID);
         LocalidadSelect6 = cmLocalidadSelect6.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return LocalidadSelect6 ;
      }

      public int DeleteByProvinciaID( int provinciaID )
      {
         init_reader( ) ;
         int intCount = 0 ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmLocalidadDelete2 = connDefault.GetCommand("DELETE FROM [Localidad]  WHERE [ProvinciaID] = @ProvinciaID", false) ;
         if ( ( cmLocalidadDelete2.IDbCommand.Parameters.Count == 0 ) )
         {
            cmLocalidadDelete2.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ProvinciaID", System.Data.DbType.Int32));
         }
         // Using cursor LocalidadDelete2
         cmLocalidadDelete2.SetParameter(0, provinciaID);
         intCount = cmLocalidadDelete2.ExecuteStmt() ;
         return intCount ;
      }

      public void Dispose( )
      {
         if ( ! m_Disposed )
         {
            m_Disposed = true ;
            try
            {
               if ( ! m_Closed && ( LocalidadSelect6 != null ) )
               {
                  m_Closed = true ;
                  LocalidadSelect6.Close();
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
      private ReadWriteCommand cmLocalidadSelect6 ;
      private IDataReader LocalidadSelect6 ;
      private ReadWriteCommand cmLocalidadDelete2 ;
   }

}
