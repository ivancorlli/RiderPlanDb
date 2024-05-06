
//               File: TrayectoTipoDetalleDataSet
//        Description: TipoDetalle
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
   public partial class TrayectoTipoDetalleDataSet : System.Data.DataSet
   {
      private TrayectoTipoDetalleDataTable tableTrayectoTipoDetalle ;
      [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
      public TrayectoTipoDetalleDataTable TrayectoTipoDetalle
      {
         get {
            return this.tableTrayectoTipoDetalle ;
         }

      }

      private System.Data.SchemaSerializationMode _schemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema;
      
      [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
      public TrayectoTipoDetalleDataSet() {
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
          TrayectoTipoDetalleDataSet cln = ((TrayectoTipoDetalleDataSet)(base.Clone()));
          cln.InitVars();
          return cln;
      }
      
      protected override bool ShouldSerializeTables() {
      	    return false;
      }
      
      protected override bool ShouldSerializeRelations() {
      	    return false;
      }
      
      private bool ShouldSerializeTrayectoTipoDetalle() { 
		return false; 
	  }
              
      protected override void ReadXmlSerializable(XmlReader reader) 
      {
          if ((this.DetermineSchemaSerializationMode(reader) == System.Data.SchemaSerializationMode.IncludeSchema)) 
          {
      		this.Reset();
      		DataSet ds = new DataSet();
              ds.ReadXml(reader);
              if ((ds.Tables["TrayectoTipoDetalle"] != null))  
        { 
			base.Tables.Add(new TrayectoTipoDetalleDataTable(ds.Tables["TrayectoTipoDetalle"])); 
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
          this.tableTrayectoTipoDetalle = ((TrayectoTipoDetalleDataTable)(base.Tables["TrayectoTipoDetalle"]));		
		  if ((initTable == true)) { 
			if ((this.tableTrayectoTipoDetalle != null)) { 
				this.tableTrayectoTipoDetalle.InitVars(); 
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
          TrayectoTipoDetalleDataSet ds = new TrayectoTipoDetalleDataSet();
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
      protected TrayectoTipoDetalleDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context, false)
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
              if ((ds.Tables["TrayectoTipoDetalle"] != null))  
        { 
			base.Tables.Add(new TrayectoTipoDetalleDataTable(ds.Tables["TrayectoTipoDetalle"])); 
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
         this.ExtendedProperties.Add( "DataAdapterName", "TrayectoTipoDetalleDataAdapter") ;
         this.ExtendedProperties.Add( "BigImage", " ") ;
         this.ExtendedProperties.Add( "SmallImage", " ") ;
         this.ExtendedProperties.Add( "Image", " ") ;
         this.ExtendedProperties.Add( "Deklarit.PermissionBaseId", "2013") ;
         this.ExtendedProperties.Add( "DataSetName", "TrayectoTipoDetalleDataSet") ;
         this.ExtendedProperties.Add( "DataAdapterInterfaceName", "ITrayectoTipoDetalleDataAdapter") ;
         this.ExtendedProperties.Add( "ObjectName", "TrayectoTipoDetalle") ;
         this.ExtendedProperties.Add( "ObjectDescription", "TipoDetalle") ;
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
         this.DataSetName = "TrayectoTipoDetalleDataSet" ;
         this.Namespace = "http://www.tempuri.org/TrayectoTipoDetalle" ;
         this.tableTrayectoTipoDetalle = new TrayectoTipoDetalleDataTable() ;
         this.Tables.Add( this.tableTrayectoTipoDetalle) ;
      }

      public delegate  void TrayectoTipoDetalleRowChangeEventHandler( object sender ,
                                                                      TrayectoTipoDetalleRowChangeEvent e );
      [Serializable()]
      public partial class TrayectoTipoDetalleDataTable : DataTable, System.Collections.IEnumerable
      {
         private DataColumn columnTrayectoTipoDetalleID ;
         private DataColumn columnTTipoDetalleCategoria ;
         private DataColumn columnTTipoDetalleIcono ;
         public TrayectoTipoDetalleDataTable() 
         {
             this.TableName = "TrayectoTipoDetalle";
             this.BeginInit();
             this.InitClass();
             this.EndInit();
         }
         
         internal TrayectoTipoDetalleDataTable(System.Data.DataTable table) {
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
         
         public TrayectoTipoDetalleRow this[int index] {
             get {
                 return ((TrayectoTipoDetalleRow)(this.Rows[index]));
             }
         }
         
         public virtual System.Collections.IEnumerator GetEnumerator() {
             return this.Rows.GetEnumerator();
         }
         
         public override System.Data.DataTable Clone() {
             TrayectoTipoDetalleDataTable cln = ((TrayectoTipoDetalleDataTable)(base.Clone()));
             cln.InitVars();
             return cln;
         }
         
         protected override System.Data.DataTable CreateInstance() {
             return new TrayectoTipoDetalleDataTable();
         }
         
         public void AddTrayectoTipoDetalleRow(TrayectoTipoDetalleRow row) {
             this.Rows.Add(row);
         }
         
         public TrayectoTipoDetalleRow NewTrayectoTipoDetalleRow() {
             return ((TrayectoTipoDetalleRow)(this.NewRow()));
         }
         
         protected override System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder) {
             return new TrayectoTipoDetalleRow(builder);
         }
         
         protected override System.Type GetRowType() {
             return typeof(TrayectoTipoDetalleRow);
         }
         
         public void RemoveTrayectoTipoDetalleRow(TrayectoTipoDetalleRow row) {
             this.Rows.Remove(row);
         }
         
         public static System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet xs) {
             System.Xml.Schema.XmlSchemaComplexType type = new System.Xml.Schema.XmlSchemaComplexType();
             System.Xml.Schema.XmlSchemaSequence sequence = new System.Xml.Schema.XmlSchemaSequence();
             TrayectoTipoDetalleDataSet ds = new TrayectoTipoDetalleDataSet();
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
             attribute2.FixedValue = "TrayectoTipoDetalleDataTable";
             type.Attributes.Add(attribute2);
             type.Particle = sequence;
             return type;
         }
         protected TrayectoTipoDetalleDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                 base(info, context) 
         {
             this.InitVars();
         }
         public DataColumn TrayectoTipoDetalleIDColumn
         {
            get {
               return this.columnTrayectoTipoDetalleID ;
            }

         }

         public DataColumn TTipoDetalleCategoriaColumn
         {
            get {
               return this.columnTTipoDetalleCategoria ;
            }

         }

         public DataColumn TTipoDetalleIconoColumn
         {
            get {
               return this.columnTTipoDetalleIcono ;
            }

         }

         public event TrayectoTipoDetalleRowChangeEventHandler TrayectoTipoDetalleRowChanged ;
         public event TrayectoTipoDetalleRowChangeEventHandler TrayectoTipoDetalleRowChanging ;
         public event TrayectoTipoDetalleRowChangeEventHandler TrayectoTipoDetalleRowDeleted ;
         public event TrayectoTipoDetalleRowChangeEventHandler TrayectoTipoDetalleRowDeleting ;
         public TrayectoTipoDetalleRow AddTrayectoTipoDetalleRow( int trayectoTipoDetalleID ,
                                                                  String tTipoDetalleCategoria ,
                                                                  String tTipoDetalleIcono )
         {
            TrayectoTipoDetalleRow rowTrayectoTipoDetalleRow = ((TrayectoTipoDetalleRow)(this.NewRow())) ;
            rowTrayectoTipoDetalleRow["TrayectoTipoDetalleID"] = trayectoTipoDetalleID ;
            rowTrayectoTipoDetalleRow["TTipoDetalleCategoria"] = tTipoDetalleCategoria ;
            rowTrayectoTipoDetalleRow["TTipoDetalleIcono"] = tTipoDetalleIcono ;
            this.Rows.Add( rowTrayectoTipoDetalleRow) ;
            return rowTrayectoTipoDetalleRow ;
         }

         public TrayectoTipoDetalleRow FindByTrayectoTipoDetalleID( int trayectoTipoDetalleID )
         {
            return ((TrayectoTipoDetalleRow)(this.Rows.Find(new  object[] {trayectoTipoDetalleID}))) ;
         }

         internal void InitVars( )
         {
            this.columnTrayectoTipoDetalleID = this.Columns["TrayectoTipoDetalleID"] ;
            this.columnTTipoDetalleCategoria = this.Columns["TTipoDetalleCategoria"] ;
            this.columnTTipoDetalleIcono = this.Columns["TTipoDetalleIcono"] ;
         }

         public void InitClass( )
         {
            this.columnTrayectoTipoDetalleID = new DataColumn( "TrayectoTipoDetalleID", typeof(int), "", System.Data.MappingType.Element) ;
            this.columnTrayectoTipoDetalleID.AllowDBNull = false ;
            this.columnTrayectoTipoDetalleID.Caption = "Trayecto Tipo Detalle ID" ;
            this.columnTrayectoTipoDetalleID.Unique = true ;
            this.columnTrayectoTipoDetalleID.DefaultValue = System.Convert.DBNull ;
            this.columnTrayectoTipoDetalleID.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnTrayectoTipoDetalleID.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnTrayectoTipoDetalleID.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnTrayectoTipoDetalleID.ExtendedProperties.Add( "IsKey", "true") ;
            this.columnTrayectoTipoDetalleID.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnTrayectoTipoDetalleID.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnTrayectoTipoDetalleID.ExtendedProperties.Add( "Description", "Trayecto Tipo Detalle ID") ;
            this.columnTrayectoTipoDetalleID.ExtendedProperties.Add( "Length", "5") ;
            this.columnTrayectoTipoDetalleID.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnTrayectoTipoDetalleID.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnTrayectoTipoDetalleID.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnTrayectoTipoDetalleID.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnTrayectoTipoDetalleID.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnTrayectoTipoDetalleID.ExtendedProperties.Add( "Deklarit.InternalName", "TrayectoTipoDetalleID") ;
            this.Columns.Add( this.columnTrayectoTipoDetalleID) ;
            this.columnTTipoDetalleCategoria = new DataColumn( "TTipoDetalleCategoria", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnTTipoDetalleCategoria.AllowDBNull = false ;
            this.columnTTipoDetalleCategoria.Caption = "T Tipo Detalle Categoria" ;
            this.columnTTipoDetalleCategoria.MaxLength = 60 ;
            this.columnTTipoDetalleCategoria.DefaultValue = System.Convert.DBNull ;
            this.columnTTipoDetalleCategoria.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnTTipoDetalleCategoria.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnTTipoDetalleCategoria.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnTTipoDetalleCategoria.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnTTipoDetalleCategoria.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnTTipoDetalleCategoria.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnTTipoDetalleCategoria.ExtendedProperties.Add( "Description", "Nombre de la categoria") ;
            this.columnTTipoDetalleCategoria.ExtendedProperties.Add( "Length", "60") ;
            this.columnTTipoDetalleCategoria.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnTTipoDetalleCategoria.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnTTipoDetalleCategoria.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnTTipoDetalleCategoria.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnTTipoDetalleCategoria.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnTTipoDetalleCategoria.ExtendedProperties.Add( "Deklarit.InternalName", "TTipoDetalleCategoria") ;
            this.Columns.Add( this.columnTTipoDetalleCategoria) ;
            this.columnTTipoDetalleIcono = new DataColumn( "TTipoDetalleIcono", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnTTipoDetalleIcono.AllowDBNull = false ;
            this.columnTTipoDetalleIcono.Caption = "T Tipo Detalle Icono" ;
            this.columnTTipoDetalleIcono.MaxLength = 50 ;
            this.columnTTipoDetalleIcono.DefaultValue = System.Convert.DBNull ;
            this.columnTTipoDetalleIcono.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnTTipoDetalleIcono.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnTTipoDetalleIcono.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnTTipoDetalleIcono.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnTTipoDetalleIcono.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnTTipoDetalleIcono.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnTTipoDetalleIcono.ExtendedProperties.Add( "Description", "T Tipo Detalle Icono") ;
            this.columnTTipoDetalleIcono.ExtendedProperties.Add( "Length", "50") ;
            this.columnTTipoDetalleIcono.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnTTipoDetalleIcono.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnTTipoDetalleIcono.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnTTipoDetalleIcono.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnTTipoDetalleIcono.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnTTipoDetalleIcono.ExtendedProperties.Add( "Deklarit.InternalName", "TTipoDetalleIcono") ;
            this.Columns.Add( this.columnTTipoDetalleIcono) ;
            this.PrimaryKey = new  DataColumn[]  {this.columnTrayectoTipoDetalleID} ;
            this.ExtendedProperties.Add( "ParentLvl", "") ;
            this.ExtendedProperties.Add( "LevelName", "TrayectoTipoDetalle") ;
            this.ExtendedProperties.Add( "Description", "TipoDetalle") ;
            this.ExtendedProperties.Add( "msprop:AllowInsert", "true") ;
            this.ExtendedProperties.Add( "msprop:AllowUpdate", "true") ;
            this.ExtendedProperties.Add( "msprop:AllowDelete", "true") ;
            this.ExtendedProperties.Add( "Deklarit.EditInDataGrid", "True") ;
         }

         protected override void OnRowChanged( DataRowChangeEventArgs e )
         {
            base.OnRowChanged( e) ;
            if ( ( this.TrayectoTipoDetalleRowChanged != null ) )
            {
               this.TrayectoTipoDetalleRowChanged( this, new TrayectoTipoDetalleRowChangeEvent( ((TrayectoTipoDetalleRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowChanging( DataRowChangeEventArgs e )
         {
            base.OnRowChanging( e) ;
            if ( ( this.TrayectoTipoDetalleRowChanging != null ) )
            {
               this.TrayectoTipoDetalleRowChanging( this, new TrayectoTipoDetalleRowChangeEvent( ((TrayectoTipoDetalleRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowDeleted( DataRowChangeEventArgs e )
         {
            base.OnRowDeleted( e) ;
            if ( ( this.TrayectoTipoDetalleRowDeleted != null ) )
            {
               this.TrayectoTipoDetalleRowDeleted( this, new TrayectoTipoDetalleRowChangeEvent( ((TrayectoTipoDetalleRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowDeleting( DataRowChangeEventArgs e )
         {
            base.OnRowDeleting( e) ;
            if ( ( this.TrayectoTipoDetalleRowDeleting != null ) )
            {
               this.TrayectoTipoDetalleRowDeleting( this, new TrayectoTipoDetalleRowChangeEvent( ((TrayectoTipoDetalleRow)(e.Row)), e.Action)) ;
            }
         }

      }

      public class TrayectoTipoDetalleRow : DataRow
      {
         private TrayectoTipoDetalleDataTable tableTrayectoTipoDetalle ;
         internal TrayectoTipoDetalleRow( DataRowBuilder rb ) : base(rb)
         {
            this.tableTrayectoTipoDetalle = ((TrayectoTipoDetalleDataTable)(this.Table)) ;
         }

         ///  <summary>
         ///   Gets or sets the Trayecto Tipo Detalle ID.
         ///  </summary>
         public int TrayectoTipoDetalleID
         {
            get {
               return ((int)(this[this.tableTrayectoTipoDetalle.TrayectoTipoDetalleIDColumn])) ;
            }

            set {
               this[this.tableTrayectoTipoDetalle.TrayectoTipoDetalleIDColumn] = value ;
            }

         }

         public bool IsTrayectoTipoDetalleIDNull( )
         {
            return this.IsNull( this.tableTrayectoTipoDetalle.TrayectoTipoDetalleIDColumn) ;
         }

         ///  <summary>
         ///   Gets or sets the Nombre de la categoria.
         ///  </summary>
         public String TTipoDetalleCategoria
         {
            get {
               try
               {
                  return ((String)(this[this.tableTrayectoTipoDetalle.TTipoDetalleCategoriaColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value TTipoDetalleCategoria because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableTrayectoTipoDetalle.TTipoDetalleCategoriaColumn] = value ;
            }

         }

         public bool IsTTipoDetalleCategoriaNull( )
         {
            return this.IsNull( this.tableTrayectoTipoDetalle.TTipoDetalleCategoriaColumn) ;
         }

         public void SetTTipoDetalleCategoriaNull( )
         {
            this[this.tableTrayectoTipoDetalle.TTipoDetalleCategoriaColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the T Tipo Detalle Icono.
         ///  </summary>
         public String TTipoDetalleIcono
         {
            get {
               try
               {
                  return ((String)(this[this.tableTrayectoTipoDetalle.TTipoDetalleIconoColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value TTipoDetalleIcono because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableTrayectoTipoDetalle.TTipoDetalleIconoColumn] = value ;
            }

         }

         public bool IsTTipoDetalleIconoNull( )
         {
            return this.IsNull( this.tableTrayectoTipoDetalle.TTipoDetalleIconoColumn) ;
         }

         public void SetTTipoDetalleIconoNull( )
         {
            this[this.tableTrayectoTipoDetalle.TTipoDetalleIconoColumn] = System.Convert.DBNull ;
         }

      }

      public class TrayectoTipoDetalleRowChangeEvent : EventArgs
      {
         private TrayectoTipoDetalleRow eventRow ;
         private System.Data.DataRowAction eventAction ;
         public TrayectoTipoDetalleRowChangeEvent( TrayectoTipoDetalleRow row ,
                                                   DataRowAction action )
         {
            this.eventRow = row ;
            this.eventAction = action ;
         }

         public TrayectoTipoDetalleRow Row
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
