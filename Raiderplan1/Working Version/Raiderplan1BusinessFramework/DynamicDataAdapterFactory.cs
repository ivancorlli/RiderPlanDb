
//               File: DynamicDataAdapterFactory
//        Description: No description for object
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5
//       Program type: Callable routine
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   using System;
   using System.Reflection;
   using System.Configuration;
   public partial class DynamicDataAdapterFactory : Raiderplan1.IDataAdapterFactory
   {
      private IDataAdapterFactory dataAdapterFactory ;
      public DynamicDataAdapterFactory( Assembly factoryAssembly ,
                                        string factoryClass )
      {
         dataAdapterFactory = ((IDataAdapterFactory)(Activator.CreateInstance( factoryAssembly.GetType( factoryClass, true, false))));
      }

      public DynamicDataAdapterFactory( ) : this(Assembly.LoadFrom(ConfigurationManager.AppSettings["DataAdapterFactory"]), ConfigurationManager.AppSettings["DataAdapterFactoryClass"])
      {
      }

      public DynamicDataAdapterFactory( string typeName )
      {
         dataAdapterFactory = ((IDataAdapterFactory)(Activator.CreateInstance( Type.GetType( typeName, true))));
      }

      public IDataAdapterFactory IDataAdapterFactory
      {
         get {
            return dataAdapterFactory ;
         }

         set {
            dataAdapterFactory = value ;
         }

      }

      public IComentarioViajeDataAdapter GetComentarioViajeDataAdapter( )
      {
         return dataAdapterFactory.GetComentarioViajeDataAdapter( ) ;
      }

      public IViajesXUsuarioXOrigenXDestinoDataAdapter GetViajesXUsuarioXOrigenXDestinoDataAdapter( )
      {
         return dataAdapterFactory.GetViajesXUsuarioXOrigenXDestinoDataAdapter( ) ;
      }

      public IViajesRealizadosDataAdapter GetViajesRealizadosDataAdapter( )
      {
         return dataAdapterFactory.GetViajesRealizadosDataAdapter( ) ;
      }

      public IViajesEnProgresoDataAdapter GetViajesEnProgresoDataAdapter( )
      {
         return dataAdapterFactory.GetViajesEnProgresoDataAdapter( ) ;
      }

      public IViajesEnPlanificacionDataAdapter GetViajesEnPlanificacionDataAdapter( )
      {
         return dataAdapterFactory.GetViajesEnPlanificacionDataAdapter( ) ;
      }

      public IViajesEliminadosDataAdapter GetViajesEliminadosDataAdapter( )
      {
         return dataAdapterFactory.GetViajesEliminadosDataAdapter( ) ;
      }

      public IViajeDataAdapter GetViajeDataAdapter( )
      {
         return dataAdapterFactory.GetViajeDataAdapter( ) ;
      }

      public IUsuarioDataAdapter GetUsuarioDataAdapter( )
      {
         return dataAdapterFactory.GetUsuarioDataAdapter( ) ;
      }

      public ITrayectoViajeDataAdapter GetTrayectoViajeDataAdapter( )
      {
         return dataAdapterFactory.GetTrayectoViajeDataAdapter( ) ;
      }

      public IRolUsuarioDataAdapter GetRolUsuarioDataAdapter( )
      {
         return dataAdapterFactory.GetRolUsuarioDataAdapter( ) ;
      }

      public IProvinciaDataAdapter GetProvinciaDataAdapter( )
      {
         return dataAdapterFactory.GetProvinciaDataAdapter( ) ;
      }

      public IPersonaDataAdapter GetPersonaDataAdapter( )
      {
         return dataAdapterFactory.GetPersonaDataAdapter( ) ;
      }

      public IPaisDataAdapter GetPaisDataAdapter( )
      {
         return dataAdapterFactory.GetPaisDataAdapter( ) ;
      }

      public ILocalidadDataAdapter GetLocalidadDataAdapter( )
      {
         return dataAdapterFactory.GetLocalidadDataAdapter( ) ;
      }

      public ITrayectoComentarioDataAdapter GetTrayectoComentarioDataAdapter( )
      {
         return dataAdapterFactory.GetTrayectoComentarioDataAdapter( ) ;
      }

      public IdpUsuarioXEmailXusuarioIDCollectionDataAdapter GetdpUsuarioXEmailXusuarioIDCollectionDataAdapter( )
      {
         return dataAdapterFactory.GetdpUsuarioXEmailXusuarioIDCollectionDataAdapter( ) ;
      }

   }

}
