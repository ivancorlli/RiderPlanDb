
//               File: DataAdapterFactory
//        Description: No description for object
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5
//       Program type: Callable routine
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   public partial class DataAdapterFactory
   {
      private static IDataAdapterFactory daFactory ;
      public static IDataAdapterFactory Provider
      {
         get {
            return daFactory ;
         }

         set {
            daFactory = value ;
         }

      }

      public static IViajeDataAdapter GetViajeDataAdapter( )
      {
         return daFactory.GetViajeDataAdapter( ) ;
      }

      public static IUsuarioDataAdapter GetUsuarioDataAdapter( )
      {
         return daFactory.GetUsuarioDataAdapter( ) ;
      }

      public static ITrayectoViajeDataAdapter GetTrayectoViajeDataAdapter( )
      {
         return daFactory.GetTrayectoViajeDataAdapter( ) ;
      }

      public static IRolUsuarioDataAdapter GetRolUsuarioDataAdapter( )
      {
         return daFactory.GetRolUsuarioDataAdapter( ) ;
      }

      public static IProvinciaDataAdapter GetProvinciaDataAdapter( )
      {
         return daFactory.GetProvinciaDataAdapter( ) ;
      }

      public static IPersonaDataAdapter GetPersonaDataAdapter( )
      {
         return daFactory.GetPersonaDataAdapter( ) ;
      }

      public static IPaisDataAdapter GetPaisDataAdapter( )
      {
         return daFactory.GetPaisDataAdapter( ) ;
      }

      public static ILocalidadDataAdapter GetLocalidadDataAdapter( )
      {
         return daFactory.GetLocalidadDataAdapter( ) ;
      }

      public static IViajesRealizadosDataAdapter GetViajesRealizadosDataAdapter( )
      {
         return daFactory.GetViajesRealizadosDataAdapter( ) ;
      }

      public static IViajesEnProgresoDataAdapter GetViajesEnProgresoDataAdapter( )
      {
         return daFactory.GetViajesEnProgresoDataAdapter( ) ;
      }

      public static IViajesEnPlanificacionDataAdapter GetViajesEnPlanificacionDataAdapter( )
      {
         return daFactory.GetViajesEnPlanificacionDataAdapter( ) ;
      }

      public static IViajesEliminadosDataAdapter GetViajesEliminadosDataAdapter( )
      {
         return daFactory.GetViajesEliminadosDataAdapter( ) ;
      }

      public static IdpUsuarioXEmailXusuarioIDCollectionDataAdapter GetdpUsuarioXEmailXusuarioIDCollectionDataAdapter( )
      {
         return daFactory.GetdpUsuarioXEmailXusuarioIDCollectionDataAdapter( ) ;
      }

   }

}
