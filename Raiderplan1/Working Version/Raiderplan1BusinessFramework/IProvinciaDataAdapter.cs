
//               File: IProvinciaDataAdapter
//        Description:
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5_0.002
//       Program type: proc
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   using System.Data;
   using System;
   public partial interface IProvinciaDataAdapter
   {
       int Update( DataSet dataSet );
       int GetRecordCount( );
       int FillPage( ProvinciaDataSet dataSet ,
                     int startRow ,
                     int maxRows );
       int Fill( DataSet dataSet );
       int GetRecordCountByPaisID( int paisID );
       int FillPageByPaisID( ProvinciaDataSet dataSet ,
                             int paisID ,
                             int startRow ,
                             int maxRows );
       int FillByPaisID( ProvinciaDataSet dataSet ,
                         int paisID );
       bool FillByProvinciaID( ProvinciaDataSet dataSet ,
                               int provinciaID );
       int Fill( ProvinciaDataSet dataSet );
       int Fill( ProvinciaDataSet dataSet ,
                 int provinciaID );
   }

}
