namespace MedicalCard
{
	using AutoMapper;
	using Entities;
	using Entities.Enums;
	using Models;

	public class AutoMapperConfig
	{
		public static void RegisterMappings()
		{
			#region Account

			Mapper.CreateMap<Account, AccountModel>()
				.ForMember(dest => dest.Role, src => src.MapFrom(s => (int) s.Role));
			Mapper.CreateMap<AccountModel, Account>()
				.ForMember(dest => dest.Role, src => src.MapFrom(s => (Role) s.Role))
				.ForMember(dest => dest.PatientId, src => src.Ignore())
				.ForMember(dest => dest.Patient, src => src.Ignore())
				.ForMember(dest => dest.DoctorId, src => src.Ignore())
				.ForMember(dest => dest.Doctor, src => src.Ignore());

			#endregion

			Mapper.AssertConfigurationIsValid();
		}
	}
}