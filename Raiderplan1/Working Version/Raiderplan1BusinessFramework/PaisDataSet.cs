
//               File: PaisDataSet
//        Description: Pais
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
   public partial class PaisDataSet : System.Data.DataSet
   {
      private PaisDataTable tablePais ;
      [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
      public PaisDataTable Pais
      {
         get {
            return this.tablePais ;
         }

      }

      private System.Data.SchemaSerializationMode _schemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema;
      
      [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
      public PaisDataSet() {
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
          PaisDataSet cln = ((PaisDataSet)(base.Clone()));
          cln.InitVars();
          return cln;
      }
      
      protected override bool ShouldSerializeTables() {
      	    return false;
      }
      
      protected override bool ShouldSerializeRelations() {
      	    return false;
      }
      
      private bool ShouldSerializePais() { 
		return false; 
	  }
              
      protected override void ReadXmlSerializable(XmlReader reader) 
      {
          if ((this.DetermineSchemaSerializationMode(reader) == System.Data.SchemaSerializationMode.IncludeSchema)) 
          {
      		this.Reset();
      		DataSet ds = new DataSet();
              ds.ReadXml(reader);
              if ((ds.Tables["Pais"] != null))  
        { 
			base.Tables.Add(new PaisDataTable(ds.Tables["Pais"])); 
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
          this.tablePais = ((PaisDataTable)(base.Tables["Pais"]));		
		  if ((initTable == true)) { 
			if ((this.tablePais != null)) { 
				this.tablePais.InitVars(); 
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
          PaisDataSet ds = new PaisDataSet();
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
      protected PaisDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context, false)
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
              if ((ds.Tables["Pais"] != null))  
        { 
			base.Tables.Add(new PaisDataTable(ds.Tables["Pais"])); 
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
         this.ExtendedProperties.Add( "DataAdapterName", "PaisDataAdapter") ;
         this.ExtendedProperties.Add( "BigImage", " ") ;
         this.ExtendedProperties.Add( "SmallImage", " ") ;
         this.ExtendedProperties.Add( "Image", " ") ;
         this.ExtendedProperties.Add( "Deklarit.PermissionBaseId", "2004") ;
         this.ExtendedProperties.Add( "DataSetName", "PaisDataSet") ;
         this.ExtendedProperties.Add( "DataAdapterInterfaceName", "IPaisDataAdapter") ;
         this.ExtendedProperties.Add( "ObjectName", "Pais") ;
         this.ExtendedProperties.Add( "ObjectDescription", "Pais") ;
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
         this.DataSetName = "PaisDataSet" ;
         this.Namespace = "http://www.tempuri.org/Pais" ;
         this.tablePais = new PaisDataTable() ;
         this.Tables.Add( this.tablePais) ;
      }

      public delegate  void PaisRowChangeEventHandler( object sender ,
                                                       PaisRowChangeEvent e );
      [Serializable()]
      public partial class PaisDataTable : DataTable, System.Collections.IEnumerable
      {
         private DataColumn columnPaisID ;
         private DataColumn columnPaisNombre ;
         public PaisDataTable() 
         {
             this.TableName = "Pais";
             this.BeginInit();
             this.InitClass();
             this.EndInit();
         }
         
         internal PaisDataTable(System.Data.DataTable table) {
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
         
         public PaisRow this[int index] {
             get {
                 return ((PaisRow)(this.Rows[index]));
             }
         }
         
         public virtual System.Collections.IEnumerator GetEnumerator() {
             return this.Rows.GetEnumerator();
         }
         
         public override System.Data.DataTable Clone() {
             PaisDataTable cln = ((PaisDataTable)(base.Clone()));
             cln.InitVars();
             return cln;
         }
         
         protected override System.Data.DataTable CreateInstance() {
             return new PaisDataTable();
         }
         
         public void AddPaisRow(PaisRow row) {
             this.Rows.Add(row);
         }
         
         public PaisRow NewPaisRow() {
             return ((PaisRow)(this.NewRow()));
         }
         
         protected override System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder) {
             return new PaisRow(builder);
         }
         
         protected override System.Type GetRowType() {
             return typeof(PaisRow);
         }
         
         public void RemovePaisRow(PaisRow row) {
             this.Rows.Remove(row);
         }
         
         public static System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet xs) {
             System.Xml.Schema.XmlSchemaComplexType type = new System.Xml.Schema.XmlSchemaComplexType();
             System.Xml.Schema.XmlSchemaSequence sequence = new System.Xml.Schema.XmlSchemaSequence();
             PaisDataSet ds = new PaisDataSet();
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
             attribute2.FixedValue = "PaisDataTable";
             type.Attributes.Add(attribute2);
             type.Particle = sequence;
             return type;
         }
         protected PaisDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                 base(info, context) 
         {
             this.InitVars();
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

         public event PaisRowChangeEventHandler PaisRowChanged ;
         public event PaisRowChangeEventHandler PaisRowChanging ;
         public event PaisRowChangeEventHandler PaisRowDeleted ;
         public event PaisRowChangeEventHandler PaisRowDeleting ;
         public PaisRow AddPaisRow( String paisNombre )
         {
            PaisRow rowPaisRow = ((PaisRow)(this.NewRow())) ;
            rowPaisRow["PaisNombre"] = paisNombre ;
            this.Rows.Add( rowPaisRow) ;
            return rowPaisRow ;
         }

         public PaisRow FindByPaisID( int paisID )
         {
            return ((PaisRow)(this.Rows.Find(new  object[] {paisID}))) ;
         }

         internal void InitVars( )
         {
            this.columnPaisID = this.Columns["PaisID"] ;
            this.columnPaisNombre = this.Columns["PaisNombre"] ;
         }

         public void InitClass( )
         {
            this.columnPaisID = new DataColumn( "PaisID", typeof(int), "", System.Data.MappingType.Element) ;
            this.columnPaisID.AllowDBNull = false ;
            this.columnPaisID.Caption = "Pais ID" ;
            this.columnPaisID.Unique = true ;
            this.columnPaisID.AutoIncrement = true ;
            this.columnPaisID.AutoIncrementSeed = -1 ;
            this.columnPaisID.AutoIncrementStep = -1 ;
            this.columnPaisID.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnPaisID.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnPaisID.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnPaisID.ExtendedProperties.Add( "AutoNumber", "true") ;
            this.columnPaisID.ExtendedProperties.Add( "IsKey", "true") ;
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
            this.columnPaisNombre.AllowDBNull = false ;
            this.columnPaisNombre.Caption = "Pais Nombre" ;
            this.columnPaisNombre.MaxLength = 60 ;
            this.columnPaisNombre.DefaultValue = System.Convert.DBNull ;
            this.columnPaisNombre.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnPaisNombre.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnPaisNombre.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnPaisNombre.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnPaisNombre.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnPaisNombre.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnPaisNombre.ExtendedProperties.Add( "Description", "Pais Nombre") ;
            this.columnPaisNombre.ExtendedProperties.Add( "Length", "60") ;
            this.columnPaisNombre.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnPaisNombre.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnPaisNombre.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnPaisNombre.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnPaisNombre.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnPaisNombre.ExtendedProperties.Add( "Deklarit.InternalName", "PaisNombre") ;
            this.Columns.Add( this.columnPaisNombre) ;
            this.PrimaryKey = new  DataColumn[]  {this.columnPaisID} ;
            this.ExtendedProperties.Add( "ParentLvl", "") ;
            this.ExtendedProperties.Add( "LevelName", "Pais") ;
            this.ExtendedProperties.Add( "Description", "Pais") ;
            this.ExtendedProperties.Add( "msprop:AllowInsert", "true") ;
            this.ExtendedProperties.Add( "msprop:AllowUpdate", "true") ;
            this.ExtendedProperties.Add( "msprop:AllowDelete", "true") ;
            this.ExtendedProperties.Add( "Deklarit.EditInDataGrid", "True") ;
         }

         protected override void OnRowChanged( DataRowChangeEventArgs e )
         {
            base.OnRowChanged( e) ;
            if ( ( this.PaisRowChanged != null ) )
            {
               this.PaisRowChanged( this, new PaisRowChangeEvent( ((PaisRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowChanging( DataRowChangeEventArgs e )
         {
            base.OnRowChanging( e) ;
            if ( ( this.PaisRowChanging != null ) )
            {
               this.PaisRowChanging( this, new PaisRowChangeEvent( ((PaisRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowDeleted( DataRowChangeEventArgs e )
         {
            base.OnRowDeleted( e) ;
            if ( ( this.PaisRowDeleted != null ) )
            {
               this.PaisRowDeleted( this, new PaisRowChangeEvent( ((PaisRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowDeleting( DataRowChangeEventArgs e )
         {
            base.OnRowDeleting( e) ;
            if ( ( this.PaisRowDeleting != null ) )
            {
               this.PaisRowDeleting( this, new PaisRowChangeEvent( ((PaisRow)(e.Row)), e.Action)) ;
            }
         }

      }

      public class PaisRow : DataRow
      {
         private PaisDataTable tablePais ;
         internal PaisRow( DataRowBuilder rb ) : base(rb)
         {
            this.tablePais = ((PaisDataTable)(this.Table)) ;
         }

         ///  <summary>
         ///   Gets or sets the Pais ID.
         ///  </summary>
         public int PaisID
         {
            get {
               return ((int)(this[this.tablePais.PaisIDColumn])) ;
            }

            set {
               this[this.tablePais.PaisIDColumn] = value ;
            }

         }

         public bool IsPaisIDNull( )
         {
            return this.IsNull( this.tablePais.PaisIDColumn) ;
         }

         ///  <summary>
         ///   Gets or sets the Pais Nombre.
         ///  </summary>
         public String PaisNombre
         {
            get {
               try
               {
                  return ((String)(this[this.tablePais.PaisNombreColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value PaisNombre because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tablePais.PaisNombreColumn] = value ;
            }

         }

         public bool IsPaisNombreNull( )
         {
            return this.IsNull( this.tablePais.PaisNombreColumn) ;
         }

         public void SetPaisNombreNull( )
         {
            this[this.tablePais.PaisNombreColumn] = System.Convert.DBNull ;
         }

      }

      public class PaisRowChangeEvent : EventArgs
      {
         private PaisRow eventRow ;
         private System.Data.DataRowAction eventAction ;
         public PaisRowChangeEvent( PaisRow row ,
                                    DataRowAction action )
         {
            this.eventRow = row ;
            this.eventAction = action ;
         }

         public PaisRow Row
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
