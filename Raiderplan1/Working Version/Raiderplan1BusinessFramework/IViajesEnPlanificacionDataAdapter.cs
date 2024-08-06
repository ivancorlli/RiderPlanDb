
//               File: IViajesEnPlanificacionDataAdapter
//        Description:
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5_0.002
//       Program type: proc
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   using System.Data;
   using System;
   public partial interface IViajesEnPlanificacionDataAdapter
   {
       int FillPage( ViajesEnPlanificacionDataSet dataSet ,
                     int startRow ,
                     int maxRows );
       int Fill( ViajesEnPlanificacionDataSet dataSet );
       int FillPage( DataSet dataSet ,
                     int startRow ,
                     int maxRows );
       int Fill( DataSet dataSet );
       int GetRecordCount( int usuarioID );
       int FillPage( ViajesEnPlanificacionDataSet dataSet ,
                     int usuarioID ,
                     int startRow ,
                     int maxRows );
       int Fill( ViajesEnPlanificacionDataSet dataSet ,
                 int usuarioID );
       String Filter
      {
         get;
         set;
      }
   }

}
