
//               File: TrayectoComentarioDataAdapter
//        Description: TrayectoComentario
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
   public partial class TrayectoComentarioDataAdapter : System.Data.IDataAdapter, ITrayectoComentarioDataAdapter
   {
      private TrayectoComentarioDataSet TrayectoComentarioSet ;
      public TrayectoComentarioDataAdapter( )
      {
         dsDefault = new DataStore( new SqlServer2005Handler( ), "System.Data.SqlClient", Raiderplan1.Configuration.ConnectionString, DeklaritTransaction.TransactionSlotName) ;
         Init_order_Comentarioviaje( ) ;
         orderString = GetOrderString( this.Order, true) ;
         reverseOrderString = GetOrderString( this.Order, false) ;
      }

      private IDbTransaction daCurrentTransaction ;
      ///  <summary>
      ///   Gets or sets the Transaction object to be used  by  TrayectoComentarioDataAdapterclasses
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
            DbParameter parm0ViajeID ;
            parm0ViajeID = factory.CreateParameter() ;
            parm0ViajeID.ParameterName = "ViajeID" ;
            parm0ViajeID.DbType = System.Data.DbType.Int64 ;
            DbParameter parm1TrayectoID ;
            parm1TrayectoID = factory.CreateParameter() ;
            parm1TrayectoID.ParameterName = "TrayectoID" ;
            parm1TrayectoID.DbType = System.Data.DbType.Int32 ;
            fillDataParameters = new  DbParameter[]  {parm0ViajeID, parm1TrayectoID} ;
         }
         return fillDataParameters ;
      }

      private DbParameter[] fillDataParameters ;
      ///  <summary>
      ///   Sets the fill parameters array.
      ///  </summary>
      private void SetFillParameters( long viajeID ,
                                      int trayectoID )
      {
         if ( ( fillDataParameters == null ) )
         {
            GetFillParameters( ) ;
            fillDataParameters[0].Value = viajeID ;
            fillDataParameters[1].Value = trayectoID ;
         }
         return  ;
      }

      public virtual int Fill( TrayectoComentarioDataSet dataSet ,
                               long viajeID ,
                               int trayectoID )
      {
         this.Initialize( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         TrayectoComentarioSet = dataSet ;
         SetFillParameters( viajeID, trayectoID) ;
         AV8ViajeID = viajeID;
         AV9Trayect = trayectoID;
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


      public virtual int FillPage( TrayectoComentarioDataSet dataSet ,
                                   long viajeID ,
                                   int trayectoID ,
                                   int startRow ,
                                   int maxRows )
      {
         this.Initialize( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         TrayectoComentarioSet = dataSet ;
         SetFillParameters( viajeID, trayectoID) ;
         AV8ViajeID = viajeID;
         AV9Trayect = trayectoID;
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


      public virtual int GetRecordCount( long viajeID ,
                                         int trayectoID )
      {
         int m_Count ;
         try
         {
            SetFillParameters( viajeID, trayectoID) ;
            m_Count = GetInternalRecordCount( viajeID, trayectoID ) ;
         }
         finally
         {
            this.Cleanup();
         }
         return m_Count ;
      }

      private int GetInternalRecordCount( long viajeID ,
                                          int trayectoID )
      {
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         String m_WhereString ;
         m_WhereString = " WHERE ([ViajeID] = @ViajeID) AND ([CVTrayectoID] = @TrayectoID)" ;
         scmdbuf = "SELECT COUNT(*) FROM [ComentarioViaje]" + m_WhereString + "  " ;
         cmComentarioViajeSelect1 = connDefault.GetCommand(scmdbuf,false);
         if ( ( cmComentarioViajeSelect1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmComentarioViajeSelect1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
            cmComentarioViajeSelect1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoID", System.Data.DbType.Int32));
         }
         cmComentarioViajeSelect1.SetParameter(0, viajeID);
         cmComentarioViajeSelect1.SetParameter(1, trayectoID);
         cmComentarioViajeSelect1.ErrorMask = cmComentarioViajeSelect1.ErrorMask  |  ErrorMask.Lock;
         ComentarioViajeSelect1 = cmComentarioViajeSelect1.FetchData();
         m_RecordCount = ( ( ComentarioViajeSelect1.IsDBNull(0) )  ? (int)(0) : ComentarioViajeSelect1.GetInt32(0) ) ;
         ComentarioViajeSelect1.Close();
         return m_RecordCount ;
      }

      ///  <summary>
      ///   (8) Fills the specified dataset with the record matching ViajeID in the the fillDataParameters
      ///    array, if the array is null, it fills the Dataset loading all records in the table.
      ///
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Fill( DataSet dataSet )
      {
         TrayectoComentarioSet = dataSet as TrayectoComentarioDataSet ;
         if ( ( TrayectoComentarioSet != null ) )
         {
            return Fill( TrayectoComentarioSet) ;
         }
         else
         {
            TrayectoComentarioSet = new TrayectoComentarioDataSet() ;
            Fill( TrayectoComentarioSet) ;
            dataSet.Merge( TrayectoComentarioSet) ;
            return 0 ;
         }
      }

      ///  <summary>
      ///   (8) Fills the specified dataset with the record matching ViajeID in the the fillDataParameters
      ///    array, if the array is null, it fills the Dataset loading all records in the table.
      ///
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int FillPage( DataSet dataSet ,
                                   int startRow ,
                                   int maxRows )
      {
         TrayectoComentarioSet = dataSet as TrayectoComentarioDataSet ;
         if ( ( TrayectoComentarioSet != null ) )
         {
            return FillPage( TrayectoComentarioSet, startRow, maxRows) ;
         }
         else
         {
            TrayectoComentarioSet = new TrayectoComentarioDataSet() ;
            FillPage( TrayectoComentarioSet, startRow, maxRows) ;
            dataSet.Merge( TrayectoComentarioSet) ;
            return 0 ;
         }
      }

      public virtual int Fill( TrayectoComentarioDataSet dataSet )
      {
         if ( ( fillDataParameters != null ) )
         {
            Fill( dataSet, System.Int64.Parse( fillDataParameters[0].Value.ToString()), System.Int32.Parse( fillDataParameters[1].Value.ToString())) ;
         }
         else
         {
            throw new System.ArgumentException( ) ;
         }
         return 0 ;
      }


      public virtual int FillPage( TrayectoComentarioDataSet dataSet ,
                                   int startRow ,
                                   int maxRows )
      {
         if ( ( fillDataParameters != null ) )
         {
            FillPage( dataSet, System.Int64.Parse( fillDataParameters[0].Value.ToString()), System.Int32.Parse( fillDataParameters[1].Value.ToString()), startRow, maxRows) ;
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
         m_WhereString = " WHERE " + filterString + "  (TM1.[ViajeID] = @ViajeID) AND (TM1.[CVTrayectoID] = @TrayectoID)" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  TM1.[ComentarioViajeID], TM1.[ComentarioLatitud], TM1.[ComentarioLongitud], TM1.[ComentarioTexto], TM1.[ComentarioImagen], TM1.[CVTrayectoID], TM1.[ViajeID]  FROM [ComentarioViaje] TM1" + m_WhereString + "" + orderString + "" ;
            }
            else
            {
               if ( (String.Compare(m_WhereString.TrimEnd(' '), "".TrimEnd(' '), false, System.Globalization.CultureInfo.CurrentCulture)==0) )
               {
                  sWhereSep = " WHERE " ;
               }
               else
               {
                  sWhereSep = " AND " ;
               }
               scmdbuf = " SELECT * FROM ( SELECT  TM1.[ComentarioViajeID], TM1.[ComentarioLatitud], TM1.[ComentarioLongitud], TM1.[ComentarioTexto], TM1.[ComentarioImagen], TM1.[CVTrayectoID], TM1.[ViajeID], ROW_NUMBER() OVER  ( " + orderString + " ) AS DK_PAGENUM   FROM [ComentarioViaje] TM1 " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT TM1.[ComentarioViajeID], TM1.[ComentarioLatitud], TM1.[ComentarioLongitud], TM1.[ComentarioTexto], TM1.[ComentarioImagen], TM1.[CVTrayectoID], TM1.[ViajeID] FROM [ComentarioViaje] TM1" + m_WhereString + "" + orderString + " " ;
         }
         cmComentarioViajeSelect2 = connDefault.GetCommand(scmdbuf,false);
         if ( ( cmComentarioViajeSelect2.IDbCommand.Parameters.Count == 0 ) )
         {
            cmComentarioViajeSelect2.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
            cmComentarioViajeSelect2.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoID", System.Data.DbType.Int32));
         }
         cmComentarioViajeSelect2.SetParameter(0, AV8ViajeID);
         cmComentarioViajeSelect2.SetParameter(1, AV9Trayect);
         cmComentarioViajeSelect2.ErrorMask = cmComentarioViajeSelect2.ErrorMask  |  ErrorMask.Lock;
         ComentarioViajeSelect2 = cmComentarioViajeSelect2.FetchData();
         int loadedRows = 0 ;
         while ( ( cmComentarioViajeSelect2.HasMoreRows ) && ( ( loadedRows != maxRows ) ) )
         {
            m_ComentarioViajeID = dsDefault.Db.GetInt32(ComentarioViajeSelect2, 0, ref m__ComentarioViajeIDIsNull) ;
            m_ComentarioLatitud = dsDefault.Db.GetDecimal(ComentarioViajeSelect2, 1, ref m__ComentarioLatitudIsNull) ;
            m_ComentarioLongitud = dsDefault.Db.GetDecimal(ComentarioViajeSelect2, 2, ref m__ComentarioLongitudIsNull) ;
            m_ComentarioTexto = dsDefault.Db.GetString(ComentarioViajeSelect2, 3, ref m__ComentarioTextoIsNull) ;
            m_ComentarioImagen = dsDefault.Db.GetString(ComentarioViajeSelect2, 4, ref m__ComentarioImagenIsNull) ;
            m_CVTrayectoID = dsDefault.Db.GetInt32(ComentarioViajeSelect2, 5, ref m__CVTrayectoIDIsNull) ;
            m_ViajeID = dsDefault.Db.GetInt64(ComentarioViajeSelect2, 6, ref m__ViajeIDIsNull) ;
            rowComentarioViaje = TrayectoComentarioSet.ComentarioViaje.NewComentarioViajeRow() ;
            rowComentarioViaje["ComentarioViajeID"] = ( ( m__ComentarioViajeIDIsNull )  ? System.Convert.DBNull : m_ComentarioViajeID ) ;
            rowComentarioViaje["ComentarioLatitud"] = ( ( m__ComentarioLatitudIsNull )  ? System.Convert.DBNull : m_ComentarioLatitud ) ;
            rowComentarioViaje["ComentarioLongitud"] = ( ( m__ComentarioLongitudIsNull )  ? System.Convert.DBNull : m_ComentarioLongitud ) ;
            rowComentarioViaje["ComentarioTexto"] = ( ( m__ComentarioTextoIsNull )  ? System.Convert.DBNull : m_ComentarioTexto ) ;
            rowComentarioViaje["ComentarioImagen"] = ( ( m__ComentarioImagenIsNull )  ? System.Convert.DBNull : m_ComentarioImagen ) ;
            rowComentarioViaje["CVTrayectoID"] = ( ( m__CVTrayectoIDIsNull )  ? System.Convert.DBNull : m_CVTrayectoID ) ;
            rowComentarioViaje["ViajeID"] = ( ( m__ViajeIDIsNull )  ? System.Convert.DBNull : m_ViajeID ) ;
            AddRowComentarioviaje( ) ;
            loadedRows++ ;
            cmComentarioViajeSelect2.HasMoreRows = ComentarioViajeSelect2.Read();
         }
         ComentarioViajeSelect2.Close();
         this.Cleanup();
      }

      protected void Cleanup( )
      {
         dsDefault.Dispose();
      }

      private TrayectoComentarioDataSet.ComentarioViajeRow rowComentarioViaje ;
      private void AddRowComentarioviaje( )
      {
         TrayectoComentarioSet.ComentarioViaje.AddComentarioViajeRow( rowComentarioViaje) ;
         rowComentarioViaje.AcceptChanges( ) ;
      }

      ///  <summary>
      ///   Gets or sets the filter used by  TrayectoComentario DataProvider classes to retrieve
      ///    data.
      ///  </summary>
      public String Filter
      {
         get {
            return filterCondition ;
         }

         set {
            filterCondition = value ;
            filterString = Deklarit.Data.QueryHelper.AddFilterString( filterCondition) ;
         }

      }

      public enum Attribute {ComentarioViajeID, ComentarioLatitud, ComentarioLongitud, ComentarioTexto, ComentarioImagen, CVTrayectoID, ViajeID};
      private static String[] attributeNames = new String[]  {"TM1.[ComentarioViajeID]", "TM1.[ComentarioLatitud]", "TM1.[ComentarioLongitud]", "TM1.[ComentarioTexto]", "TM1.[ComentarioImagen]", "TM1.[CVTrayectoID]", "TM1.[ViajeID]"} ;
      private void Init_order_Comentarioviaje( )
      {
         this.Order = new ArrayList() ;
         this.Order.Add( new OrderAttribute( Attribute.ViajeID, true)) ;
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
         AV8ViajeID = 0 ;
         AV9Trayect = 0 ;
         scmdbuf = "" ;
         m_WhereString = "" ;
         m_RecordCount = 0 ;
         sWhereSep = "" ;
         m__ComentarioViajeIDIsNull = false ;
         m_ComentarioViajeID = 0 ;
         m__ComentarioLatitudIsNull = false ;
         m_ComentarioLatitud = (decimal)(0M) ;
         m__ComentarioLongitudIsNull = false ;
         m_ComentarioLongitud = (decimal)(0M) ;
         m__ComentarioTextoIsNull = false ;
         m_ComentarioTexto = "" ;
         m__ComentarioImagenIsNull = false ;
         m_ComentarioImagen = "" ;
         m__CVTrayectoIDIsNull = false ;
         m_CVTrayectoID = 0 ;
         m__ViajeIDIsNull = false ;
         m_ViajeID = 0 ;
         // GeneXus formulas.
         if ( ( this.Transaction == null ) )
         {
            this.Transaction = ((System.Data.IDbTransaction)(System.Threading.Thread.GetData(System.Threading.Thread.GetNamedDataSlot(DeklaritTransaction.TransactionSlotName)) ));
         }
      }

      private int AV9Trayect ;
      private int m_RecordCount ;
      private int m_ComentarioViajeID ;
      private int m_CVTrayectoID ;
      private long AV8ViajeID ;
      private long m_ViajeID ;
      private decimal m_ComentarioLatitud ;
      private decimal m_ComentarioLongitud ;
      private String scmdbuf ;
      private String m_WhereString ;
      private String sWhereSep ;
      private bool m__ComentarioViajeIDIsNull ;
      private bool m__ComentarioLatitudIsNull ;
      private bool m__ComentarioLongitudIsNull ;
      private bool m__ComentarioTextoIsNull ;
      private bool m__ComentarioImagenIsNull ;
      private bool m__CVTrayectoIDIsNull ;
      private bool m__ViajeIDIsNull ;
      private String m_ComentarioTexto ;
      private String m_ComentarioImagen ;
      private DataStore dsDefault ;
      private System.Resources.ResourceManager resourceManager ;
      private System.Resources.ResourceManager resourceManagerTables ;
      private ReadWriteConnection connDefault ;
      private ReadWriteCommand cmComentarioViajeSelect1 ;
      private IDataReader ComentarioViajeSelect1 ;
      private ReadWriteCommand cmComentarioViajeSelect2 ;
      private IDataReader ComentarioViajeSelect2 ;
   }

   public class TrayectoComentarioDataReader : System.IDisposable
   {
      public TrayectoComentarioDataReader( )
      {
         Init_order_Comentarioviaje( ) ;
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
      ///   Gets or sets the Transaction object to be used  by  TrayectoComentarioDataReaderDeklarit
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

      public IDataReader Open( long viajeID ,
                               int trayectoID )
      {
         init_reader( ) ;
         m_Closed = false ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         m_WhereString = " WHERE " + filterString + "  (TM1.[ViajeID] = @ViajeID) AND (TM1.[CVTrayectoID] = @TrayectoID)" ;
         scmdbuf = "SELECT TM1.[ComentarioViajeID], TM1.[ComentarioLatitud], TM1.[ComentarioLongitud], TM1.[ComentarioTexto], TM1.[ComentarioImagen], TM1.[CVTrayectoID], TM1.[ViajeID] FROM [ComentarioViaje] TM1" + m_WhereString + " " + orderString + "  " ;
         cmComentarioViajeSelect3 = connDefault.GetCommand(scmdbuf,false);
         if ( ( cmComentarioViajeSelect3.IDbCommand.Parameters.Count == 0 ) )
         {
            cmComentarioViajeSelect3.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ViajeID", System.Data.DbType.Int64));
            cmComentarioViajeSelect3.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@TrayectoID", System.Data.DbType.Int32));
         }
         cmComentarioViajeSelect3.SetParameter(0, viajeID);
         cmComentarioViajeSelect3.SetParameter(1, trayectoID);
         cmComentarioViajeSelect3.ErrorMask = cmComentarioViajeSelect3.ErrorMask  |  ErrorMask.Lock;
         ComentarioViajeSelect3 = cmComentarioViajeSelect3.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default));
         return ComentarioViajeSelect3 ;
      }

      public void Dispose( )
      {
         if ( ! m_Disposed )
         {
            m_Disposed = true ;
            try
            {
               ComentarioViajeSelect3.Close();
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
      ///  <summary>
      ///   Gets or sets the filter used by  TrayectoComentario DataProvider classes to retrieve
      ///    data.
      ///  </summary>
      public String Filter
      {
         get {
            return filterCondition ;
         }

         set {
            filterCondition = value ;
            filterString = Deklarit.Data.QueryHelper.AddFilterString( filterCondition) ;
         }

      }

      public enum Attribute {ComentarioViajeID, ComentarioLatitud, ComentarioLongitud, ComentarioTexto, ComentarioImagen, CVTrayectoID, ViajeID};
      private static String[] attributeNames = new String[]  {"TM1.[ComentarioViajeID]", "TM1.[ComentarioLatitud]", "TM1.[ComentarioLongitud]", "TM1.[ComentarioTexto]", "TM1.[ComentarioImagen]", "TM1.[CVTrayectoID]", "TM1.[ViajeID]"} ;
      private void Init_order_Comentarioviaje( )
      {
         this.Order = new ArrayList() ;
         this.Order.Add( new OrderAttribute( Attribute.ViajeID, true)) ;
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
         m_WhereString = "" ;
         // GeneXus formulas.
         if ( ( this.Transaction == null ) )
         {
            this.Transaction = ((System.Data.IDbTransaction)(System.Threading.Thread.GetData(System.Threading.Thread.GetNamedDataSlot(DeklaritTransaction.TransactionSlotName)) ));
         }
      }

      private String scmdbuf ;
      private String m_WhereString ;
      private bool m_Disposed ;
      private bool m_Closed ;
      private DataStore dsDefault ;
      private ReadWriteConnection connDefault ;
      private ReadWriteCommand cmComentarioViajeSelect3 ;
      private IDataReader ComentarioViajeSelect3 ;
   }

}
