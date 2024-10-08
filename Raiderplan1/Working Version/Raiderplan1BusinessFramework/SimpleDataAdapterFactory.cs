
//               File: SimpleDataAdapterFactory
//        Description: No description for object
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5
//       Program type: Callable routine
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   using System.Data;
   using Deklarit.Data;
   using Deklarit.Configuration;
   using Microsoft.Practices.EnterpriseLibrary.PolicyInjection;
   public partial class SimpleDataAdapterFactory : IDataAdapterFactory, IConnectedDataAdapterFactory
   {
      public virtual ITrayectoComentarioDataAdapter GetTrayectoComentarioDataAdapter( )
      {
         return PolicyInjection.Create<TrayectoComentarioDataAdapter, ITrayectoComentarioDataAdapter>( ) ;
      }

      public virtual IComentarioViajeDataAdapter GetComentarioViajeDataAdapter( )
      {
         return PolicyInjection.Create<ComentarioViajeDataAdapter, IComentarioViajeDataAdapter>( ) ;
      }

      public virtual IViajeDataAdapter GetViajeDataAdapter( )
      {
         return PolicyInjection.Create<ViajeDataAdapter, IViajeDataAdapter>( ) ;
      }

      public virtual IUsuarioDataAdapter GetUsuarioDataAdapter( )
      {
         return PolicyInjection.Create<UsuarioDataAdapter, IUsuarioDataAdapter>( ) ;
      }

      public virtual ITrayectoViajeDataAdapter GetTrayectoViajeDataAdapter( )
      {
         return PolicyInjection.Create<TrayectoViajeDataAdapter, ITrayectoViajeDataAdapter>( ) ;
      }

      public virtual IRolUsuarioDataAdapter GetRolUsuarioDataAdapter( )
      {
         return PolicyInjection.Create<RolUsuarioDataAdapter, IRolUsuarioDataAdapter>( ) ;
      }

      public virtual IProvinciaDataAdapter GetProvinciaDataAdapter( )
      {
         return PolicyInjection.Create<ProvinciaDataAdapter, IProvinciaDataAdapter>( ) ;
      }

      public virtual IPersonaDataAdapter GetPersonaDataAdapter( )
      {
         return PolicyInjection.Create<PersonaDataAdapter, IPersonaDataAdapter>( ) ;
      }

      public virtual IPaisDataAdapter GetPaisDataAdapter( )
      {
         return PolicyInjection.Create<PaisDataAdapter, IPaisDataAdapter>( ) ;
      }

      public virtual ILocalidadDataAdapter GetLocalidadDataAdapter( )
      {
         return PolicyInjection.Create<LocalidadDataAdapter, ILocalidadDataAdapter>( ) ;
      }

      public virtual IViajesRealizadosDataAdapter GetViajesRealizadosDataAdapter( )
      {
         return PolicyInjection.Create<ViajesRealizadosDataAdapter, IViajesRealizadosDataAdapter>( ) ;
      }

      public virtual IViajesEnProgresoDataAdapter GetViajesEnProgresoDataAdapter( )
      {
         return PolicyInjection.Create<ViajesEnProgresoDataAdapter, IViajesEnProgresoDataAdapter>( ) ;
      }

      public virtual IViajesEnPlanificacionDataAdapter GetViajesEnPlanificacionDataAdapter( )
      {
         return PolicyInjection.Create<ViajesEnPlanificacionDataAdapter, IViajesEnPlanificacionDataAdapter>( ) ;
      }

      public virtual IViajesEliminadosDataAdapter GetViajesEliminadosDataAdapter( )
      {
         return PolicyInjection.Create<ViajesEliminadosDataAdapter, IViajesEliminadosDataAdapter>( ) ;
      }

      public virtual IdpUsuarioXEmailXusuarioIDCollectionDataAdapter GetdpUsuarioXEmailXusuarioIDCollectionDataAdapter( )
      {
         return PolicyInjection.Create<dpUsuarioXEmailXusuarioIDCollectionDataAdapter, IdpUsuarioXEmailXusuarioIDCollectionDataAdapter>( ) ;
      }

      public IDeklaritTransaction GetDeklaritTransaction( IsolationLevel level )
      {
         return new DeklaritTransaction( level) ;
      }

      public IDeklaritTransaction GetDeklaritTransaction( )
      {
         return new DeklaritTransaction( ) ;
      }

      public object EnterpriseLibraryConfigurationContext
      {
         get {
            return EnterpriseLibrary.Instance.ConfigurationContext ;
         }

         set {
            EnterpriseLibrary.Instance.ConfigurationContext = ((Microsoft.Practices.EnterpriseLibrary.Common.Configuration.IConfigurationSource)(value));
         }

      }

      public IDeklaritConfiguration IDeklaritConfiguration
      {
         get {
            return Configuration.Instance ;
         }

         set {
            Configuration.Instance = value ;
         }

      }

   }

}
