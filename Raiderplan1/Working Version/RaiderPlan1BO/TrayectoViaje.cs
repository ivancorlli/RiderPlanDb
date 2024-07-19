
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
		/// Gets or sets the Instrucciones
		/// </summary>        
		public System.String Instrucciones
		{
			get 
			{
				return m_DataRow.Instrucciones;
			}
			set
			{
				m_DataRow.Instrucciones = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Orden
		/// </summary>        
		public System.Int32 Orden
		{
			get 
			{
				return m_DataRow.Orden;
			}
			set
			{
				m_DataRow.Orden = value;
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

