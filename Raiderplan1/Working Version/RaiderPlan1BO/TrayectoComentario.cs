
namespace Raiderplan1
{
	using System;
    using System.Collections;
    using System.Data;
    using Raiderplan1;

    

	public partial class TrayectoComentario
	{
		private TrayectoComentarioDataSet.ComentarioViajeRow m_DataRow;
		private TrayectoComentarioDataSet m_DataSet;
		
		/// <summary>
		/// Creates a new <see cref="TrayectoComentario"/> instance.
		/// </summary>
		/// <param name="dataRow">Data row that will be wrapped by the Business Object.</param>		
		public TrayectoComentario(TrayectoComentarioDataSet.ComentarioViajeRow dataRow)
		{
			m_DataRow = dataRow;
			m_DataSet = (TrayectoComentarioDataSet) dataRow.Table.DataSet;
		}
		
		/// <summary>
		/// Creates a new <see cref="TrayectoComentario"/> instance.
		/// </summary>		
		public TrayectoComentario()
		{
			m_DataSet = new TrayectoComentarioDataSet();
			m_DataRow = m_DataSet.ComentarioViaje.NewComentarioViajeRow();			
		}

		/// <summary>
		/// Gets the underlying TrayectoComentarioDataSet
		/// </summary>
		/// <value></value>
		public TrayectoComentarioDataSet TrayectoComentarioDataSet
		{
			get { return m_DataSet; }
		}

		/// <summary>
		/// Gets the ComentarioViaje row attached to the Business Object instance
		/// </summary>
		/// <value></value>							
		public TrayectoComentarioDataSet.ComentarioViajeRow ComentarioViajeRow
		{
			get { return m_DataRow; }
		}
		
		/// <summary>
		/// Deletes this TrayectoComentario from the child collection. 
		/// </summary>
		public void Remove()
		{
			m_DataRow.Delete();
		}	
		
		/// <summary>
		/// Gets or sets the Comentario Viaje ID
		/// </summary>        
		public System.Int32 ComentarioViajeID
		{
			get 
			{
				return m_DataRow.ComentarioViajeID;
			}
			set
			{
				m_DataRow.ComentarioViajeID = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Comentario Latitud
		/// </summary>        
		public System.Decimal ComentarioLatitud
		{
			get 
			{
				return m_DataRow.ComentarioLatitud;
			}
			set
			{
				m_DataRow.ComentarioLatitud = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Comentario Longitud
		/// </summary>        
		public System.Decimal ComentarioLongitud
		{
			get 
			{
				return m_DataRow.ComentarioLongitud;
			}
			set
			{
				m_DataRow.ComentarioLongitud = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Comentario Texto
		/// </summary>        
		public System.String ComentarioTexto
		{
			get 
			{
				return m_DataRow.ComentarioTexto;
			}
			set
			{
				m_DataRow.ComentarioTexto = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Comentario Imagen
		/// </summary>        
		public System.String ComentarioImagen
		{
			get 
			{
				return m_DataRow.ComentarioImagen;
			}
			set
			{
				m_DataRow.ComentarioImagen = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the CV Trayecto ID
		/// </summary>        
		public System.Int32 CVTrayectoID
		{
			get 
			{
				return m_DataRow.CVTrayectoID;
			}
			set
			{
				m_DataRow.CVTrayectoID = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Viaje ID
		/// </summary>        
		public System.Int64 ViajeID
		{
			get 
			{
				return m_DataRow.ViajeID;
			}
			set
			{
				m_DataRow.ViajeID = value;
			}
		}
		



	}


    public partial class TrayectoComentarioCollection : IList, ICollection, IEnumerable
    {		
		
		private string m_Filter;
		private TrayectoComentarioDataSet.ComentarioViajeDataTable  m_DataTable;
		private TrayectoComentarioDataSet m_DataSet;
		public TrayectoComentarioCollection(TrayectoComentarioDataSet.ComentarioViajeDataTable dataTable)
		{
			m_DataTable = dataTable;
			m_DataSet = (TrayectoComentarioDataSet) dataTable.DataSet;
		}
		
		public TrayectoComentarioCollection()
		{
			m_DataSet = new TrayectoComentarioDataSet ();
			m_DataTable = m_DataSet.ComentarioViaje;
		}		
		public string Filter
		{
			get { return m_Filter; }
			set { m_Filter = value; }
		}

		public TrayectoComentarioDataSet TrayectoComentarioDataSet
		{
			get { return m_DataSet; }
		}
						
		public TrayectoComentarioDataSet.ComentarioViajeDataTable ComentarioViajeDataTable
		{
			get { return m_DataTable; }
		}	
		
   
		public System.Int32 GetRecordCount(System.Int64 viajeID, System.Int32 trayectoID)
		{
			ITrayectoComentarioDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetTrayectoComentarioDataAdapter();
			return dataAdapter.GetRecordCount(viajeID, trayectoID);
		}

   
		public System.Int32 FillPage(System.Int64 viajeID, System.Int32 trayectoID, System.Int32 startRow, System.Int32 maxRows)
		{
			ITrayectoComentarioDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetTrayectoComentarioDataAdapter();
			dataAdapter.Filter = m_Filter;
			return dataAdapter.FillPage(m_DataSet, viajeID, trayectoID, startRow, maxRows);
		}

   
		public System.Int32 Fill(System.Int64 viajeID, System.Int32 trayectoID)
		{
			ITrayectoComentarioDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetTrayectoComentarioDataAdapter();
			dataAdapter.Filter = m_Filter;
			return dataAdapter.Fill(m_DataSet, viajeID, trayectoID);
		}

		#region IList Members
        object System.Collections.IList.this[int index]
		{
			get { return this[index]; }
			set { this[index] = (TrayectoComentario) value; }
		}

		void System.Collections.IList.Insert(int index, object value)
		{
			Insert(index, (TrayectoComentario) value);
		}

		void System.Collections.IList.Remove(object value)
		{
			Remove((TrayectoComentario) value);
		}

		bool System.Collections.IList.Contains(object value)
		{
			return Contains((TrayectoComentario) value);
		}

		int System.Collections.IList.IndexOf(object value)
		{
			return IndexOf( (TrayectoComentario) value);
		}

    	int System.Collections.IList.Add(object value)
		{
			return Add((TrayectoComentario) value);
		}
		
		public bool IsReadOnly
		{
			get { return false; }
		}
		
		public TrayectoComentario this[int index]
		{
			get
			{
				return new TrayectoComentario(m_DataTable[index]);
			}
			set
			{
				m_DataTable[index].ItemArray = ( (TrayectoComentario) value).ComentarioViajeRow.ItemArray;
			}
		}

		public void RemoveAt(int index)
		{
			m_DataTable[index].Delete();
		}

		public void Insert(int index, TrayectoComentario value)
		{
			Add(value);
		}

		public void Remove(TrayectoComentario value)
		{
			value.ComentarioViajeRow.Delete();		
		}

		public bool Contains(TrayectoComentario value)
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

		public int IndexOf(TrayectoComentario value)
		{
			for (int idx = 0; idx < m_DataTable.Count; idx++)
			{
				if (m_DataTable[idx].Equals(value.ComentarioViajeRow))
				{
					return idx;
				}
			}
			return -1;
		}

		public int Add(TrayectoComentario value)
		{
			m_DataTable.AddComentarioViajeRow( value.ComentarioViajeRow);
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
			
			private TrayectoComentarioDataSet.ComentarioViajeDataTable t;
			public CollectionEnumerator(TrayectoComentarioDataSet.ComentarioViajeDataTable t)
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
					return new TrayectoComentario((TrayectoComentarioDataSet.ComentarioViajeRow) t.Rows[position]);
				}
			}
		}
	}


}

