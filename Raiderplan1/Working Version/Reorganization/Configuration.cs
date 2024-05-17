
//               File: Configuration
//        Description: DeKlarit Configuration Classes
//             Author: DeKlarit - Language C# - Generator Version 4_5_2008.568 - Specifier Version 4_5
//       Program type: Helper Class
//          Main DBMS: Microsoft SqlServer 9

namespace Raiderplan1 {
   using Deklarit.Configuration;
   public interface IConfigurationProvider  : Deklarit.Configuration.IConfigurationProvider
   {
   }

   public class Configuration
   {
      public static IDeklaritConfiguration Instance = new DeklaritConfiguration() ;
      public static Deklarit.Configuration.IConfigurationProvider ConfigurationProvider
      {
         get {
            return Instance.ConfigurationProvider ;
         }

         set {
            Instance.ConfigurationProvider = value ;
         }

      }

      public static string ConnectionString
      {
         get {
            return Instance.ConnectionString ;
         }

      }

      public static DatabaseEngineType DatabaseEngineType
      {
         get {
            return Instance.DatabaseEngineType ;
         }

      }

      public static System.Data.CommandBehavior ReaderCommandBehavior
      {
         get {
            return System.Data.CommandBehavior.CloseConnection ;
         }

      }

      public static System.Data.IDbConnection GetConnection( )
      {
         return Instance.GetConnection() ;
      }

   }

   public class DeklaritConfiguration : IDeklaritConfiguration
   {
      private Deklarit.Configuration.IConfigurationProvider m_ConfigurationProvider = new CommandLineConfigurationProvider() ;
      public Deklarit.Configuration.IConfigurationProvider ConfigurationProvider
      {
         get {
            return m_ConfigurationProvider ;
         }

         set {
            m_ConfigurationProvider = value ;
         }

      }

      public string ConnectionString
      {
         get {
            return m_ConfigurationProvider.ConnectionString ;
         }

      }

      public DatabaseEngineType DatabaseEngineType
      {
         get {
            return DatabaseEngineType.SqlServer ;
         }

      }

      public System.Data.IDbConnection GetConnection( )
      {
         Deklarit.Data.IDbmsHandler dsHandler ;
         dsHandler = new Deklarit.Data.SqlServer2005Handler() ;
         return dsHandler.NewConnection( ConnectionString, "System.Data.SqlClient") ;
      }

   }

   public class DefaultConfigurationProvider : IConfigurationProvider
   {
      private string m_ConnectionString ;
      ///  <summary>
      ///   Gets or sets the connection string used by the Raiderplan1 Business Framework classes
      ///    to connect to the server.
      ///  </summary>
      public void SetConnectionString( string sConnStr )
      {
         m_ConnectionString = sConnStr ;
      }

      public string ConnectionString
      {
         get {
            string m_CurrentConnectionString = null ;
            if ( ( System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"] != null ) )
            {
               m_CurrentConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString ;
            }
            else
            {
               if ( ( System.Configuration.ConfigurationManager.AppSettings["ConnectionString"] != null ) )
               {
                  m_CurrentConnectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"] ;
               }
            }
            if ( ( m_CurrentConnectionString == null ) )
            {
               if ( ( m_ConnectionString == null ) || (m_ConnectionString.Length==0) )
               {
                  m_CurrentConnectionString = "Data Source=ICORLLI\\SQLEXPRESS01;Integrated Security=SSPI;Initial Catalog=RiderPlanDB1" ;
               }
               else
               {
                  m_CurrentConnectionString = m_ConnectionString ;
               }
            }
            return m_CurrentConnectionString ;
         }

      }

   }

   public class CommandLineConfigurationProvider : IConfigurationProvider
   {
      private string m_ConnectionString ;
      ///  <summary>
      ///   Gets or sets the connection string used by the Raiderplan1 Business Framework classes
      ///    to connect to the server.
      ///  </summary>
      public void SetConnectionString( string sConnStr )
      {
         m_ConnectionString = sConnStr ;
      }

      public string ConnectionString
      {
         get {
            string m_CurrentConnectionString = null ;
            m_CurrentConnectionString = GetConnectionString( System.Environment.GetCommandLineArgs()) ;
            if ( ( m_CurrentConnectionString == null ) )
            {
               if ( ( m_ConnectionString == null ) || (m_ConnectionString.Length==0) )
               {
                  m_CurrentConnectionString = new DefaultConfigurationProvider().ConnectionString ;
               }
               else
               {
                  m_CurrentConnectionString = m_ConnectionString ;
               }
            }
            return m_CurrentConnectionString ;
         }

      }

      private string GetConnectionString( string[] args )
      {
         string token = "/connectionstring:" ;
         foreach( string arg in args )
         {
            if ( arg.ToLower().StartsWith(token) )
            {
               return arg.Substring(token.Length, arg.Length - token.Length) ;
            }
         }

         return null ;
      }

   }

}
