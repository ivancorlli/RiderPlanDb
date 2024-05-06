
namespace Raiderplan1
{
	using Raiderplan1;

	public class DataAdapterFactoryProxy
	{
		static DataAdapterFactoryProxy()
		{
			if (DataAdapterFactory.Provider == null)
			{
				DataAdapterFactory.Provider = new Raiderplan1.SimpleDataAdapterFactory();
			}
			
		}
		 
		public static IDataAdapterFactory Instance
		{
			get
			{
				return DataAdapterFactory.Provider;
			}
		}
		
	}
}