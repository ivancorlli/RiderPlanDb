
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

      public IViajeDataAdapter GetViajeDataAdapter( )
      {
         return dataAdapterFactory.GetViajeDataAdapter( ) ;
      }

      public ITrayectoViajeDataAdapter GetTrayectoViajeDataAdapter( )
      {
         return dataAdapterFactory.GetTrayectoViajeDataAdapter( ) ;
      }

      public ITrayectoTipoDetalleDataAdapter GetTrayectoTipoDetalleDataAdapter( )
      {
         return dataAdapterFactory.GetTrayectoTipoDetalleDataAdapter( ) ;
      }

      public IPersonaDataAdapter GetPersonaDataAdapter( )
      {
         return dataAdapterFactory.GetPersonaDataAdapter( ) ;
      }

      public IdpUsuarioXEmailXusuarioIDCollectionDataAdapter GetdpUsuarioXEmailXusuarioIDCollectionDataAdapter( )
      {
         return dataAdapterFactory.GetdpUsuarioXEmailXusuarioIDCollectionDataAdapter( ) ;
      }

      public IUsuarioDataAdapter GetUsuarioDataAdapter( )
      {
         return dataAdapterFactory.GetUsuarioDataAdapter( ) ;
      }

      public IRolUsuarioDataAdapter GetRolUsuarioDataAdapter( )
      {
         return dataAdapterFactory.GetRolUsuarioDataAdapter( ) ;
      }

      public IProvinciaDataAdapter GetProvinciaDataAdapter( )
      {
         return dataAdapterFactory.GetProvinciaDataAdapter( ) ;
      }

      public IPaisDataAdapter GetPaisDataAdapter( )
      {
         return dataAdapterFactory.GetPaisDataAdapter( ) ;
      }

      public ILocalidadDataAdapter GetLocalidadDataAdapter( )
      {
         return dataAdapterFactory.GetLocalidadDataAdapter( ) ;
      }

   }

}
