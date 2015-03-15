namespace MedicalCard.BLL
{
	using System;
	using System.Data.Entity;

	internal sealed class DbTransactionWrapper : ITransaction
	{
		private readonly DbContextTransaction _transaction;

		internal DbTransactionWrapper(DbContextTransaction transaction)
		{
			_transaction = transaction;
		}

		void ITransaction.Commit()
		{
			_transaction.Commit();
		}

		void ITransaction.Rollback()
		{
			_transaction.Rollback();
		}

		void IDisposable.Dispose()
		{
			_transaction.Dispose();
		}
	}
}