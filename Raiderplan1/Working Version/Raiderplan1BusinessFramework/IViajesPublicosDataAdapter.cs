
//               File: IViajesPublicosDataAdapter
//        Description:
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5_0.002
//       Program type: proc
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   using System.Data;
   using System;
   public partial interface IViajesPublicosDataAdapter
   {
       int GetRecordCount( );
       int FillPage( ViajesPublicosDataSet dataSet ,
                     int startRow ,
                     int maxRows );
       int Fill( ViajesPublicosDataSet dataSet );
       int FillPage( DataSet dataSet ,
                     int startRow ,
                     int maxRows );
       int Fill( DataSet dataSet );
       String Filter
      {
         get;
         set;
      }
   }

}
