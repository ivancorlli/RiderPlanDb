
//               File: ProvinciaDataSet
//        Description: Provincia
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
   public partial class ProvinciaDataSet : System.Data.DataSet
   {
      private ProvinciaDataTable tableProvincia ;
      [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
      public ProvinciaDataTable Provincia
      {
         get {
            return this.tableProvincia ;
         }

      }

      private System.Data.SchemaSerializationMode _schemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema;
      
      [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
      public ProvinciaDataSet() {
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
          ProvinciaDataSet cln = ((ProvinciaDataSet)(base.Clone()));
          cln.InitVars();
          return cln;
      }
      
      protected override bool ShouldSerializeTables() {
      	    return false;
      }
      
      protected override bool ShouldSerializeRelations() {
      	    return false;
      }
      
      private bool ShouldSerializeProvincia() { 
		return false; 
	  }
              
      protected override void ReadXmlSerializable(XmlReader reader) 
      {
          if ((this.DetermineSchemaSerializationMode(reader) == System.Data.SchemaSerializationMode.IncludeSchema)) 
          {
      		this.Reset();
      		DataSet ds = new DataSet();
              ds.ReadXml(reader);
              if ((ds.Tables["Provincia"] != null))  
        { 
			base.Tables.Add(new ProvinciaDataTable(ds.Tables["Provincia"])); 
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
          this.tableProvincia = ((ProvinciaDataTable)(base.Tables["Provincia"]));		
		  if ((initTable == true)) { 
			if ((this.tableProvincia != null)) { 
				this.tableProvincia.InitVars(); 
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
          ProvinciaDataSet ds = new ProvinciaDataSet();
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
      protected ProvinciaDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context, false)
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
              if ((ds.Tables["Provincia"] != null))  
        { 
			base.Tables.Add(new ProvinciaDataTable(ds.Tables["Provincia"])); 
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
         this.ExtendedProperties.Add( "DataAdapterName", "ProvinciaDataAdapter") ;
         this.ExtendedProperties.Add( "BigImage", " ") ;
         this.ExtendedProperties.Add( "SmallImage", " ") ;
         this.ExtendedProperties.Add( "Image", " ") ;
         this.ExtendedProperties.Add( "Deklarit.PermissionBaseId", "2006") ;
         this.ExtendedProperties.Add( "DataSetName", "ProvinciaDataSet") ;
         this.ExtendedProperties.Add( "DataAdapterInterfaceName", "IProvinciaDataAdapter") ;
         this.ExtendedProperties.Add( "ObjectName", "Provincia") ;
         this.ExtendedProperties.Add( "ObjectDescription", "Provincia") ;
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
         this.DataSetName = "ProvinciaDataSet" ;
         this.Namespace = "http://www.tempuri.org/Provincia" ;
         this.tableProvincia = new ProvinciaDataTable() ;
         this.Tables.Add( this.tableProvincia) ;
      }

      public delegate  void ProvinciaRowChangeEventHandler( object sender ,
                                                            ProvinciaRowChangeEvent e );
      [Serializable()]
      public partial class ProvinciaDataTable : DataTable, System.Collections.IEnumerable
      {
         private DataColumn columnProvinciaID ;
         private DataColumn columnProvinciaNombre ;
         private DataColumn columnPaisID ;
         private DataColumn columnPaisNombre ;
         public ProvinciaDataTable() 
         {
             this.TableName = "Provincia";
             this.BeginInit();
             this.InitClass();
             this.EndInit();
         }
         
         internal ProvinciaDataTable(System.Data.DataTable table) {
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
         
         public ProvinciaRow this[int index] {
             get {
                 return ((ProvinciaRow)(this.Rows[index]));
             }
         }
         
         public virtual System.Collections.IEnumerator GetEnumerator() {
             return this.Rows.GetEnumerator();
         }
         
         public override System.Data.DataTable Clone() {
             ProvinciaDataTable cln = ((ProvinciaDataTable)(base.Clone()));
             cln.InitVars();
             return cln;
         }
         
         protected override System.Data.DataTable CreateInstance() {
             return new ProvinciaDataTable();
         }
         
         public void AddProvinciaRow(ProvinciaRow row) {
             this.Rows.Add(row);
         }
         
         public ProvinciaRow NewProvinciaRow() {
             return ((ProvinciaRow)(this.NewRow()));
         }
         
         protected override System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder) {
             return new ProvinciaRow(builder);
         }
         
         protected override System.Type GetRowType() {
             return typeof(ProvinciaRow);
         }
         
         public void RemoveProvinciaRow(ProvinciaRow row) {
             this.Rows.Remove(row);
         }
         
         public static System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet xs) {
             System.Xml.Schema.XmlSchemaComplexType type = new System.Xml.Schema.XmlSchemaComplexType();
             System.Xml.Schema.XmlSchemaSequence sequence = new System.Xml.Schema.XmlSchemaSequence();
             ProvinciaDataSet ds = new ProvinciaDataSet();
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
             attribute2.FixedValue = "ProvinciaDataTable";
             type.Attributes.Add(attribute2);
             type.Particle = sequence;
             return type;
         }
         protected ProvinciaDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                 base(info, context) 
         {
             this.InitVars();
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

         public DataColumn PaisIDColumn
         {
            get {
               return this.columnPaisID ;
            }

         }

         public DataColumn PaisNombreColumn
         {
            get {
               return this.columnPaisNombre ;
            }

         }

         public event ProvinciaRowChangeEventHandler ProvinciaRowChanged ;
         public event ProvinciaRowChangeEventHandler ProvinciaRowChanging ;
         public event ProvinciaRowChangeEventHandler ProvinciaRowDeleted ;
         public event ProvinciaRowChangeEventHandler ProvinciaRowDeleting ;
         public ProvinciaRow AddProvinciaRow( String provinciaNombre ,
                                              int paisID )
         {
            ProvinciaRow rowProvinciaRow = ((ProvinciaRow)(this.NewRow())) ;
            rowProvinciaRow["ProvinciaNombre"] = provinciaNombre ;
            rowProvinciaRow["PaisID"] = paisID ;
            this.Rows.Add( rowProvinciaRow) ;
            return rowProvinciaRow ;
         }

         public ProvinciaRow FindByProvinciaID( int provinciaID )
         {
            return ((ProvinciaRow)(this.Rows.Find(new  object[] {provinciaID}))) ;
         }

         internal void InitVars( )
         {
            this.columnProvinciaID = this.Columns["ProvinciaID"] ;
            this.columnProvinciaNombre = this.Columns["ProvinciaNombre"] ;
            this.columnPaisID = this.Columns["PaisID"] ;
            this.columnPaisNombre = this.Columns["PaisNombre"] ;
         }

         public void InitClass( )
         {
            this.columnProvinciaID = new DataColumn( "ProvinciaID", typeof(int), "", System.Data.MappingType.Element) ;
            this.columnProvinciaID.AllowDBNull = false ;
            this.columnProvinciaID.Caption = "Provincia ID" ;
            this.columnProvinciaID.Unique = true ;
            this.columnProvinciaID.AutoIncrement = true ;
            this.columnProvinciaID.AutoIncrementSeed = -1 ;
            this.columnProvinciaID.AutoIncrementStep = -1 ;
            this.columnProvinciaID.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnProvinciaID.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnProvinciaID.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnProvinciaID.ExtendedProperties.Add( "AutoNumber", "true") ;
            this.columnProvinciaID.ExtendedProperties.Add( "IsKey", "true") ;
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
            this.columnProvinciaNombre.AllowDBNull = false ;
            this.columnProvinciaNombre.Caption = "Provincia Nombre" ;
            this.columnProvinciaNombre.MaxLength = 60 ;
            this.columnProvinciaNombre.DefaultValue = System.Convert.DBNull ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "Description", "Provincia Nombre") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "Length", "60") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnProvinciaNombre.ExtendedProperties.Add( "Deklarit.InternalName", "ProvinciaNombre") ;
            this.Columns.Add( this.columnProvinciaNombre) ;
            this.columnPaisID = new DataColumn( "PaisID", typeof(int), "", System.Data.MappingType.Element) ;
            this.columnPaisID.AllowDBNull = false ;
            this.columnPaisID.Caption = "Pais ID" ;
            this.columnPaisID.DefaultValue = System.Convert.DBNull ;
            this.columnPaisID.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnPaisID.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnPaisID.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnPaisID.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnPaisID.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnPaisID.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnPaisID.ExtendedProperties.Add( "Description", "Pais ID") ;
            this.columnPaisID.ExtendedProperties.Add( "Length", "5") ;
            this.columnPaisID.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnPaisID.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnPaisID.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnPaisID.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnPaisID.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnPaisID.ExtendedProperties.Add( "Deklarit.InternalName", "PaisID") ;
            this.Columns.Add( this.columnPaisID) ;
            this.columnPaisNombre = new DataColumn( "PaisNombre", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnPaisNombre.AllowDBNull = true ;
            this.columnPaisNombre.Caption = "Pais Nombre" ;
            this.columnPaisNombre.MaxLength = 60 ;
            this.columnPaisNombre.DefaultValue = System.Convert.DBNull ;
            this.columnPaisNombre.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnPaisNombre.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnPaisNombre.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnPaisNombre.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnPaisNombre.ExtendedProperties.Add( "ReadOnly", "true") ;
            this.columnPaisNombre.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnPaisNombre.ExtendedProperties.Add( "Description", "Pais Nombre") ;
            this.columnPaisNombre.ExtendedProperties.Add( "Length", "60") ;
            this.columnPaisNombre.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnPaisNombre.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnPaisNombre.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnPaisNombre.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnPaisNombre.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnPaisNombre.ExtendedProperties.Add( "Deklarit.InternalName", "PaisNombre") ;
            this.Columns.Add( this.columnPaisNombre) ;
            this.PrimaryKey = new  DataColumn[]  {this.columnProvinciaID} ;
            this.ExtendedProperties.Add( "ParentLvl", "") ;
            this.ExtendedProperties.Add( "LevelName", "Provincia") ;
            this.ExtendedProperties.Add( "Description", "Provincia") ;
            this.ExtendedProperties.Add( "msprop:AllowInsert", "true") ;
            this.ExtendedProperties.Add( "msprop:AllowUpdate", "true") ;
            this.ExtendedProperties.Add( "msprop:AllowDelete", "true") ;
            this.ExtendedProperties.Add( "Deklarit.EditInDataGrid", "True") ;
         }

         protected override void OnRowChanged( DataRowChangeEventArgs e )
         {
            base.OnRowChanged( e) ;
            if ( ( this.ProvinciaRowChanged != null ) )
            {
               this.ProvinciaRowChanged( this, new ProvinciaRowChangeEvent( ((ProvinciaRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowChanging( DataRowChangeEventArgs e )
         {
            base.OnRowChanging( e) ;
            if ( ( this.ProvinciaRowChanging != null ) )
            {
               this.ProvinciaRowChanging( this, new ProvinciaRowChangeEvent( ((ProvinciaRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowDeleted( DataRowChangeEventArgs e )
         {
            base.OnRowDeleted( e) ;
            if ( ( this.ProvinciaRowDeleted != null ) )
            {
               this.ProvinciaRowDeleted( this, new ProvinciaRowChangeEvent( ((ProvinciaRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowDeleting( DataRowChangeEventArgs e )
         {
            base.OnRowDeleting( e) ;
            if ( ( this.ProvinciaRowDeleting != null ) )
            {
               this.ProvinciaRowDeleting( this, new ProvinciaRowChangeEvent( ((ProvinciaRow)(e.Row)), e.Action)) ;
            }
         }

      }

      public class ProvinciaRow : DataRow
      {
         private ProvinciaDataTable tableProvincia ;
         internal ProvinciaRow( DataRowBuilder rb ) : base(rb)
         {
            this.tableProvincia = ((ProvinciaDataTable)(this.Table)) ;
         }

         ///  <summary>
         ///   Gets or sets the Provincia ID.
         ///  </summary>
         public int ProvinciaID
         {
            get {
               return ((int)(this[this.tableProvincia.ProvinciaIDColumn])) ;
            }

            set {
               this[this.tableProvincia.ProvinciaIDColumn] = value ;
            }

         }

         public bool IsProvinciaIDNull( )
         {
            return this.IsNull( this.tableProvincia.ProvinciaIDColumn) ;
         }

         ///  <summary>
         ///   Gets or sets the Provincia Nombre.
         ///  </summary>
         public String ProvinciaNombre
         {
            get {
               try
               {
                  return ((String)(this[this.tableProvincia.ProvinciaNombreColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value ProvinciaNombre because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableProvincia.ProvinciaNombreColumn] = value ;
            }

         }

         public bool IsProvinciaNombreNull( )
         {
            return this.IsNull( this.tableProvincia.ProvinciaNombreColumn) ;
         }

         public void SetProvinciaNombreNull( )
         {
            this[this.tableProvincia.ProvinciaNombreColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Pais ID.
         ///  </summary>
         public int PaisID
         {
            get {
               try
               {
                  return ((int)(this[this.tableProvincia.PaisIDColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value PaisID because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableProvincia.PaisIDColumn] = value ;
            }

         }

         public bool IsPaisIDNull( )
         {
            return this.IsNull( this.tableProvincia.PaisIDColumn) ;
         }

         public void SetPaisIDNull( )
         {
            this[this.tableProvincia.PaisIDColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Pais Nombre.
         ///  </summary>
         public String PaisNombre
         {
            get {
               try
               {
                  return ((String)(this[this.tableProvincia.PaisNombreColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value PaisNombre because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableProvincia.PaisNombreColumn] = value ;
            }

         }

         public bool IsPaisNombreNull( )
         {
            return this.IsNull( this.tableProvincia.PaisNombreColumn) ;
         }

         public void SetPaisNombreNull( )
         {
            this[this.tableProvincia.PaisNombreColumn] = System.Convert.DBNull ;
         }

      }

      public class ProvinciaRowChangeEvent : EventArgs
      {
         private ProvinciaRow eventRow ;
         private System.Data.DataRowAction eventAction ;
         public ProvinciaRowChangeEvent( ProvinciaRow row ,
                                         DataRowAction action )
         {
            this.eventRow = row ;
            this.eventAction = action ;
         }

         public ProvinciaRow Row
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
