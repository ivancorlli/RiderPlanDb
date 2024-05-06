
//               File: dpUsuarioXEmailXusuarioIDCollectionDataAdapter
//        Description: dpUsuarioXEmailXusuarioIDCollection
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5_0.002
//       Program type: Deklarit Data Provider
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   using System;
   using System.Collections;
   using Deklarit.Utils;
   using System.Data;
   using System.Data.SqlClient;
   using System.Data.Common;
   using Deklarit.Data;
   using System.Threading;
   using System.Xml.Serialization;
   using System.Runtime.Serialization;
   using System.Security.Permissions;
   using System.Data.SqlTypes;
   public partial class dpUsuarioXEmailXusuarioIDCollectionDataAdapter : System.Data.IDataAdapter, IdpUsuarioXEmailXusuarioIDCollectionDataAdapter
   {
      private dpUsuarioXEmailXusuarioIDCollectionDataSet dpUsuarioXEmailXusuarioIDCollectionSet ;
      public dpUsuarioXEmailXusuarioIDCollectionDataAdapter( )
      {
         dsDefault = new DataStore( new SqlServer2005Handler( ), "System.Data.SqlClient", Raiderplan1.Configuration.ConnectionString, DeklaritTransaction.TransactionSlotName) ;
         Init_order_Usuario( ) ;
         orderString = GetOrderString( this.Order, true) ;
         reverseOrderString = GetOrderString( this.Order, false) ;
      }

      private IDbTransaction daCurrentTransaction ;
      ///  <summary>
      ///   Gets or sets the Transaction object to be used  by  dpUsuarioXEmailXusuarioIDCollectionDataAdapterclasses
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

      private string filterCondition ;
      private string filterString ;
      private string filterStringCond ;
      private string orderString ;
      private string reverseOrderString ;
      public ArrayList Order
      {
         get {
            return orderArray ;
         }

         set {
            orderArray = value ;
         }

      }


      private ArrayList orderArray ;

      public class OrderAttribute
      {
         public OrderAttribute( Attribute orderAttributeName ,
                                bool orderAttributeAscending )
         {
            this.OrderAttributeName = orderAttributeName ;
            this.OrderAttributeAscending = orderAttributeAscending ;
            this.OrderAttributeString = attributeNames[((int)(this.OrderAttributeName))] ;
         }

         public OrderAttribute( Attribute orderAttributeName )
         {
            this.OrderAttributeName = orderAttributeName ;
            this.OrderAttributeAscending = true ;
            this.OrderAttributeString = attributeNames[((int)(this.OrderAttributeName))] ;
         }

         public Attribute OrderAttributeName ;
         public bool OrderAttributeAscending ;
         public String OrderAttributeString ;
      }

      public static string GetOrderString(ArrayList ListOrder, bool AscendingOrder)
      	{
      		string orderString = "" ;
      		string prevString = "" ;
      		if ( ( ListOrder.Count > 0 ) )
      		{
      			prevString = " ORDER BY " ;
      		}
      		foreach( OrderAttribute orderAtt in ListOrder )
      		{
      			if ( ( orderAtt.OrderAttributeAscending == AscendingOrder ) )
      			{
      				orderString = orderString + prevString + " " + orderAtt.OrderAttributeString ;
      			}
      			else
      			{
      				orderString = orderString + prevString + " " + orderAtt.OrderAttributeString + " DESC" ;
      			}
      			prevString = ", ";
      		}
              return orderString;
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

      public virtual int Update( DataSet dataSet )
      {
         throw new System.InvalidOperationException( ) ;
      }

      ///  <summary>
      ///   Gets the fill parameters array.
      ///  </summary>
      public virtual IDataParameter[] GetFillParameters( )
      {
         if ( ( fillDataParameters == null ) )
         {
            DbProviderFactory factory = System.Data.Common.DbProviderFactories.GetFactory( "System.Data.SqlClient") ;
            DbParameter parm0Email ;
            parm0Email = factory.CreateParameter() ;
            parm0Email.ParameterName = "Email" ;
            parm0Email.DbType = System.Data.DbType.AnsiString ;
            DbParameter parm1NombreUsuario ;
            parm1NombreUsuario = factory.CreateParameter() ;
            parm1NombreUsuario.ParameterName = "NombreUsuario" ;
            parm1NombreUsuario.DbType = System.Data.DbType.AnsiString ;
            fillDataParameters = new  DbParameter[]  {parm0Email, parm1NombreUsuario} ;
         }
         return fillDataParameters ;
      }

      private DbParameter[] fillDataParameters ;
      ///  <summary>
      ///   Sets the fill parameters array.
      ///  </summary>
      private void SetFillParameters( String email ,
                                      String nombreUsuario )
      {
         if ( ( fillDataParameters == null ) )
         {
            GetFillParameters( ) ;
            fillDataParameters[0].Value = email ;
            fillDataParameters[1].Value = nombreUsuario ;
         }
         return  ;
      }

      public virtual int Fill( dpUsuarioXEmailXusuarioIDCollectionDataSet dataSet ,
                               String email ,
                               String nombreUsuario )
      {
         this.Initialize( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         dpUsuarioXEmailXusuarioIDCollectionSet = dataSet ;
         SetFillParameters( email, nombreUsuario) ;
         AV8Email = email;
         AV9NombreU = nombreUsuario;
         orderString = GetOrderString( this.Order, true) ;
         reverseOrderString = GetOrderString( this.Order, false) ;
         try
         {
            executePrivate( 0, -1) ;
         }
         finally
         {
            this.Cleanup();
         }
         return 0 ;
      }


      public virtual int FillPage( dpUsuarioXEmailXusuarioIDCollectionDataSet dataSet ,
                                   String email ,
                                   String nombreUsuario ,
                                   int startRow ,
                                   int maxRows )
      {
         this.Initialize( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         dpUsuarioXEmailXusuarioIDCollectionSet = dataSet ;
         SetFillParameters( email, nombreUsuario) ;
         AV8Email = email;
         AV9NombreU = nombreUsuario;
         orderString = GetOrderString( this.Order, true) ;
         reverseOrderString = GetOrderString( this.Order, false) ;
         try
         {
            executePrivate( startRow, maxRows) ;
         }
         finally
         {
            this.Cleanup();
         }
         return 0 ;
      }


      public virtual int GetRecordCount( String email ,
                                         String nombreUsuario )
      {
         int m_Count ;
         try
         {
            SetFillParameters( email, nombreUsuario) ;
            m_Count = GetInternalRecordCount( email, nombreUsuario ) ;
         }
         finally
         {
            this.Cleanup();
         }
         return m_Count ;
      }

      private int GetInternalRecordCount( String email ,
                                          String nombreUsuario )
      {
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         scmdbuf = "SELECT COUNT(*) FROM ([Usuario] T1 INNER JOIN [Persona] T2 ON T2.[PersonaID] = T1.[PersonaID])" ;
         sWhereString = "" ;
         if ( ( String.Compare(email.TrimEnd(' '), "".TrimEnd(' '), false, System.Globalization.CultureInfo.CurrentCulture) == 0 ) )
         {
            if ( ( String.Compare("".TrimEnd(' '), sWhereString.TrimEnd(' '), false, System.Globalization.CultureInfo.CurrentCulture) != 0 ) )
            {
               sWhereString = sWhereString + " and ('" + StringUtil.StringReplace( nombreUsuario, "'", "''") + "' = T1.[UsuarioNombre])" ;
            }
            else
            {
               sWhereString = sWhereString + " ('" + StringUtil.StringReplace( nombreUsuario, "'", "''") + "' = T1.[UsuarioNombre])" ;
            }
         }
         if ( ( String.Compare(nombreUsuario.TrimEnd(' '), "".TrimEnd(' '), false, System.Globalization.CultureInfo.CurrentCulture) == 0 ) )
         {
            if ( ( String.Compare("".TrimEnd(' '), sWhereString.TrimEnd(' '), false, System.Globalization.CultureInfo.CurrentCulture) != 0 ) )
            {
               sWhereString = sWhereString + " and ('" + StringUtil.StringReplace( email, "'", "''") + "' = T1.[UsuarioEmail])" ;
            }
            else
            {
               sWhereString = sWhereString + " ('" + StringUtil.StringReplace( email, "'", "''") + "' = T1.[UsuarioEmail])" ;
            }
         }
         if ( ( String.Compare("".TrimEnd(' '), sWhereString.TrimEnd(' '), false, System.Globalization.CultureInfo.CurrentCulture) != 0 ) )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         cmUsuarioSelect1 = connDefault.GetCommand(scmdbuf,false);
         cmUsuarioSelect1.ErrorMask = cmUsuarioSelect1.ErrorMask  |  ErrorMask.Lock;
         UsuarioSelect1 = cmUsuarioSelect1.FetchData();
         m_RecordCount = ( ( UsuarioSelect1.IsDBNull(0) )  ? (int)(0) : UsuarioSelect1.GetInt32(0) ) ;
         UsuarioSelect1.Close();
         return m_RecordCount ;
      }

      ///  <summary>
      ///   (8) Fills the specified dataset with the record matching  in the the fillDataParameters
      ///    array, if the array is null, it fills the Dataset loading all records in the table.
      ///
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Fill( DataSet dataSet )
      {
         dpUsuarioXEmailXusuarioIDCollectionSet = dataSet as dpUsuarioXEmailXusuarioIDCollectionDataSet ;
         if ( ( dpUsuarioXEmailXusuarioIDCollectionSet != null ) )
         {
            return Fill( dpUsuarioXEmailXusuarioIDCollectionSet) ;
         }
         else
         {
            dpUsuarioXEmailXusuarioIDCollectionSet = new dpUsuarioXEmailXusuarioIDCollectionDataSet() ;
            Fill( dpUsuarioXEmailXusuarioIDCollectionSet) ;
            dataSet.Merge( dpUsuarioXEmailXusuarioIDCollectionSet) ;
            return 0 ;
         }
      }

      ///  <summary>
      ///   (8) Fills the specified dataset with the record matching  in the the fillDataParameters
      ///    array, if the array is null, it fills the Dataset loading all records in the table.
      ///
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int FillPage( DataSet dataSet ,
                                   int startRow ,
                                   int maxRows )
      {
         dpUsuarioXEmailXusuarioIDCollectionSet = dataSet as dpUsuarioXEmailXusuarioIDCollectionDataSet ;
         if ( ( dpUsuarioXEmailXusuarioIDCollectionSet != null ) )
         {
            return FillPage( dpUsuarioXEmailXusuarioIDCollectionSet, startRow, maxRows) ;
         }
         else
         {
            dpUsuarioXEmailXusuarioIDCollectionSet = new dpUsuarioXEmailXusuarioIDCollectionDataSet() ;
            FillPage( dpUsuarioXEmailXusuarioIDCollectionSet, startRow, maxRows) ;
            dataSet.Merge( dpUsuarioXEmailXusuarioIDCollectionSet) ;
            return 0 ;
         }
      }

      public virtual int Fill( dpUsuarioXEmailXusuarioIDCollectionDataSet dataSet )
      {
         if ( ( fillDataParameters != null ) )
         {
            Fill( dataSet, fillDataParameters[0].Value.ToString(), fillDataParameters[1].Value.ToString()) ;
         }
         else
         {
            throw new System.ArgumentException( ) ;
         }
         return 0 ;
      }


      public virtual int FillPage( dpUsuarioXEmailXusuarioIDCollectionDataSet dataSet ,
                                   int startRow ,
                                   int maxRows )
      {
         if ( ( fillDataParameters != null ) )
         {
            FillPage( dataSet, fillDataParameters[0].Value.ToString(), fillDataParameters[1].Value.ToString(), startRow, maxRows) ;
         }
         else
         {
            throw new System.ArgumentException( ) ;
         }
         return 0 ;
      }


      void executePrivate( int startRow ,
                           int maxRows )
      {
         // DeKlarit formulas
         m_WhereString = "" ;
         sWhereString = "" ;
         if ( ( String.Compare(AV8Email.TrimEnd(' '), "".TrimEnd(' '), false, System.Globalization.CultureInfo.CurrentCulture) == 0 ) )
         {
            if ( ( String.Compare("".TrimEnd(' '), sWhereString.TrimEnd(' '), false, System.Globalization.CultureInfo.CurrentCulture) != 0 ) )
            {
               sWhereString = sWhereString + " and ('" + StringUtil.StringReplace( AV9NombreU, "'", "''") + "' = TM1.[UsuarioNombre])" ;
            }
            else
            {
               sWhereString = sWhereString + " ('" + StringUtil.StringReplace( AV9NombreU, "'", "''") + "' = TM1.[UsuarioNombre])" ;
            }
         }
         if ( ( String.Compare(AV9NombreU.TrimEnd(' '), "".TrimEnd(' '), false, System.Globalization.CultureInfo.CurrentCulture) == 0 ) )
         {
            if ( ( String.Compare("".TrimEnd(' '), sWhereString.TrimEnd(' '), false, System.Globalization.CultureInfo.CurrentCulture) != 0 ) )
            {
               sWhereString = sWhereString + " and ('" + StringUtil.StringReplace( AV8Email, "'", "''") + "' = TM1.[UsuarioEmail])" ;
            }
            else
            {
               sWhereString = sWhereString + " ('" + StringUtil.StringReplace( AV8Email, "'", "''") + "' = TM1.[UsuarioEmail])" ;
            }
         }
         if ( ( String.Compare("".TrimEnd(' '), sWhereString.TrimEnd(' '), false, System.Globalization.CultureInfo.CurrentCulture) != 0 ) )
         {
            m_WhereString = m_WhereString + " WHERE " + sWhereString ;
         }
         sDynOrderString = "" ;
         sDynRevOrderString = "" ;
         if ( ( String.Compare(orderString.TrimEnd(' '), "".TrimEnd(' '), false, System.Globalization.CultureInfo.CurrentCulture) != 0 ) )
         {
            sDynOrderString = sDynOrderString + orderString ;
            sDynRevOrderString = sDynRevOrderString + reverseOrderString ;
         }
         sWhereSep = "" ;
         if ( ( String.Compare(m_WhereString.TrimEnd(' '), "".TrimEnd(' '), false, System.Globalization.CultureInfo.CurrentCulture) != 0 ) )
         {
            sWhereSep = " AND " ;
         }
         else
         {
            sWhereSep = " WHERE " ;
         }
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  TM1.[UsuarioID], TM1.[UsuarioNombre], TM1.[UsuarioEmail], TM1.[UsuarioPasword], TM1.[UsuarioActivo], TM1.[PersonaID], T2.[PersonaApellido], T2.[PersonaNombre], TM1.[CodigoValidation]  FROM ([Usuario] TM1 INNER JOIN [Persona] T2 ON T2.[PersonaID] = TM1.[PersonaID])" + m_WhereString + ((sDynOrderString.Length==0) ? " ORDER BY TM1.[UsuarioID] " : sDynOrderString) ;
            }
            else
            {
               scmdbuf = " SELECT * FROM ( SELECT  TM1.[UsuarioID], TM1.[UsuarioNombre], TM1.[UsuarioEmail], TM1.[UsuarioPasword], TM1.[UsuarioActivo], TM1.[PersonaID], T2.[PersonaApellido], T2.[PersonaNombre], TM1.[CodigoValidation], ROW_NUMBER() OVER  ( " + ((sDynOrderString.Length==0) ? " ORDER BY TM1.[UsuarioID] " : sDynOrderString) + " ) AS DK_PAGENUM   FROM ([Usuario] TM1 INNER JOIN [Persona] T2 ON T2.[PersonaID] = TM1.[PersonaID]) " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT TM1.[UsuarioID], TM1.[UsuarioNombre], TM1.[UsuarioEmail], TM1.[UsuarioPasword], TM1.[UsuarioActivo], TM1.[PersonaID], T2.[PersonaApellido], T2.[PersonaNombre], TM1.[CodigoValidation] FROM ([Usuario] TM1 INNER JOIN [Persona] T2 ON T2.[PersonaID] = TM1.[PersonaID])" + m_WhereString + sDynOrderString ;
         }
         cmUsuarioSelect2 = connDefault.GetCommand(scmdbuf,false);
         cmUsuarioSelect2.ErrorMask = cmUsuarioSelect2.ErrorMask  |  ErrorMask.Lock;
         UsuarioSelect2 = cmUsuarioSelect2.FetchData();
         int loadedRows = 0 ;
         while ( ( cmUsuarioSelect2.HasMoreRows ) && ( ( loadedRows != maxRows ) ) )
         {
            m_UsuarioID = dsDefault.Db.GetInt32(UsuarioSelect2, 0, ref m__UsuarioIDIsNull) ;
            m_UsuarioNombre = dsDefault.Db.GetString(UsuarioSelect2, 1, ref m__UsuarioNombreIsNull) ;
            m_UsuarioEmail = dsDefault.Db.GetString(UsuarioSelect2, 2, ref m__UsuarioEmailIsNull) ;
            m_UsuarioPasword = dsDefault.Db.GetString(UsuarioSelect2, 3, ref m__UsuarioPaswordIsNull) ;
            m_UsuarioActivo = dsDefault.Db.GetString(UsuarioSelect2, 4, ref m__UsuarioActivoIsNull) ;
            m_PersonaID = dsDefault.Db.GetInt32(UsuarioSelect2, 5, ref m__PersonaIDIsNull) ;
            m_PersonaApellido = dsDefault.Db.GetString(UsuarioSelect2, 6, ref m__PersonaApellidoIsNull) ;
            m_PersonaNombre = dsDefault.Db.GetString(UsuarioSelect2, 7, ref m__PersonaNombreIsNull) ;
            m_CodigoValidation = dsDefault.Db.GetString(UsuarioSelect2, 8, ref m__CodigoValidationIsNull) ;
            m_PersonaApellido = dsDefault.Db.GetString(UsuarioSelect2, 6, ref m__PersonaApellidoIsNull) ;
            m_PersonaNombre = dsDefault.Db.GetString(UsuarioSelect2, 7, ref m__PersonaNombreIsNull) ;
            rowUsuario = dpUsuarioXEmailXusuarioIDCollectionSet.Usuario.NewUsuarioRow() ;
            rowUsuario["UsuarioID"] = ( ( m__UsuarioIDIsNull )  ? System.Convert.DBNull : m_UsuarioID ) ;
            rowUsuario["UsuarioNombre"] = ( ( m__UsuarioNombreIsNull )  ? System.Convert.DBNull : m_UsuarioNombre ) ;
            rowUsuario["UsuarioEmail"] = ( ( m__UsuarioEmailIsNull )  ? System.Convert.DBNull : m_UsuarioEmail ) ;
            rowUsuario["UsuarioPasword"] = ( ( m__UsuarioPaswordIsNull )  ? System.Convert.DBNull : m_UsuarioPasword ) ;
            rowUsuario["UsuarioActivo"] = ( ( m__UsuarioActivoIsNull )  ? System.Convert.DBNull : m_UsuarioActivo ) ;
            rowUsuario["PersonaID"] = ( ( m__PersonaIDIsNull )  ? System.Convert.DBNull : m_PersonaID ) ;
            rowUsuario["PersonaApellido"] = ( ( m__PersonaApellidoIsNull )  ? System.Convert.DBNull : m_PersonaApellido ) ;
            rowUsuario["PersonaNombre"] = ( ( m__PersonaNombreIsNull )  ? System.Convert.DBNull : m_PersonaNombre ) ;
            rowUsuario["CodigoValidation"] = ( ( m__CodigoValidationIsNull )  ? System.Convert.DBNull : m_CodigoValidation ) ;
            AddRowUsuario( ) ;
            loadedRows++ ;
            cmUsuarioSelect2.HasMoreRows = UsuarioSelect2.Read();
         }
         UsuarioSelect2.Close();
         this.Cleanup();
      }

      protected void Cleanup( )
      {
         dsDefault.Dispose();
      }

      private dpUsuarioXEmailXusuarioIDCollectionDataSet.UsuarioRow rowUsuario ;
      private void AddRowUsuario( )
      {
         dpUsuarioXEmailXusuarioIDCollectionSet.Usuario.AddUsuarioRow( rowUsuario) ;
         rowUsuario.AcceptChanges( ) ;
      }

      public enum Attribute {UsuarioID, UsuarioNombre, UsuarioEmail, UsuarioPasword, UsuarioActivo, PersonaID, PersonaApellido, PersonaNombre, CodigoValidation};
      private static String[] attributeNames = new String[]  {"TM1.[UsuarioID]", "TM1.[UsuarioNombre]", "TM1.[UsuarioEmail]", "TM1.[UsuarioPasword]", "TM1.[UsuarioActivo]", "TM1.[PersonaID]", "T2.[PersonaApellido]", "T2.[PersonaNombre]", "TM1.[CodigoValidation]"} ;
      private void Init_order_Usuario( )
      {
         this.Order = new ArrayList() ;
      }

      public static string GetAttributeName( Attribute attribute )
      {
         return attributeNames[(int) attribute] ;
      }

      // Custom Exceptions
      private void Initialize( )
      {
         resourceManager = Deklarit.Utils.ResourceManager.Instance ;
         resourceManagerTables = new System.Resources.ResourceManager( "Deklarit.Tables", System.Reflection.Assembly.GetExecutingAssembly()) ;
         AV8Email = "" ;
         AV9NombreU = "" ;
         scmdbuf = "" ;
         sWhereString = "" ;
         m_RecordCount = 0 ;
         m_WhereString = "" ;
         sDynOrderString = "" ;
         sDynRevOrderString = "" ;
         sWhereSep = "" ;
         m__UsuarioIDIsNull = false ;
         m_UsuarioID = 0 ;
         m__UsuarioNombreIsNull = false ;
         m_UsuarioNombre = "" ;
         m__UsuarioEmailIsNull = false ;
         m_UsuarioEmail = "" ;
         m__UsuarioPaswordIsNull = false ;
         m_UsuarioPasword = "" ;
         m__UsuarioActivoIsNull = false ;
         m_UsuarioActivo = "" ;
         m__PersonaIDIsNull = false ;
         m_PersonaID = 0 ;
         m__PersonaApellidoIsNull = false ;
         m_PersonaApellido = "" ;
         m__PersonaNombreIsNull = false ;
         m_PersonaNombre = "" ;
         m__CodigoValidationIsNull = false ;
         m_CodigoValidation = "" ;
         // GeneXus formulas.
         if ( ( this.Transaction == null ) )
         {
            this.Transaction = ((System.Data.IDbTransaction)(System.Threading.Thread.GetData(System.Threading.Thread.GetNamedDataSlot(DeklaritTransaction.TransactionSlotName)) ));
         }
      }

      private int m_RecordCount ;
      private int m_UsuarioID ;
      private int m_PersonaID ;
      private String scmdbuf ;
      private String sWhereString ;
      private String m_WhereString ;
      private String sDynOrderString ;
      private String sDynRevOrderString ;
      private String sWhereSep ;
      private bool m__UsuarioIDIsNull ;
      private bool m__UsuarioNombreIsNull ;
      private bool m__UsuarioEmailIsNull ;
      private bool m__UsuarioPaswordIsNull ;
      private bool m__UsuarioActivoIsNull ;
      private bool m__PersonaIDIsNull ;
      private bool m__PersonaApellidoIsNull ;
      private bool m__PersonaNombreIsNull ;
      private bool m__CodigoValidationIsNull ;
      private String AV8Email ;
      private String AV9NombreU ;
      private String m_UsuarioNombre ;
      private String m_UsuarioEmail ;
      private String m_UsuarioPasword ;
      private String m_UsuarioActivo ;
      private String m_PersonaApellido ;
      private String m_PersonaNombre ;
      private String m_CodigoValidation ;
      private DataStore dsDefault ;
      private System.Resources.ResourceManager resourceManager ;
      private System.Resources.ResourceManager resourceManagerTables ;
      private ReadWriteConnection connDefault ;
      private ReadWriteCommand cmUsuarioSelect1 ;
      private IDataReader UsuarioSelect1 ;
      private ReadWriteCommand cmUsuarioSelect2 ;
      private IDataReader UsuarioSelect2 ;
   }

   public class dpUsuarioXEmailXusuarioIDCollectionDataReader : System.IDisposable
   {
      public dpUsuarioXEmailXusuarioIDCollectionDataReader( )
      {
         Init_order_Usuario( ) ;
         orderString = GetOrderString( this.Order, true) ;
         reverseOrderString = GetOrderString( this.Order, false) ;
      }

      private void init_reader( )
      {
         this.Initialize( ) ;
         orderString = GetOrderString( this.Order, true) ;
         reverseOrderString = GetOrderString( this.Order, false) ;
         dsDefault = new DataStore( new SqlServer2005Handler( ), "System.Data.SqlClient", Raiderplan1.Configuration.ConnectionString, DeklaritTransaction.TransactionSlotName) ;
         m_Disposed = false ;
         m_Closed = true ;
      }

      private IDbTransaction daCurrentTransaction ;
      ///  <summary>
      ///   Gets or sets the Transaction object to be used  by  dpUsuarioXEmailXusuarioIDCollectionDataReaderDeklarit
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

      public IDataReader Open( String email ,
                               String nombreUsuario )
      {
         init_reader( ) ;
         m_Closed = false ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         scmdbuf = "SELECT TM1.[UsuarioID], TM1.[UsuarioNombre], TM1.[UsuarioEmail], TM1.[UsuarioPasword], TM1.[UsuarioActivo], TM1.[PersonaID], T2.[PersonaApellido], T2.[PersonaNombre], TM1.[CodigoValidation] FROM ([Usuario] TM1 INNER JOIN [Persona] T2 ON T2.[PersonaID] = TM1.[PersonaID])" ;
         sWhereString = "" ;
         if ( ( String.Compare(email.TrimEnd(' '), "".TrimEnd(' '), false, System.Globalization.CultureInfo.CurrentCulture) == 0 ) )
         {
            if ( ( String.Compare("".TrimEnd(' '), sWhereString.TrimEnd(' '), false, System.Globalization.CultureInfo.CurrentCulture) != 0 ) )
            {
               sWhereString = sWhereString + " and ('" + StringUtil.StringReplace( nombreUsuario, "'", "''") + "' = TM1.[UsuarioNombre])" ;
            }
            else
            {
               sWhereString = sWhereString + " ('" + StringUtil.StringReplace( nombreUsuario, "'", "''") + "' = TM1.[UsuarioNombre])" ;
            }
         }
         if ( ( String.Compare(nombreUsuario.TrimEnd(' '), "".TrimEnd(' '), false, System.Globalization.CultureInfo.CurrentCulture) == 0 ) )
         {
            if ( ( String.Compare("".TrimEnd(' '), sWhereString.TrimEnd(' '), false, System.Globalization.CultureInfo.CurrentCulture) != 0 ) )
            {
               sWhereString = sWhereString + " and ('" + StringUtil.StringReplace( email, "'", "''") + "' = TM1.[UsuarioEmail])" ;
            }
            else
            {
               sWhereString = sWhereString + " ('" + StringUtil.StringReplace( email, "'", "''") + "' = TM1.[UsuarioEmail])" ;
            }
         }
         if ( ( String.Compare("".TrimEnd(' '), sWhereString.TrimEnd(' '), false, System.Globalization.CultureInfo.CurrentCulture) != 0 ) )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         if ( ( String.Compare(orderString.TrimEnd(' '), "".TrimEnd(' '), false, System.Globalization.CultureInfo.CurrentCulture) != 0 ) )
         {
            scmdbuf = scmdbuf + orderString ;
         }
         cmUsuarioSelect3 = connDefault.GetCommand(scmdbuf,false);
         cmUsuarioSelect3.ErrorMask = cmUsuarioSelect3.ErrorMask  |  ErrorMask.Lock;
         UsuarioSelect3 = cmUsuarioSelect3.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default));
         return UsuarioSelect3 ;
      }

      public void Dispose( )
      {
         if ( ! m_Disposed )
         {
            m_Disposed = true ;
            try
            {
               UsuarioSelect3.Close();
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


      private string filterCondition ;
      private string filterString ;
      private string filterStringCond ;
      private string orderString ;
      private string reverseOrderString ;
      public ArrayList Order
      {
         get {
            return orderArray ;
         }

         set {
            orderArray = value ;
         }

      }


      private ArrayList orderArray ;

      public class OrderAttribute
      {
         public OrderAttribute( Attribute orderAttributeName ,
                                bool orderAttributeAscending )
         {
            this.OrderAttributeName = orderAttributeName ;
            this.OrderAttributeAscending = orderAttributeAscending ;
            this.OrderAttributeString = attributeNames[((int)(this.OrderAttributeName))] ;
         }

         public OrderAttribute( Attribute orderAttributeName )
         {
            this.OrderAttributeName = orderAttributeName ;
            this.OrderAttributeAscending = true ;
            this.OrderAttributeString = attributeNames[((int)(this.OrderAttributeName))] ;
         }

         public Attribute OrderAttributeName ;
         public bool OrderAttributeAscending ;
         public String OrderAttributeString ;
      }

      public static string GetOrderString(ArrayList ListOrder, bool AscendingOrder)
      	{
      		string orderString = "" ;
      		string prevString = "" ;
      		if ( ( ListOrder.Count > 0 ) )
      		{
      			prevString = " ORDER BY " ;
      		}
      		foreach( OrderAttribute orderAtt in ListOrder )
      		{
      			if ( ( orderAtt.OrderAttributeAscending == AscendingOrder ) )
      			{
      				orderString = orderString + prevString + " " + orderAtt.OrderAttributeString ;
      			}
      			else
      			{
      				orderString = orderString + prevString + " " + orderAtt.OrderAttributeString + " DESC" ;
      			}
      			prevString = ", ";
      		}
              return orderString;
      	}
      public enum Attribute {UsuarioID, UsuarioNombre, UsuarioEmail, UsuarioPasword, UsuarioActivo, PersonaID, PersonaApellido, PersonaNombre, CodigoValidation};
      private static String[] attributeNames = new String[]  {"TM1.[UsuarioID]", "TM1.[UsuarioNombre]", "TM1.[UsuarioEmail]", "TM1.[UsuarioPasword]", "TM1.[UsuarioActivo]", "TM1.[PersonaID]", "T2.[PersonaApellido]", "T2.[PersonaNombre]", "TM1.[CodigoValidation]"} ;
      private void Init_order_Usuario( )
      {
         this.Order = new ArrayList() ;
      }

      public static string GetAttributeName( Attribute attribute )
      {
         return attributeNames[(int) attribute] ;
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
         sWhereString = "" ;
         // GeneXus formulas.
         if ( ( this.Transaction == null ) )
         {
            this.Transaction = ((System.Data.IDbTransaction)(System.Threading.Thread.GetData(System.Threading.Thread.GetNamedDataSlot(DeklaritTransaction.TransactionSlotName)) ));
         }
      }

      private String scmdbuf ;
      private String sWhereString ;
      private bool m_Disposed ;
      private bool m_Closed ;
      private DataStore dsDefault ;
      private ReadWriteConnection connDefault ;
      private ReadWriteCommand cmUsuarioSelect3 ;
      private IDataReader UsuarioSelect3 ;
   }

}
