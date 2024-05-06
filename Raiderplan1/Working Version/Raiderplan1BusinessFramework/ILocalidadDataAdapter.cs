
//               File: ILocalidadDataAdapter
//        Description:
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5_0.002
//       Program type: proc
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   using System.Data;
   using System;
   public partial interface ILocalidadDataAdapter
   {
       int Update( DataSet dataSet );
       int GetRecordCount( );
       int FillPage( LocalidadDataSet dataSet ,
                     int startRow ,
                     int maxRows );
       int Fill( DataSet dataSet );
       int GetRecordCountByProvinciaID( int provinciaID );
       int FillPageByProvinciaID( LocalidadDataSet dataSet ,
                                  int provinciaID ,
                                  int startRow ,
                                  int maxRows );
       int FillByProvinciaID( LocalidadDataSet dataSet ,
                              int provinciaID );
       bool FillByLoacaliadID( LocalidadDataSet dataSet ,
                               int loacaliadID );
       int Fill( LocalidadDataSet dataSet );
       int Fill( LocalidadDataSet dataSet ,
                 int loacaliadID );
   }

}
