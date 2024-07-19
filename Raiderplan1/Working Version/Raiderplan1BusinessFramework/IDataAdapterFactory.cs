
//               File: IDataAdapterFactory
//        Description: No description for object
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5
//       Program type: Callable routine
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   public partial interface IDataAdapterFactory
   {
       IViajeDataAdapter GetViajeDataAdapter( );
       IUsuarioDataAdapter GetUsuarioDataAdapter( );
       ITrayectoViajeDataAdapter GetTrayectoViajeDataAdapter( );
       IRolUsuarioDataAdapter GetRolUsuarioDataAdapter( );
       IProvinciaDataAdapter GetProvinciaDataAdapter( );
       IPersonaDataAdapter GetPersonaDataAdapter( );
       IPaisDataAdapter GetPaisDataAdapter( );
       ILocalidadDataAdapter GetLocalidadDataAdapter( );
       IdpUsuarioXEmailXusuarioIDCollectionDataAdapter GetdpUsuarioXEmailXusuarioIDCollectionDataAdapter( );
   }

}
