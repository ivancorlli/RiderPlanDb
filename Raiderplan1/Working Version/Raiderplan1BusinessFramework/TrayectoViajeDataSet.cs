
//               File: TrayectoViajeDataSet
//        Description: TrayectoViaje
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5_0.002
//       Program type: Deklarit Business Component
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   using System;
   using System.Collections;
   using System.Data;
   using System.Data.SqlClient;
   using System.Data.Common;
   using System.ComponentModel.Design;
   using System.Xml;
   using System.Configuration;
   using System.Data.SqlTypes;
   [Serializable()]
   public partial class TrayectoViajeDataSet : System.Data.DataSet
   {
      private TrayectoViajeDataTable tableTrayectoViaje ;
      [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
      public TrayectoViajeDataTable TrayectoViaje
      {
         get {
            return this.tableTrayectoViaje ;
         }

      }

      private System.Data.SchemaSerializationMode _schemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema;
      
      [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
      public TrayectoViajeDataSet() {
          this.BeginInit();
          this.InitClass();
          System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
          base.Tables.CollectionChanged += schemaChangedHandler;
          base.Relations.CollectionChanged += schemaChangedHandler;
          this.EndInit();
      }
      
      public override System.Data.SchemaSerializationMode SchemaSerializationMode {
          get {
              return this._schemaSerializationMode;
          }
          set {
              this._schemaSerializationMode = value;
          }
      }
      
      [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
      public new System.Data.DataTableCollection Tables {
          get {
              return base.Tables;
          }
      }
      
      [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
      public new System.Data.DataRelationCollection Relations {
          get {
              return base.Relations;
          }
      }
      
      [System.ComponentModel.DefaultValueAttribute(true)]
      public new bool EnforceConstraints {
          get {
              return base.EnforceConstraints;
          }
          set {
              base.EnforceConstraints = value;
          }
      }
      
      protected override void InitializeDerivedDataSet() {
          this.BeginInit();
          this.InitClassBase();
          this.EndInit();
      }
      
      public override System.Data.DataSet Clone() {
          TrayectoViajeDataSet cln = ((TrayectoViajeDataSet)(base.Clone()));
          cln.InitVars();
          return cln;
      }
      
      protected override bool ShouldSerializeTables() {
      	    return false;
      }
      
      protected override bool ShouldSerializeRelations() {
      	    return false;
      }
      
      private bool ShouldSerializeTrayectoViaje() { 
		return false; 
	  }
              
      protected override void ReadXmlSerializable(XmlReader reader) 
      {
          if ((this.DetermineSchemaSerializationMode(reader) == System.Data.SchemaSerializationMode.IncludeSchema)) 
          {
      		this.Reset();
      		DataSet ds = new DataSet();
              ds.ReadXml(reader);
              if ((ds.Tables["TrayectoViaje"] != null))  
        { 
			base.Tables.Add(new TrayectoViajeDataTable(ds.Tables["TrayectoViaje"])); 
        }		
      	    this.DataSetName = ds.DataSetName;
      		this.Prefix = ds.Prefix;
      		this.Namespace = ds.Namespace;
      		this.Locale = ds.Locale;
      		this.CaseSensitive = ds.CaseSensitive;
      		this.EnforceConstraints = ds.EnforceConstraints;
      		this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
      		this.InitVars();
      	}
          else 
          {
      	  this.ExtendedProperties.Clear();
              this.ReadXml(reader);
              this.InitVars();
          }
      }
      
      protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() 
      {
          System.IO.MemoryStream stream = new System.IO.MemoryStream();
          this.WriteXmlSchema(new XmlTextWriter(stream, null));
          stream.Position = 0;
          return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
      }
      
      internal void InitVars() 
      {
      	this.InitVars(true);
      }
      
      internal void InitVars(bool initTable) {
          this.tableTrayectoViaje = ((TrayectoViajeDataTable)(base.Tables["TrayectoViaje"]));		
		  if ((initTable == true)) { 
			if ((this.tableTrayectoViaje != null)) { 
				this.tableTrayectoViaje.InitVars(); 
			} 
	  	  }  
      	this.RemotingFormat = SerializationFormat.Binary;
      } 
             
      private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
          if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
              this.InitVars();
          }
      }
      
      public static System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(System.Xml.Schema.XmlSchemaSet xs) {
          TrayectoViajeDataSet ds = new TrayectoViajeDataSet();
          System.Xml.Schema.XmlSchemaComplexType type = new System.Xml.Schema.XmlSchemaComplexType();
          System.Xml.Schema.XmlSchemaSequence sequence = new System.Xml.Schema.XmlSchemaSequence();
          xs.Add(ds.GetSchemaSerializable());
          System.Xml.Schema.XmlSchemaAny any = new System.Xml.Schema.XmlSchemaAny();
          any.Namespace = ds.Namespace;
          sequence.Items.Add(any);
          type.Particle = sequence;
          return type;
      }
      [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
      protected TrayectoViajeDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context, false)
      {
      	if ((this.IsBinarySerialized(info, context) == true)) 
      	{
      		this.InitVars(false);
      		System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
      		this.Tables.CollectionChanged += schemaChangedHandler1;
      		this.Relations.CollectionChanged += schemaChangedHandler1;
      		return;
      	}
      
      	string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
      	if ((this.DetermineSchemaSerializationMode(info, context) == System.Data.SchemaSerializationMode.IncludeSchema)) 
      	{
      		System.Data.DataSet ds = new System.Data.DataSet();
              ds.ReadXmlSchema(new System.Xml.XmlTextReader(new System.IO.StringReader(strSchema)));
              if ((ds.Tables["TrayectoViaje"] != null))  
        { 
			base.Tables.Add(new TrayectoViajeDataTable(ds.Tables["TrayectoViaje"])); 
        }        
              this.DataSetName = ds.DataSetName;
              this.Prefix = ds.Prefix;
              this.Namespace = ds.Namespace;
              this.Locale = ds.Locale;
              this.CaseSensitive = ds.CaseSensitive;
              this.EnforceConstraints = ds.EnforceConstraints;
              this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
              this.InitVars();
           }
           else 
           {
      		this.ReadXmlSchema(new System.Xml.XmlTextReader(new System.IO.StringReader(strSchema)));
           }
           
           this.GetSerializationData(info, context);
           System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
           base.Tables.CollectionChanged += schemaChangedHandler;
           this.Relations.CollectionChanged += schemaChangedHandler;
      }
      
      private void InitClass( )
      {
         InitClassBase( ) ;
         this.ExtendedProperties.Add( "DataAdapterName", "TrayectoViajeDataAdapter") ;
         this.ExtendedProperties.Add( "BigImage", " ") ;
         this.ExtendedProperties.Add( "SmallImage", " ") ;
         this.ExtendedProperties.Add( "Image", " ") ;
         this.ExtendedProperties.Add( "Deklarit.PermissionBaseId", "2012") ;
         this.ExtendedProperties.Add( "DataSetName", "TrayectoViajeDataSet") ;
         this.ExtendedProperties.Add( "DataAdapterInterfaceName", "ITrayectoViajeDataAdapter") ;
         this.ExtendedProperties.Add( "ObjectName", "TrayectoViaje") ;
         this.ExtendedProperties.Add( "ObjectDescription", "TrayectoViaje") ;
         this.ExtendedProperties.Add( "ObjectType", "BusinessComponent") ;
         this.ExtendedProperties.Add( "ObjectPath", "\\BusinessComponents\\Vaijes") ;
         this.ExtendedProperties.Add( "NameSpace", "Raiderplan1") ;
         this.ExtendedProperties.Add( "DataChangeFrequency", "PrettyOften") ;
         this.ExtendedProperties.Add( "CachePriority", "Medium") ;
         this.ExtendedProperties.Add( "Deklarit.AddNewOptionToLowCardinality", "True") ;
         this.ExtendedProperties.Add( "Deklarit.DescriptionAttribute", "") ;
         this.ExtendedProperties.Add( "Deklarit.LowCardinality", "False") ;
      }

      private void InitClassBase( )
      {
         this.DataSetName = "TrayectoViajeDataSet" ;
         this.Namespace = "http://www.tempuri.org/TrayectoViaje" ;
         this.tableTrayectoViaje = new TrayectoViajeDataTable() ;
         this.Tables.Add( this.tableTrayectoViaje) ;
      }

      public delegate  void TrayectoViajeRowChangeEventHandler( object sender ,
                                                                TrayectoViajeRowChangeEvent e );
      [Serializable()]
      public partial class TrayectoViajeDataTable : DataTable, System.Collections.IEnumerable
      {
         private DataColumn columnTrayectoViajeID ;
         private DataColumn columnViajeID ;
         private DataColumn columnTrayectoOrigen ;
         private DataColumn columnTrayectoDestino ;
         private DataColumn columnTayectoLatitudOrigen ;
         private DataColumn columnTrayectoLongitudOrigen ;
         private DataColumn columnTrayectoLatidudDestino ;
         private DataColumn columnTrayectoLongitudDestino ;
         private DataColumn columnTrayectokm ;
         private DataColumn columnTiempoEstimado ;
         private DataColumn columnCombustibleConsumido ;
         private DataColumn columnEstadoCarretera ;
         private DataColumn columnInstrucciones ;
         private DataColumn columnOrden ;
         private DataColumn columnEsOrigen ;
         public TrayectoViajeDataTable() 
         {
             this.TableName = "TrayectoViaje";
             this.BeginInit();
             this.InitClass();
             this.EndInit();
         }
         
         internal TrayectoViajeDataTable(System.Data.DataTable table) {
             this.TableName = table.TableName;
             if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                 this.CaseSensitive = table.CaseSensitive;
             }
             if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                 this.Locale = table.Locale;
             }
             if ((table.Namespace != table.DataSet.Namespace)) {
                 this.Namespace = table.Namespace;
             }
             this.Prefix = table.Prefix;
             this.MinimumCapacity = table.MinimumCapacity;
         }
         
         [System.ComponentModel.Browsable(false)]
         public int Count {
             get {
                 return this.Rows.Count;
             }
         }
         
         public TrayectoViajeRow this[int index] {
             get {
                 return ((TrayectoViajeRow)(this.Rows[index]));
             }
         }
         
         public virtual System.Collections.IEnumerator GetEnumerator() {
             return this.Rows.GetEnumerator();
         }
         
         public override System.Data.DataTable Clone() {
             TrayectoViajeDataTable cln = ((TrayectoViajeDataTable)(base.Clone()));
             cln.InitVars();
             return cln;
         }
         
         protected override System.Data.DataTable CreateInstance() {
             return new TrayectoViajeDataTable();
         }
         
         public void AddTrayectoViajeRow(TrayectoViajeRow row) {
             this.Rows.Add(row);
         }
         
         public TrayectoViajeRow NewTrayectoViajeRow() {
             return ((TrayectoViajeRow)(this.NewRow()));
         }
         
         protected override System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder) {
             return new TrayectoViajeRow(builder);
         }
         
         protected override System.Type GetRowType() {
             return typeof(TrayectoViajeRow);
         }
         
         public void RemoveTrayectoViajeRow(TrayectoViajeRow row) {
             this.Rows.Remove(row);
         }
         
         public static System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet xs) {
             System.Xml.Schema.XmlSchemaComplexType type = new System.Xml.Schema.XmlSchemaComplexType();
             System.Xml.Schema.XmlSchemaSequence sequence = new System.Xml.Schema.XmlSchemaSequence();
             TrayectoViajeDataSet ds = new TrayectoViajeDataSet();
             xs.Add(ds.GetSchemaSerializable());
             System.Xml.Schema.XmlSchemaAny any1 = new System.Xml.Schema.XmlSchemaAny();
             any1.Namespace = "http://www.w3.org/2001/XMLSchema";
             any1.MinOccurs = new decimal(0);
             any1.MaxOccurs = decimal.MaxValue;
             any1.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax;
             sequence.Items.Add(any1);
             System.Xml.Schema.XmlSchemaAny any2 = new System.Xml.Schema.XmlSchemaAny();
             any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
             any2.MinOccurs = new decimal(1);
             any2.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax;
             sequence.Items.Add(any2);
             System.Xml.Schema.XmlSchemaAttribute attribute1 = new System.Xml.Schema.XmlSchemaAttribute();
             attribute1.Name = "namespace";
             attribute1.FixedValue = ds.Namespace;
             type.Attributes.Add(attribute1);
             System.Xml.Schema.XmlSchemaAttribute attribute2 = new System.Xml.Schema.XmlSchemaAttribute();
             attribute2.Name = "tableTypeName";
             attribute2.FixedValue = "TrayectoViajeDataTable";
             type.Attributes.Add(attribute2);
             type.Particle = sequence;
             return type;
         }
         protected TrayectoViajeDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                 base(info, context) 
         {
             this.InitVars();
         }
         public DataColumn TrayectoViajeIDColumn
         {
            get {
               return this.columnTrayectoViajeID ;
            }

         }

         public DataColumn ViajeIDColumn
         {
            get {
               return this.columnViajeID ;
            }

         }

         public DataColumn TrayectoOrigenColumn
         {
            get {
               return this.columnTrayectoOrigen ;
            }

         }

         public DataColumn TrayectoDestinoColumn
         {
            get {
               return this.columnTrayectoDestino ;
            }

         }

         public DataColumn TayectoLatitudOrigenColumn
         {
            get {
               return this.columnTayectoLatitudOrigen ;
            }

         }

         public DataColumn TrayectoLongitudOrigenColumn
         {
            get {
               return this.columnTrayectoLongitudOrigen ;
            }

         }

         public DataColumn TrayectoLatidudDestinoColumn
         {
            get {
               return this.columnTrayectoLatidudDestino ;
            }

         }

         public DataColumn TrayectoLongitudDestinoColumn
         {
            get {
               return this.columnTrayectoLongitudDestino ;
            }

         }

         public DataColumn TrayectokmColumn
         {
            get {
               return this.columnTrayectokm ;
            }

         }

         public DataColumn TiempoEstimadoColumn
         {
            get {
               return this.columnTiempoEstimado ;
            }

         }

         public DataColumn CombustibleConsumidoColumn
         {
            get {
               return this.columnCombustibleConsumido ;
            }

         }

         public DataColumn EstadoCarreteraColumn
         {
            get {
               return this.columnEstadoCarretera ;
            }

         }

         public DataColumn InstruccionesColumn
         {
            get {
               return this.columnInstrucciones ;
            }

         }

         public DataColumn OrdenColumn
         {
            get {
               return this.columnOrden ;
            }

         }

         public DataColumn EsOrigenColumn
         {
            get {
               return this.columnEsOrigen ;
            }

         }

         public event TrayectoViajeRowChangeEventHandler TrayectoViajeRowChanged ;
         public event TrayectoViajeRowChangeEventHandler TrayectoViajeRowChanging ;
         public event TrayectoViajeRowChangeEventHandler TrayectoViajeRowDeleted ;
         public event TrayectoViajeRowChangeEventHandler TrayectoViajeRowDeleting ;
         public TrayectoViajeRow AddTrayectoViajeRow( long viajeID ,
                                                      String trayectoOrigen ,
                                                      String trayectoDestino ,
                                                      decimal tayectoLatitudOrigen ,
                                                      decimal trayectoLongitudOrigen ,
                                                      decimal trayectoLatidudDestino ,
                                                      decimal trayectoLongitudDestino ,
                                                      decimal trayectokm ,
                                                      decimal tiempoEstimado ,
                                                      decimal combustibleConsumido ,
                                                      String estadoCarretera ,
                                                      String instrucciones ,
                                                      int orden ,
                                                      String esOrigen )
         {
            TrayectoViajeRow rowTrayectoViajeRow = ((TrayectoViajeRow)(this.NewRow())) ;
            rowTrayectoViajeRow["ViajeID"] = viajeID ;
            rowTrayectoViajeRow["TrayectoOrigen"] = trayectoOrigen ;
            rowTrayectoViajeRow["TrayectoDestino"] = trayectoDestino ;
            rowTrayectoViajeRow["TayectoLatitudOrigen"] = tayectoLatitudOrigen ;
            rowTrayectoViajeRow["TrayectoLongitudOrigen"] = trayectoLongitudOrigen ;
            rowTrayectoViajeRow["TrayectoLatidudDestino"] = trayectoLatidudDestino ;
            rowTrayectoViajeRow["TrayectoLongitudDestino"] = trayectoLongitudDestino ;
            rowTrayectoViajeRow["Trayectokm"] = trayectokm ;
            rowTrayectoViajeRow["TiempoEstimado"] = tiempoEstimado ;
            rowTrayectoViajeRow["CombustibleConsumido"] = combustibleConsumido ;
            rowTrayectoViajeRow["EstadoCarretera"] = estadoCarretera ;
            rowTrayectoViajeRow["Instrucciones"] = instrucciones ;
            rowTrayectoViajeRow["Orden"] = orden ;
            rowTrayectoViajeRow["EsOrigen"] = esOrigen ;
            this.Rows.Add( rowTrayectoViajeRow) ;
            return rowTrayectoViajeRow ;
         }

         public TrayectoViajeRow FindByTrayectoViajeID( int trayectoViajeID )
         {
            return ((TrayectoViajeRow)(this.Rows.Find(new  object[] {trayectoViajeID}))) ;
         }

         internal void InitVars( )
         {
            this.columnTrayectoViajeID = this.Columns["TrayectoViajeID"] ;
            this.columnViajeID = this.Columns["ViajeID"] ;
            this.columnTrayectoOrigen = this.Columns["TrayectoOrigen"] ;
            this.columnTrayectoDestino = this.Columns["TrayectoDestino"] ;
            this.columnTayectoLatitudOrigen = this.Columns["TayectoLatitudOrigen"] ;
            this.columnTrayectoLongitudOrigen = this.Columns["TrayectoLongitudOrigen"] ;
            this.columnTrayectoLatidudDestino = this.Columns["TrayectoLatidudDestino"] ;
            this.columnTrayectoLongitudDestino = this.Columns["TrayectoLongitudDestino"] ;
            this.columnTrayectokm = this.Columns["Trayectokm"] ;
            this.columnTiempoEstimado = this.Columns["TiempoEstimado"] ;
            this.columnCombustibleConsumido = this.Columns["CombustibleConsumido"] ;
            this.columnEstadoCarretera = this.Columns["EstadoCarretera"] ;
            this.columnInstrucciones = this.Columns["Instrucciones"] ;
            this.columnOrden = this.Columns["Orden"] ;
            this.columnEsOrigen = this.Columns["EsOrigen"] ;
         }

         public void InitClass( )
         {
            this.columnTrayectoViajeID = new DataColumn( "TrayectoViajeID", typeof(int), "", System.Data.MappingType.Element) ;
            this.columnTrayectoViajeID.AllowDBNull = false ;
            this.columnTrayectoViajeID.Caption = "Trayecto Viaje ID" ;
            this.columnTrayectoViajeID.Unique = true ;
            this.columnTrayectoViajeID.AutoIncrement = true ;
            this.columnTrayectoViajeID.AutoIncrementSeed = -1 ;
            this.columnTrayectoViajeID.AutoIncrementStep = -1 ;
            this.columnTrayectoViajeID.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnTrayectoViajeID.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnTrayectoViajeID.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnTrayectoViajeID.ExtendedProperties.Add( "AutoNumber", "true") ;
            this.columnTrayectoViajeID.ExtendedProperties.Add( "IsKey", "true") ;
            this.columnTrayectoViajeID.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnTrayectoViajeID.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnTrayectoViajeID.ExtendedProperties.Add( "Description", "Trayecto Viaje ID") ;
            this.columnTrayectoViajeID.ExtendedProperties.Add( "Length", "8") ;
            this.columnTrayectoViajeID.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnTrayectoViajeID.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnTrayectoViajeID.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnTrayectoViajeID.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnTrayectoViajeID.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnTrayectoViajeID.ExtendedProperties.Add( "Deklarit.InternalName", "TrayectoViajeID") ;
            this.Columns.Add( this.columnTrayectoViajeID) ;
            this.columnViajeID = new DataColumn( "ViajeID", typeof(long), "", System.Data.MappingType.Element) ;
            this.columnViajeID.AllowDBNull = false ;
            this.columnViajeID.Caption = "Viaje ID" ;
            this.columnViajeID.DefaultValue = System.Convert.DBNull ;
            this.columnViajeID.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnViajeID.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnViajeID.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnViajeID.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnViajeID.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnViajeID.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnViajeID.ExtendedProperties.Add( "Description", "Viaje ID") ;
            this.columnViajeID.ExtendedProperties.Add( "Length", "10") ;
            this.columnViajeID.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnViajeID.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnViajeID.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnViajeID.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnViajeID.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnViajeID.ExtendedProperties.Add( "Deklarit.InternalName", "ViajeID") ;
            this.Columns.Add( this.columnViajeID) ;
            this.columnTrayectoOrigen = new DataColumn( "TrayectoOrigen", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnTrayectoOrigen.AllowDBNull = true ;
            this.columnTrayectoOrigen.Caption = "Trayecto Origen" ;
            this.columnTrayectoOrigen.MaxLength = 150 ;
            this.columnTrayectoOrigen.DefaultValue = System.Convert.DBNull ;
            this.columnTrayectoOrigen.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnTrayectoOrigen.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnTrayectoOrigen.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnTrayectoOrigen.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnTrayectoOrigen.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnTrayectoOrigen.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnTrayectoOrigen.ExtendedProperties.Add( "Description", "Trayecto Origen") ;
            this.columnTrayectoOrigen.ExtendedProperties.Add( "Length", "150") ;
            this.columnTrayectoOrigen.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnTrayectoOrigen.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnTrayectoOrigen.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnTrayectoOrigen.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnTrayectoOrigen.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnTrayectoOrigen.ExtendedProperties.Add( "Deklarit.InternalName", "TrayectoOrigen") ;
            this.Columns.Add( this.columnTrayectoOrigen) ;
            this.columnTrayectoDestino = new DataColumn( "TrayectoDestino", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnTrayectoDestino.AllowDBNull = false ;
            this.columnTrayectoDestino.Caption = "Trayecto Destino" ;
            this.columnTrayectoDestino.MaxLength = 150 ;
            this.columnTrayectoDestino.DefaultValue = System.Convert.DBNull ;
            this.columnTrayectoDestino.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnTrayectoDestino.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnTrayectoDestino.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnTrayectoDestino.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnTrayectoDestino.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnTrayectoDestino.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnTrayectoDestino.ExtendedProperties.Add( "Description", "Trayecto Destino") ;
            this.columnTrayectoDestino.ExtendedProperties.Add( "Length", "150") ;
            this.columnTrayectoDestino.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnTrayectoDestino.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnTrayectoDestino.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnTrayectoDestino.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnTrayectoDestino.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnTrayectoDestino.ExtendedProperties.Add( "Deklarit.InternalName", "TrayectoDestino") ;
            this.Columns.Add( this.columnTrayectoDestino) ;
            this.columnTayectoLatitudOrigen = new DataColumn( "TayectoLatitudOrigen", typeof(decimal), "", System.Data.MappingType.Element) ;
            this.columnTayectoLatitudOrigen.AllowDBNull = true ;
            this.columnTayectoLatitudOrigen.Caption = "Tayecto Latitud Origen" ;
            this.columnTayectoLatitudOrigen.DefaultValue = System.Convert.DBNull ;
            this.columnTayectoLatitudOrigen.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnTayectoLatitudOrigen.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnTayectoLatitudOrigen.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnTayectoLatitudOrigen.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnTayectoLatitudOrigen.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnTayectoLatitudOrigen.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnTayectoLatitudOrigen.ExtendedProperties.Add( "Description", "Tayecto Latitud Origen") ;
            this.columnTayectoLatitudOrigen.ExtendedProperties.Add( "Length", "17") ;
            this.columnTayectoLatitudOrigen.ExtendedProperties.Add( "Decimals", "15") ;
            this.columnTayectoLatitudOrigen.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnTayectoLatitudOrigen.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnTayectoLatitudOrigen.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnTayectoLatitudOrigen.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnTayectoLatitudOrigen.ExtendedProperties.Add( "Deklarit.InternalName", "TayectoLatitudOrigen") ;
            this.Columns.Add( this.columnTayectoLatitudOrigen) ;
            this.columnTrayectoLongitudOrigen = new DataColumn( "TrayectoLongitudOrigen", typeof(decimal), "", System.Data.MappingType.Element) ;
            this.columnTrayectoLongitudOrigen.AllowDBNull = true ;
            this.columnTrayectoLongitudOrigen.Caption = "Trayecto Longitud Origen" ;
            this.columnTrayectoLongitudOrigen.DefaultValue = System.Convert.DBNull ;
            this.columnTrayectoLongitudOrigen.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnTrayectoLongitudOrigen.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnTrayectoLongitudOrigen.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnTrayectoLongitudOrigen.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnTrayectoLongitudOrigen.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnTrayectoLongitudOrigen.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnTrayectoLongitudOrigen.ExtendedProperties.Add( "Description", "Trayecto Longitud Origen") ;
            this.columnTrayectoLongitudOrigen.ExtendedProperties.Add( "Length", "17") ;
            this.columnTrayectoLongitudOrigen.ExtendedProperties.Add( "Decimals", "15") ;
            this.columnTrayectoLongitudOrigen.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnTrayectoLongitudOrigen.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnTrayectoLongitudOrigen.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnTrayectoLongitudOrigen.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnTrayectoLongitudOrigen.ExtendedProperties.Add( "Deklarit.InternalName", "TrayectoLongitudOrigen") ;
            this.Columns.Add( this.columnTrayectoLongitudOrigen) ;
            this.columnTrayectoLatidudDestino = new DataColumn( "TrayectoLatidudDestino", typeof(decimal), "", System.Data.MappingType.Element) ;
            this.columnTrayectoLatidudDestino.AllowDBNull = true ;
            this.columnTrayectoLatidudDestino.Caption = "Trayecto Latidud Destino" ;
            this.columnTrayectoLatidudDestino.DefaultValue = System.Convert.DBNull ;
            this.columnTrayectoLatidudDestino.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnTrayectoLatidudDestino.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnTrayectoLatidudDestino.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnTrayectoLatidudDestino.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnTrayectoLatidudDestino.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnTrayectoLatidudDestino.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnTrayectoLatidudDestino.ExtendedProperties.Add( "Description", "Trayecto Latidud Destino") ;
            this.columnTrayectoLatidudDestino.ExtendedProperties.Add( "Length", "17") ;
            this.columnTrayectoLatidudDestino.ExtendedProperties.Add( "Decimals", "15") ;
            this.columnTrayectoLatidudDestino.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnTrayectoLatidudDestino.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnTrayectoLatidudDestino.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnTrayectoLatidudDestino.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnTrayectoLatidudDestino.ExtendedProperties.Add( "Deklarit.InternalName", "TrayectoLatidudDestino") ;
            this.Columns.Add( this.columnTrayectoLatidudDestino) ;
            this.columnTrayectoLongitudDestino = new DataColumn( "TrayectoLongitudDestino", typeof(decimal), "", System.Data.MappingType.Element) ;
            this.columnTrayectoLongitudDestino.AllowDBNull = true ;
            this.columnTrayectoLongitudDestino.Caption = "Trayecto Longitud Destino" ;
            this.columnTrayectoLongitudDestino.DefaultValue = System.Convert.DBNull ;
            this.columnTrayectoLongitudDestino.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnTrayectoLongitudDestino.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnTrayectoLongitudDestino.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnTrayectoLongitudDestino.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnTrayectoLongitudDestino.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnTrayectoLongitudDestino.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnTrayectoLongitudDestino.ExtendedProperties.Add( "Description", "Trayecto Longitud Destino") ;
            this.columnTrayectoLongitudDestino.ExtendedProperties.Add( "Length", "17") ;
            this.columnTrayectoLongitudDestino.ExtendedProperties.Add( "Decimals", "15") ;
            this.columnTrayectoLongitudDestino.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnTrayectoLongitudDestino.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnTrayectoLongitudDestino.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnTrayectoLongitudDestino.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnTrayectoLongitudDestino.ExtendedProperties.Add( "Deklarit.InternalName", "TrayectoLongitudDestino") ;
            this.Columns.Add( this.columnTrayectoLongitudDestino) ;
            this.columnTrayectokm = new DataColumn( "Trayectokm", typeof(decimal), "", System.Data.MappingType.Element) ;
            this.columnTrayectokm.AllowDBNull = true ;
            this.columnTrayectokm.Caption = "Trayectokm" ;
            this.columnTrayectokm.DefaultValue = System.Convert.DBNull ;
            this.columnTrayectokm.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnTrayectokm.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnTrayectokm.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnTrayectokm.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnTrayectokm.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnTrayectokm.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnTrayectokm.ExtendedProperties.Add( "Description", "Trayecto Km") ;
            this.columnTrayectokm.ExtendedProperties.Add( "Length", "5") ;
            this.columnTrayectokm.ExtendedProperties.Add( "Decimals", "2") ;
            this.columnTrayectokm.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnTrayectokm.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnTrayectokm.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnTrayectokm.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnTrayectokm.ExtendedProperties.Add( "Deklarit.InternalName", "Trayectokm") ;
            this.Columns.Add( this.columnTrayectokm) ;
            this.columnTiempoEstimado = new DataColumn( "TiempoEstimado", typeof(decimal), "", System.Data.MappingType.Element) ;
            this.columnTiempoEstimado.AllowDBNull = true ;
            this.columnTiempoEstimado.Caption = "Tiempo Estimado" ;
            this.columnTiempoEstimado.DefaultValue = System.Convert.DBNull ;
            this.columnTiempoEstimado.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnTiempoEstimado.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnTiempoEstimado.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnTiempoEstimado.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnTiempoEstimado.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnTiempoEstimado.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnTiempoEstimado.ExtendedProperties.Add( "Description", "Tiempo Estimado en horas") ;
            this.columnTiempoEstimado.ExtendedProperties.Add( "Length", "4") ;
            this.columnTiempoEstimado.ExtendedProperties.Add( "Decimals", "2") ;
            this.columnTiempoEstimado.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnTiempoEstimado.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnTiempoEstimado.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnTiempoEstimado.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnTiempoEstimado.ExtendedProperties.Add( "Deklarit.InternalName", "TiempoEstimado") ;
            this.Columns.Add( this.columnTiempoEstimado) ;
            this.columnCombustibleConsumido = new DataColumn( "CombustibleConsumido", typeof(decimal), "", System.Data.MappingType.Element) ;
            this.columnCombustibleConsumido.AllowDBNull = true ;
            this.columnCombustibleConsumido.Caption = "Combustible Consumido" ;
            this.columnCombustibleConsumido.DefaultValue = System.Convert.DBNull ;
            this.columnCombustibleConsumido.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnCombustibleConsumido.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnCombustibleConsumido.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnCombustibleConsumido.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnCombustibleConsumido.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnCombustibleConsumido.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnCombustibleConsumido.ExtendedProperties.Add( "Description", "Combustible Consumido en litros") ;
            this.columnCombustibleConsumido.ExtendedProperties.Add( "Length", "5") ;
            this.columnCombustibleConsumido.ExtendedProperties.Add( "Decimals", "2") ;
            this.columnCombustibleConsumido.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnCombustibleConsumido.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnCombustibleConsumido.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnCombustibleConsumido.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnCombustibleConsumido.ExtendedProperties.Add( "Deklarit.InternalName", "CombustibleConsumido") ;
            this.Columns.Add( this.columnCombustibleConsumido) ;
            this.columnEstadoCarretera = new DataColumn( "EstadoCarretera", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnEstadoCarretera.AllowDBNull = true ;
            this.columnEstadoCarretera.Caption = "Estado Carretera" ;
            this.columnEstadoCarretera.MaxLength = 100 ;
            this.columnEstadoCarretera.DefaultValue = System.Convert.DBNull ;
            this.columnEstadoCarretera.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnEstadoCarretera.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnEstadoCarretera.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnEstadoCarretera.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnEstadoCarretera.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnEstadoCarretera.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnEstadoCarretera.ExtendedProperties.Add( "Description", "Estado Carretera") ;
            this.columnEstadoCarretera.ExtendedProperties.Add( "Length", "100") ;
            this.columnEstadoCarretera.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnEstadoCarretera.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnEstadoCarretera.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnEstadoCarretera.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnEstadoCarretera.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnEstadoCarretera.ExtendedProperties.Add( "Deklarit.InternalName", "EstadoCarretera") ;
            this.Columns.Add( this.columnEstadoCarretera) ;
            this.columnInstrucciones = new DataColumn( "Instrucciones", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnInstrucciones.AllowDBNull = true ;
            this.columnInstrucciones.Caption = "Instrucciones" ;
            this.columnInstrucciones.DefaultValue = System.Convert.DBNull ;
            this.columnInstrucciones.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnInstrucciones.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnInstrucciones.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnInstrucciones.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnInstrucciones.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnInstrucciones.ExtendedProperties.Add( "DeklaritType", "vchar") ;
            this.columnInstrucciones.ExtendedProperties.Add( "Description", "Instrucciones") ;
            this.columnInstrucciones.ExtendedProperties.Add( "Length", "5") ;
            this.columnInstrucciones.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnInstrucciones.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnInstrucciones.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnInstrucciones.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnInstrucciones.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnInstrucciones.ExtendedProperties.Add( "Deklarit.InternalName", "Instrucciones") ;
            this.Columns.Add( this.columnInstrucciones) ;
            this.columnOrden = new DataColumn( "Orden", typeof(int), "", System.Data.MappingType.Element) ;
            this.columnOrden.AllowDBNull = true ;
            this.columnOrden.Caption = "Orden" ;
            this.columnOrden.DefaultValue = System.Convert.DBNull ;
            this.columnOrden.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnOrden.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnOrden.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnOrden.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnOrden.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnOrden.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnOrden.ExtendedProperties.Add( "Description", "Orden") ;
            this.columnOrden.ExtendedProperties.Add( "Length", "5") ;
            this.columnOrden.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnOrden.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnOrden.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnOrden.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnOrden.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnOrden.ExtendedProperties.Add( "Deklarit.InternalName", "Orden") ;
            this.Columns.Add( this.columnOrden) ;
            this.columnEsOrigen = new DataColumn( "EsOrigen", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnEsOrigen.AllowDBNull = false ;
            this.columnEsOrigen.Caption = "Es Origen" ;
            this.columnEsOrigen.MaxLength = 1 ;
            this.columnEsOrigen.DefaultValue = System.Convert.DBNull ;
            this.columnEsOrigen.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnEsOrigen.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnEsOrigen.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnEsOrigen.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnEsOrigen.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnEsOrigen.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnEsOrigen.ExtendedProperties.Add( "Description", "S/N") ;
            this.columnEsOrigen.ExtendedProperties.Add( "Length", "1") ;
            this.columnEsOrigen.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnEsOrigen.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnEsOrigen.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnEsOrigen.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnEsOrigen.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnEsOrigen.ExtendedProperties.Add( "Deklarit.InternalName", "EsOrigen") ;
            this.Columns.Add( this.columnEsOrigen) ;
            this.PrimaryKey = new  DataColumn[]  {this.columnTrayectoViajeID} ;
            this.ExtendedProperties.Add( "ParentLvl", "") ;
            this.ExtendedProperties.Add( "LevelName", "TrayectoViaje") ;
            this.ExtendedProperties.Add( "Description", "TrayectoViaje") ;
            this.ExtendedProperties.Add( "msprop:AllowInsert", "true") ;
            this.ExtendedProperties.Add( "msprop:AllowUpdate", "true") ;
            this.ExtendedProperties.Add( "msprop:AllowDelete", "true") ;
            this.ExtendedProperties.Add( "Deklarit.EditInDataGrid", "True") ;
         }

         protected override void OnRowChanged( DataRowChangeEventArgs e )
         {
            base.OnRowChanged( e) ;
            if ( ( this.TrayectoViajeRowChanged != null ) )
            {
               this.TrayectoViajeRowChanged( this, new TrayectoViajeRowChangeEvent( ((TrayectoViajeRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowChanging( DataRowChangeEventArgs e )
         {
            base.OnRowChanging( e) ;
            if ( ( this.TrayectoViajeRowChanging != null ) )
            {
               this.TrayectoViajeRowChanging( this, new TrayectoViajeRowChangeEvent( ((TrayectoViajeRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowDeleted( DataRowChangeEventArgs e )
         {
            base.OnRowDeleted( e) ;
            if ( ( this.TrayectoViajeRowDeleted != null ) )
            {
               this.TrayectoViajeRowDeleted( this, new TrayectoViajeRowChangeEvent( ((TrayectoViajeRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowDeleting( DataRowChangeEventArgs e )
         {
            base.OnRowDeleting( e) ;
            if ( ( this.TrayectoViajeRowDeleting != null ) )
            {
               this.TrayectoViajeRowDeleting( this, new TrayectoViajeRowChangeEvent( ((TrayectoViajeRow)(e.Row)), e.Action)) ;
            }
         }

      }

      public class TrayectoViajeRow : DataRow
      {
         private TrayectoViajeDataTable tableTrayectoViaje ;
         internal TrayectoViajeRow( DataRowBuilder rb ) : base(rb)
         {
            this.tableTrayectoViaje = ((TrayectoViajeDataTable)(this.Table)) ;
         }

         ///  <summary>
         ///   Gets or sets the Trayecto Viaje ID.
         ///  </summary>
         public int TrayectoViajeID
         {
            get {
               return ((int)(this[this.tableTrayectoViaje.TrayectoViajeIDColumn])) ;
            }

            set {
               this[this.tableTrayectoViaje.TrayectoViajeIDColumn] = value ;
            }

         }

         public bool IsTrayectoViajeIDNull( )
         {
            return this.IsNull( this.tableTrayectoViaje.TrayectoViajeIDColumn) ;
         }

         ///  <summary>
         ///   Gets or sets the Viaje ID.
         ///  </summary>
         public long ViajeID
         {
            get {
               try
               {
                  return ((long)(this[this.tableTrayectoViaje.ViajeIDColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value ViajeID because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableTrayectoViaje.ViajeIDColumn] = value ;
            }

         }

         public bool IsViajeIDNull( )
         {
            return this.IsNull( this.tableTrayectoViaje.ViajeIDColumn) ;
         }

         public void SetViajeIDNull( )
         {
            this[this.tableTrayectoViaje.ViajeIDColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Trayecto Origen.
         ///  </summary>
         public String TrayectoOrigen
         {
            get {
               try
               {
                  return ((String)(this[this.tableTrayectoViaje.TrayectoOrigenColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value TrayectoOrigen because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableTrayectoViaje.TrayectoOrigenColumn] = value ;
            }

         }

         public bool IsTrayectoOrigenNull( )
         {
            return this.IsNull( this.tableTrayectoViaje.TrayectoOrigenColumn) ;
         }

         public void SetTrayectoOrigenNull( )
         {
            this[this.tableTrayectoViaje.TrayectoOrigenColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Trayecto Destino.
         ///  </summary>
         public String TrayectoDestino
         {
            get {
               try
               {
                  return ((String)(this[this.tableTrayectoViaje.TrayectoDestinoColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value TrayectoDestino because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableTrayectoViaje.TrayectoDestinoColumn] = value ;
            }

         }

         public bool IsTrayectoDestinoNull( )
         {
            return this.IsNull( this.tableTrayectoViaje.TrayectoDestinoColumn) ;
         }

         public void SetTrayectoDestinoNull( )
         {
            this[this.tableTrayectoViaje.TrayectoDestinoColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Tayecto Latitud Origen.
         ///  </summary>
         public decimal TayectoLatitudOrigen
         {
            get {
               try
               {
                  return ((decimal)(this[this.tableTrayectoViaje.TayectoLatitudOrigenColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value TayectoLatitudOrigen because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableTrayectoViaje.TayectoLatitudOrigenColumn] = value ;
            }

         }

         public bool IsTayectoLatitudOrigenNull( )
         {
            return this.IsNull( this.tableTrayectoViaje.TayectoLatitudOrigenColumn) ;
         }

         public void SetTayectoLatitudOrigenNull( )
         {
            this[this.tableTrayectoViaje.TayectoLatitudOrigenColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Trayecto Longitud Origen.
         ///  </summary>
         public decimal TrayectoLongitudOrigen
         {
            get {
               try
               {
                  return ((decimal)(this[this.tableTrayectoViaje.TrayectoLongitudOrigenColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value TrayectoLongitudOrigen because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableTrayectoViaje.TrayectoLongitudOrigenColumn] = value ;
            }

         }

         public bool IsTrayectoLongitudOrigenNull( )
         {
            return this.IsNull( this.tableTrayectoViaje.TrayectoLongitudOrigenColumn) ;
         }

         public void SetTrayectoLongitudOrigenNull( )
         {
            this[this.tableTrayectoViaje.TrayectoLongitudOrigenColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Trayecto Latidud Destino.
         ///  </summary>
         public decimal TrayectoLatidudDestino
         {
            get {
               try
               {
                  return ((decimal)(this[this.tableTrayectoViaje.TrayectoLatidudDestinoColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value TrayectoLatidudDestino because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableTrayectoViaje.TrayectoLatidudDestinoColumn] = value ;
            }

         }

         public bool IsTrayectoLatidudDestinoNull( )
         {
            return this.IsNull( this.tableTrayectoViaje.TrayectoLatidudDestinoColumn) ;
         }

         public void SetTrayectoLatidudDestinoNull( )
         {
            this[this.tableTrayectoViaje.TrayectoLatidudDestinoColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Trayecto Longitud Destino.
         ///  </summary>
         public decimal TrayectoLongitudDestino
         {
            get {
               try
               {
                  return ((decimal)(this[this.tableTrayectoViaje.TrayectoLongitudDestinoColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value TrayectoLongitudDestino because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableTrayectoViaje.TrayectoLongitudDestinoColumn] = value ;
            }

         }

         public bool IsTrayectoLongitudDestinoNull( )
         {
            return this.IsNull( this.tableTrayectoViaje.TrayectoLongitudDestinoColumn) ;
         }

         public void SetTrayectoLongitudDestinoNull( )
         {
            this[this.tableTrayectoViaje.TrayectoLongitudDestinoColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Trayecto Km.
         ///  </summary>
         public decimal Trayectokm
         {
            get {
               try
               {
                  return ((decimal)(this[this.tableTrayectoViaje.TrayectokmColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value Trayectokm because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableTrayectoViaje.TrayectokmColumn] = value ;
            }

         }

         public bool IsTrayectokmNull( )
         {
            return this.IsNull( this.tableTrayectoViaje.TrayectokmColumn) ;
         }

         public void SetTrayectokmNull( )
         {
            this[this.tableTrayectoViaje.TrayectokmColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Tiempo Estimado en horas.
         ///  </summary>
         public decimal TiempoEstimado
         {
            get {
               try
               {
                  return ((decimal)(this[this.tableTrayectoViaje.TiempoEstimadoColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value TiempoEstimado because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableTrayectoViaje.TiempoEstimadoColumn] = value ;
            }

         }

         public bool IsTiempoEstimadoNull( )
         {
            return this.IsNull( this.tableTrayectoViaje.TiempoEstimadoColumn) ;
         }

         public void SetTiempoEstimadoNull( )
         {
            this[this.tableTrayectoViaje.TiempoEstimadoColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Combustible Consumido en litros.
         ///  </summary>
         public decimal CombustibleConsumido
         {
            get {
               try
               {
                  return ((decimal)(this[this.tableTrayectoViaje.CombustibleConsumidoColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value CombustibleConsumido because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableTrayectoViaje.CombustibleConsumidoColumn] = value ;
            }

         }

         public bool IsCombustibleConsumidoNull( )
         {
            return this.IsNull( this.tableTrayectoViaje.CombustibleConsumidoColumn) ;
         }

         public void SetCombustibleConsumidoNull( )
         {
            this[this.tableTrayectoViaje.CombustibleConsumidoColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Estado Carretera.
         ///  </summary>
         public String EstadoCarretera
         {
            get {
               try
               {
                  return ((String)(this[this.tableTrayectoViaje.EstadoCarreteraColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value EstadoCarretera because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableTrayectoViaje.EstadoCarreteraColumn] = value ;
            }

         }

         public bool IsEstadoCarreteraNull( )
         {
            return this.IsNull( this.tableTrayectoViaje.EstadoCarreteraColumn) ;
         }

         public void SetEstadoCarreteraNull( )
         {
            this[this.tableTrayectoViaje.EstadoCarreteraColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Instrucciones.
         ///  </summary>
         public String Instrucciones
         {
            get {
               try
               {
                  return ((String)(this[this.tableTrayectoViaje.InstruccionesColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value Instrucciones because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableTrayectoViaje.InstruccionesColumn] = value ;
            }

         }

         public bool IsInstruccionesNull( )
         {
            return this.IsNull( this.tableTrayectoViaje.InstruccionesColumn) ;
         }

         public void SetInstruccionesNull( )
         {
            this[this.tableTrayectoViaje.InstruccionesColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Orden.
         ///  </summary>
         public int Orden
         {
            get {
               try
               {
                  return ((int)(this[this.tableTrayectoViaje.OrdenColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value Orden because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableTrayectoViaje.OrdenColumn] = value ;
            }

         }

         public bool IsOrdenNull( )
         {
            return this.IsNull( this.tableTrayectoViaje.OrdenColumn) ;
         }

         public void SetOrdenNull( )
         {
            this[this.tableTrayectoViaje.OrdenColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the S/N.
         ///  </summary>
         public String EsOrigen
         {
            get {
               try
               {
                  return ((String)(this[this.tableTrayectoViaje.EsOrigenColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value EsOrigen because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableTrayectoViaje.EsOrigenColumn] = value ;
            }

         }

         public bool IsEsOrigenNull( )
         {
            return this.IsNull( this.tableTrayectoViaje.EsOrigenColumn) ;
         }

         public void SetEsOrigenNull( )
         {
            this[this.tableTrayectoViaje.EsOrigenColumn] = System.Convert.DBNull ;
         }

      }

      public class TrayectoViajeRowChangeEvent : EventArgs
      {
         private TrayectoViajeRow eventRow ;
         private System.Data.DataRowAction eventAction ;
         public TrayectoViajeRowChangeEvent( TrayectoViajeRow row ,
                                             DataRowAction action )
         {
            this.eventRow = row ;
            this.eventAction = action ;
         }

         public TrayectoViajeRow Row
         {
            get {
               return this.eventRow ;
            }

         }

         public DataRowAction Action
         {
            get {
               return this.eventAction ;
            }

         }

      }

   }

}
