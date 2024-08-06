
namespace Raiderplan1
{
	using System;
    using System.Collections;
    using System.Data;
    using Raiderplan1;

    

	public partial class ViajesEnPlanificacion
	{
		private ViajesEnPlanificacionDataSet.ViajeRow m_DataRow;
		private ViajesEnPlanificacionDataSet m_DataSet;
		
		/// <summary>
		/// Creates a new <see cref="ViajesEnPlanificacion"/> instance.
		/// </summary>
		/// <param name="dataRow">Data row that will be wrapped by the Business Object.</param>		
		public ViajesEnPlanificacion(ViajesEnPlanificacionDataSet.ViajeRow dataRow)
		{
			m_DataRow = dataRow;
			m_DataSet = (ViajesEnPlanificacionDataSet) dataRow.Table.DataSet;
		}
		
		/// <summary>
		/// Creates a new <see cref="ViajesEnPlanificacion"/> instance.
		/// </summary>		
		public ViajesEnPlanificacion()
		{
			m_DataSet = new ViajesEnPlanificacionDataSet();
			m_DataRow = m_DataSet.Viaje.NewViajeRow();			
		}

		/// <summary>
		/// Gets the underlying ViajesEnPlanificacionDataSet
		/// </summary>
		/// <value></value>
		public ViajesEnPlanificacionDataSet ViajesEnPlanificacionDataSet
		{
			get { return m_DataSet; }
		}

		/// <summary>
		/// Gets the Viaje row attached to the Business Object instance
		/// </summary>
		/// <value></value>							
		public ViajesEnPlanificacionDataSet.ViajeRow ViajeRow
		{
			get { return m_DataRow; }
		}
		
		/// <summary>
		/// Deletes this ViajesEnPlanificacion from the child collection. 
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


    public partial class ViajesEnPlanificacionCollection : IList, ICollection, IEnumerable
    {		
		
		private string m_Filter;
		private ViajesEnPlanificacionDataSet.ViajeDataTable  m_DataTable;
		private ViajesEnPlanificacionDataSet m_DataSet;
		public ViajesEnPlanificacionCollection(ViajesEnPlanificacionDataSet.ViajeDataTable dataTable)
		{
			m_DataTable = dataTable;
			m_DataSet = (ViajesEnPlanificacionDataSet) dataTable.DataSet;
		}
		
		public ViajesEnPlanificacionCollection()
		{
			m_DataSet = new ViajesEnPlanificacionDataSet ();
			m_DataTable = m_DataSet.Viaje;
		}		
		public string Filter
		{
			get { return m_Filter; }
			set { m_Filter = value; }
		}

		public ViajesEnPlanificacionDataSet ViajesEnPlanificacionDataSet
		{
			get { return m_DataSet; }
		}
						
		public ViajesEnPlanificacionDataSet.ViajeDataTable ViajeDataTable
		{
			get { return m_DataTable; }
		}	
		
   
		public System.Int32 GetRecordCount(System.Int32 usuarioID)
		{
			IViajesEnPlanificacionDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetViajesEnPlanificacionDataAdapter();
			return dataAdapter.GetRecordCount(usuarioID);
		}

   
		public System.Int32 FillPage(System.Int32 usuarioID, System.Int32 startRow, System.Int32 maxRows)
		{
			IViajesEnPlanificacionDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetViajesEnPlanificacionDataAdapter();
			dataAdapter.Filter = m_Filter;
			return dataAdapter.FillPage(m_DataSet, usuarioID, startRow, maxRows);
		}

   
		public System.Int32 Fill(System.Int32 usuarioID)
		{
			IViajesEnPlanificacionDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetViajesEnPlanificacionDataAdapter();
			dataAdapter.Filter = m_Filter;
			return dataAdapter.Fill(m_DataSet, usuarioID);
		}

		#region IList Members
        object System.Collections.IList.this[int index]
		{
			get { return this[index]; }
			set { this[index] = (ViajesEnPlanificacion) value; }
		}

		void System.Collections.IList.Insert(int index, object value)
		{
			Insert(index, (ViajesEnPlanificacion) value);
		}

		void System.Collections.IList.Remove(object value)
		{
			Remove((ViajesEnPlanificacion) value);
		}

		bool System.Collections.IList.Contains(object value)
		{
			return Contains((ViajesEnPlanificacion) value);
		}

		int System.Collections.IList.IndexOf(object value)
		{
			return IndexOf( (ViajesEnPlanificacion) value);
		}

    	int System.Collections.IList.Add(object value)
		{
			return Add((ViajesEnPlanificacion) value);
		}
		
		public bool IsReadOnly
		{
			get { return false; }
		}
		
		public ViajesEnPlanificacion this[int index]
		{
			get
			{
				return new ViajesEnPlanificacion(m_DataTable[index]);
			}
			set
			{
				m_DataTable[index].ItemArray = ( (ViajesEnPlanificacion) value).ViajeRow.ItemArray;
			}
		}

		public void RemoveAt(int index)
		{
			m_DataTable[index].Delete();
		}

		public void Insert(int index, ViajesEnPlanificacion value)
		{
			Add(value);
		}

		public void Remove(ViajesEnPlanificacion value)
		{
			value.ViajeRow.Delete();		
		}

		public bool Contains(ViajesEnPlanificacion value)
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

		public int IndexOf(ViajesEnPlanificacion value)
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

		public int Add(ViajesEnPlanificacion value)
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
			
			private ViajesEnPlanificacionDataSet.ViajeDataTable t;
			public CollectionEnumerator(ViajesEnPlanificacionDataSet.ViajeDataTable t)
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
					return new ViajesEnPlanificacion((ViajesEnPlanificacionDataSet.ViajeRow) t.Rows[position]);
				}
			}
		}
	}


}

