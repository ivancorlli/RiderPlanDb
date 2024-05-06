using System;
using System.Collections.Generic;
using System.Text;
using Deklarit.Configuration;
using System.Security.Principal;
using Deklarit.Data;
using System.Data;

namespace Raiderplan1
{
    public class BusinessFrameworkContext : BusinessFrameworkContextBase
	{        
        public static BusinessFrameworkContext Instance = new BusinessFrameworkContext();

        public override IDeklaritConfiguration DeklaritConfiguration
        {
            get
            {
                return Configuration.Instance;
            }
        }

        public override object EnterpriseLibraryConfigurationSource
        {
            get
            {
                return EnterpriseLibrary.Instance.ConfigurationContext;
            }
        }

        public override object DataAdapterFactory
        {
            get
            {
                return Raiderplan1.DataAdapterFactory.Provider;
            }
        }

        public override IDeklaritTransaction GetDeklaritTransaction()
        {
            return new DeklaritTransaction();
        }

        public override IDeklaritTransaction GetDeklaritTransaction(IsolationLevel isolationLevel)
        {
            return new DeklaritTransaction(isolationLevel);
        }


    }
}
