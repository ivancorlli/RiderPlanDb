using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Deklarit.EnterpriseLibrary.Security.Configuration.Cryptography;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.ObjectBuilder;

namespace Raiderplan1
{
		
	public class EnterpriseLibrary
	{
		public static EnterpriseLibrary Instance = new EnterpriseLibrary();

		private string m_ConfigurationFile;

		private IConfigurationSource m_ConfigurationContext;	
		
		private object m_ConfigurationContextLock = new object();  

		private EnterpriseLibrary()
		{
		}

		public string ConfigurationFile
		{
			get { return m_ConfigurationFile; }
			set 
			{ 	
				if (m_ConfigurationFile != value)
				{
					m_ConfigurationFile = value; 
					m_ConfigurationContext = null;
				}
			}
		}

		public IConfigurationSource ConfigurationContext
		{
			set { m_ConfigurationContext = value; }

			get
			{				
				if (m_ConfigurationContext == null)
				{
					lock (m_ConfigurationContextLock)
					{
						if (m_ConfigurationContext == null)
						{
							m_ConfigurationContext = (m_ConfigurationFile == null) ?
												ConfigurationSourceFactory.Create() : 
												new FileConfigurationSource(m_ConfigurationFile);
						}
					}
				}

				return m_ConfigurationContext;
			}
		}

		public string CreateHash(string value)
		{
			 return Cryptographer.CreateHash("HashProvider", value, ConfigurationContext);
		}

		public byte[] CreateHash(byte[] value)
		{
			 return Cryptographer.CreateHash("HashProvider", value, ConfigurationContext);
		}

		public string EncryptSymmetric(string value)
		{
			 return Cryptographer.EncryptSymmetric("EncryptionProvider", value, ConfigurationContext);
		}

		public byte[] EncryptSymmetric(byte[] value)
		{
			 return Cryptographer.EncryptSymmetric("EncryptionProvider", value, ConfigurationContext);
		}

		public string DecryptSymmetric(string value)
		{
			 return Cryptographer.DecryptSymmetric("EncryptionProvider", value, ConfigurationContext);
		}

		public byte[] DecryptSymmetric(byte[] value)
		{
			 return Cryptographer.DecryptSymmetric("EncryptionProvider", value, ConfigurationContext);
		}

		public bool CompareHash(string plainText, string hashedText)
		{
			 return Cryptographer.CompareHash("HashProvider", plainText, hashedText, ConfigurationContext);
		}

		public bool CompareHash(byte[] plainText, byte[] hashedText)
		{
			 return Cryptographer.CompareHash("HashProvider", plainText, hashedText, ConfigurationContext);
		}

		
}

}
