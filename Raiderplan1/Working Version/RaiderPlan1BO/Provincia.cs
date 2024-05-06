
namespace Raiderplan1
{
	using System;
    using System.Collections;
    using System.Data;
    using Raiderplan1;

    

	public partial class Provincia
	{
		private ProvinciaDataSet.ProvinciaRow m_DataRow;
		private ProvinciaDataSet m_DataSet;
		
		/// <summary>
		/// Creates a new <see cref="Provincia"/> instance.
		/// </summary>
		/// <param name="dataRow">Data row that will be wrapped by the Business Object.</param>		
		public Provincia(ProvinciaDataSet.ProvinciaRow dataRow)
		{
			m_DataRow = dataRow;
			m_DataSet = (ProvinciaDataSet) dataRow.Table.DataSet;
		}
		
		/// <summary>
		/// Creates a new <see cref="Provincia"/> instance.
		/// </summary>		
		public Provincia()
		{
			m_DataSet = new ProvinciaDataSet();
			m_DataRow = m_DataSet.Provincia.NewProvinciaRow();			
		}

		/// <summary>
		/// Gets the underlying ProvinciaDataSet
		/// </summary>
		/// <value></value>
		public ProvinciaDataSet ProvinciaDataSet
		{
			get { return m_DataSet; }
		}

		/// <summary>
		/// Gets the Provincia row attached to the Business Object instance
		/// </summary>
		/// <value></value>							
		public ProvinciaDataSet.ProvinciaRow ProvinciaRow
		{
			get { return m_DataRow; }
		}
		
 
		/// <summary>
		/// Loads the Provincia instance for a given pimary key value
		/// </summary>
		/// <param name="_ProvinciaID"> Provincia ID.</param>			
		/// <value></value>		
		public void Fill(System.Int32 _ProvinciaID )
		{
			//m_DataSet.Clear();
			m_DataSet = new ProvinciaDataSet();
			DataAdapterFactoryProxy.Instance.GetProvinciaDataAdapter().Fill(m_DataSet, _ProvinciaID);
			m_DataRow = m_DataSet.Provincia[0];
		}

		
		/// <summary>
		/// Updates this Provincia in the database
		/// </summary>
		public void Update()
		{
			if (m_DataRow.RowState == DataRowState.Detached)
			{
				m_DataSet.Provincia.AddProvinciaRow(m_DataRow);
			}
			DataAdapterFactoryProxy.Instance.GetProvinciaDataAdapter().Update(m_DataSet);
			if (m_DataSet.Provincia.Rows.Count > 0)
				m_DataRow = m_DataSet.Provincia[0];
		}
		
		/// <summary>
		/// Deletes this Provincia instance from the database
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
		/// Deletes this Provincia instance from the DataSet. It will be deleted
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
		/// Gets the Provincia ID
		/// </summary>        
		public System.Int32 ProvinciaID
		{
			get 
			{
				return m_DataRow.ProvinciaID;
			}
		}
		
		/// <summary>
		/// Gets or sets the Provincia Nombre
		/// </summary>        
		public System.String ProvinciaNombre
		{
			get 
			{
				return m_DataRow.ProvinciaNombre;
			}
			set
			{
				m_DataRow.ProvinciaNombre = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Pais ID
		/// </summary>        
		public System.Int32 PaisID
		{
			get 
			{
				return m_DataRow.PaisID;
			}
			set
			{
				m_DataRow.PaisID = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Pais Nombre
		/// </summary>        
		public System.String PaisNombre
		{
			get 
			{
				return m_DataRow.PaisNombre;
			}
			set
			{
				m_DataRow.PaisNombre = value;
			}
		}
		



	}


    public partial class ProvinciaCollection : IList, ICollection, IEnumerable
    {		
		
		private ProvinciaDataSet.ProvinciaDataTable  m_DataTable;
		private ProvinciaDataSet m_DataSet;
		public ProvinciaCollection(ProvinciaDataSet.ProvinciaDataTable dataTable)
		{
			m_DataTable = dataTable;
			m_DataSet = (ProvinciaDataSet) dataTable.DataSet;
		}
		
		public ProvinciaCollection()
		{
			m_DataSet = new ProvinciaDataSet ();
			m_DataTable = m_DataSet.Provincia;
		}		
		public Provincia NewProvincia()
		{
			return new Provincia(m_DataTable.NewProvinciaRow());
		}		
       
		public Provincia FindByProvinciaID(System.Int32 _ProvinciaID)
		{
			ProvinciaDataSet.ProvinciaRow row = m_DataTable.FindByProvinciaID(_ProvinciaID );
			return row == null?null: new Provincia(row);			
		}	


		public ProvinciaDataSet ProvinciaDataSet
		{
			get { return m_DataSet; }
		}
						
		public ProvinciaDataSet.ProvinciaDataTable ProvinciaDataTable
		{
			get { return m_DataTable; }
		}	
		
   
		public System.Int32 Update()
		{
			IProvinciaDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetProvinciaDataAdapter();
			return dataAdapter.Update(m_DataSet);
		}

   
		public System.Int32 GetRecordCount()
		{
			IProvinciaDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetProvinciaDataAdapter();
			return dataAdapter.GetRecordCount();
		}

   
		public System.Int32 FillPage(System.Int32 startRow, System.Int32 maxRows)
		{
			IProvinciaDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetProvinciaDataAdapter();
			return dataAdapter.FillPage(m_DataSet, startRow, maxRows);
		}

   
		public System.Int32 GetRecordCountByPaisID(System.Int32 paisID)
		{
			IProvinciaDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetProvinciaDataAdapter();
			return dataAdapter.GetRecordCountByPaisID(paisID);
		}

   
		public System.Int32 FillPageByPaisID(System.Int32 paisID, System.Int32 startRow, System.Int32 maxRows)
		{
			IProvinciaDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetProvinciaDataAdapter();
			return dataAdapter.FillPageByPaisID(m_DataSet, paisID, startRow, maxRows);
		}

   
		public System.Int32 FillByPaisID(System.Int32 paisID)
		{
			IProvinciaDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetProvinciaDataAdapter();
			return dataAdapter.FillByPaisID(m_DataSet, paisID);
		}

   
		public System.Int32 Fill()
		{
			IProvinciaDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetProvinciaDataAdapter();
			return dataAdapter.Fill(m_DataSet);
		}

		#region IList Members
        object System.Collections.IList.this[int index]
		{
			get { return this[index]; }
			set { this[index] = (Provincia) value; }
		}

		void System.Collections.IList.Insert(int index, object value)
		{
			Insert(index, (Provincia) value);
		}

		void System.Collections.IList.Remove(object value)
		{
			Remove((Provincia) value);
		}

		bool System.Collections.IList.Contains(object value)
		{
			return Contains((Provincia) value);
		}

		int System.Collections.IList.IndexOf(object value)
		{
			return IndexOf( (Provincia) value);
		}

    	int System.Collections.IList.Add(object value)
		{
			return Add((Provincia) value);
		}
		
		public bool IsReadOnly
		{
			get { return false; }
		}
		
		public Provincia this[int index]
		{
			get
			{
				return new Provincia(m_DataTable[index]);
			}
			set
			{
				m_DataTable[index].ItemArray = ( (Provincia) value).ProvinciaRow.ItemArray;
			}
		}

		public void RemoveAt(int index)
		{
			m_DataTable[index].Delete();
		}

		public void Insert(int index, Provincia value)
		{
			Add(value);
		}

		public void Remove(Provincia value)
		{
			value.ProvinciaRow.Delete();		
		}

		public bool Contains(Provincia value)
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

		public int IndexOf(Provincia value)
		{
			for (int idx = 0; idx < m_DataTable.Count; idx++)
			{
				if (m_DataTable[idx].Equals(value.ProvinciaRow))
				{
					return idx;
				}
			}
			return -1;
		}

		public int Add(Provincia value)
		{
			m_DataTable.AddProvinciaRow( value.ProvinciaRow);
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
			
			private ProvinciaDataSet.ProvinciaDataTable t;
			public CollectionEnumerator(ProvinciaDataSet.ProvinciaDataTable t)
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
					return new Provincia((ProvinciaDataSet.ProvinciaRow) t.Rows[position]);
				}
			}
		}
	}


}

