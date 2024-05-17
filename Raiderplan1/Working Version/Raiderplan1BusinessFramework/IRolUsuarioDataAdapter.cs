
//               File: IRolUsuarioDataAdapter
//        Description:
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5_0.002
//       Program type: proc
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   using System.Data;
   using System;
   public partial interface IRolUsuarioDataAdapter
   {
       int Update( DataSet dataSet );
       int GetRecordCount( );
       int FillPage( RolUsuarioDataSet dataSet ,
                     int startRow ,
                     int maxRows );
       int Fill( DataSet dataSet );
       int GetRecordCountByUsuarioID( int usuarioID );
       int FillPageByUsuarioID( RolUsuarioDataSet dataSet ,
                                int usuarioID ,
                                int startRow ,
                                int maxRows );
       int FillByUsuarioID( RolUsuarioDataSet dataSet ,
                            int usuarioID );
       bool FillByRolUsuarioID( RolUsuarioDataSet dataSet ,
                                short rolUsuarioID );
       int Fill( RolUsuarioDataSet dataSet );
       int Fill( RolUsuarioDataSet dataSet ,
                 short rolUsuarioID );
   }

}
