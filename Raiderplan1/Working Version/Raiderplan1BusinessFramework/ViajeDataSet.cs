
//               File: ViajeDataSet
//        Description: Viaje
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
   public partial class ViajeDataSet : System.Data.DataSet
   {
      private ViajeDataTable tableViaje ;
      [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
      public ViajeDataTable Viaje
      {
         get {
            return this.tableViaje ;
         }

      }

      private System.Data.SchemaSerializationMode _schemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema;
      
      [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
      public ViajeDataSet() {
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
          ViajeDataSet cln = ((ViajeDataSet)(base.Clone()));
          cln.InitVars();
          return cln;
      }
      
      protected override bool ShouldSerializeTables() {
      	    return false;
      }
      
      protected override bool ShouldSerializeRelations() {
      	    return false;
      }
      
      private bool ShouldSerializeViaje() { 
		return false; 
	  }
              
      protected override void ReadXmlSerializable(XmlReader reader) 
      {
          if ((this.DetermineSchemaSerializationMode(reader) == System.Data.SchemaSerializationMode.IncludeSchema)) 
          {
      		this.Reset();
      		DataSet ds = new DataSet();
              ds.ReadXml(reader);
              if ((ds.Tables["Viaje"] != null))  
        { 
			base.Tables.Add(new ViajeDataTable(ds.Tables["Viaje"])); 
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
          this.tableViaje = ((ViajeDataTable)(base.Tables["Viaje"]));		
		  if ((initTable == true)) { 
			if ((this.tableViaje != null)) { 
				this.tableViaje.InitVars(); 
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
          ViajeDataSet ds = new ViajeDataSet();
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
      protected ViajeDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context, false)
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
              if ((ds.Tables["Viaje"] != null))  
        { 
			base.Tables.Add(new ViajeDataTable(ds.Tables["Viaje"])); 
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
         this.ExtendedProperties.Add( "DataAdapterName", "ViajeDataAdapter") ;
         this.ExtendedProperties.Add( "BigImage", " ") ;
         this.ExtendedProperties.Add( "SmallImage", " ") ;
         this.ExtendedProperties.Add( "Image", " ") ;
         this.ExtendedProperties.Add( "Deklarit.PermissionBaseId", "2011") ;
         this.ExtendedProperties.Add( "DataSetName", "ViajeDataSet") ;
         this.ExtendedProperties.Add( "DataAdapterInterfaceName", "IViajeDataAdapter") ;
         this.ExtendedProperties.Add( "ObjectName", "Viaje") ;
         this.ExtendedProperties.Add( "ObjectDescription", "Viaje") ;
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
         this.DataSetName = "ViajeDataSet" ;
         this.Namespace = "http://www.tempuri.org/Viaje" ;
         this.tableViaje = new ViajeDataTable() ;
         this.Tables.Add( this.tableViaje) ;
      }

      public delegate  void ViajeRowChangeEventHandler( object sender ,
                                                        ViajeRowChangeEvent e );
      [Serializable()]
      public partial class ViajeDataTable : DataTable, System.Collections.IEnumerable
      {
         private DataColumn columnViajeID ;
         private DataColumn columnUsuarioID ;
         private DataColumn columnViajeNombre ;
         private DataColumn columnFechaSalidaProgramada ;
         private DataColumn columnFechaLlegadaProgramada ;
         private DataColumn columnFechaSalidaEfectiva ;
         private DataColumn columnFechaLlegadaEfectiva ;
         private DataColumn columnLugarPartida ;
         private DataColumn columnLugarllegada ;
         private DataColumn columnLongitudPartida ;
         private DataColumn columnLatitudPartida ;
         private DataColumn columnLongitudLegada ;
         private DataColumn columnLatitudLlegada ;
         private DataColumn columnkmTotalesEstimado ;
         private DataColumn columnMotocilcetaMarca ;
         private DataColumn columnMotociletaModelo ;
         private DataColumn columnViajeImagen ;
         private DataColumn columnViajeEstado ;
         public ViajeDataTable() 
         {
             this.TableName = "Viaje";
             this.BeginInit();
             this.InitClass();
             this.EndInit();
         }
         
         internal ViajeDataTable(System.Data.DataTable table) {
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
         
         public ViajeRow this[int index] {
             get {
                 return ((ViajeRow)(this.Rows[index]));
             }
         }
         
         public virtual System.Collections.IEnumerator GetEnumerator() {
             return this.Rows.GetEnumerator();
         }
         
         public override System.Data.DataTable Clone() {
             ViajeDataTable cln = ((ViajeDataTable)(base.Clone()));
             cln.InitVars();
             return cln;
         }
         
         protected override System.Data.DataTable CreateInstance() {
             return new ViajeDataTable();
         }
         
         public void AddViajeRow(ViajeRow row) {
             this.Rows.Add(row);
         }
         
         public ViajeRow NewViajeRow() {
             return ((ViajeRow)(this.NewRow()));
         }
         
         protected override System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder) {
             return new ViajeRow(builder);
         }
         
         protected override System.Type GetRowType() {
             return typeof(ViajeRow);
         }
         
         public void RemoveViajeRow(ViajeRow row) {
             this.Rows.Remove(row);
         }
         
         public static System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet xs) {
             System.Xml.Schema.XmlSchemaComplexType type = new System.Xml.Schema.XmlSchemaComplexType();
             System.Xml.Schema.XmlSchemaSequence sequence = new System.Xml.Schema.XmlSchemaSequence();
             ViajeDataSet ds = new ViajeDataSet();
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
             attribute2.FixedValue = "ViajeDataTable";
             type.Attributes.Add(attribute2);
             type.Particle = sequence;
             return type;
         }
         protected ViajeDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                 base(info, context) 
         {
             this.InitVars();
         }
         public DataColumn ViajeIDColumn
         {
            get {
               return this.columnViajeID ;
            }

         }

         public DataColumn UsuarioIDColumn
         {
            get {
               return this.columnUsuarioID ;
            }

         }

         public DataColumn ViajeNombreColumn
         {
            get {
               return this.columnViajeNombre ;
            }

         }

         public DataColumn FechaSalidaProgramadaColumn
         {
            get {
               return this.columnFechaSalidaProgramada ;
            }

         }

         public DataColumn FechaLlegadaProgramadaColumn
         {
            get {
               return this.columnFechaLlegadaProgramada ;
            }

         }

         public DataColumn FechaSalidaEfectivaColumn
         {
            get {
               return this.columnFechaSalidaEfectiva ;
            }

         }

         public DataColumn FechaLlegadaEfectivaColumn
         {
            get {
               return this.columnFechaLlegadaEfectiva ;
            }

         }

         public DataColumn LugarPartidaColumn
         {
            get {
               return this.columnLugarPartida ;
            }

         }

         public DataColumn LugarllegadaColumn
         {
            get {
               return this.columnLugarllegada ;
            }

         }

         public DataColumn LongitudPartidaColumn
         {
            get {
               return this.columnLongitudPartida ;
            }

         }

         public DataColumn LatitudPartidaColumn
         {
            get {
               return this.columnLatitudPartida ;
            }

         }

         public DataColumn LongitudLegadaColumn
         {
            get {
               return this.columnLongitudLegada ;
            }

         }

         public DataColumn LatitudLlegadaColumn
         {
            get {
               return this.columnLatitudLlegada ;
            }

         }

         public DataColumn kmTotalesEstimadoColumn
         {
            get {
               return this.columnkmTotalesEstimado ;
            }

         }

         public DataColumn MotocilcetaMarcaColumn
         {
            get {
               return this.columnMotocilcetaMarca ;
            }

         }

         public DataColumn MotociletaModeloColumn
         {
            get {
               return this.columnMotociletaModelo ;
            }

         }

         public DataColumn ViajeImagenColumn
         {
            get {
               return this.columnViajeImagen ;
            }

         }

         public DataColumn ViajeEstadoColumn
         {
            get {
               return this.columnViajeEstado ;
            }

         }

         public event ViajeRowChangeEventHandler ViajeRowChanged ;
         public event ViajeRowChangeEventHandler ViajeRowChanging ;
         public event ViajeRowChangeEventHandler ViajeRowDeleted ;
         public event ViajeRowChangeEventHandler ViajeRowDeleting ;
         public ViajeRow AddViajeRow( int usuarioID ,
                                      String viajeNombre ,
                                      DateTime fechaSalidaProgramada ,
                                      DateTime fechaLlegadaProgramada ,
                                      DateTime fechaSalidaEfectiva ,
                                      DateTime fechaLlegadaEfectiva ,
                                      String lugarPartida ,
                                      String lugarllegada ,
                                      decimal longitudPartida ,
                                      decimal latitudPartida ,
                                      decimal longitudLegada ,
                                      decimal latitudLlegada ,
                                      decimal kmTotalesEstimado ,
                                      String motocilcetaMarca ,
                                      String motociletaModelo ,
                                      String viajeImagen ,
                                      String viajeEstado )
         {
            ViajeRow rowViajeRow = ((ViajeRow)(this.NewRow())) ;
            rowViajeRow["UsuarioID"] = usuarioID ;
            rowViajeRow["ViajeNombre"] = viajeNombre ;
            rowViajeRow["FechaSalidaProgramada"] = fechaSalidaProgramada ;
            rowViajeRow["FechaLlegadaProgramada"] = fechaLlegadaProgramada ;
            rowViajeRow["FechaSalidaEfectiva"] = fechaSalidaEfectiva ;
            rowViajeRow["FechaLlegadaEfectiva"] = fechaLlegadaEfectiva ;
            rowViajeRow["LugarPartida"] = lugarPartida ;
            rowViajeRow["Lugarllegada"] = lugarllegada ;
            rowViajeRow["LongitudPartida"] = longitudPartida ;
            rowViajeRow["LatitudPartida"] = latitudPartida ;
            rowViajeRow["LongitudLegada"] = longitudLegada ;
            rowViajeRow["LatitudLlegada"] = latitudLlegada ;
            rowViajeRow["kmTotalesEstimado"] = kmTotalesEstimado ;
            rowViajeRow["MotocilcetaMarca"] = motocilcetaMarca ;
            rowViajeRow["MotociletaModelo"] = motociletaModelo ;
            rowViajeRow["ViajeImagen"] = viajeImagen ;
            rowViajeRow["ViajeEstado"] = viajeEstado ;
            this.Rows.Add( rowViajeRow) ;
            return rowViajeRow ;
         }

         public ViajeRow FindByViajeID( long viajeID )
         {
            return ((ViajeRow)(this.Rows.Find(new  object[] {viajeID}))) ;
         }

         internal void InitVars( )
         {
            this.columnViajeID = this.Columns["ViajeID"] ;
            this.columnUsuarioID = this.Columns["UsuarioID"] ;
            this.columnViajeNombre = this.Columns["ViajeNombre"] ;
            this.columnFechaSalidaProgramada = this.Columns["FechaSalidaProgramada"] ;
            this.columnFechaLlegadaProgramada = this.Columns["FechaLlegadaProgramada"] ;
            this.columnFechaSalidaEfectiva = this.Columns["FechaSalidaEfectiva"] ;
            this.columnFechaLlegadaEfectiva = this.Columns["FechaLlegadaEfectiva"] ;
            this.columnLugarPartida = this.Columns["LugarPartida"] ;
            this.columnLugarllegada = this.Columns["Lugarllegada"] ;
            this.columnLongitudPartida = this.Columns["LongitudPartida"] ;
            this.columnLatitudPartida = this.Columns["LatitudPartida"] ;
            this.columnLongitudLegada = this.Columns["LongitudLegada"] ;
            this.columnLatitudLlegada = this.Columns["LatitudLlegada"] ;
            this.columnkmTotalesEstimado = this.Columns["kmTotalesEstimado"] ;
            this.columnMotocilcetaMarca = this.Columns["MotocilcetaMarca"] ;
            this.columnMotociletaModelo = this.Columns["MotociletaModelo"] ;
            this.columnViajeImagen = this.Columns["ViajeImagen"] ;
            this.columnViajeEstado = this.Columns["ViajeEstado"] ;
         }

         public void InitClass( )
         {
            this.columnViajeID = new DataColumn( "ViajeID", typeof(long), "", System.Data.MappingType.Element) ;
            this.columnViajeID.AllowDBNull = false ;
            this.columnViajeID.Caption = "Viaje ID" ;
            this.columnViajeID.Unique = true ;
            this.columnViajeID.AutoIncrement = true ;
            this.columnViajeID.AutoIncrementSeed = -1 ;
            this.columnViajeID.AutoIncrementStep = -1 ;
            this.columnViajeID.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnViajeID.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnViajeID.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnViajeID.ExtendedProperties.Add( "AutoNumber", "true") ;
            this.columnViajeID.ExtendedProperties.Add( "IsKey", "true") ;
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
            this.columnUsuarioID = new DataColumn( "UsuarioID", typeof(int), "", System.Data.MappingType.Element) ;
            this.columnUsuarioID.AllowDBNull = false ;
            this.columnUsuarioID.Caption = "Usuario ID" ;
            this.columnUsuarioID.DefaultValue = System.Convert.DBNull ;
            this.columnUsuarioID.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnUsuarioID.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnUsuarioID.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnUsuarioID.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnUsuarioID.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnUsuarioID.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnUsuarioID.ExtendedProperties.Add( "Description", "Usuario ID") ;
            this.columnUsuarioID.ExtendedProperties.Add( "Length", "8") ;
            this.columnUsuarioID.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnUsuarioID.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnUsuarioID.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnUsuarioID.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnUsuarioID.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnUsuarioID.ExtendedProperties.Add( "Deklarit.InternalName", "UsuarioID") ;
            this.Columns.Add( this.columnUsuarioID) ;
            this.columnViajeNombre = new DataColumn( "ViajeNombre", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnViajeNombre.AllowDBNull = false ;
            this.columnViajeNombre.Caption = "Viaje Nombre" ;
            this.columnViajeNombre.MaxLength = 25 ;
            this.columnViajeNombre.DefaultValue = System.Convert.DBNull ;
            this.columnViajeNombre.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnViajeNombre.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnViajeNombre.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnViajeNombre.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnViajeNombre.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnViajeNombre.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnViajeNombre.ExtendedProperties.Add( "Description", "Viaje Nombre") ;
            this.columnViajeNombre.ExtendedProperties.Add( "Length", "25") ;
            this.columnViajeNombre.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnViajeNombre.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnViajeNombre.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnViajeNombre.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnViajeNombre.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnViajeNombre.ExtendedProperties.Add( "Deklarit.InternalName", "ViajeNombre") ;
            this.Columns.Add( this.columnViajeNombre) ;
            this.columnFechaSalidaProgramada = new DataColumn( "FechaSalidaProgramada", typeof(DateTime), "", System.Data.MappingType.Element) ;
            this.columnFechaSalidaProgramada.AllowDBNull = true ;
            this.columnFechaSalidaProgramada.Caption = "Fecha Salida" ;
            this.columnFechaSalidaProgramada.DefaultValue = System.Convert.DBNull ;
            this.columnFechaSalidaProgramada.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnFechaSalidaProgramada.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnFechaSalidaProgramada.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnFechaSalidaProgramada.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnFechaSalidaProgramada.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnFechaSalidaProgramada.ExtendedProperties.Add( "DeklaritType", "dtime") ;
            this.columnFechaSalidaProgramada.ExtendedProperties.Add( "Description", "Fecha Salida") ;
            this.columnFechaSalidaProgramada.ExtendedProperties.Add( "Length", "7") ;
            this.columnFechaSalidaProgramada.ExtendedProperties.Add( "Decimals", "5") ;
            this.columnFechaSalidaProgramada.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnFechaSalidaProgramada.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnFechaSalidaProgramada.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnFechaSalidaProgramada.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnFechaSalidaProgramada.ExtendedProperties.Add( "Deklarit.InternalName", "FechaSalidaProgramada") ;
            this.Columns.Add( this.columnFechaSalidaProgramada) ;
            this.columnFechaLlegadaProgramada = new DataColumn( "FechaLlegadaProgramada", typeof(DateTime), "", System.Data.MappingType.Element) ;
            this.columnFechaLlegadaProgramada.AllowDBNull = true ;
            this.columnFechaLlegadaProgramada.Caption = "Fecha Llegada" ;
            this.columnFechaLlegadaProgramada.DefaultValue = System.Convert.DBNull ;
            this.columnFechaLlegadaProgramada.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnFechaLlegadaProgramada.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnFechaLlegadaProgramada.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnFechaLlegadaProgramada.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnFechaLlegadaProgramada.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnFechaLlegadaProgramada.ExtendedProperties.Add( "DeklaritType", "dtime") ;
            this.columnFechaLlegadaProgramada.ExtendedProperties.Add( "Description", "Fecha Llegada") ;
            this.columnFechaLlegadaProgramada.ExtendedProperties.Add( "Length", "7") ;
            this.columnFechaLlegadaProgramada.ExtendedProperties.Add( "Decimals", "5") ;
            this.columnFechaLlegadaProgramada.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnFechaLlegadaProgramada.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnFechaLlegadaProgramada.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnFechaLlegadaProgramada.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnFechaLlegadaProgramada.ExtendedProperties.Add( "Deklarit.InternalName", "FechaLlegadaProgramada") ;
            this.Columns.Add( this.columnFechaLlegadaProgramada) ;
            this.columnFechaSalidaEfectiva = new DataColumn( "FechaSalidaEfectiva", typeof(DateTime), "", System.Data.MappingType.Element) ;
            this.columnFechaSalidaEfectiva.AllowDBNull = true ;
            this.columnFechaSalidaEfectiva.Caption = "Fecha Salida Efectiva" ;
            this.columnFechaSalidaEfectiva.DefaultValue = System.Convert.DBNull ;
            this.columnFechaSalidaEfectiva.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnFechaSalidaEfectiva.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnFechaSalidaEfectiva.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnFechaSalidaEfectiva.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnFechaSalidaEfectiva.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnFechaSalidaEfectiva.ExtendedProperties.Add( "DeklaritType", "dtime") ;
            this.columnFechaSalidaEfectiva.ExtendedProperties.Add( "Description", "Fecha Salida Efectiva") ;
            this.columnFechaSalidaEfectiva.ExtendedProperties.Add( "Length", "7") ;
            this.columnFechaSalidaEfectiva.ExtendedProperties.Add( "Decimals", "5") ;
            this.columnFechaSalidaEfectiva.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnFechaSalidaEfectiva.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnFechaSalidaEfectiva.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnFechaSalidaEfectiva.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnFechaSalidaEfectiva.ExtendedProperties.Add( "Deklarit.InternalName", "FechaSalidaEfectiva") ;
            this.Columns.Add( this.columnFechaSalidaEfectiva) ;
            this.columnFechaLlegadaEfectiva = new DataColumn( "FechaLlegadaEfectiva", typeof(DateTime), "", System.Data.MappingType.Element) ;
            this.columnFechaLlegadaEfectiva.AllowDBNull = true ;
            this.columnFechaLlegadaEfectiva.Caption = "Fecha Llegada Efectiva" ;
            this.columnFechaLlegadaEfectiva.DefaultValue = System.Convert.DBNull ;
            this.columnFechaLlegadaEfectiva.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnFechaLlegadaEfectiva.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnFechaLlegadaEfectiva.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnFechaLlegadaEfectiva.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnFechaLlegadaEfectiva.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnFechaLlegadaEfectiva.ExtendedProperties.Add( "DeklaritType", "dtime") ;
            this.columnFechaLlegadaEfectiva.ExtendedProperties.Add( "Description", "Fecha Llegada Efectiva") ;
            this.columnFechaLlegadaEfectiva.ExtendedProperties.Add( "Length", "7") ;
            this.columnFechaLlegadaEfectiva.ExtendedProperties.Add( "Decimals", "5") ;
            this.columnFechaLlegadaEfectiva.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnFechaLlegadaEfectiva.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnFechaLlegadaEfectiva.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnFechaLlegadaEfectiva.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnFechaLlegadaEfectiva.ExtendedProperties.Add( "Deklarit.InternalName", "FechaLlegadaEfectiva") ;
            this.Columns.Add( this.columnFechaLlegadaEfectiva) ;
            this.columnLugarPartida = new DataColumn( "LugarPartida", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnLugarPartida.AllowDBNull = true ;
            this.columnLugarPartida.Caption = "Lugar Partida" ;
            this.columnLugarPartida.MaxLength = 150 ;
            this.columnLugarPartida.DefaultValue = System.Convert.DBNull ;
            this.columnLugarPartida.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnLugarPartida.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnLugarPartida.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnLugarPartida.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnLugarPartida.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnLugarPartida.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnLugarPartida.ExtendedProperties.Add( "Description", "Lugar Partida") ;
            this.columnLugarPartida.ExtendedProperties.Add( "Length", "150") ;
            this.columnLugarPartida.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnLugarPartida.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnLugarPartida.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnLugarPartida.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnLugarPartida.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnLugarPartida.ExtendedProperties.Add( "Deklarit.InternalName", "LugarPartida") ;
            this.Columns.Add( this.columnLugarPartida) ;
            this.columnLugarllegada = new DataColumn( "Lugarllegada", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnLugarllegada.AllowDBNull = true ;
            this.columnLugarllegada.Caption = "Lugarllegada" ;
            this.columnLugarllegada.MaxLength = 150 ;
            this.columnLugarllegada.DefaultValue = System.Convert.DBNull ;
            this.columnLugarllegada.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnLugarllegada.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnLugarllegada.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnLugarllegada.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnLugarllegada.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnLugarllegada.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnLugarllegada.ExtendedProperties.Add( "Description", "Lugarllegada") ;
            this.columnLugarllegada.ExtendedProperties.Add( "Length", "150") ;
            this.columnLugarllegada.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnLugarllegada.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnLugarllegada.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnLugarllegada.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnLugarllegada.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnLugarllegada.ExtendedProperties.Add( "Deklarit.InternalName", "Lugarllegada") ;
            this.Columns.Add( this.columnLugarllegada) ;
            this.columnLongitudPartida = new DataColumn( "LongitudPartida", typeof(decimal), "", System.Data.MappingType.Element) ;
            this.columnLongitudPartida.AllowDBNull = true ;
            this.columnLongitudPartida.Caption = "Longitud Partida" ;
            this.columnLongitudPartida.DefaultValue = System.Convert.DBNull ;
            this.columnLongitudPartida.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnLongitudPartida.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnLongitudPartida.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnLongitudPartida.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnLongitudPartida.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnLongitudPartida.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnLongitudPartida.ExtendedProperties.Add( "Description", "Longitud Partida") ;
            this.columnLongitudPartida.ExtendedProperties.Add( "Length", "17") ;
            this.columnLongitudPartida.ExtendedProperties.Add( "Decimals", "15") ;
            this.columnLongitudPartida.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnLongitudPartida.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnLongitudPartida.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnLongitudPartida.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnLongitudPartida.ExtendedProperties.Add( "Deklarit.InternalName", "LongitudPartida") ;
            this.Columns.Add( this.columnLongitudPartida) ;
            this.columnLatitudPartida = new DataColumn( "LatitudPartida", typeof(decimal), "", System.Data.MappingType.Element) ;
            this.columnLatitudPartida.AllowDBNull = true ;
            this.columnLatitudPartida.Caption = "Latitud Partida" ;
            this.columnLatitudPartida.DefaultValue = System.Convert.DBNull ;
            this.columnLatitudPartida.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnLatitudPartida.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnLatitudPartida.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnLatitudPartida.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnLatitudPartida.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnLatitudPartida.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnLatitudPartida.ExtendedProperties.Add( "Description", "Latitud Partida") ;
            this.columnLatitudPartida.ExtendedProperties.Add( "Length", "17") ;
            this.columnLatitudPartida.ExtendedProperties.Add( "Decimals", "15") ;
            this.columnLatitudPartida.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnLatitudPartida.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnLatitudPartida.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnLatitudPartida.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnLatitudPartida.ExtendedProperties.Add( "Deklarit.InternalName", "LatitudPartida") ;
            this.Columns.Add( this.columnLatitudPartida) ;
            this.columnLongitudLegada = new DataColumn( "LongitudLegada", typeof(decimal), "", System.Data.MappingType.Element) ;
            this.columnLongitudLegada.AllowDBNull = true ;
            this.columnLongitudLegada.Caption = "Longitud Legada" ;
            this.columnLongitudLegada.DefaultValue = System.Convert.DBNull ;
            this.columnLongitudLegada.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnLongitudLegada.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnLongitudLegada.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnLongitudLegada.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnLongitudLegada.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnLongitudLegada.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnLongitudLegada.ExtendedProperties.Add( "Description", "Longitud Legada") ;
            this.columnLongitudLegada.ExtendedProperties.Add( "Length", "17") ;
            this.columnLongitudLegada.ExtendedProperties.Add( "Decimals", "15") ;
            this.columnLongitudLegada.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnLongitudLegada.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnLongitudLegada.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnLongitudLegada.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnLongitudLegada.ExtendedProperties.Add( "Deklarit.InternalName", "LongitudLegada") ;
            this.Columns.Add( this.columnLongitudLegada) ;
            this.columnLatitudLlegada = new DataColumn( "LatitudLlegada", typeof(decimal), "", System.Data.MappingType.Element) ;
            this.columnLatitudLlegada.AllowDBNull = true ;
            this.columnLatitudLlegada.Caption = "Latitud Llegada" ;
            this.columnLatitudLlegada.DefaultValue = System.Convert.DBNull ;
            this.columnLatitudLlegada.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnLatitudLlegada.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnLatitudLlegada.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnLatitudLlegada.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnLatitudLlegada.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnLatitudLlegada.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnLatitudLlegada.ExtendedProperties.Add( "Description", "Latitud Llegada") ;
            this.columnLatitudLlegada.ExtendedProperties.Add( "Length", "17") ;
            this.columnLatitudLlegada.ExtendedProperties.Add( "Decimals", "15") ;
            this.columnLatitudLlegada.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnLatitudLlegada.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnLatitudLlegada.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnLatitudLlegada.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnLatitudLlegada.ExtendedProperties.Add( "Deklarit.InternalName", "LatitudLlegada") ;
            this.Columns.Add( this.columnLatitudLlegada) ;
            this.columnkmTotalesEstimado = new DataColumn( "kmTotalesEstimado", typeof(decimal), "", System.Data.MappingType.Element) ;
            this.columnkmTotalesEstimado.AllowDBNull = true ;
            this.columnkmTotalesEstimado.Caption = "km Totales Estimado" ;
            this.columnkmTotalesEstimado.DefaultValue = System.Convert.DBNull ;
            this.columnkmTotalesEstimado.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnkmTotalesEstimado.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnkmTotalesEstimado.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnkmTotalesEstimado.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnkmTotalesEstimado.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnkmTotalesEstimado.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnkmTotalesEstimado.ExtendedProperties.Add( "Description", "km Totales Estimado") ;
            this.columnkmTotalesEstimado.ExtendedProperties.Add( "Length", "8") ;
            this.columnkmTotalesEstimado.ExtendedProperties.Add( "Decimals", "2") ;
            this.columnkmTotalesEstimado.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnkmTotalesEstimado.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnkmTotalesEstimado.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnkmTotalesEstimado.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnkmTotalesEstimado.ExtendedProperties.Add( "Deklarit.InternalName", "kmTotalesEstimado") ;
            this.Columns.Add( this.columnkmTotalesEstimado) ;
            this.columnMotocilcetaMarca = new DataColumn( "MotocilcetaMarca", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnMotocilcetaMarca.AllowDBNull = true ;
            this.columnMotocilcetaMarca.Caption = "Motocilceta" ;
            this.columnMotocilcetaMarca.MaxLength = 30 ;
            this.columnMotocilcetaMarca.DefaultValue = System.Convert.DBNull ;
            this.columnMotocilcetaMarca.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnMotocilcetaMarca.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnMotocilcetaMarca.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnMotocilcetaMarca.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnMotocilcetaMarca.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnMotocilcetaMarca.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnMotocilcetaMarca.ExtendedProperties.Add( "Description", "Motocilceta Marca") ;
            this.columnMotocilcetaMarca.ExtendedProperties.Add( "Length", "30") ;
            this.columnMotocilcetaMarca.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnMotocilcetaMarca.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnMotocilcetaMarca.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnMotocilcetaMarca.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnMotocilcetaMarca.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnMotocilcetaMarca.ExtendedProperties.Add( "Deklarit.InternalName", "MotocilcetaMarca") ;
            this.Columns.Add( this.columnMotocilcetaMarca) ;
            this.columnMotociletaModelo = new DataColumn( "MotociletaModelo", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnMotociletaModelo.AllowDBNull = true ;
            this.columnMotociletaModelo.Caption = "Motocileta" ;
            this.columnMotociletaModelo.MaxLength = 50 ;
            this.columnMotociletaModelo.DefaultValue = System.Convert.DBNull ;
            this.columnMotociletaModelo.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnMotociletaModelo.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnMotociletaModelo.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnMotociletaModelo.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnMotociletaModelo.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnMotociletaModelo.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnMotociletaModelo.ExtendedProperties.Add( "Description", "Motocileta Modelo(ej. Wave,XR,CB)") ;
            this.columnMotociletaModelo.ExtendedProperties.Add( "Length", "50") ;
            this.columnMotociletaModelo.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnMotociletaModelo.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnMotociletaModelo.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnMotociletaModelo.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnMotociletaModelo.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnMotociletaModelo.ExtendedProperties.Add( "Deklarit.InternalName", "MotociletaModelo") ;
            this.Columns.Add( this.columnMotociletaModelo) ;
            this.columnViajeImagen = new DataColumn( "ViajeImagen", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnViajeImagen.AllowDBNull = true ;
            this.columnViajeImagen.Caption = "Viaje Imagen" ;
            this.columnViajeImagen.MaxLength = 50 ;
            this.columnViajeImagen.DefaultValue = System.Convert.DBNull ;
            this.columnViajeImagen.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnViajeImagen.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnViajeImagen.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnViajeImagen.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnViajeImagen.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnViajeImagen.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnViajeImagen.ExtendedProperties.Add( "Description", "Viaje Imagen") ;
            this.columnViajeImagen.ExtendedProperties.Add( "Length", "50") ;
            this.columnViajeImagen.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnViajeImagen.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnViajeImagen.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnViajeImagen.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnViajeImagen.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnViajeImagen.ExtendedProperties.Add( "Deklarit.InternalName", "ViajeImagen") ;
            this.Columns.Add( this.columnViajeImagen) ;
            this.columnViajeEstado = new DataColumn( "ViajeEstado", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnViajeEstado.AllowDBNull = false ;
            this.columnViajeEstado.Caption = "A = Activo (Planificacion); Z =Eliminado; P =Progreso; R = Realizado" ;
            this.columnViajeEstado.MaxLength = 1 ;
            this.columnViajeEstado.DefaultValue = System.Convert.DBNull ;
            this.columnViajeEstado.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnViajeEstado.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnViajeEstado.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnViajeEstado.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnViajeEstado.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnViajeEstado.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnViajeEstado.ExtendedProperties.Add( "Description", "A = Activo (planificacion); Z =Inactivo (papelera); P = Progreso (iniciado); R = Realizado") ;
            this.columnViajeEstado.ExtendedProperties.Add( "Length", "1") ;
            this.columnViajeEstado.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnViajeEstado.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnViajeEstado.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnViajeEstado.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnViajeEstado.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnViajeEstado.ExtendedProperties.Add( "Deklarit.InternalName", "ViajeEstado") ;
            this.Columns.Add( this.columnViajeEstado) ;
            this.PrimaryKey = new  DataColumn[]  {this.columnViajeID} ;
            this.ExtendedProperties.Add( "ParentLvl", "") ;
            this.ExtendedProperties.Add( "LevelName", "Viaje") ;
            this.ExtendedProperties.Add( "Description", "Viaje") ;
            this.ExtendedProperties.Add( "msprop:AllowInsert", "true") ;
            this.ExtendedProperties.Add( "msprop:AllowUpdate", "true") ;
            this.ExtendedProperties.Add( "msprop:AllowDelete", "true") ;
            this.ExtendedProperties.Add( "Deklarit.EditInDataGrid", "True") ;
         }

         protected override void OnRowChanged( DataRowChangeEventArgs e )
         {
            base.OnRowChanged( e) ;
            if ( ( this.ViajeRowChanged != null ) )
            {
               this.ViajeRowChanged( this, new ViajeRowChangeEvent( ((ViajeRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowChanging( DataRowChangeEventArgs e )
         {
            base.OnRowChanging( e) ;
            if ( ( this.ViajeRowChanging != null ) )
            {
               this.ViajeRowChanging( this, new ViajeRowChangeEvent( ((ViajeRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowDeleted( DataRowChangeEventArgs e )
         {
            base.OnRowDeleted( e) ;
            if ( ( this.ViajeRowDeleted != null ) )
            {
               this.ViajeRowDeleted( this, new ViajeRowChangeEvent( ((ViajeRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowDeleting( DataRowChangeEventArgs e )
         {
            base.OnRowDeleting( e) ;
            if ( ( this.ViajeRowDeleting != null ) )
            {
               this.ViajeRowDeleting( this, new ViajeRowChangeEvent( ((ViajeRow)(e.Row)), e.Action)) ;
            }
         }

      }

      public class ViajeRow : DataRow
      {
         private ViajeDataTable tableViaje ;
         internal ViajeRow( DataRowBuilder rb ) : base(rb)
         {
            this.tableViaje = ((ViajeDataTable)(this.Table)) ;
         }

         ///  <summary>
         ///   Gets or sets the Viaje ID.
         ///  </summary>
         public long ViajeID
         {
            get {
               return ((long)(this[this.tableViaje.ViajeIDColumn])) ;
            }

            set {
               this[this.tableViaje.ViajeIDColumn] = value ;
            }

         }

         public bool IsViajeIDNull( )
         {
            return this.IsNull( this.tableViaje.ViajeIDColumn) ;
         }

         ///  <summary>
         ///   Gets or sets the Usuario ID.
         ///  </summary>
         public int UsuarioID
         {
            get {
               try
               {
                  return ((int)(this[this.tableViaje.UsuarioIDColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value UsuarioID because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableViaje.UsuarioIDColumn] = value ;
            }

         }

         public bool IsUsuarioIDNull( )
         {
            return this.IsNull( this.tableViaje.UsuarioIDColumn) ;
         }

         public void SetUsuarioIDNull( )
         {
            this[this.tableViaje.UsuarioIDColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Viaje Nombre.
         ///  </summary>
         public String ViajeNombre
         {
            get {
               try
               {
                  return ((String)(this[this.tableViaje.ViajeNombreColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value ViajeNombre because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableViaje.ViajeNombreColumn] = value ;
            }

         }

         public bool IsViajeNombreNull( )
         {
            return this.IsNull( this.tableViaje.ViajeNombreColumn) ;
         }

         public void SetViajeNombreNull( )
         {
            this[this.tableViaje.ViajeNombreColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Fecha Salida.
         ///  </summary>
         public DateTime FechaSalidaProgramada
         {
            get {
               try
               {
                  return ((DateTime)(this[this.tableViaje.FechaSalidaProgramadaColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value FechaSalidaProgramada because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableViaje.FechaSalidaProgramadaColumn] = value ;
            }

         }

         public bool IsFechaSalidaProgramadaNull( )
         {
            return this.IsNull( this.tableViaje.FechaSalidaProgramadaColumn) ;
         }

         public void SetFechaSalidaProgramadaNull( )
         {
            this[this.tableViaje.FechaSalidaProgramadaColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Fecha Llegada.
         ///  </summary>
         public DateTime FechaLlegadaProgramada
         {
            get {
               try
               {
                  return ((DateTime)(this[this.tableViaje.FechaLlegadaProgramadaColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value FechaLlegadaProgramada because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableViaje.FechaLlegadaProgramadaColumn] = value ;
            }

         }

         public bool IsFechaLlegadaProgramadaNull( )
         {
            return this.IsNull( this.tableViaje.FechaLlegadaProgramadaColumn) ;
         }

         public void SetFechaLlegadaProgramadaNull( )
         {
            this[this.tableViaje.FechaLlegadaProgramadaColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Fecha Salida Efectiva.
         ///  </summary>
         public DateTime FechaSalidaEfectiva
         {
            get {
               try
               {
                  return ((DateTime)(this[this.tableViaje.FechaSalidaEfectivaColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value FechaSalidaEfectiva because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableViaje.FechaSalidaEfectivaColumn] = value ;
            }

         }

         public bool IsFechaSalidaEfectivaNull( )
         {
            return this.IsNull( this.tableViaje.FechaSalidaEfectivaColumn) ;
         }

         public void SetFechaSalidaEfectivaNull( )
         {
            this[this.tableViaje.FechaSalidaEfectivaColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Fecha Llegada Efectiva.
         ///  </summary>
         public DateTime FechaLlegadaEfectiva
         {
            get {
               try
               {
                  return ((DateTime)(this[this.tableViaje.FechaLlegadaEfectivaColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value FechaLlegadaEfectiva because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableViaje.FechaLlegadaEfectivaColumn] = value ;
            }

         }

         public bool IsFechaLlegadaEfectivaNull( )
         {
            return this.IsNull( this.tableViaje.FechaLlegadaEfectivaColumn) ;
         }

         public void SetFechaLlegadaEfectivaNull( )
         {
            this[this.tableViaje.FechaLlegadaEfectivaColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Lugar Partida.
         ///  </summary>
         public String LugarPartida
         {
            get {
               try
               {
                  return ((String)(this[this.tableViaje.LugarPartidaColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value LugarPartida because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableViaje.LugarPartidaColumn] = value ;
            }

         }

         public bool IsLugarPartidaNull( )
         {
            return this.IsNull( this.tableViaje.LugarPartidaColumn) ;
         }

         public void SetLugarPartidaNull( )
         {
            this[this.tableViaje.LugarPartidaColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Lugarllegada.
         ///  </summary>
         public String Lugarllegada
         {
            get {
               try
               {
                  return ((String)(this[this.tableViaje.LugarllegadaColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value Lugarllegada because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableViaje.LugarllegadaColumn] = value ;
            }

         }

         public bool IsLugarllegadaNull( )
         {
            return this.IsNull( this.tableViaje.LugarllegadaColumn) ;
         }

         public void SetLugarllegadaNull( )
         {
            this[this.tableViaje.LugarllegadaColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Longitud Partida.
         ///  </summary>
         public decimal LongitudPartida
         {
            get {
               try
               {
                  return ((decimal)(this[this.tableViaje.LongitudPartidaColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value LongitudPartida because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableViaje.LongitudPartidaColumn] = value ;
            }

         }

         public bool IsLongitudPartidaNull( )
         {
            return this.IsNull( this.tableViaje.LongitudPartidaColumn) ;
         }

         public void SetLongitudPartidaNull( )
         {
            this[this.tableViaje.LongitudPartidaColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Latitud Partida.
         ///  </summary>
         public decimal LatitudPartida
         {
            get {
               try
               {
                  return ((decimal)(this[this.tableViaje.LatitudPartidaColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value LatitudPartida because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableViaje.LatitudPartidaColumn] = value ;
            }

         }

         public bool IsLatitudPartidaNull( )
         {
            return this.IsNull( this.tableViaje.LatitudPartidaColumn) ;
         }

         public void SetLatitudPartidaNull( )
         {
            this[this.tableViaje.LatitudPartidaColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Longitud Legada.
         ///  </summary>
         public decimal LongitudLegada
         {
            get {
               try
               {
                  return ((decimal)(this[this.tableViaje.LongitudLegadaColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value LongitudLegada because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableViaje.LongitudLegadaColumn] = value ;
            }

         }

         public bool IsLongitudLegadaNull( )
         {
            return this.IsNull( this.tableViaje.LongitudLegadaColumn) ;
         }

         public void SetLongitudLegadaNull( )
         {
            this[this.tableViaje.LongitudLegadaColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Latitud Llegada.
         ///  </summary>
         public decimal LatitudLlegada
         {
            get {
               try
               {
                  return ((decimal)(this[this.tableViaje.LatitudLlegadaColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value LatitudLlegada because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableViaje.LatitudLlegadaColumn] = value ;
            }

         }

         public bool IsLatitudLlegadaNull( )
         {
            return this.IsNull( this.tableViaje.LatitudLlegadaColumn) ;
         }

         public void SetLatitudLlegadaNull( )
         {
            this[this.tableViaje.LatitudLlegadaColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the km Totales Estimado.
         ///  </summary>
         public decimal kmTotalesEstimado
         {
            get {
               try
               {
                  return ((decimal)(this[this.tableViaje.kmTotalesEstimadoColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value kmTotalesEstimado because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableViaje.kmTotalesEstimadoColumn] = value ;
            }

         }

         public bool IskmTotalesEstimadoNull( )
         {
            return this.IsNull( this.tableViaje.kmTotalesEstimadoColumn) ;
         }

         public void SetkmTotalesEstimadoNull( )
         {
            this[this.tableViaje.kmTotalesEstimadoColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Motocilceta Marca.
         ///  </summary>
         public String MotocilcetaMarca
         {
            get {
               try
               {
                  return ((String)(this[this.tableViaje.MotocilcetaMarcaColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value MotocilcetaMarca because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableViaje.MotocilcetaMarcaColumn] = value ;
            }

         }

         public bool IsMotocilcetaMarcaNull( )
         {
            return this.IsNull( this.tableViaje.MotocilcetaMarcaColumn) ;
         }

         public void SetMotocilcetaMarcaNull( )
         {
            this[this.tableViaje.MotocilcetaMarcaColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Motocileta Modelo(ej. Wave,XR,CB).
         ///  </summary>
         public String MotociletaModelo
         {
            get {
               try
               {
                  return ((String)(this[this.tableViaje.MotociletaModeloColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value MotociletaModelo because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableViaje.MotociletaModeloColumn] = value ;
            }

         }

         public bool IsMotociletaModeloNull( )
         {
            return this.IsNull( this.tableViaje.MotociletaModeloColumn) ;
         }

         public void SetMotociletaModeloNull( )
         {
            this[this.tableViaje.MotociletaModeloColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Viaje Imagen.
         ///  </summary>
         public String ViajeImagen
         {
            get {
               try
               {
                  return ((String)(this[this.tableViaje.ViajeImagenColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value ViajeImagen because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableViaje.ViajeImagenColumn] = value ;
            }

         }

         public bool IsViajeImagenNull( )
         {
            return this.IsNull( this.tableViaje.ViajeImagenColumn) ;
         }

         public void SetViajeImagenNull( )
         {
            this[this.tableViaje.ViajeImagenColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the A = Activo (planificacion); Z =Inactivo (papelera); P = Progreso
         ///    (iniciado); R = Realizado.
         ///  </summary>
         public String ViajeEstado
         {
            get {
               try
               {
                  return ((String)(this[this.tableViaje.ViajeEstadoColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value ViajeEstado because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableViaje.ViajeEstadoColumn] = value ;
            }

         }

         public bool IsViajeEstadoNull( )
         {
            return this.IsNull( this.tableViaje.ViajeEstadoColumn) ;
         }

         public void SetViajeEstadoNull( )
         {
            this[this.tableViaje.ViajeEstadoColumn] = System.Convert.DBNull ;
         }

      }

      public class ViajeRowChangeEvent : EventArgs
      {
         private ViajeRow eventRow ;
         private System.Data.DataRowAction eventAction ;
         public ViajeRowChangeEvent( ViajeRow row ,
                                     DataRowAction action )
         {
            this.eventRow = row ;
            this.eventAction = action ;
         }

         public ViajeRow Row
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
