
namespace Raiderplan1
{
	using System;
    using System.Collections;
    using System.Data;
    using Raiderplan1;

    

	public partial class ViajesEnProgreso
	{
		private ViajesEnProgresoDataSet.ViajeRow m_DataRow;
		private ViajesEnProgresoDataSet m_DataSet;
		
		/// <summary>
		/// Creates a new <see cref="ViajesEnProgreso"/> instance.
		/// </summary>
		/// <param name="dataRow">Data row that will be wrapped by the Business Object.</param>		
		public ViajesEnProgreso(ViajesEnProgresoDataSet.ViajeRow dataRow)
		{
			m_DataRow = dataRow;
			m_DataSet = (ViajesEnProgresoDataSet) dataRow.Table.DataSet;
		}
		
		/// <summary>
		/// Creates a new <see cref="ViajesEnProgreso"/> instance.
		/// </summary>		
		public ViajesEnProgreso()
		{
			m_DataSet = new ViajesEnProgresoDataSet();
			m_DataRow = m_DataSet.Viaje.NewViajeRow();			
		}

		/// <summary>
		/// Gets the underlying ViajesEnProgresoDataSet
		/// </summary>
		/// <value></value>
		public ViajesEnProgresoDataSet ViajesEnProgresoDataSet
		{
			get { return m_DataSet; }
		}

		/// <summary>
		/// Gets the Viaje row attached to the Business Object instance
		/// </summary>
		/// <value></value>							
		public ViajesEnProgresoDataSet.ViajeRow ViajeRow
		{
			get { return m_DataRow; }
		}
		
		/// <summary>
		/// Deletes this ViajesEnProgreso from the child collection. 
		/// </summary>
		public void Remove()
		{
			m_DataRow.Delete();
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
		/// Gets or sets the Viaje Nombre
		/// </summary>        
		public System.String ViajeNombre
		{
			get 
			{
				return m_DataRow.ViajeNombre;
			}
			set
			{
				m_DataRow.ViajeNombre = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Fecha Salida
		/// </summary>        
		public System.DateTime FechaSalidaProgramada
		{
			get 
			{
				return m_DataRow.FechaSalidaProgramada;
			}
			set
			{
				m_DataRow.FechaSalidaProgramada = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Fecha Llegada
		/// </summary>        
		public System.DateTime FechaLlegadaProgramada
		{
			get 
			{
				return m_DataRow.FechaLlegadaProgramada;
			}
			set
			{
				m_DataRow.FechaLlegadaProgramada = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Fecha Salida Efectiva
		/// </summary>        
		public System.DateTime FechaSalidaEfectiva
		{
			get 
			{
				return m_DataRow.FechaSalidaEfectiva;
			}
			set
			{
				m_DataRow.FechaSalidaEfectiva = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Fecha Llegada Efectiva
		/// </summary>        
		public System.DateTime FechaLlegadaEfectiva
		{
			get 
			{
				return m_DataRow.FechaLlegadaEfectiva;
			}
			set
			{
				m_DataRow.FechaLlegadaEfectiva = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Lugar Partida
		/// </summary>        
		public System.String LugarPartida
		{
			get 
			{
				return m_DataRow.LugarPartida;
			}
			set
			{
				m_DataRow.LugarPartida = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Lugarllegada
		/// </summary>        
		public System.String Lugarllegada
		{
			get 
			{
				return m_DataRow.Lugarllegada;
			}
			set
			{
				m_DataRow.Lugarllegada = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Longitud Partida
		/// </summary>        
		public System.Decimal LongitudPartida
		{
			get 
			{
				return m_DataRow.LongitudPartida;
			}
			set
			{
				m_DataRow.LongitudPartida = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Latitud Partida
		/// </summary>        
		public System.Decimal LatitudPartida
		{
			get 
			{
				return m_DataRow.LatitudPartida;
			}
			set
			{
				m_DataRow.LatitudPartida = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Longitud Legada
		/// </summary>        
		public System.Decimal LongitudLegada
		{
			get 
			{
				return m_DataRow.LongitudLegada;
			}
			set
			{
				m_DataRow.LongitudLegada = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Latitud Llegada
		/// </summary>        
		public System.Decimal LatitudLlegada
		{
			get 
			{
				return m_DataRow.LatitudLlegada;
			}
			set
			{
				m_DataRow.LatitudLlegada = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the km Totales Estimado
		/// </summary>        
		public System.Decimal kmTotalesEstimado
		{
			get 
			{
				return m_DataRow.kmTotalesEstimado;
			}
			set
			{
				m_DataRow.kmTotalesEstimado = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Motocilceta
		/// </summary>        
		public System.String MotocilcetaMarca
		{
			get 
			{
				return m_DataRow.MotocilcetaMarca;
			}
			set
			{
				m_DataRow.MotocilcetaMarca = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Motocileta
		/// </summary>        
		public System.String MotociletaModelo
		{
			get 
			{
				return m_DataRow.MotociletaModelo;
			}
			set
			{
				m_DataRow.MotociletaModelo = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Viaje Imagen
		/// </summary>        
		public System.String ViajeImagen
		{
			get 
			{
				return m_DataRow.ViajeImagen;
			}
			set
			{
				m_DataRow.ViajeImagen = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the A = Activo (Planificacion); Z =Eliminado; P =Progreso; R = Realizado
		/// </summary>        
		public System.String ViajeEstado
		{
			get 
			{
				return m_DataRow.ViajeEstado;
			}
			set
			{
				m_DataRow.ViajeEstado = value;
			}
		}
		



	}


    public partial class ViajesEnProgresoCollection : IList, ICollection, IEnumerable
    {		
		
		private string m_Filter;
		private ViajesEnProgresoDataSet.ViajeDataTable  m_DataTable;
		private ViajesEnProgresoDataSet m_DataSet;
		public ViajesEnProgresoCollection(ViajesEnProgresoDataSet.ViajeDataTable dataTable)
		{
			m_DataTable = dataTable;
			m_DataSet = (ViajesEnProgresoDataSet) dataTable.DataSet;
		}
		
		public ViajesEnProgresoCollection()
		{
			m_DataSet = new ViajesEnProgresoDataSet ();
			m_DataTable = m_DataSet.Viaje;
		}		
		public string Filter
		{
			get { return m_Filter; }
			set { m_Filter = value; }
		}

		public ViajesEnProgresoDataSet ViajesEnProgresoDataSet
		{
			get { return m_DataSet; }
		}
						
		public ViajesEnProgresoDataSet.ViajeDataTable ViajeDataTable
		{
			get { return m_DataTable; }
		}	
		
   
		public System.Int32 GetRecordCount(System.Int32 usuarioID)
		{
			IViajesEnProgresoDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetViajesEnProgresoDataAdapter();
			return dataAdapter.GetRecordCount(usuarioID);
		}

   
		public System.Int32 FillPage(System.Int32 usuarioID, System.Int32 startRow, System.Int32 maxRows)
		{
			IViajesEnProgresoDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetViajesEnProgresoDataAdapter();
			dataAdapter.Filter = m_Filter;
			return dataAdapter.FillPage(m_DataSet, usuarioID, startRow, maxRows);
		}

   
		public System.Int32 Fill(System.Int32 usuarioID)
		{
			IViajesEnProgresoDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetViajesEnProgresoDataAdapter();
			dataAdapter.Filter = m_Filter;
			return dataAdapter.Fill(m_DataSet, usuarioID);
		}

		#region IList Members
        object System.Collections.IList.this[int index]
		{
			get { return this[index]; }
			set { this[index] = (ViajesEnProgreso) value; }
		}

		void System.Collections.IList.Insert(int index, object value)
		{
			Insert(index, (ViajesEnProgreso) value);
		}

		void System.Collections.IList.Remove(object value)
		{
			Remove((ViajesEnProgreso) value);
		}

		bool System.Collections.IList.Contains(object value)
		{
			return Contains((ViajesEnProgreso) value);
		}

		int System.Collections.IList.IndexOf(object value)
		{
			return IndexOf( (ViajesEnProgreso) value);
		}

    	int System.Collections.IList.Add(object value)
		{
			return Add((ViajesEnProgreso) value);
		}
		
		public bool IsReadOnly
		{
			get { return false; }
		}
		
		public ViajesEnProgreso this[int index]
		{
			get
			{
				return new ViajesEnProgreso(m_DataTable[index]);
			}
			set
			{
				m_DataTable[index].ItemArray = ( (ViajesEnProgreso) value).ViajeRow.ItemArray;
			}
		}

		public void RemoveAt(int index)
		{
			m_DataTable[index].Delete();
		}

		public void Insert(int index, ViajesEnProgreso value)
		{
			Add(value);
		}

		public void Remove(ViajesEnProgreso value)
		{
			value.ViajeRow.Delete();		
		}

		public bool Contains(ViajesEnProgreso value)
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

		public int IndexOf(ViajesEnProgreso value)
		{
			for (int idx = 0; idx < m_DataTable.Count; idx++)
			{
				if (m_DataTable[idx].Equals(value.ViajeRow))
				{
					return idx;
				}
			}
			return -1;
		}

		public int Add(ViajesEnProgreso value)
		{
			m_DataTable.AddViajeRow( value.ViajeRow);
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
			
			private ViajesEnProgresoDataSet.ViajeDataTable t;
			public CollectionEnumerator(ViajesEnProgresoDataSet.ViajeDataTable t)
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
					return new ViajesEnProgreso((ViajesEnProgresoDataSet.ViajeRow) t.Rows[position]);
				}
			}
		}
	}


}

