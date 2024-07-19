
namespace Raiderplan1
{
	using System;
    using System.Collections;
    using System.Data;
    using Raiderplan1;

    

	public partial class Persona
	{
		private PersonaDataSet.PersonaRow m_DataRow;
		private PersonaDataSet m_DataSet;
		
		/// <summary>
		/// Creates a new <see cref="Persona"/> instance.
		/// </summary>
		/// <param name="dataRow">Data row that will be wrapped by the Business Object.</param>		
		public Persona(PersonaDataSet.PersonaRow dataRow)
		{
			m_DataRow = dataRow;
			m_DataSet = (PersonaDataSet) dataRow.Table.DataSet;
		}
		
		/// <summary>
		/// Creates a new <see cref="Persona"/> instance.
		/// </summary>		
		public Persona()
		{
			m_DataSet = new PersonaDataSet();
			m_DataRow = m_DataSet.Persona.NewPersonaRow();			
		}

		/// <summary>
		/// Gets the underlying PersonaDataSet
		/// </summary>
		/// <value></value>
		public PersonaDataSet PersonaDataSet
		{
			get { return m_DataSet; }
		}

		/// <summary>
		/// Gets the Persona row attached to the Business Object instance
		/// </summary>
		/// <value></value>							
		public PersonaDataSet.PersonaRow PersonaRow
		{
			get { return m_DataRow; }
		}
		
 
		/// <summary>
		/// Loads the Persona instance for a given pimary key value
		/// </summary>
		/// <param name="_PersonaID"> Persona ID.</param>			
		/// <value></value>		
		public void Fill(System.Int32 _PersonaID )
		{
			//m_DataSet.Clear();
			m_DataSet = new PersonaDataSet();
			DataAdapterFactoryProxy.Instance.GetPersonaDataAdapter().Fill(m_DataSet, _PersonaID);
			m_DataRow = m_DataSet.Persona[0];
		}

		
		/// <summary>
		/// Updates this Persona in the database
		/// </summary>
		public void Update()
		{
			if (m_DataRow.RowState == DataRowState.Detached)
			{
				m_DataSet.Persona.AddPersonaRow(m_DataRow);
			}
			DataAdapterFactoryProxy.Instance.GetPersonaDataAdapter().Update(m_DataSet);
			if (m_DataSet.Persona.Rows.Count > 0)
				m_DataRow = m_DataSet.Persona[0];
		}
		
		/// <summary>
		/// Deletes this Persona instance from the database
		/// </summary>
		public void Delete()
		{
			// This is just in case you call Delete in a row that was
			// added to the DataSet without being retrieved from the 
			// database

			if (m_DataRow.RowState != DataRowState.Detached)
			{
				m_DataRow.Delete();
				Update();
			}
		}

		/// <summary>
		/// Deletes this Persona instance from the DataSet. It will be deleted
		/// from the database when you call Update()
		/// </summary>
		public void Remove()
		{
			// This is just in case you call Delete in a row that was
			// added to the DataSet without being retrieved from the 
			// database

			if (m_DataRow.RowState != DataRowState.Detached)
			{
				m_DataRow.Delete();
			}
		}
		
		/// <summary>
		/// Gets the Persona ID
		/// </summary>        
		public System.Int32 PersonaID
		{
			get 
			{
				return m_DataRow.PersonaID;
			}
		}
		
		/// <summary>
		/// Gets or sets the Persona Nombre
		/// </summary>        
		public System.String PersonaNombre
		{
			get 
			{
				return m_DataRow.PersonaNombre;
			}
			set
			{
				m_DataRow.PersonaNombre = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Persona Apellido
		/// </summary>        
		public System.String PersonaApellido
		{
			get 
			{
				return m_DataRow.PersonaApellido;
			}
			set
			{
				m_DataRow.PersonaApellido = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Perosna fecha nacimiento
		/// </summary>        
		public System.DateTime PersonaFechaNacimiento
		{
			get 
			{
				return m_DataRow.PersonaFechaNacimiento;
			}
			set
			{
				m_DataRow.PersonaFechaNacimiento = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Persona Sexo
		/// </summary>        
		public Sexo PersonaSexo
		{
			get 
			{
				return m_DataRow.PersonaSexo;
			}
			set
			{
				m_DataRow.PersonaSexo = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the P Localidad ID
		/// </summary>        
		public System.Int32 PLocalidadID
		{
			get 
			{
				return m_DataRow.PLocalidadID;
			}
			set
			{
				m_DataRow.PLocalidadID = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the P Provincia ID
		/// </summary>        
		public System.Int32 PProvinciaID
		{
			get 
			{
				return m_DataRow.PProvinciaID;
			}
			set
			{
				m_DataRow.PProvinciaID = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Imagen Perfil
		/// </summary>        
		public System.String ImagenPerfil
		{
			get 
			{
				return m_DataRow.ImagenPerfil;
			}
			set
			{
				m_DataRow.ImagenPerfil = value;
			}
		}
		



	}


    public partial class PersonaCollection : IList, ICollection, IEnumerable
    {		
		
		private PersonaDataSet.PersonaDataTable  m_DataTable;
		private PersonaDataSet m_DataSet;
		public PersonaCollection(PersonaDataSet.PersonaDataTable dataTable)
		{
			m_DataTable = dataTable;
			m_DataSet = (PersonaDataSet) dataTable.DataSet;
		}
		
		public PersonaCollection()
		{
			m_DataSet = new PersonaDataSet ();
			m_DataTable = m_DataSet.Persona;
		}		
		public Persona NewPersona()
		{
			return new Persona(m_DataTable.NewPersonaRow());
		}		
       
		public Persona FindByPersonaID(System.Int32 _PersonaID)
		{
			PersonaDataSet.PersonaRow row = m_DataTable.FindByPersonaID(_PersonaID );
			return row == null?null: new Persona(row);			
		}	


		public PersonaDataSet PersonaDataSet
		{
			get { return m_DataSet; }
		}
						
		public PersonaDataSet.PersonaDataTable PersonaDataTable
		{
			get { return m_DataTable; }
		}	
		
   
		public System.Int32 Update()
		{
			IPersonaDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetPersonaDataAdapter();
			return dataAdapter.Update(m_DataSet);
		}

   
		public System.Int32 GetRecordCount()
		{
			IPersonaDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetPersonaDataAdapter();
			return dataAdapter.GetRecordCount();
		}

   
		public System.Int32 FillPage(System.Int32 startRow, System.Int32 maxRows)
		{
			IPersonaDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetPersonaDataAdapter();
			return dataAdapter.FillPage(m_DataSet, startRow, maxRows);
		}

   
		public System.Int32 Fill()
		{
			IPersonaDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetPersonaDataAdapter();
			return dataAdapter.Fill(m_DataSet);
		}

		#region IList Members
        object System.Collections.IList.this[int index]
		{
			get { return this[index]; }
			set { this[index] = (Persona) value; }
		}

		void System.Collections.IList.Insert(int index, object value)
		{
			Insert(index, (Persona) value);
		}

		void System.Collections.IList.Remove(object value)
		{
			Remove((Persona) value);
		}

		bool System.Collections.IList.Contains(object value)
		{
			return Contains((Persona) value);
		}

		int System.Collections.IList.IndexOf(object value)
		{
			return IndexOf( (Persona) value);
		}

    	int System.Collections.IList.Add(object value)
		{
			return Add((Persona) value);
		}
		
		public bool IsReadOnly
		{
			get { return false; }
		}
		
		public Persona this[int index]
		{
			get
			{
				return new Persona(m_DataTable[index]);
			}
			set
			{
				m_DataTable[index].ItemArray = ( (Persona) value).PersonaRow.ItemArray;
			}
		}

		public void RemoveAt(int index)
		{
			m_DataTable[index].Delete();
		}

		public void Insert(int index, Persona value)
		{
			Add(value);
		}

		public void Remove(Persona value)
		{
			value.PersonaRow.Delete();		
		}

		public bool Contains(Persona value)
		{
			return IndexOf(value) != -1;
		}

		public void Clear()
		{
            foreach (DataRow row in m_DataTable)
			{
				row.Delete();
			}
		}

		public int IndexOf(Persona value)
		{
			for (int idx = 0; idx < m_DataTable.Count; idx++)
			{
				if (m_DataTable[idx].Equals(value.PersonaRow))
				{
					return idx;
				}
			}
			return -1;
		}

		public int Add(Persona value)
		{
			m_DataTable.AddPersonaRow( value.PersonaRow);
			return Count;
		}

		public bool IsFixedSize
		{
			get { return false; }
		}

		#endregion
		

		#region ICollection Members

		public bool IsSynchronized
		{
			get { return false; }
		}

		public int Count
		{
			get { return m_DataTable.Count; }
		}

		public void CopyTo(Array array, int index)
		{
		
			m_DataTable.Rows.CopyTo(array, index);
		}

		public object SyncRoot
		{
			get { return this; }
		}

		#endregion

		#region IEnumerable Members

		public IEnumerator GetEnumerator()
		{
			return new CollectionEnumerator(m_DataTable);
		}

		#endregion
		
		// Inner class implements IEnumerator interface:
		private class CollectionEnumerator : IEnumerator		
		{
			private int position = -1;
			
			private PersonaDataSet.PersonaDataTable t;
			public CollectionEnumerator(PersonaDataSet.PersonaDataTable t)
			{
				this.t = t;
			}

			// Declare the MoveNext method required by IEnumerator:
			public bool MoveNext()
			{
				if (position < t.Rows.Count - 1)
				{
					position++;
					return true;
				}
				else
				{
					return false;
				}
			}

			// Declare the Reset method required by IEnumerator:
			public void Reset()
			{
				position = -1;
			}

			// Declare the Current property required by IEnumerator:
			public object Current
			{
				get
				{
					return new Persona((PersonaDataSet.PersonaRow) t.Rows[position]);
				}
			}
		}
	}


}

