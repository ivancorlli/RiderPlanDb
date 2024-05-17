
//               File: dpUsuarioXEmailXusuarioIDCollectionDataSet
//        Description: dpUsuarioXEmailXusuarioIDCollection
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5_0.002
//       Program type: Deklarit Data Provider
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   using System;
   using System.Collections;
   using System.Data;
   using System.Data.SqlClient;
   using System.Data.Common;
   using System.Threading;
   using System.Xml.Serialization;
   using System.Xml;
   using System.Configuration;
   using System.Data.SqlTypes;
   [Serializable()]
   public partial class dpUsuarioXEmailXusuarioIDCollectionDataSet : System.Data.DataSet
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
      public dpUsuarioXEmailXusuarioIDCollectionDataSet() {
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
          dpUsuarioXEmailXusuarioIDCollectionDataSet cln = ((dpUsuarioXEmailXusuarioIDCollectionDataSet)(base.Clone()));
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
          dpUsuarioXEmailXusuarioIDCollectionDataSet ds = new dpUsuarioXEmailXusuarioIDCollectionDataSet();
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
      protected dpUsuarioXEmailXusuarioIDCollectionDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context, false)
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
         this.ExtendedProperties.Add( "DataAdapterName", "dpUsuarioXEmailXusuarioIDCollectionDataAdapter") ;
         this.ExtendedProperties.Add( "BigImage", " ") ;
         this.ExtendedProperties.Add( "SmallImage", " ") ;
         this.ExtendedProperties.Add( "Image", " ") ;
         this.ExtendedProperties.Add( "Deklarit.PermissionBaseId", "2007") ;
         this.ExtendedProperties.Add( "DataSetName", "dpUsuarioXEmailXusuarioIDCollectionDataSet") ;
         this.ExtendedProperties.Add( "DataAdapterInterfaceName", "IdpUsuarioXEmailXusuarioIDCollectionDataAdapter") ;
         this.ExtendedProperties.Add( "ObjectName", "dpUsuarioXEmailXusuarioIDCollection") ;
         this.ExtendedProperties.Add( "ObjectDescription", "dpUsuarioXEmailXusuarioIDCollection") ;
         this.ExtendedProperties.Add( "ObjectType", "DataProvider") ;
         this.ExtendedProperties.Add( "ObjectPath", "\\DataProviders\\dpUsuario") ;
         this.ExtendedProperties.Add( "NameSpace", "Raiderplan1") ;
         this.ExtendedProperties.Add( "DataChangeFrequency", "PrettyOften") ;
         this.ExtendedProperties.Add( "CachePriority", "Medium") ;
         this.ExtendedProperties.Add( "DefaultBusinessComponent", "Usuario") ;
         this.ExtendedProperties.Add( "Deklarit.BCForNewOption", "") ;
         this.ExtendedProperties.Add( "Deklarit.DescriptionAttribute", "") ;
         this.ExtendedProperties.Add( "Deklarit.LowCardinality", "False") ;
      }

      private void InitClassBase( )
      {
         this.DataSetName = "dpUsuarioXEmailXusuarioIDCollectionDataSet" ;
         this.Namespace = "http://www.tempuri.org/dpUsuarioXEmailXusuarioIDCollection" ;
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
         private DataColumn columnUsuarioEmail ;
         private DataColumn columnUsuarioPasword ;
         private DataColumn columnUsuarioActivo ;
         private DataColumn columnPersonaID ;
         private DataColumn columnPersonaApellido ;
         private DataColumn columnPersonaNombre ;
         private DataColumn columnCodigoValidation ;
         private DataColumn columnCodigoRecuperacion ;
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
             dpUsuarioXEmailXusuarioIDCollectionDataSet ds = new dpUsuarioXEmailXusuarioIDCollectionDataSet();
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

         public DataColumn UsuarioActivoColumn
         {
            get {
               return this.columnUsuarioActivo ;
            }

         }

         public DataColumn PersonaIDColumn
         {
            get {
               return this.columnPersonaID ;
            }

         }

         public DataColumn PersonaApellidoColumn
         {
            get {
               return this.columnPersonaApellido ;
            }

         }

         public DataColumn PersonaNombreColumn
         {
            get {
               return this.columnPersonaNombre ;
            }

         }

         public DataColumn CodigoValidationColumn
         {
            get {
               return this.columnCodigoValidation ;
            }

         }

         public DataColumn CodigoRecuperacionColumn
         {
            get {
               return this.columnCodigoRecuperacion ;
            }

         }

         public event UsuarioRowChangeEventHandler UsuarioRowChanged ;
         public event UsuarioRowChangeEventHandler UsuarioRowChanging ;
         public event UsuarioRowChangeEventHandler UsuarioRowDeleted ;
         public event UsuarioRowChangeEventHandler UsuarioRowDeleting ;
         public UsuarioRow AddUsuarioRow( int usuarioID ,
                                          String usuarioNombre ,
                                          String usuarioEmail ,
                                          String usuarioPasword ,
                                          String usuarioActivo ,
                                          int personaID ,
                                          String personaApellido ,
                                          String personaNombre ,
                                          String codigoValidation ,
                                          String codigoRecuperacion )
         {
            UsuarioRow rowUsuarioRow = ((UsuarioRow)(this.NewRow())) ;
            rowUsuarioRow.ItemArray = new   object[]  {usuarioID, usuarioNombre, usuarioEmail, usuarioPasword, usuarioActivo, personaID, personaApellido, personaNombre, codigoValidation, codigoRecuperacion} ;
            this.Rows.Add( rowUsuarioRow) ;
            return rowUsuarioRow ;
         }

         internal void InitVars( )
         {
            this.columnUsuarioID = this.Columns["UsuarioID"] ;
            this.columnUsuarioNombre = this.Columns["UsuarioNombre"] ;
            this.columnUsuarioEmail = this.Columns["UsuarioEmail"] ;
            this.columnUsuarioPasword = this.Columns["UsuarioPasword"] ;
            this.columnUsuarioActivo = this.Columns["UsuarioActivo"] ;
            this.columnPersonaID = this.Columns["PersonaID"] ;
            this.columnPersonaApellido = this.Columns["PersonaApellido"] ;
            this.columnPersonaNombre = this.Columns["PersonaNombre"] ;
            this.columnCodigoValidation = this.Columns["CodigoValidation"] ;
            this.columnCodigoRecuperacion = this.Columns["CodigoRecuperacion"] ;
         }

         public void InitClass( )
         {
            this.columnUsuarioID = new DataColumn( "UsuarioID", typeof(int), "", System.Data.MappingType.Element) ;
            this.columnUsuarioID.Caption = "Usuario ID" ;
            this.columnUsuarioID.DefaultValue = System.Convert.DBNull ;
            this.columnUsuarioID.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnUsuarioID.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnUsuarioID.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnUsuarioID.ExtendedProperties.Add( "AutoNumber", "true") ;
            this.columnUsuarioID.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnUsuarioID.ExtendedProperties.Add( "ReadOnly", "true") ;
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
            this.columnUsuarioNombre.Caption = "Usuario Nombre" ;
            this.columnUsuarioNombre.MaxLength = 50 ;
            this.columnUsuarioNombre.DefaultValue = System.Convert.DBNull ;
            this.columnUsuarioNombre.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnUsuarioNombre.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnUsuarioNombre.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnUsuarioNombre.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnUsuarioNombre.ExtendedProperties.Add( "ReadOnly", "true") ;
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
            this.columnUsuarioEmail = new DataColumn( "UsuarioEmail", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnUsuarioEmail.Caption = "Usuario Email" ;
            this.columnUsuarioEmail.MaxLength = 60 ;
            this.columnUsuarioEmail.DefaultValue = System.Convert.DBNull ;
            this.columnUsuarioEmail.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnUsuarioEmail.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnUsuarioEmail.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnUsuarioEmail.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnUsuarioEmail.ExtendedProperties.Add( "ReadOnly", "true") ;
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
            this.columnUsuarioPasword.Caption = "Usuario Pasword" ;
            this.columnUsuarioPasword.MaxLength = 70 ;
            this.columnUsuarioPasword.DefaultValue = System.Convert.DBNull ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "ReadOnly", "true") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "Description", "Usuario Pasword") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "Length", "70") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnUsuarioPasword.ExtendedProperties.Add( "Deklarit.InternalName", "UsuarioPasword") ;
            this.Columns.Add( this.columnUsuarioPasword) ;
            this.columnUsuarioActivo = new DataColumn( "UsuarioActivo", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnUsuarioActivo.Caption = "Usuario Activo" ;
            this.columnUsuarioActivo.MaxLength = 1 ;
            this.columnUsuarioActivo.DefaultValue = System.Convert.DBNull ;
            this.columnUsuarioActivo.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnUsuarioActivo.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnUsuarioActivo.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnUsuarioActivo.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnUsuarioActivo.ExtendedProperties.Add( "ReadOnly", "true") ;
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
            this.columnPersonaID = new DataColumn( "PersonaID", typeof(int), "", System.Data.MappingType.Element) ;
            this.columnPersonaID.Caption = "Persona ID" ;
            this.columnPersonaID.DefaultValue = System.Convert.DBNull ;
            this.columnPersonaID.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnPersonaID.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnPersonaID.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnPersonaID.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnPersonaID.ExtendedProperties.Add( "ReadOnly", "true") ;
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
            this.columnPersonaApellido = new DataColumn( "PersonaApellido", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnPersonaApellido.Caption = "Persona Apellido" ;
            this.columnPersonaApellido.MaxLength = 120 ;
            this.columnPersonaApellido.DefaultValue = System.Convert.DBNull ;
            this.columnPersonaApellido.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "ReadOnly", "true") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "Description", "Persona Apellido") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "Length", "120") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "Deklarit.InternalName", "PersonaApellido") ;
            this.Columns.Add( this.columnPersonaApellido) ;
            this.columnPersonaNombre = new DataColumn( "PersonaNombre", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnPersonaNombre.Caption = "Persona Nombre" ;
            this.columnPersonaNombre.MaxLength = 120 ;
            this.columnPersonaNombre.DefaultValue = System.Convert.DBNull ;
            this.columnPersonaNombre.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "ReadOnly", "true") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "Description", "Persona Nombre") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "Length", "120") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "Deklarit.InternalName", "PersonaNombre") ;
            this.Columns.Add( this.columnPersonaNombre) ;
            this.columnCodigoValidation = new DataColumn( "CodigoValidation", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnCodigoValidation.Caption = "Codigo Validation" ;
            this.columnCodigoValidation.MaxLength = 4 ;
            this.columnCodigoValidation.DefaultValue = System.Convert.DBNull ;
            this.columnCodigoValidation.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnCodigoValidation.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnCodigoValidation.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnCodigoValidation.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnCodigoValidation.ExtendedProperties.Add( "ReadOnly", "true") ;
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
            this.columnCodigoRecuperacion = new DataColumn( "CodigoRecuperacion", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnCodigoRecuperacion.Caption = "Codigo Recuperacion" ;
            this.columnCodigoRecuperacion.MaxLength = 4 ;
            this.columnCodigoRecuperacion.DefaultValue = System.Convert.DBNull ;
            this.columnCodigoRecuperacion.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnCodigoRecuperacion.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnCodigoRecuperacion.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnCodigoRecuperacion.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnCodigoRecuperacion.ExtendedProperties.Add( "ReadOnly", "true") ;
            this.columnCodigoRecuperacion.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnCodigoRecuperacion.ExtendedProperties.Add( "Description", "Codigo Recuperacion") ;
            this.columnCodigoRecuperacion.ExtendedProperties.Add( "Length", "4") ;
            this.columnCodigoRecuperacion.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnCodigoRecuperacion.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnCodigoRecuperacion.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnCodigoRecuperacion.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnCodigoRecuperacion.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnCodigoRecuperacion.ExtendedProperties.Add( "Deklarit.InternalName", "CodigoRecuperacion") ;
            this.Columns.Add( this.columnCodigoRecuperacion) ;
            this.ExtendedProperties.Add( "ParentLvl", "") ;
            this.ExtendedProperties.Add( "LevelName", "dpUsuarioXEmailXusuarioIDCollection") ;
            this.ExtendedProperties.Add( "Description", "Usuario") ;
            this.ExtendedProperties.Add( "HasOrder", "true") ;
            this.ExtendedProperties.Add( "OrderAttributes", "") ;
            this.ExtendedProperties.Add( "Deklarit.NumberOfRows", "0") ;
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
               try
               {
                  return ((int)(this[this.tableUsuario.UsuarioIDColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value UsuarioID because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableUsuario.UsuarioIDColumn] = value ;
            }

         }

         public bool IsUsuarioIDNull( )
         {
            return this.IsNull( this.tableUsuario.UsuarioIDColumn) ;
         }

         public void SetUsuarioIDNull( )
         {
            this[this.tableUsuario.UsuarioIDColumn] = System.Convert.DBNull ;
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
         ///   Gets or sets the Persona Apellido.
         ///  </summary>
         public String PersonaApellido
         {
            get {
               try
               {
                  return ((String)(this[this.tableUsuario.PersonaApellidoColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value PersonaApellido because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableUsuario.PersonaApellidoColumn] = value ;
            }

         }

         public bool IsPersonaApellidoNull( )
         {
            return this.IsNull( this.tableUsuario.PersonaApellidoColumn) ;
         }

         public void SetPersonaApellidoNull( )
         {
            this[this.tableUsuario.PersonaApellidoColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Persona Nombre.
         ///  </summary>
         public String PersonaNombre
         {
            get {
               try
               {
                  return ((String)(this[this.tableUsuario.PersonaNombreColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value PersonaNombre because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableUsuario.PersonaNombreColumn] = value ;
            }

         }

         public bool IsPersonaNombreNull( )
         {
            return this.IsNull( this.tableUsuario.PersonaNombreColumn) ;
         }

         public void SetPersonaNombreNull( )
         {
            this[this.tableUsuario.PersonaNombreColumn] = System.Convert.DBNull ;
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

         ///  <summary>
         ///   Gets or sets the Codigo Recuperacion.
         ///  </summary>
         public String CodigoRecuperacion
         {
            get {
               try
               {
                  return ((String)(this[this.tableUsuario.CodigoRecuperacionColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value CodigoRecuperacion because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tableUsuario.CodigoRecuperacionColumn] = value ;
            }

         }

         public bool IsCodigoRecuperacionNull( )
         {
            return this.IsNull( this.tableUsuario.CodigoRecuperacionColumn) ;
         }

         public void SetCodigoRecuperacionNull( )
         {
            this[this.tableUsuario.CodigoRecuperacionColumn] = System.Convert.DBNull ;
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
