
namespace Raiderplan1
{
	using System;
    using System.Collections;
    using System.Data;
    using Raiderplan1;

    

	public partial class TrayectoTipoDetalle
	{
		private TrayectoTipoDetalleDataSet.TrayectoTipoDetalleRow m_DataRow;
		private TrayectoTipoDetalleDataSet m_DataSet;
		
		/// <summary>
		/// Creates a new <see cref="TrayectoTipoDetalle"/> instance.
		/// </summary>
		/// <param name="dataRow">Data row that will be wrapped by the Business Object.</param>		
		public TrayectoTipoDetalle(TrayectoTipoDetalleDataSet.TrayectoTipoDetalleRow dataRow)
		{
			m_DataRow = dataRow;
			m_DataSet = (TrayectoTipoDetalleDataSet) dataRow.Table.DataSet;
		}
		
		/// <summary>
		/// Creates a new <see cref="TrayectoTipoDetalle"/> instance.
		/// </summary>		
		public TrayectoTipoDetalle()
		{
			m_DataSet = new TrayectoTipoDetalleDataSet();
			m_DataRow = m_DataSet.TrayectoTipoDetalle.NewTrayectoTipoDetalleRow();			
		}

		/// <summary>
		/// Gets the underlying TrayectoTipoDetalleDataSet
		/// </summary>
		/// <value></value>
		public TrayectoTipoDetalleDataSet TrayectoTipoDetalleDataSet
		{
			get { return m_DataSet; }
		}

		/// <summary>
		/// Gets the TrayectoTipoDetalle row attached to the Business Object instance
		/// </summary>
		/// <value></value>							
		public TrayectoTipoDetalleDataSet.TrayectoTipoDetalleRow TrayectoTipoDetalleRow
		{
			get { return m_DataRow; }
		}
		
 
		/// <summary>
		/// Loads the TrayectoTipoDetalle instance for a given pimary key value
		/// </summary>
		/// <param name="_TrayectoTipoDetalleID"> Trayecto Tipo Detalle ID.</param>			
		/// <value></value>		
		public void Fill(System.Int32 _TrayectoTipoDetalleID )
		{
			//m_DataSet.Clear();
			m_DataSet = new TrayectoTipoDetalleDataSet();
			DataAdapterFactoryProxy.Instance.GetTrayectoTipoDetalleDataAdapter().Fill(m_DataSet, _TrayectoTipoDetalleID);
			m_DataRow = m_DataSet.TrayectoTipoDetalle[0];
		}

		
		/// <summary>
		/// Updates this TipoDetalle in the database
		/// </summary>
		public void Update()
		{
			if (m_DataRow.RowState == DataRowState.Detached)
			{
				m_DataSet.TrayectoTipoDetalle.AddTrayectoTipoDetalleRow(m_DataRow);
			}
			DataAdapterFactoryProxy.Instance.GetTrayectoTipoDetalleDataAdapter().Update(m_DataSet);
			if (m_DataSet.TrayectoTipoDetalle.Rows.Count > 0)
				m_DataRow = m_DataSet.TrayectoTipoDetalle[0];
		}
		
		/// <summary>
		/// Deletes this TipoDetalle instance from the database
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
		/// Deletes this TipoDetalle instance from the DataSet. It will be deleted
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
		/// Gets or sets the Trayecto Tipo Detalle ID
		/// </summary>        
		public System.Int32 TrayectoTipoDetalleID
		{
			get 
			{
				return m_DataRow.TrayectoTipoDetalleID;
			}
			set
			{
				m_DataRow.TrayectoTipoDetalleID = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Nombre de la categoria
		/// </summary>        
		public System.String TTipoDetalleCategoria
		{
			get 
			{
				return m_DataRow.TTipoDetalleCategoria;
			}
			set
			{
				m_DataRow.TTipoDetalleCategoria = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the T Tipo Detalle Icono
		/// </summary>        
		public System.String TTipoDetalleIcono
		{
			get 
			{
				return m_DataRow.TTipoDetalleIcono;
			}
			set
			{
				m_DataRow.TTipoDetalleIcono = value;
			}
		}
		



	}


    public partial class TrayectoTipoDetalleCollection : IList, ICollection, IEnumerable
    {		
		
		private TrayectoTipoDetalleDataSet.TrayectoTipoDetalleDataTable  m_DataTable;
		private TrayectoTipoDetalleDataSet m_DataSet;
		public TrayectoTipoDetalleCollection(TrayectoTipoDetalleDataSet.TrayectoTipoDetalleDataTable dataTable)
		{
			m_DataTable = dataTable;
			m_DataSet = (TrayectoTipoDetalleDataSet) dataTable.DataSet;
		}
		
		public TrayectoTipoDetalleCollection()
		{
			m_DataSet = new TrayectoTipoDetalleDataSet ();
			m_DataTable = m_DataSet.TrayectoTipoDetalle;
		}		
		public TrayectoTipoDetalle NewTrayectoTipoDetalle()
		{
			return new TrayectoTipoDetalle(m_DataTable.NewTrayectoTipoDetalleRow());
		}		
       
		public TrayectoTipoDetalle FindByTrayectoTipoDetalleID(System.Int32 _TrayectoTipoDetalleID)
		{
			TrayectoTipoDetalleDataSet.TrayectoTipoDetalleRow row = m_DataTable.FindByTrayectoTipoDetalleID(_TrayectoTipoDetalleID );
			return row == null?null: new TrayectoTipoDetalle(row);			
		}	


		public TrayectoTipoDetalleDataSet TrayectoTipoDetalleDataSet
		{
			get { return m_DataSet; }
		}
						
		public TrayectoTipoDetalleDataSet.TrayectoTipoDetalleDataTable TrayectoTipoDetalleDataTable
		{
			get { return m_DataTable; }
		}	
		
   
		public System.Int32 Update()
		{
			ITrayectoTipoDetalleDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetTrayectoTipoDetalleDataAdapter();
			return dataAdapter.Update(m_DataSet);
		}

   
		public System.Int32 GetRecordCount()
		{
			ITrayectoTipoDetalleDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetTrayectoTipoDetalleDataAdapter();
			return dataAdapter.GetRecordCount();
		}

   
		public System.Int32 FillPage(System.Int32 startRow, System.Int32 maxRows)
		{
			ITrayectoTipoDetalleDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetTrayectoTipoDetalleDataAdapter();
			return dataAdapter.FillPage(m_DataSet, startRow, maxRows);
		}

   
		public System.Int32 Fill()
		{
			ITrayectoTipoDetalleDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetTrayectoTipoDetalleDataAdapter();
			return dataAdapter.Fill(m_DataSet);
		}

		#region IList Members
        object System.Collections.IList.this[int index]
		{
			get { return this[index]; }
			set { this[index] = (TrayectoTipoDetalle) value; }
		}

		void System.Collections.IList.Insert(int index, object value)
		{
			Insert(index, (TrayectoTipoDetalle) value);
		}

		void System.Collections.IList.Remove(object value)
		{
			Remove((TrayectoTipoDetalle) value);
		}

		bool System.Collections.IList.Contains(object value)
		{
			return Contains((TrayectoTipoDetalle) value);
		}

		int System.Collections.IList.IndexOf(object value)
		{
			return IndexOf( (TrayectoTipoDetalle) value);
		}

    	int System.Collections.IList.Add(object value)
		{
			return Add((TrayectoTipoDetalle) value);
		}
		
		public bool IsReadOnly
		{
			get { return false; }
		}
		
		public TrayectoTipoDetalle this[int index]
		{
			get
			{
				return new TrayectoTipoDetalle(m_DataTable[index]);
			}
			set
			{
				m_DataTable[index].ItemArray = ( (TrayectoTipoDetalle) value).TrayectoTipoDetalleRow.ItemArray;
			}
		}

		public void RemoveAt(int index)
		{
			m_DataTable[index].Delete();
		}

		public void Insert(int index, TrayectoTipoDetalle value)
		{
			Add(value);
		}

		public void Remove(TrayectoTipoDetalle value)
		{
			value.TrayectoTipoDetalleRow.Delete();		
		}

		public bool Contains(TrayectoTipoDetalle value)
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

		public int IndexOf(TrayectoTipoDetalle value)
		{
			for (int idx = 0; idx < m_DataTable.Count; idx++)
			{
				if (m_DataTable[idx].Equals(value.TrayectoTipoDetalleRow))
				{
					return idx;
				}
			}
			return -1;
		}

		public int Add(TrayectoTipoDetalle value)
		{
			m_DataTable.AddTrayectoTipoDetalleRow( value.TrayectoTipoDetalleRow);
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
			
			private TrayectoTipoDetalleDataSet.TrayectoTipoDetalleDataTable t;
			public CollectionEnumerator(TrayectoTipoDetalleDataSet.TrayectoTipoDetalleDataTable t)
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
					return new TrayectoTipoDetalle((TrayectoTipoDetalleDataSet.TrayectoTipoDetalleRow) t.Rows[position]);
				}
			}
		}
	}


}

