
//               File: IViajeDataAdapter
//        Description:
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5_0.002
//       Program type: proc
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   using System.Data;
   using System;
   public partial interface IViajeDataAdapter
   {
       int Update( DataSet dataSet );
       int GetRecordCount( );
       int FillPage( ViajeDataSet dataSet ,
                     int startRow ,
                     int maxRows );
       int Fill( DataSet dataSet );
       int GetRecordCountByUsuarioID( int usuarioID );
       int FillPageByUsuarioID( ViajeDataSet dataSet ,
                                int usuarioID ,
                                int startRow ,
                                int maxRows );
       int FillByUsuarioID( ViajeDataSet dataSet ,
                            int usuarioID );
       bool FillByViajeID( ViajeDataSet dataSet ,
                           long viajeID );
       int Fill( ViajeDataSet dataSet );
       int Fill( ViajeDataSet dataSet ,
                 long viajeID );
   }

}
