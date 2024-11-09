
//               File: IDataAdapterFactory
//        Description: No description for object
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5
//       Program type: Callable routine
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   public partial interface IDataAdapterFactory
   {
       IComentarioViajeDataAdapter GetComentarioViajeDataAdapter( );
       IViajesXUsuarioXOrigenXDestinoDataAdapter GetViajesXUsuarioXOrigenXDestinoDataAdapter( );
       IViajesRealizadosDataAdapter GetViajesRealizadosDataAdapter( );
       IViajesEnProgresoDataAdapter GetViajesEnProgresoDataAdapter( );
       IViajesEnPlanificacionDataAdapter GetViajesEnPlanificacionDataAdapter( );
       IViajesEliminadosDataAdapter GetViajesEliminadosDataAdapter( );
       IViajeDataAdapter GetViajeDataAdapter( );
       IUsuarioDataAdapter GetUsuarioDataAdapter( );
       ITrayectoViajeDataAdapter GetTrayectoViajeDataAdapter( );
       IRolUsuarioDataAdapter GetRolUsuarioDataAdapter( );
       IProvinciaDataAdapter GetProvinciaDataAdapter( );
       IPersonaDataAdapter GetPersonaDataAdapter( );
       IPaisDataAdapter GetPaisDataAdapter( );
       ILocalidadDataAdapter GetLocalidadDataAdapter( );
       ITrayectoComentarioDataAdapter GetTrayectoComentarioDataAdapter( );
       IdpUsuarioXEmailXusuarioIDCollectionDataAdapter GetdpUsuarioXEmailXusuarioIDCollectionDataAdapter( );
   }

}
