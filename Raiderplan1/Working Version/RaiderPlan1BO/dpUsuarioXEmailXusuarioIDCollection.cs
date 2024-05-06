
namespace Raiderplan1
{
	using System;
    using System.Collections;
    using System.Data;
    using Raiderplan1;

    

	public partial class dpUsuarioXEmailXusuarioIDCollection
	{
		private dpUsuarioXEmailXusuarioIDCollectionDataSet.UsuarioRow m_DataRow;
		private dpUsuarioXEmailXusuarioIDCollectionDataSet m_DataSet;
		
		/// <summary>
		/// Creates a new <see cref="dpUsuarioXEmailXusuarioIDCollection"/> instance.
		/// </summary>
		/// <param name="dataRow">Data row that will be wrapped by the Business Object.</param>		
		public dpUsuarioXEmailXusuarioIDCollection(dpUsuarioXEmailXusuarioIDCollectionDataSet.UsuarioRow dataRow)
		{
			m_DataRow = dataRow;
			m_DataSet = (dpUsuarioXEmailXusuarioIDCollectionDataSet) dataRow.Table.DataSet;
		}
		
		/// <summary>
		/// Creates a new <see cref="dpUsuarioXEmailXusuarioIDCollection"/> instance.
		/// </summary>		
		public dpUsuarioXEmailXusuarioIDCollection()
		{
			m_DataSet = new dpUsuarioXEmailXusuarioIDCollectionDataSet();
			m_DataRow = m_DataSet.Usuario.NewUsuarioRow();			
		}

		/// <summary>
		/// Gets the underlying dpUsuarioXEmailXusuarioIDCollectionDataSet
		/// </summary>
		/// <value></value>
		public dpUsuarioXEmailXusuarioIDCollectionDataSet dpUsuarioXEmailXusuarioIDCollectionDataSet
		{
			get { return m_DataSet; }
		}

		/// <summary>
		/// Gets the Usuario row attached to the Business Object instance
		/// </summary>
		/// <value></value>							
		public dpUsuarioXEmailXusuarioIDCollectionDataSet.UsuarioRow UsuarioRow
		{
			get { return m_DataRow; }
		}
		
		/// <summary>
		/// Deletes this dpUsuarioXEmailXusuarioIDCollection from the child collection. 
		/// </summary>
		public void Remove()
		{
			m_DataRow.Delete();
		}	
		
		/// <summary>
		/// Gets or sets the Usuario ID
		/// </summary>        
		public System.Int32 UsuarioID
		{
			get 
			{
				return m_DataRow.UsuarioID;
			}
			set
			{
				m_DataRow.UsuarioID = value;
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


    public partial class dpUsuarioXEmailXusuarioIDCollectionCollection : IList, ICollection, IEnumerable
    {		
		
		private dpUsuarioXEmailXusuarioIDCollectionDataSet.UsuarioDataTable  m_DataTable;
		private dpUsuarioXEmailXusuarioIDCollectionDataSet m_DataSet;
		public dpUsuarioXEmailXusuarioIDCollectionCollection(dpUsuarioXEmailXusuarioIDCollectionDataSet.UsuarioDataTable dataTable)
		{
			m_DataTable = dataTable;
			m_DataSet = (dpUsuarioXEmailXusuarioIDCollectionDataSet) dataTable.DataSet;
		}
		
		public dpUsuarioXEmailXusuarioIDCollectionCollection()
		{
			m_DataSet = new dpUsuarioXEmailXusuarioIDCollectionDataSet ();
			m_DataTable = m_DataSet.Usuario;
		}		

		public dpUsuarioXEmailXusuarioIDCollectionDataSet dpUsuarioXEmailXusuarioIDCollectionDataSet
		{
			get { return m_DataSet; }
		}
						
		public dpUsuarioXEmailXusuarioIDCollectionDataSet.UsuarioDataTable UsuarioDataTable
		{
			get { return m_DataTable; }
		}	
		
   
		public System.Int32 GetRecordCount(System.String email, System.String nombreUsuario)
		{
			IdpUsuarioXEmailXusuarioIDCollectionDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetdpUsuarioXEmailXusuarioIDCollectionDataAdapter();
			return dataAdapter.GetRecordCount(email, nombreUsuario);
		}

   
		public System.Int32 FillPage(System.String email, System.String nombreUsuario, System.Int32 startRow, System.Int32 maxRows)
		{
			IdpUsuarioXEmailXusuarioIDCollectionDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetdpUsuarioXEmailXusuarioIDCollectionDataAdapter();
			return dataAdapter.FillPage(m_DataSet, email, nombreUsuario, startRow, maxRows);
		}

   
		public System.Int32 Fill(System.String email, System.String nombreUsuario)
		{
			IdpUsuarioXEmailXusuarioIDCollectionDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetdpUsuarioXEmailXusuarioIDCollectionDataAdapter();
			return dataAdapter.Fill(m_DataSet, email, nombreUsuario);
		}

		#region IList Members
        object System.Collections.IList.this[int index]
		{
			get { return this[index]; }
			set { this[index] = (dpUsuarioXEmailXusuarioIDCollection) value; }
		}

		void System.Collections.IList.Insert(int index, object value)
		{
			Insert(index, (dpUsuarioXEmailXusuarioIDCollection) value);
		}

		void System.Collections.IList.Remove(object value)
		{
			Remove((dpUsuarioXEmailXusuarioIDCollection) value);
		}

		bool System.Collections.IList.Contains(object value)
		{
			return Contains((dpUsuarioXEmailXusuarioIDCollection) value);
		}

		int System.Collections.IList.IndexOf(object value)
		{
			return IndexOf( (dpUsuarioXEmailXusuarioIDCollection) value);
		}

    	int System.Collections.IList.Add(object value)
		{
			return Add((dpUsuarioXEmailXusuarioIDCollection) value);
		}
		
		public bool IsReadOnly
		{
			get { return false; }
		}
		
		public dpUsuarioXEmailXusuarioIDCollection this[int index]
		{
			get
			{
				return new dpUsuarioXEmailXusuarioIDCollection(m_DataTable[index]);
			}
			set
			{
				m_DataTable[index].ItemArray = ( (dpUsuarioXEmailXusuarioIDCollection) value).UsuarioRow.ItemArray;
			}
		}

		public void RemoveAt(int index)
		{
			m_DataTable[index].Delete();
		}

		public void Insert(int index, dpUsuarioXEmailXusuarioIDCollection value)
		{
			Add(value);
		}

		public void Remove(dpUsuarioXEmailXusuarioIDCollection value)
		{
			value.UsuarioRow.Delete();		
		}

		public bool Contains(dpUsuarioXEmailXusuarioIDCollection value)
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

		public int IndexOf(dpUsuarioXEmailXusuarioIDCollection value)
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

		public int Add(dpUsuarioXEmailXusuarioIDCollection value)
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
			
			private dpUsuarioXEmailXusuarioIDCollectionDataSet.UsuarioDataTable t;
			public CollectionEnumerator(dpUsuarioXEmailXusuarioIDCollectionDataSet.UsuarioDataTable t)
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
					return new dpUsuarioXEmailXusuarioIDCollection((dpUsuarioXEmailXusuarioIDCollectionDataSet.UsuarioRow) t.Rows[position]);
				}
			}
		}
	}


}

