
//               File: IComentarioViajeDataAdapter
//        Description:
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5_0.002
//       Program type: proc
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   using System.Data;
   using System;
   public partial interface IComentarioViajeDataAdapter
   {
       int Update( DataSet dataSet );
       int GetRecordCount( );
       int FillPage( ComentarioViajeDataSet dataSet ,
                     int startRow ,
                     int maxRows );
       int Fill( DataSet dataSet );
       int GetRecordCountByViajeID( long viajeID );
       int FillPageByViajeID( ComentarioViajeDataSet dataSet ,
                              long viajeID ,
                              int startRow ,
                              int maxRows );
       int FillByViajeID( ComentarioViajeDataSet dataSet ,
                          long viajeID );
       bool FillByComentarioViajeID( ComentarioViajeDataSet dataSet ,
                                     int comentarioViajeID );
       int Fill( ComentarioViajeDataSet dataSet );
       int Fill( ComentarioViajeDataSet dataSet ,
                 int comentarioViajeID );
   }

}
