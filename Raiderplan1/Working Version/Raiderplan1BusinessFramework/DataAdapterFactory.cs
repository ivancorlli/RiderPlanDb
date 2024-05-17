
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

      public static IdpUsuarioXEmailXusuarioIDCollectionDataAdapter GetdpUsuarioXEmailXusuarioIDCollectionDataAdapter( )
      {
         return daFactory.GetdpUsuarioXEmailXusuarioIDCollectionDataAdapter( ) ;
      }

      public static IUsuarioDataAdapter GetUsuarioDataAdapter( )
      {
         return daFactory.GetUsuarioDataAdapter( ) ;
      }

      public static IViajeDataAdapter GetViajeDataAdapter( )
      {
         return daFactory.GetViajeDataAdapter( ) ;
      }

      public static ITrayectoViajeDataAdapter GetTrayectoViajeDataAdapter( )
      {
         return daFactory.GetTrayectoViajeDataAdapter( ) ;
      }

      public static ITrayectoTipoDetalleDataAdapter GetTrayectoTipoDetalleDataAdapter( )
      {
         return daFactory.GetTrayectoTipoDetalleDataAdapter( ) ;
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

   }

}
