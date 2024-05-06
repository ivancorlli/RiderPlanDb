
//               File: UsuarioDataSet
//        Description: Usuario
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
   public partial class UsuarioDataSet : System.Data.DataSet
   {
      private UsuarioDataTable tableUsuario ;
      [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
      public UsuarioDataTable Usuario
      {
         get {
            return this.tableUsuario ;
         }

      }

      private System.Data.SchemaSerializationMode _schemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema;
      
      [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
      public UsuarioDataSet() {
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
          UsuarioDataSet cln = ((UsuarioDataSet)(base.Clone()));
          cln.InitVars();
          return cln;
      }
      
      protected override bool ShouldSerializeTables() {
      	    return false;
      }
      
      protected override bool ShouldSerializeRelations() {
      	    return false;
      }
      
      private bool ShouldSerializeUsuario() { 
		return false; 
	  }
              
      protected override void ReadXmlSerializable(XmlReader reader) 
      {
          if ((this.DetermineSchemaSerializationMode(reader) == System.Data.SchemaSerializationMode.IncludeSchema)) 
          {
      		this.Reset();
      		DataSet ds = new DataSet();
              ds.ReadXml(reader);
              if ((ds.Tables["Usuario"] != null))  
        { 
			base.Tables.Add(new UsuarioDataTable(ds.Tables["Usuario"])); 
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
          this.tableUsuario = ((UsuarioDataTable)(base.Tables["Usuario"]));		
		  if ((initTable == true)) { 
			if ((this.tableUsuario != null)) { 
				this.tableUsuario.InitVars(); 
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
          UsuarioDataSet ds = new UsuarioDataSet();
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
      protected UsuarioDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context, false)
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
              if ((ds.Tables["Usuario"] != null))  
        { 
			base.Tables.Add(new UsuarioDataTable(ds.Tables["Usuario"])); 
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
         this.ExtendedProperties.Add( "DataAdapterName", "UsuarioDataAdapter") ;
         this.ExtendedProperties.Add( "BigImage", " ") ;
         this.ExtendedProperties.Add( "SmallImage", " ") ;
         this.ExtendedProperties.Add( "Image", " ") ;
         this.ExtendedProperties.Add( "Deklarit.PermissionBaseId", "2010") ;
         this.ExtendedProperties.Add( "DataSetName", "UsuarioDataSet") ;
         this.ExtendedProperties.Add( "DataAdapterInterfaceName", "IUsuarioDataAdapter") ;
         this.ExtendedProperties.Add( "ObjectName", "Usuario") ;
         this.ExtendedProperties.Add( "ObjectDescription", "Usuario") ;
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
         this.DataSetName = "UsuarioDataSet" ;
         this.Namespace = "http://www.tempuri.org/Usuario" ;
         this.tableUsuario = new UsuarioDataTable() ;
         this.Tables.Add( this.tableUsuario) ;
      }

      public delegate  void UsuarioRowChangeEventHandler( object sender ,
                                                          UsuarioRowChangeEvent e );
      [Serializable()]
      public partial class UsuarioDataTable : DataTable, System.Collections.IEnumerable
      {
         private DataColumn columnUsuarioID ;
         private DataColumn columnUsuarioNombre ;
         private DataColumn columnUsuarioActivo ;
         private DataColumn columnUsuarioEmail ;
         private DataColumn columnUsuarioPasword ;
         private DataColumn columnUsuarioFechaAlta ;
         private DataColumn columnPersonaID ;
         private DataColumn columnCodigoValidation ;
         public UsuarioDataTable() 
         {
             this.TableName = "Usuario";
             this.BeginInit();
             this.InitClass();
             this.EndInit();
         }
         
         internal UsuarioDataTable(System.Data.DataTable table) {
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
         
         public UsuarioRow this[int index] {
             get {
                 return ((UsuarioRow)(this.Rows[index]));
             }
         }
         
         public virtual System.Collections.IEnumerator GetEnumerator() {
             return this.Rows.GetEnumerator();
         }
         
         public override System.Data.DataTable Clone() {
             UsuarioDataTable cln = ((UsuarioDataTable)(base.Clone()));
             cln.InitVars();
             return cln;
         }
         
         protected override System.Data.DataTable CreateInstance() {
             return new UsuarioDataTable();
         }
         
         public void AddUsuarioRow(UsuarioRow row) {
             this.Rows.Add(row);
         }
         
         public UsuarioRow NewUsuarioRow() {
             return ((UsuarioRow)(this.NewRow()));
         }
         
         protected override System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder) {
             return new UsuarioRow(builder);
         }
         
         protected override System.Type GetRowType() {
             return typeof(UsuarioRow);
         }
         
         public void RemoveUsuarioRow(UsuarioRow row) {
             this.Rows.Remove(row);
         }
         
         public static System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet xs) {
             System.Xml.Schema.XmlSchemaComplexType type = new System.Xml.Schema.XmlSchemaComplexType();
             System.Xml.Schema.XmlSchemaSequence sequence = new System.Xml.Schema.XmlSchemaSequence();
             UsuarioDataSet ds = new UsuarioDataSet();
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
             attribute2.FixedValue = "UsuarioDataTable";
             type.Attributes.Add(attribute2);
             type.Particle = sequence;
             return type;
         }
         protected UsuarioDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                 base(info, context) 
         {
             this.InitVars();
         }
         public DataColumn UsuarioIDColumn
         {
            get {
               return this.columnUsuarioID ;
            }

         }

         public DataColumn UsuarioNombreColumn
         {
            get {
               return this.columnUsuarioNombre ;
            }

         }

         public DataColumn UsuarioActivoColumn
         {
            get {
               return this.columnUsuarioActivo ;
            }

         }

         public DataColumn UsuarioEmailColumn
         {
            get {
               return this.columnUsuarioEmail ;
            }

         }

         public DataColumn UsuarioPaswordColumn
         {
            get {
               return this.columnUsuarioPasword ;
            }

         }

         public DataColumn UsuarioFechaAltaColumn
         {
            get {
               return this.columnUsuarioFechaAlta ;
            }

         }

         public DataColumn PersonaIDColumn
         {
            get {
               return this.columnPersonaID ;
            }

         }

         public DataColumn CodigoValidationColumn
         {
            get {
               return this.columnCodigoValidation ;
            }

         }

         public event UsuarioRowChangeEventHandler UsuarioRowChanged ;
         public event UsuarioRowChangeEventHandler UsuarioRowChanging ;
         public event UsuarioRowChangeEventHandler UsuarioRowDeleted ;
         public event UsuarioRowChangeEventHandler UsuarioRowDeleting ;
         public UsuarioRow AddUsuarioRow( String usuarioNombre ,
                                          String usuarioActivo ,
                                          String usuarioEmail ,
                                          String usuarioPasword ,
                                          DateTime usuarioFechaAlta ,
                                          int personaID ,
                                          String codigoValidation )
         {
            UsuarioRow rowUsuarioRow = ((UsuarioRow)(this.NewRow())) ;
            rowUsuarioRow["UsuarioNombre"] = usuarioNombre ;
            rowUsuarioRow["UsuarioActivo"] = usuarioActivo ;
            rowUsuarioRow["UsuarioEmail"] = usuarioEmail ;
            rowUsuarioRow["UsuarioPasword"] = usuarioPasword ;
            rowUsuarioRow["UsuarioFechaAlta"] = usuarioFechaAlta ;
            rowUsuarioRow["PersonaID"] = personaID ;
            rowUsuarioRow["CodigoValidation"] = codigoValidation ;
            this.Rows.Add( rowUsuarioRow) ;
            return rowUsuarioRow ;
         }

         public UsuarioRow FindByUsuarioID( int usuarioID )
         {
            return ((UsuarioRow)(this.Rows.Find(new  object[] {usuarioID}))) ;
         }

         internal void InitVars( )
         {
            this.columnUsuarioID = this.Columns["UsuarioID"] ;
            this.columnUsuarioNombre = this.Columns["UsuarioNombre"] ;
            this.columnUsuarioActivo = this.Columns["UsuarioActivo"] ;
            this.columnUsuarioEmail = this.Columns["UsuarioEmail"] ;
            this.columnUsuarioPasword = this.Columns["UsuarioPasword"] ;
            this.columnUsuarioFechaAlta = this.Columns["UsuarioFechaAlta"] ;
            this.columnPersonaID = this.Columns["PersonaID"] ;
            this.columnCodigoValidation = this.Columns["CodigoValidation"] ;
         }

         public void InitClass( )
         {
            this.columnUsuarioID = new DataColumn( "UsuarioID", typeof(int), "", System.Data.MappingType.Element) ;
            this.columnUsuarioID.AllowDBNull = false ;
            this.columnUsuarioID.Caption = "Usuario ID" ;
            this.columnUsuarioID.Unique = true ;
            this.columnUsuarioID.AutoIncrement = true ;
            this.columnUsuarioID.AutoIncrementSeed = -1 ;
            this.columnUsuarioID.AutoIncrementStep = -1 ;
            this.columnUsuarioID.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnUsuarioID.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnUsuarioID.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnUsuarioID.ExtendedProperties.Add( "AutoNumber", "true") ;
            this.columnUsuarioID.ExtendedProperties.Add( "IsKey", "true") ;
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
            this.columnUsuarioNombre = new DataColumn( "UsuarioNombre", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnUsuarioNombre.AllowDBNull = false ;
            this.columnUsuarioNombre.Caption = "Usuario Nombre" ;
            this.columnUsuarioNombre.MaxLength = 50 ;
            this.columnUsuarioNombre.DefaultValue = System.Convert.DBNull ;
            this.columnUsuarioNombre.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnUsuarioNombre.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnUsuarioNombre.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnUsuarioNombre.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnUsuarioNombre.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnUsuarioNombre.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnUsuarioNombre.ExtendedProperties.Add( "Description", "Usuario Nombre") ;
            this.columnUsuarioNombre.ExtendedProperties.Add( "Length", "50") ;
            this.columnUsuarioNombre.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnUsuarioNombre.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnUsuarioNombre.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnUsuarioNombre.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnUsuarioNombre.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnUsuarioNombre.ExtendedProperties.Add( "Deklarit.InternalName", "UsuarioNombre") ;
            this.Columns.Add( this.columnUsuarioNombre) ;
            this.columnUsuarioActivo = new DataColumn( "UsuarioActivo", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnUsuarioActivo.AllowDBNull = false ;
            this.columnUsuarioActivo.Caption = "Usuario Activo" ;
            this.columnUsuarioActivo.MaxLength = 1 ;
            this.columnUsuarioActivo.DefaultValue = System.Convert.DBNull ;
            this.columnUsuarioActivo.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnUsuarioActivo.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnUsuarioActivo.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnUsuarioActivo.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnUsuarioActivo.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnUsuarioActivo.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnUsuarioActivo.ExtendedProperties.Add( "Description", "Usuario Activo") ;
            this.columnUsuarioActivo.ExtendedProperties.Add( "Length", "1") ;
            this.columnUsuarioActivo.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnUsuarioActivo.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnUsuarioActivo.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnUsuarioActivo.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnUsuarioActivo.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnUsuarioActivo.ExtendedProperties.Add( "Deklarit.InternalName", "UsuarioActivo") ;
            this.Columns.Add( this.columnUsuarioActivo) ;
            this.columnUsuarioEmail = new DataColumn( "UsuarioEmail", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnUsuarioEmail.AllowDBNull = false ;
            this.columnUsuarioEmail.Caption = "Usuario Email" ;
            this.columnUsuarioEmail.MaxLength = 60 ;
            this.columnUsuarioEmail.DefaultValue = System.Convert.DBNull ;
            this.columnUsuarioEmail.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnUsuarioEmail.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnUsuarioEmail.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnUsuarioEmail.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnUsuarioEmail.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnUsuarioEmail.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnUsuarioEmail.ExtendedProperties.Add( "Description", "Usuario Email") ;
            this.columnUsuarioEmail.ExtendedProperties.Add( "Length", "60") ;
            this.columnUsuarioEmail.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnUsuarioEmail.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnUsuarioEmail.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnUsuarioEmail.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnUsuarioEmail.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnUsuarioEmail.ExtendedProperties.Add( "Deklarit.InternalName", "UsuarioEmail") ;
            this.Columns.Add( this.columnUsuarioEmail) ;
            this.columnUsuarioPasword = new DataColumn( "UsuarioPasword", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnUsuarioPasword.AllowDBNull = false ;
            this.columnUsuarioPasword.Caption = "Usuario Pasword" ;
            this.columnUsuarioPasword.MaxLength = 70 ;
            this.columnUsuarioPasword.DefaultValue = System.Convert.DBNull ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "Description", "Usuario Pasword") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "Length", "70") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "Deklarit.InternalName", "UsuarioPasword") ;
            this.Columns.Add( this.columnUsuarioPasword) ;
            this.columnUsuarioFechaAlta = new DataColumn( "UsuarioFechaAlta", typeof(DateTime), "", System.Data.MappingType.Element) ;
            this.columnUsuarioFechaAlta.AllowDBNull = false ;
            this.columnUsuarioFechaAlta.Caption = "Usuario Fecha Alta" ;
            this.columnUsuarioFechaAlta.DefaultValue = System.Convert.DBNull ;
            this.columnUsuarioFechaAlta.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnUsuarioFechaAlta.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnUsuarioFechaAlta.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnUsuarioFechaAlta.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnUsuarioFechaAlta.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnUsuarioFechaAlta.ExtendedProperties.Add( "DeklaritType", "date") ;
            this.columnUsuarioFechaAlta.ExtendedProperties.Add( "Description", "Usuario Fecha Alta") ;
            this.columnUsuarioFechaAlta.ExtendedProperties.Add( "Length", "8") ;
            this.columnUsuarioFechaAlta.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnUsuarioFechaAlta.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnUsuarioFechaAlta.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnUsuarioFechaAlta.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnUsuarioFechaAlta.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnUsuarioFechaAlta.ExtendedProperties.Add( "Deklarit.InternalName", "UsuarioFechaAlta") ;
            this.Columns.Add( this.columnUsuarioFechaAlta) ;
            this.columnPersonaID = new DataColumn( "PersonaID", typeof(int), "", System.Data.MappingType.Element) ;
            this.columnPersonaID.AllowDBNull = false ;
            this.columnPersonaID.Caption = "Persona ID" ;
            this.columnPersonaID.DefaultValue = System.Convert.DBNull ;
            this.columnPersonaID.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnPersonaID.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnPersonaID.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnPersonaID.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnPersonaID.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnPersonaID.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnPersonaID.ExtendedProperties.Add( "Description", "Persona ID") ;
            this.columnPersonaID.ExtendedProperties.Add( "Length", "8") ;
            this.columnPersonaID.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnPersonaID.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnPersonaID.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnPersonaID.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnPersonaID.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnPersonaID.ExtendedProperties.Add( "Deklarit.InternalName", "PersonaID") ;
            this.Columns.Add( this.columnPersonaID) ;
            this.columnCodigoValidation = new DataColumn( "CodigoValidation", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnCodigoValidation.AllowDBNull = true ;
            this.columnCodigoValidation.Caption = "Codigo Validation" ;
            this.columnCodigoValidation.MaxLength = 4 ;
            this.columnCodigoValidation.DefaultValue = System.Convert.DBNull ;
            this.columnCodigoValidation.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnCodigoValidation.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnCodigoValidation.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnCodigoValidation.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnCodigoValidation.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnCodigoValidation.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnCodigoValidation.ExtendedProperties.Add( "Description", "Codigo Validation") ;
            this.columnCodigoValidation.ExtendedProperties.Add( "Length", "4") ;
            this.columnCodigoValidation.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnCodigoValidation.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnCodigoValidation.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnCodigoValidation.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnCodigoValidation.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnCodigoValidation.ExtendedProperties.Add( "Deklarit.InternalName", "CodigoValidation") ;
            this.Columns.Add( this.columnCodigoValidation) ;
            this.PrimaryKey = new  DataColumn[]  {this.columnUsuarioID} ;
            this.ExtendedProperties.Add( "ParentLvl", "") ;
            this.ExtendedProperties.Add( "LevelName", "Usuario") ;
            this.ExtendedProperties.Add( "Description", "Usuario") ;
            this.ExtendedProperties.Add( "msprop:AllowInsert", "true") ;
            this.ExtendedProperties.Add( "msprop:AllowUpdate", "true") ;
            this.ExtendedProperties.Add( "msprop:AllowDelete", "true") ;
            this.ExtendedProperties.Add( "Deklarit.EditInDataGrid", "True") ;
         }

         protected override void OnRowChanged( DataRowChangeEventArgs e )
         {
            base.OnRowChanged( e) ;
            if ( ( this.UsuarioRowChanged != null ) )
            {
               this.UsuarioRowChanged( this, new UsuarioRowChangeEvent( ((UsuarioRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowChanging( DataRowChangeEventArgs e )
         {
            base.OnRowChanging( e) ;
            if ( ( this.UsuarioRowChanging != null ) )
            {
               this.UsuarioRowChanging( this, new UsuarioRowChangeEvent( ((UsuarioRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowDeleted( DataRowChangeEventArgs e )
         {
            base.OnRowDeleted( e) ;
            if ( ( this.UsuarioRowDeleted != null ) )
            {
               this.UsuarioRowDeleted( this, new UsuarioRowChangeEvent( ((UsuarioRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowDeleting( DataRowChangeEventArgs e )
         {
            base.OnRowDeleting( e) ;
            if ( ( this.UsuarioRowDeleting != null ) )
            {
               this.UsuarioRowDeleting( this, new UsuarioRowChangeEvent( ((UsuarioRow)(e.Row)), e.Action)) ;
            }
         }

      }

      public class UsuarioRow : DataRow
      {
         private UsuarioDataTable tableUsuario ;
         internal UsuarioRow( DataRowBuilder rb ) : base(rb)
         {
            this.tableUsuario = ((UsuarioDataTable)(this.Table)) ;
         }

         ///  <summary>
         ///   Gets or sets the Usuario ID.
         ///  </summary>
         public int UsuarioID
         {
            get {
               return ((int)(this[this.tableUsuario.UsuarioIDColumn])) ;
            }

            set {
               this[this.tableUsuario.UsuarioIDColumn] = value ;
            }

         }

         public bool IsUsuarioIDNull( )
         {
            return this.IsNull( this.tableUsuario.UsuarioIDColumn) ;
         }

         ///  <summary>
         ///   Gets or sets the Usuario Nombre.
         ///  </summary>
         public String UsuarioNombre
         {
            get {
               try
               {
                  return ((String)(this[this.tableUsuario.UsuarioNombreColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value UsuarioNombre because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableUsuario.UsuarioNombreColumn] = value ;
            }

         }

         public bool IsUsuarioNombreNull( )
         {
            return this.IsNull( this.tableUsuario.UsuarioNombreColumn) ;
         }

         public void SetUsuarioNombreNull( )
         {
            this[this.tableUsuario.UsuarioNombreColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Usuario Activo.
         ///  </summary>
         public String UsuarioActivo
         {
            get {
               try
               {
                  return ((String)(this[this.tableUsuario.UsuarioActivoColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value UsuarioActivo because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableUsuario.UsuarioActivoColumn] = value ;
            }

         }

         public bool IsUsuarioActivoNull( )
         {
            return this.IsNull( this.tableUsuario.UsuarioActivoColumn) ;
         }

         public void SetUsuarioActivoNull( )
         {
            this[this.tableUsuario.UsuarioActivoColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Usuario Email.
         ///  </summary>
         public String UsuarioEmail
         {
            get {
               try
               {
                  return ((String)(this[this.tableUsuario.UsuarioEmailColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value UsuarioEmail because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableUsuario.UsuarioEmailColumn] = value ;
            }

         }

         public bool IsUsuarioEmailNull( )
         {
            return this.IsNull( this.tableUsuario.UsuarioEmailColumn) ;
         }

         public void SetUsuarioEmailNull( )
         {
            this[this.tableUsuario.UsuarioEmailColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Usuario Pasword.
         ///  </summary>
         public String UsuarioPasword
         {
            get {
               try
               {
                  return ((String)(this[this.tableUsuario.UsuarioPaswordColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value UsuarioPasword because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableUsuario.UsuarioPaswordColumn] = value ;
            }

         }

         public bool IsUsuarioPaswordNull( )
         {
            return this.IsNull( this.tableUsuario.UsuarioPaswordColumn) ;
         }

         public void SetUsuarioPaswordNull( )
         {
            this[this.tableUsuario.UsuarioPaswordColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Usuario Fecha Alta.
         ///  </summary>
         public DateTime UsuarioFechaAlta
         {
            get {
               try
               {
                  return ((DateTime)(this[this.tableUsuario.UsuarioFechaAltaColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value UsuarioFechaAlta because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableUsuario.UsuarioFechaAltaColumn] = value ;
            }

         }

         public bool IsUsuarioFechaAltaNull( )
         {
            return this.IsNull( this.tableUsuario.UsuarioFechaAltaColumn) ;
         }

         public void SetUsuarioFechaAltaNull( )
         {
            this[this.tableUsuario.UsuarioFechaAltaColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Persona ID.
         ///  </summary>
         public int PersonaID
         {
            get {
               try
               {
                  return ((int)(this[this.tableUsuario.PersonaIDColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value PersonaID because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableUsuario.PersonaIDColumn] = value ;
            }

         }

         public bool IsPersonaIDNull( )
         {
            return this.IsNull( this.tableUsuario.PersonaIDColumn) ;
         }

         public void SetPersonaIDNull( )
         {
            this[this.tableUsuario.PersonaIDColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Codigo Validation.
         ///  </summary>
         public String CodigoValidation
         {
            get {
               try
               {
                  return ((String)(this[this.tableUsuario.CodigoValidationColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value CodigoValidation because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableUsuario.CodigoValidationColumn] = value ;
            }

         }

         public bool IsCodigoValidationNull( )
         {
            return this.IsNull( this.tableUsuario.CodigoValidationColumn) ;
         }

         public void SetCodigoValidationNull( )
         {
            this[this.tableUsuario.CodigoValidationColumn] = System.Convert.DBNull ;
         }

      }

      public class UsuarioRowChangeEvent : EventArgs
      {
         private UsuarioRow eventRow ;
         private System.Data.DataRowAction eventAction ;
         public UsuarioRowChangeEvent( UsuarioRow row ,
                                       DataRowAction action )
         {
            this.eventRow = row ;
            this.eventAction = action ;
         }

         public UsuarioRow Row
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
