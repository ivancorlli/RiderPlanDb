
//               File: LocalidadDataSet
//        Description: Localidad
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
   public partial class LocalidadDataSet : System.Data.DataSet
   {
      private LocalidadDataTable tableLocalidad ;
      [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
      public LocalidadDataTable Localidad
      {
         get {
            return this.tableLocalidad ;
         }

      }

      private System.Data.SchemaSerializationMode _schemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema;
      
      [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
      public LocalidadDataSet() {
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
          LocalidadDataSet cln = ((LocalidadDataSet)(base.Clone()));
          cln.InitVars();
          return cln;
      }
      
      protected override bool ShouldSerializeTables() {
      	    return false;
      }
      
      protected override bool ShouldSerializeRelations() {
      	    return false;
      }
      
      private bool ShouldSerializeLocalidad() { 
		return false; 
	  }
              
      protected override void ReadXmlSerializable(XmlReader reader) 
      {
          if ((this.DetermineSchemaSerializationMode(reader) == System.Data.SchemaSerializationMode.IncludeSchema)) 
          {
      		this.Reset();
      		DataSet ds = new DataSet();
              ds.ReadXml(reader);
              if ((ds.Tables["Localidad"] != null))  
        { 
			base.Tables.Add(new LocalidadDataTable(ds.Tables["Localidad"])); 
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
          this.tableLocalidad = ((LocalidadDataTable)(base.Tables["Localidad"]));		
		  if ((initTable == true)) { 
			if ((this.tableLocalidad != null)) { 
				this.tableLocalidad.InitVars(); 
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
          LocalidadDataSet ds = new LocalidadDataSet();
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
      protected LocalidadDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context, false)
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
              if ((ds.Tables["Localidad"] != null))  
        { 
			base.Tables.Add(new LocalidadDataTable(ds.Tables["Localidad"])); 
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
         this.ExtendedProperties.Add( "DataAdapterName", "LocalidadDataAdapter") ;
         this.ExtendedProperties.Add( "BigImage", " ") ;
         this.ExtendedProperties.Add( "SmallImage", " ") ;
         this.ExtendedProperties.Add( "Image", " ") ;
         this.ExtendedProperties.Add( "Deklarit.PermissionBaseId", "2005") ;
         this.ExtendedProperties.Add( "DataSetName", "LocalidadDataSet") ;
         this.ExtendedProperties.Add( "DataAdapterInterfaceName", "ILocalidadDataAdapter") ;
         this.ExtendedProperties.Add( "ObjectName", "Localidad") ;
         this.ExtendedProperties.Add( "ObjectDescription", "Localidad") ;
         this.ExtendedProperties.Add( "ObjectType", "BusinessComponent") ;
         this.ExtendedProperties.Add( "ObjectPath", "\\BusinessComponents\\Geografia") ;
         this.ExtendedProperties.Add( "NameSpace", "Raiderplan1") ;
         this.ExtendedProperties.Add( "DataChangeFrequency", "PrettyOften") ;
         this.ExtendedProperties.Add( "CachePriority", "Medium") ;
         this.ExtendedProperties.Add( "Deklarit.AddNewOptionToLowCardinality", "True") ;
         this.ExtendedProperties.Add( "Deklarit.DescriptionAttribute", "") ;
         this.ExtendedProperties.Add( "Deklarit.LowCardinality", "False") ;
      }

      private void InitClassBase( )
      {
         this.DataSetName = "LocalidadDataSet" ;
         this.Namespace = "http://www.tempuri.org/Localidad" ;
         this.tableLocalidad = new LocalidadDataTable() ;
         this.Tables.Add( this.tableLocalidad) ;
      }

      public delegate  void LocalidadRowChangeEventHandler( object sender ,
                                                            LocalidadRowChangeEvent e );
      [Serializable()]
      public partial class LocalidadDataTable : DataTable, System.Collections.IEnumerable
      {
         private DataColumn columnLoacaliadID ;
         private DataColumn columnLocalidadNombre ;
         private DataColumn columnLocalidadCodPos ;
         private DataColumn columnProvinciaID ;
         private DataColumn columnProvinciaNombre ;
         public LocalidadDataTable() 
         {
             this.TableName = "Localidad";
             this.BeginInit();
             this.InitClass();
             this.EndInit();
         }
         
         internal LocalidadDataTable(System.Data.DataTable table) {
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
         
         public LocalidadRow this[int index] {
             get {
                 return ((LocalidadRow)(this.Rows[index]));
             }
         }
         
         public virtual System.Collections.IEnumerator GetEnumerator() {
             return this.Rows.GetEnumerator();
         }
         
         public override System.Data.DataTable Clone() {
             LocalidadDataTable cln = ((LocalidadDataTable)(base.Clone()));
             cln.InitVars();
             return cln;
         }
         
         protected override System.Data.DataTable CreateInstance() {
             return new LocalidadDataTable();
         }
         
         public void AddLocalidadRow(LocalidadRow row) {
             this.Rows.Add(row);
         }
         
         public LocalidadRow NewLocalidadRow() {
             return ((LocalidadRow)(this.NewRow()));
         }
         
         protected override System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder) {
             return new LocalidadRow(builder);
         }
         
         protected override System.Type GetRowType() {
             return typeof(LocalidadRow);
         }
         
         public void RemoveLocalidadRow(LocalidadRow row) {
             this.Rows.Remove(row);
         }
         
         public static System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet xs) {
             System.Xml.Schema.XmlSchemaComplexType type = new System.Xml.Schema.XmlSchemaComplexType();
             System.Xml.Schema.XmlSchemaSequence sequence = new System.Xml.Schema.XmlSchemaSequence();
             LocalidadDataSet ds = new LocalidadDataSet();
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
             attribute2.FixedValue = "LocalidadDataTable";
             type.Attributes.Add(attribute2);
             type.Particle = sequence;
             return type;
         }
         protected LocalidadDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                 base(info, context) 
         {
             this.InitVars();
         }
         public DataColumn LoacaliadIDColumn
         {
            get {
               return this.columnLoacaliadID ;
            }

         }

         public DataColumn LocalidadNombreColumn
         {
            get {
               return this.columnLocalidadNombre ;
            }

         }

         public DataColumn LocalidadCodPosColumn
         {
            get {
               return this.columnLocalidadCodPos ;
            }

         }

         public DataColumn ProvinciaIDColumn
         {
            get {
               return this.columnProvinciaID ;
            }

         }

         public DataColumn ProvinciaNombreColumn
         {
            get {
               return this.columnProvinciaNombre ;
            }

         }

         public event LocalidadRowChangeEventHandler LocalidadRowChanged ;
         public event LocalidadRowChangeEventHandler LocalidadRowChanging ;
         public event LocalidadRowChangeEventHandler LocalidadRowDeleted ;
         public event LocalidadRowChangeEventHandler LocalidadRowDeleting ;
         public LocalidadRow AddLocalidadRow( String localidadNombre ,
                                              String localidadCodPos ,
                                              int provinciaID )
         {
            LocalidadRow rowLocalidadRow = ((LocalidadRow)(this.NewRow())) ;
            rowLocalidadRow["LocalidadNombre"] = localidadNombre ;
            rowLocalidadRow["LocalidadCodPos"] = localidadCodPos ;
            rowLocalidadRow["ProvinciaID"] = provinciaID ;
            this.Rows.Add( rowLocalidadRow) ;
            return rowLocalidadRow ;
         }

         public LocalidadRow FindByLoacaliadID( int loacaliadID )
         {
            return ((LocalidadRow)(this.Rows.Find(new  object[] {loacaliadID}))) ;
         }

         internal void InitVars( )
         {
            this.columnLoacaliadID = this.Columns["LoacaliadID"] ;
            this.columnLocalidadNombre = this.Columns["LocalidadNombre"] ;
            this.columnLocalidadCodPos = this.Columns["LocalidadCodPos"] ;
            this.columnProvinciaID = this.Columns["ProvinciaID"] ;
            this.columnProvinciaNombre = this.Columns["ProvinciaNombre"] ;
         }

         public void InitClass( )
         {
            this.columnLoacaliadID = new DataColumn( "LoacaliadID", typeof(int), "", System.Data.MappingType.Element) ;
            this.columnLoacaliadID.AllowDBNull = false ;
            this.columnLoacaliadID.Caption = "Loacaliad ID" ;
            this.columnLoacaliadID.Unique = true ;
            this.columnLoacaliadID.AutoIncrement = true ;
            this.columnLoacaliadID.AutoIncrementSeed = -1 ;
            this.columnLoacaliadID.AutoIncrementStep = -1 ;
            this.columnLoacaliadID.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnLoacaliadID.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnLoacaliadID.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnLoacaliadID.ExtendedProperties.Add( "AutoNumber", "true") ;
            this.columnLoacaliadID.ExtendedProperties.Add( "IsKey", "true") ;
            this.columnLoacaliadID.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnLoacaliadID.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnLoacaliadID.ExtendedProperties.Add( "Description", "Loacaliad ID") ;
            this.columnLoacaliadID.ExtendedProperties.Add( "Length", "8") ;
            this.columnLoacaliadID.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnLoacaliadID.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnLoacaliadID.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnLoacaliadID.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnLoacaliadID.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnLoacaliadID.ExtendedProperties.Add( "Deklarit.InternalName", "LoacaliadID") ;
            this.Columns.Add( this.columnLoacaliadID) ;
            this.columnLocalidadNombre = new DataColumn( "LocalidadNombre", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnLocalidadNombre.AllowDBNull = false ;
            this.columnLocalidadNombre.Caption = "Localidad Nombre" ;
            this.columnLocalidadNombre.MaxLength = 60 ;
            this.columnLocalidadNombre.DefaultValue = System.Convert.DBNull ;
            this.columnLocalidadNombre.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnLocalidadNombre.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnLocalidadNombre.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnLocalidadNombre.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnLocalidadNombre.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnLocalidadNombre.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnLocalidadNombre.ExtendedProperties.Add( "Description", "Localidad Nombre") ;
            this.columnLocalidadNombre.ExtendedProperties.Add( "Length", "60") ;
            this.columnLocalidadNombre.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnLocalidadNombre.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnLocalidadNombre.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnLocalidadNombre.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnLocalidadNombre.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnLocalidadNombre.ExtendedProperties.Add( "Deklarit.InternalName", "LocalidadNombre") ;
            this.Columns.Add( this.columnLocalidadNombre) ;
            this.columnLocalidadCodPos = new DataColumn( "LocalidadCodPos", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnLocalidadCodPos.AllowDBNull = true ;
            this.columnLocalidadCodPos.Caption = "Localidad Cod Pos" ;
            this.columnLocalidadCodPos.MaxLength = 7 ;
            this.columnLocalidadCodPos.DefaultValue = System.Convert.DBNull ;
            this.columnLocalidadCodPos.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnLocalidadCodPos.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnLocalidadCodPos.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnLocalidadCodPos.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnLocalidadCodPos.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnLocalidadCodPos.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnLocalidadCodPos.ExtendedProperties.Add( "Description", "Localidad Cod Pos") ;
            this.columnLocalidadCodPos.ExtendedProperties.Add( "Length", "7") ;
            this.columnLocalidadCodPos.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnLocalidadCodPos.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnLocalidadCodPos.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnLocalidadCodPos.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnLocalidadCodPos.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnLocalidadCodPos.ExtendedProperties.Add( "Deklarit.InternalName", "LocalidadCodPos") ;
            this.Columns.Add( this.columnLocalidadCodPos) ;
            this.columnProvinciaID = new DataColumn( "ProvinciaID", typeof(int), "", System.Data.MappingType.Element) ;
            this.columnProvinciaID.AllowDBNull = false ;
            this.columnProvinciaID.Caption = "Provincia ID" ;
            this.columnProvinciaID.DefaultValue = System.Convert.DBNull ;
            this.columnProvinciaID.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnProvinciaID.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnProvinciaID.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnProvinciaID.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnProvinciaID.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnProvinciaID.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnProvinciaID.ExtendedProperties.Add( "Description", "Provincia ID") ;
            this.columnProvinciaID.ExtendedProperties.Add( "Length", "5") ;
            this.columnProvinciaID.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnProvinciaID.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnProvinciaID.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnProvinciaID.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnProvinciaID.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnProvinciaID.ExtendedProperties.Add( "Deklarit.InternalName", "ProvinciaID") ;
            this.Columns.Add( this.columnProvinciaID) ;
            this.columnProvinciaNombre = new DataColumn( "ProvinciaNombre", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnProvinciaNombre.AllowDBNull = true ;
            this.columnProvinciaNombre.Caption = "Provincia Nombre" ;
            this.columnProvinciaNombre.MaxLength = 60 ;
            this.columnProvinciaNombre.DefaultValue = System.Convert.DBNull ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "ReadOnly", "true") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "Description", "Provincia Nombre") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "Length", "60") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "Deklarit.InternalName", "ProvinciaNombre") ;
            this.Columns.Add( this.columnProvinciaNombre) ;
            this.PrimaryKey = new  DataColumn[]  {this.columnLoacaliadID} ;
            this.ExtendedProperties.Add( "ParentLvl", "") ;
            this.ExtendedProperties.Add( "LevelName", "Localidad") ;
            this.ExtendedProperties.Add( "Description", "Localidad") ;
            this.ExtendedProperties.Add( "msprop:AllowInsert", "true") ;
            this.ExtendedProperties.Add( "msprop:AllowUpdate", "true") ;
            this.ExtendedProperties.Add( "msprop:AllowDelete", "true") ;
            this.ExtendedProperties.Add( "Deklarit.EditInDataGrid", "True") ;
         }

         protected override void OnRowChanged( DataRowChangeEventArgs e )
         {
            base.OnRowChanged( e) ;
            if ( ( this.LocalidadRowChanged != null ) )
            {
               this.LocalidadRowChanged( this, new LocalidadRowChangeEvent( ((LocalidadRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowChanging( DataRowChangeEventArgs e )
         {
            base.OnRowChanging( e) ;
            if ( ( this.LocalidadRowChanging != null ) )
            {
               this.LocalidadRowChanging( this, new LocalidadRowChangeEvent( ((LocalidadRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowDeleted( DataRowChangeEventArgs e )
         {
            base.OnRowDeleted( e) ;
            if ( ( this.LocalidadRowDeleted != null ) )
            {
               this.LocalidadRowDeleted( this, new LocalidadRowChangeEvent( ((LocalidadRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowDeleting( DataRowChangeEventArgs e )
         {
            base.OnRowDeleting( e) ;
            if ( ( this.LocalidadRowDeleting != null ) )
            {
               this.LocalidadRowDeleting( this, new LocalidadRowChangeEvent( ((LocalidadRow)(e.Row)), e.Action)) ;
            }
         }

      }

      public class LocalidadRow : DataRow
      {
         private LocalidadDataTable tableLocalidad ;
         internal LocalidadRow( DataRowBuilder rb ) : base(rb)
         {
            this.tableLocalidad = ((LocalidadDataTable)(this.Table)) ;
         }

         ///  <summary>
         ///   Gets or sets the Loacaliad ID.
         ///  </summary>
         public int LoacaliadID
         {
            get {
               return ((int)(this[this.tableLocalidad.LoacaliadIDColumn])) ;
            }

            set {
               this[this.tableLocalidad.LoacaliadIDColumn] = value ;
            }

         }

         public bool IsLoacaliadIDNull( )
         {
            return this.IsNull( this.tableLocalidad.LoacaliadIDColumn) ;
         }

         ///  <summary>
         ///   Gets or sets the Localidad Nombre.
         ///  </summary>
         public String LocalidadNombre
         {
            get {
               try
               {
                  return ((String)(this[this.tableLocalidad.LocalidadNombreColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value LocalidadNombre because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableLocalidad.LocalidadNombreColumn] = value ;
            }

         }

         public bool IsLocalidadNombreNull( )
         {
            return this.IsNull( this.tableLocalidad.LocalidadNombreColumn) ;
         }

         public void SetLocalidadNombreNull( )
         {
            this[this.tableLocalidad.LocalidadNombreColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Localidad Cod Pos.
         ///  </summary>
         public String LocalidadCodPos
         {
            get {
               try
               {
                  return ((String)(this[this.tableLocalidad.LocalidadCodPosColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value LocalidadCodPos because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableLocalidad.LocalidadCodPosColumn] = value ;
            }

         }

         public bool IsLocalidadCodPosNull( )
         {
            return this.IsNull( this.tableLocalidad.LocalidadCodPosColumn) ;
         }

         public void SetLocalidadCodPosNull( )
         {
            this[this.tableLocalidad.LocalidadCodPosColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Provincia ID.
         ///  </summary>
         public int ProvinciaID
         {
            get {
               try
               {
                  return ((int)(this[this.tableLocalidad.ProvinciaIDColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value ProvinciaID because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableLocalidad.ProvinciaIDColumn] = value ;
            }

         }

         public bool IsProvinciaIDNull( )
         {
            return this.IsNull( this.tableLocalidad.ProvinciaIDColumn) ;
         }

         public void SetProvinciaIDNull( )
         {
            this[this.tableLocalidad.ProvinciaIDColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Provincia Nombre.
         ///  </summary>
         public String ProvinciaNombre
         {
            get {
               try
               {
                  return ((String)(this[this.tableLocalidad.ProvinciaNombreColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value ProvinciaNombre because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableLocalidad.ProvinciaNombreColumn] = value ;
            }

         }

         public bool IsProvinciaNombreNull( )
         {
            return this.IsNull( this.tableLocalidad.ProvinciaNombreColumn) ;
         }

         public void SetProvinciaNombreNull( )
         {
            this[this.tableLocalidad.ProvinciaNombreColumn] = System.Convert.DBNull ;
         }

      }

      public class LocalidadRowChangeEvent : EventArgs
      {
         private LocalidadRow eventRow ;
         private System.Data.DataRowAction eventAction ;
         public LocalidadRowChangeEvent( LocalidadRow row ,
                                         DataRowAction action )
         {
            this.eventRow = row ;
            this.eventAction = action ;
         }

         public LocalidadRow Row
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
