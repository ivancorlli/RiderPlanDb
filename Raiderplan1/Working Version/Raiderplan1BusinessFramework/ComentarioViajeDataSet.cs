
//               File: ComentarioViajeDataSet
//        Description: ComentarioViaje
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
   public partial class ComentarioViajeDataSet : System.Data.DataSet
   {
      private ComentarioViajeDataTable tableComentarioViaje ;
      [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
      public ComentarioViajeDataTable ComentarioViaje
      {
         get {
            return this.tableComentarioViaje ;
         }

      }

      private System.Data.SchemaSerializationMode _schemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema;
      
      [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
      public ComentarioViajeDataSet() {
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
          ComentarioViajeDataSet cln = ((ComentarioViajeDataSet)(base.Clone()));
          cln.InitVars();
          return cln;
      }
      
      protected override bool ShouldSerializeTables() {
      	    return false;
      }
      
      protected override bool ShouldSerializeRelations() {
      	    return false;
      }
      
      private bool ShouldSerializeComentarioViaje() { 
		return false; 
	  }
              
      protected override void ReadXmlSerializable(XmlReader reader) 
      {
          if ((this.DetermineSchemaSerializationMode(reader) == System.Data.SchemaSerializationMode.IncludeSchema)) 
          {
      		this.Reset();
      		DataSet ds = new DataSet();
              ds.ReadXml(reader);
              if ((ds.Tables["ComentarioViaje"] != null))  
        { 
			base.Tables.Add(new ComentarioViajeDataTable(ds.Tables["ComentarioViaje"])); 
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
          this.tableComentarioViaje = ((ComentarioViajeDataTable)(base.Tables["ComentarioViaje"]));		
		  if ((initTable == true)) { 
			if ((this.tableComentarioViaje != null)) { 
				this.tableComentarioViaje.InitVars(); 
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
          ComentarioViajeDataSet ds = new ComentarioViajeDataSet();
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
      protected ComentarioViajeDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context, false)
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
              if ((ds.Tables["ComentarioViaje"] != null))  
        { 
			base.Tables.Add(new ComentarioViajeDataTable(ds.Tables["ComentarioViaje"])); 
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
         this.ExtendedProperties.Add( "DataAdapterName", "ComentarioViajeDataAdapter") ;
         this.ExtendedProperties.Add( "BigImage", " ") ;
         this.ExtendedProperties.Add( "SmallImage", " ") ;
         this.ExtendedProperties.Add( "Image", " ") ;
         this.ExtendedProperties.Add( "Deklarit.PermissionBaseId", "2020") ;
         this.ExtendedProperties.Add( "DataSetName", "ComentarioViajeDataSet") ;
         this.ExtendedProperties.Add( "DataAdapterInterfaceName", "IComentarioViajeDataAdapter") ;
         this.ExtendedProperties.Add( "ObjectName", "ComentarioViaje") ;
         this.ExtendedProperties.Add( "ObjectDescription", "ComentarioViaje") ;
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
         this.DataSetName = "ComentarioViajeDataSet" ;
         this.Namespace = "http://www.tempuri.org/ComentarioViaje" ;
         this.tableComentarioViaje = new ComentarioViajeDataTable() ;
         this.Tables.Add( this.tableComentarioViaje) ;
      }

      public delegate  void ComentarioViajeRowChangeEventHandler( object sender ,
                                                                  ComentarioViajeRowChangeEvent e );
      [Serializable()]
      public partial class ComentarioViajeDataTable : DataTable, System.Collections.IEnumerable
      {
         private DataColumn columnComentarioViajeID ;
         private DataColumn columnComentarioLatitud ;
         private DataColumn columnComentarioLongitud ;
         private DataColumn columnComentarioTexto ;
         private DataColumn columnComentarioImagen ;
         private DataColumn columnCVTrayectoID ;
         private DataColumn columnViajeID ;
         public ComentarioViajeDataTable() 
         {
             this.TableName = "ComentarioViaje";
             this.BeginInit();
             this.InitClass();
             this.EndInit();
         }
         
         internal ComentarioViajeDataTable(System.Data.DataTable table) {
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
         
         public ComentarioViajeRow this[int index] {
             get {
                 return ((ComentarioViajeRow)(this.Rows[index]));
             }
         }
         
         public virtual System.Collections.IEnumerator GetEnumerator() {
             return this.Rows.GetEnumerator();
         }
         
         public override System.Data.DataTable Clone() {
             ComentarioViajeDataTable cln = ((ComentarioViajeDataTable)(base.Clone()));
             cln.InitVars();
             return cln;
         }
         
         protected override System.Data.DataTable CreateInstance() {
             return new ComentarioViajeDataTable();
         }
         
         public void AddComentarioViajeRow(ComentarioViajeRow row) {
             this.Rows.Add(row);
         }
         
         public ComentarioViajeRow NewComentarioViajeRow() {
             return ((ComentarioViajeRow)(this.NewRow()));
         }
         
         protected override System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder) {
             return new ComentarioViajeRow(builder);
         }
         
         protected override System.Type GetRowType() {
             return typeof(ComentarioViajeRow);
         }
         
         public void RemoveComentarioViajeRow(ComentarioViajeRow row) {
             this.Rows.Remove(row);
         }
         
         public static System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet xs) {
             System.Xml.Schema.XmlSchemaComplexType type = new System.Xml.Schema.XmlSchemaComplexType();
             System.Xml.Schema.XmlSchemaSequence sequence = new System.Xml.Schema.XmlSchemaSequence();
             ComentarioViajeDataSet ds = new ComentarioViajeDataSet();
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
             attribute2.FixedValue = "ComentarioViajeDataTable";
             type.Attributes.Add(attribute2);
             type.Particle = sequence;
             return type;
         }
         protected ComentarioViajeDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                 base(info, context) 
         {
             this.InitVars();
         }
         public DataColumn ComentarioViajeIDColumn
         {
            get {
               return this.columnComentarioViajeID ;
            }

         }

         public DataColumn ComentarioLatitudColumn
         {
            get {
               return this.columnComentarioLatitud ;
            }

         }

         public DataColumn ComentarioLongitudColumn
         {
            get {
               return this.columnComentarioLongitud ;
            }

         }

         public DataColumn ComentarioTextoColumn
         {
            get {
               return this.columnComentarioTexto ;
            }

         }

         public DataColumn ComentarioImagenColumn
         {
            get {
               return this.columnComentarioImagen ;
            }

         }

         public DataColumn CVTrayectoIDColumn
         {
            get {
               return this.columnCVTrayectoID ;
            }

         }

         public DataColumn ViajeIDColumn
         {
            get {
               return this.columnViajeID ;
            }

         }

         public event ComentarioViajeRowChangeEventHandler ComentarioViajeRowChanged ;
         public event ComentarioViajeRowChangeEventHandler ComentarioViajeRowChanging ;
         public event ComentarioViajeRowChangeEventHandler ComentarioViajeRowDeleted ;
         public event ComentarioViajeRowChangeEventHandler ComentarioViajeRowDeleting ;
         public ComentarioViajeRow AddComentarioViajeRow( decimal comentarioLatitud ,
                                                          decimal comentarioLongitud ,
                                                          String comentarioTexto ,
                                                          String comentarioImagen ,
                                                          int cVTrayectoID ,
                                                          long viajeID )
         {
            ComentarioViajeRow rowComentarioViajeRow = ((ComentarioViajeRow)(this.NewRow())) ;
            rowComentarioViajeRow["ComentarioLatitud"] = comentarioLatitud ;
            rowComentarioViajeRow["ComentarioLongitud"] = comentarioLongitud ;
            rowComentarioViajeRow["ComentarioTexto"] = comentarioTexto ;
            rowComentarioViajeRow["ComentarioImagen"] = comentarioImagen ;
            rowComentarioViajeRow["CVTrayectoID"] = cVTrayectoID ;
            rowComentarioViajeRow["ViajeID"] = viajeID ;
            this.Rows.Add( rowComentarioViajeRow) ;
            return rowComentarioViajeRow ;
         }

         public ComentarioViajeRow FindByComentarioViajeID( int comentarioViajeID )
         {
            return ((ComentarioViajeRow)(this.Rows.Find(new  object[] {comentarioViajeID}))) ;
         }

         internal void InitVars( )
         {
            this.columnComentarioViajeID = this.Columns["ComentarioViajeID"] ;
            this.columnComentarioLatitud = this.Columns["ComentarioLatitud"] ;
            this.columnComentarioLongitud = this.Columns["ComentarioLongitud"] ;
            this.columnComentarioTexto = this.Columns["ComentarioTexto"] ;
            this.columnComentarioImagen = this.Columns["ComentarioImagen"] ;
            this.columnCVTrayectoID = this.Columns["CVTrayectoID"] ;
            this.columnViajeID = this.Columns["ViajeID"] ;
         }

         public void InitClass( )
         {
            this.columnComentarioViajeID = new DataColumn( "ComentarioViajeID", typeof(int), "", System.Data.MappingType.Element) ;
            this.columnComentarioViajeID.AllowDBNull = false ;
            this.columnComentarioViajeID.Caption = "Comentario Viaje ID" ;
            this.columnComentarioViajeID.Unique = true ;
            this.columnComentarioViajeID.AutoIncrement = true ;
            this.columnComentarioViajeID.AutoIncrementSeed = -1 ;
            this.columnComentarioViajeID.AutoIncrementStep = -1 ;
            this.columnComentarioViajeID.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnComentarioViajeID.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnComentarioViajeID.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnComentarioViajeID.ExtendedProperties.Add( "AutoNumber", "true") ;
            this.columnComentarioViajeID.ExtendedProperties.Add( "IsKey", "true") ;
            this.columnComentarioViajeID.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnComentarioViajeID.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnComentarioViajeID.ExtendedProperties.Add( "Description", "Comentario Viaje ID") ;
            this.columnComentarioViajeID.ExtendedProperties.Add( "Length", "8") ;
            this.columnComentarioViajeID.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnComentarioViajeID.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnComentarioViajeID.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnComentarioViajeID.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnComentarioViajeID.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnComentarioViajeID.ExtendedProperties.Add( "Deklarit.InternalName", "ComentarioViajeID") ;
            this.Columns.Add( this.columnComentarioViajeID) ;
            this.columnComentarioLatitud = new DataColumn( "ComentarioLatitud", typeof(decimal), "", System.Data.MappingType.Element) ;
            this.columnComentarioLatitud.AllowDBNull = false ;
            this.columnComentarioLatitud.Caption = "Comentario Latitud" ;
            this.columnComentarioLatitud.DefaultValue = System.Convert.DBNull ;
            this.columnComentarioLatitud.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnComentarioLatitud.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnComentarioLatitud.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnComentarioLatitud.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnComentarioLatitud.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnComentarioLatitud.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnComentarioLatitud.ExtendedProperties.Add( "Description", "Comentario Latitud") ;
            this.columnComentarioLatitud.ExtendedProperties.Add( "Length", "17") ;
            this.columnComentarioLatitud.ExtendedProperties.Add( "Decimals", "5") ;
            this.columnComentarioLatitud.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnComentarioLatitud.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnComentarioLatitud.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnComentarioLatitud.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnComentarioLatitud.ExtendedProperties.Add( "Deklarit.InternalName", "ComentarioLatitud") ;
            this.Columns.Add( this.columnComentarioLatitud) ;
            this.columnComentarioLongitud = new DataColumn( "ComentarioLongitud", typeof(decimal), "", System.Data.MappingType.Element) ;
            this.columnComentarioLongitud.AllowDBNull = false ;
            this.columnComentarioLongitud.Caption = "Comentario Longitud" ;
            this.columnComentarioLongitud.DefaultValue = System.Convert.DBNull ;
            this.columnComentarioLongitud.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnComentarioLongitud.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnComentarioLongitud.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnComentarioLongitud.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnComentarioLongitud.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnComentarioLongitud.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnComentarioLongitud.ExtendedProperties.Add( "Description", "Comentario Longitud") ;
            this.columnComentarioLongitud.ExtendedProperties.Add( "Length", "17") ;
            this.columnComentarioLongitud.ExtendedProperties.Add( "Decimals", "5") ;
            this.columnComentarioLongitud.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnComentarioLongitud.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnComentarioLongitud.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnComentarioLongitud.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnComentarioLongitud.ExtendedProperties.Add( "Deklarit.InternalName", "ComentarioLongitud") ;
            this.Columns.Add( this.columnComentarioLongitud) ;
            this.columnComentarioTexto = new DataColumn( "ComentarioTexto", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnComentarioTexto.AllowDBNull = false ;
            this.columnComentarioTexto.Caption = "Comentario Texto" ;
            this.columnComentarioTexto.MaxLength = 250 ;
            this.columnComentarioTexto.DefaultValue = System.Convert.DBNull ;
            this.columnComentarioTexto.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnComentarioTexto.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnComentarioTexto.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnComentarioTexto.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnComentarioTexto.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnComentarioTexto.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnComentarioTexto.ExtendedProperties.Add( "Description", "Comentario Texto") ;
            this.columnComentarioTexto.ExtendedProperties.Add( "Length", "250") ;
            this.columnComentarioTexto.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnComentarioTexto.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnComentarioTexto.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnComentarioTexto.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnComentarioTexto.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnComentarioTexto.ExtendedProperties.Add( "Deklarit.InternalName", "ComentarioTexto") ;
            this.Columns.Add( this.columnComentarioTexto) ;
            this.columnComentarioImagen = new DataColumn( "ComentarioImagen", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnComentarioImagen.AllowDBNull = true ;
            this.columnComentarioImagen.Caption = "Comentario Imagen" ;
            this.columnComentarioImagen.MaxLength = 250 ;
            this.columnComentarioImagen.DefaultValue = System.Convert.DBNull ;
            this.columnComentarioImagen.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnComentarioImagen.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnComentarioImagen.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnComentarioImagen.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnComentarioImagen.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnComentarioImagen.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnComentarioImagen.ExtendedProperties.Add( "Description", "Comentario Imagen") ;
            this.columnComentarioImagen.ExtendedProperties.Add( "Length", "250") ;
            this.columnComentarioImagen.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnComentarioImagen.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnComentarioImagen.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnComentarioImagen.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnComentarioImagen.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnComentarioImagen.ExtendedProperties.Add( "Deklarit.InternalName", "ComentarioImagen") ;
            this.Columns.Add( this.columnComentarioImagen) ;
            this.columnCVTrayectoID = new DataColumn( "CVTrayectoID", typeof(int), "", System.Data.MappingType.Element) ;
            this.columnCVTrayectoID.AllowDBNull = true ;
            this.columnCVTrayectoID.Caption = "CV Trayecto ID" ;
            this.columnCVTrayectoID.DefaultValue = System.Convert.DBNull ;
            this.columnCVTrayectoID.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnCVTrayectoID.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnCVTrayectoID.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnCVTrayectoID.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnCVTrayectoID.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnCVTrayectoID.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnCVTrayectoID.ExtendedProperties.Add( "Description", "Trayecto Viaje ID") ;
            this.columnCVTrayectoID.ExtendedProperties.Add( "Length", "5") ;
            this.columnCVTrayectoID.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnCVTrayectoID.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnCVTrayectoID.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnCVTrayectoID.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnCVTrayectoID.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnCVTrayectoID.ExtendedProperties.Add( "Deklarit.InternalName", "CVTrayectoID") ;
            this.Columns.Add( this.columnCVTrayectoID) ;
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
            this.PrimaryKey = new  DataColumn[]  {this.columnComentarioViajeID} ;
            this.ExtendedProperties.Add( "ParentLvl", "") ;
            this.ExtendedProperties.Add( "LevelName", "ComentarioViaje") ;
            this.ExtendedProperties.Add( "Description", "ComentarioViaje") ;
            this.ExtendedProperties.Add( "msprop:AllowInsert", "true") ;
            this.ExtendedProperties.Add( "msprop:AllowUpdate", "true") ;
            this.ExtendedProperties.Add( "msprop:AllowDelete", "true") ;
            this.ExtendedProperties.Add( "Deklarit.EditInDataGrid", "True") ;
         }

         protected override void OnRowChanged( DataRowChangeEventArgs e )
         {
            base.OnRowChanged( e) ;
            if ( ( this.ComentarioViajeRowChanged != null ) )
            {
               this.ComentarioViajeRowChanged( this, new ComentarioViajeRowChangeEvent( ((ComentarioViajeRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowChanging( DataRowChangeEventArgs e )
         {
            base.OnRowChanging( e) ;
            if ( ( this.ComentarioViajeRowChanging != null ) )
            {
               this.ComentarioViajeRowChanging( this, new ComentarioViajeRowChangeEvent( ((ComentarioViajeRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowDeleted( DataRowChangeEventArgs e )
         {
            base.OnRowDeleted( e) ;
            if ( ( this.ComentarioViajeRowDeleted != null ) )
            {
               this.ComentarioViajeRowDeleted( this, new ComentarioViajeRowChangeEvent( ((ComentarioViajeRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowDeleting( DataRowChangeEventArgs e )
         {
            base.OnRowDeleting( e) ;
            if ( ( this.ComentarioViajeRowDeleting != null ) )
            {
               this.ComentarioViajeRowDeleting( this, new ComentarioViajeRowChangeEvent( ((ComentarioViajeRow)(e.Row)), e.Action)) ;
            }
         }

      }

      public class ComentarioViajeRow : DataRow
      {
         private ComentarioViajeDataTable tableComentarioViaje ;
         internal ComentarioViajeRow( DataRowBuilder rb ) : base(rb)
         {
            this.tableComentarioViaje = ((ComentarioViajeDataTable)(this.Table)) ;
         }

         ///  <summary>
         ///   Gets or sets the Comentario Viaje ID.
         ///  </summary>
         public int ComentarioViajeID
         {
            get {
               return ((int)(this[this.tableComentarioViaje.ComentarioViajeIDColumn])) ;
            }

            set {
               this[this.tableComentarioViaje.ComentarioViajeIDColumn] = value ;
            }

         }

         public bool IsComentarioViajeIDNull( )
         {
            return this.IsNull( this.tableComentarioViaje.ComentarioViajeIDColumn) ;
         }

         ///  <summary>
         ///   Gets or sets the Comentario Latitud.
         ///  </summary>
         public decimal ComentarioLatitud
         {
            get {
               try
               {
                  return ((decimal)(this[this.tableComentarioViaje.ComentarioLatitudColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value ComentarioLatitud because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableComentarioViaje.ComentarioLatitudColumn] = value ;
            }

         }

         public bool IsComentarioLatitudNull( )
         {
            return this.IsNull( this.tableComentarioViaje.ComentarioLatitudColumn) ;
         }

         public void SetComentarioLatitudNull( )
         {
            this[this.tableComentarioViaje.ComentarioLatitudColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Comentario Longitud.
         ///  </summary>
         public decimal ComentarioLongitud
         {
            get {
               try
               {
                  return ((decimal)(this[this.tableComentarioViaje.ComentarioLongitudColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value ComentarioLongitud because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableComentarioViaje.ComentarioLongitudColumn] = value ;
            }

         }

         public bool IsComentarioLongitudNull( )
         {
            return this.IsNull( this.tableComentarioViaje.ComentarioLongitudColumn) ;
         }

         public void SetComentarioLongitudNull( )
         {
            this[this.tableComentarioViaje.ComentarioLongitudColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Comentario Texto.
         ///  </summary>
         public String ComentarioTexto
         {
            get {
               try
               {
                  return ((String)(this[this.tableComentarioViaje.ComentarioTextoColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value ComentarioTexto because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableComentarioViaje.ComentarioTextoColumn] = value ;
            }

         }

         public bool IsComentarioTextoNull( )
         {
            return this.IsNull( this.tableComentarioViaje.ComentarioTextoColumn) ;
         }

         public void SetComentarioTextoNull( )
         {
            this[this.tableComentarioViaje.ComentarioTextoColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Comentario Imagen.
         ///  </summary>
         public String ComentarioImagen
         {
            get {
               try
               {
                  return ((String)(this[this.tableComentarioViaje.ComentarioImagenColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value ComentarioImagen because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableComentarioViaje.ComentarioImagenColumn] = value ;
            }

         }

         public bool IsComentarioImagenNull( )
         {
            return this.IsNull( this.tableComentarioViaje.ComentarioImagenColumn) ;
         }

         public void SetComentarioImagenNull( )
         {
            this[this.tableComentarioViaje.ComentarioImagenColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Trayecto Viaje ID.
         ///  </summary>
         public int CVTrayectoID
         {
            get {
               try
               {
                  return ((int)(this[this.tableComentarioViaje.CVTrayectoIDColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value CVTrayectoID because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableComentarioViaje.CVTrayectoIDColumn] = value ;
            }

         }

         public bool IsCVTrayectoIDNull( )
         {
            return this.IsNull( this.tableComentarioViaje.CVTrayectoIDColumn) ;
         }

         public void SetCVTrayectoIDNull( )
         {
            this[this.tableComentarioViaje.CVTrayectoIDColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Viaje ID.
         ///  </summary>
         public long ViajeID
         {
            get {
               try
               {
                  return ((long)(this[this.tableComentarioViaje.ViajeIDColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value ViajeID because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableComentarioViaje.ViajeIDColumn] = value ;
            }

         }

         public bool IsViajeIDNull( )
         {
            return this.IsNull( this.tableComentarioViaje.ViajeIDColumn) ;
         }

         public void SetViajeIDNull( )
         {
            this[this.tableComentarioViaje.ViajeIDColumn] = System.Convert.DBNull ;
         }

      }

      public class ComentarioViajeRowChangeEvent : EventArgs
      {
         private ComentarioViajeRow eventRow ;
         private System.Data.DataRowAction eventAction ;
         public ComentarioViajeRowChangeEvent( ComentarioViajeRow row ,
                                               DataRowAction action )
         {
            this.eventRow = row ;
            this.eventAction = action ;
         }

         public ComentarioViajeRow Row
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
