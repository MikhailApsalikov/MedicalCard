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

	public partial class Registration : BaseForm
	{
		private PositionRepository positionRepository;
		private List<Position> positions;
		private byte[] image = null;

		public Registration()
		{
			InitializeComponent();
			SetParameters("Регистрация");
			InitRepositories();
			InitComboBoxes();
		}

		private void InitComboBoxes()
		{
			roleComboBox.SelectedIndex = 0;
			disabilityComboBox.SelectedIndex = 0;
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

		private void roleComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedIndex = roleComboBox.SelectedIndex;
			patientPanel.Visible = (selectedIndex == 0);
			doctorPanel.Visible = (selectedIndex == 1);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var account = new Account
			{
				Username = loginTextBox.Text,
				Password = passwordTextBox.Text,
				Role = (Role) roleComboBox.SelectedIndex
			};
			var accountRepository = new AccountRepository(new MedicalCardDbContext());
			if (accountRepository.GetAll().FirstOrDefault(d => d.Username == account.Username) != null)
			{
				MessageBox.Show("Пользователь с таким логином уже существует", "Ошибка", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			try
			{
				switch ((Role) roleComboBox.SelectedIndex)
				{
					case Role.Patient:
					{
						account.Patient = new Patient
						{
							Id = account.Id,
							Address = addressTextBox.Text,
							BirthDate = birthDateTimePicker.Value,
							Disability = (Disability) disabilityComboBox.SelectedIndex,
							DisabilityDocument = disabliltyDocumentTextBox.Text,
							Email = emailTextBox.Text,
							FirstName = firstNameTextBox.Text,
							Gender = (Gender) GenderComboBox.SelectedIndex,
							InsurancePolicy = insurancePolicyTextBox.Text,
							JobStudyPosition = positionTextBox.Text,
							LastName = lastNameTextBox.Text,
							MiddleName = middleNameTextBox.Text,
							Phone = phoneTextBox.Text,
							Snils = snilsTextBox.Text
						};
						break;
					}

					case Role.Doctor:
					{
						var position = positions.FirstOrDefault(p => p.Name == positionComboBox.Text);
						if (position == null)
						{
							throw new ArgumentOutOfRangeException();
						}
						account.Doctor = new Doctor
						{
							Id = account.Id,
							Address = addressTextBox.Text,
							BirthDate = birthDateTimePicker.Value,
							Email = emailTextBox.Text,
							FirstName = firstNameTextBox.Text,
							Gender = (Gender) GenderComboBox.SelectedIndex,
							LastName = lastNameTextBox.Text,
							MiddleName = middleNameTextBox.Text,
							Phone = phoneTextBox.Text,
							PositionId = position.Id
						};
						if (image != null)
						{
							account.Doctor.Photo = new Photo
							{
								Content = image
							};
						}

						break;
					}
					default:
					{
						throw new ArgumentOutOfRangeException();
					}
				}

				accountRepository.Add(account);
				MessageBox.Show(
					String.Format("Регистрация прошла успешно. Теперь вы можете зайти под своей учетной записью."),
					"Регистрация", MessageBoxButtons.OK,
					MessageBoxIcon.None);

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
			OpenFileDialog odf = new OpenFileDialog()
			{
				CheckFileExists = true,
				Filter = "Картинки|*.bmp;*.jpg;*.png;*.gif",
				Multiselect = false,
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
			catch
			{
				MessageBox.Show("Ошибка при загрузке картинки", "Ошибка",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			
		}

		private void removePhotoButton_Click(object sender, EventArgs e)
		{
			image = null;
			photoPictureBox.Image = Resources.DefaultPhoto;
		}
	}
}