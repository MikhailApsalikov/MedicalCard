namespace MedicalCard.BLL
{
	using System;

	public interface ITransaction : IDisposable
	{
		void Commit();
		void Rollback();
	}
}