
//               File: SexoEnumeration
//        Description: Enumerated Type Sexo
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5
//       Program type:
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   public enum Sexo {Masculino=0, Femenino=1, Otro=2};
   public class SexoMetaData
   {
      public static string[] Descriptions = new string[] {"Masculino", "Femenino", "Otro"} ;
      public static Sexo[] Values = new Sexo[] {Sexo.Masculino, Sexo.Femenino, Sexo.Otro} ;
      public static string GetDescription( Sexo enumValue )
      {
         return Descriptions[System.Array.IndexOf( SexoMetaData.Values, enumValue)] ;
      }

   }

}
