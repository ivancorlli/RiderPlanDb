
namespace Raiderplan1
{
	using System;
    using System.Collections;
    using System.Data;
    using Raiderplan1;

    

	public partial class Localidad
	{
		private LocalidadDataSet.LocalidadRow m_DataRow;
		private LocalidadDataSet m_DataSet;
		
		/// <summary>
		/// Creates a new <see cref="Localidad"/> instance.
		/// </summary>
		/// <param name="dataRow">Data row that will be wrapped by the Business Object.</param>		
		public Localidad(LocalidadDataSet.LocalidadRow dataRow)
		{
			m_DataRow = dataRow;
			m_DataSet = (LocalidadDataSet) dataRow.Table.DataSet;
		}
		
		/// <summary>
		/// Creates a new <see cref="Localidad"/> instance.
		/// </summary>		
		public Localidad()
		{
			m_DataSet = new LocalidadDataSet();
			m_DataRow = m_DataSet.Localidad.NewLocalidadRow();			
		}

		/// <summary>
		/// Gets the underlying LocalidadDataSet
		/// </summary>
		/// <value></value>
		public LocalidadDataSet LocalidadDataSet
		{
			get { return m_DataSet; }
		}

		/// <summary>
		/// Gets the Localidad row attached to the Business Object instance
		/// </summary>
		/// <value></value>							
		public LocalidadDataSet.LocalidadRow LocalidadRow
		{
			get { return m_DataRow; }
		}
		
 
		/// <summary>
		/// Loads the Localidad instance for a given pimary key value
		/// </summary>
		/// <param name="_LoacaliadID"> Loacaliad ID.</param>			
		/// <value></value>		
		public void Fill(System.Int32 _LoacaliadID )
		{
			//m_DataSet.Clear();
			m_DataSet = new LocalidadDataSet();
			DataAdapterFactoryProxy.Instance.GetLocalidadDataAdapter().Fill(m_DataSet, _LoacaliadID);
			m_DataRow = m_DataSet.Localidad[0];
		}

		
		/// <summary>
		/// Updates this Localidad in the database
		/// </summary>
		public void Update()
		{
			if (m_DataRow.RowState == DataRowState.Detached)
			{
				m_DataSet.Localidad.AddLocalidadRow(m_DataRow);
			}
			DataAdapterFactoryProxy.Instance.GetLocalidadDataAdapter().Update(m_DataSet);
			if (m_DataSet.Localidad.Rows.Count > 0)
				m_DataRow = m_DataSet.Localidad[0];
		}
		
		/// <summary>
		/// Deletes this Localidad instance from the database
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
		/// Deletes this Localidad instance from the DataSet. It will be deleted
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
		/// Gets the Loacaliad ID
		/// </summary>        
		public System.Int32 LoacaliadID
		{
			get 
			{
				return m_DataRow.LoacaliadID;
			}
		}
		
		/// <summary>
		/// Gets or sets the Localidad Nombre
		/// </summary>        
		public System.String LocalidadNombre
		{
			get 
			{
				return m_DataRow.LocalidadNombre;
			}
			set
			{
				m_DataRow.LocalidadNombre = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Localidad Cod Pos
		/// </summary>        
		public System.String LocalidadCodPos
		{
			get 
			{
				return m_DataRow.LocalidadCodPos;
			}
			set
			{
				m_DataRow.LocalidadCodPos = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Provincia ID
		/// </summary>        
		public System.Int32 ProvinciaID
		{
			get 
			{
				return m_DataRow.ProvinciaID;
			}
			set
			{
				m_DataRow.ProvinciaID = value;
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
		



	}


    public partial class LocalidadCollection : IList, ICollection, IEnumerable
    {		
		
		private LocalidadDataSet.LocalidadDataTable  m_DataTable;
		private LocalidadDataSet m_DataSet;
		public LocalidadCollection(LocalidadDataSet.LocalidadDataTable dataTable)
		{
			m_DataTable = dataTable;
			m_DataSet = (LocalidadDataSet) dataTable.DataSet;
		}
		
		public LocalidadCollection()
		{
			m_DataSet = new LocalidadDataSet ();
			m_DataTable = m_DataSet.Localidad;
		}		
		public Localidad NewLocalidad()
		{
			return new Localidad(m_DataTable.NewLocalidadRow());
		}		
       
		public Localidad FindByLoacaliadID(System.Int32 _LoacaliadID)
		{
			LocalidadDataSet.LocalidadRow row = m_DataTable.FindByLoacaliadID(_LoacaliadID );
			return row == null?null: new Localidad(row);			
		}	


		public LocalidadDataSet LocalidadDataSet
		{
			get { return m_DataSet; }
		}
						
		public LocalidadDataSet.LocalidadDataTable LocalidadDataTable
		{
			get { return m_DataTable; }
		}	
		
   
		public System.Int32 Update()
		{
			ILocalidadDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetLocalidadDataAdapter();
			return dataAdapter.Update(m_DataSet);
		}

   
		public System.Int32 GetRecordCount()
		{
			ILocalidadDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetLocalidadDataAdapter();
			return dataAdapter.GetRecordCount();
		}

   
		public System.Int32 FillPage(System.Int32 startRow, System.Int32 maxRows)
		{
			ILocalidadDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetLocalidadDataAdapter();
			return dataAdapter.FillPage(m_DataSet, startRow, maxRows);
		}

   
		public System.Int32 GetRecordCountByProvinciaID(System.Int32 provinciaID)
		{
			ILocalidadDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetLocalidadDataAdapter();
			return dataAdapter.GetRecordCountByProvinciaID(provinciaID);
		}

   
		public System.Int32 FillPageByProvinciaID(System.Int32 provinciaID, System.Int32 startRow, System.Int32 maxRows)
		{
			ILocalidadDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetLocalidadDataAdapter();
			return dataAdapter.FillPageByProvinciaID(m_DataSet, provinciaID, startRow, maxRows);
		}

   
		public System.Int32 FillByProvinciaID(System.Int32 provinciaID)
		{
			ILocalidadDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetLocalidadDataAdapter();
			return dataAdapter.FillByProvinciaID(m_DataSet, provinciaID);
		}

   
		public System.Int32 Fill()
		{
			ILocalidadDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetLocalidadDataAdapter();
			return dataAdapter.Fill(m_DataSet);
		}

		#region IList Members
        object System.Collections.IList.this[int index]
		{
			get { return this[index]; }
			set { this[index] = (Localidad) value; }
		}

		void System.Collections.IList.Insert(int index, object value)
		{
			Insert(index, (Localidad) value);
		}

		void System.Collections.IList.Remove(object value)
		{
			Remove((Localidad) value);
		}

		bool System.Collections.IList.Contains(object value)
		{
			return Contains((Localidad) value);
		}

		int System.Collections.IList.IndexOf(object value)
		{
			return IndexOf( (Localidad) value);
		}

    	int System.Collections.IList.Add(object value)
		{
			return Add((Localidad) value);
		}
		
		public bool IsReadOnly
		{
			get { return false; }
		}
		
		public Localidad this[int index]
		{
			get
			{
				return new Localidad(m_DataTable[index]);
			}
			set
			{
				m_DataTable[index].ItemArray = ( (Localidad) value).LocalidadRow.ItemArray;
			}
		}

		public void RemoveAt(int index)
		{
			m_DataTable[index].Delete();
		}

		public void Insert(int index, Localidad value)
		{
			Add(value);
		}

		public void Remove(Localidad value)
		{
			value.LocalidadRow.Delete();		
		}

		public bool Contains(Localidad value)
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

		public int IndexOf(Localidad value)
		{
			for (int idx = 0; idx < m_DataTable.Count; idx++)
			{
				if (m_DataTable[idx].Equals(value.LocalidadRow))
				{
					return idx;
				}
			}
			return -1;
		}

		public int Add(Localidad value)
		{
			m_DataTable.AddLocalidadRow( value.LocalidadRow);
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
			
			private LocalidadDataSet.LocalidadDataTable t;
			public CollectionEnumerator(LocalidadDataSet.LocalidadDataTable t)
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
					return new Localidad((LocalidadDataSet.LocalidadRow) t.Rows[position]);
				}
			}
		}
	}


}

