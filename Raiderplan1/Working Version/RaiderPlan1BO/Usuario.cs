
namespace Raiderplan1
{
	using System;
    using System.Collections;
    using System.Data;
    using Raiderplan1;

    

	public partial class Usuario
	{
		private UsuarioDataSet.UsuarioRow m_DataRow;
		private UsuarioDataSet m_DataSet;
		
		/// <summary>
		/// Creates a new <see cref="Usuario"/> instance.
		/// </summary>
		/// <param name="dataRow">Data row that will be wrapped by the Business Object.</param>		
		public Usuario(UsuarioDataSet.UsuarioRow dataRow)
		{
			m_DataRow = dataRow;
			m_DataSet = (UsuarioDataSet) dataRow.Table.DataSet;
		}
		
		/// <summary>
		/// Creates a new <see cref="Usuario"/> instance.
		/// </summary>		
		public Usuario()
		{
			m_DataSet = new UsuarioDataSet();
			m_DataRow = m_DataSet.Usuario.NewUsuarioRow();			
		}

		/// <summary>
		/// Gets the underlying UsuarioDataSet
		/// </summary>
		/// <value></value>
		public UsuarioDataSet UsuarioDataSet
		{
			get { return m_DataSet; }
		}

		/// <summary>
		/// Gets the Usuario row attached to the Business Object instance
		/// </summary>
		/// <value></value>							
		public UsuarioDataSet.UsuarioRow UsuarioRow
		{
			get { return m_DataRow; }
		}
		
 
		/// <summary>
		/// Loads the Usuario instance for a given pimary key value
		/// </summary>
		/// <param name="_UsuarioID"> Usuario ID.</param>			
		/// <value></value>		
		public void Fill(System.Int32 _UsuarioID )
		{
			//m_DataSet.Clear();
			m_DataSet = new UsuarioDataSet();
			DataAdapterFactoryProxy.Instance.GetUsuarioDataAdapter().Fill(m_DataSet, _UsuarioID);
			m_DataRow = m_DataSet.Usuario[0];
		}

		
		/// <summary>
		/// Updates this Usuario in the database
		/// </summary>
		public void Update()
		{
			if (m_DataRow.RowState == DataRowState.Detached)
			{
				m_DataSet.Usuario.AddUsuarioRow(m_DataRow);
			}
			DataAdapterFactoryProxy.Instance.GetUsuarioDataAdapter().Update(m_DataSet);
			if (m_DataSet.Usuario.Rows.Count > 0)
				m_DataRow = m_DataSet.Usuario[0];
		}
		
		/// <summary>
		/// Deletes this Usuario instance from the database
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
		/// Deletes this Usuario instance from the DataSet. It will be deleted
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
		/// Gets the Usuario ID
		/// </summary>        
		public System.Int32 UsuarioID
		{
			get 
			{
				return m_DataRow.UsuarioID;
			}
		}
		
		/// <summary>
		/// Gets or sets the Usuario Nombre
		/// </summary>        
		public System.String UsuarioNombre
		{
			get 
			{
				return m_DataRow.UsuarioNombre;
			}
			set
			{
				m_DataRow.UsuarioNombre = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Usuario Activo
		/// </summary>        
		public System.String UsuarioActivo
		{
			get 
			{
				return m_DataRow.UsuarioActivo;
			}
			set
			{
				m_DataRow.UsuarioActivo = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Usuario Email
		/// </summary>        
		public System.String UsuarioEmail
		{
			get 
			{
				return m_DataRow.UsuarioEmail;
			}
			set
			{
				m_DataRow.UsuarioEmail = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Usuario Pasword
		/// </summary>        
		public System.String UsuarioPasword
		{
			get 
			{
				return m_DataRow.UsuarioPasword;
			}
			set
			{
				m_DataRow.UsuarioPasword = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Usuario Fecha Alta
		/// </summary>        
		public System.DateTime UsuarioFechaAlta
		{
			get 
			{
				return m_DataRow.UsuarioFechaAlta;
			}
			set
			{
				m_DataRow.UsuarioFechaAlta = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Persona ID
		/// </summary>        
		public System.Int32 PersonaID
		{
			get 
			{
				return m_DataRow.PersonaID;
			}
			set
			{
				m_DataRow.PersonaID = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Codigo Validation
		/// </summary>        
		public System.String CodigoValidation
		{
			get 
			{
				return m_DataRow.CodigoValidation;
			}
			set
			{
				m_DataRow.CodigoValidation = value;
			}
		}
		



	}


    public partial class UsuarioCollection : IList, ICollection, IEnumerable
    {		
		
		private UsuarioDataSet.UsuarioDataTable  m_DataTable;
		private UsuarioDataSet m_DataSet;
		public UsuarioCollection(UsuarioDataSet.UsuarioDataTable dataTable)
		{
			m_DataTable = dataTable;
			m_DataSet = (UsuarioDataSet) dataTable.DataSet;
		}
		
		public UsuarioCollection()
		{
			m_DataSet = new UsuarioDataSet ();
			m_DataTable = m_DataSet.Usuario;
		}		
		public Usuario NewUsuario()
		{
			return new Usuario(m_DataTable.NewUsuarioRow());
		}		
       
		public Usuario FindByUsuarioID(System.Int32 _UsuarioID)
		{
			UsuarioDataSet.UsuarioRow row = m_DataTable.FindByUsuarioID(_UsuarioID );
			return row == null?null: new Usuario(row);			
		}	


		public UsuarioDataSet UsuarioDataSet
		{
			get { return m_DataSet; }
		}
						
		public UsuarioDataSet.UsuarioDataTable UsuarioDataTable
		{
			get { return m_DataTable; }
		}	
		
   
		public System.Int32 Update()
		{
			IUsuarioDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetUsuarioDataAdapter();
			return dataAdapter.Update(m_DataSet);
		}

   
		public System.Int32 GetRecordCount()
		{
			IUsuarioDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetUsuarioDataAdapter();
			return dataAdapter.GetRecordCount();
		}

   
		public System.Int32 FillPage(System.Int32 startRow, System.Int32 maxRows)
		{
			IUsuarioDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetUsuarioDataAdapter();
			return dataAdapter.FillPage(m_DataSet, startRow, maxRows);
		}

   
		public System.Int32 GetRecordCountByPersonaID(System.Int32 personaID)
		{
			IUsuarioDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetUsuarioDataAdapter();
			return dataAdapter.GetRecordCountByPersonaID(personaID);
		}

   
		public System.Int32 FillPageByPersonaID(System.Int32 personaID, System.Int32 startRow, System.Int32 maxRows)
		{
			IUsuarioDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetUsuarioDataAdapter();
			return dataAdapter.FillPageByPersonaID(m_DataSet, personaID, startRow, maxRows);
		}

   
		public System.Int32 FillByPersonaID(System.Int32 personaID)
		{
			IUsuarioDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetUsuarioDataAdapter();
			return dataAdapter.FillByPersonaID(m_DataSet, personaID);
		}

   
		public System.Int32 Fill()
		{
			IUsuarioDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetUsuarioDataAdapter();
			return dataAdapter.Fill(m_DataSet);
		}

		#region IList Members
        object System.Collections.IList.this[int index]
		{
			get { return this[index]; }
			set { this[index] = (Usuario) value; }
		}

		void System.Collections.IList.Insert(int index, object value)
		{
			Insert(index, (Usuario) value);
		}

		void System.Collections.IList.Remove(object value)
		{
			Remove((Usuario) value);
		}

		bool System.Collections.IList.Contains(object value)
		{
			return Contains((Usuario) value);
		}

		int System.Collections.IList.IndexOf(object value)
		{
			return IndexOf( (Usuario) value);
		}

    	int System.Collections.IList.Add(object value)
		{
			return Add((Usuario) value);
		}
		
		public bool IsReadOnly
		{
			get { return false; }
		}
		
		public Usuario this[int index]
		{
			get
			{
				return new Usuario(m_DataTable[index]);
			}
			set
			{
				m_DataTable[index].ItemArray = ( (Usuario) value).UsuarioRow.ItemArray;
			}
		}

		public void RemoveAt(int index)
		{
			m_DataTable[index].Delete();
		}

		public void Insert(int index, Usuario value)
		{
			Add(value);
		}

		public void Remove(Usuario value)
		{
			value.UsuarioRow.Delete();		
		}

		public bool Contains(Usuario value)
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

		public int IndexOf(Usuario value)
		{
			for (int idx = 0; idx < m_DataTable.Count; idx++)
			{
				if (m_DataTable[idx].Equals(value.UsuarioRow))
				{
					return idx;
				}
			}
			return -1;
		}

		public int Add(Usuario value)
		{
			m_DataTable.AddUsuarioRow( value.UsuarioRow);
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
			
			private UsuarioDataSet.UsuarioDataTable t;
			public CollectionEnumerator(UsuarioDataSet.UsuarioDataTable t)
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
					return new Usuario((UsuarioDataSet.UsuarioRow) t.Rows[position]);
				}
			}
		}
	}


}

