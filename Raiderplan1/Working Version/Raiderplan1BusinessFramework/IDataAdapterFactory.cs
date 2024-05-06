
//               File: IDataAdapterFactory
//        Description: No description for object
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5
//       Program type: Callable routine
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   public partial interface IDataAdapterFactory
   {
       IViajeDataAdapter GetViajeDataAdapter( );
       ITrayectoViajeDataAdapter GetTrayectoViajeDataAdapter( );
       ITrayectoTipoDetalleDataAdapter GetTrayectoTipoDetalleDataAdapter( );
       IPersonaDataAdapter GetPersonaDataAdapter( );
       IdpUsuarioXEmailXusuarioIDCollectionDataAdapter GetdpUsuarioXEmailXusuarioIDCollectionDataAdapter( );
       IUsuarioDataAdapter GetUsuarioDataAdapter( );
       IRolUsuarioDataAdapter GetRolUsuarioDataAdapter( );
       IProvinciaDataAdapter GetProvinciaDataAdapter( );
       IPaisDataAdapter GetPaisDataAdapter( );
       ILocalidadDataAdapter GetLocalidadDataAdapter( );
   }

}
