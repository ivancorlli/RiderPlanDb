
//               File: RolUsuarioDataAdapter
//        Description: RolUsuario
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
   public partial class RolUsuarioDataAdapter : System.Data.IDataAdapter, IRolUsuarioDataAdapter
   {
      private RolUsuarioDataSet RolUsuarioSet ;
      private IDbTransaction daCurrentTransaction ;
      private RolUsuarioDataSet.RolUsuarioRow rowRolUsuario ;
      public RolUsuarioDataAdapter( )
      {
      }

      private void InitializeMembers( )
      {
         RolUsuarioSet = new RolUsuarioDataSet() ;
         this.Initialize( ) ;
         dsDefault = new DataStore( new SqlServer2005Handler( ), "System.Data.SqlClient", Raiderplan1.Configuration.ConnectionString, DeklaritTransaction.TransactionSlotName) ;
      }

      ///  <summary>
      ///   Gets or sets the Transaction object to be used  by  RolUsuarioDataAdapterclasses
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
      ///   (2) Fills the specified Dataset with the record matching RolUsuarioID field(s) of
      ///    the given IDataRecord
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="dataRecord">Data Record</param>
      public virtual int Fill( RolUsuarioDataSet dataSet ,
                               IDataRecord dataRecord )
      {
         return Fill(dataSet, ((short)(dataRecord["RolUsuarioID"]))) ;
      }

      ///  <summary>
      ///   (3) Fills the specified Dataset with the record matching RolUsuarioID field(s) of
      ///    the given DataRow
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="dataRecord">Data Row</param>
      public virtual int Fill( RolUsuarioDataSet dataSet ,
                               DataRow dataRecord )
      {
         return Fill(dataSet, ((short)(dataRecord["RolUsuarioID"]))) ;
      }

      ///  <summary>
      ///   (4) Fills the specified Dataset with the record matching RolUsuarioID, if the record
      ///    is not found , throws an exception.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="rolUsuarioID">Rol Usuario ID</param>
      public virtual int Fill( RolUsuarioDataSet dataSet ,
                               short rolUsuarioID )
      {
         if ( ! FillByRolUsuarioID( dataSet, rolUsuarioID) )
         {
            throw new RolUsuarioNotFoundException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("inex"), new   object[]  {resourceManagerTables.GetString("RolUsuario")})) ;
         }
         return 0 ;
      }


      ///  <summary>
      ///   (5) Fills the specified Dataset with the record matching RolUsuarioID in the fillDataParameters
      ///    array, if the array is null, it fills the Dataset loading all records in the table.
      ///
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Fill( RolUsuarioDataSet dataSet )
      {
         if ( ( fillDataParameters != null ) )
         {
            Fill( dataSet, System.Int16.Parse( fillDataParameters[0].Value.ToString())) ;
         }
         else
         {
            try
            {
               InitializeMembers( ) ;
               connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
               RolUsuarioSet = dataSet ;
               LoadChildRolusuario( 0, -1) ;
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
      ///   (6) Fills the specified dataset filtered by RolUsuarioIDfield(s).
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="rolUsuarioID">Rol Usuario ID</param>
      public virtual bool FillByRolUsuarioID( RolUsuarioDataSet dataSet ,
                                              short rolUsuarioID )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         RolUsuarioSet = dataSet ;
         rowRolUsuario = RolUsuarioSet.RolUsuario.NewRolUsuarioRow() ;
         rowRolUsuario.RolUsuarioID = rolUsuarioID ;
         try
         {
            LoadByRolUsuarioID( 0, -1) ;
            dataSet.AcceptChanges( ) ;
         }
         finally
         {
            this.Cleanup();
         }
         if ( ( RcdFound3 == 0 ) )
         {
            return false ;
         }
         return true ;
      }


      ///  <summary>
      ///   (8) Fills the specified dataset with the record matching RolUsuarioID in the the
      ///    fillDataParameters array, if the array is null, it fills the Dataset loading all
      ///    records in the table.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Fill( DataSet dataSet )
      {
         RolUsuarioSet = dataSet as RolUsuarioDataSet ;
         if ( ( RolUsuarioSet != null ) )
         {
            return Fill( RolUsuarioSet) ;
         }
         else
         {
            RolUsuarioSet = new RolUsuarioDataSet() ;
            Fill( RolUsuarioSet) ;
            dataSet.Merge( RolUsuarioSet) ;
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
      public virtual int FillPage( RolUsuarioDataSet dataSet ,
                                   int startRow ,
                                   int maxRows )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         RolUsuarioSet = dataSet ;
         try
         {
            LoadChildRolusuario( startRow, maxRows) ;
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
         cmRolUsuarioSelect1 = connDefault.GetCommand("SELECT COUNT(*) FROM [RolUsuario] WITH (NOLOCK) ", false) ;
         RolUsuarioSelect1 = cmRolUsuarioSelect1.FetchData() ;
         recordCount = ( ( RolUsuarioSelect1.IsDBNull(0) )  ? (int)(0) : RolUsuarioSelect1.GetInt32(0) ) ;
         RolUsuarioSelect1.Close();
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
            DbParameter parm0RolUsuarioID ;
            parm0RolUsuarioID = factory.CreateParameter() ;
            parm0RolUsuarioID.ParameterName = "RolUsuarioID" ;
            parm0RolUsuarioID.DbType = System.Data.DbType.Int16 ;
            fillDataParameters = new  DbParameter[]  {parm0RolUsuarioID} ;
         }
         return fillDataParameters ;
      }

      private DbParameter[] fillDataParameters ;

      ///  <summary>
      ///   Inserts, Updates or Deletes records from the specified RolUsuarioDataSet object.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Update( DataSet dataSet )
      {
         InitializeMembers( ) ;
         RolUsuarioSet = dataSet as RolUsuarioDataSet ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         if ( ( RolUsuarioSet != null ) )
         {
            try
            {
               connDefault.BeginTransaction();
               foreach( RolUsuarioDataSet.RolUsuarioRow row in RolUsuarioSet.RolUsuario )
               {
                  rowRolUsuario = row ;
                  if ( Deklarit.Data.Helpers.IsRowChanged(rowRolUsuario) )
                  {
                     ReadRowRolusuario( ) ;
                     if ( ( rowRolUsuario.RowState == System.Data.DataRowState.Added ) )
                     {
                        InsertRolusuario( ) ;
                     }
                     else
                     {
                        if ( _Gxremove )
                        {
                           Delete( ) ;
                        }
                        else
                        {
                           UpdateRolusuario( ) ;
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

      private void LoadRowRolusuario( )
      {
         AddRowRolusuario( ) ;
      }

      private void ReadRowRolusuario( )
      {
         Gx_mode = Deklarit.Utils.Mode.FromRowState(rowRolUsuario.RowState) ;
         if ( ( rowRolUsuario.RowState != System.Data.DataRowState.Added ) )
         {
            m__RolOriginal = rowRolUsuario["Rol", System.Data.DataRowVersion.Original] ;
            m__UsuarioIDOriginal = rowRolUsuario["UsuarioID", System.Data.DataRowVersion.Original] ;
         }
         else
         {
            m__RolOriginal = rowRolUsuario["Rol"] ;
            m__UsuarioIDOriginal = rowRolUsuario["UsuarioID"] ;
         }
         _Gxremove = (bool)((rowRolUsuario.RowState==System.Data.DataRowState.Deleted)) ;
         if ( _Gxremove )
         {
            rowRolUsuario = ((RolUsuarioDataSet.RolUsuarioRow)(Deklarit.Utils.DataSetUtil.CloneOriginalDataRow(rowRolUsuario)));
         }
      }

      private void CheckExtendedTableRolusuario( )
      {
         if ( !  System.Enum.IsDefined(typeof(UsuarioRol),((int)(((short)(rowRolUsuario["Rol"]))))) )
         {
            throw new RolInvalidValue( "Invalid Rol Value") ;
         }
      }

      private void GetByPrimaryKey( )
      {
          IDataReader RolUsuarioSelect2 ;
          ReadWriteCommand cmRolUsuarioSelect2 ;
         cmRolUsuarioSelect2 = connDefault.GetCommand("SELECT [RolUsuarioID], [Rol], [UsuarioID] FROM [RolUsuario] WITH (NOLOCK) WHERE [RolUsuarioID] = @RolUsuarioID ", false) ;
         if ( ( cmRolUsuarioSelect2.IDbCommand.Parameters.Count == 0 ) )
         {
            cmRolUsuarioSelect2.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@RolUsuarioID", System.Data.DbType.Int16));
         }
         cmRolUsuarioSelect2.SetParameter(0, rowRolUsuario["RolUsuarioID"]);
         RolUsuarioSelect2 = cmRolUsuarioSelect2.FetchData() ;
         if ( cmRolUsuarioSelect2.HasMoreRows )
         {
            RcdFound3 = 1 ;
            rowRolUsuario["RolUsuarioID"] = dsDefault.Db.GetInt16(RolUsuarioSelect2, 0) ;
            rowRolUsuario["Rol"] = dsDefault.Db.GetInt16(RolUsuarioSelect2, 1) ;
            rowRolUsuario["UsuarioID"] = dsDefault.Db.GetInt32(RolUsuarioSelect2, 2) ;
            sMode3 = Gx_mode ;
            Gx_mode = Mode.Display ;
            Gx_mode = sMode3 ;
         }
         else
         {
            RcdFound3 = 0 ;
         }
         RolUsuarioSelect2.Close();
      }

      private void CheckOptimisticConcurrencyRolusuario( )
      {
          IDataReader RolUsuarioSelect3 ;
          ReadWriteCommand cmRolUsuarioSelect3 ;
         if ( ( Gx_mode != Mode.Insert ) )
         {
            cmRolUsuarioSelect3 = connDefault.GetCommand("SELECT [RolUsuarioID], [Rol], [UsuarioID] FROM [RolUsuario] WITH (UPDLOCK) WHERE [RolUsuarioID] = @RolUsuarioID ", false) ;
            if ( ( cmRolUsuarioSelect3.IDbCommand.Parameters.Count == 0 ) )
            {
               cmRolUsuarioSelect3.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@RolUsuarioID", System.Data.DbType.Int16));
            }
            cmRolUsuarioSelect3.SetParameter(0, rowRolUsuario["RolUsuarioID"]);
            RolUsuarioSelect3 = cmRolUsuarioSelect3.FetchData() ;
            if ( cmRolUsuarioSelect3.Locked )
            {
               RolUsuarioSelect3.Close();
               throw new RolUsuarioDataLockedException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("lock"), new   object[]  {resourceManagerTables.GetString("RolUsuario")})) ;
            }
            if ( !cmRolUsuarioSelect3.HasMoreRows || ( ! m__RolOriginal.Equals(dsDefault.Db.GetInt16(RolUsuarioSelect3, 1)) ) || ( ! m__UsuarioIDOriginal.Equals(dsDefault.Db.GetInt32(RolUsuarioSelect3, 2)) ) )
            {
               RolUsuarioSelect3.Close();
               throw new RolUsuarioDataChangedException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("waschg"), new   object[]  {resourceManagerTables.GetString("RolUsuario")})) ;
            }
            RolUsuarioSelect3.Close();
         }
      }

      private void InsertRolusuario( )
      {
          IDataReader RolUsuarioInsert1 ;
          ReadWriteCommand cmRolUsuarioInsert1 ;
         CheckOptimisticConcurrencyRolusuario( ) ;
         CheckExtendedTableRolusuario( ) ;
         AfterConfirmRolusuario( ) ;
         cmRolUsuarioInsert1 = connDefault.GetCommand("INSERT INTO [RolUsuario] ([Rol], [UsuarioID]) VALUES (@Rol, @UsuarioID); SELECT SCOPE_IDENTITY()", false) ;
         if ( ( cmRolUsuarioInsert1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmRolUsuarioInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@Rol", System.Data.DbType.Int16));
            cmRolUsuarioInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioID", System.Data.DbType.Int32));
         }
         cmRolUsuarioInsert1.ErrorMask = cmRolUsuarioInsert1.ErrorMask  |  ErrorMask.DuplicateKeyError;
         cmRolUsuarioInsert1.SetParameter(0, rowRolUsuario["Rol"]);
         cmRolUsuarioInsert1.SetParameter(1, rowRolUsuario["UsuarioID"]);
         RolUsuarioInsert1 = cmRolUsuarioInsert1.FetchData() ;
         rowRolUsuario.RolUsuarioID = (short)(RolUsuarioInsert1.GetDecimal(0)) ;
         RolUsuarioInsert1.Close();
         // Start of After( Insert) rules
         // End of After( Insert) rules
         OnRolUsuarioUpdated( new RolUsuarioEventArgs( rowRolUsuario, Mode.Insert)) ;
         // Save values for previous() function.
         EndLevelRolusuario( ) ;
      }

      private void UpdateRolusuario( )
      {
          ReadWriteCommand cmRolUsuarioUpdate1 ;
         CheckOptimisticConcurrencyRolusuario( ) ;
         CheckExtendedTableRolusuario( ) ;
         AfterConfirmRolusuario( ) ;
         cmRolUsuarioUpdate1 = connDefault.GetCommand("UPDATE [RolUsuario] SET [Rol]=@Rol, [UsuarioID]=@UsuarioID  WHERE [RolUsuarioID] = @RolUsuarioID", false) ;
         if ( ( cmRolUsuarioUpdate1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmRolUsuarioUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@Rol", System.Data.DbType.Int16));
            cmRolUsuarioUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioID", System.Data.DbType.Int32));
            cmRolUsuarioUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@RolUsuarioID", System.Data.DbType.Int16));
         }
         // Using cursor RolUsuarioUpdate1
         cmRolUsuarioUpdate1.SetParameter(0, rowRolUsuario["Rol"]);
         cmRolUsuarioUpdate1.SetParameter(1, rowRolUsuario["UsuarioID"]);
         cmRolUsuarioUpdate1.SetParameter(2, rowRolUsuario["RolUsuarioID"]);
         cmRolUsuarioUpdate1.ExecuteStmt();
         // Start of After( update) rules
         // End of After( update) rules
         OnRolUsuarioUpdated( new RolUsuarioEventArgs( rowRolUsuario, Mode.Update)) ;
         EndLevelRolusuario( ) ;
      }

      private void Delete( )
      {
          ReadWriteCommand cmRolUsuarioDelete1 ;
         Gx_mode = Mode.Delete ;
         CheckOptimisticConcurrencyRolusuario( ) ;
         // No cascading delete specified.
         AfterConfirmRolusuario( ) ;
         cmRolUsuarioDelete1 = connDefault.GetCommand("DELETE FROM [RolUsuario]  WHERE [RolUsuarioID] = @RolUsuarioID", false) ;
         if ( ( cmRolUsuarioDelete1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmRolUsuarioDelete1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@RolUsuarioID", System.Data.DbType.Int16));
         }
         cmRolUsuarioDelete1.ErrorMask = cmRolUsuarioDelete1.ErrorMask  |  ErrorMask.ForeignKeyError;
         // Using cursor RolUsuarioDelete1
         cmRolUsuarioDelete1.SetParameter(0, rowRolUsuario["RolUsuarioID"]);
         cmRolUsuarioDelete1.ExecuteStmt();
         // Start of After( delete) rules
         // End of After( delete) rules
         OnRolUsuarioUpdated( new RolUsuarioEventArgs( rowRolUsuario, Mode.Delete)) ;
         rowRolUsuario.Delete( ) ;
         sMode3 = Gx_mode ;
         Gx_mode = Mode.Delete ;
         EndLevelRolusuario( ) ;
         Gx_mode = sMode3 ;
      }

      private void EndLevelRolusuario( )
      {
         // Execute 'After Trn' event if defined.
         IsModified = 0 ;
      }

      private void ScanByRolUsuarioID( int startRow ,
                                       int maxRows )
      {
         m_WhereString = " WHERE TM1.[RolUsuarioID] = @RolUsuarioID" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString3 + "  FROM [RolUsuario] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[RolUsuarioID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString3 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[RolUsuarioID] ) AS DK_PAGENUM   FROM [RolUsuario] TM1 WITH (NOLOCK) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString3 + " FROM [RolUsuario] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[RolUsuarioID] " ;
         }
         cmRolUsuarioSelect4 = connDefault.GetCommand(scmdbuf, false) ;
         if ( ( cmRolUsuarioSelect4.IDbCommand.Parameters.Count == 0 ) )
         {
            cmRolUsuarioSelect4.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@RolUsuarioID", System.Data.DbType.Int16));
         }
         cmRolUsuarioSelect4.SetParameter(0, rowRolUsuario["RolUsuarioID"]);
         RolUsuarioSelect4 = cmRolUsuarioSelect4.FetchData() ;
         RcdFound3 = 0 ;
         ScanLoadRolusuario( ) ;
         LoadDataRolusuario( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanStartRolusuario( int startRow ,
                                        int maxRows )
      {
         m_WhereString = "" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString3 + "  FROM [RolUsuario] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[RolUsuarioID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString3 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[RolUsuarioID] ) AS DK_PAGENUM   FROM [RolUsuario] TM1 WITH (NOLOCK) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString3 + " FROM [RolUsuario] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[RolUsuarioID] " ;
         }
         cmRolUsuarioSelect4 = connDefault.GetCommand(scmdbuf, false) ;
         RolUsuarioSelect4 = cmRolUsuarioSelect4.FetchData() ;
         RcdFound3 = 0 ;
         ScanLoadRolusuario( ) ;
         LoadDataRolusuario( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanNextRolusuario( )
      {
         cmRolUsuarioSelect4.HasMoreRows = RolUsuarioSelect4.Read() ;
         RcdFound3 = 0 ;
         ScanLoadRolusuario( ) ;
      }

      private void ScanLoadRolusuario( )
      {
         Gx_mode = Mode.Display ;
         if ( cmRolUsuarioSelect4.HasMoreRows )
         {
            RcdFound3 = 1 ;
            rowRolUsuario["RolUsuarioID"] = dsDefault.Db.GetInt16(RolUsuarioSelect4, 0) ;
            rowRolUsuario["Rol"] = dsDefault.Db.GetInt16(RolUsuarioSelect4, 1) ;
            rowRolUsuario["UsuarioID"] = dsDefault.Db.GetInt32(RolUsuarioSelect4, 2) ;
         }
      }

      private void ScanEndRolusuario( )
      {
         RolUsuarioSelect4.Close();
      }

      private void AfterConfirmRolusuario( )
      {
         // After Confirm Rules
         OnRolUsuarioUpdating( new RolUsuarioEventArgs( rowRolUsuario, Gx_mode)) ;
      }

      private void CreateNewRowRolusuario( )
      {
         rowRolUsuario = RolUsuarioSet.RolUsuario.NewRolUsuarioRow() ;
      }

      private void LoadChildRolusuario( int startRow ,
                                        int maxRows )
      {
         CreateNewRowRolusuario( ) ;
         bool tmpConstraintState = RolUsuarioSet.EnforceConstraints ;
         RolUsuarioSet.RolUsuario.BeginLoadData( ) ;
         ScanStartRolusuario( startRow, maxRows) ;
         RolUsuarioSet.RolUsuario.EndLoadData( ) ;
         this.RolUsuarioSet.EnforceConstraints = tmpConstraintState ;
      }

      private void LoadDataRolusuario( int maxRows )
      {
         int loadedRows = 0 ;
         if ( ( RcdFound3 != 0 ) )
         {
            ScanLoadRolusuario( ) ;
            while ( ( RcdFound3 != 0 ) && ( loadedRows != maxRows ) )
            {
               loadedRows++ ;
               LoadRowRolusuario( ) ;
               CreateNewRowRolusuario( ) ;
               ScanNextRolusuario( ) ;
            }
         }
         if ( ( loadedRows > 0 ) )
         {
            RcdFound3 = 1 ;
         }
         ScanEndRolusuario( ) ;
         if ( ( RolUsuarioSet.RolUsuario.Count > 0 ) )
         {
            rowRolUsuario = RolUsuarioSet.RolUsuario[RolUsuarioSet.RolUsuario.Count -1] ;
         }
      }

      private void LoadByRolUsuarioID( int startRow ,
                                       int maxRows )
      {
         bool tmpConstraintState = RolUsuarioSet.EnforceConstraints ;
         RolUsuarioSet.RolUsuario.BeginLoadData( ) ;
         ScanByRolUsuarioID( startRow, maxRows) ;
         RolUsuarioSet.RolUsuario.EndLoadData( ) ;
         this.RolUsuarioSet.EnforceConstraints = tmpConstraintState ;
         if ( ( RolUsuarioSet.RolUsuario.Count > 0 ) )
         {
            rowRolUsuario = RolUsuarioSet.RolUsuario[RolUsuarioSet.RolUsuario.Count -1] ;
         }
      }

      private void AddRowRolusuario( )
      {
         RolUsuarioSet.RolUsuario.AddRolUsuarioRow( rowRolUsuario) ;
      }

      private readonly string m_SelectString3 = "TM1.[RolUsuarioID], TM1.[Rol], TM1.[UsuarioID]" ;


      public delegate  void RolUsuarioUpdateEventHandler( object sender ,
                                                          RolUsuarioEventArgs e );
      public event RolUsuarioUpdateEventHandler RolUsuarioUpdated ;
      private void OnRolUsuarioUpdated( RolUsuarioEventArgs e )
      {
         if ( ( this.RolUsuarioUpdated != null ) )
         {
            this.RolUsuarioUpdated( this, e) ;
         }
      }

      public event RolUsuarioUpdateEventHandler RolUsuarioUpdating ;
      private void OnRolUsuarioUpdating( RolUsuarioEventArgs e )
      {
         if ( ( this.RolUsuarioUpdating != null ) )
         {
            this.RolUsuarioUpdating( this, e) ;
         }
      }

      public class RolUsuarioEventArgs : EventArgs
      {
         private System.Data.StatementType m_statementType ;
         private RolUsuarioDataSet.RolUsuarioRow m_dataRow ;
         public RolUsuarioEventArgs( RolUsuarioDataSet.RolUsuarioRow row ,
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

         public RolUsuarioDataSet.RolUsuarioRow Row
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
      public class RolUsuarioNotFoundException : Deklarit.DataNotFoundException
      {
         public RolUsuarioNotFoundException( )
         {
         }

         public RolUsuarioNotFoundException( string message ) : base(message)
         {
         }

         public RolUsuarioNotFoundException( string message ,
                                             Exception inner ) : base(message, inner)
         {
         }

         protected RolUsuarioNotFoundException( SerializationInfo info ,
                                                StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class RolInvalidValue : Deklarit.UserException
      {
         public RolInvalidValue( )
         {
         }

         public RolInvalidValue( string message ) : base(message)
         {
         }

         public RolInvalidValue( string message ,
                                 Exception inner ) : base(message, inner)
         {
         }

         protected RolInvalidValue( SerializationInfo info ,
                                    StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class RolUsuarioDataLockedException : Deklarit.DataLockedException
      {
         public RolUsuarioDataLockedException( )
         {
         }

         public RolUsuarioDataLockedException( string message ) : base(message)
         {
         }

         public RolUsuarioDataLockedException( string message ,
                                               Exception inner ) : base(message, inner)
         {
         }

         protected RolUsuarioDataLockedException( SerializationInfo info ,
                                                  StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class RolUsuarioDataChangedException : Deklarit.DataChangedException
      {
         public RolUsuarioDataChangedException( )
         {
         }

         public RolUsuarioDataChangedException( string message ) : base(message)
         {
         }

         public RolUsuarioDataChangedException( string message ,
                                                Exception inner ) : base(message, inner)
         {
         }

         protected RolUsuarioDataChangedException( SerializationInfo info ,
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
         RcdFound3 = 0 ;
         scmdbuf = "" ;
         recordCount = 0 ;
         _Gxremove = false ;
         m__RolOriginal = new object();
         m__UsuarioIDOriginal = new object();
         IsModified = 0 ;
         m_WhereString = "" ;
         if ( ( this.Transaction == null ) )
         {
            this.Transaction = ((System.Data.IDbTransaction)(System.Threading.Thread.GetData(System.Threading.Thread.GetNamedDataSlot(DeklaritTransaction.TransactionSlotName)) ));
         }
      }

      private short RcdFound3 ;
      private short IsModified ;
      private int recordCount ;
      private String scmdbuf ;
      private String m_WhereString ;
      private bool _Gxremove ;
      private DataStore dsDefault ;
      private System.Resources.ResourceManager resourceManager ;
      private System.Resources.ResourceManager resourceManagerTables ;
      private ReadWriteConnection connDefault ;
      private ReadWriteCommand cmRolUsuarioSelect1 ;
      private IDataReader RolUsuarioSelect1 ;
      private ReadWriteCommand cmRolUsuarioSelect4 ;
      private IDataReader RolUsuarioSelect4 ;
      private System.Data.StatementType Gx_mode ;
      private System.Data.StatementType sMode3 ;
      private object m__RolOriginal ;
      private object m__UsuarioIDOriginal ;
   }

   public class RolUsuarioDataReader : System.IDisposable
   {
      public RolUsuarioDataReader( )
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
      ///   Gets or sets the Transaction object to be used  by  RolUsuarioDataReaderDeklarit
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
         cmRolUsuarioSelect5 = connDefault.GetCommand("SELECT TM1.[RolUsuarioID], TM1.[Rol], TM1.[UsuarioID] FROM [RolUsuario] TM1 WITH (NOLOCK) ORDER BY TM1.[RolUsuarioID] ", false) ;
         RolUsuarioSelect5 = cmRolUsuarioSelect5.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return RolUsuarioSelect5 ;
      }

      public IDataReader OpenByRolUsuarioID( short rolUsuarioID )
      {
         init_reader( ) ;
         m_Closed = false ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmRolUsuarioSelect5 = connDefault.GetCommand("SELECT TM1.[RolUsuarioID], TM1.[Rol], TM1.[UsuarioID] FROM [RolUsuario] TM1 WITH (NOLOCK) WHERE TM1.[RolUsuarioID] = @RolUsuarioID ORDER BY TM1.[RolUsuarioID] ", false) ;
         if ( ( cmRolUsuarioSelect5.IDbCommand.Parameters.Count == 0 ) )
         {
            cmRolUsuarioSelect5.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@RolUsuarioID", System.Data.DbType.Int16));
         }
         cmRolUsuarioSelect5.SetParameter(0, rolUsuarioID);
         RolUsuarioSelect5 = cmRolUsuarioSelect5.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return RolUsuarioSelect5 ;
      }

      public void Dispose( )
      {
         if ( ! m_Disposed )
         {
            m_Disposed = true ;
            try
            {
               if ( ! m_Closed && ( RolUsuarioSelect5 != null ) )
               {
                  m_Closed = true ;
                  RolUsuarioSelect5.Close();
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
      private ReadWriteCommand cmRolUsuarioSelect5 ;
      private IDataReader RolUsuarioSelect5 ;
   }

}
