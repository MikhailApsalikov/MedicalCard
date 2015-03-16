namespace MedicalCard.BLL.Interfaces
{
	using System;

	public interface ITransaction : IDisposable
	{
		void Commit();
		void Rollback();
	}
}