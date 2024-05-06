namespace Raiderplan1.Reorg {
   using Deklarit.Reorganization;
   using Deklarit.Data;
   using Deklarit.Configuration;
   public class Reorganization : IReorganizationProvider
   {
      public event ReorganizationMessageEventHandler MessageHandler;

      public void Execute( )
      {
         DataStore dsDefault ;
         dsDefault = new DataStore( new SqlServer2005Handler( ), "System.Data.SqlClient", Raiderplan1.Configuration.ConnectionString, "_Reorganization.DeklaritTransaction") ;
         dsDefault.AutoCommit = true;
         new gxrgza( dsDefault, MessageHandler).execute();
         new gxrgzb( dsDefault, MessageHandler).execute();
         new gxrgzc( dsDefault, MessageHandler).execute();
         dsDefault.GetReadWriteConnection().Commit();
         dsDefault.Dispose();
      }

      public Deklarit.Configuration.IConfigurationProvider ConfigurationProvider
      {
         get {
            return Configuration.ConfigurationProvider ;
         }

         set {
            Configuration.ConfigurationProvider = value ;
         }

      }

      public DatabaseEngineType DatabaseEngineType
      {
         get {
            return DatabaseEngineType.SqlServer ;
         }

      }

      public System.String Description
      {
         get {
            return "" ;
         }

      }

      public ReorganizationType Type
      {
         get {
            return ReorganizationType.Reorganization ;
         }

      }

   }

}
