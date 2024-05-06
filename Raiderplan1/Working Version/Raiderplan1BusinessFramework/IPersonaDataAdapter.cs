
//               File: IPersonaDataAdapter
//        Description:
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5_0.002
//       Program type: proc
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   using System.Data;
   using System;
   public partial interface IPersonaDataAdapter
   {
       int Update( DataSet dataSet );
       int GetRecordCount( );
       int FillPage( PersonaDataSet dataSet ,
                     int startRow ,
                     int maxRows );
       int Fill( DataSet dataSet );
       int GetRecordCountByLoacaliadID( int loacaliadID );
       int FillPageByLoacaliadID( PersonaDataSet dataSet ,
                                  int loacaliadID ,
                                  int startRow ,
                                  int maxRows );
       int FillByLoacaliadID( PersonaDataSet dataSet ,
                              int loacaliadID );
       bool FillByPersonaID( PersonaDataSet dataSet ,
                             int personaID );
       int Fill( PersonaDataSet dataSet );
       int Fill( PersonaDataSet dataSet ,
                 int personaID );
   }

}
