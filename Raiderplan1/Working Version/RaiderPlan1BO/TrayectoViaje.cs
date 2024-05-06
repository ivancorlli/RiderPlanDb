
namespace Raiderplan1
{
	using System;
    using System.Collections;
    using System.Data;
    using Raiderplan1;

    

	public partial class TrayectoViaje
	{
		private TrayectoViajeDataSet.TrayectoViajeRow m_DataRow;
		private TrayectoViajeDataSet m_DataSet;
		
		/// <summary>
		/// Creates a new <see cref="TrayectoViaje"/> instance.
		/// </summary>
		/// <param name="dataRow">Data row that will be wrapped by the Business Object.</param>		
		public TrayectoViaje(TrayectoViajeDataSet.TrayectoViajeRow dataRow)
		{
			m_DataRow = dataRow;
			m_DataSet = (TrayectoViajeDataSet) dataRow.Table.DataSet;
		}
		
		/// <summary>
		/// Creates a new <see cref="TrayectoViaje"/> instance.
		/// </summary>		
		public TrayectoViaje()
		{
			m_DataSet = new TrayectoViajeDataSet();
			m_DataRow = m_DataSet.TrayectoViaje.NewTrayectoViajeRow();			
		}

		/// <summary>
		/// Gets the underlying TrayectoViajeDataSet
		/// </summary>
		/// <value></value>
		public TrayectoViajeDataSet TrayectoViajeDataSet
		{
			get { return m_DataSet; }
		}

		/// <summary>
		/// Gets the TrayectoViaje row attached to the Business Object instance
		/// </summary>
		/// <value></value>							
		public TrayectoViajeDataSet.TrayectoViajeRow TrayectoViajeRow
		{
			get { return m_DataRow; }
		}
		
 
		/// <summary>
		/// Loads the TrayectoViaje instance for a given pimary key value
		/// </summary>
		/// <param name="_TrayectoViajeID"> Trayecto Viaje ID.</param>			
		/// <value></value>		
		public void Fill(System.Int32 _TrayectoViajeID )
		{
			//m_DataSet.Clear();
			m_DataSet = new TrayectoViajeDataSet();
			DataAdapterFactoryProxy.Instance.GetTrayectoViajeDataAdapter().Fill(m_DataSet, _TrayectoViajeID);
			m_DataRow = m_DataSet.TrayectoViaje[0];
		}

		
		/// <summary>
		/// Updates this TrayectoViaje in the database
		/// </summary>
		public void Update()
		{
			if (m_DataRow.RowState == DataRowState.Detached)
			{
				m_DataSet.TrayectoViaje.AddTrayectoViajeRow(m_DataRow);
			}
			DataAdapterFactoryProxy.Instance.GetTrayectoViajeDataAdapter().Update(m_DataSet);
			if (m_DataSet.TrayectoViaje.Rows.Count > 0)
				m_DataRow = m_DataSet.TrayectoViaje[0];
		}
		
		/// <summary>
		/// Deletes this TrayectoViaje instance from the database
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
		/// Deletes this TrayectoViaje instance from the DataSet. It will be deleted
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
		/// Gets the Trayecto Viaje ID
		/// </summary>        
		public System.Int32 TrayectoViajeID
		{
			get 
			{
				return m_DataRow.TrayectoViajeID;
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
		/// Gets or sets the Trayecto Origen
		/// </summary>        
		public System.String TrayectoOrigen
		{
			get 
			{
				return m_DataRow.TrayectoOrigen;
			}
			set
			{
				m_DataRow.TrayectoOrigen = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Trayecto Destino
		/// </summary>        
		public System.String TrayectoDestino
		{
			get 
			{
				return m_DataRow.TrayectoDestino;
			}
			set
			{
				m_DataRow.TrayectoDestino = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Tayecto Latitud Origen
		/// </summary>        
		public System.Decimal TayectoLatitudOrigen
		{
			get 
			{
				return m_DataRow.TayectoLatitudOrigen;
			}
			set
			{
				m_DataRow.TayectoLatitudOrigen = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Trayecto Longitud Origen
		/// </summary>        
		public System.Decimal TrayectoLongitudOrigen
		{
			get 
			{
				return m_DataRow.TrayectoLongitudOrigen;
			}
			set
			{
				m_DataRow.TrayectoLongitudOrigen = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Trayecto Latidud Destino
		/// </summary>        
		public System.Decimal TrayectoLatidudDestino
		{
			get 
			{
				return m_DataRow.TrayectoLatidudDestino;
			}
			set
			{
				m_DataRow.TrayectoLatidudDestino = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Trayecto Longitud Destino
		/// </summary>        
		public System.Decimal TrayectoLongitudDestino
		{
			get 
			{
				return m_DataRow.TrayectoLongitudDestino;
			}
			set
			{
				m_DataRow.TrayectoLongitudDestino = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Trayecto Km
		/// </summary>        
		public System.Decimal Trayectokm
		{
			get 
			{
				return m_DataRow.Trayectokm;
			}
			set
			{
				m_DataRow.Trayectokm = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Tiempo Estimado en horas
		/// </summary>        
		public System.Decimal TiempoEstimado
		{
			get 
			{
				return m_DataRow.TiempoEstimado;
			}
			set
			{
				m_DataRow.TiempoEstimado = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Combustible Consumido en litros
		/// </summary>        
		public System.Decimal CombustibleConsumido
		{
			get 
			{
				return m_DataRow.CombustibleConsumido;
			}
			set
			{
				m_DataRow.CombustibleConsumido = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Estado Carretera
		/// </summary>        
		public System.String EstadoCarretera
		{
			get 
			{
				return m_DataRow.EstadoCarretera;
			}
			set
			{
				m_DataRow.EstadoCarretera = value;
			}
		}
		


		/// <summary>
		/// Gets the Trayecto for this TrayectoViaje
		/// </summary>
		/// <value></value>		
		public TrayectoViajeTrayectoCollectionClass TrayectoViajeTrayectoCollection
		{
			get
			{
				return new TrayectoViajeTrayectoCollectionClass(	m_DataRow);
			}
		}
		

		/// <summary>
		/// Adds a child Trayecto to this TrayectoViaje
		/// </summary>
		/// <param name="trayectoviajetrayecto"> Trayecto.</param>
		public void Add( TrayectoViajeTrayecto trayectoviajetrayecto)
		{
			this.TrayectoViajeTrayectoCollection.Add(trayectoviajetrayecto);
		}
		
		/// <summary>
		/// Creates a new Trayecto instance
		/// </summary>
		public TrayectoViajeTrayecto NewTrayectoViajeTrayecto()
		{
			return this.TrayectoViajeTrayectoCollection.NewTrayectoViajeTrayecto();
		}
		


	public partial class TrayectoViajeTrayecto
	{
		private TrayectoViajeDataSet.TrayectoViajeTrayectoRow m_DataRow;
		private TrayectoViajeDataSet m_DataSet;
		
		/// <summary>
		/// Creates a new <see cref="TrayectoViajeTrayecto"/> instance.
		/// </summary>
		/// <param name="dataRow">Data row that will be wrapped by the Business Object.</param>		
		internal TrayectoViajeTrayecto(TrayectoViajeDataSet.TrayectoViajeTrayectoRow dataRow)
		{
			m_DataRow = dataRow;
			m_DataSet = (TrayectoViajeDataSet) dataRow.Table.DataSet;
		}
		

		/// <summary>
		/// Gets the underlying TrayectoViajeDataSet
		/// </summary>
		/// <value></value>
		public TrayectoViajeDataSet TrayectoViajeDataSet
		{
			get { return m_DataSet; }
		}

		/// <summary>
		/// Gets the TrayectoViajeTrayecto row attached to the Business Object instance
		/// </summary>
		/// <value></value>							
		public TrayectoViajeDataSet.TrayectoViajeTrayectoRow TrayectoViajeTrayectoRow
		{
			get { return m_DataRow; }
		}
		
		/// <summary>
		/// Deletes this TrayectoViaje from the child collection. 
		/// </summary>
		public void Remove()
		{
			m_DataRow.Delete();
		}	
		
		/// <summary>
		/// Gets or sets the Trayecto Viaje ID
		/// </summary>        
		public System.Int32 TrayectoViajeID
		{
			get 
			{
				return m_DataRow.TrayectoViajeID;
			}
			set
			{
				m_DataRow.TrayectoViajeID = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Trayecto Detalle
		/// </summary>        
		public System.Int32 TrayectoDetalleID
		{
			get 
			{
				return m_DataRow.TrayectoDetalleID;
			}
			set
			{
				m_DataRow.TrayectoDetalleID = value;
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
		/// Gets or sets the TD Descripcion
		/// </summary>        
		public System.String TDDescripcion
		{
			get 
			{
				return m_DataRow.TDDescripcion;
			}
			set
			{
				m_DataRow.TDDescripcion = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the TD Latitud
		/// </summary>        
		public System.Decimal TDLatitud
		{
			get 
			{
				return m_DataRow.TDLatitud;
			}
			set
			{
				m_DataRow.TDLatitud = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the TD Longitud
		/// </summary>        
		public System.Decimal TDLongitud
		{
			get 
			{
				return m_DataRow.TDLongitud;
			}
			set
			{
				m_DataRow.TDLongitud = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the TD Costo
		/// </summary>        
		public System.Decimal TDCosto
		{
			get 
			{
				return m_DataRow.TDCosto;
			}
			set
			{
				m_DataRow.TDCosto = value;
			}
		}
		



	}


    public partial class TrayectoViajeTrayectoCollectionClass : IList, ICollection, IEnumerable
    {		
		
		private TrayectoViajeDataSet.TrayectoViajeRow m_ParentRow;
		internal TrayectoViajeTrayectoCollectionClass(TrayectoViajeDataSet.TrayectoViajeRow parentRow)
		{
			m_ParentRow  = parentRow;
			if (m_ParentRow.RowState == DataRowState.Detached)
			{
				m_ParentRow.Table.Rows.Add(m_ParentRow);
			}
		}	
	
		public TrayectoViajeTrayecto NewTrayectoViajeTrayecto()
		{
			TrayectoViajeTrayecto ret = new TrayectoViajeTrayecto (((TrayectoViajeDataSet) m_ParentRow.Table.DataSet).TrayectoViajeTrayecto.NewTrayectoViajeTrayectoRow());			
			
					
	        ret.TrayectoViajeID = m_ParentRow.TrayectoViajeID;
			return ret;
		}
		
       
		public TrayectoViajeTrayecto FindByTrayectoDetalleID(System.Int32 _TrayectoDetalleID)
		{
			TrayectoViajeDataSet.TrayectoViajeTrayectoRow row = ((TrayectoViajeDataSet) m_ParentRow.Table.DataSet).TrayectoViajeTrayecto.FindByTrayectoViajeIDTrayectoDetalleID(m_ParentRow.TrayectoViajeID, _TrayectoDetalleID );
			return row == null?null: new TrayectoViajeTrayecto(row);			
		}	

		#region IList Members
        object System.Collections.IList.this[int index]
		{
			get { return this[index]; }
			set { this[index] = (TrayectoViajeTrayecto) value; }
		}

		void System.Collections.IList.Insert(int index, object value)
		{
			Insert(index, (TrayectoViajeTrayecto) value);
		}

		void System.Collections.IList.Remove(object value)
		{
			Remove((TrayectoViajeTrayecto) value);
		}

		bool System.Collections.IList.Contains(object value)
		{
			return Contains((TrayectoViajeTrayecto) value);
		}

		int System.Collections.IList.IndexOf(object value)
		{
			return IndexOf( (TrayectoViajeTrayecto) value);
		}

    	int System.Collections.IList.Add(object value)
		{
			return Add((TrayectoViajeTrayecto) value);
		}
		
		public bool IsReadOnly
		{
			get { return false; }
		}
		
		public TrayectoViajeTrayecto this[int index]
		{
			get
			{
				return new TrayectoViajeTrayecto(m_ParentRow.GetTrayectoViajeTrayectoRows()[index]);
			}
			set
			{
				m_ParentRow.GetTrayectoViajeTrayectoRows()[index].ItemArray = ( (TrayectoViajeTrayecto) value).TrayectoViajeTrayectoRow.ItemArray;
			}
		}

		public void RemoveAt(int index)
		{
			m_ParentRow.GetTrayectoViajeTrayectoRows()[index].Delete();
		}

		public void Insert(int index, TrayectoViajeTrayecto value)
		{
			Add(value);
		}

		public void Remove(TrayectoViajeTrayecto value)
		{
			value.TrayectoViajeTrayectoRow.Delete();		
		}

		public bool Contains(TrayectoViajeTrayecto value)
		{
			return IndexOf(value) != -1;
		}

		public void Clear()
		{
            foreach (DataRow row in m_ParentRow.GetTrayectoViajeTrayectoRows())
			{
				row.Delete();
			}
		}

		public int IndexOf(TrayectoViajeTrayecto value)
		{
			for (int idx = 0; idx < m_ParentRow.GetTrayectoViajeTrayectoRows().Length; idx++)
			{
				if (m_ParentRow.GetTrayectoViajeTrayectoRows()[idx].Equals(value.TrayectoViajeTrayectoRow))
				{
					return idx;
				}
			}
			return -1;
		}

		public int Add(TrayectoViajeTrayecto value)
		{
			((TrayectoViajeDataSet) m_ParentRow.Table.DataSet).TrayectoViajeTrayecto.AddTrayectoViajeTrayectoRow( ((TrayectoViajeTrayecto)value).TrayectoViajeTrayectoRow);
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
			get { return m_ParentRow.GetTrayectoViajeTrayectoRows().Length; }
		}

		public void CopyTo(Array array, int index)
		{
		
			m_ParentRow.GetTrayectoViajeTrayectoRows().CopyTo(array, index);
		}

		public object SyncRoot
		{
			get { return this; }
		}

		#endregion

		#region IEnumerable Members

		public IEnumerator GetEnumerator()
		{
			return new CollectionEnumerator(m_ParentRow.GetTrayectoViajeTrayectoRows());
		}

		#endregion
		
		// Inner class implements IEnumerator interface:
		private class CollectionEnumerator : IEnumerator		
		{
			private int position = -1;
			
			private TrayectoViajeDataSet.TrayectoViajeTrayectoRow[] t;

			public CollectionEnumerator(TrayectoViajeDataSet.TrayectoViajeTrayectoRow[] t)
			{
				this.t = t;
			}

			// Declare the MoveNext method required by IEnumerator:
			public bool MoveNext()
			{
				if (position < t.Length - 1)
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
					return new TrayectoViajeTrayecto((TrayectoViajeDataSet.TrayectoViajeTrayectoRow) t[position]);
				}
			}
		}
	}


	}


    public partial class TrayectoViajeCollection : IList, ICollection, IEnumerable
    {		
		
		private TrayectoViajeDataSet.TrayectoViajeDataTable  m_DataTable;
		private TrayectoViajeDataSet m_DataSet;
		public TrayectoViajeCollection(TrayectoViajeDataSet.TrayectoViajeDataTable dataTable)
		{
			m_DataTable = dataTable;
			m_DataSet = (TrayectoViajeDataSet) dataTable.DataSet;
		}
		
		public TrayectoViajeCollection()
		{
			m_DataSet = new TrayectoViajeDataSet ();
			m_DataTable = m_DataSet.TrayectoViaje;
		}		
		public TrayectoViaje NewTrayectoViaje()
		{
			return new TrayectoViaje(m_DataTable.NewTrayectoViajeRow());
		}		
       
		public TrayectoViaje FindByTrayectoViajeID(System.Int32 _TrayectoViajeID)
		{
			TrayectoViajeDataSet.TrayectoViajeRow row = m_DataTable.FindByTrayectoViajeID(_TrayectoViajeID );
			return row == null?null: new TrayectoViaje(row);			
		}	


		public TrayectoViajeDataSet TrayectoViajeDataSet
		{
			get { return m_DataSet; }
		}
						
		public TrayectoViajeDataSet.TrayectoViajeDataTable TrayectoViajeDataTable
		{
			get { return m_DataTable; }
		}	
		
   
		public System.Int32 Update()
		{
			ITrayectoViajeDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetTrayectoViajeDataAdapter();
			return dataAdapter.Update(m_DataSet);
		}

   
		public System.Int32 GetRecordCount()
		{
			ITrayectoViajeDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetTrayectoViajeDataAdapter();
			return dataAdapter.GetRecordCount();
		}

   
		public System.Int32 FillPage(System.Int32 startRow, System.Int32 maxRows)
		{
			ITrayectoViajeDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetTrayectoViajeDataAdapter();
			return dataAdapter.FillPage(m_DataSet, startRow, maxRows);
		}

   
		public System.Int32 GetRecordCountByViajeID(System.Int64 viajeID)
		{
			ITrayectoViajeDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetTrayectoViajeDataAdapter();
			return dataAdapter.GetRecordCountByViajeID(viajeID);
		}

   
		public System.Int32 FillPageByViajeID(System.Int64 viajeID, System.Int32 startRow, System.Int32 maxRows)
		{
			ITrayectoViajeDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetTrayectoViajeDataAdapter();
			return dataAdapter.FillPageByViajeID(m_DataSet, viajeID, startRow, maxRows);
		}

   
		public System.Int32 FillByViajeID(System.Int64 viajeID)
		{
			ITrayectoViajeDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetTrayectoViajeDataAdapter();
			return dataAdapter.FillByViajeID(m_DataSet, viajeID);
		}

   
		public System.Int32 Fill()
		{
			ITrayectoViajeDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetTrayectoViajeDataAdapter();
			return dataAdapter.Fill(m_DataSet);
		}

		#region IList Members
        object System.Collections.IList.this[int index]
		{
			get { return this[index]; }
			set { this[index] = (TrayectoViaje) value; }
		}

		void System.Collections.IList.Insert(int index, object value)
		{
			Insert(index, (TrayectoViaje) value);
		}

		void System.Collections.IList.Remove(object value)
		{
			Remove((TrayectoViaje) value);
		}

		bool System.Collections.IList.Contains(object value)
		{
			return Contains((TrayectoViaje) value);
		}

		int System.Collections.IList.IndexOf(object value)
		{
			return IndexOf( (TrayectoViaje) value);
		}

    	int System.Collections.IList.Add(object value)
		{
			return Add((TrayectoViaje) value);
		}
		
		public bool IsReadOnly
		{
			get { return false; }
		}
		
		public TrayectoViaje this[int index]
		{
			get
			{
				return new TrayectoViaje(m_DataTable[index]);
			}
			set
			{
				m_DataTable[index].ItemArray = ( (TrayectoViaje) value).TrayectoViajeRow.ItemArray;
			}
		}

		public void RemoveAt(int index)
		{
			m_DataTable[index].Delete();
		}

		public void Insert(int index, TrayectoViaje value)
		{
			Add(value);
		}

		public void Remove(TrayectoViaje value)
		{
			value.TrayectoViajeRow.Delete();		
		}

		public bool Contains(TrayectoViaje value)
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

		public int IndexOf(TrayectoViaje value)
		{
			for (int idx = 0; idx < m_DataTable.Count; idx++)
			{
				if (m_DataTable[idx].Equals(value.TrayectoViajeRow))
				{
					return idx;
				}
			}
			return -1;
		}

		public int Add(TrayectoViaje value)
		{
			m_DataTable.AddTrayectoViajeRow( value.TrayectoViajeRow);
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
			
			private TrayectoViajeDataSet.TrayectoViajeDataTable t;
			public CollectionEnumerator(TrayectoViajeDataSet.TrayectoViajeDataTable t)
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
					return new TrayectoViaje((TrayectoViajeDataSet.TrayectoViajeRow) t.Rows[position]);
				}
			}
		}
	}


}

