
//               File: PersonaDataSet
//        Description: Persona
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
   public partial class PersonaDataSet : System.Data.DataSet
   {
      private PersonaDataTable tablePersona ;
      [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
      public PersonaDataTable Persona
      {
         get {
            return this.tablePersona ;
         }

      }

      private System.Data.SchemaSerializationMode _schemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema;
      
      [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
      public PersonaDataSet() {
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
          PersonaDataSet cln = ((PersonaDataSet)(base.Clone()));
          cln.InitVars();
          return cln;
      }
      
      protected override bool ShouldSerializeTables() {
      	    return false;
      }
      
      protected override bool ShouldSerializeRelations() {
      	    return false;
      }
      
      private bool ShouldSerializePersona() { 
		return false; 
	  }
              
      protected override void ReadXmlSerializable(XmlReader reader) 
      {
          if ((this.DetermineSchemaSerializationMode(reader) == System.Data.SchemaSerializationMode.IncludeSchema)) 
          {
      		this.Reset();
      		DataSet ds = new DataSet();
              ds.ReadXml(reader);
              if ((ds.Tables["Persona"] != null))  
        { 
			base.Tables.Add(new PersonaDataTable(ds.Tables["Persona"])); 
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
          this.tablePersona = ((PersonaDataTable)(base.Tables["Persona"]));		
		  if ((initTable == true)) { 
			if ((this.tablePersona != null)) { 
				this.tablePersona.InitVars(); 
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
          PersonaDataSet ds = new PersonaDataSet();
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
      protected PersonaDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context, false)
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
              if ((ds.Tables["Persona"] != null))  
        { 
			base.Tables.Add(new PersonaDataTable(ds.Tables["Persona"])); 
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
         this.ExtendedProperties.Add( "DataAdapterName", "PersonaDataAdapter") ;
         this.ExtendedProperties.Add( "BigImage", " ") ;
         this.ExtendedProperties.Add( "SmallImage", " ") ;
         this.ExtendedProperties.Add( "Image", " ") ;
         this.ExtendedProperties.Add( "Deklarit.PermissionBaseId", "2001") ;
         this.ExtendedProperties.Add( "DataSetName", "PersonaDataSet") ;
         this.ExtendedProperties.Add( "DataAdapterInterfaceName", "IPersonaDataAdapter") ;
         this.ExtendedProperties.Add( "ObjectName", "Persona") ;
         this.ExtendedProperties.Add( "ObjectDescription", "Persona") ;
         this.ExtendedProperties.Add( "ObjectType", "BusinessComponent") ;
         this.ExtendedProperties.Add( "ObjectPath", "\\BusinessComponents\\Persona") ;
         this.ExtendedProperties.Add( "NameSpace", "Raiderplan1") ;
         this.ExtendedProperties.Add( "DataChangeFrequency", "PrettyOften") ;
         this.ExtendedProperties.Add( "CachePriority", "Medium") ;
         this.ExtendedProperties.Add( "Deklarit.AddNewOptionToLowCardinality", "True") ;
         this.ExtendedProperties.Add( "Deklarit.DescriptionAttribute", "") ;
         this.ExtendedProperties.Add( "Deklarit.LowCardinality", "False") ;
      }

      private void InitClassBase( )
      {
         this.DataSetName = "PersonaDataSet" ;
         this.Namespace = "http://www.tempuri.org/Persona" ;
         this.tablePersona = new PersonaDataTable() ;
         this.Tables.Add( this.tablePersona) ;
      }

      public delegate  void PersonaRowChangeEventHandler( object sender ,
                                                          PersonaRowChangeEvent e );
      [Serializable()]
      public partial class PersonaDataTable : DataTable, System.Collections.IEnumerable
      {
         private DataColumn columnPersonaID ;
         private DataColumn columnPersonaNombre ;
         private DataColumn columnPersonaApellido ;
         private DataColumn columnPersonaFechaNacimiento ;
         private DataColumn columnPersonaSexo ;
         private DataColumn columnPLocalidadID ;
         private DataColumn columnPProvinciaID ;
         private DataColumn columnImagenPerfil ;
         public PersonaDataTable() 
         {
             this.TableName = "Persona";
             this.BeginInit();
             this.InitClass();
             this.EndInit();
         }
         
         internal PersonaDataTable(System.Data.DataTable table) {
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
         
         public PersonaRow this[int index] {
             get {
                 return ((PersonaRow)(this.Rows[index]));
             }
         }
         
         public virtual System.Collections.IEnumerator GetEnumerator() {
             return this.Rows.GetEnumerator();
         }
         
         public override System.Data.DataTable Clone() {
             PersonaDataTable cln = ((PersonaDataTable)(base.Clone()));
             cln.InitVars();
             return cln;
         }
         
         protected override System.Data.DataTable CreateInstance() {
             return new PersonaDataTable();
         }
         
         public void AddPersonaRow(PersonaRow row) {
             this.Rows.Add(row);
         }
         
         public PersonaRow NewPersonaRow() {
             return ((PersonaRow)(this.NewRow()));
         }
         
         protected override System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder) {
             return new PersonaRow(builder);
         }
         
         protected override System.Type GetRowType() {
             return typeof(PersonaRow);
         }
         
         public void RemovePersonaRow(PersonaRow row) {
             this.Rows.Remove(row);
         }
         
         public static System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet xs) {
             System.Xml.Schema.XmlSchemaComplexType type = new System.Xml.Schema.XmlSchemaComplexType();
             System.Xml.Schema.XmlSchemaSequence sequence = new System.Xml.Schema.XmlSchemaSequence();
             PersonaDataSet ds = new PersonaDataSet();
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
             attribute2.FixedValue = "PersonaDataTable";
             type.Attributes.Add(attribute2);
             type.Particle = sequence;
             return type;
         }
         protected PersonaDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                 base(info, context) 
         {
             this.InitVars();
         }
         public DataColumn PersonaIDColumn
         {
            get {
               return this.columnPersonaID ;
            }

         }

         public DataColumn PersonaNombreColumn
         {
            get {
               return this.columnPersonaNombre ;
            }

         }

         public DataColumn PersonaApellidoColumn
         {
            get {
               return this.columnPersonaApellido ;
            }

         }

         public DataColumn PersonaFechaNacimientoColumn
         {
            get {
               return this.columnPersonaFechaNacimiento ;
            }

         }

         public DataColumn PersonaSexoColumn
         {
            get {
               return this.columnPersonaSexo ;
            }

         }

         public DataColumn PLocalidadIDColumn
         {
            get {
               return this.columnPLocalidadID ;
            }

         }

         public DataColumn PProvinciaIDColumn
         {
            get {
               return this.columnPProvinciaID ;
            }

         }

         public DataColumn ImagenPerfilColumn
         {
            get {
               return this.columnImagenPerfil ;
            }

         }

         public event PersonaRowChangeEventHandler PersonaRowChanged ;
         public event PersonaRowChangeEventHandler PersonaRowChanging ;
         public event PersonaRowChangeEventHandler PersonaRowDeleted ;
         public event PersonaRowChangeEventHandler PersonaRowDeleting ;
         public PersonaRow AddPersonaRow( String personaNombre ,
                                          String personaApellido ,
                                          DateTime personaFechaNacimiento ,
                                          Sexo personaSexo ,
                                          int pLocalidadID ,
                                          int pProvinciaID ,
                                          String imagenPerfil )
         {
            PersonaRow rowPersonaRow = ((PersonaRow)(this.NewRow())) ;
            rowPersonaRow["PersonaNombre"] = personaNombre ;
            rowPersonaRow["PersonaApellido"] = personaApellido ;
            rowPersonaRow["PersonaFechaNacimiento"] = personaFechaNacimiento ;
            rowPersonaRow["PersonaSexo"] = personaSexo ;
            rowPersonaRow["PLocalidadID"] = pLocalidadID ;
            rowPersonaRow["PProvinciaID"] = pProvinciaID ;
            rowPersonaRow["ImagenPerfil"] = imagenPerfil ;
            this.Rows.Add( rowPersonaRow) ;
            return rowPersonaRow ;
         }

         public PersonaRow FindByPersonaID( int personaID )
         {
            return ((PersonaRow)(this.Rows.Find(new  object[] {personaID}))) ;
         }

         internal void InitVars( )
         {
            this.columnPersonaID = this.Columns["PersonaID"] ;
            this.columnPersonaNombre = this.Columns["PersonaNombre"] ;
            this.columnPersonaApellido = this.Columns["PersonaApellido"] ;
            this.columnPersonaFechaNacimiento = this.Columns["PersonaFechaNacimiento"] ;
            this.columnPersonaSexo = this.Columns["PersonaSexo"] ;
            this.columnPLocalidadID = this.Columns["PLocalidadID"] ;
            this.columnPProvinciaID = this.Columns["PProvinciaID"] ;
            this.columnImagenPerfil = this.Columns["ImagenPerfil"] ;
         }

         public void InitClass( )
         {
            this.columnPersonaID = new DataColumn( "PersonaID", typeof(int), "", System.Data.MappingType.Element) ;
            this.columnPersonaID.AllowDBNull = false ;
            this.columnPersonaID.Caption = "Persona ID" ;
            this.columnPersonaID.Unique = true ;
            this.columnPersonaID.AutoIncrement = true ;
            this.columnPersonaID.AutoIncrementSeed = -1 ;
            this.columnPersonaID.AutoIncrementStep = -1 ;
            this.columnPersonaID.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnPersonaID.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnPersonaID.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnPersonaID.ExtendedProperties.Add( "AutoNumber", "true") ;
            this.columnPersonaID.ExtendedProperties.Add( "IsKey", "true") ;
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
            this.columnPersonaNombre = new DataColumn( "PersonaNombre", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnPersonaNombre.AllowDBNull = false ;
            this.columnPersonaNombre.Caption = "Persona Nombre" ;
            this.columnPersonaNombre.MaxLength = 120 ;
            this.columnPersonaNombre.DefaultValue = System.Convert.DBNull ;
            this.columnPersonaNombre.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "Description", "Persona Nombre") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "Length", "120") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnPersonaNombre.ExtendedProperties.Add( "Deklarit.InternalName", "PersonaNombre") ;
            this.Columns.Add( this.columnPersonaNombre) ;
            this.columnPersonaApellido = new DataColumn( "PersonaApellido", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnPersonaApellido.AllowDBNull = false ;
            this.columnPersonaApellido.Caption = "Persona Apellido" ;
            this.columnPersonaApellido.MaxLength = 120 ;
            this.columnPersonaApellido.DefaultValue = System.Convert.DBNull ;
            this.columnPersonaApellido.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "Description", "Persona Apellido") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "Length", "120") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnPersonaApellido.ExtendedProperties.Add( "Deklarit.InternalName", "PersonaApellido") ;
            this.Columns.Add( this.columnPersonaApellido) ;
            this.columnPersonaFechaNacimiento = new DataColumn( "PersonaFechaNacimiento", typeof(DateTime), "", System.Data.MappingType.Element) ;
            this.columnPersonaFechaNacimiento.AllowDBNull = false ;
            this.columnPersonaFechaNacimiento.Caption = "Perosna" ;
            this.columnPersonaFechaNacimiento.DefaultValue = System.Convert.DBNull ;
            this.columnPersonaFechaNacimiento.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnPersonaFechaNacimiento.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnPersonaFechaNacimiento.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnPersonaFechaNacimiento.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnPersonaFechaNacimiento.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnPersonaFechaNacimiento.ExtendedProperties.Add( "DeklaritType", "date") ;
            this.columnPersonaFechaNacimiento.ExtendedProperties.Add( "Description", "Perosna fecha nacimiento") ;
            this.columnPersonaFechaNacimiento.ExtendedProperties.Add( "Length", "8") ;
            this.columnPersonaFechaNacimiento.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnPersonaFechaNacimiento.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnPersonaFechaNacimiento.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnPersonaFechaNacimiento.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnPersonaFechaNacimiento.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnPersonaFechaNacimiento.ExtendedProperties.Add( "Deklarit.InternalName", "PersonaFechaNacimiento") ;
            this.Columns.Add( this.columnPersonaFechaNacimiento) ;
            this.columnPersonaSexo = new DataColumn( "PersonaSexo", typeof(short), "", System.Data.MappingType.Element) ;
            this.columnPersonaSexo.AllowDBNull = false ;
            this.columnPersonaSexo.Caption = "Persona Sexo" ;
            this.columnPersonaSexo.DefaultValue = System.Convert.DBNull ;
            this.columnPersonaSexo.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnPersonaSexo.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnPersonaSexo.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnPersonaSexo.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnPersonaSexo.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnPersonaSexo.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnPersonaSexo.ExtendedProperties.Add( "Description", "Persona Sexo") ;
            this.columnPersonaSexo.ExtendedProperties.Add( "Length", "3") ;
            this.columnPersonaSexo.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnPersonaSexo.ExtendedProperties.Add( "IsEnumeration", "true") ;
            this.columnPersonaSexo.ExtendedProperties.Add( "EnumerationType", "Sexo") ;
            this.columnPersonaSexo.ExtendedProperties.Add( "AllowDBNulls", "false") ;
            this.columnPersonaSexo.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnPersonaSexo.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnPersonaSexo.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnPersonaSexo.ExtendedProperties.Add( "Deklarit.InternalName", "PersonaSexo") ;
            this.Columns.Add( this.columnPersonaSexo) ;
            this.columnPLocalidadID = new DataColumn( "PLocalidadID", typeof(int), "", System.Data.MappingType.Element) ;
            this.columnPLocalidadID.AllowDBNull = true ;
            this.columnPLocalidadID.Caption = "P Localidad ID" ;
            this.columnPLocalidadID.DefaultValue = System.Convert.DBNull ;
            this.columnPLocalidadID.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnPLocalidadID.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnPLocalidadID.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnPLocalidadID.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnPLocalidadID.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnPLocalidadID.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnPLocalidadID.ExtendedProperties.Add( "Description", "P Localidad ID") ;
            this.columnPLocalidadID.ExtendedProperties.Add( "Length", "5") ;
            this.columnPLocalidadID.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnPLocalidadID.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnPLocalidadID.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnPLocalidadID.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnPLocalidadID.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnPLocalidadID.ExtendedProperties.Add( "Deklarit.InternalName", "PLocalidadID") ;
            this.Columns.Add( this.columnPLocalidadID) ;
            this.columnPProvinciaID = new DataColumn( "PProvinciaID", typeof(int), "", System.Data.MappingType.Element) ;
            this.columnPProvinciaID.AllowDBNull = true ;
            this.columnPProvinciaID.Caption = "P Provincia ID" ;
            this.columnPProvinciaID.DefaultValue = System.Convert.DBNull ;
            this.columnPProvinciaID.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnPProvinciaID.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnPProvinciaID.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnPProvinciaID.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnPProvinciaID.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnPProvinciaID.ExtendedProperties.Add( "DeklaritType", "int") ;
            this.columnPProvinciaID.ExtendedProperties.Add( "Description", "P Provincia ID") ;
            this.columnPProvinciaID.ExtendedProperties.Add( "Length", "5") ;
            this.columnPProvinciaID.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnPProvinciaID.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnPProvinciaID.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnPProvinciaID.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnPProvinciaID.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnPProvinciaID.ExtendedProperties.Add( "Deklarit.InternalName", "PProvinciaID") ;
            this.Columns.Add( this.columnPProvinciaID) ;
            this.columnImagenPerfil = new DataColumn( "ImagenPerfil", typeof(String), "", System.Data.MappingType.Element) ;
            this.columnImagenPerfil.AllowDBNull = true ;
            this.columnImagenPerfil.Caption = "Imagen Perfil" ;
            this.columnImagenPerfil.MaxLength = 50 ;
            this.columnImagenPerfil.DefaultValue = System.Convert.DBNull ;
            this.columnImagenPerfil.ExtendedProperties.Add( "Deklarit.IsDescription", "false") ;
            this.columnImagenPerfil.ExtendedProperties.Add( "Deklarit.IsVisibleOnForm", "true") ;
            this.columnImagenPerfil.ExtendedProperties.Add( "Deklarit.IsVisibleOnWorkWith", "true") ;
            this.columnImagenPerfil.ExtendedProperties.Add( "IsKey", "false") ;
            this.columnImagenPerfil.ExtendedProperties.Add( "ReadOnly", "false") ;
            this.columnImagenPerfil.ExtendedProperties.Add( "DeklaritType", "svchar") ;
            this.columnImagenPerfil.ExtendedProperties.Add( "Description", "Imagen Perfil") ;
            this.columnImagenPerfil.ExtendedProperties.Add( "Length", "50") ;
            this.columnImagenPerfil.ExtendedProperties.Add( "Decimals", "0") ;
            this.columnImagenPerfil.ExtendedProperties.Add( "AllowDBNulls", "true") ;
            this.columnImagenPerfil.ExtendedProperties.Add( "IsInReader", "true") ;
            this.columnImagenPerfil.ExtendedProperties.Add( "Deklarit.Casing", "default") ;
            this.columnImagenPerfil.ExtendedProperties.Add( "Deklarit.IsPassword", "false") ;
            this.columnImagenPerfil.ExtendedProperties.Add( "Deklarit.InternalName", "ImagenPerfil") ;
            this.Columns.Add( this.columnImagenPerfil) ;
            this.PrimaryKey = new  DataColumn[]  {this.columnPersonaID} ;
            this.ExtendedProperties.Add( "ParentLvl", "") ;
            this.ExtendedProperties.Add( "LevelName", "Persona") ;
            this.ExtendedProperties.Add( "Description", "Persona") ;
            this.ExtendedProperties.Add( "msprop:AllowInsert", "true") ;
            this.ExtendedProperties.Add( "msprop:AllowUpdate", "true") ;
            this.ExtendedProperties.Add( "msprop:AllowDelete", "true") ;
            this.ExtendedProperties.Add( "Deklarit.EditInDataGrid", "True") ;
         }

         protected override void OnRowChanged( DataRowChangeEventArgs e )
         {
            base.OnRowChanged( e) ;
            if ( ( this.PersonaRowChanged != null ) )
            {
               this.PersonaRowChanged( this, new PersonaRowChangeEvent( ((PersonaRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowChanging( DataRowChangeEventArgs e )
         {
            base.OnRowChanging( e) ;
            if ( ( this.PersonaRowChanging != null ) )
            {
               this.PersonaRowChanging( this, new PersonaRowChangeEvent( ((PersonaRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowDeleted( DataRowChangeEventArgs e )
         {
            base.OnRowDeleted( e) ;
            if ( ( this.PersonaRowDeleted != null ) )
            {
               this.PersonaRowDeleted( this, new PersonaRowChangeEvent( ((PersonaRow)(e.Row)), e.Action)) ;
            }
         }

         protected override void OnRowDeleting( DataRowChangeEventArgs e )
         {
            base.OnRowDeleting( e) ;
            if ( ( this.PersonaRowDeleting != null ) )
            {
               this.PersonaRowDeleting( this, new PersonaRowChangeEvent( ((PersonaRow)(e.Row)), e.Action)) ;
            }
         }

      }

      public class PersonaRow : DataRow
      {
         private PersonaDataTable tablePersona ;
         internal PersonaRow( DataRowBuilder rb ) : base(rb)
         {
            this.tablePersona = ((PersonaDataTable)(this.Table)) ;
         }

         ///  <summary>
         ///   Gets or sets the Persona ID.
         ///  </summary>
         public int PersonaID
         {
            get {
               return ((int)(this[this.tablePersona.PersonaIDColumn])) ;
            }

            set {
               this[this.tablePersona.PersonaIDColumn] = value ;
            }

         }

         public bool IsPersonaIDNull( )
         {
            return this.IsNull( this.tablePersona.PersonaIDColumn) ;
         }

         ///  <summary>
         ///   Gets or sets the Persona Nombre.
         ///  </summary>
         public String PersonaNombre
         {
            get {
               try
               {
                  return ((String)(this[this.tablePersona.PersonaNombreColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value PersonaNombre because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tablePersona.PersonaNombreColumn] = value ;
            }

         }

         public bool IsPersonaNombreNull( )
         {
            return this.IsNull( this.tablePersona.PersonaNombreColumn) ;
         }

         public void SetPersonaNombreNull( )
         {
            this[this.tablePersona.PersonaNombreColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Persona Apellido.
         ///  </summary>
         public String PersonaApellido
         {
            get {
               try
               {
                  return ((String)(this[this.tablePersona.PersonaApellidoColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value PersonaApellido because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tablePersona.PersonaApellidoColumn] = value ;
            }

         }

         public bool IsPersonaApellidoNull( )
         {
            return this.IsNull( this.tablePersona.PersonaApellidoColumn) ;
         }

         public void SetPersonaApellidoNull( )
         {
            this[this.tablePersona.PersonaApellidoColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Perosna fecha nacimiento.
         ///  </summary>
         public DateTime PersonaFechaNacimiento
         {
            get {
               try
               {
                  return ((DateTime)(this[this.tablePersona.PersonaFechaNacimientoColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value PersonaFechaNacimiento because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tablePersona.PersonaFechaNacimientoColumn] = value ;
            }

         }

         public bool IsPersonaFechaNacimientoNull( )
         {
            return this.IsNull( this.tablePersona.PersonaFechaNacimientoColumn) ;
         }

         public void SetPersonaFechaNacimientoNull( )
         {
            this[this.tablePersona.PersonaFechaNacimientoColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Persona Sexo.
         ///  </summary>
         public Sexo PersonaSexo
         {
            get {
               try
               {
                  return ((Sexo)(((short)(this[this.tablePersona.PersonaSexoColumn])))) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value PersonaSexo because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tablePersona.PersonaSexoColumn] = ((short)(value)) ;
            }

         }

         public bool IsPersonaSexoNull( )
         {
            return this.IsNull( this.tablePersona.PersonaSexoColumn) ;
         }

         public void SetPersonaSexoNull( )
         {
            this[this.tablePersona.PersonaSexoColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the P Localidad ID.
         ///  </summary>
         public int PLocalidadID
         {
            get {
               try
               {
                  return ((int)(this[this.tablePersona.PLocalidadIDColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value PLocalidadID because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tablePersona.PLocalidadIDColumn] = value ;
            }

         }

         public bool IsPLocalidadIDNull( )
         {
            return this.IsNull( this.tablePersona.PLocalidadIDColumn) ;
         }

         public void SetPLocalidadIDNull( )
         {
            this[this.tablePersona.PLocalidadIDColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the P Provincia ID.
         ///  </summary>
         public int PProvinciaID
         {
            get {
               try
               {
                  return ((int)(this[this.tablePersona.PProvinciaIDColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value PProvinciaID because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tablePersona.PProvinciaIDColumn] = value ;
            }

         }

         public bool IsPProvinciaIDNull( )
         {
            return this.IsNull( this.tablePersona.PProvinciaIDColumn) ;
         }

         public void SetPProvinciaIDNull( )
         {
            this[this.tablePersona.PProvinciaIDColumn] = System.Convert.DBNull ;
         }

         ///  <summary>
         ///   Gets or sets the Imagen Perfil.
         ///  </summary>
         public String ImagenPerfil
         {
            get {
               try
               {
                  return ((String)(this[this.tablePersona.ImagenPerfilColumn])) ;
               }
               catch ( InvalidCastException deklaritException )
               {
                  throw new StrongTypingException( "Cannot get value ImagenPerfil because it is DBNull.", deklaritException) ;
               }
            }

            set {
               this[this.tablePersona.ImagenPerfilColumn] = value ;
            }

         }

         public bool IsImagenPerfilNull( )
         {
            return this.IsNull( this.tablePersona.ImagenPerfilColumn) ;
         }

         public void SetImagenPerfilNull( )
         {
            this[this.tablePersona.ImagenPerfilColumn] = System.Convert.DBNull ;
         }

      }

      public class PersonaRowChangeEvent : EventArgs
      {
         private PersonaRow eventRow ;
         private System.Data.DataRowAction eventAction ;
         public PersonaRowChangeEvent( PersonaRow row ,
                                       DataRowAction action )
         {
            this.eventRow = row ;
            this.eventAction = action ;
         }

         public PersonaRow Row
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
