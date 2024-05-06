using System;
using System.Threading;
using System.Data;
using Deklarit.Data;

namespace Raiderplan1
{
   public class DeklaritTransaction : IDeklaritTransaction
   {
      private IDbTransaction m_Transaction;
      private IDbConnection m_Connection;
      
      private static  string m_TransactionSlotName = "Raiderplan1.DeklaritTransaction";
 
      public static string TransactionSlotName
      {
          get { return m_TransactionSlotName; }
      }

      public DeklaritTransaction(IsolationLevel il)
      {
         m_Transaction = Connection.BeginTransaction(il);
         Thread.SetData(Thread.GetNamedDataSlot(m_TransactionSlotName), m_Transaction);
      }

      public DeklaritTransaction()
      {
         m_Transaction = Connection.BeginTransaction();
         Thread.SetData(Thread.GetNamedDataSlot(m_TransactionSlotName), m_Transaction);
      }

      #region IDisposable Members

      public void Dispose()
      {

         Thread.FreeNamedDataSlot(m_TransactionSlotName);
         ;
         m_Transaction.Dispose();
         m_Connection.Dispose();
      }
      
      #endregion

      #region IDeklaritTransctionMembers
      
      public System.Data.IsolationLevel IsolationLevel
      {
	get
          {
	     return m_Transaction.IsolationLevel;
          }
      }

      public void Commit()
      {
         m_Transaction.Commit();
      }

      public void Rollback()
      {
         m_Transaction.Rollback();
      }

      public IDbConnection Connection
      {
         get
	 {
	    if(m_Connection == null)
            {
               m_Connection = Configuration.GetConnection();
               m_Connection.Open();
            }

            return m_Connection;
	 }
      }
      #endregion
   }
}
