
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
         cmC12 = connDefault.GetCommand("SELECT [LoacaliadID], [PersonaSexo], [PersonaFechaNacimiento], [PersonaApellido], [PersonaNombre], [PersonaID] FROM [Persona] ",false);
         cmC12.ErrorMask = cmC12.ErrorMask  |  ErrorMask.Lock;
         C12 = cmC12.FetchData();
         while ( cmC12.HasMoreRows )
         {
            m_LoacaliadID = dsDefault.Db.GetInt32(C12, 0, ref m__LoacaliadIDIsNull) ;
            m_PersonaSexo = dsDefault.Db.GetInt16(C12, 1, ref m__PersonaSexoIsNull) ;
            m_PersonaFechaNacimiento = dsDefault.Db.GetDateTime(C12, 2, ref m__PersonaFechaNacimientoIsNull) ;
            m_PersonaApellido = dsDefault.Db.GetString(C12, 3, ref m__PersonaApellidoIsNull) ;
            m_PersonaNombre = dsDefault.Db.GetString(C12, 4, ref m__PersonaNombreIsNull) ;
            m_PersonaID = dsDefault.Db.GetInt32(C12, 5, ref m__PersonaIDIsNull) ;
            //
               // INSERT RECORD ON TABLE GXA0001
               //
            //
            AV2Persona = m_PersonaID ;
            AV3Persona = m_PersonaNombre ;
            AV4Persona = m_PersonaApellido ;
            AV5Persona = m_PersonaFechaNacimiento ;
            AV6Persona = m_PersonaSexo ;
            if ( C12.IsDBNull(0) )
            {
               AV7Loacali = 0 ;
               nV7Loacali = true ;
            }
            else
            {
               AV7Loacali = m_LoacaliadID ;
               nV7Loacali = false ;
            }
            AV8ImagenP = " " ;
            cmC13 = connDefault.GetCommand("INSERT INTO [GXA0001] ([PersonaID], [PersonaNombre], [PersonaApellido], [PersonaFechaNacimiento], [PersonaSexo], [LoacaliadID], [ImagenPerfil]) VALUES (@PersonaID, @PersonaNombre, @PersonaApellido, @PersonaFechaNacimiento, @PersonaSexo, @LoacaliadID, @ImagenPerfil)",false);
            if ( ( cmC13.IDbCommand.Parameters.Count == 0 ) )
            {
               cmC13.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaID", System.Data.DbType.Int32));
               cmC13.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaNombre", System.Data.DbType.AnsiString,120));
               cmC13.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaApellido", System.Data.DbType.AnsiString,120));
               cmC13.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaFechaNacimiento", System.Data.DbType.Date));
               cmC13.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@PersonaSexo", System.Data.DbType.Int16));
               cmC13.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@LoacaliadID", System.Data.DbType.Int32));
               cmC13.IDbCommand.Parameters.Add(  dsDefault.GetDbParameter( "@ImagenPerfil", System.Data.DbType.AnsiString,25));
            }
            cmC13.ErrorMask = cmC13.ErrorMask  |  ErrorMask.DuplicateKeyError;
            // Using cursor C13
            cmC13.SetParameter(0, AV2Persona);
            cmC13.SetParameter(1, AV3Persona);
            cmC13.SetParameter(2, AV4Persona);
            cmC13.SetParameterDateObject(3, AV5Persona);
            cmC13.SetParameter(4, AV6Persona);
            cmC13.SetParameter(5, AV7Loacali, nV7Loacali);
            cmC13.SetParameter(6, AV8ImagenP);
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
         m__LoacaliadIDIsNull = false ;
         m_LoacaliadID = 0 ;
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
         AV7Loacali = 0 ;
         nV7Loacali = false ;
         AV8ImagenP = "" ;
         Gx_err = 0 ;
         Gx_emsg = "" ;
         // GeneXus formulas.
         Gx_err = 0 ;
      }

      private short m_PersonaSexo ;
      private short AV6Persona ;
      private short Gx_err ;
      private int m_LoacaliadID ;
      private int m_PersonaID ;
      private int GIGXA0001 ;
      private int AV2Persona ;
      private int AV7Loacali ;
      private String cmdBuffer ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime m_PersonaFechaNacimiento ;
      private DateTime AV5Persona ;
      private bool m__LoacaliadIDIsNull ;
      private bool m__PersonaSexoIsNull ;
      private bool m__PersonaFechaNacimientoIsNull ;
      private bool m__PersonaApellidoIsNull ;
      private bool m__PersonaNombreIsNull ;
      private bool m__PersonaIDIsNull ;
      private bool nV7Loacali ;
      private String m_PersonaApellido ;
      private String m_PersonaNombre ;
      private String AV3Persona ;
      private String AV4Persona ;
      private String AV8ImagenP ;
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
