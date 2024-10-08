
//               File: ITrayectoComentarioDataAdapter
//        Description:
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5_0.002
//       Program type: proc
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   using System.Data;
   using System;
   public partial interface ITrayectoComentarioDataAdapter
   {
       int FillPage( TrayectoComentarioDataSet dataSet ,
                     int startRow ,
                     int maxRows );
       int Fill( TrayectoComentarioDataSet dataSet );
       int FillPage( DataSet dataSet ,
                     int startRow ,
                     int maxRows );
       int Fill( DataSet dataSet );
       int GetRecordCount( long viajeID ,
                           int trayectoID );
       int FillPage( TrayectoComentarioDataSet dataSet ,
                     long viajeID ,
                     int trayectoID ,
                     int startRow ,
                     int maxRows );
       int Fill( TrayectoComentarioDataSet dataSet ,
                 long viajeID ,
                 int trayectoID );
       String Filter
      {
         get;
         set;
      }
   }

}
