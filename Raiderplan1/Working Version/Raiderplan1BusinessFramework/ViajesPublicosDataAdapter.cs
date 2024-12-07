
//               File: ViajesPublicosDataAdapter
//        Description: ViajesPublicos
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
   public partial class ViajesPublicosDataAdapter : System.Data.IDataAdapter, IViajesPublicosDataAdapter
   {
      private ViajesPublicosDataSet ViajesPublicosSet ;
      public ViajesPublicosDataAdapter( )
      {
         dsDefault = new DataStore( new SqlServer2005Handler( ), "System.Data.SqlClient", Raiderplan1.Configuration.ConnectionString, DeklaritTransaction.TransactionSlotName) ;
         Init_order_Viaje( ) ;
         orderString = GetOrderString( this.Order, true) ;
         reverseOrderString = GetOrderString( this.Order, false) ;
      }

      private IDbTransaction daCurrentTransaction ;
      ///  <summary>
      ///   Gets or sets the Transaction object to be used  by  ViajesPublicosDataAdapterclasses
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
            fillDataParameters = new  DbParameter[]  {} ;
         }
         return fillDataParameters ;
      }

      private DbParameter[] fillDataParameters ;
      ///  <summary>
      ///   (8) Fills the specified dataset with the record matching ViajeNombre in the the fillDataParameters
      ///    array, if the array is null, it fills the Dataset loading all records in the table.
      ///
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int Fill( DataSet dataSet )
      {
         ViajesPublicosSet = dataSet as ViajesPublicosDataSet ;
         if ( ( ViajesPublicosSet != null ) )
         {
            return Fill( ViajesPublicosSet) ;
         }
         else
         {
            ViajesPublicosSet = new ViajesPublicosDataSet() ;
            Fill( ViajesPublicosSet) ;
            dataSet.Merge( ViajesPublicosSet) ;
            return 0 ;
         }
      }

      ///  <summary>
      ///   (8) Fills the specified dataset with the record matching ViajeNombre in the the fillDataParameters
      ///    array, if the array is null, it fills the Dataset loading all records in the table.
      ///
      ///  </summary>
      ///  <param name="dataSet">DataSet</param>
      public virtual int FillPage( DataSet dataSet ,
                                   int startRow ,
                                   int maxRows )
      {
         ViajesPublicosSet = dataSet as ViajesPublicosDataSet ;
         if ( ( ViajesPublicosSet != null ) )
         {
            return FillPage( ViajesPublicosSet, startRow, maxRows) ;
         }
         else
         {
            ViajesPublicosSet = new ViajesPublicosDataSet() ;
            FillPage( ViajesPublicosSet, startRow, maxRows) ;
            dataSet.Merge( ViajesPublicosSet) ;
            return 0 ;
         }
      }

      public virtual int Fill( ViajesPublicosDataSet dataSet )
      {
         this.Initialize( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         ViajesPublicosSet = dataSet ;
         rowViaje = ViajesPublicosSet.Viaje.NewViajeRow() ;
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


      public virtual int FillPage( ViajesPublicosDataSet dataSet ,
                                   int startRow ,
                                   int maxRows )
      {
         this.Initialize( ) ;
         connDefault = dsDefault.GetReadWriteConnection( daCurrentTransaction) ;
         ViajesPublicosSet = dataSet ;
         rowViaje = ViajesPublicosSet.Viaje.NewViajeRow() ;
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


      public virtual int GetRecordCount( )
      {
         int m_Count ;
         try
         {
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
         String m_WhereString ;
         m_WhereString = " WHERE ([ViajePrivado] IS NULL or [ViajePrivado] = 'N') AND (Not [LugarPartida] IS NULL) AND (Not [Lugarllegada] IS NULL) AND (Not [ViajeMeGustas] IS NULL) AND (Not [ViajeDescargas] IS NULL)" ;
         scmdbuf = "SELECT COUNT(*) FROM [Viaje]" + m_WhereString + "  " ;
         cmViajeSelect1 = connDefault.GetCommand(scmdbuf,false);
         cmViajeSelect1.ErrorMask = cmViajeSelect1.ErrorMask  |  ErrorMask.Lock;
         ViajeSelect1 = cmViajeSelect1.FetchData();
         m_RecordCount = ( ( ViajeSelect1.IsDBNull(0) )  ? (int)(0) : ViajeSelect1.GetInt32(0) ) ;
         ViajeSelect1.Close();
         return m_RecordCount ;
      }

      void executePrivate( int startRow ,
                           int maxRows )
      {
         // DeKlarit formulas
         m_WhereString = " WHERE " + filterString + "  (TM1.[ViajePrivado] IS NULL or TM1.[ViajePrivado] = 'N') AND (Not TM1.[LugarPartida] IS NULL) AND (Not TM1.[Lugarllegada] IS NULL) AND (Not TM1.[ViajeMeGustas] IS NULL) AND (Not TM1.[ViajeDescargas] IS NULL)" ;
         if ( ( maxRows >= 0 ) )
         {
            if ( ( startRow == 0 ) )
            {
               scmdbuf = "SELECT TOP " + maxRows.ToString() + "  TM1.[ViajeID], TM1.[UsuarioID], TM1.[ViajeNombre], TM1.[FechaSalidaProgramada], TM1.[FechaLlegadaProgramada], TM1.[FechaSalidaEfectiva], TM1.[FechaLlegadaEfectiva], TM1.[LugarPartida], TM1.[Lugarllegada], TM1.[LongitudPartida], TM1.[LatitudPartida], TM1.[LongitudLegada], TM1.[LatitudLlegada], TM1.[kmTotalesEstimado], TM1.[MotocilcetaMarca], TM1.[MotociletaModelo], TM1.[ViajeImagen], TM1.[ViajeEstado], TM1.[ViajeFechaCreacion], TM1.[ViajeMeGustas], TM1.[ViajeDescargas], TM1.[ViajeParentID], TM1.[ViajePrivado]  FROM [Viaje] TM1" + m_WhereString + "" + orderString + "" ;
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
               scmdbuf = " SELECT * FROM ( SELECT  TM1.[ViajeID], TM1.[UsuarioID], TM1.[ViajeNombre], TM1.[FechaSalidaProgramada], TM1.[FechaLlegadaProgramada], TM1.[FechaSalidaEfectiva], TM1.[FechaLlegadaEfectiva], TM1.[LugarPartida], TM1.[Lugarllegada], TM1.[LongitudPartida], TM1.[LatitudPartida], TM1.[LongitudLegada], TM1.[LatitudLlegada], TM1.[kmTotalesEstimado], TM1.[MotocilcetaMarca], TM1.[MotociletaModelo], TM1.[ViajeImagen], TM1.[ViajeEstado], TM1.[ViajeFechaCreacion], TM1.[ViajeMeGustas], TM1.[ViajeDescargas], TM1.[ViajeParentID], TM1.[ViajePrivado], ROW_NUMBER() OVER  ( " + orderString + " ) AS DK_PAGENUM   FROM [Viaje] TM1 " + m_WhereString + " ) AS DK_PAGE WHERE DK_PAGENUM BETWEEN " + (startRow + 1).ToString() + " AND " + (startRow + maxRows).ToString() ;
            }
         }
         else
         {
            scmdbuf = "SELECT TM1.[ViajeID], TM1.[UsuarioID], TM1.[ViajeNombre], TM1.[FechaSalidaProgramada], TM1.[FechaLlegadaProgramada], TM1.[FechaSalidaEfectiva], TM1.[FechaLlegadaEfectiva], TM1.[LugarPartida], TM1.[Lugarllegada], TM1.[LongitudPartida], TM1.[LatitudPartida], TM1.[LongitudLegada], TM1.[LatitudLlegada], TM1.[kmTotalesEstimado], TM1.[MotocilcetaMarca], TM1.[MotociletaModelo], TM1.[ViajeImagen], TM1.[ViajeEstado], TM1.[ViajeFechaCreacion], TM1.[ViajeMeGustas], TM1.[ViajeDescargas], TM1.[ViajeParentID], TM1.[ViajePrivado] FROM [Viaje] TM1" + m_WhereString + "" + orderString + " " ;
         }
         cmViajeSelect2 = connDefault.GetCommand(scmdbuf,false);
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
            m_ViajeFechaCreacion = dsDefault.Db.GetDateTime(ViajeSelect2, 18, ref m__ViajeFechaCreacionIsNull) ;
            m_ViajeMeGustas = dsDefault.Db.GetInt32(ViajeSelect2, 19, ref m__ViajeMeGustasIsNull) ;
            m_ViajeDescargas = dsDefault.Db.GetInt32(ViajeSelect2, 20, ref m__ViajeDescargasIsNull) ;
            m_ViajeParentID = dsDefault.Db.GetInt64(ViajeSelect2, 21, ref m__ViajeParentIDIsNull) ;
            m_ViajePrivado = dsDefault.Db.GetString(ViajeSelect2, 22, ref m__ViajePrivadoIsNull) ;
            rowViaje = ViajesPublicosSet.Viaje.NewViajeRow() ;
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
            rowViaje["ViajeFechaCreacion"] = ( ( m__ViajeFechaCreacionIsNull )  ? System.Convert.DBNull : m_ViajeFechaCreacion ) ;
            rowViaje["ViajeMeGustas"] = ( ( m__ViajeMeGustasIsNull )  ? System.Convert.DBNull : m_ViajeMeGustas ) ;
            rowViaje["ViajeDescargas"] = ( ( m__ViajeDescargasIsNull )  ? System.Convert.DBNull : m_ViajeDescargas ) ;
            rowViaje["ViajeParentID"] = ( ( m__ViajeParentIDIsNull )  ? System.Convert.DBNull : m_ViajeParentID ) ;
            rowViaje["ViajePrivado"] = ( ( m__ViajePrivadoIsNull )  ? System.Convert.DBNull : m_ViajePrivado ) ;
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

      private ViajesPublicosDataSet.ViajeRow rowViaje ;
      private void AddRowViaje( )
      {
         ViajesPublicosSet.Viaje.AddViajeRow( rowViaje) ;
         rowViaje.AcceptChanges( ) ;
      }

      ///  <summary>
      ///   Gets or sets the filter used by  ViajesPublicos DataProvider classes to retrieve
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

      public enum Attribute {ViajeID, UsuarioID, ViajeNombre, FechaSalidaProgramada, FechaLlegadaProgramada, FechaSalidaEfectiva, FechaLlegadaEfectiva, LugarPartida, Lugarllegada, LongitudPartida, LatitudPartida, LongitudLegada, LatitudLlegada, kmTotalesEstimado, MotocilcetaMarca, MotociletaModelo, ViajeImagen, ViajeEstado, ViajeFechaCreacion, ViajeMeGustas, ViajeDescargas, ViajeParentID, ViajePrivado};
      private static String[] attributeNames = new String[]  {"TM1.[ViajeID]", "TM1.[UsuarioID]", "TM1.[ViajeNombre]", "TM1.[FechaSalidaProgramada]", "TM1.[FechaLlegadaProgramada]", "TM1.[FechaSalidaEfectiva]", "TM1.[FechaLlegadaEfectiva]", "TM1.[LugarPartida]", "TM1.[Lugarllegada]", "TM1.[LongitudPartida]", "TM1.[LatitudPartida]", "TM1.[LongitudLegada]", "TM1.[LatitudLlegada]", "TM1.[kmTotalesEstimado]", "TM1.[MotocilcetaMarca]", "TM1.[MotociletaModelo]", "TM1.[ViajeImagen]", "TM1.[ViajeEstado]", "TM1.[ViajeFechaCreacion]", "TM1.[ViajeMeGustas]", "TM1.[ViajeDescargas]", "TM1.[ViajeParentID]", "TM1.[ViajePrivado]"} ;
      private void Init_order_Viaje( )
      {
         this.Order = new ArrayList() ;
         this.Order.Add( new OrderAttribute( Attribute.ViajeMeGustas, false)) ;
         this.Order.Add( new OrderAttribute( Attribute.ViajeDescargas, false)) ;
         this.Order.Add( new OrderAttribute( Attribute.ViajeNombre, true)) ;
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
         scmdbuf = "" ;
         m_WhereString = "" ;
         m_RecordCount = 0 ;
         sWhereSep = "" ;
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
         m__ViajeFechaCreacionIsNull = false ;
         m_ViajeFechaCreacion = (DateTime)(DateTime.MinValue) ;
         m__ViajeMeGustasIsNull = false ;
         m_ViajeMeGustas = 0 ;
         m__ViajeDescargasIsNull = false ;
         m_ViajeDescargas = 0 ;
         m__ViajeParentIDIsNull = false ;
         m_ViajeParentID = 0 ;
         m__ViajePrivadoIsNull = false ;
         m_ViajePrivado = "" ;
         // GeneXus formulas.
         if ( ( this.Transaction == null ) )
         {
            this.Transaction = ((System.Data.IDbTransaction)(System.Threading.Thread.GetData(System.Threading.Thread.GetNamedDataSlot(DeklaritTransaction.TransactionSlotName)) ));
         }
      }

      private int m_RecordCount ;
      private int m_UsuarioID ;
      private int m_ViajeMeGustas ;
      private int m_ViajeDescargas ;
      private long m_ViajeID ;
      private long m_ViajeParentID ;
      private decimal m_LongitudPartida ;
      private decimal m_LatitudPartida ;
      private decimal m_LongitudLegada ;
      private decimal m_LatitudLlegada ;
      private decimal m_kmTotalesEstimado ;
      private String scmdbuf ;
      private String m_WhereString ;
      private String sWhereSep ;
      private String m_ViajePrivado ;
      private DateTime m_FechaSalidaProgramada ;
      private DateTime m_FechaLlegadaProgramada ;
      private DateTime m_FechaSalidaEfectiva ;
      private DateTime m_FechaLlegadaEfectiva ;
      private DateTime m_ViajeFechaCreacion ;
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
      private bool m__ViajeFechaCreacionIsNull ;
      private bool m__ViajeMeGustasIsNull ;
      private bool m__ViajeDescargasIsNull ;
      private bool m__ViajeParentIDIsNull ;
      private bool m__ViajePrivadoIsNull ;
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

   public class ViajesPublicosDataReader : System.IDisposable
   {
      public ViajesPublicosDataReader( )
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
      ///   Gets or sets the Transaction object to be used  by  ViajesPublicosDataReaderDeklarit
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
         m_WhereString = " WHERE " + filterString + "  (TM1.[ViajePrivado] IS NULL or TM1.[ViajePrivado] = 'N') AND (Not TM1.[LugarPartida] IS NULL) AND (Not TM1.[Lugarllegada] IS NULL) AND (Not TM1.[ViajeMeGustas] IS NULL) AND (Not TM1.[ViajeDescargas] IS NULL)" ;
         scmdbuf = "SELECT TM1.[ViajeID], TM1.[UsuarioID], TM1.[ViajeNombre], TM1.[FechaSalidaProgramada], TM1.[FechaLlegadaProgramada], TM1.[FechaSalidaEfectiva], TM1.[FechaLlegadaEfectiva], TM1.[LugarPartida], TM1.[Lugarllegada], TM1.[LongitudPartida], TM1.[LatitudPartida], TM1.[LongitudLegada], TM1.[LatitudLlegada], TM1.[kmTotalesEstimado], TM1.[MotocilcetaMarca], TM1.[MotociletaModelo], TM1.[ViajeImagen], TM1.[ViajeEstado], TM1.[ViajeFechaCreacion], TM1.[ViajeMeGustas], TM1.[ViajeDescargas], TM1.[ViajeParentID], TM1.[ViajePrivado] FROM [Viaje] TM1" + m_WhereString + " " + orderString + "  " ;
         cmViajeSelect3 = connDefault.GetCommand(scmdbuf,false);
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
      ///   Gets or sets the filter used by  ViajesPublicos DataProvider classes to retrieve
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

      public enum Attribute {ViajeID, UsuarioID, ViajeNombre, FechaSalidaProgramada, FechaLlegadaProgramada, FechaSalidaEfectiva, FechaLlegadaEfectiva, LugarPartida, Lugarllegada, LongitudPartida, LatitudPartida, LongitudLegada, LatitudLlegada, kmTotalesEstimado, MotocilcetaMarca, MotociletaModelo, ViajeImagen, ViajeEstado, ViajeFechaCreacion, ViajeMeGustas, ViajeDescargas, ViajeParentID, ViajePrivado};
      private static String[] attributeNames = new String[]  {"TM1.[ViajeID]", "TM1.[UsuarioID]", "TM1.[ViajeNombre]", "TM1.[FechaSalidaProgramada]", "TM1.[FechaLlegadaProgramada]", "TM1.[FechaSalidaEfectiva]", "TM1.[FechaLlegadaEfectiva]", "TM1.[LugarPartida]", "TM1.[Lugarllegada]", "TM1.[LongitudPartida]", "TM1.[LatitudPartida]", "TM1.[LongitudLegada]", "TM1.[LatitudLlegada]", "TM1.[kmTotalesEstimado]", "TM1.[MotocilcetaMarca]", "TM1.[MotociletaModelo]", "TM1.[ViajeImagen]", "TM1.[ViajeEstado]", "TM1.[ViajeFechaCreacion]", "TM1.[ViajeMeGustas]", "TM1.[ViajeDescargas]", "TM1.[ViajeParentID]", "TM1.[ViajePrivado]"} ;
      private void Init_order_Viaje( )
      {
         this.Order = new ArrayList() ;
         this.Order.Add( new OrderAttribute( Attribute.ViajeMeGustas, false)) ;
         this.Order.Add( new OrderAttribute( Attribute.ViajeDescargas, false)) ;
         this.Order.Add( new OrderAttribute( Attribute.ViajeNombre, true)) ;
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
