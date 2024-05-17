
namespace Raiderplan1
{
	using System;
    using System.Collections;
    using System.Data;
    using Raiderplan1;

    

	public partial class RolUsuario
	{
		private RolUsuarioDataSet.RolUsuarioRow m_DataRow;
		private RolUsuarioDataSet m_DataSet;
		
		/// <summary>
		/// Creates a new <see cref="RolUsuario"/> instance.
		/// </summary>
		/// <param name="dataRow">Data row that will be wrapped by the Business Object.</param>		
		public RolUsuario(RolUsuarioDataSet.RolUsuarioRow dataRow)
		{
			m_DataRow = dataRow;
			m_DataSet = (RolUsuarioDataSet) dataRow.Table.DataSet;
		}
		
		/// <summary>
		/// Creates a new <see cref="RolUsuario"/> instance.
		/// </summary>		
		public RolUsuario()
		{
			m_DataSet = new RolUsuarioDataSet();
			m_DataRow = m_DataSet.RolUsuario.NewRolUsuarioRow();			
		}

		/// <summary>
		/// Gets the underlying RolUsuarioDataSet
		/// </summary>
		/// <value></value>
		public RolUsuarioDataSet RolUsuarioDataSet
		{
			get { return m_DataSet; }
		}

		/// <summary>
		/// Gets the RolUsuario row attached to the Business Object instance
		/// </summary>
		/// <value></value>							
		public RolUsuarioDataSet.RolUsuarioRow RolUsuarioRow
		{
			get { return m_DataRow; }
		}
		
 
		/// <summary>
		/// Loads the RolUsuario instance for a given pimary key value
		/// </summary>
		/// <param name="_RolUsuarioID"> Rol Usuario ID.</param>			
		/// <value></value>		
		public void Fill(System.Int16 _RolUsuarioID )
		{
			//m_DataSet.Clear();
			m_DataSet = new RolUsuarioDataSet();
			DataAdapterFactoryProxy.Instance.GetRolUsuarioDataAdapter().Fill(m_DataSet, _RolUsuarioID);
			m_DataRow = m_DataSet.RolUsuario[0];
		}

		
		/// <summary>
		/// Updates this RolUsuario in the database
		/// </summary>
		public void Update()
		{
			if (m_DataRow.RowState == DataRowState.Detached)
			{
				m_DataSet.RolUsuario.AddRolUsuarioRow(m_DataRow);
			}
			DataAdapterFactoryProxy.Instance.GetRolUsuarioDataAdapter().Update(m_DataSet);
			if (m_DataSet.RolUsuario.Rows.Count > 0)
				m_DataRow = m_DataSet.RolUsuario[0];
		}
		
		/// <summary>
		/// Deletes this RolUsuario instance from the database
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
		/// Deletes this RolUsuario instance from the DataSet. It will be deleted
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
		/// Gets the Rol Usuario ID
		/// </summary>        
		public System.Int16 RolUsuarioID
		{
			get 
			{
				return m_DataRow.RolUsuarioID;
			}
		}
		
		/// <summary>
		/// Gets or sets the Rol
		/// </summary>        
		public UsuarioRol Rol
		{
			get 
			{
				return m_DataRow.Rol;
			}
			set
			{
				m_DataRow.Rol = value;
			}
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
		



	}


    public partial class RolUsuarioCollection : IList, ICollection, IEnumerable
    {		
		
		private RolUsuarioDataSet.RolUsuarioDataTable  m_DataTable;
		private RolUsuarioDataSet m_DataSet;
		public RolUsuarioCollection(RolUsuarioDataSet.RolUsuarioDataTable dataTable)
		{
			m_DataTable = dataTable;
			m_DataSet = (RolUsuarioDataSet) dataTable.DataSet;
		}
		
		public RolUsuarioCollection()
		{
			m_DataSet = new RolUsuarioDataSet ();
			m_DataTable = m_DataSet.RolUsuario;
		}		
		public RolUsuario NewRolUsuario()
		{
			return new RolUsuario(m_DataTable.NewRolUsuarioRow());
		}		
       
		public RolUsuario FindByRolUsuarioID(System.Int16 _RolUsuarioID)
		{
			RolUsuarioDataSet.RolUsuarioRow row = m_DataTable.FindByRolUsuarioID(_RolUsuarioID );
			return row == null?null: new RolUsuario(row);			
		}	


		public RolUsuarioDataSet RolUsuarioDataSet
		{
			get { return m_DataSet; }
		}
						
		public RolUsuarioDataSet.RolUsuarioDataTable RolUsuarioDataTable
		{
			get { return m_DataTable; }
		}	
		
   
		public System.Int32 Update()
		{
			IRolUsuarioDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetRolUsuarioDataAdapter();
			return dataAdapter.Update(m_DataSet);
		}

   
		public System.Int32 GetRecordCount()
		{
			IRolUsuarioDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetRolUsuarioDataAdapter();
			return dataAdapter.GetRecordCount();
		}

   
		public System.Int32 FillPage(System.Int32 startRow, System.Int32 maxRows)
		{
			IRolUsuarioDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetRolUsuarioDataAdapter();
			return dataAdapter.FillPage(m_DataSet, startRow, maxRows);
		}

   
		public System.Int32 GetRecordCountByUsuarioID(System.Int32 usuarioID)
		{
			IRolUsuarioDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetRolUsuarioDataAdapter();
			return dataAdapter.GetRecordCountByUsuarioID(usuarioID);
		}

   
		public System.Int32 FillPageByUsuarioID(System.Int32 usuarioID, System.Int32 startRow, System.Int32 maxRows)
		{
			IRolUsuarioDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetRolUsuarioDataAdapter();
			return dataAdapter.FillPageByUsuarioID(m_DataSet, usuarioID, startRow, maxRows);
		}

   
		public System.Int32 FillByUsuarioID(System.Int32 usuarioID)
		{
			IRolUsuarioDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetRolUsuarioDataAdapter();
			return dataAdapter.FillByUsuarioID(m_DataSet, usuarioID);
		}

   
		public System.Int32 Fill()
		{
			IRolUsuarioDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetRolUsuarioDataAdapter();
			return dataAdapter.Fill(m_DataSet);
		}

		#region IList Members
        object System.Collections.IList.this[int index]
		{
			get { return this[index]; }
			set { this[index] = (RolUsuario) value; }
		}

		void System.Collections.IList.Insert(int index, object value)
		{
			Insert(index, (RolUsuario) value);
		}

		void System.Collections.IList.Remove(object value)
		{
			Remove((RolUsuario) value);
		}

		bool System.Collections.IList.Contains(object value)
		{
			return Contains((RolUsuario) value);
		}

		int System.Collections.IList.IndexOf(object value)
		{
			return IndexOf( (RolUsuario) value);
		}

    	int System.Collections.IList.Add(object value)
		{
			return Add((RolUsuario) value);
		}
		
		public bool IsReadOnly
		{
			get { return false; }
		}
		
		public RolUsuario this[int index]
		{
			get
			{
				return new RolUsuario(m_DataTable[index]);
			}
			set
			{
				m_DataTable[index].ItemArray = ( (RolUsuario) value).RolUsuarioRow.ItemArray;
			}
		}

		public void RemoveAt(int index)
		{
			m_DataTable[index].Delete();
		}

		public void Insert(int index, RolUsuario value)
		{
			Add(value);
		}

		public void Remove(RolUsuario value)
		{
			value.RolUsuarioRow.Delete();		
		}

		public bool Contains(RolUsuario value)
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

		public int IndexOf(RolUsuario value)
		{
			for (int idx = 0; idx < m_DataTable.Count; idx++)
			{
				if (m_DataTable[idx].Equals(value.RolUsuarioRow))
				{
					return idx;
				}
			}
			return -1;
		}

		public int Add(RolUsuario value)
		{
			m_DataTable.AddRolUsuarioRow( value.RolUsuarioRow);
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
			
			private RolUsuarioDataSet.RolUsuarioDataTable t;
			public CollectionEnumerator(RolUsuarioDataSet.RolUsuarioDataTable t)
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
					return new RolUsuario((RolUsuarioDataSet.RolUsuarioRow) t.Rows[position]);
				}
			}
		}
	}


}

