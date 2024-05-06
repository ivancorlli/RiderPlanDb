
//               File: IPaisDataAdapter
//        Description:
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5_0.002
//       Program type: proc
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   using System.Data;
   using System;
   public partial interface IPaisDataAdapter
   {
       int Update( DataSet dataSet );
       int GetRecordCount( );
       int FillPage( PaisDataSet dataSet ,
                     int startRow ,
                     int maxRows );
       int Fill( DataSet dataSet );
       bool FillByPaisID( PaisDataSet dataSet ,
                          int paisID );
       int Fill( PaisDataSet dataSet );
       int Fill( PaisDataSet dataSet ,
                 int paisID );
   }

}
