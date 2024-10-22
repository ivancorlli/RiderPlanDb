
namespace Raiderplan1
{
	using System;
    using System.Collections;
    using System.Data;
    using Raiderplan1;

    

	public partial class Viaje
	{
		private ViajeDataSet.ViajeRow m_DataRow;
		private ViajeDataSet m_DataSet;
		
		/// <summary>
		/// Creates a new <see cref="Viaje"/> instance.
		/// </summary>
		/// <param name="dataRow">Data row that will be wrapped by the Business Object.</param>		
		public Viaje(ViajeDataSet.ViajeRow dataRow)
		{
			m_DataRow = dataRow;
			m_DataSet = (ViajeDataSet) dataRow.Table.DataSet;
		}
		
		/// <summary>
		/// Creates a new <see cref="Viaje"/> instance.
		/// </summary>		
		public Viaje()
		{
			m_DataSet = new ViajeDataSet();
			m_DataRow = m_DataSet.Viaje.NewViajeRow();			
		}

		/// <summary>
		/// Gets the underlying ViajeDataSet
		/// </summary>
		/// <value></value>
		public ViajeDataSet ViajeDataSet
		{
			get { return m_DataSet; }
		}

		/// <summary>
		/// Gets the Viaje row attached to the Business Object instance
		/// </summary>
		/// <value></value>							
		public ViajeDataSet.ViajeRow ViajeRow
		{
			get { return m_DataRow; }
		}
		
 
		/// <summary>
		/// Loads the Viaje instance for a given pimary key value
		/// </summary>
		/// <param name="_ViajeID"> Viaje ID.</param>			
		/// <value></value>		
		public void Fill(System.Int64 _ViajeID )
		{
			//m_DataSet.Clear();
			m_DataSet = new ViajeDataSet();
			DataAdapterFactoryProxy.Instance.GetViajeDataAdapter().Fill(m_DataSet, _ViajeID);
			m_DataRow = m_DataSet.Viaje[0];
		}

		
		/// <summary>
		/// Updates this Viaje in the database
		/// </summary>
		public void Update()
		{
			if (m_DataRow.RowState == DataRowState.Detached)
			{
				m_DataSet.Viaje.AddViajeRow(m_DataRow);
			}
			DataAdapterFactoryProxy.Instance.GetViajeDataAdapter().Update(m_DataSet);
			if (m_DataSet.Viaje.Rows.Count > 0)
				m_DataRow = m_DataSet.Viaje[0];
		}
		
		/// <summary>
		/// Deletes this Viaje instance from the database
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
		/// Deletes this Viaje instance from the DataSet. It will be deleted
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
		/// Gets the Viaje ID
		/// </summary>        
		public System.Int64 ViajeID
		{
			get 
			{
				return m_DataRow.ViajeID;
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
		/// Gets or sets the Motocilceta Marca
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
		/// Gets or sets the Motocileta Modelo(ej. Wave,XR,CB)
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
		/// Gets or sets the A = Activo (planificacion); Z =Inactivo (papelera); P = Progreso (iniciado); R = Realizado
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
		/// Gets or sets the Viaje Privado "S"= SI "N"=NO "null"=NO
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


    public partial class ViajeCollection : IList, ICollection, IEnumerable
    {		
		
		private ViajeDataSet.ViajeDataTable  m_DataTable;
		private ViajeDataSet m_DataSet;
		public ViajeCollection(ViajeDataSet.ViajeDataTable dataTable)
		{
			m_DataTable = dataTable;
			m_DataSet = (ViajeDataSet) dataTable.DataSet;
		}
		
		public ViajeCollection()
		{
			m_DataSet = new ViajeDataSet ();
			m_DataTable = m_DataSet.Viaje;
		}		
		public Viaje NewViaje()
		{
			return new Viaje(m_DataTable.NewViajeRow());
		}		
       
		public Viaje FindByViajeID(System.Int64 _ViajeID)
		{
			ViajeDataSet.ViajeRow row = m_DataTable.FindByViajeID(_ViajeID );
			return row == null?null: new Viaje(row);			
		}	


		public ViajeDataSet ViajeDataSet
		{
			get { return m_DataSet; }
		}
						
		public ViajeDataSet.ViajeDataTable ViajeDataTable
		{
			get { return m_DataTable; }
		}	
		
   
		public System.Int32 Update()
		{
			IViajeDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetViajeDataAdapter();
			return dataAdapter.Update(m_DataSet);
		}

   
		public System.Int32 GetRecordCount()
		{
			IViajeDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetViajeDataAdapter();
			return dataAdapter.GetRecordCount();
		}

   
		public System.Int32 FillPage(System.Int32 startRow, System.Int32 maxRows)
		{
			IViajeDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetViajeDataAdapter();
			return dataAdapter.FillPage(m_DataSet, startRow, maxRows);
		}

   
		public System.Int32 GetRecordCountByUsuarioID(System.Int32 usuarioID)
		{
			IViajeDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetViajeDataAdapter();
			return dataAdapter.GetRecordCountByUsuarioID(usuarioID);
		}

   
		public System.Int32 FillPageByUsuarioID(System.Int32 usuarioID, System.Int32 startRow, System.Int32 maxRows)
		{
			IViajeDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetViajeDataAdapter();
			return dataAdapter.FillPageByUsuarioID(m_DataSet, usuarioID, startRow, maxRows);
		}

   
		public System.Int32 FillByUsuarioID(System.Int32 usuarioID)
		{
			IViajeDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetViajeDataAdapter();
			return dataAdapter.FillByUsuarioID(m_DataSet, usuarioID);
		}

   
		public System.Int32 Fill()
		{
			IViajeDataAdapter dataAdapter = DataAdapterFactoryProxy.Instance.GetViajeDataAdapter();
			return dataAdapter.Fill(m_DataSet);
		}

		#region IList Members
        object System.Collections.IList.this[int index]
		{
			get { return this[index]; }
			set { this[index] = (Viaje) value; }
		}

		void System.Collections.IList.Insert(int index, object value)
		{
			Insert(index, (Viaje) value);
		}

		void System.Collections.IList.Remove(object value)
		{
			Remove((Viaje) value);
		}

		bool System.Collections.IList.Contains(object value)
		{
			return Contains((Viaje) value);
		}

		int System.Collections.IList.IndexOf(object value)
		{
			return IndexOf( (Viaje) value);
		}

    	int System.Collections.IList.Add(object value)
		{
			return Add((Viaje) value);
		}
		
		public bool IsReadOnly
		{
			get { return false; }
		}
		
		public Viaje this[int index]
		{
			get
			{
				return new Viaje(m_DataTable[index]);
			}
			set
			{
				m_DataTable[index].ItemArray = ( (Viaje) value).ViajeRow.ItemArray;
			}
		}

		public void RemoveAt(int index)
		{
			m_DataTable[index].Delete();
		}

		public void Insert(int index, Viaje value)
		{
			Add(value);
		}

		public void Remove(Viaje value)
		{
			value.ViajeRow.Delete();		
		}

		public bool Contains(Viaje value)
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

		public int IndexOf(Viaje value)
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

		public int Add(Viaje value)
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
			
			private ViajeDataSet.ViajeDataTable t;
			public CollectionEnumerator(ViajeDataSet.ViajeDataTable t)
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
					return new Viaje((ViajeDataSet.ViajeRow) t.Rows[position]);
				}
			}
		}
	}


}

