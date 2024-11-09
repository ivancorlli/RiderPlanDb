
namespace Raiderplan1
{
	using System;
    using System.Collections;
    using System.Data;
    using Raiderplan1;

    

	public partial class ComentarioViaje
	{
		private ComentarioViajeDataSet.ComentarioViajeRow m_DataRow;
		private ComentarioViajeDataSet m_DataSet;
		
		/// <summary>
		/// Creates a new <see cref="ComentarioViaje"/> instance.
		/// </summary>
		/// <param name="dataRow">Data row that will be wrapped by the Business Object.</param>		
		public ComentarioViaje(ComentarioViajeDataSet.ComentarioViajeRow dataRow)
		{
			m_DataRow = dataRow;
			m_DataSet = (ComentarioViajeDataSet) dataRow.Table.DataSet;
		}
		
		/// <summary>
		/// Creates a new <see cref="ComentarioViaje"/> instance.
		/// </summary>		
		public ComentarioViaje()
		{
			m_DataSet = new ComentarioViajeDataSet();
			m_DataRow = m_DataSet.ComentarioViaje.NewComentarioViajeRow();			
		}

		/// <summary>
		/// Gets the underlying ComentarioViajeDataSet
		/// </summary>
		/// <value></value>
		public ComentarioViajeDataSet ComentarioViajeDataSet
		{
			get { return m_DataSet; }
		}

		/// <summary>
		/// Gets the ComentarioViaje row attached to the Business Object instance
		/// </summary>
		/// <value></value>							
		public ComentarioViajeDataSet.ComentarioViajeRow ComentarioViajeRow
		{
			get { return m_DataRow; }
		}
		
 
		/// <summary>
		/// Loads the ComentarioViaje instance for a given pimary key value
		/// </summary>
		/// <param name="_ComentarioViajeID"> Comentario Viaje ID.</param>			
		/// <value></value>		
		public void Fill(System.Int32 _ComentarioViajeID )
		{
			//m_DataSet.Clear();
			m_DataSet = new ComentarioViajeDataSet();
			DataAdapterFactoryProxy.Instance.GetComentarioViajeDataAdapter().Fill(m_DataSet, _ComentarioViajeID);
			m_DataRow = m_DataSet.ComentarioViaje[0];
		}

		
		/// <summary>
		/// Updates this ComentarioViaje in the database
		/// </summary>
		public void Update()
		{
			if (m_DataRow.RowState == DataRowState.Detached)
			{
				m_DataSet.ComentarioViaje.AddComentarioViajeRow(m_DataRow);
			}
			DataAdapterFactoryProxy.Instance.GetComentarioViajeDataAdapter().Update(m_DataSet);
			if (m_DataSet.ComentarioViaje.Rows.Count > 0)
				m_DataRow = m_DataSet.ComentarioViaje[0];
		}
		
		/// <summary>
		/// Deletes this ComentarioViaje instance from the database
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
		/// Deletes this ComentarioViaje instance from the DataSet. It will be deleted
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
		/// Gets the Comentario Viaje ID
		/// </summary>        
		public System.Int32 ComentarioViajeID
		{
			get 
			{
				return m_DataRow.ComentarioViajeID;
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
		/// Gets or sets the Trayecto Viaje ID
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
		
		/// <summary>
		/// Gets or sets the "S"= Privado; Null = Privado; N ="Publico"
		/// </summary>        
		public System.String ComentarioPrivado
		{
			get 
			{
				return m_DataRow.ComentarioPrivado;
			}
			set
			{
				m_DataRow.ComentarioPrivado = value;
			}
		}
		



	}


    public partial class ComentarioViajeCollection : IList, ICollection, IEnumerable
    {		
		
		private ComentarioViajeDataSet.ComentarioViajeDataTable  m_DataTable;
		private ComentarioViajeDataSet m_DataSet;
		public ComentarioViajeCollection(ComentarioViajeDataSet.ComentarioViajeDataTable dataTable)
		{
			m_DataTable = dataTable;
			m_DataSet = (ComentarioViajeDataSet) dataTable.DataSet;
		}
		
		public ComentarioViajeCollection()
		{
			m_DataSet = new ComentarioViajeDataSet ();
			m_DataTable = m_DataSet.ComentarioViaje;
		}		
		public ComentarioViaje NewComentarioViaje()
		{
			return new ComentarioViaje(m_DataTable.NewComentarioViajeRow());
		}		
       
		public ComentarioViaje FindByComentarioViajeID(System.Int32 _ComentarioViajeID)
		{
			ComentarioViajeDataSet.ComentarioViajeRow row = m_DataTable.FindByComentarioViajeID(_ComentarioViajeID );
			return row == null?null: new ComentarioViaje(row);			
		}	


		public ComentarioViajeDataSet ComentarioViajeDataSet
		{
			get { return m_DataSet; }
		}
						
		public ComentarioViajeDataSet.ComentarioViajeDataTable ComentarioViajeDataTable
		{
			get { return m_DataTable; }
		}	
		
   
		public System.Int32 Update()
		{
			IComentarioViajeDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetComentarioViajeDataAdapter();
			return dataAdapter.Update(m_DataSet);
		}

   
		public System.Int32 GetRecordCount()
		{
			IComentarioViajeDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetComentarioViajeDataAdapter();
			return dataAdapter.GetRecordCount();
		}

   
		public System.Int32 FillPage(System.Int32 startRow, System.Int32 maxRows)
		{
			IComentarioViajeDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetComentarioViajeDataAdapter();
			return dataAdapter.FillPage(m_DataSet, startRow, maxRows);
		}

   
		public System.Int32 GetRecordCountByViajeID(System.Int64 viajeID)
		{
			IComentarioViajeDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetComentarioViajeDataAdapter();
			return dataAdapter.GetRecordCountByViajeID(viajeID);
		}

   
		public System.Int32 FillPageByViajeID(System.Int64 viajeID, System.Int32 startRow, System.Int32 maxRows)
		{
			IComentarioViajeDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetComentarioViajeDataAdapter();
			return dataAdapter.FillPageByViajeID(m_DataSet, viajeID, startRow, maxRows);
		}

   
		public System.Int32 FillByViajeID(System.Int64 viajeID)
		{
			IComentarioViajeDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetComentarioViajeDataAdapter();
			return dataAdapter.FillByViajeID(m_DataSet, viajeID);
		}

   
		public System.Int32 Fill()
		{
			IComentarioViajeDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetComentarioViajeDataAdapter();
			return dataAdapter.Fill(m_DataSet);
		}

		#region IList Members
        object System.Collections.IList.this[int index]
		{
			get { return this[index]; }
			set { this[index] = (ComentarioViaje) value; }
		}

		void System.Collections.IList.Insert(int index, object value)
		{
			Insert(index, (ComentarioViaje) value);
		}

		void System.Collections.IList.Remove(object value)
		{
			Remove((ComentarioViaje) value);
		}

		bool System.Collections.IList.Contains(object value)
		{
			return Contains((ComentarioViaje) value);
		}

		int System.Collections.IList.IndexOf(object value)
		{
			return IndexOf( (ComentarioViaje) value);
		}

    	int System.Collections.IList.Add(object value)
		{
			return Add((ComentarioViaje) value);
		}
		
		public bool IsReadOnly
		{
			get { return false; }
		}
		
		public ComentarioViaje this[int index]
		{
			get
			{
				return new ComentarioViaje(m_DataTable[index]);
			}
			set
			{
				m_DataTable[index].ItemArray = ( (ComentarioViaje) value).ComentarioViajeRow.ItemArray;
			}
		}

		public void RemoveAt(int index)
		{
			m_DataTable[index].Delete();
		}

		public void Insert(int index, ComentarioViaje value)
		{
			Add(value);
		}

		public void Remove(ComentarioViaje value)
		{
			value.ComentarioViajeRow.Delete();		
		}

		public bool Contains(ComentarioViaje value)
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

		public int IndexOf(ComentarioViaje value)
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

		public int Add(ComentarioViaje value)
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
			
			private ComentarioViajeDataSet.ComentarioViajeDataTable t;
			public CollectionEnumerator(ComentarioViajeDataSet.ComentarioViajeDataTable t)
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
					return new ComentarioViaje((ComentarioViajeDataSet.ComentarioViajeRow) t.Rows[position]);
				}
			}
		}
	}


}

