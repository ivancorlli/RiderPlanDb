
namespace Raiderplan1
{
	using System;
    using System.Collections;
    using System.Data;
    using Raiderplan1;

    

	public partial class ViajesXUsuarioXOrigenXDestino
	{
		private ViajesXUsuarioXOrigenXDestinoDataSet.ViajeRow m_DataRow;
		private ViajesXUsuarioXOrigenXDestinoDataSet m_DataSet;
		
		/// <summary>
		/// Creates a new <see cref="ViajesXUsuarioXOrigenXDestino"/> instance.
		/// </summary>
		/// <param name="dataRow">Data row that will be wrapped by the Business Object.</param>		
		public ViajesXUsuarioXOrigenXDestino(ViajesXUsuarioXOrigenXDestinoDataSet.ViajeRow dataRow)
		{
			m_DataRow = dataRow;
			m_DataSet = (ViajesXUsuarioXOrigenXDestinoDataSet) dataRow.Table.DataSet;
		}
		
		/// <summary>
		/// Creates a new <see cref="ViajesXUsuarioXOrigenXDestino"/> instance.
		/// </summary>		
		public ViajesXUsuarioXOrigenXDestino()
		{
			m_DataSet = new ViajesXUsuarioXOrigenXDestinoDataSet();
			m_DataRow = m_DataSet.Viaje.NewViajeRow();			
		}

		/// <summary>
		/// Gets the underlying ViajesXUsuarioXOrigenXDestinoDataSet
		/// </summary>
		/// <value></value>
		public ViajesXUsuarioXOrigenXDestinoDataSet ViajesXUsuarioXOrigenXDestinoDataSet
		{
			get { return m_DataSet; }
		}

		/// <summary>
		/// Gets the Viaje row attached to the Business Object instance
		/// </summary>
		/// <value></value>							
		public ViajesXUsuarioXOrigenXDestinoDataSet.ViajeRow ViajeRow
		{
			get { return m_DataRow; }
		}
		
		/// <summary>
		/// Deletes this ViajesXUsuarioXOrigenXDestino from the child collection. 
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
		
		/// <summary>
		/// Gets or sets the Viaje Fecha Creacion
		/// </summary>        
		public System.DateTime ViajeFechaCreacion
		{
			get 
			{
				return m_DataRow.ViajeFechaCreacion;
			}
			set
			{
				m_DataRow.ViajeFechaCreacion = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Viaje Me Gusta
		/// </summary>        
		public System.Int32 ViajeMeGustas
		{
			get 
			{
				return m_DataRow.ViajeMeGustas;
			}
			set
			{
				m_DataRow.ViajeMeGustas = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Viaje Descargas
		/// </summary>        
		public System.Int32 ViajeDescargas
		{
			get 
			{
				return m_DataRow.ViajeDescargas;
			}
			set
			{
				m_DataRow.ViajeDescargas = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Viaje Parent ID
		/// </summary>        
		public System.Int64 ViajeParentID
		{
			get 
			{
				return m_DataRow.ViajeParentID;
			}
			set
			{
				m_DataRow.ViajeParentID = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Viaje Privado
		/// </summary>        
		public System.String ViajePrivado
		{
			get 
			{
				return m_DataRow.ViajePrivado;
			}
			set
			{
				m_DataRow.ViajePrivado = value;
			}
		}
		



	}


    public partial class ViajesXUsuarioXOrigenXDestinoCollection : IList, ICollection, IEnumerable
    {		
		
		private ViajesXUsuarioXOrigenXDestinoDataSet.ViajeDataTable  m_DataTable;
		private ViajesXUsuarioXOrigenXDestinoDataSet m_DataSet;
		public ViajesXUsuarioXOrigenXDestinoCollection(ViajesXUsuarioXOrigenXDestinoDataSet.ViajeDataTable dataTable)
		{
			m_DataTable = dataTable;
			m_DataSet = (ViajesXUsuarioXOrigenXDestinoDataSet) dataTable.DataSet;
		}
		
		public ViajesXUsuarioXOrigenXDestinoCollection()
		{
			m_DataSet = new ViajesXUsuarioXOrigenXDestinoDataSet ();
			m_DataTable = m_DataSet.Viaje;
		}		

		public ViajesXUsuarioXOrigenXDestinoDataSet ViajesXUsuarioXOrigenXDestinoDataSet
		{
			get { return m_DataSet; }
		}
						
		public ViajesXUsuarioXOrigenXDestinoDataSet.ViajeDataTable ViajeDataTable
		{
			get { return m_DataTable; }
		}	
		
   
		public System.Int32 GetRecordCount(System.Int32 usuarioID, System.String origen, System.String destino)
		{
			IViajesXUsuarioXOrigenXDestinoDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetViajesXUsuarioXOrigenXDestinoDataAdapter();
			return dataAdapter.GetRecordCount(usuarioID, origen, destino);
		}

   
		public System.Int32 FillPage(System.Int32 usuarioID, System.String origen, System.String destino, System.Int32 startRow, System.Int32 maxRows)
		{
			IViajesXUsuarioXOrigenXDestinoDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetViajesXUsuarioXOrigenXDestinoDataAdapter();
			return dataAdapter.FillPage(m_DataSet, usuarioID, origen, destino, startRow, maxRows);
		}

   
		public System.Int32 Fill(System.Int32 usuarioID, System.String origen, System.String destino)
		{
			IViajesXUsuarioXOrigenXDestinoDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetViajesXUsuarioXOrigenXDestinoDataAdapter();
			return dataAdapter.Fill(m_DataSet, usuarioID, origen, destino);
		}

		#region IList Members
        object System.Collections.IList.this[int index]
		{
			get { return this[index]; }
			set { this[index] = (ViajesXUsuarioXOrigenXDestino) value; }
		}

		void System.Collections.IList.Insert(int index, object value)
		{
			Insert(index, (ViajesXUsuarioXOrigenXDestino) value);
		}

		void System.Collections.IList.Remove(object value)
		{
			Remove((ViajesXUsuarioXOrigenXDestino) value);
		}

		bool System.Collections.IList.Contains(object value)
		{
			return Contains((ViajesXUsuarioXOrigenXDestino) value);
		}

		int System.Collections.IList.IndexOf(object value)
		{
			return IndexOf( (ViajesXUsuarioXOrigenXDestino) value);
		}

    	int System.Collections.IList.Add(object value)
		{
			return Add((ViajesXUsuarioXOrigenXDestino) value);
		}
		
		public bool IsReadOnly
		{
			get { return false; }
		}
		
		public ViajesXUsuarioXOrigenXDestino this[int index]
		{
			get
			{
				return new ViajesXUsuarioXOrigenXDestino(m_DataTable[index]);
			}
			set
			{
				m_DataTable[index].ItemArray = ( (ViajesXUsuarioXOrigenXDestino) value).ViajeRow.ItemArray;
			}
		}

		public void RemoveAt(int index)
		{
			m_DataTable[index].Delete();
		}

		public void Insert(int index, ViajesXUsuarioXOrigenXDestino value)
		{
			Add(value);
		}

		public void Remove(ViajesXUsuarioXOrigenXDestino value)
		{
			value.ViajeRow.Delete();		
		}

		public bool Contains(ViajesXUsuarioXOrigenXDestino value)
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

		public int IndexOf(ViajesXUsuarioXOrigenXDestino value)
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

		public int Add(ViajesXUsuarioXOrigenXDestino value)
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
			
			private ViajesXUsuarioXOrigenXDestinoDataSet.ViajeDataTable t;
			public CollectionEnumerator(ViajesXUsuarioXOrigenXDestinoDataSet.ViajeDataTable t)
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
					return new ViajesXUsuarioXOrigenXDestino((ViajesXUsuarioXOrigenXDestinoDataSet.ViajeRow) t.Rows[position]);
				}
			}
		}
	}


}

