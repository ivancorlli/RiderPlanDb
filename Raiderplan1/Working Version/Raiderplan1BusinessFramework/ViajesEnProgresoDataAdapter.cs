
//               File: ViajesEnProgresoDataAdapter
//        Description: ViajesEnProgreso
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
   public partial class ViajesEnProgresoDataAdapter : System.Data.IDataAdapter, IViajesEnProgresoDataAdapter
   {
      private ViajesEnProgresoDataSet ViajesEnProgresoSet ;
      public ViajesEnProgresoDataAdapter( )
      {
         dsDefault = new DataStore( new SqlServer2005Handler( ), "System.Data.SqlClient", Raiderplan1.Configuration.ConnectionString, DeklaritTransaction.TransactionSlotName) ;
         Init_order_Viaje( ) ;
         orderString = GetOrderString( this.Order, true) ;
         reverseOrderString = GetOrderString( this.Order, false) ;
      }

      private IDbTransaction daCurrentTransaction ;
      ///  <summary>
      ///   Gets or sets the Transaction object to be used  by  ViajesEnProgresoDataAdapterclasses
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
      ///   Sets the fill parameters array.
      ///  </summary>
      private void SetFillParameters( int usuarioID )
      {
         if ( ( fillDataParameters == null ) )
         {
            GetFillParameters( ) ;
            fillDataParameters[0].Value = usuarioID ;
         }
         return  ;
      }

      public virtual int Fill( ViajesEnProgresoDataSet dataSet ,
                               int usuarioID )
      {
         this.Initialize( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         ViajesEnProgresoSet = dataSet ;
         SetFillParameters( usuarioID) ;
         AV8Usuario = usuarioID;
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


      public virtual int FillPage( ViajesEnProgresoDataSet dataSet ,
                                   int usuarioID ,
                                   int startRow ,
                                   int maxRows )
      {
         this.Initialize( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         ViajesEnProgresoSet = dataSet ;
         SetFillParameters( usuarioID) ;
         AV8Usuario = usuarioID;
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


      public virtual int GetRecordCount( int usuarioID )
      {
         int m_Count ;
         try
         {
            SetFillParameters( usuarioID) ;
            m_Count = GetInternalRecordCount( usuarioID ) ;
         }
         finally
         {
            this.Cleanup();
         }
         return m_Count ;
      }

      private int GetInternalRecordCount( int usuarioID )
      {
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         String m_WhereString ;
         m_WhereString = " WHERE (@UsuarioID = [UsuarioID]) AND ([ViajeEstado] = 'P')" ;
         scmdbuf = "SELECT COUNT(*) FROM [Viaje]" + m_WhereString + "  " ;
         cmViajeSelect1 = connDefault.GetCommand(scmdbuf,false);
         if ( ( cmViajeSelect1.IDbCommand.Parameters.Count == 0 ) )
         {
            cmViajeSelect1.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioID", System.Data.DbType.Int32));
         }
         cmViajeSelect1.SetParameter(0, usuarioID);
         cmViajeSelect1.ErrorMask = cmViajeSelect1.ErrorMask  |  ErrorMask.Lock;
         ViajeSelect1 = cmViajeSelect1.FetchData();
         m_RecordCount = ( ( ViajeSelect1.IsDBNull(0) )  ? (int)(0) : ViajeSelect1.GetInt32(0) ) ;
         ViajeSelect1.Close();
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
         ViajesEnProgresoSet = dataSet as ViajesEnProgresoDataSet ;
         if ( ( ViajesEnProgresoSet != null ) )
         {
            return Fill( ViajesEnProgresoSet) ;
         }
         else
         {
            ViajesEnProgresoSet = new ViajesEnProgresoDataSet() ;
            Fill( ViajesEnProgresoSet) ;
            dataSet.Merge( ViajesEnProgresoSet) ;
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
         ViajesEnProgresoSet = dataSet as ViajesEnProgresoDataSet ;
         if ( ( ViajesEnProgresoSet != null ) )
         {
            return FillPage( ViajesEnProgresoSet, startRow, maxRows) ;
         }
         else
         {
            ViajesEnProgresoSet = new ViajesEnProgresoDataSet() ;
            FillPage( ViajesEnProgresoSet, startRow, maxRows) ;
            dataSet.Merge( ViajesEnProgresoSet) ;
            return 0 ;
         }
      }

      public virtual int Fill( ViajesEnProgresoDataSet dataSet )
      {
         if ( ( fillDataParameters != null ) )
         {
            Fill( dataSet, System.Int32.Parse( fillDataParameters[0].Value.ToString())) ;
         }
         else
         {
            throw new System.ArgumentException( ) ;
         }
         return 0 ;
      }


      public virtual int FillPage( ViajesEnProgresoDataSet dataSet ,
                                   int startRow ,
                                   int maxRows )
      {
         if ( ( fillDataParameters != null ) )
         {
            FillPage( dataSet, System.Int32.Parse( fillDataParameters[0].Value.ToString()), startRow, maxRows) ;
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
         m_WhereString = " WHERE " + filterString + "  (@UsuarioID = TM1.[UsuarioID]) AND (TM1.[ViajeEstado] = 'P')" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  TM1.[ViajeID], TM1.[UsuarioID], TM1.[ViajeNombre], TM1.[FechaSalidaProgramada], TM1.[FechaLlegadaProgramada], TM1.[FechaSalidaEfectiva], TM1.[FechaLlegadaEfectiva], TM1.[LugarPartida], TM1.[Lugarllegada], TM1.[LongitudPartida], TM1.[LatitudPartida], TM1.[LongitudLegada], TM1.[LatitudLlegada], TM1.[kmTotalesEstimado], TM1.[MotocilcetaMarca], TM1.[MotociletaModelo], TM1.[ViajeImagen], TM1.[ViajeEstado] FROM [Viaje] TM1" + m_WhereString + "" + orderString + "" ;
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
               int m_recordCount = GetInternalRecordCount( AV8Usuario) ;
               m_TopRowCount = ((m_recordCount>=(startRow+maxRows)) ? maxRows : ((m_recordCount>=startRow) ? m_recordCount-startRow : 0)) ;
               if ( ( m_TopRowCount == 0 ) )
               {
                  return  ;
               }
               scmdbuf = "SELECT TM1.[ViajeID], TM1.[UsuarioID], TM1.[ViajeNombre], TM1.[FechaSalidaProgramada], TM1.[FechaLlegadaProgramada], TM1.[FechaSalidaEfectiva], TM1.[FechaLlegadaEfectiva], TM1.[LugarPartida], TM1.[Lugarllegada], TM1.[LongitudPartida], TM1.[LatitudPartida], TM1.[LongitudLegada], TM1.[LatitudLlegada], TM1.[kmTotalesEstimado], TM1.[MotocilcetaMarca], TM1.[MotociletaModelo], TM1.[ViajeImagen], TM1.[ViajeEstado] FROM [Viaje] TM1 WHERE TM1.[ViajeID] IN ( SELECT TOP " + maxRows.ToString() + " TM1.[ViajeID]  FROM [Viaje] TM1" + m_WhereString + "" + sWhereSep + "TM1.[ViajeID] NOT IN ( SELECT TOP " + startRow.ToString() + " TM1.[ViajeID]  FROM [Viaje] TM1" + m_WhereString + "" + orderString + ")" + orderString + ")" + orderString + "" ;
            }
         }
         else
         {
            scmdbuf = "SELECT TM1.[ViajeID], TM1.[UsuarioID], TM1.[ViajeNombre], TM1.[FechaSalidaProgramada], TM1.[FechaLlegadaProgramada], TM1.[FechaSalidaEfectiva], TM1.[FechaLlegadaEfectiva], TM1.[LugarPartida], TM1.[Lugarllegada], TM1.[LongitudPartida], TM1.[LatitudPartida], TM1.[LongitudLegada], TM1.[LatitudLlegada], TM1.[kmTotalesEstimado], TM1.[MotocilcetaMarca], TM1.[MotociletaModelo], TM1.[ViajeImagen], TM1.[ViajeEstado] FROM [Viaje] TM1" + m_WhereString + "" + orderString + " " ;
         }
         cmViajeSelect2 = connDefault.GetCommand(scmdbuf,false);
         if ( ( cmViajeSelect2.IDbCommand.Parameters.Count == 0 ) )
         {
            cmViajeSelect2.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioID", System.Data.DbType.Int32));
         }
         cmViajeSelect2.SetParameter(0, AV8Usuario);
         cmViajeSelect2.ErrorMask = cmViajeSelect2.ErrorMask  |  ErrorMask.Lock;
         ViajeSelect2 = cmViajeSelect2.FetchData();
         int loadedRows = 0 ;
         while ( ( cmViajeSelect2.HasMoreRows ) && ( ( loadedRows != maxRows ) ) )
         {
            m_ViajeID = dsDefault.Db.GetInt64(ViajeSelect2, 0, ref m__ViajeIDIsNull) ;
            m_UsuarioID = dsDefault.Db.GetInt32(ViajeSelect2, 1, ref m__UsuarioIDIsNull) ;
            m_ViajeNombre = dsDefault.Db.GetString(ViajeSelect2, 2, ref m__ViajeNombreIsNull) ;
            m_FechaSalidaProgramada = dsDefault.Db.GetDateTime(ViajeSelect2, 3, ref m__FechaSalidaProgramadaIsNull) ;
            m_FechaLlegadaProgramada = dsDefault.Db.GetDateTime(ViajeSelect2, 4, ref m__FechaLlegadaProgramadaIsNull) ;
            m_FechaSalidaEfectiva = dsDefault.Db.GetDateTime(ViajeSelect2, 5, ref m__FechaSalidaEfectivaIsNull) ;
            m_FechaLlegadaEfectiva = dsDefault.Db.GetDateTime(ViajeSelect2, 6, ref m__FechaLlegadaEfectivaIsNull) ;
            m_LugarPartida = dsDefault.Db.GetString(ViajeSelect2, 7, ref m__LugarPartidaIsNull) ;
            m_Lugarllegada = dsDefault.Db.GetString(ViajeSelect2, 8, ref m__LugarllegadaIsNull) ;
            m_LongitudPartida = dsDefault.Db.GetDecimal(ViajeSelect2, 9, ref m__LongitudPartidaIsNull) ;
            m_LatitudPartida = dsDefault.Db.GetDecimal(ViajeSelect2, 10, ref m__LatitudPartidaIsNull) ;
            m_LongitudLegada = dsDefault.Db.GetDecimal(ViajeSelect2, 11, ref m__LongitudLegadaIsNull) ;
            m_LatitudLlegada = dsDefault.Db.GetDecimal(ViajeSelect2, 12, ref m__LatitudLlegadaIsNull) ;
            m_kmTotalesEstimado = dsDefault.Db.GetDecimal(ViajeSelect2, 13, ref m__kmTotalesEstimadoIsNull) ;
            m_MotocilcetaMarca = dsDefault.Db.GetString(ViajeSelect2, 14, ref m__MotocilcetaMarcaIsNull) ;
            m_MotociletaModelo = dsDefault.Db.GetString(ViajeSelect2, 15, ref m__MotociletaModeloIsNull) ;
            m_ViajeImagen = dsDefault.Db.GetString(ViajeSelect2, 16, ref m__ViajeImagenIsNull) ;
            m_ViajeEstado = dsDefault.Db.GetString(ViajeSelect2, 17, ref m__ViajeEstadoIsNull) ;
            rowViaje = ViajesEnProgresoSet.Viaje.NewViajeRow() ;
            rowViaje["ViajeID"] = ( ( m__ViajeIDIsNull )  ? System.Convert.DBNull : m_ViajeID ) ;
            rowViaje["UsuarioID"] = ( ( m__UsuarioIDIsNull )  ? System.Convert.DBNull : m_UsuarioID ) ;
            rowViaje["ViajeNombre"] = ( ( m__ViajeNombreIsNull )  ? System.Convert.DBNull : m_ViajeNombre ) ;
            rowViaje["FechaSalidaProgramada"] = ( ( m__FechaSalidaProgramadaIsNull )  ? System.Convert.DBNull : m_FechaSalidaProgramada ) ;
            rowViaje["FechaLlegadaProgramada"] = ( ( m__FechaLlegadaProgramadaIsNull )  ? System.Convert.DBNull : m_FechaLlegadaProgramada ) ;
            rowViaje["FechaSalidaEfectiva"] = ( ( m__FechaSalidaEfectivaIsNull )  ? System.Convert.DBNull : m_FechaSalidaEfectiva ) ;
            rowViaje["FechaLlegadaEfectiva"] = ( ( m__FechaLlegadaEfectivaIsNull )  ? System.Convert.DBNull : m_FechaLlegadaEfectiva ) ;
            rowViaje["LugarPartida"] = ( ( m__LugarPartidaIsNull )  ? System.Convert.DBNull : m_LugarPartida ) ;
            rowViaje["Lugarllegada"] = ( ( m__LugarllegadaIsNull )  ? System.Convert.DBNull : m_Lugarllegada ) ;
            rowViaje["LongitudPartida"] = ( ( m__LongitudPartidaIsNull )  ? System.Convert.DBNull : m_LongitudPartida ) ;
            rowViaje["LatitudPartida"] = ( ( m__LatitudPartidaIsNull )  ? System.Convert.DBNull : m_LatitudPartida ) ;
            rowViaje["LongitudLegada"] = ( ( m__LongitudLegadaIsNull )  ? System.Convert.DBNull : m_LongitudLegada ) ;
            rowViaje["LatitudLlegada"] = ( ( m__LatitudLlegadaIsNull )  ? System.Convert.DBNull : m_LatitudLlegada ) ;
            rowViaje["kmTotalesEstimado"] = ( ( m__kmTotalesEstimadoIsNull )  ? System.Convert.DBNull : m_kmTotalesEstimado ) ;
            rowViaje["MotocilcetaMarca"] = ( ( m__MotocilcetaMarcaIsNull )  ? System.Convert.DBNull : m_MotocilcetaMarca ) ;
            rowViaje["MotociletaModelo"] = ( ( m__MotociletaModeloIsNull )  ? System.Convert.DBNull : m_MotociletaModelo ) ;
            rowViaje["ViajeImagen"] = ( ( m__ViajeImagenIsNull )  ? System.Convert.DBNull : m_ViajeImagen ) ;
            rowViaje["ViajeEstado"] = ( ( m__ViajeEstadoIsNull )  ? System.Convert.DBNull : m_ViajeEstado ) ;
            AddRowViaje( ) ;
            loadedRows++ ;
            cmViajeSelect2.HasMoreRows = ViajeSelect2.Read();
         }
         ViajeSelect2.Close();
         this.Cleanup();
      }

      protected void Cleanup( )
      {
         dsDefault.Dispose();
      }

      private ViajesEnProgresoDataSet.ViajeRow rowViaje ;
      private void AddRowViaje( )
      {
         ViajesEnProgresoSet.Viaje.AddViajeRow( rowViaje) ;
         rowViaje.AcceptChanges( ) ;
      }

      ///  <summary>
      ///   Gets or sets the filter used by  ViajesEnProgreso DataProvider classes to retrieve
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

      public enum Attribute {ViajeID, UsuarioID, ViajeNombre, FechaSalidaProgramada, FechaLlegadaProgramada, FechaSalidaEfectiva, FechaLlegadaEfectiva, LugarPartida, Lugarllegada, LongitudPartida, LatitudPartida, LongitudLegada, LatitudLlegada, kmTotalesEstimado, MotocilcetaMarca, MotociletaModelo, ViajeImagen, ViajeEstado};
      private static String[] attributeNames = new String[]  {"TM1.[ViajeID]", "TM1.[UsuarioID]", "TM1.[ViajeNombre]", "TM1.[FechaSalidaProgramada]", "TM1.[FechaLlegadaProgramada]", "TM1.[FechaSalidaEfectiva]", "TM1.[FechaLlegadaEfectiva]", "TM1.[LugarPartida]", "TM1.[Lugarllegada]", "TM1.[LongitudPartida]", "TM1.[LatitudPartida]", "TM1.[LongitudLegada]", "TM1.[LatitudLlegada]", "TM1.[kmTotalesEstimado]", "TM1.[MotocilcetaMarca]", "TM1.[MotociletaModelo]", "TM1.[ViajeImagen]", "TM1.[ViajeEstado]"} ;
      private void Init_order_Viaje( )
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
         AV8Usuario = 0 ;
         scmdbuf = "" ;
         m_WhereString = "" ;
         m_RecordCount = 0 ;
         sWhereSep = "" ;
         m_TopRowCount = 0 ;
         m__ViajeIDIsNull = false ;
         m_ViajeID = 0 ;
         m__UsuarioIDIsNull = false ;
         m_UsuarioID = 0 ;
         m__ViajeNombreIsNull = false ;
         m_ViajeNombre = "" ;
         m__FechaSalidaProgramadaIsNull = false ;
         m_FechaSalidaProgramada = (DateTime)(DateTime.MinValue) ;
         m__FechaLlegadaProgramadaIsNull = false ;
         m_FechaLlegadaProgramada = (DateTime)(DateTime.MinValue) ;
         m__FechaSalidaEfectivaIsNull = false ;
         m_FechaSalidaEfectiva = (DateTime)(DateTime.MinValue) ;
         m__FechaLlegadaEfectivaIsNull = false ;
         m_FechaLlegadaEfectiva = (DateTime)(DateTime.MinValue) ;
         m__LugarPartidaIsNull = false ;
         m_LugarPartida = "" ;
         m__LugarllegadaIsNull = false ;
         m_Lugarllegada = "" ;
         m__LongitudPartidaIsNull = false ;
         m_LongitudPartida = (decimal)(0M) ;
         m__LatitudPartidaIsNull = false ;
         m_LatitudPartida = (decimal)(0M) ;
         m__LongitudLegadaIsNull = false ;
         m_LongitudLegada = (decimal)(0M) ;
         m__LatitudLlegadaIsNull = false ;
         m_LatitudLlegada = (decimal)(0M) ;
         m__kmTotalesEstimadoIsNull = false ;
         m_kmTotalesEstimado = (decimal)(0M) ;
         m__MotocilcetaMarcaIsNull = false ;
         m_MotocilcetaMarca = "" ;
         m__MotociletaModeloIsNull = false ;
         m_MotociletaModelo = "" ;
         m__ViajeImagenIsNull = false ;
         m_ViajeImagen = "" ;
         m__ViajeEstadoIsNull = false ;
         m_ViajeEstado = "" ;
         // GeneXus formulas.
         if ( ( this.Transaction == null ) )
         {
            this.Transaction = ((System.Data.IDbTransaction)(System.Threading.Thread.GetData(System.Threading.Thread.GetNamedDataSlot(DeklaritTransaction.TransactionSlotName)) ));
         }
      }

      private int AV8Usuario ;
      private int m_RecordCount ;
      private int m_TopRowCount ;
      private int m_UsuarioID ;
      private long m_ViajeID ;
      private decimal m_LongitudPartida ;
      private decimal m_LatitudPartida ;
      private decimal m_LongitudLegada ;
      private decimal m_LatitudLlegada ;
      private decimal m_kmTotalesEstimado ;
      private String scmdbuf ;
      private String m_WhereString ;
      private String sWhereSep ;
      private DateTime m_FechaSalidaProgramada ;
      private DateTime m_FechaLlegadaProgramada ;
      private DateTime m_FechaSalidaEfectiva ;
      private DateTime m_FechaLlegadaEfectiva ;
      private bool m__ViajeIDIsNull ;
      private bool m__UsuarioIDIsNull ;
      private bool m__ViajeNombreIsNull ;
      private bool m__FechaSalidaProgramadaIsNull ;
      private bool m__FechaLlegadaProgramadaIsNull ;
      private bool m__FechaSalidaEfectivaIsNull ;
      private bool m__FechaLlegadaEfectivaIsNull ;
      private bool m__LugarPartidaIsNull ;
      private bool m__LugarllegadaIsNull ;
      private bool m__LongitudPartidaIsNull ;
      private bool m__LatitudPartidaIsNull ;
      private bool m__LongitudLegadaIsNull ;
      private bool m__LatitudLlegadaIsNull ;
      private bool m__kmTotalesEstimadoIsNull ;
      private bool m__MotocilcetaMarcaIsNull ;
      private bool m__MotociletaModeloIsNull ;
      private bool m__ViajeImagenIsNull ;
      private bool m__ViajeEstadoIsNull ;
      private String m_ViajeNombre ;
      private String m_LugarPartida ;
      private String m_Lugarllegada ;
      private String m_MotocilcetaMarca ;
      private String m_MotociletaModelo ;
      private String m_ViajeImagen ;
      private String m_ViajeEstado ;
      private DataStore dsDefault ;
      private System.Resources.ResourceManager resourceManager ;
      private System.Resources.ResourceManager resourceManagerTables ;
      private ReadWriteConnection connDefault ;
      private ReadWriteCommand cmViajeSelect1 ;
      private IDataReader ViajeSelect1 ;
      private ReadWriteCommand cmViajeSelect2 ;
      private IDataReader ViajeSelect2 ;
   }

   public class ViajesEnProgresoDataReader : System.IDisposable
   {
      public ViajesEnProgresoDataReader( )
      {
         Init_order_Viaje( ) ;
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
      ///   Gets or sets the Transaction object to be used  by  ViajesEnProgresoDataReaderDeklarit
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

      public IDataReader Open( int usuarioID )
      {
         init_reader( ) ;
         m_Closed = false ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         m_WhereString = " WHERE " + filterString + "  (@UsuarioID = TM1.[UsuarioID]) AND (TM1.[ViajeEstado] = 'P')" ;
         scmdbuf = "SELECT TM1.[ViajeID], TM1.[UsuarioID], TM1.[ViajeNombre], TM1.[FechaSalidaProgramada], TM1.[FechaLlegadaProgramada], TM1.[FechaSalidaEfectiva], TM1.[FechaLlegadaEfectiva], TM1.[LugarPartida], TM1.[Lugarllegada], TM1.[LongitudPartida], TM1.[LatitudPartida], TM1.[LongitudLegada], TM1.[LatitudLlegada], TM1.[kmTotalesEstimado], TM1.[MotocilcetaMarca], TM1.[MotociletaModelo], TM1.[ViajeImagen], TM1.[ViajeEstado] FROM [Viaje] TM1" + m_WhereString + " " + orderString + "  " ;
         cmViajeSelect3 = connDefault.GetCommand(scmdbuf,false);
         if ( ( cmViajeSelect3.IDbCommand.Parameters.Count == 0 ) )
         {
            cmViajeSelect3.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioID", System.Data.DbType.Int32));
         }
         cmViajeSelect3.SetParameter(0, usuarioID);
         cmViajeSelect3.ErrorMask = cmViajeSelect3.ErrorMask  |  ErrorMask.Lock;
         ViajeSelect3 = cmViajeSelect3.ExecuteReader(((daCurrentTransaction==null) ? Configuration.ReaderCommandBehavior : CommandBehavior.Default));
         return ViajeSelect3 ;
      }

      public void Dispose( )
      {
         if ( ! m_Disposed )
         {
            m_Disposed = true ;
            try
            {
               ViajeSelect3.Close();
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
      ///   Gets or sets the filter used by  ViajesEnProgreso DataProvider classes to retrieve
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

      public enum Attribute {ViajeID, UsuarioID, ViajeNombre, FechaSalidaProgramada, FechaLlegadaProgramada, FechaSalidaEfectiva, FechaLlegadaEfectiva, LugarPartida, Lugarllegada, LongitudPartida, LatitudPartida, LongitudLegada, LatitudLlegada, kmTotalesEstimado, MotocilcetaMarca, MotociletaModelo, ViajeImagen, ViajeEstado};
      private static String[] attributeNames = new String[]  {"TM1.[ViajeID]", "TM1.[UsuarioID]", "TM1.[ViajeNombre]", "TM1.[FechaSalidaProgramada]", "TM1.[FechaLlegadaProgramada]", "TM1.[FechaSalidaEfectiva]", "TM1.[FechaLlegadaEfectiva]", "TM1.[LugarPartida]", "TM1.[Lugarllegada]", "TM1.[LongitudPartida]", "TM1.[LatitudPartida]", "TM1.[LongitudLegada]", "TM1.[LatitudLlegada]", "TM1.[kmTotalesEstimado]", "TM1.[MotocilcetaMarca]", "TM1.[MotociletaModelo]", "TM1.[ViajeImagen]", "TM1.[ViajeEstado]"} ;
      private void Init_order_Viaje( )
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
      private ReadWriteCommand cmViajeSelect3 ;
      private IDataReader ViajeSelect3 ;
   }

}
