
namespace Raiderplan1
{
	using System;
    using System.Collections;
    using System.Data;
    using Raiderplan1;

    

	public partial class Pais
	{
		private PaisDataSet.PaisRow m_DataRow;
		private PaisDataSet m_DataSet;
		
		/// <summary>
		/// Creates a new <see cref="Pais"/> instance.
		/// </summary>
		/// <param name="dataRow">Data row that will be wrapped by the Business Object.</param>		
		public Pais(PaisDataSet.PaisRow dataRow)
		{
			m_DataRow = dataRow;
			m_DataSet = (PaisDataSet) dataRow.Table.DataSet;
		}
		
		/// <summary>
		/// Creates a new <see cref="Pais"/> instance.
		/// </summary>		
		public Pais()
		{
			m_DataSet = new PaisDataSet();
			m_DataRow = m_DataSet.Pais.NewPaisRow();			
		}

		/// <summary>
		/// Gets the underlying PaisDataSet
		/// </summary>
		/// <value></value>
		public PaisDataSet PaisDataSet
		{
			get { return m_DataSet; }
		}

		/// <summary>
		/// Gets the Pais row attached to the Business Object instance
		/// </summary>
		/// <value></value>							
		public PaisDataSet.PaisRow PaisRow
		{
			get { return m_DataRow; }
		}
		
 
		/// <summary>
		/// Loads the Pais instance for a given pimary key value
		/// </summary>
		/// <param name="_PaisID"> Pais ID.</param>			
		/// <value></value>		
		public void Fill(System.Int32 _PaisID )
		{
			//m_DataSet.Clear();
			m_DataSet = new PaisDataSet();
			DataAdapterFactoryProxy.Instance.GetPaisDataAdapter().Fill(m_DataSet, _PaisID);
			m_DataRow = m_DataSet.Pais[0];
		}

		
		/// <summary>
		/// Updates this Pais in the database
		/// </summary>
		public void Update()
		{
			if (m_DataRow.RowState == DataRowState.Detached)
			{
				m_DataSet.Pais.AddPaisRow(m_DataRow);
			}
			DataAdapterFactoryProxy.Instance.GetPaisDataAdapter().Update(m_DataSet);
			if (m_DataSet.Pais.Rows.Count > 0)
				m_DataRow = m_DataSet.Pais[0];
		}
		
		/// <summary>
		/// Deletes this Pais instance from the database
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
		/// Deletes this Pais instance from the DataSet. It will be deleted
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
		/// Gets the Pais ID
		/// </summary>        
		public System.Int32 PaisID
		{
			get 
			{
				return m_DataRow.PaisID;
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


    public partial class PaisCollection : IList, ICollection, IEnumerable
    {		
		
		private PaisDataSet.PaisDataTable  m_DataTable;
		private PaisDataSet m_DataSet;
		public PaisCollection(PaisDataSet.PaisDataTable dataTable)
		{
			m_DataTable = dataTable;
			m_DataSet = (PaisDataSet) dataTable.DataSet;
		}
		
		public PaisCollection()
		{
			m_DataSet = new PaisDataSet ();
			m_DataTable = m_DataSet.Pais;
		}		
		public Pais NewPais()
		{
			return new Pais(m_DataTable.NewPaisRow());
		}		
       
		public Pais FindByPaisID(System.Int32 _PaisID)
		{
			PaisDataSet.PaisRow row = m_DataTable.FindByPaisID(_PaisID );
			return row == null?null: new Pais(row);			
		}	


		public PaisDataSet PaisDataSet
		{
			get { return m_DataSet; }
		}
						
		public PaisDataSet.PaisDataTable PaisDataTable
		{
			get { return m_DataTable; }
		}	
		
   
		public System.Int32 Update()
		{
			IPaisDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetPaisDataAdapter();
			return dataAdapter.Update(m_DataSet);
		}

   
		public System.Int32 GetRecordCount()
		{
			IPaisDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetPaisDataAdapter();
			return dataAdapter.GetRecordCount();
		}

   
		public System.Int32 FillPage(System.Int32 startRow, System.Int32 maxRows)
		{
			IPaisDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetPaisDataAdapter();
			return dataAdapter.FillPage(m_DataSet, startRow, maxRows);
		}

   
		public System.Int32 Fill()
		{
			IPaisDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetPaisDataAdapter();
			return dataAdapter.Fill(m_DataSet);
		}

		#region IList Members
        object System.Collections.IList.this[int index]
		{
			get { return this[index]; }
			set { this[index] = (Pais) value; }
		}

		void System.Collections.IList.Insert(int index, object value)
		{
			Insert(index, (Pais) value);
		}

		void System.Collections.IList.Remove(object value)
		{
			Remove((Pais) value);
		}

		bool System.Collections.IList.Contains(object value)
		{
			return Contains((Pais) value);
		}

		int System.Collections.IList.IndexOf(object value)
		{
			return IndexOf( (Pais) value);
		}

    	int System.Collections.IList.Add(object value)
		{
			return Add((Pais) value);
		}
		
		public bool IsReadOnly
		{
			get { return false; }
		}
		
		public Pais this[int index]
		{
			get
			{
				return new Pais(m_DataTable[index]);
			}
			set
			{
				m_DataTable[index].ItemArray = ( (Pais) value).PaisRow.ItemArray;
			}
		}

		public void RemoveAt(int index)
		{
			m_DataTable[index].Delete();
		}

		public void Insert(int index, Pais value)
		{
			Add(value);
		}

		public void Remove(Pais value)
		{
			value.PaisRow.Delete();		
		}

		public bool Contains(Pais value)
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

		public int IndexOf(Pais value)
		{
			for (int idx = 0; idx < m_DataTable.Count; idx++)
			{
				if (m_DataTable[idx].Equals(value.PaisRow))
				{
					return idx;
				}
			}
			return -1;
		}

		public int Add(Pais value)
		{
			m_DataTable.AddPaisRow( value.PaisRow);
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
			
			private PaisDataSet.PaisDataTable t;
			public CollectionEnumerator(PaisDataSet.PaisDataTable t)
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
					return new Pais((PaisDataSet.PaisRow) t.Rows[position]);
				}
			}
		}
	}


}

