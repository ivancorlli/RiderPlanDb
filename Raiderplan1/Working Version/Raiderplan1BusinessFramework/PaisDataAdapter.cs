
//               File: PaisDataAdapter
//        Description: Pais
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
   public partial class PaisDataAdapter : System.Data.IDataAdapter, IPaisDataAdapter
   {
      private PaisDataSet PaisSet ;
      private IDbTransaction daCurrentTransaction ;
      private PaisDataSet.PaisRow rowPais ;
      public PaisDataAdapter( )
      {
      }

      private void InitializeMembers( )
      {
         PaisSet = new PaisDataSet() ;
         this.Initialize( ) ;
         dsDefault = new DataStore( new SqlServer2005Handler( ), "System.Data.SqlClient", Raiderplan1.Configuration.ConnectionString, DeklaritTransaction.TransactionSlotName) ;
      }

      ///  <summary>
      ///   Gets or sets the Transaction object to be used  by  PaisDataAdapterclasses to commit
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
      ///   (2) Fills the specified Dataset with the record matching PaisID field(s) of the given
      ///    IDataRecord
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="dataRecord">Data Record</param>
      public virtual int Fill( PaisDataSet dataSet ,
                               IDataRecord dataRecord )
      {
         return Fill(dataSet, ((int)(dataRecord["PaisID"]))) ;
      }

      ///  <summary>
      ///   (3) Fills the specified Dataset with the record matching PaisID field(s) of the given
      ///    DataRow
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="dataRecord">Data Row</param>
      public virtual int Fill( PaisDataSet dataSet ,
                               DataRow dataRecord )
      {
         return Fill(dataSet, ((int)(dataRecord["PaisID"]))) ;
      }

      ///  <summary>
      ///   (4) Fills the specified Dataset with the record matching PaisID, if the record is
      ///    not found , throws an exception.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="paisID">Pais ID</param>
      public virtual int Fill( PaisDataSet dataSet ,
                               int paisID )
      {
         if ( ! FillByPaisID( dataSet, paisID) )
         {
            throw new PaisNotFoundException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("inex"), new   object[]  {resourceManagerTables.GetString("Pais")})) ;
         }
         return 0 ;
      }


      ///  <summary>
      ///   (5) Fills the specified Dataset with the record matching PaisID in the fillDataParameters
      ///    array, if the array is null, it fills the Dataset loading all records in the table.
      ///
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Fill( PaisDataSet dataSet )
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
               PaisSet = dataSet ;
               LoadChildPais( 0, -1) ;
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
      ///   (6) Fills the specified dataset filtered by PaisIDfield(s).
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="paisID">Pais ID</param>
      public virtual bool FillByPaisID( PaisDataSet dataSet ,
                                        int paisID )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         PaisSet = dataSet ;
         rowPais = PaisSet.Pais.NewPaisRow() ;
         rowPais.PaisID = paisID ;
         try
         {
            LoadByPaisID( 0, -1) ;
            dataSet.AcceptChanges( ) ;
         }
         finally
         {
            this.Cleanup();
         }
         if ( ( RcdFound4 == 0 ) )
         {
            return false ;
         }
         return true ;
      }


      ///  <summary>
      ///   (8) Fills the specified dataset with the record matching PaisID in the the fillDataParameters
      ///    array, if the array is null, it fills the Dataset loading all records in the table.
      ///
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Fill( DataSet dataSet )
      {
         PaisSet = dataSet as PaisDataSet ;
         if ( ( PaisSet != null ) )
         {
            return Fill( PaisSet) ;
         }
         else
         {
            PaisSet = new PaisDataSet() ;
            Fill( PaisSet) ;
            dataSet.Merge( PaisSet) ;
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
      public virtual int FillPage( PaisDataSet dataSet ,
                                   int startRow ,
                                   int maxRows )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         PaisSet = dataSet ;
         try
         {
            LoadChildPais( startRow, maxRows) ;
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
         cmPaisSelect1 = connDefault.GetCommand("SELECT COUNT(*) FROM [Pais] WITH (NOLOCK) ", false) ;
         PaisSelect1 = cmPaisSelect1.FetchData() ;
         recordCount = ( ( PaisSelect1.IsDBNull(0) )  ? (int)(0) : PaisSelect1.GetInt32(0) ) ;
         PaisSelect1.Close();
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
            DbParameter parm0PaisID ;
            parm0PaisID = factory.CreateParameter() ;
            parm0PaisID.ParameterName = "PaisID" ;
            parm0PaisID.DbType = System.Data.DbType.Int32 ;
            fillDataParameters = new  DbParameter[]  {parm0PaisID} ;
         }
         return fillDataParameters ;
      }

      private DbParameter[] fillDataParameters ;

      ///  <summary>
      ///   Inserts, Updates or Deletes records from the specified PaisDataSet object.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Update( DataSet dataSet )
      {
         InitializeMembers( ) ;
         PaisSet = dataSet as PaisDataSet ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         if ( ( PaisSet != null ) )
         {
            try
            {
               connDefault.BeginTransaction();
               foreach( PaisDataSet.PaisRow row in PaisSet.Pais )
               {
                  rowPais = row ;
                  if ( Deklarit.Data.Helpers.IsRowChanged(rowPais) )
                  {
                     ReadRowPais( ) ;
                     if ( ( rowPais.RowState == System.Data.DataRowState.Added ) )
                     {
                        InsertPais( ) ;
                     }
                     else
                     {
                        if ( _Gxremove )
                        {
                           Delete( ) ;
                        }
                        else
                        {
                           UpdatePais( ) ;
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

      private void LoadRowPais( )
      {
         AddRowPais( ) ;
      }

      private void ReadRowPais( )
      {
         Gx_mode = Deklarit.Utils.Mode.FromRowState(rowPais.RowState) ;
         if ( ( rowPais.RowState != System.Data.DataRowState.Added ) )
         {
            m__PaisNombreOriginal = rowPais["PaisNombre", System.Data.DataRowVersion.Original] ;
         }
         else
         {
            m__PaisNombreOriginal = rowPais["PaisNombre"] ;
         }
         _Gxremove = (bool)((rowPais.RowState==System.Data.DataRowState.Deleted)) ;
         if ( _Gxremove )
         {
            rowPais = ((PaisDataSet.PaisRow)(Deklarit.Utils.DataSetUtil.CloneOriginalDataRow(rowPais)));
         }
      }

      private void GetByPrimaryKey( )
      {
          IDataReader PaisSelect2 ;
          ReadWriteCommand cmPaisSelect2 ;
         cmPaisSelect2 = connDefault.GetCommand("SELECT [PaisID], [PaisNombre] FROM [Pais] WITH (NOLOCK) WHERE [PaisID] = @PaisID ", false) ;
         if ( ( cmPaisSelect2.IDbCommand.Parameters.Count == 0 ) )
         {
            cmPaisSelect2.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PaisID", System.Data.DbType.Int32));
         }
         cmPaisSelect2.SetParameter(0, rowPais["PaisID"]);
         PaisSelect2 = cmPaisSelect2.FetchData() ;
         if ( cmPaisSelect2.HasMoreRows )
         {
            RcdFound4 = 1 ;
            rowPais["PaisID"] = dsDefault.Db.GetInt32(PaisSelect2, 0) ;
            rowPais["PaisNombre"] = dsDefault.Db.GetString(PaisSelect2, 1) ;
            sMode4 = Gx_mode ;
            Gx_mode = Mode.Display ;
            Gx_mode = sMode4 ;
         }
         else
         {
            RcdFound4 = 0 ;
         }
         PaisSelect2.Close();
      }

      private void CheckOptimisticConcurrencyPais( )
      {
          IDataReader PaisSelect3 ;
          ReadWriteCommand cmPaisSelect3 ;
         if ( ( Gx_mode != Mode.Insert ) )
         {
            cmPaisSelect3 = connDefault.GetCommand("SELECT [PaisID], [PaisNombre] FROM [Pais] WITH (UPDLOCK) WHERE [PaisID] = @PaisID ", false) ;
            if ( ( cmPaisSelect3.IDbCommand.Parameters.Count == 0 ) )
            {
               cmPaisSelect3.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PaisID", System.Data.DbType.Int32));
            }
            cmPaisSelect3.SetParameter(0, rowPais["PaisID"]);
            PaisSelect3 = cmPaisSelect3.FetchData() ;
            if ( cmPaisSelect3.Locked )
            {
               PaisSelect3.Close();
               throw new PaisDataLockedException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("lock"), new   object[]  {resourceManagerTables.GetString("Pais")})) ;
            }
            if ( !cmPaisSelect3.HasMoreRows || ( ! StringUtil.ObjectStringEquals(m__PaisNombreOriginal,dsDefault.Db.GetString(PaisSelect3, 1)) ) )
            {
               PaisSelect3.Close();
               throw new PaisDataChangedException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("waschg"), new   object[]  {resourceManagerTables.GetString("Pais")})) ;
            }
            PaisSelect3.Close();
         }
      }

      private void InsertPais( )
      {
          IDataReader PaisInsert1 ;
          ReadWriteCommand cmPaisInsert1 ;
         CheckOptimisticConcurrencyPais( ) ;
         AfterConfirmPais( ) ;
         cmPaisInsert1 = connDefault.GetCommand("INSERT INTO [Pais] ([PaisNombre]) VALUES (@PaisNombre); SELECT SCOPE_IDENTITY()", false) ;
         if ( ( cmPaisInsert1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmPaisInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PaisNombre", System.Data.DbType.AnsiString,60));
         }
         cmPaisInsert1.ErrorMask = cmPaisInsert1.ErrorMask  |  ErrorMask.DuplicateKeyError;
         cmPaisInsert1.SetParameter(0, rowPais["PaisNombre"]);
         PaisInsert1 = cmPaisInsert1.FetchData() ;
         rowPais.PaisID = (int)(PaisInsert1.GetDecimal(0)) ;
         PaisInsert1.Close();
         // Start of After( Insert) rules
         // End of After( Insert) rules
         OnPaisUpdated( new PaisEventArgs( rowPais, Mode.Insert)) ;
         // Save values for previous() function.
         EndLevelPais( ) ;
      }

      private void UpdatePais( )
      {
          ReadWriteCommand cmPaisUpdate1 ;
         CheckOptimisticConcurrencyPais( ) ;
         AfterConfirmPais( ) ;
         cmPaisUpdate1 = connDefault.GetCommand("UPDATE [Pais] SET [PaisNombre]=@PaisNombre  WHERE [PaisID] = @PaisID", false) ;
         if ( ( cmPaisUpdate1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmPaisUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PaisNombre", System.Data.DbType.AnsiString,60));
            cmPaisUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PaisID", System.Data.DbType.Int32));
         }
         // Using cursor PaisUpdate1
         cmPaisUpdate1.SetParameter(0, rowPais["PaisNombre"]);
         cmPaisUpdate1.SetParameter(1, rowPais["PaisID"]);
         cmPaisUpdate1.ExecuteStmt();
         // Start of After( update) rules
         // End of After( update) rules
         OnPaisUpdated( new PaisEventArgs( rowPais, Mode.Update)) ;
         EndLevelPais( ) ;
      }

      private void Delete( )
      {
          ReadWriteCommand cmPaisDelete1 ;
         Gx_mode = Mode.Delete ;
         CheckOptimisticConcurrencyPais( ) ;
         // No cascading delete specified.
         AfterConfirmPais( ) ;
         cmPaisDelete1 = connDefault.GetCommand("DELETE FROM [Pais]  WHERE [PaisID] = @PaisID", false) ;
         if ( ( cmPaisDelete1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmPaisDelete1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PaisID", System.Data.DbType.Int32));
         }
         cmPaisDelete1.ErrorMask = cmPaisDelete1.ErrorMask  |  ErrorMask.ForeignKeyError;
         // Using cursor PaisDelete1
         cmPaisDelete1.SetParameter(0, rowPais["PaisID"]);
         cmPaisDelete1.ExecuteStmt();
         if ( cmPaisDelete1.ForeignKeyError )
         {
            CheckDeleteErrorsPais( ) ;
         }
         // Start of After( delete) rules
         // End of After( delete) rules
         OnPaisUpdated( new PaisEventArgs( rowPais, Mode.Delete)) ;
         rowPais.Delete( ) ;
         sMode4 = Gx_mode ;
         Gx_mode = Mode.Delete ;
         EndLevelPais( ) ;
         Gx_mode = sMode4 ;
      }

      private void CheckDeleteErrorsPais( )
      {
          IDataReader ProvinciaSelect1 ;
          ReadWriteCommand cmProvinciaSelect1 ;
         cmProvinciaSelect1 = connDefault.GetCommand("SELECT TOP 1 [ProvinciaID] FROM [Provincia] WITH (NOLOCK) WHERE [PaisID] = @PaisID ", false) ;
         if ( ( cmProvinciaSelect1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmProvinciaSelect1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PaisID", System.Data.DbType.Int32));
         }
         cmProvinciaSelect1.SetParameter(0, rowPais["PaisID"]);
         ProvinciaSelect1 = cmProvinciaSelect1.FetchData() ;
         if ( cmProvinciaSelect1.HasMoreRows )
         {
            ProvinciaSelect1.Close();
            throw new ProvinciaInvalidDeleteException( string.Format(resourceManager.GetString("del"), new   object[]  {"Provincia"})) ;
         }
         ProvinciaSelect1.Close();
      }

      private void EndLevelPais( )
      {
         // Execute 'After Trn' event if defined.
         IsModified = 0 ;
      }

      private void ScanByPaisID( int startRow ,
                                 int maxRows )
      {
         m_WhereString = " WHERE TM1.[PaisID] = @PaisID" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString4 + "  FROM [Pais] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[PaisID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString4 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[PaisID] ) AS DK_PAGENUM   FROM [Pais] TM1 WITH (NOLOCK) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString4 + " FROM [Pais] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[PaisID] " ;
         }
         cmPaisSelect4 = connDefault.GetCommand(scmdbuf, false) ;
         if ( ( cmPaisSelect4.IDbCommand.Parameters.Count == 0 ) )
         {
            cmPaisSelect4.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PaisID", System.Data.DbType.Int32));
         }
         cmPaisSelect4.SetParameter(0, rowPais["PaisID"]);
         PaisSelect4 = cmPaisSelect4.FetchData() ;
         RcdFound4 = 0 ;
         ScanLoadPais( ) ;
         LoadDataPais( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanStartPais( int startRow ,
                                  int maxRows )
      {
         m_WhereString = "" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString4 + "  FROM [Pais] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[PaisID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString4 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[PaisID] ) AS DK_PAGENUM   FROM [Pais] TM1 WITH (NOLOCK) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString4 + " FROM [Pais] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[PaisID] " ;
         }
         cmPaisSelect4 = connDefault.GetCommand(scmdbuf, false) ;
         PaisSelect4 = cmPaisSelect4.FetchData() ;
         RcdFound4 = 0 ;
         ScanLoadPais( ) ;
         LoadDataPais( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanNextPais( )
      {
         cmPaisSelect4.HasMoreRows = PaisSelect4.Read() ;
         RcdFound4 = 0 ;
         ScanLoadPais( ) ;
      }

      private void ScanLoadPais( )
      {
         Gx_mode = Mode.Display ;
         if ( cmPaisSelect4.HasMoreRows )
         {
            RcdFound4 = 1 ;
            rowPais["PaisID"] = dsDefault.Db.GetInt32(PaisSelect4, 0) ;
            rowPais["PaisNombre"] = dsDefault.Db.GetString(PaisSelect4, 1) ;
         }
      }

      private void ScanEndPais( )
      {
         PaisSelect4.Close();
      }

      private void AfterConfirmPais( )
      {
         // After Confirm Rules
         OnPaisUpdating( new PaisEventArgs( rowPais, Gx_mode)) ;
      }

      private void CreateNewRowPais( )
      {
         rowPais = PaisSet.Pais.NewPaisRow() ;
      }

      private void LoadChildPais( int startRow ,
                                  int maxRows )
      {
         CreateNewRowPais( ) ;
         bool tmpConstraintState = PaisSet.EnforceConstraints ;
         PaisSet.Pais.BeginLoadData( ) ;
         ScanStartPais( startRow, maxRows) ;
         PaisSet.Pais.EndLoadData( ) ;
         this.PaisSet.EnforceConstraints = tmpConstraintState ;
      }

      private void LoadDataPais( int maxRows )
      {
         int loadedRows = 0 ;
         if ( ( RcdFound4 != 0 ) )
         {
            ScanLoadPais( ) ;
            while ( ( RcdFound4 != 0 ) && ( loadedRows != maxRows ) )
            {
               loadedRows++ ;
               LoadRowPais( ) ;
               CreateNewRowPais( ) ;
               ScanNextPais( ) ;
            }
         }
         if ( ( loadedRows > 0 ) )
         {
            RcdFound4 = 1 ;
         }
         ScanEndPais( ) ;
         if ( ( PaisSet.Pais.Count > 0 ) )
         {
            rowPais = PaisSet.Pais[PaisSet.Pais.Count -1] ;
         }
      }

      private void LoadByPaisID( int startRow ,
                                 int maxRows )
      {
         bool tmpConstraintState = PaisSet.EnforceConstraints ;
         PaisSet.Pais.BeginLoadData( ) ;
         ScanByPaisID( startRow, maxRows) ;
         PaisSet.Pais.EndLoadData( ) ;
         this.PaisSet.EnforceConstraints = tmpConstraintState ;
         if ( ( PaisSet.Pais.Count > 0 ) )
         {
            rowPais = PaisSet.Pais[PaisSet.Pais.Count -1] ;
         }
      }

      private void AddRowPais( )
      {
         PaisSet.Pais.AddPaisRow( rowPais) ;
      }

      private readonly string m_SelectString4 = "TM1.[PaisID], TM1.[PaisNombre]" ;


      public delegate  void PaisUpdateEventHandler( object sender ,
                                                    PaisEventArgs e );
      public event PaisUpdateEventHandler PaisUpdated ;
      private void OnPaisUpdated( PaisEventArgs e )
      {
         if ( ( this.PaisUpdated != null ) )
         {
            this.PaisUpdated( this, e) ;
         }
      }

      public event PaisUpdateEventHandler PaisUpdating ;
      private void OnPaisUpdating( PaisEventArgs e )
      {
         if ( ( this.PaisUpdating != null ) )
         {
            this.PaisUpdating( this, e) ;
         }
      }

      public class PaisEventArgs : EventArgs
      {
         private System.Data.StatementType m_statementType ;
         private PaisDataSet.PaisRow m_dataRow ;
         public PaisEventArgs( PaisDataSet.PaisRow row ,
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

         public PaisDataSet.PaisRow Row
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
      public class PaisNotFoundException : Deklarit.DataNotFoundException
      {
         public PaisNotFoundException( )
         {
         }

         public PaisNotFoundException( string message ) : base(message)
         {
         }

         public PaisNotFoundException( string message ,
                                       Exception inner ) : base(message, inner)
         {
         }

         protected PaisNotFoundException( SerializationInfo info ,
                                          StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class PaisDataLockedException : Deklarit.DataLockedException
      {
         public PaisDataLockedException( )
         {
         }

         public PaisDataLockedException( string message ) : base(message)
         {
         }

         public PaisDataLockedException( string message ,
                                         Exception inner ) : base(message, inner)
         {
         }

         protected PaisDataLockedException( SerializationInfo info ,
                                            StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class PaisDataChangedException : Deklarit.DataChangedException
      {
         public PaisDataChangedException( )
         {
         }

         public PaisDataChangedException( string message ) : base(message)
         {
         }

         public PaisDataChangedException( string message ,
                                          Exception inner ) : base(message, inner)
         {
         }

         protected PaisDataChangedException( SerializationInfo info ,
                                             StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class ProvinciaInvalidDeleteException : Deklarit.InvalidDeleteException
      {
         public ProvinciaInvalidDeleteException( )
         {
         }

         public ProvinciaInvalidDeleteException( string message ) : base(message)
         {
         }

         public ProvinciaInvalidDeleteException( string message ,
                                                 Exception inner ) : base(message, inner)
         {
         }

         protected ProvinciaInvalidDeleteException( SerializationInfo info ,
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
         RcdFound4 = 0 ;
         scmdbuf = "" ;
         recordCount = 0 ;
         _Gxremove = false ;
         m__PaisNombreOriginal = new object();
         IsModified = 0 ;
         m_WhereString = "" ;
         if ( ( this.Transaction == null ) )
         {
            this.Transaction = ((System.Data.IDbTransaction)(System.Threading.Thread.GetData(System.Threading.Thread.GetNamedDataSlot(DeklaritTransaction.TransactionSlotName)) ));
         }
      }

      private short RcdFound4 ;
      private short IsModified ;
      private int recordCount ;
      private String scmdbuf ;
      private String m_WhereString ;
      private bool _Gxremove ;
      private DataStore dsDefault ;
      private System.Resources.ResourceManager resourceManager ;
      private System.Resources.ResourceManager resourceManagerTables ;
      private ReadWriteConnection connDefault ;
      private ReadWriteCommand cmPaisSelect1 ;
      private IDataReader PaisSelect1 ;
      private ReadWriteCommand cmPaisSelect4 ;
      private IDataReader PaisSelect4 ;
      private System.Data.StatementType Gx_mode ;
      private System.Data.StatementType sMode4 ;
      private object m__PaisNombreOriginal ;
   }

   public class PaisDataReader : System.IDisposable
   {
      public PaisDataReader( )
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
      ///   Gets or sets the Transaction object to be used  by  PaisDataReaderDeklarit DataReaderclasses
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
         cmPaisSelect5 = connDefault.GetCommand("SELECT TM1.[PaisID], TM1.[PaisNombre] FROM [Pais] TM1 WITH (NOLOCK) ORDER BY TM1.[PaisID] ", false) ;
         PaisSelect5 = cmPaisSelect5.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return PaisSelect5 ;
      }

      public IDataReader OpenByPaisID( int paisID )
      {
         init_reader( ) ;
         m_Closed = false ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmPaisSelect5 = connDefault.GetCommand("SELECT TM1.[PaisID], TM1.[PaisNombre] FROM [Pais] TM1 WITH (NOLOCK) WHERE TM1.[PaisID] = @PaisID ORDER BY TM1.[PaisID] ", false) ;
         if ( ( cmPaisSelect5.IDbCommand.Parameters.Count == 0 ) )
         {
            cmPaisSelect5.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PaisID", System.Data.DbType.Int32));
         }
         cmPaisSelect5.SetParameter(0, paisID);
         PaisSelect5 = cmPaisSelect5.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return PaisSelect5 ;
      }

      public void Dispose( )
      {
         if ( ! m_Disposed )
         {
            m_Disposed = true ;
            try
            {
               if ( ! m_Closed && ( PaisSelect5 != null ) )
               {
                  m_Closed = true ;
                  PaisSelect5.Close();
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
      private ReadWriteCommand cmPaisSelect5 ;
      private IDataReader PaisSelect5 ;
   }

}
