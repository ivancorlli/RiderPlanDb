
//               File: ITrayectoViajeDataAdapter
//        Description:
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5_0.002
//       Program type: proc
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   using System.Data;
   using System;
   public partial interface ITrayectoViajeDataAdapter
   {
       int Update( DataSet dataSet );
       int GetRecordCount( );
       int FillPage( TrayectoViajeDataSet dataSet ,
                     int startRow ,
                     int maxRows );
       int Fill( DataSet dataSet );
       int GetRecordCountByViajeID( long viajeID );
       int FillPageByViajeID( TrayectoViajeDataSet dataSet ,
                              long viajeID ,
                              int startRow ,
                              int maxRows );
       int FillByViajeID( TrayectoViajeDataSet dataSet ,
                          long viajeID );
       bool FillByTrayectoViajeID( TrayectoViajeDataSet dataSet ,
                                   int trayectoViajeID );
       int Fill( TrayectoViajeDataSet dataSet );
       int Fill( TrayectoViajeDataSet dataSet ,
                 int trayectoViajeID );
   }

}
