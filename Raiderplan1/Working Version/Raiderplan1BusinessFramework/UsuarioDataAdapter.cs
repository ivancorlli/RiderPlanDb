
//               File: UsuarioDataAdapter
//        Description: Usuario
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
   public partial class UsuarioDataAdapter : System.Data.IDataAdapter, IUsuarioDataAdapter
   {
      private UsuarioDataSet UsuarioSet ;
      private IDbTransaction daCurrentTransaction ;
      private UsuarioDataSet.UsuarioRow rowUsuario ;
      public UsuarioDataAdapter( )
      {
      }

      private void InitializeMembers( )
      {
         UsuarioSet = new UsuarioDataSet() ;
         this.Initialize( ) ;
         dsDefault = new DataStore( new SqlServer2005Handler( ), "System.Data.SqlClient", Raiderplan1.Configuration.ConnectionString, DeklaritTransaction.TransactionSlotName) ;
      }

      ///  <summary>
      ///   Gets or sets the Transaction object to be used  by  UsuarioDataAdapterclasses to
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
      ///   (2) Fills the specified Dataset with the record matching UsuarioID field(s) of the
      ///    given IDataRecord
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="dataRecord">Data Record</param>
      public virtual int Fill( UsuarioDataSet dataSet ,
                               IDataRecord dataRecord )
      {
         return Fill(dataSet, ((int)(dataRecord["UsuarioID"]))) ;
      }

      ///  <summary>
      ///   (3) Fills the specified Dataset with the record matching UsuarioID field(s) of the
      ///    given DataRow
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="dataRecord">Data Row</param>
      public virtual int Fill( UsuarioDataSet dataSet ,
                               DataRow dataRecord )
      {
         return Fill(dataSet, ((int)(dataRecord["UsuarioID"]))) ;
      }

      ///  <summary>
      ///   (4) Fills the specified Dataset with the record matching UsuarioID, if the record
      ///    is not found , throws an exception.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="usuarioID">Usuario ID</param>
      public virtual int Fill( UsuarioDataSet dataSet ,
                               int usuarioID )
      {
         if ( ! FillByUsuarioID( dataSet, usuarioID) )
         {
            throw new UsuarioNotFoundException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("inex"), new   object[]  {resourceManagerTables.GetString("Usuario")})) ;
         }
         return 0 ;
      }


      ///  <summary>
      ///   (5) Fills the specified Dataset with the record matching UsuarioID in the fillDataParameters
      ///    array, if the array is null, it fills the Dataset loading all records in the table.
      ///
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Fill( UsuarioDataSet dataSet )
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
               UsuarioSet = dataSet ;
               LoadChildUsuario( 0, -1) ;
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
      ///   (6) Fills the specified dataset filtered by UsuarioIDfield(s).
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="usuarioID">Usuario ID</param>
      public virtual bool FillByUsuarioID( UsuarioDataSet dataSet ,
                                           int usuarioID )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         UsuarioSet = dataSet ;
         rowUsuario = UsuarioSet.Usuario.NewUsuarioRow() ;
         rowUsuario.UsuarioID = usuarioID ;
         try
         {
            LoadByUsuarioID( 0, -1) ;
            dataSet.AcceptChanges( ) ;
         }
         finally
         {
            this.Cleanup();
         }
         if ( ( RcdFound7 == 0 ) )
         {
            return false ;
         }
         return true ;
      }


      ///  <summary>
      ///   (6) Fills the specified dataset filtered by PersonaIDfield(s).
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="personaID">Persona ID</param>
      public virtual int FillByPersonaID( UsuarioDataSet dataSet ,
                                          int personaID )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         UsuarioSet = dataSet ;
         rowUsuario = UsuarioSet.Usuario.NewUsuarioRow() ;
         rowUsuario.PersonaID = personaID ;
         try
         {
            LoadByPersonaID( 0, -1) ;
            dataSet.AcceptChanges( ) ;
         }
         finally
         {
            this.Cleanup();
         }
         return 0 ;
      }


      ///  <summary>
      ///   (6) Fills a page of up to maxRows rows into the specified dataset filtered by PersonaIDfield(s)starting
      ///    at startRow
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="personaID">Persona ID</param>
      ///  <param name="startRow">Starting row</param>
      ///  <param name="maxRows">Max number of rows to load</param>
      public virtual int FillPageByPersonaID( UsuarioDataSet dataSet ,
                                              int personaID ,
                                              int startRow ,
                                              int maxRows )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         UsuarioSet = dataSet ;
         rowUsuario = UsuarioSet.Usuario.NewUsuarioRow() ;
         rowUsuario.PersonaID = personaID ;
         try
         {
            LoadByPersonaID( startRow, maxRows) ;
            dataSet.AcceptChanges( ) ;
         }
         finally
         {
            this.Cleanup();
         }
         return 0 ;
      }


      ///  <summary>
      ///   (9) Gets the record count filtered by PersonaIDfield(s).
      ///  </summary>
      ///  <param name="personaID">Persona ID</param>
      public virtual int GetRecordCountByPersonaID( int personaID )
      {
         int m_Count ;
         try
         {
            InitializeMembers( ) ;
            m_Count = GetInternalRecordCountByPersonaID( personaID ) ;
         }
         finally
         {
            this.Cleanup();
         }
         return m_Count ;
      }

      private int GetInternalRecordCountByPersonaID( int personaID )
      {
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmUsuarioSelect1 = connDefault.GetCommand("SELECT COUNT(*) FROM [Usuario] WITH (NOLOCK) WHERE [PersonaID] = @PersonaID ", false) ;
         if ( ( cmUsuarioSelect1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmUsuarioSelect1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaID", System.Data.DbType.Int32));
         }
         cmUsuarioSelect1.SetParameter(0, personaID);
         UsuarioSelect1 = cmUsuarioSelect1.FetchData() ;
         recordCount = ( ( UsuarioSelect1.IsDBNull(0) )  ? (int)(0) : UsuarioSelect1.GetInt32(0) ) ;
         UsuarioSelect1.Close();
         return recordCount ;
      }

      ///  <summary>
      ///   (8) Fills the specified dataset with the record matching UsuarioID in the the fillDataParameters
      ///    array, if the array is null, it fills the Dataset loading all records in the table.
      ///
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Fill( DataSet dataSet )
      {
         UsuarioSet = dataSet as UsuarioDataSet ;
         if ( ( UsuarioSet != null ) )
         {
            return Fill( UsuarioSet) ;
         }
         else
         {
            UsuarioSet = new UsuarioDataSet() ;
            Fill( UsuarioSet) ;
            dataSet.Merge( UsuarioSet) ;
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
      public virtual int FillPage( UsuarioDataSet dataSet ,
                                   int startRow ,
                                   int maxRows )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         UsuarioSet = dataSet ;
         try
         {
            LoadChildUsuario( startRow, maxRows) ;
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
         cmUsuarioSelect2 = connDefault.GetCommand("SELECT COUNT(*) FROM [Usuario] WITH (NOLOCK) ", false) ;
         UsuarioSelect2 = cmUsuarioSelect2.FetchData() ;
         recordCount = ( ( UsuarioSelect2.IsDBNull(0) )  ? (int)(0) : UsuarioSelect2.GetInt32(0) ) ;
         UsuarioSelect2.Close();
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
            DbParameter parm0UsuarioID ;
            parm0UsuarioID = factory.CreateParameter() ;
            parm0UsuarioID.ParameterName = "UsuarioID" ;
            parm0UsuarioID.DbType = System.Data.DbType.Int32 ;
            fillDataParameters = new  DbParameter[]  {parm0UsuarioID} ;
         }
         return fillDataParameters ;
      }

      private DbParameter[] fillDataParameters ;

      ///  <summary>
      ///   Inserts, Updates or Deletes records from the specified UsuarioDataSet object.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Update( DataSet dataSet )
      {
         InitializeMembers( ) ;
         UsuarioSet = dataSet as UsuarioDataSet ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         if ( ( UsuarioSet != null ) )
         {
            try
            {
               connDefault.BeginTransaction();
               foreach( UsuarioDataSet.UsuarioRow row in UsuarioSet.Usuario )
               {
                  rowUsuario = row ;
                  if ( Deklarit.Data.Helpers.IsRowChanged(rowUsuario) )
                  {
                     ReadRowUsuario( ) ;
                     if ( ( rowUsuario.RowState == System.Data.DataRowState.Added ) )
                     {
                        InsertUsuario( ) ;
                     }
                     else
                     {
                        if ( _Gxremove )
                        {
                           Delete( ) ;
                        }
                        else
                        {
                           UpdateUsuario( ) ;
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

      private void LoadRowUsuario( )
      {
         AddRowUsuario( ) ;
      }

      private void ReadRowUsuario( )
      {
         Gx_mode = Deklarit.Utils.Mode.FromRowState(rowUsuario.RowState) ;
         if ( ( rowUsuario.RowState != System.Data.DataRowState.Deleted ) )
         {
            rowUsuario["UsuarioFechaAlta"] = Deklarit.Utils.DateTimeUtil.ResetTimeObject(rowUsuario["UsuarioFechaAlta"]) ;
         }
         if ( ( rowUsuario.RowState != System.Data.DataRowState.Added ) )
         {
            m__UsuarioNombreOriginal = rowUsuario["UsuarioNombre", System.Data.DataRowVersion.Original] ;
            m__UsuarioActivoOriginal = rowUsuario["UsuarioActivo", System.Data.DataRowVersion.Original] ;
            m__UsuarioEmailOriginal = rowUsuario["UsuarioEmail", System.Data.DataRowVersion.Original] ;
            m__UsuarioPaswordOriginal = rowUsuario["UsuarioPasword", System.Data.DataRowVersion.Original] ;
            m__UsuarioFechaAltaOriginal = rowUsuario["UsuarioFechaAlta", System.Data.DataRowVersion.Original] ;
            m__CodigoValidationOriginal = rowUsuario["CodigoValidation", System.Data.DataRowVersion.Original] ;
            m__PersonaIDOriginal = rowUsuario["PersonaID", System.Data.DataRowVersion.Original] ;
         }
         else
         {
            m__UsuarioNombreOriginal = rowUsuario["UsuarioNombre"] ;
            m__UsuarioActivoOriginal = rowUsuario["UsuarioActivo"] ;
            m__UsuarioEmailOriginal = rowUsuario["UsuarioEmail"] ;
            m__UsuarioPaswordOriginal = rowUsuario["UsuarioPasword"] ;
            m__UsuarioFechaAltaOriginal = rowUsuario["UsuarioFechaAlta"] ;
            m__CodigoValidationOriginal = rowUsuario["CodigoValidation"] ;
            m__PersonaIDOriginal = rowUsuario["PersonaID"] ;
         }
         _Gxremove = (bool)((rowUsuario.RowState==System.Data.DataRowState.Deleted)) ;
         if ( _Gxremove )
         {
            rowUsuario = ((UsuarioDataSet.UsuarioRow)(Deklarit.Utils.DataSetUtil.CloneOriginalDataRow(rowUsuario)));
         }
      }

      private void CheckIntegrityErrorsUsuario( )
      {
          IDataReader PersonaSelect1 ;
          ReadWriteCommand cmPersonaSelect1 ;
         cmPersonaSelect1 = connDefault.GetCommand("SELECT [PersonaID] FROM [Persona] WITH (NOLOCK) WHERE [PersonaID] = @PersonaID ", false) ;
         if ( ( cmPersonaSelect1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmPersonaSelect1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaID", System.Data.DbType.Int32));
         }
         cmPersonaSelect1.SetParameter(0, rowUsuario["PersonaID"]);
         PersonaSelect1 = cmPersonaSelect1.FetchData() ;
         if ( !cmPersonaSelect1.HasMoreRows )
         {
            PersonaSelect1.Close();
            throw new PersonaForeignKeyNotFoundException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("inex"), new   object[]  {resourceManagerTables.GetString("Persona")})) ;
         }
         PersonaSelect1.Close();
         throw new ForeignKeyNotFoundException( resourceManager.GetString("refinterror")) ;
      }

      private void GetByPrimaryKey( )
      {
          IDataReader UsuarioSelect3 ;
          ReadWriteCommand cmUsuarioSelect3 ;
         cmUsuarioSelect3 = connDefault.GetCommand("SELECT [UsuarioID], [UsuarioNombre], [UsuarioActivo], [UsuarioEmail], [UsuarioPasword], [UsuarioFechaAlta], [CodigoValidation], [PersonaID] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioID] = @UsuarioID ", false) ;
         if ( ( cmUsuarioSelect3.IDbCommand.Parameters.Count == 0 ) )
         {
            cmUsuarioSelect3.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioID", System.Data.DbType.Int32));
         }
         cmUsuarioSelect3.SetParameter(0, rowUsuario["UsuarioID"]);
         UsuarioSelect3 = cmUsuarioSelect3.FetchData() ;
         if ( cmUsuarioSelect3.HasMoreRows )
         {
            RcdFound7 = 1 ;
            rowUsuario["UsuarioID"] = dsDefault.Db.GetInt32(UsuarioSelect3, 0) ;
            rowUsuario["UsuarioNombre"] = dsDefault.Db.GetString(UsuarioSelect3, 1) ;
            rowUsuario["UsuarioActivo"] = dsDefault.Db.GetString(UsuarioSelect3, 2) ;
            rowUsuario["UsuarioEmail"] = dsDefault.Db.GetString(UsuarioSelect3, 3) ;
            rowUsuario["UsuarioPasword"] = dsDefault.Db.GetString(UsuarioSelect3, 4) ;
            rowUsuario["UsuarioFechaAlta"] = dsDefault.Db.GetDateTime(UsuarioSelect3, 5) ;
            rowUsuario["CodigoValidation"] = dsDefault.Db.GetString(UsuarioSelect3, 6) ;
            rowUsuario["PersonaID"] = dsDefault.Db.GetInt32(UsuarioSelect3, 7) ;
            sMode7 = Gx_mode ;
            Gx_mode = Mode.Display ;
            Gx_mode = sMode7 ;
         }
         else
         {
            RcdFound7 = 0 ;
         }
         UsuarioSelect3.Close();
      }

      private void CheckOptimisticConcurrencyUsuario( )
      {
          IDataReader UsuarioSelect4 ;
          ReadWriteCommand cmUsuarioSelect4 ;
         if ( ( Gx_mode != Mode.Insert ) )
         {
            cmUsuarioSelect4 = connDefault.GetCommand("SELECT [UsuarioID], [UsuarioNombre], [UsuarioActivo], [UsuarioEmail], [UsuarioPasword], [UsuarioFechaAlta], [CodigoValidation], [PersonaID] FROM [Usuario] WITH (UPDLOCK) WHERE [UsuarioID] = @UsuarioID ", false) ;
            if ( ( cmUsuarioSelect4.IDbCommand.Parameters.Count == 0 ) )
            {
               cmUsuarioSelect4.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioID", System.Data.DbType.Int32));
            }
            cmUsuarioSelect4.SetParameter(0, rowUsuario["UsuarioID"]);
            UsuarioSelect4 = cmUsuarioSelect4.FetchData() ;
            if ( cmUsuarioSelect4.Locked )
            {
               UsuarioSelect4.Close();
               throw new UsuarioDataLockedException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("lock"), new   object[]  {resourceManagerTables.GetString("Usuario")})) ;
            }
            _Condition = false ;
            if ( !cmUsuarioSelect4.HasMoreRows || ( ! StringUtil.ObjectStringEquals(m__UsuarioNombreOriginal,dsDefault.Db.GetString(UsuarioSelect4, 1)) ) || ( ! StringUtil.ObjectStringEquals(m__UsuarioActivoOriginal,dsDefault.Db.GetString(UsuarioSelect4, 2)) ) || ( ! StringUtil.ObjectStringEquals(m__UsuarioEmailOriginal,dsDefault.Db.GetString(UsuarioSelect4, 3)) ) || ( ! StringUtil.ObjectStringEquals(m__UsuarioPaswordOriginal,dsDefault.Db.GetString(UsuarioSelect4, 4)) ) || ( ! DateTimeUtil.ObjectDateEquals(m__UsuarioFechaAltaOriginal,dsDefault.Db.GetDateTime(UsuarioSelect4, 5)) ) )
            {
               _Condition = true ;
            }
            if ( _Condition || ( ! StringUtil.ObjectStringEquals(m__CodigoValidationOriginal,dsDefault.Db.GetString(UsuarioSelect4, 6)) ) || ( ! m__PersonaIDOriginal.Equals(dsDefault.Db.GetInt32(UsuarioSelect4, 7)) ) )
            {
               UsuarioSelect4.Close();
               throw new UsuarioDataChangedException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("waschg"), new   object[]  {resourceManagerTables.GetString("Usuario")})) ;
            }
            UsuarioSelect4.Close();
         }
      }

      private void InsertUsuario( )
      {
          IDataReader UsuarioInsert1 ;
          ReadWriteCommand cmUsuarioInsert1 ;
         CheckOptimisticConcurrencyUsuario( ) ;
         AfterConfirmUsuario( ) ;
         cmUsuarioInsert1 = connDefault.GetCommand("INSERT INTO [Usuario] ([UsuarioNombre], [UsuarioActivo], [UsuarioEmail], [UsuarioPasword], [UsuarioFechaAlta], [CodigoValidation], [PersonaID]) VALUES (@UsuarioNombre, @UsuarioActivo, @UsuarioEmail, @UsuarioPasword, @UsuarioFechaAlta, @CodigoValidation, @PersonaID); SELECT SCOPE_IDENTITY()", false) ;
         if ( ( cmUsuarioInsert1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmUsuarioInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioNombre", System.Data.DbType.AnsiString,50));
            cmUsuarioInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioActivo", System.Data.DbType.AnsiString,1));
            cmUsuarioInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioEmail", System.Data.DbType.AnsiString,60));
            cmUsuarioInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioPasword", System.Data.DbType.AnsiString,70));
            cmUsuarioInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioFechaAlta", System.Data.DbType.Date));
            cmUsuarioInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@CodigoValidation", System.Data.DbType.AnsiString,4));
            cmUsuarioInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaID", System.Data.DbType.Int32));
         }
         cmUsuarioInsert1.ErrorMask = cmUsuarioInsert1.ErrorMask  |  ErrorMask.ForeignKeyError;
         cmUsuarioInsert1.ErrorMask = cmUsuarioInsert1.ErrorMask  |  ErrorMask.DuplicateKeyError;
         cmUsuarioInsert1.SetParameter(0, rowUsuario["UsuarioNombre"]);
         cmUsuarioInsert1.SetParameter(1, rowUsuario["UsuarioActivo"]);
         cmUsuarioInsert1.SetParameter(2, rowUsuario["UsuarioEmail"]);
         cmUsuarioInsert1.SetParameter(3, rowUsuario["UsuarioPasword"]);
         cmUsuarioInsert1.SetParameterDateObject(4, rowUsuario["UsuarioFechaAlta"]);
         cmUsuarioInsert1.SetParameter(5, rowUsuario["CodigoValidation"]);
         cmUsuarioInsert1.SetParameter(6, rowUsuario["PersonaID"]);
         UsuarioInsert1 = cmUsuarioInsert1.FetchData() ;
         if ( ! ( cmUsuarioInsert1.ForeignKeyError || cmUsuarioInsert1.DupKey ) )
         {
            rowUsuario.UsuarioID = (int)(UsuarioInsert1.GetDecimal(0)) ;
            UsuarioInsert1.Close();
         }
         if ( cmUsuarioInsert1.ForeignKeyError )
         {
            CheckIntegrityErrorsUsuario( ) ;
         }
         // Start of After( Insert) rules
         // End of After( Insert) rules
         OnUsuarioUpdated( new UsuarioEventArgs( rowUsuario, Mode.Insert)) ;
         // Save values for previous() function.
         EndLevelUsuario( ) ;
      }

      private void UpdateUsuario( )
      {
          ReadWriteCommand cmUsuarioUpdate1 ;
         CheckOptimisticConcurrencyUsuario( ) ;
         AfterConfirmUsuario( ) ;
         cmUsuarioUpdate1 = connDefault.GetCommand("UPDATE [Usuario] SET [UsuarioNombre]=@UsuarioNombre, [UsuarioActivo]=@UsuarioActivo, [UsuarioEmail]=@UsuarioEmail, [UsuarioPasword]=@UsuarioPasword, [UsuarioFechaAlta]=@UsuarioFechaAlta, [CodigoValidation]=@CodigoValidation, [PersonaID]=@PersonaID  WHERE [UsuarioID] = @UsuarioID", false) ;
         if ( ( cmUsuarioUpdate1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmUsuarioUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioNombre", System.Data.DbType.AnsiString,50));
            cmUsuarioUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioActivo", System.Data.DbType.AnsiString,1));
            cmUsuarioUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioEmail", System.Data.DbType.AnsiString,60));
            cmUsuarioUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioPasword", System.Data.DbType.AnsiString,70));
            cmUsuarioUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioFechaAlta", System.Data.DbType.Date));
            cmUsuarioUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@CodigoValidation", System.Data.DbType.AnsiString,4));
            cmUsuarioUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaID", System.Data.DbType.Int32));
            cmUsuarioUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioID", System.Data.DbType.Int32));
         }
         cmUsuarioUpdate1.ErrorMask = cmUsuarioUpdate1.ErrorMask  |  ErrorMask.ForeignKeyError;
         // Using cursor UsuarioUpdate1
         cmUsuarioUpdate1.SetParameter(0, rowUsuario["UsuarioNombre"]);
         cmUsuarioUpdate1.SetParameter(1, rowUsuario["UsuarioActivo"]);
         cmUsuarioUpdate1.SetParameter(2, rowUsuario["UsuarioEmail"]);
         cmUsuarioUpdate1.SetParameter(3, rowUsuario["UsuarioPasword"]);
         cmUsuarioUpdate1.SetParameterDateObject(4, rowUsuario["UsuarioFechaAlta"]);
         cmUsuarioUpdate1.SetParameter(5, rowUsuario["CodigoValidation"]);
         cmUsuarioUpdate1.SetParameter(6, rowUsuario["PersonaID"]);
         cmUsuarioUpdate1.SetParameter(7, rowUsuario["UsuarioID"]);
         cmUsuarioUpdate1.ExecuteStmt();
         if ( cmUsuarioUpdate1.ForeignKeyError )
         {
            CheckIntegrityErrorsUsuario( ) ;
         }
         // Start of After( update) rules
         // End of After( update) rules
         OnUsuarioUpdated( new UsuarioEventArgs( rowUsuario, Mode.Update)) ;
         EndLevelUsuario( ) ;
      }

      private void Delete( )
      {
          ReadWriteCommand cmUsuarioDelete1 ;
         Gx_mode = Mode.Delete ;
         CheckOptimisticConcurrencyUsuario( ) ;
         // No cascading delete specified.
         AfterConfirmUsuario( ) ;
         cmUsuarioDelete1 = connDefault.GetCommand("DELETE FROM [Usuario]  WHERE [UsuarioID] = @UsuarioID", false) ;
         if ( ( cmUsuarioDelete1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmUsuarioDelete1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioID", System.Data.DbType.Int32));
         }
         cmUsuarioDelete1.ErrorMask = cmUsuarioDelete1.ErrorMask  |  ErrorMask.ForeignKeyError;
         // Using cursor UsuarioDelete1
         cmUsuarioDelete1.SetParameter(0, rowUsuario["UsuarioID"]);
         cmUsuarioDelete1.ExecuteStmt();
         if ( cmUsuarioDelete1.ForeignKeyError )
         {
            CheckDeleteErrorsUsuario( ) ;
         }
         // Start of After( delete) rules
         // End of After( delete) rules
         OnUsuarioUpdated( new UsuarioEventArgs( rowUsuario, Mode.Delete)) ;
         rowUsuario.Delete( ) ;
         sMode7 = Gx_mode ;
         Gx_mode = Mode.Delete ;
         EndLevelUsuario( ) ;
         Gx_mode = sMode7 ;
      }

      private void CheckDeleteErrorsUsuario( )
      {
          IDataReader RolUsuarioSelect1 ;
          ReadWriteCommand cmRolUsuarioSelect1 ;
         cmRolUsuarioSelect1 = connDefault.GetCommand("SELECT TOP 1 [RolUsuarioID] FROM [RolUsuario] WITH (NOLOCK) WHERE [UsuarioID] = @UsuarioID ", false) ;
         if ( ( cmRolUsuarioSelect1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmRolUsuarioSelect1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioID", System.Data.DbType.Int32));
         }
         cmRolUsuarioSelect1.SetParameter(0, rowUsuario["UsuarioID"]);
         RolUsuarioSelect1 = cmRolUsuarioSelect1.FetchData() ;
         if ( cmRolUsuarioSelect1.HasMoreRows )
         {
            RolUsuarioSelect1.Close();
            throw new RolUsuarioInvalidDeleteException( string.Format(resourceManager.GetString("del"), new   object[]  {"RolUsuario"})) ;
         }
         RolUsuarioSelect1.Close();
      }

      private void EndLevelUsuario( )
      {
         // Execute 'After Trn' event if defined.
         IsModified = 0 ;
      }

      private void ScanByUsuarioID( int startRow ,
                                    int maxRows )
      {
         m_WhereString = " WHERE TM1.[UsuarioID] = @UsuarioID" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString7 + "  FROM [Usuario] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[UsuarioID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString7 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[UsuarioID] ) AS DK_PAGENUM   FROM [Usuario] TM1 WITH (NOLOCK) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString7 + " FROM [Usuario] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[UsuarioID] " ;
         }
         cmUsuarioSelect5 = connDefault.GetCommand(scmdbuf, false) ;
         if ( ( cmUsuarioSelect5.IDbCommand.Parameters.Count == 0 ) )
         {
            cmUsuarioSelect5.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioID", System.Data.DbType.Int32));
         }
         cmUsuarioSelect5.SetParameter(0, rowUsuario["UsuarioID"]);
         UsuarioSelect5 = cmUsuarioSelect5.FetchData() ;
         RcdFound7 = 0 ;
         ScanLoadUsuario( ) ;
         LoadDataUsuario( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanByPersonaID( int startRow ,
                                    int maxRows )
      {
         m_WhereString = " WHERE TM1.[PersonaID] = @PersonaID" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString7 + "  FROM [Usuario] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[UsuarioID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString7 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[UsuarioID] ) AS DK_PAGENUM   FROM [Usuario] TM1 WITH (NOLOCK) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString7 + " FROM [Usuario] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[UsuarioID] " ;
         }
         cmUsuarioSelect5 = connDefault.GetCommand(scmdbuf, false) ;
         if ( ( cmUsuarioSelect5.IDbCommand.Parameters.Count == 0 ) )
         {
            cmUsuarioSelect5.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaID", System.Data.DbType.Int32));
         }
         cmUsuarioSelect5.SetParameter(0, rowUsuario["PersonaID"]);
         UsuarioSelect5 = cmUsuarioSelect5.FetchData() ;
         RcdFound7 = 0 ;
         ScanLoadUsuario( ) ;
         LoadDataUsuario( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanStartUsuario( int startRow ,
                                     int maxRows )
      {
         m_WhereString = "" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString7 + "  FROM [Usuario] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[UsuarioID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString7 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[UsuarioID] ) AS DK_PAGENUM   FROM [Usuario] TM1 WITH (NOLOCK) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString7 + " FROM [Usuario] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[UsuarioID] " ;
         }
         cmUsuarioSelect5 = connDefault.GetCommand(scmdbuf, false) ;
         UsuarioSelect5 = cmUsuarioSelect5.FetchData() ;
         RcdFound7 = 0 ;
         ScanLoadUsuario( ) ;
         LoadDataUsuario( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanNextUsuario( )
      {
         cmUsuarioSelect5.HasMoreRows = UsuarioSelect5.Read() ;
         RcdFound7 = 0 ;
         ScanLoadUsuario( ) ;
      }

      private void ScanLoadUsuario( )
      {
         Gx_mode = Mode.Display ;
         if ( cmUsuarioSelect5.HasMoreRows )
         {
            RcdFound7 = 1 ;
            rowUsuario["UsuarioID"] = dsDefault.Db.GetInt32(UsuarioSelect5, 0) ;
            rowUsuario["UsuarioNombre"] = dsDefault.Db.GetString(UsuarioSelect5, 1) ;
            rowUsuario["UsuarioActivo"] = dsDefault.Db.GetString(UsuarioSelect5, 2) ;
            rowUsuario["UsuarioEmail"] = dsDefault.Db.GetString(UsuarioSelect5, 3) ;
            rowUsuario["UsuarioPasword"] = dsDefault.Db.GetString(UsuarioSelect5, 4) ;
            rowUsuario["UsuarioFechaAlta"] = dsDefault.Db.GetDateTime(UsuarioSelect5, 5) ;
            rowUsuario["CodigoValidation"] = dsDefault.Db.GetString(UsuarioSelect5, 6) ;
            rowUsuario["PersonaID"] = dsDefault.Db.GetInt32(UsuarioSelect5, 7) ;
         }
      }

      private void ScanEndUsuario( )
      {
         UsuarioSelect5.Close();
      }

      private void AfterConfirmUsuario( )
      {
         // After Confirm Rules
         OnUsuarioUpdating( new UsuarioEventArgs( rowUsuario, Gx_mode)) ;
      }

      private void CreateNewRowUsuario( )
      {
         rowUsuario = UsuarioSet.Usuario.NewUsuarioRow() ;
      }

      private void LoadChildUsuario( int startRow ,
                                     int maxRows )
      {
         CreateNewRowUsuario( ) ;
         bool tmpConstraintState = UsuarioSet.EnforceConstraints ;
         UsuarioSet.Usuario.BeginLoadData( ) ;
         ScanStartUsuario( startRow, maxRows) ;
         UsuarioSet.Usuario.EndLoadData( ) ;
         this.UsuarioSet.EnforceConstraints = tmpConstraintState ;
      }

      private void LoadDataUsuario( int maxRows )
      {
         int loadedRows = 0 ;
         if ( ( RcdFound7 != 0 ) )
         {
            ScanLoadUsuario( ) ;
            while ( ( RcdFound7 != 0 ) && ( loadedRows != maxRows ) )
            {
               loadedRows++ ;
               LoadRowUsuario( ) ;
               CreateNewRowUsuario( ) ;
               ScanNextUsuario( ) ;
            }
         }
         if ( ( loadedRows > 0 ) )
         {
            RcdFound7 = 1 ;
         }
         ScanEndUsuario( ) ;
         if ( ( UsuarioSet.Usuario.Count > 0 ) )
         {
            rowUsuario = UsuarioSet.Usuario[UsuarioSet.Usuario.Count -1] ;
         }
      }

      private void LoadByUsuarioID( int startRow ,
                                    int maxRows )
      {
         bool tmpConstraintState = UsuarioSet.EnforceConstraints ;
         UsuarioSet.Usuario.BeginLoadData( ) ;
         ScanByUsuarioID( startRow, maxRows) ;
         UsuarioSet.Usuario.EndLoadData( ) ;
         this.UsuarioSet.EnforceConstraints = tmpConstraintState ;
         if ( ( UsuarioSet.Usuario.Count > 0 ) )
         {
            rowUsuario = UsuarioSet.Usuario[UsuarioSet.Usuario.Count -1] ;
         }
      }

      private void LoadByPersonaID( int startRow ,
                                    int maxRows )
      {
         bool tmpConstraintState = UsuarioSet.EnforceConstraints ;
         UsuarioSet.Usuario.BeginLoadData( ) ;
         ScanByPersonaID( startRow, maxRows) ;
         UsuarioSet.Usuario.EndLoadData( ) ;
         this.UsuarioSet.EnforceConstraints = tmpConstraintState ;
         if ( ( UsuarioSet.Usuario.Count > 0 ) )
         {
            rowUsuario = UsuarioSet.Usuario[UsuarioSet.Usuario.Count -1] ;
         }
      }

      private void AddRowUsuario( )
      {
         UsuarioSet.Usuario.AddUsuarioRow( rowUsuario) ;
      }

      private readonly string m_SelectString7 = "TM1.[UsuarioID], TM1.[UsuarioNombre], TM1.[UsuarioActivo], TM1.[UsuarioEmail], TM1.[UsuarioPasword], TM1.[UsuarioFechaAlta], TM1.[CodigoValidation], TM1.[PersonaID]" ;


      public delegate  void UsuarioUpdateEventHandler( object sender ,
                                                       UsuarioEventArgs e );
      public event UsuarioUpdateEventHandler UsuarioUpdated ;
      private void OnUsuarioUpdated( UsuarioEventArgs e )
      {
         if ( ( this.UsuarioUpdated != null ) )
         {
            this.UsuarioUpdated( this, e) ;
         }
      }

      public event UsuarioUpdateEventHandler UsuarioUpdating ;
      private void OnUsuarioUpdating( UsuarioEventArgs e )
      {
         if ( ( this.UsuarioUpdating != null ) )
         {
            this.UsuarioUpdating( this, e) ;
         }
      }

      public class UsuarioEventArgs : EventArgs
      {
         private System.Data.StatementType m_statementType ;
         private UsuarioDataSet.UsuarioRow m_dataRow ;
         public UsuarioEventArgs( UsuarioDataSet.UsuarioRow row ,
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

         public UsuarioDataSet.UsuarioRow Row
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
      public class UsuarioNotFoundException : Deklarit.DataNotFoundException
      {
         public UsuarioNotFoundException( )
         {
         }

         public UsuarioNotFoundException( string message ) : base(message)
         {
         }

         public UsuarioNotFoundException( string message ,
                                          Exception inner ) : base(message, inner)
         {
         }

         protected UsuarioNotFoundException( SerializationInfo info ,
                                             StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class PersonaForeignKeyNotFoundException : Deklarit.ForeignKeyNotFoundException
      {
         public PersonaForeignKeyNotFoundException( )
         {
         }

         public PersonaForeignKeyNotFoundException( string message ) : base(message)
         {
         }

         public PersonaForeignKeyNotFoundException( string message ,
                                                    Exception inner ) : base(message, inner)
         {
         }

         protected PersonaForeignKeyNotFoundException( SerializationInfo info ,
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
      public class UsuarioDataLockedException : Deklarit.DataLockedException
      {
         public UsuarioDataLockedException( )
         {
         }

         public UsuarioDataLockedException( string message ) : base(message)
         {
         }

         public UsuarioDataLockedException( string message ,
                                            Exception inner ) : base(message, inner)
         {
         }

         protected UsuarioDataLockedException( SerializationInfo info ,
                                               StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class UsuarioDataChangedException : Deklarit.DataChangedException
      {
         public UsuarioDataChangedException( )
         {
         }

         public UsuarioDataChangedException( string message ) : base(message)
         {
         }

         public UsuarioDataChangedException( string message ,
                                             Exception inner ) : base(message, inner)
         {
         }

         protected UsuarioDataChangedException( SerializationInfo info ,
                                                StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class RolUsuarioInvalidDeleteException : Deklarit.InvalidDeleteException
      {
         public RolUsuarioInvalidDeleteException( )
         {
         }

         public RolUsuarioInvalidDeleteException( string message ) : base(message)
         {
         }

         public RolUsuarioInvalidDeleteException( string message ,
                                                  Exception inner ) : base(message, inner)
         {
         }

         protected RolUsuarioInvalidDeleteException( SerializationInfo info ,
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
         RcdFound7 = 0 ;
         scmdbuf = "" ;
         recordCount = 0 ;
         _Gxremove = false ;
         m__UsuarioNombreOriginal = new object();
         m__UsuarioActivoOriginal = new object();
         m__UsuarioEmailOriginal = new object();
         m__UsuarioPaswordOriginal = new object();
         m__UsuarioFechaAltaOriginal = new object();
         m__CodigoValidationOriginal = new object();
         m__PersonaIDOriginal = new object();
         _Condition = false ;
         IsModified = 0 ;
         m_WhereString = "" ;
         if ( ( this.Transaction == null ) )
         {
            this.Transaction = ((System.Data.IDbTransaction)(System.Threading.Thread.GetData(System.Threading.Thread.GetNamedDataSlot(DeklaritTransaction.TransactionSlotName)) ));
         }
      }

      private short RcdFound7 ;
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
      private ReadWriteCommand cmUsuarioSelect1 ;
      private IDataReader UsuarioSelect1 ;
      private ReadWriteCommand cmUsuarioSelect2 ;
      private IDataReader UsuarioSelect2 ;
      private ReadWriteCommand cmUsuarioSelect5 ;
      private IDataReader UsuarioSelect5 ;
      private System.Data.StatementType Gx_mode ;
      private System.Data.StatementType sMode7 ;
      private object m__UsuarioNombreOriginal ;
      private object m__UsuarioActivoOriginal ;
      private object m__UsuarioEmailOriginal ;
      private object m__UsuarioPaswordOriginal ;
      private object m__UsuarioFechaAltaOriginal ;
      private object m__CodigoValidationOriginal ;
      private object m__PersonaIDOriginal ;
   }

   public class UsuarioDataReader : System.IDisposable
   {
      public UsuarioDataReader( )
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
      ///   Gets or sets the Transaction object to be used  by  UsuarioDataReaderDeklarit DataReaderclasses
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
         cmUsuarioSelect6 = connDefault.GetCommand("SELECT TM1.[UsuarioID], TM1.[UsuarioNombre], TM1.[UsuarioActivo], TM1.[UsuarioEmail], TM1.[UsuarioPasword], TM1.[UsuarioFechaAlta], TM1.[CodigoValidation], TM1.[PersonaID] FROM [Usuario] TM1 WITH (NOLOCK) ORDER BY TM1.[UsuarioID] ", false) ;
         UsuarioSelect6 = cmUsuarioSelect6.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return UsuarioSelect6 ;
      }

      public IDataReader OpenByUsuarioID( int usuarioID )
      {
         init_reader( ) ;
         m_Closed = false ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmUsuarioSelect6 = connDefault.GetCommand("SELECT TM1.[UsuarioID], TM1.[UsuarioNombre], TM1.[UsuarioActivo], TM1.[UsuarioEmail], TM1.[UsuarioPasword], TM1.[UsuarioFechaAlta], TM1.[CodigoValidation], TM1.[PersonaID] FROM [Usuario] TM1 WITH (NOLOCK) WHERE TM1.[UsuarioID] = @UsuarioID ORDER BY TM1.[UsuarioID] ", false) ;
         if ( ( cmUsuarioSelect6.IDbCommand.Parameters.Count == 0 ) )
         {
            cmUsuarioSelect6.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioID", System.Data.DbType.Int32));
         }
         cmUsuarioSelect6.SetParameter(0, usuarioID);
         UsuarioSelect6 = cmUsuarioSelect6.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return UsuarioSelect6 ;
      }

      public IDataReader OpenByPersonaID( int personaID )
      {
         init_reader( ) ;
         m_Closed = false ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmUsuarioSelect6 = connDefault.GetCommand("SELECT TM1.[UsuarioID], TM1.[UsuarioNombre], TM1.[UsuarioActivo], TM1.[UsuarioEmail], TM1.[UsuarioPasword], TM1.[UsuarioFechaAlta], TM1.[CodigoValidation], TM1.[PersonaID] FROM [Usuario] TM1 WITH (NOLOCK) WHERE TM1.[PersonaID] = @PersonaID ORDER BY TM1.[UsuarioID] ", false) ;
         if ( ( cmUsuarioSelect6.IDbCommand.Parameters.Count == 0 ) )
         {
            cmUsuarioSelect6.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaID", System.Data.DbType.Int32));
         }
         cmUsuarioSelect6.SetParameter(0, personaID);
         UsuarioSelect6 = cmUsuarioSelect6.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return UsuarioSelect6 ;
      }

      public int DeleteByPersonaID( int personaID )
      {
         init_reader( ) ;
         int intCount = 0 ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmUsuarioDelete2 = connDefault.GetCommand("DELETE FROM [Usuario]  WHERE [PersonaID] = @PersonaID", false) ;
         if ( ( cmUsuarioDelete2.IDbCommand.Parameters.Count == 0 ) )
         {
            cmUsuarioDelete2.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaID", System.Data.DbType.Int32));
         }
         // Using cursor UsuarioDelete2
         cmUsuarioDelete2.SetParameter(0, personaID);
         intCount = cmUsuarioDelete2.ExecuteStmt() ;
         return intCount ;
      }

      public void Dispose( )
      {
         if ( ! m_Disposed )
         {
            m_Disposed = true ;
            try
            {
               if ( ! m_Closed && ( UsuarioSelect6 != null ) )
               {
                  m_Closed = true ;
                  UsuarioSelect6.Close();
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
      private ReadWriteCommand cmUsuarioSelect6 ;
      private IDataReader UsuarioSelect6 ;
      private ReadWriteCommand cmUsuarioDelete2 ;
   }

}
