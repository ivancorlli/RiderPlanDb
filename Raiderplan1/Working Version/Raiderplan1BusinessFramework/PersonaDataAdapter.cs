
//               File: PersonaDataAdapter
//        Description: Persona
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
   public partial class PersonaDataAdapter : System.Data.IDataAdapter, IPersonaDataAdapter
   {
      private PersonaDataSet PersonaSet ;
      private IDbTransaction daCurrentTransaction ;
      private PersonaDataSet.PersonaRow rowPersona ;
      public PersonaDataAdapter( )
      {
      }

      private void InitializeMembers( )
      {
         PersonaSet = new PersonaDataSet() ;
         this.Initialize( ) ;
         dsDefault = new DataStore( new SqlServer2005Handler( ), "System.Data.SqlClient", Raiderplan1.Configuration.ConnectionString, DeklaritTransaction.TransactionSlotName) ;
      }

      ///  <summary>
      ///   Gets or sets the Transaction object to be used  by  PersonaDataAdapterclasses to
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
      ///   (2) Fills the specified Dataset with the record matching PersonaID field(s) of the
      ///    given IDataRecord
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="dataRecord">Data Record</param>
      public virtual int Fill( PersonaDataSet dataSet ,
                               IDataRecord dataRecord )
      {
         return Fill(dataSet, ((int)(dataRecord["PersonaID"]))) ;
      }

      ///  <summary>
      ///   (3) Fills the specified Dataset with the record matching PersonaID field(s) of the
      ///    given DataRow
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="dataRecord">Data Row</param>
      public virtual int Fill( PersonaDataSet dataSet ,
                               DataRow dataRecord )
      {
         return Fill(dataSet, ((int)(dataRecord["PersonaID"]))) ;
      }

      ///  <summary>
      ///   (4) Fills the specified Dataset with the record matching PersonaID, if the record
      ///    is not found , throws an exception.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="personaID">Persona ID</param>
      public virtual int Fill( PersonaDataSet dataSet ,
                               int personaID )
      {
         if ( ! FillByPersonaID( dataSet, personaID) )
         {
            throw new PersonaNotFoundException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("inex"), new   object[]  {resourceManagerTables.GetString("Persona")})) ;
         }
         return 0 ;
      }


      ///  <summary>
      ///   (5) Fills the specified Dataset with the record matching PersonaID in the fillDataParameters
      ///    array, if the array is null, it fills the Dataset loading all records in the table.
      ///
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Fill( PersonaDataSet dataSet )
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
               PersonaSet = dataSet ;
               LoadChildPersona( 0, -1) ;
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
      ///   (6) Fills the specified dataset filtered by PersonaIDfield(s).
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      ///  <param name="personaID">Persona ID</param>
      public virtual bool FillByPersonaID( PersonaDataSet dataSet ,
                                           int personaID )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         PersonaSet = dataSet ;
         rowPersona = PersonaSet.Persona.NewPersonaRow() ;
         rowPersona.PersonaID = personaID ;
         try
         {
            LoadByPersonaID( 0, -1) ;
            dataSet.AcceptChanges( ) ;
         }
         finally
         {
            this.Cleanup();
         }
         if ( ( RcdFound1 == 0 ) )
         {
            return false ;
         }
         return true ;
      }


      ///  <summary>
      ///   (8) Fills the specified dataset with the record matching PersonaID in the the fillDataParameters
      ///    array, if the array is null, it fills the Dataset loading all records in the table.
      ///
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Fill( DataSet dataSet )
      {
         PersonaSet = dataSet as PersonaDataSet ;
         if ( ( PersonaSet != null ) )
         {
            return Fill( PersonaSet) ;
         }
         else
         {
            PersonaSet = new PersonaDataSet() ;
            Fill( PersonaSet) ;
            dataSet.Merge( PersonaSet) ;
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
      public virtual int FillPage( PersonaDataSet dataSet ,
                                   int startRow ,
                                   int maxRows )
      {
         InitializeMembers( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         PersonaSet = dataSet ;
         try
         {
            LoadChildPersona( startRow, maxRows) ;
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
         cmPersonaSelect1 = connDefault.GetCommand("SELECT COUNT(*) FROM [Persona] WITH (NOLOCK) ", false) ;
         PersonaSelect1 = cmPersonaSelect1.FetchData() ;
         recordCount = ( ( PersonaSelect1.IsDBNull(0) )  ? (int)(0) : PersonaSelect1.GetInt32(0) ) ;
         PersonaSelect1.Close();
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
            DbParameter parm0PersonaID ;
            parm0PersonaID = factory.CreateParameter() ;
            parm0PersonaID.ParameterName = "PersonaID" ;
            parm0PersonaID.DbType = System.Data.DbType.Int32 ;
            fillDataParameters = new  DbParameter[]  {parm0PersonaID} ;
         }
         return fillDataParameters ;
      }

      private DbParameter[] fillDataParameters ;

      ///  <summary>
      ///   Inserts, Updates or Deletes records from the specified PersonaDataSet object.
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Update( DataSet dataSet )
      {
         InitializeMembers( ) ;
         PersonaSet = dataSet as PersonaDataSet ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         if ( ( PersonaSet != null ) )
         {
            try
            {
               connDefault.BeginTransaction();
               foreach( PersonaDataSet.PersonaRow row in PersonaSet.Persona )
               {
                  rowPersona = row ;
                  if ( Deklarit.Data.Helpers.IsRowChanged(rowPersona) )
                  {
                     ReadRowPersona( ) ;
                     if ( ( rowPersona.RowState == System.Data.DataRowState.Added ) )
                     {
                        InsertPersona( ) ;
                     }
                     else
                     {
                        if ( _Gxremove )
                        {
                           Delete( ) ;
                        }
                        else
                        {
                           UpdatePersona( ) ;
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

      private void LoadRowPersona( )
      {
         AddRowPersona( ) ;
      }

      private void ReadRowPersona( )
      {
         Gx_mode = Deklarit.Utils.Mode.FromRowState(rowPersona.RowState) ;
         if ( ( rowPersona.RowState != System.Data.DataRowState.Deleted ) )
         {
            rowPersona["PersonaFechaNacimiento"] = Deklarit.Utils.DateTimeUtil.ResetTimeObject(rowPersona["PersonaFechaNacimiento"]) ;
         }
         if ( ( rowPersona.RowState != System.Data.DataRowState.Added ) )
         {
            m__PersonaNombreOriginal = rowPersona["PersonaNombre", System.Data.DataRowVersion.Original] ;
            m__PersonaApellidoOriginal = rowPersona["PersonaApellido", System.Data.DataRowVersion.Original] ;
            m__PersonaFechaNacimientoOriginal = rowPersona["PersonaFechaNacimiento", System.Data.DataRowVersion.Original] ;
            m__PersonaSexoOriginal = rowPersona["PersonaSexo", System.Data.DataRowVersion.Original] ;
            m__PLocalidadIDOriginal = rowPersona["PLocalidadID", System.Data.DataRowVersion.Original] ;
            m__PProvinciaIDOriginal = rowPersona["PProvinciaID", System.Data.DataRowVersion.Original] ;
            m__ImagenPerfilOriginal = rowPersona["ImagenPerfil", System.Data.DataRowVersion.Original] ;
         }
         else
         {
            m__PersonaNombreOriginal = rowPersona["PersonaNombre"] ;
            m__PersonaApellidoOriginal = rowPersona["PersonaApellido"] ;
            m__PersonaFechaNacimientoOriginal = rowPersona["PersonaFechaNacimiento"] ;
            m__PersonaSexoOriginal = rowPersona["PersonaSexo"] ;
            m__PLocalidadIDOriginal = rowPersona["PLocalidadID"] ;
            m__PProvinciaIDOriginal = rowPersona["PProvinciaID"] ;
            m__ImagenPerfilOriginal = rowPersona["ImagenPerfil"] ;
         }
         _Gxremove = (bool)((rowPersona.RowState==System.Data.DataRowState.Deleted)) ;
         if ( _Gxremove )
         {
            rowPersona = ((PersonaDataSet.PersonaRow)(Deklarit.Utils.DataSetUtil.CloneOriginalDataRow(rowPersona)));
         }
      }

      private void CheckExtendedTablePersona( )
      {
         if ( !  System.Enum.IsDefined(typeof(Sexo),((int)(((short)(rowPersona["PersonaSexo"]))))) )
         {
            throw new PersonaSexoInvalidValue( "Invalid Persona Sexo Value") ;
         }
      }

      private void GetByPrimaryKey( )
      {
          IDataReader PersonaSelect2 ;
          ReadWriteCommand cmPersonaSelect2 ;
         cmPersonaSelect2 = connDefault.GetCommand("SELECT [PersonaID], [PersonaNombre], [PersonaApellido], [PersonaFechaNacimiento], [PersonaSexo], [PLocalidadID], [PProvinciaID], [ImagenPerfil] FROM [Persona] WITH (NOLOCK) WHERE [PersonaID] = @PersonaID ", false) ;
         if ( ( cmPersonaSelect2.IDbCommand.Parameters.Count == 0 ) )
         {
            cmPersonaSelect2.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaID", System.Data.DbType.Int32));
         }
         cmPersonaSelect2.SetParameter(0, rowPersona["PersonaID"]);
         PersonaSelect2 = cmPersonaSelect2.FetchData() ;
         if ( cmPersonaSelect2.HasMoreRows )
         {
            RcdFound1 = 1 ;
            rowPersona["PersonaID"] = dsDefault.Db.GetInt32(PersonaSelect2, 0) ;
            rowPersona["PersonaNombre"] = dsDefault.Db.GetString(PersonaSelect2, 1) ;
            rowPersona["PersonaApellido"] = dsDefault.Db.GetString(PersonaSelect2, 2) ;
            rowPersona["PersonaFechaNacimiento"] = dsDefault.Db.GetDateTime(PersonaSelect2, 3) ;
            rowPersona["PersonaSexo"] = dsDefault.Db.GetInt16(PersonaSelect2, 4) ;
            rowPersona["PLocalidadID"] = dsDefault.Db.GetInt32(PersonaSelect2, 5) ;
            rowPersona["PProvinciaID"] = dsDefault.Db.GetInt32(PersonaSelect2, 6) ;
            rowPersona["ImagenPerfil"] = dsDefault.Db.GetString(PersonaSelect2, 7) ;
            sMode1 = Gx_mode ;
            Gx_mode = Mode.Display ;
            Gx_mode = sMode1 ;
         }
         else
         {
            RcdFound1 = 0 ;
         }
         PersonaSelect2.Close();
      }

      private void CheckOptimisticConcurrencyPersona( )
      {
          IDataReader PersonaSelect3 ;
          ReadWriteCommand cmPersonaSelect3 ;
         if ( ( Gx_mode != Mode.Insert ) )
         {
            cmPersonaSelect3 = connDefault.GetCommand("SELECT [PersonaID], [PersonaNombre], [PersonaApellido], [PersonaFechaNacimiento], [PersonaSexo], [PLocalidadID], [PProvinciaID], [ImagenPerfil] FROM [Persona] WITH (UPDLOCK) WHERE [PersonaID] = @PersonaID ", false) ;
            if ( ( cmPersonaSelect3.IDbCommand.Parameters.Count == 0 ) )
            {
               cmPersonaSelect3.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaID", System.Data.DbType.Int32));
            }
            cmPersonaSelect3.SetParameter(0, rowPersona["PersonaID"]);
            PersonaSelect3 = cmPersonaSelect3.FetchData() ;
            if ( cmPersonaSelect3.Locked )
            {
               PersonaSelect3.Close();
               throw new PersonaDataLockedException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("lock"), new   object[]  {resourceManagerTables.GetString("Persona")})) ;
            }
            _Condition = false ;
            if ( !cmPersonaSelect3.HasMoreRows || ( ! StringUtil.ObjectStringEquals(m__PersonaNombreOriginal,dsDefault.Db.GetString(PersonaSelect3, 1)) ) || ( ! StringUtil.ObjectStringEquals(m__PersonaApellidoOriginal,dsDefault.Db.GetString(PersonaSelect3, 2)) ) || ( ! DateTimeUtil.ObjectDateEquals(m__PersonaFechaNacimientoOriginal,dsDefault.Db.GetDateTime(PersonaSelect3, 3)) ) || ( ! m__PersonaSexoOriginal.Equals(dsDefault.Db.GetInt16(PersonaSelect3, 4)) ) || ( ! m__PLocalidadIDOriginal.Equals(dsDefault.Db.GetInt32(PersonaSelect3, 5)) ) )
            {
               _Condition = true ;
            }
            if ( _Condition || ( ! m__PProvinciaIDOriginal.Equals(dsDefault.Db.GetInt32(PersonaSelect3, 6)) ) || ( ! StringUtil.ObjectStringEquals(m__ImagenPerfilOriginal,dsDefault.Db.GetString(PersonaSelect3, 7)) ) )
            {
               PersonaSelect3.Close();
               throw new PersonaDataChangedException( string.Format( System.Globalization.CultureInfo.InvariantCulture, resourceManager.GetString("waschg"), new   object[]  {resourceManagerTables.GetString("Persona")})) ;
            }
            PersonaSelect3.Close();
         }
      }

      private void InsertPersona( )
      {
          IDataReader PersonaInsert1 ;
          ReadWriteCommand cmPersonaInsert1 ;
         CheckOptimisticConcurrencyPersona( ) ;
         CheckExtendedTablePersona( ) ;
         AfterConfirmPersona( ) ;
         cmPersonaInsert1 = connDefault.GetCommand("INSERT INTO [Persona] ([PersonaNombre], [PersonaApellido], [PersonaFechaNacimiento], [PersonaSexo], [PLocalidadID], [PProvinciaID], [ImagenPerfil]) VALUES (@PersonaNombre, @PersonaApellido, @PersonaFechaNacimiento, @PersonaSexo, @PLocalidadID, @PProvinciaID, @ImagenPerfil); SELECT SCOPE_IDENTITY()", false) ;
         if ( ( cmPersonaInsert1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmPersonaInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaNombre", System.Data.DbType.AnsiString,120));
            cmPersonaInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaApellido", System.Data.DbType.AnsiString,120));
            cmPersonaInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaFechaNacimiento", System.Data.DbType.Date));
            cmPersonaInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaSexo", System.Data.DbType.Int16));
            cmPersonaInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PLocalidadID", System.Data.DbType.Int32));
            cmPersonaInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PProvinciaID", System.Data.DbType.Int32));
            cmPersonaInsert1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ImagenPerfil", System.Data.DbType.AnsiString,50));
         }
         cmPersonaInsert1.ErrorMask = cmPersonaInsert1.ErrorMask  |  ErrorMask.DuplicateKeyError;
         cmPersonaInsert1.SetParameter(0, rowPersona["PersonaNombre"]);
         cmPersonaInsert1.SetParameter(1, rowPersona["PersonaApellido"]);
         cmPersonaInsert1.SetParameterDateObject(2, rowPersona["PersonaFechaNacimiento"]);
         cmPersonaInsert1.SetParameter(3, rowPersona["PersonaSexo"]);
         cmPersonaInsert1.SetParameter(4, rowPersona["PLocalidadID"]);
         cmPersonaInsert1.SetParameter(5, rowPersona["PProvinciaID"]);
         cmPersonaInsert1.SetParameter(6, rowPersona["ImagenPerfil"]);
         PersonaInsert1 = cmPersonaInsert1.FetchData() ;
         rowPersona.PersonaID = (int)(PersonaInsert1.GetDecimal(0)) ;
         PersonaInsert1.Close();
         // Start of After( Insert) rules
         // End of After( Insert) rules
         OnPersonaUpdated( new PersonaEventArgs( rowPersona, Mode.Insert)) ;
         // Save values for previous() function.
         EndLevelPersona( ) ;
      }

      private void UpdatePersona( )
      {
          ReadWriteCommand cmPersonaUpdate1 ;
         CheckOptimisticConcurrencyPersona( ) ;
         CheckExtendedTablePersona( ) ;
         AfterConfirmPersona( ) ;
         cmPersonaUpdate1 = connDefault.GetCommand("UPDATE [Persona] SET [PersonaNombre]=@PersonaNombre, [PersonaApellido]=@PersonaApellido, [PersonaFechaNacimiento]=@PersonaFechaNacimiento, [PersonaSexo]=@PersonaSexo, [PLocalidadID]=@PLocalidadID, [PProvinciaID]=@PProvinciaID, [ImagenPerfil]=@ImagenPerfil  WHERE [PersonaID] = @PersonaID", false) ;
         if ( ( cmPersonaUpdate1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmPersonaUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaNombre", System.Data.DbType.AnsiString,120));
            cmPersonaUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaApellido", System.Data.DbType.AnsiString,120));
            cmPersonaUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaFechaNacimiento", System.Data.DbType.Date));
            cmPersonaUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaSexo", System.Data.DbType.Int16));
            cmPersonaUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PLocalidadID", System.Data.DbType.Int32));
            cmPersonaUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PProvinciaID", System.Data.DbType.Int32));
            cmPersonaUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ImagenPerfil", System.Data.DbType.AnsiString,50));
            cmPersonaUpdate1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaID", System.Data.DbType.Int32));
         }
         // Using cursor PersonaUpdate1
         cmPersonaUpdate1.SetParameter(0, rowPersona["PersonaNombre"]);
         cmPersonaUpdate1.SetParameter(1, rowPersona["PersonaApellido"]);
         cmPersonaUpdate1.SetParameterDateObject(2, rowPersona["PersonaFechaNacimiento"]);
         cmPersonaUpdate1.SetParameter(3, rowPersona["PersonaSexo"]);
         cmPersonaUpdate1.SetParameter(4, rowPersona["PLocalidadID"]);
         cmPersonaUpdate1.SetParameter(5, rowPersona["PProvinciaID"]);
         cmPersonaUpdate1.SetParameter(6, rowPersona["ImagenPerfil"]);
         cmPersonaUpdate1.SetParameter(7, rowPersona["PersonaID"]);
         cmPersonaUpdate1.ExecuteStmt();
         // Start of After( update) rules
         // End of After( update) rules
         OnPersonaUpdated( new PersonaEventArgs( rowPersona, Mode.Update)) ;
         EndLevelPersona( ) ;
      }

      private void Delete( )
      {
          ReadWriteCommand cmPersonaDelete1 ;
         Gx_mode = Mode.Delete ;
         CheckOptimisticConcurrencyPersona( ) ;
         // No cascading delete specified.
         AfterConfirmPersona( ) ;
         cmPersonaDelete1 = connDefault.GetCommand("DELETE FROM [Persona]  WHERE [PersonaID] = @PersonaID", false) ;
         if ( ( cmPersonaDelete1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmPersonaDelete1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaID", System.Data.DbType.Int32));
         }
         cmPersonaDelete1.ErrorMask = cmPersonaDelete1.ErrorMask  |  ErrorMask.ForeignKeyError;
         // Using cursor PersonaDelete1
         cmPersonaDelete1.SetParameter(0, rowPersona["PersonaID"]);
         cmPersonaDelete1.ExecuteStmt();
         if ( cmPersonaDelete1.ForeignKeyError )
         {
            CheckDeleteErrorsPersona( ) ;
         }
         // Start of After( delete) rules
         // End of After( delete) rules
         OnPersonaUpdated( new PersonaEventArgs( rowPersona, Mode.Delete)) ;
         rowPersona.Delete( ) ;
         sMode1 = Gx_mode ;
         Gx_mode = Mode.Delete ;
         EndLevelPersona( ) ;
         Gx_mode = sMode1 ;
      }

      private void CheckDeleteErrorsPersona( )
      {
          IDataReader UsuarioSelect1 ;
          ReadWriteCommand cmUsuarioSelect1 ;
         cmUsuarioSelect1 = connDefault.GetCommand("SELECT TOP 1 [UsuarioID] FROM [Usuario] WITH (NOLOCK) WHERE [PersonaID] = @PersonaID ", false) ;
         if ( ( cmUsuarioSelect1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmUsuarioSelect1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaID", System.Data.DbType.Int32));
         }
         cmUsuarioSelect1.SetParameter(0, rowPersona["PersonaID"]);
         UsuarioSelect1 = cmUsuarioSelect1.FetchData() ;
         if ( cmUsuarioSelect1.HasMoreRows )
         {
            UsuarioSelect1.Close();
            throw new UsuarioInvalidDeleteException( string.Format(resourceManager.GetString("del"), new   object[]  {"Usuario"})) ;
         }
         UsuarioSelect1.Close();
      }

      private void EndLevelPersona( )
      {
         // Execute 'After Trn' event if defined.
         IsModified = 0 ;
      }

      private void ScanByPersonaID( int startRow ,
                                    int maxRows )
      {
         m_WhereString = " WHERE TM1.[PersonaID] = @PersonaID" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString1 + "  FROM [Persona] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[PersonaID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString1 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[PersonaID] ) AS DK_PAGENUM   FROM [Persona] TM1 WITH (NOLOCK) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString1 + " FROM [Persona] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[PersonaID] " ;
         }
         cmPersonaSelect4 = connDefault.GetCommand(scmdbuf, false) ;
         if ( ( cmPersonaSelect4.IDbCommand.Parameters.Count == 0 ) )
         {
            cmPersonaSelect4.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaID", System.Data.DbType.Int32));
         }
         cmPersonaSelect4.SetParameter(0, rowPersona["PersonaID"]);
         PersonaSelect4 = cmPersonaSelect4.FetchData() ;
         RcdFound1 = 0 ;
         ScanLoadPersona( ) ;
         LoadDataPersona( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanStartPersona( int startRow ,
                                     int maxRows )
      {
         m_WhereString = "" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  " + m_SelectString1 + "  FROM [Persona] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[PersonaID]" ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  " + m_SelectString1 + ", ROW_NUMBER() OVER  (  ORDER BY TM1.[PersonaID] ) AS DK_PAGENUM   FROM [Persona] TM1 WITH (NOLOCK) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT " + m_SelectString1 + " FROM [Persona] TM1 WITH (NOLOCK)" + m_WhereString + " ORDER BY TM1.[PersonaID] " ;
         }
         cmPersonaSelect4 = connDefault.GetCommand(scmdbuf, false) ;
         PersonaSelect4 = cmPersonaSelect4.FetchData() ;
         RcdFound1 = 0 ;
         ScanLoadPersona( ) ;
         LoadDataPersona( maxRows) ;
         // Load Subordinate Levels
      }

      private void ScanNextPersona( )
      {
         cmPersonaSelect4.HasMoreRows = PersonaSelect4.Read() ;
         RcdFound1 = 0 ;
         ScanLoadPersona( ) ;
      }

      private void ScanLoadPersona( )
      {
         Gx_mode = Mode.Display ;
         if ( cmPersonaSelect4.HasMoreRows )
         {
            RcdFound1 = 1 ;
            rowPersona["PersonaID"] = dsDefault.Db.GetInt32(PersonaSelect4, 0) ;
            rowPersona["PersonaNombre"] = dsDefault.Db.GetString(PersonaSelect4, 1) ;
            rowPersona["PersonaApellido"] = dsDefault.Db.GetString(PersonaSelect4, 2) ;
            rowPersona["PersonaFechaNacimiento"] = dsDefault.Db.GetDateTime(PersonaSelect4, 3) ;
            rowPersona["PersonaSexo"] = dsDefault.Db.GetInt16(PersonaSelect4, 4) ;
            rowPersona["PLocalidadID"] = dsDefault.Db.GetInt32(PersonaSelect4, 5) ;
            rowPersona["PProvinciaID"] = dsDefault.Db.GetInt32(PersonaSelect4, 6) ;
            rowPersona["ImagenPerfil"] = dsDefault.Db.GetString(PersonaSelect4, 7) ;
         }
      }

      private void ScanEndPersona( )
      {
         PersonaSelect4.Close();
      }

      private void AfterConfirmPersona( )
      {
         // After Confirm Rules
         OnPersonaUpdating( new PersonaEventArgs( rowPersona, Gx_mode)) ;
      }

      private void CreateNewRowPersona( )
      {
         rowPersona = PersonaSet.Persona.NewPersonaRow() ;
      }

      private void LoadChildPersona( int startRow ,
                                     int maxRows )
      {
         CreateNewRowPersona( ) ;
         bool tmpConstraintState = PersonaSet.EnforceConstraints ;
         PersonaSet.Persona.BeginLoadData( ) ;
         ScanStartPersona( startRow, maxRows) ;
         PersonaSet.Persona.EndLoadData( ) ;
         this.PersonaSet.EnforceConstraints = tmpConstraintState ;
      }

      private void LoadDataPersona( int maxRows )
      {
         int loadedRows = 0 ;
         if ( ( RcdFound1 != 0 ) )
         {
            ScanLoadPersona( ) ;
            while ( ( RcdFound1 != 0 ) && ( loadedRows != maxRows ) )
            {
               loadedRows++ ;
               LoadRowPersona( ) ;
               CreateNewRowPersona( ) ;
               ScanNextPersona( ) ;
            }
         }
         if ( ( loadedRows > 0 ) )
         {
            RcdFound1 = 1 ;
         }
         ScanEndPersona( ) ;
         if ( ( PersonaSet.Persona.Count > 0 ) )
         {
            rowPersona = PersonaSet.Persona[PersonaSet.Persona.Count -1] ;
         }
      }

      private void LoadByPersonaID( int startRow ,
                                    int maxRows )
      {
         bool tmpConstraintState = PersonaSet.EnforceConstraints ;
         PersonaSet.Persona.BeginLoadData( ) ;
         ScanByPersonaID( startRow, maxRows) ;
         PersonaSet.Persona.EndLoadData( ) ;
         this.PersonaSet.EnforceConstraints = tmpConstraintState ;
         if ( ( PersonaSet.Persona.Count > 0 ) )
         {
            rowPersona = PersonaSet.Persona[PersonaSet.Persona.Count -1] ;
         }
      }

      private void AddRowPersona( )
      {
         PersonaSet.Persona.AddPersonaRow( rowPersona) ;
      }

      private readonly string m_SelectString1 = "TM1.[PersonaID], TM1.[PersonaNombre], TM1.[PersonaApellido], TM1.[PersonaFechaNacimiento], TM1.[PersonaSexo], TM1.[PLocalidadID], TM1.[PProvinciaID], TM1.[ImagenPerfil]" ;


      public delegate  void PersonaUpdateEventHandler( object sender ,
                                                       PersonaEventArgs e );
      public event PersonaUpdateEventHandler PersonaUpdated ;
      private void OnPersonaUpdated( PersonaEventArgs e )
      {
         if ( ( this.PersonaUpdated != null ) )
         {
            this.PersonaUpdated( this, e) ;
         }
      }

      public event PersonaUpdateEventHandler PersonaUpdating ;
      private void OnPersonaUpdating( PersonaEventArgs e )
      {
         if ( ( this.PersonaUpdating != null ) )
         {
            this.PersonaUpdating( this, e) ;
         }
      }

      public class PersonaEventArgs : EventArgs
      {
         private System.Data.StatementType m_statementType ;
         private PersonaDataSet.PersonaRow m_dataRow ;
         public PersonaEventArgs( PersonaDataSet.PersonaRow row ,
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

         public PersonaDataSet.PersonaRow Row
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
      public class PersonaNotFoundException : Deklarit.DataNotFoundException
      {
         public PersonaNotFoundException( )
         {
         }

         public PersonaNotFoundException( string message ) : base(message)
         {
         }

         public PersonaNotFoundException( string message ,
                                          Exception inner ) : base(message, inner)
         {
         }

         protected PersonaNotFoundException( SerializationInfo info ,
                                             StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class PersonaSexoInvalidValue : Deklarit.UserException
      {
         public PersonaSexoInvalidValue( )
         {
         }

         public PersonaSexoInvalidValue( string message ) : base(message)
         {
         }

         public PersonaSexoInvalidValue( string message ,
                                         Exception inner ) : base(message, inner)
         {
         }

         protected PersonaSexoInvalidValue( SerializationInfo info ,
                                            StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class PersonaDataLockedException : Deklarit.DataLockedException
      {
         public PersonaDataLockedException( )
         {
         }

         public PersonaDataLockedException( string message ) : base(message)
         {
         }

         public PersonaDataLockedException( string message ,
                                            Exception inner ) : base(message, inner)
         {
         }

         protected PersonaDataLockedException( SerializationInfo info ,
                                               StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class PersonaDataChangedException : Deklarit.DataChangedException
      {
         public PersonaDataChangedException( )
         {
         }

         public PersonaDataChangedException( string message ) : base(message)
         {
         }

         public PersonaDataChangedException( string message ,
                                             Exception inner ) : base(message, inner)
         {
         }

         protected PersonaDataChangedException( SerializationInfo info ,
                                                StreamingContext context ) : base(info, context)
         {
         }

      }

      [Serializable()]
      public class UsuarioInvalidDeleteException : Deklarit.InvalidDeleteException
      {
         public UsuarioInvalidDeleteException( )
         {
         }

         public UsuarioInvalidDeleteException( string message ) : base(message)
         {
         }

         public UsuarioInvalidDeleteException( string message ,
                                               Exception inner ) : base(message, inner)
         {
         }

         protected UsuarioInvalidDeleteException( SerializationInfo info ,
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
         RcdFound1 = 0 ;
         scmdbuf = "" ;
         recordCount = 0 ;
         _Gxremove = false ;
         m__PersonaNombreOriginal = new object();
         m__PersonaApellidoOriginal = new object();
         m__PersonaFechaNacimientoOriginal = new object();
         m__PersonaSexoOriginal = new object();
         m__PLocalidadIDOriginal = new object();
         m__PProvinciaIDOriginal = new object();
         m__ImagenPerfilOriginal = new object();
         _Condition = false ;
         IsModified = 0 ;
         m_WhereString = "" ;
         if ( ( this.Transaction == null ) )
         {
            this.Transaction = ((System.Data.IDbTransaction)(System.Threading.Thread.GetData(System.Threading.Thread.GetNamedDataSlot(DeklaritTransaction.TransactionSlotName)) ));
         }
      }

      private short RcdFound1 ;
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
      private ReadWriteCommand cmPersonaSelect1 ;
      private IDataReader PersonaSelect1 ;
      private ReadWriteCommand cmPersonaSelect4 ;
      private IDataReader PersonaSelect4 ;
      private System.Data.StatementType Gx_mode ;
      private System.Data.StatementType sMode1 ;
      private object m__PersonaNombreOriginal ;
      private object m__PersonaApellidoOriginal ;
      private object m__PersonaFechaNacimientoOriginal ;
      private object m__PersonaSexoOriginal ;
      private object m__PLocalidadIDOriginal ;
      private object m__PProvinciaIDOriginal ;
      private object m__ImagenPerfilOriginal ;
   }

   public class PersonaDataReader : System.IDisposable
   {
      public PersonaDataReader( )
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
      ///   Gets or sets the Transaction object to be used  by  PersonaDataReaderDeklarit DataReaderclasses
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
         cmPersonaSelect5 = connDefault.GetCommand("SELECT TM1.[PersonaID], TM1.[PersonaNombre], TM1.[PersonaApellido], TM1.[PersonaFechaNacimiento], TM1.[PersonaSexo], TM1.[PLocalidadID], TM1.[PProvinciaID], TM1.[ImagenPerfil] FROM [Persona] TM1 WITH (NOLOCK) ORDER BY TM1.[PersonaID] ", false) ;
         PersonaSelect5 = cmPersonaSelect5.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return PersonaSelect5 ;
      }

      public IDataReader OpenByPersonaID( int personaID )
      {
         init_reader( ) ;
         m_Closed = false ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         cmPersonaSelect5 = connDefault.GetCommand("SELECT TM1.[PersonaID], TM1.[PersonaNombre], TM1.[PersonaApellido], TM1.[PersonaFechaNacimiento], TM1.[PersonaSexo], TM1.[PLocalidadID], TM1.[PProvinciaID], TM1.[ImagenPerfil] FROM [Persona] TM1 WITH (NOLOCK) WHERE TM1.[PersonaID] = @PersonaID ORDER BY TM1.[PersonaID] ", false) ;
         if ( ( cmPersonaSelect5.IDbCommand.Parameters.Count == 0 ) )
         {
            cmPersonaSelect5.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaID", System.Data.DbType.Int32));
         }
         cmPersonaSelect5.SetParameter(0, personaID);
         PersonaSelect5 = cmPersonaSelect5.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default)) ;
         return PersonaSelect5 ;
      }

      public void Dispose( )
      {
         if ( ! m_Disposed )
         {
            m_Disposed = true ;
            try
            {
               if ( ! m_Closed && ( PersonaSelect5 != null ) )
               {
                  m_Closed = true ;
                  PersonaSelect5.Close();
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
      private ReadWriteCommand cmPersonaSelect5 ;
      private IDataReader PersonaSelect5 ;
   }

}
