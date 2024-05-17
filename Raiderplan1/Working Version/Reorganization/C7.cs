
//               File: C7
//        Description: Conversion for table Usuario
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version eng
//       Program type: Callable routine
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1.Reorg {
   using System;
   using System.Collections;
   using Deklarit.Utils;
   using System.Threading;
   using Deklarit.Reorganization;
   using Raiderplan1.Reorg;
   using System.Data;
   using System.Data.SqlClient;
   using System.Data.Common;
   using Deklarit.Data;
   using System.Xml.Serialization;
   using System.Data.SqlTypes;
   public class c7
   {
      public event ReorganizationMessageEventHandler messageHandler;

      public c7( ref DataStore ds )
      {
         this.dsDefault = ds ;
         this.messageHandler = messageHandler ;
         connDefault = dsDefault.GetReadWriteConnection() ;
         Initialize( ) ;
      }

      public void AddMsg( string message )
      {
         if ( ( this.messageHandler != null ) )
         {
            this.messageHandler( this, new ReorganizationMessageEventArgs( message)) ;
         }
      }

      public void execute( )
      {
         Initialize();
         executePrivate();
      }

      void executePrivate( )
      {
         // DeKlarit formulas
         cmdBuffer=" SET IDENTITY_INSERT [GXA0007] ON "
         ;
         RGZ = connDefault.GetCommand(cmdBuffer,false);
         RGZ.IDbCommand.CommandTimeout = 0;
         RGZ.ExecuteStmt() ;
         cmC72 = connDefault.GetCommand("SELECT [CodigoValidation], [PersonaID], [UsuarioFechaAlta], [UsuarioPasword], [UsuarioEmail], [UsuarioActivo], [UsuarioNombre], [UsuarioID] FROM [Usuario] ",false);
         cmC72.ErrorMask = cmC72.ErrorMask  |  ErrorMask.Lock;
         C72 = cmC72.FetchData();
         while ( cmC72.HasMoreRows )
         {
            m_CodigoValidation = dsDefault.Db.GetString(C72, 0, ref m__CodigoValidationIsNull) ;
            m_PersonaID = dsDefault.Db.GetInt32(C72, 1, ref m__PersonaIDIsNull) ;
            m_UsuarioFechaAlta = dsDefault.Db.GetDateTime(C72, 2, ref m__UsuarioFechaAltaIsNull) ;
            m_UsuarioPasword = dsDefault.Db.GetString(C72, 3, ref m__UsuarioPaswordIsNull) ;
            m_UsuarioEmail = dsDefault.Db.GetString(C72, 4, ref m__UsuarioEmailIsNull) ;
            m_UsuarioActivo = dsDefault.Db.GetString(C72, 5, ref m__UsuarioActivoIsNull) ;
            m_UsuarioNombre = dsDefault.Db.GetString(C72, 6, ref m__UsuarioNombreIsNull) ;
            m_UsuarioID = dsDefault.Db.GetInt32(C72, 7, ref m__UsuarioIDIsNull) ;
            //
               // INSERT RECORD ON TABLE GXA0007
               //
            //
            AV2Usuario = m_UsuarioID ;
            AV3Usuario = m_UsuarioNombre ;
            AV4Usuario = m_UsuarioActivo ;
            AV5Usuario = m_UsuarioEmail ;
            if ( C72.IsDBNull(3) )
            {
               AV6Usuario = "" ;
               nV6Usuario = true ;
            }
            else
            {
               AV6Usuario = m_UsuarioPasword ;
               nV6Usuario = false ;
            }
            AV7Usuario = m_UsuarioFechaAlta ;
            AV8Persona = m_PersonaID ;
            if ( C72.IsDBNull(0) )
            {
               AV9CodigoV = "" ;
               nV9CodigoV = true ;
            }
            else
            {
               AV9CodigoV = m_CodigoValidation ;
               nV9CodigoV = false ;
            }
            AV10Codigo = "" ;
            nV10Codigo = true ;
            cmC73 = connDefault.GetCommand("INSERT INTO [GXA0007] ([UsuarioID], [UsuarioNombre], [UsuarioActivo], [UsuarioEmail], [UsuarioPasword], [UsuarioFechaAlta], [PersonaID], [CodigoValidation], [CodigoRecuperacion]) VALUES (@UsuarioID, @UsuarioNombre, @UsuarioActivo, @UsuarioEmail, @UsuarioPasword, @UsuarioFechaAlta, @PersonaID, @CodigoValidation, @CodigoRecuperacion)",false);
            if ( ( cmC73.IDbCommand.Parameters.Count == 0 ) )
            {
               cmC73.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioID", System.Data.DbType.Int32));
               cmC73.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioNombre", System.Data.DbType.AnsiString,50));
               cmC73.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioActivo", System.Data.DbType.AnsiString,1));
               cmC73.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioEmail", System.Data.DbType.AnsiString,60));
               cmC73.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioPasword", System.Data.DbType.AnsiString,70));
               cmC73.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@UsuarioFechaAlta", System.Data.DbType.Date));
               cmC73.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaID", System.Data.DbType.Int32));
               cmC73.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@CodigoValidation", System.Data.DbType.AnsiString,4));
               cmC73.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@CodigoRecuperacion", System.Data.DbType.AnsiString,4));
            }
            cmC73.ErrorMask = cmC73.ErrorMask  |  ErrorMask.DuplicateKeyError;
            // Using cursor C73
            cmC73.SetParameter(0, AV2Usuario);
            cmC73.SetParameter(1, AV3Usuario);
            cmC73.SetParameter(2, AV4Usuario);
            cmC73.SetParameter(3, AV5Usuario);
            cmC73.SetParameter(4, AV6Usuario, nV6Usuario);
            cmC73.SetParameterDateObject(5, AV7Usuario);
            cmC73.SetParameter(6, AV8Persona);
            cmC73.SetParameter(7, AV9CodigoV, nV9CodigoV);
            cmC73.SetParameter(8, AV10Codigo, nV10Codigo);
            cmC73.ExecuteStmt();
            if ( cmC73.DupKey )
            {
               Gx_err = 1 ;
               Gx_emsg = (String)(resourceManager.GetString("noupdate")) ;
            }
            else
            {
               Gx_err = 0 ;
               Gx_emsg = "" ;
            }
            // End Insert
            cmC72.HasMoreRows = C72.Read();
         }
         C72.Close();
         cmdBuffer=" SET IDENTITY_INSERT [GXA0007] OFF "
         ;
         RGZ = connDefault.GetCommand(cmdBuffer,false);
         RGZ.IDbCommand.CommandTimeout = 0;
         RGZ.ExecuteStmt() ;
         this.Cleanup();
      }

      protected void Cleanup( )
      {
      }

      // Custom Exceptions
      public void Initialize( )
      {
         resourceManager = Deklarit.Utils.ResourceManager.Instance ;
         resourceManagerTables = new System.Resources.ResourceManager( "Deklarit.Tables", System.Reflection.Assembly.GetExecutingAssembly()) ;
         cmdBuffer = "" ;
         scmdbuf = "" ;
         m__CodigoValidationIsNull = false ;
         m_CodigoValidation = "" ;
         m__PersonaIDIsNull = false ;
         m_PersonaID = 0 ;
         m__UsuarioFechaAltaIsNull = false ;
         m_UsuarioFechaAlta = (DateTime)(DateTime.MinValue) ;
         m__UsuarioPaswordIsNull = false ;
         m_UsuarioPasword = "" ;
         m__UsuarioEmailIsNull = false ;
         m_UsuarioEmail = "" ;
         m__UsuarioActivoIsNull = false ;
         m_UsuarioActivo = "" ;
         m__UsuarioNombreIsNull = false ;
         m_UsuarioNombre = "" ;
         m__UsuarioIDIsNull = false ;
         m_UsuarioID = 0 ;
         GIGXA0007 = 0 ;
         AV2Usuario = 0 ;
         AV3Usuario = "" ;
         AV4Usuario = "" ;
         AV5Usuario = "" ;
         AV6Usuario = "" ;
         nV6Usuario = false ;
         AV7Usuario = (DateTime)(DateTime.MinValue) ;
         AV8Persona = 0 ;
         AV9CodigoV = "" ;
         nV9CodigoV = false ;
         AV10Codigo = "" ;
         nV10Codigo = false ;
         Gx_err = 0 ;
         Gx_emsg = "" ;
         // GeneXus formulas.
         Gx_err = 0 ;
      }

      private short Gx_err ;
      private int m_PersonaID ;
      private int m_UsuarioID ;
      private int GIGXA0007 ;
      private int AV2Usuario ;
      private int AV8Persona ;
      private String cmdBuffer ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime m_UsuarioFechaAlta ;
      private DateTime AV7Usuario ;
      private bool m__CodigoValidationIsNull ;
      private bool m__PersonaIDIsNull ;
      private bool m__UsuarioFechaAltaIsNull ;
      private bool m__UsuarioPaswordIsNull ;
      private bool m__UsuarioEmailIsNull ;
      private bool m__UsuarioActivoIsNull ;
      private bool m__UsuarioNombreIsNull ;
      private bool m__UsuarioIDIsNull ;
      private bool nV6Usuario ;
      private bool nV9CodigoV ;
      private bool nV10Codigo ;
      private String m_CodigoValidation ;
      private String m_UsuarioPasword ;
      private String m_UsuarioEmail ;
      private String m_UsuarioActivo ;
      private String m_UsuarioNombre ;
      private String AV3Usuario ;
      private String AV4Usuario ;
      private String AV5Usuario ;
      private String AV6Usuario ;
      private String AV9CodigoV ;
      private String AV10Codigo ;
      private DataStore dsDefault ;
      private System.Resources.ResourceManager resourceManager ;
      private System.Resources.ResourceManager resourceManagerTables ;
      private ReadWriteConnection connDefault ;
      private ReadWriteCommand RGZ ;
      private ReadWriteCommand cmC72 ;
      private IDataReader C72 ;
      private ReadWriteCommand cmC73 ;
   }

}
