﻿namespace MedicalCard
{
	using AutoMapper;
	using Entities;
	using Models;

	public class AutoMapperConfig
	{
		public static void RegisterMappings()
		{
			#region Account

			Mapper.CreateMap<Account, AccountModel>();
			Mapper.CreateMap<AccountModel, Account>()
				.ForMember(dest => dest.PatientId, src => src.Ignore())
				.ForMember(dest => dest.Patient, src => src.Ignore())
				.ForMember(dest => dest.DoctorId, src => src.Ignore())
				.ForMember(dest => dest.Doctor, src => src.Ignore());

			#endregion

			#region Doctor

			Mapper.CreateMap<Doctor, DoctorModel>()
				.ForMember(dest => dest.PositionId, src => src.MapFrom(s => s.Position.Id))
				.ForMember(dest => dest.PositionName, src => src.MapFrom(s => s.Position.Name));
			Mapper.CreateMap<DoctorModel, Doctor>()
				.ForMember(dest => dest.PhotoId, src => src.Ignore())
				.ForMember(dest => dest.Photo, src => src.Ignore())
				.ForMember(dest => dest.Account, src => src.Ignore())
				.ForMember(dest => dest.Position, src => src.Ignore());

			#endregion

			#region Doctor positions

			Mapper.CreateMap<Position, PositionModel>();
			Mapper.CreateMap<PositionModel, Position>();

			#endregion

			#region Patient

			Mapper.CreateMap<Patient, PatientModel>();
			Mapper.CreateMap<PatientModel, Patient>()
				.ForMember(dest => dest.Account, src => src.Ignore());

			#endregion

			Mapper.AssertConfigurationIsValid();
		}
	}
}