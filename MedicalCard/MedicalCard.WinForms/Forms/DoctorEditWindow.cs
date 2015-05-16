namespace MedicalCard.WinForms.Forms
{
	using System;
	using System.Collections.Generic;
	using System.Data.Entity.Validation;
	using System.Drawing;
	using System.IO;
	using System.Linq;
	using System.Windows.Forms;
	using BLL;
	using BLL.Repositories;
	using Common.Extensions;
	using Entities;
	using Entities.Enums;
	using Properties;

	public partial class DoctorEditWindow : BaseForm
	{
		private byte[] image;
		private PositionRepository positionRepository;
		private List<Position> positions;
		private readonly Doctor doctor;
		private readonly DoctorRepository repository = new DoctorRepository(new MedicalCardDbContext());

		public DoctorEditWindow(Doctor doctor)
		{
			this.doctor = repository.GetById(doctor.Id);
			InitializeComponent();
			SetName("Редактирование данных пациента");
			InitRepositories();
			InitComboBoxes();
			SetValues();
		}

		private void InitComboBoxes()
		{
			GenderComboBox.SelectedIndex = 0;
			positionComboBox.SelectedIndex = 0;
		}

		private void InitRepositories()
		{
			positionRepository = new PositionRepository(new MedicalCardDbContext());
			positions = positionRepository.GetAll().ToList();
			positionComboBox.Items.Clear();
			positionComboBox.Items.AddRange(positions.Select(i => i.Name).ToArray<Object>());
		}

		private void SetValues()
		{
			addressTextBox.Text = doctor.Address;
			birthDateTimePicker.Value = doctor.BirthDate ?? DateTime.Now;
			emailTextBox.Text = doctor.Email;
			firstNameTextBox.Text = doctor.FirstName;
			GenderComboBox.SelectedIndex = (int) doctor.Gender;
			lastNameTextBox.Text = doctor.LastName;
			middleNameTextBox.Text = doctor.MiddleName;
			phoneTextBox.Text = doctor.Phone;
			positionComboBox.SelectedIndex = positionComboBox.Items.IndexOf(doctor.Position.Name);
			if (doctor.Photo != null)
			{
				image = doctor.Photo.Content;
				photoPictureBox.Image = Image.FromStream(new MemoryStream(image));
			}
			else
			{
				image = null;
				photoPictureBox.Image = Resources.DefaultPhoto;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (passwordTextBox.Text != passwordTextBox2.Text)
			{
				Error("Введенные пароли не совпадают");
				return;
			}

			try
			{
				doctor.Account.Password = passwordTextBox.Text;
				repository.SaveChanges();
				Message("Пароль успешно изменен");
			}
			catch (DbEntityValidationException exception)
			{
				Error(String.Format("Обнаружены ошибки:{0}{1}", Environment.NewLine, exception.GetErrorMessage()),
					"Некорректные данные");
			}
			catch (Exception exception)
			{
				while (exception.InnerException != null)
				{
					exception = exception.InnerException;
				}
				Error(exception.Message, "Ошибка");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				var position = positions.FirstOrDefault(p => p.Name == positionComboBox.Text);
				if (position == null)
				{
					throw new ArgumentOutOfRangeException();
				}

				doctor.Address = addressTextBox.Text;
				doctor.BirthDate = birthDateTimePicker.Value;
				doctor.Email = emailTextBox.Text;
				doctor.FirstName = firstNameTextBox.Text;
				doctor.Gender = (Gender) GenderComboBox.SelectedIndex;
				doctor.LastName = lastNameTextBox.Text;
				doctor.MiddleName = middleNameTextBox.Text;
				doctor.Phone = phoneTextBox.Text;
				doctor.PositionId = position.Id;
				if (image != null)
				{
					doctor.Photo = new Photo
					{
						Content = image
					};
				}
				else
				{
					doctor.Photo = null;
				}
				repository.SaveChanges();
				Message("Данные успешно обновлены");
				Close();
			}
			catch (DbEntityValidationException exception)
			{
				Error(String.Format("Обнаружены ошибки при заполнении:{0}{1}", Environment.NewLine, exception.GetErrorMessage()),
					"Некорректные данные");
			}
			catch (Exception exception)
			{
				while (exception.InnerException != null)
				{
					exception = exception.InnerException;
				}
				Error(exception.Message, "Ошибка");
			}
		}

		private void photoPickButton_Click(object sender, EventArgs e)
		{
			var odf = new OpenFileDialog
			{
				CheckFileExists = true,
				Filter = "Картинки|*.bmp;*.jpg;*.png;*.gif",
				Multiselect = false
			};
			if (odf.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			try
			{
				photoPictureBox.Image = Image.FromFile(odf.FileName);
				image = File.ReadAllBytes(odf.FileName);
			}
			catch (Exception exception)
			{
				while (exception.InnerException != null)
				{
					exception = exception.InnerException;
				}
				Error(exception.Message, "Ошибка");
			}
		}

		private void removePhotoButton_Click(object sender, EventArgs e)
		{
			image = null;
			photoPictureBox.Image = Resources.DefaultPhoto;
		}
	}
}