
//               File: UsuarioRolEnumeration
//        Description: Enumerated Type UsuarioRol
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5
//       Program type:
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   public enum UsuarioRol {usuario=0, Admin=1, SuperUsuario=2};
   public class UsuarioRolMetaData
   {
      public static string[] Descriptions = new string[] {"usuario", "Admin", "Superusuario"} ;
      public static UsuarioRol[] Values = new UsuarioRol[] {UsuarioRol.usuario, UsuarioRol.Admin, UsuarioRol.SuperUsuario} ;
      public static string GetDescription( UsuarioRol enumValue )
      {
         return Descriptions[System.Array.IndexOf( UsuarioRolMetaData.Values, enumValue)] ;
      }

   }

}
