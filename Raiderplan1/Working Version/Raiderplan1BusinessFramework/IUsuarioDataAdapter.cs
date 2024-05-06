
//               File: IUsuarioDataAdapter
//        Description:
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5_0.002
//       Program type: proc
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   using System.Data;
   using System;
   public partial interface IUsuarioDataAdapter
   {
       int Update( DataSet dataSet );
       int GetRecordCount( );
       int FillPage( UsuarioDataSet dataSet ,
                     int startRow ,
                     int maxRows );
       int Fill( DataSet dataSet );
       int GetRecordCountByPersonaID( int personaID );
       int FillPageByPersonaID( UsuarioDataSet dataSet ,
                                int personaID ,
                                int startRow ,
                                int maxRows );
       int FillByPersonaID( UsuarioDataSet dataSet ,
                            int personaID );
       bool FillByUsuarioID( UsuarioDataSet dataSet ,
                             int usuarioID );
       int Fill( UsuarioDataSet dataSet );
       int Fill( UsuarioDataSet dataSet ,
                 int usuarioID );
   }

}
