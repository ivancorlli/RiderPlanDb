
//               File: IdpUsuarioXEmailXusuarioIDCollectionDataAdapter
//        Description:
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5_0.002
//       Program type: proc
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   using System.Data;
   using System;
   public partial interface IdpUsuarioXEmailXusuarioIDCollectionDataAdapter
   {
       int FillPage( dpUsuarioXEmailXusuarioIDCollectionDataSet dataSet ,
                     int startRow ,
                     int maxRows );
       int Fill( dpUsuarioXEmailXusuarioIDCollectionDataSet dataSet );
       int FillPage( DataSet dataSet ,
                     int startRow ,
                     int maxRows );
       int Fill( DataSet dataSet );
       int GetRecordCount( String email ,
                           String nombreUsuario );
       int FillPage( dpUsuarioXEmailXusuarioIDCollectionDataSet dataSet ,
                     String email ,
                     String nombreUsuario ,
                     int startRow ,
                     int maxRows );
       int Fill( dpUsuarioXEmailXusuarioIDCollectionDataSet dataSet ,
                 String email ,
                 String nombreUsuario );
   }

}
