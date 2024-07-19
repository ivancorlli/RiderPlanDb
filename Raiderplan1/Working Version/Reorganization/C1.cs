
//               File: C1
//        Description: Conversion for table Persona
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
   public class c1
   {
      public event ReorganizationMessageEventHandler messageHandler;

      public c1( ref DataStore ds )
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
         cmdBuffer=" SET IDENTITY_INSERT [GXA0001] ON "
         ;
         RGZ = connDefault.GetCommand(cmdBuffer,false);
         RGZ.IDbCommand.CommandTimeout = 0;
         RGZ.ExecuteStmt() ;
         cmC12 = connDefault.GetCommand("SELECT [PLocalidadID], [PProvinciaID], [ImagenPerfil], [PersonaSexo], [PersonaFechaNacimiento], [PersonaApellido], [PersonaNombre], [PersonaID] FROM [Persona] ",false);
         cmC12.ErrorMask = cmC12.ErrorMask  |  ErrorMask.Lock;
         C12 = cmC12.FetchData();
         while ( cmC12.HasMoreRows )
         {
            m_PLocalidadID = dsDefault.Db.GetInt32(C12, 0, ref m__PLocalidadIDIsNull) ;
            m_PProvinciaID = dsDefault.Db.GetInt32(C12, 1, ref m__PProvinciaIDIsNull) ;
            m_ImagenPerfil = dsDefault.Db.GetString(C12, 2, ref m__ImagenPerfilIsNull) ;
            m_PersonaSexo = dsDefault.Db.GetInt16(C12, 3, ref m__PersonaSexoIsNull) ;
            m_PersonaFechaNacimiento = dsDefault.Db.GetDateTime(C12, 4, ref m__PersonaFechaNacimientoIsNull) ;
            m_PersonaApellido = dsDefault.Db.GetString(C12, 5, ref m__PersonaApellidoIsNull) ;
            m_PersonaNombre = dsDefault.Db.GetString(C12, 6, ref m__PersonaNombreIsNull) ;
            m_PersonaID = dsDefault.Db.GetInt32(C12, 7, ref m__PersonaIDIsNull) ;
            //
               // INSERT RECORD ON TABLE GXA0001
               //
            //
            AV2Persona = m_PersonaID ;
            AV3Persona = m_PersonaNombre ;
            AV4Persona = m_PersonaApellido ;
            AV5Persona = m_PersonaFechaNacimiento ;
            AV6Persona = m_PersonaSexo ;
            if ( C12.IsDBNull(2) )
            {
               AV7ImagenP = "" ;
               nV7ImagenP = true ;
            }
            else
            {
               AV7ImagenP = m_ImagenPerfil ;
               nV7ImagenP = false ;
            }
            if ( C12.IsDBNull(1) )
            {
               AV8PProvin = 0 ;
               nV8PProvin = true ;
            }
            else
            {
               AV8PProvin = m_PProvinciaID ;
               nV8PProvin = false ;
            }
            if ( C12.IsDBNull(0) )
            {
               AV9PLocali = 0 ;
               nV9PLocali = true ;
            }
            else
            {
               AV9PLocali = m_PLocalidadID ;
               nV9PLocali = false ;
            }
            cmC13 = connDefault.GetCommand("INSERT INTO [GXA0001] ([PersonaID], [PersonaNombre], [PersonaApellido], [PersonaFechaNacimiento], [PersonaSexo], [ImagenPerfil], [PProvinciaID], [PLocalidadID]) VALUES (@PersonaID, @PersonaNombre, @PersonaApellido, @PersonaFechaNacimiento, @PersonaSexo, @ImagenPerfil, @PProvinciaID, @PLocalidadID)",false);
            if ( ( cmC13.IDbCommand.Parameters.Count == 0 ) )
            {
               cmC13.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaID", System.Data.DbType.Int32));
               cmC13.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaNombre", System.Data.DbType.AnsiString,120));
               cmC13.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaApellido", System.Data.DbType.AnsiString,120));
               cmC13.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaFechaNacimiento", System.Data.DbType.Date));
               cmC13.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaSexo", System.Data.DbType.Int16));
               cmC13.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ImagenPerfil", System.Data.DbType.AnsiString,50));
               cmC13.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PProvinciaID", System.Data.DbType.Int32));
               cmC13.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PLocalidadID", System.Data.DbType.Int32));
            }
            cmC13.ErrorMask = cmC13.ErrorMask  |  ErrorMask.DuplicateKeyError;
            // Using cursor C13
            cmC13.SetParameter(0, AV2Persona);
            cmC13.SetParameter(1, AV3Persona);
            cmC13.SetParameter(2, AV4Persona);
            cmC13.SetParameterDateObject(3, AV5Persona);
            cmC13.SetParameter(4, AV6Persona);
            cmC13.SetParameter(5, AV7ImagenP, nV7ImagenP);
            cmC13.SetParameter(6, AV8PProvin, nV8PProvin);
            cmC13.SetParameter(7, AV9PLocali, nV9PLocali);
            cmC13.ExecuteStmt();
            if ( cmC13.DupKey )
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
            cmC12.HasMoreRows = C12.Read();
         }
         C12.Close();
         cmdBuffer=" SET IDENTITY_INSERT [GXA0001] OFF "
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
         m__PLocalidadIDIsNull = false ;
         m_PLocalidadID = 0 ;
         m__PProvinciaIDIsNull = false ;
         m_PProvinciaID = 0 ;
         m__ImagenPerfilIsNull = false ;
         m_ImagenPerfil = "" ;
         m__PersonaSexoIsNull = false ;
         m_PersonaSexo = 0 ;
         m__PersonaFechaNacimientoIsNull = false ;
         m_PersonaFechaNacimiento = (DateTime)(DateTime.MinValue) ;
         m__PersonaApellidoIsNull = false ;
         m_PersonaApellido = "" ;
         m__PersonaNombreIsNull = false ;
         m_PersonaNombre = "" ;
         m__PersonaIDIsNull = false ;
         m_PersonaID = 0 ;
         GIGXA0001 = 0 ;
         AV2Persona = 0 ;
         AV3Persona = "" ;
         AV4Persona = "" ;
         AV5Persona = (DateTime)(DateTime.MinValue) ;
         AV6Persona = 0 ;
         AV7ImagenP = "" ;
         nV7ImagenP = false ;
         AV8PProvin = 0 ;
         nV8PProvin = false ;
         AV9PLocali = 0 ;
         nV9PLocali = false ;
         Gx_err = 0 ;
         Gx_emsg = "" ;
         // GeneXus formulas.
         Gx_err = 0 ;
      }

      private short m_PersonaSexo ;
      private short AV6Persona ;
      private short Gx_err ;
      private int m_PLocalidadID ;
      private int m_PProvinciaID ;
      private int m_PersonaID ;
      private int GIGXA0001 ;
      private int AV2Persona ;
      private int AV8PProvin ;
      private int AV9PLocali ;
      private String cmdBuffer ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime m_PersonaFechaNacimiento ;
      private DateTime AV5Persona ;
      private bool m__PLocalidadIDIsNull ;
      private bool m__PProvinciaIDIsNull ;
      private bool m__ImagenPerfilIsNull ;
      private bool m__PersonaSexoIsNull ;
      private bool m__PersonaFechaNacimientoIsNull ;
      private bool m__PersonaApellidoIsNull ;
      private bool m__PersonaNombreIsNull ;
      private bool m__PersonaIDIsNull ;
      private bool nV7ImagenP ;
      private bool nV8PProvin ;
      private bool nV9PLocali ;
      private String m_ImagenPerfil ;
      private String m_PersonaApellido ;
      private String m_PersonaNombre ;
      private String AV3Persona ;
      private String AV4Persona ;
      private String AV7ImagenP ;
      private DataStore dsDefault ;
      private System.Resources.ResourceManager resourceManager ;
      private System.Resources.ResourceManager resourceManagerTables ;
      private ReadWriteConnection connDefault ;
      private ReadWriteCommand RGZ ;
      private ReadWriteCommand cmC12 ;
      private IDataReader C12 ;
      private ReadWriteCommand cmC13 ;
   }

}
