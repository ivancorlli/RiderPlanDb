
//               File: IViajesXUsuarioXOrigenXDestinoDataAdapter
//        Description:
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5_0.002
//       Program type: proc
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   using System.Data;
   using System;
   public partial interface IViajesXUsuarioXOrigenXDestinoDataAdapter
   {
       int FillPage( ViajesXUsuarioXOrigenXDestinoDataSet dataSet ,
                     int startRow ,
                     int maxRows );
       int Fill( ViajesXUsuarioXOrigenXDestinoDataSet dataSet );
       int FillPage( DataSet dataSet ,
                     int startRow ,
                     int maxRows );
       int Fill( DataSet dataSet );
       int GetRecordCount( int usuarioID ,
                           String origen ,
                           String destino );
       int FillPage( ViajesXUsuarioXOrigenXDestinoDataSet dataSet ,
                     int usuarioID ,
                     String origen ,
                     String destino ,
                     int startRow ,
                     int maxRows );
       int Fill( ViajesXUsuarioXOrigenXDestinoDataSet dataSet ,
                 int usuarioID ,
                 String origen ,
                 String destino );
   }

}
