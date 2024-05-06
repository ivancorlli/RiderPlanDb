
//               File: RolUsuarioDataSet
//        Description: RolUsuario
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
   public partial class RolUsuarioDataSet : System.Data.DataSet
   {
      private RolUsuarioDataTable tableRolUsuario ;
      [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
      public RolUsuarioDataTable RolUsuario
      {
         get {
            return this.tableRolUsuario ;
         }

      }

      private System.Data.SchemaSerializationMode _schemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema;
      
      [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
      public RolUsuarioDataSet() {
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
          RolUsuarioDataSet cln = ((RolUsuarioDataSet)(base.Clone()));
          cln.InitVars();
          return cln;
      }
      
      protected override bool ShouldSerializeTables() {
      	    return false;
      }
      
      protected override bool ShouldSerializeRelations() {
      	    return false;
      }
      
      private bool ShouldSerializeRolUsuario() { 
		return false; 
	  }
              
      protected override void ReadXmlSerializable(XmlReader reader) 
      {
          if ((this.DetermineSchemaSerializationMode(reader) == System.Data.SchemaSerializationMode.IncludeSchema)) 
          {
      		this.Reset();
      		DataSet ds = new DataSet();
              ds.ReadXml(reader);
              if ((ds.Tables["RolUsuario"] != null))  
        { 
			base.Tables.Add(new RolUsuarioDataTable(ds.Tables["RolUsuario"])); 
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
          this.tableRolUsuario = ((RolUsuarioDataTable)(base.Tables["RolUsuario"]));		
		  if ((initTable == true)) { 
			if ((this.tableRolUsuario != null)) { 
				this.tableRolUsuario.InitVars(); 
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
          RolUsuarioDataSet ds = new RolUsuarioDataSet();
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
      protected RolUsuarioDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context, false)
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
              if ((ds.Tables["RolUsuario"] != null))  
        { 
			base.Tables.Add(new RolUsuarioDataTable(ds.Tables["RolUsuario"])); 
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
         this.ExtendedProperties.Add( "DataAdapterName", "RolUsuarioDataAdapter") ;
         this.ExtendedProperties.Add( "BigImage", " ") ;
         this.ExtendedProperties.Add( "SmallImage", " ") ;
         this.ExtendedProperties.Add( "Image", " ") ;
         this.ExtendedProperties.Add( "Deklarit.PermissionBaseId", "2003") ;
         this.ExtendedProperties.Add( "DataSetName", "RolUsuarioDataSet") ;
         this.ExtendedProperties.Add( "DataAdapterInterfaceName", "IRolUsuarioDataAdapter") ;
         this.ExtendedProperties.Add( "ObjectName", "RolUsuario") ;
         this.ExtendedProperties.Add( "ObjectDescription", "RolUsuario") ;
         this.ExtendedProperties.Add( "ObjectType", "BusinessComponent") ;
         this.ExtendedProperties.Add( "ObjectPath", "\\BusinessComponents\\Usuario") ;
         this.ExtendedProperties.Add( "NameSpace", "Raiderplan1") ;
         this.ExtendedProperties.Add( "DataChangeFrequency", "PrettyOften") ;
         this.ExtendedProperties.Add( "CachePriority", "Medium") ;
         this.ExtendedProperties.Add( "Deklarit.AddNewOptionToLowCardinality", "True") ;
         this.ExtendedProperties.Add( "Deklarit.DescriptionAttribute", "") ;
         this.ExtendedProperties.Add( "Deklarit.LowCardinality", "False") ;
      }

      private void InitClassBase( )
      {
         this.DataSetName = "RolUsuarioDataSet" ;
         this.Namespace = "http://www.tempuri.org/RolUsuario" ;
         this.tableRolUsuario = new RolUsuarioDataTable() ;
         this.Tables.Add( this.tableRolUsuario) ;
      }

      public delegate  void RolUsuarioRowChangeEventHandler( object sender ,
                                                             RolUsuarioRowChangeEvent e );
      [Serializable()]
      public partial class RolUsuarioDataTable : DataTable, System.Collections.IEnumerable
      {
         private DataColumn columnRolUsuarioID ;
         private DataColumn columnRol ;
         private DataColumn columnUsuarioID ;
         public RolUsuarioDataTable() 
         {
             this.TableName = "RolUsuario";
             this.BeginInit();
             this.InitClass();
             this.EndInit();
         }
         
         internal RolUsuarioDataTable(System.Data.DataTable table) {
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
         
         public RolUsuarioRow this[int index] {
             get {
                 return ((RolUsuarioRow)(this.Rows[index]));
             }
         }
         
         public virtual System.Collections.IEnumerator GetEnumerator() {
             return this.Rows.GetEnumerator();
         }
         
         public override System.Data.DataTable Clone() {
             RolUsuarioDataTable cln = ((RolUsuarioDataTable)(base.Clone()));
             cln.InitVars();
             return cln;
         }
         
         protected override System.Data.DataTable CreateInstance() {
             return new RolUsuarioDataTable();
         }
         
         public void AddRolUsuarioRow(RolUsuarioRow row) {
             this.Rows.Add(row);
         }
         
         public RolUsuarioRow NewRolUsuarioRow() {
             return ((RolUsuarioRow)(this.NewRow()));
         }
         
         protected override System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder) {
             return new RolUsuarioRow(builder);
         }
         
         protected override System.Type GetRowType() {
             return typeof(RolUsuarioRow);
         }
         
         public void RemoveRolUsuarioRow(RolUsuarioRow row) {
             this.Rows.Remove(row);
         }
         
         public static System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet xs) {
             System.Xml.Schema.XmlSchemaComplexType type = new System.Xml.Schema.XmlSchemaComplexType();
             System.Xml.Schema.XmlSchemaSequence sequence = new System.Xml.Schema.XmlSchemaSequence();
             RolUsuarioDataSet ds = new RolUsuarioDataSet();
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
             attribute2.FixedValue = "RolUsuarioDataTable";
             type.Attributes.Add(attribute2);
             type.Particle = sequence;
             return type;
         }
         protected RolUsuarioDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                 base(info, context) 
         {
             this.InitVars();
         }
         public DataColumn RolUsuarioIDColumn
         {
            get {
               return this.columnRolUsuarioID ;
            }

         }

         public DataColumn RolColumn
         {
            get {
               return this.columnRol ;
            }

         }

         public DataColumn UsuarioIDColumn
         {
            get {
               return this.columnUsuarioID ;
            }

         }

         public event RolUsuarioRowChangeEventHandler RolUsuarioRowChanged ;
         public event RolUsuarioRowChangeEventHandler RolUsuarioRowChanging ;
         public event RolUsuarioRowChangeEventHandler RolUsuarioRowDeleted ;
         public event RolUsuarioRowChangeEventHandler RolUsuarioRowDeleting ;
         public RolUsuarioRow AddRolUsuarioRow( UsuarioRol rol ,
                                                int usuarioID )
         {
            RolUsuarioRow rowRolUsuarioRow = ((RolUsuarioRow)(this.NewRow())) ;
            rowRolUsuarioRow["Rol"] = rol ;
            rowRolUsuarioRow["UsuarioID"] = usuarioID ;
            this.Rows.Add( rowRolUsuarioRow) ;
            return rowRolUsuarioRow ;
         }

         public RolUsuarioRow FindByRolUsuarioID( short rolUsuarioID )
         {
            return ((RolUsuarioRow)(this.Rows.Find(new  object[] {rolUsuarioID}))) ;
         }

         internal void InitVars( )
         {
            this.columnRolUsuarioID = this.Columns["RolUsuarioID"] ;
            this.columnRol = this.Columns["Rol"] ;
            this.columnUsuarioID = this.Columns["UsuarioID"] ;
         }

         public void InitClass( )
         {
            this.columnRolUsuarioID = new DataColumn( "RolUsuarioID", typeof(short), "", System.Data.MappingType.Element) ;
            this.columnRolUsuarioID.AllowDBNull = false ;
            this.columnRolUsuarioID.Caption = "Rol Usuario ID" ;
            this.columnRolUsuarioID.Unique = true ;
            this.columnRolUsuarioID.AutoIncrement = true ;
            this.columnRolUsuarioID.AutoIncrementSeed = -1 ;
            this.columnRolUsuarioID.AutoIncrementStep = -1 ;
            this.columnRolUsuarioID.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnRolUsuarioID.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnRolUsuarioID.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnRolUsuarioID.ExtendedProperties.Add( "AutoNumber", "true") ;
            this.columnRolUsuarioID.ExtendedProperties.Add( "IsKey", "true") ;
            this.columnRolUsuarioID.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnRolUsuarioID.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnRolUsuarioID.ExtendedProperties.Add( "Description", "Rol Usuario ID") ;
            this.columnRolUsuarioID.ExtendedProperties.Add( "Length", "3") ;
            this.columnRolUsuarioID.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnRolUsuarioID.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnRolUsuarioID.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnRolUsuarioID.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnRolUsuarioID.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnRolUsuarioID.ExtendedProperties.Add( "Deklarit.InternalName", "RolUsuarioID") ;
            this.Columns.Add( this.columnRolUsuarioID) ;
            this.columnRol = new DataColumn( "Rol", typeof(short), "", System.Data.MappingType.Element) ;
            this.columnRol.AllowDBNull = false ;
            this.columnRol.Caption = "Rol" ;
            this.columnRol.DefaultValue = System.Convert.DBNull ;
            this.columnRol.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnRol.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnRol.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnRol.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnRol.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnRol.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnRol.ExtendedProperties.Add( "Description", "Rol") ;
            this.columnRol.ExtendedProperties.Add( "Length", "3") ;
            this.columnRol.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnRol.ExtendedProperties.Add( "IsEnumeration", "true") ;
            this.columnRol.ExtendedProperties.Add( "EnumerationType", "UsuarioRol") ;
            this.columnRol.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnRol.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnRol.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnRol.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnRol.ExtendedProperties.Add( "Deklarit.InternalName", "Rol") ;
            this.Columns.Add( this.columnRol) ;
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
            this.PrimaryKey = new  DataColumn[]  {this.columnRolUsuarioID} ;
            this.ExtendedProperties.Add( "ParentLvl", "") ;
            this.ExtendedProperties.Add( "LevelName", "RolUsuario") ;
            this.ExtendedProperties.Add( "Description", "RolUsuario") ;
            this.ExtendedProperties.Add( "msprop:AllowInsert", "true") ;
            this.ExtendedProperties.Add( "msprop:AllowUpdate", "true") ;
            this.ExtendedProperties.Add( "msprop:AllowDelete", "true") ;
            this.ExtendedProperties.Add( "Deklarit.EditInDataGrid", "True") ;
         }

         protected override void OnRowChanged( DataRowChangeEventArgs e )
         {
            base.OnRowChanged( e) ;
            if ( ( this.RolUsuarioRowChanged != null ) )
            {
               this.RolUsuarioRowChanged( this, new RolUsuarioRowChangeEvent( ((RolUsuarioRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowChanging( DataRowChangeEventArgs e )
         {
            base.OnRowChanging( e) ;
            if ( ( this.RolUsuarioRowChanging != null ) )
            {
               this.RolUsuarioRowChanging( this, new RolUsuarioRowChangeEvent( ((RolUsuarioRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowDeleted( DataRowChangeEventArgs e )
         {
            base.OnRowDeleted( e) ;
            if ( ( this.RolUsuarioRowDeleted != null ) )
            {
               this.RolUsuarioRowDeleted( this, new RolUsuarioRowChangeEvent( ((RolUsuarioRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowDeleting( DataRowChangeEventArgs e )
         {
            base.OnRowDeleting( e) ;
            if ( ( this.RolUsuarioRowDeleting != null ) )
            {
               this.RolUsuarioRowDeleting( this, new RolUsuarioRowChangeEvent( ((RolUsuarioRow)(e.Row)), e.Action)) ;
            }
         }

      }

      public class RolUsuarioRow : DataRow
      {
         private RolUsuarioDataTable tableRolUsuario ;
         internal RolUsuarioRow( DataRowBuilder rb ) : base(rb)
         {
            this.tableRolUsuario = ((RolUsuarioDataTable)(this.Table)) ;
         }

         ///  <summary>
         ///   Gets or sets the Rol Usuario ID.
         ///  </summary>
         public short RolUsuarioID
         {
            get {
               return ((short)(this[this.tableRolUsuario.RolUsuarioIDColumn])) ;
            }

            set {
               this[this.tableRolUsuario.RolUsuarioIDColumn] = value ;
            }

         }

         public bool IsRolUsuarioIDNull( )
         {
            return this.IsNull( this.tableRolUsuario.RolUsuarioIDColumn) ;
         }

         ///  <summary>
         ///   Gets or sets the Rol.
         ///  </summary>
         public UsuarioRol Rol
         {
            get {
               try
               {
                  return ((UsuarioRol)(((short)(this[this.tableRolUsuario.RolColumn])))) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value Rol because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableRolUsuario.RolColumn] = ((short)(value)) ;
            }

         }

         public bool IsRolNull( )
         {
            return this.IsNull( this.tableRolUsuario.RolColumn) ;
         }

         public void SetRolNull( )
         {
            this[this.tableRolUsuario.RolColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Usuario ID.
         ///  </summary>
         public int UsuarioID
         {
            get {
               try
               {
                  return ((int)(this[this.tableRolUsuario.UsuarioIDColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value UsuarioID because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableRolUsuario.UsuarioIDColumn] = value ;
            }

         }

         public bool IsUsuarioIDNull( )
         {
            return this.IsNull( this.tableRolUsuario.UsuarioIDColumn) ;
         }

         public void SetUsuarioIDNull( )
         {
            this[this.tableRolUsuario.UsuarioIDColumn] = System.Convert.DBNull ;
         }

      }

      public class RolUsuarioRowChangeEvent : EventArgs
      {
         private RolUsuarioRow eventRow ;
         private System.Data.DataRowAction eventAction ;
         public RolUsuarioRowChangeEvent( RolUsuarioRow row ,
                                          DataRowAction action )
         {
            this.eventRow = row ;
            this.eventAction = action ;
         }

         public RolUsuarioRow Row
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
