using System;
using System.Windows.Forms;
using Tyuiu.MitinNV.Sprint7.Lib;

namespace Tyuiu.MitinNV.Sprint7
{
    public partial class Form1 : Form
    {
        private DataService _dataService;

        public Form1()
        {
            InitializeComponent();
            _dataService = new DataService(); // Инициализация сервиса данных
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Заполнение данных при загрузке формы
            LoadApartments();

            // Настройка кнопки удаления
            btnDeleteApartment.Click += btnDeleteApartment_Click;
        }

        private void btnAddApartment_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем данные из полей ввода
                var buildingNumber = int.Parse(txtBuildingNumber.Text);
                var apartmentNumber = int.Parse(txtApartmentNumber.Text);
                var totalArea = double.Parse(txtTotalArea.Text);
                var usefulArea = double.Parse(txtUsefulArea.Text);
                var numberOfRooms = int.Parse(txtNumberOfRooms.Text);
                var tenantName = txtTenantName.Text;
                var registrationDate = dtpRegistrationDate.Value; // Используем DateTimePicker для даты
                var familyMembersCount = int.Parse(txtFamilyMembersCount.Text);
                var childrenCount = int.Parse(txtChildrenCount.Text);
                var hasDebt = chkHasDebt.Checked;
                var notes = txtNotes.Text;

                // Создаем новый объект квартиры и добавляем его в хранилище данных
                var apartment = new Apartment(buildingNumber, apartmentNumber, totalArea, usefulArea, numberOfRooms, tenantName, registrationDate, familyMembersCount, childrenCount, hasDebt, notes);
                _dataService.AddApartment(apartment);

                // Обновляем отображение данных
                LoadApartments();

                // Очистка полей ввода
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteApartment_Click(object sender, EventArgs e)
        {
            if (dgvApartments.SelectedRows.Count > 0)
            {
                var selectedRow = dgvApartments.SelectedRows[0];
                var buildingNumber = (int)selectedRow.Cells["BuildingNumber"].Value;
                var apartmentNumber = (int)selectedRow.Cells["ApartmentNumber"].Value;

                var confirmationResult = MessageBox.Show(
                    $"Вы уверены, что хотите удалить квартиру {buildingNumber}/{apartmentNumber}?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmationResult == DialogResult.Yes)
                {
                    _dataService.RemoveApartment(buildingNumber, apartmentNumber); // Удаляем квартиру по номеру
                    LoadApartments(); // Обновляем таблицу
                }
            }
        }

        private void LoadApartments()
        {
            // Очистим существующие данные в DataGridView
            dgvApartments.Rows.Clear();

            // Убедимся, что у DataGridView есть столбцы
            if (dgvApartments.Columns.Count == 0)
            {
                dgvApartments.Columns.Add("BuildingNumber", "№ здания");
                dgvApartments.Columns.Add("ApartmentNumber", "№ квартиры");
                dgvApartments.Columns.Add("TotalArea", "Общая площадь");
                dgvApartments.Columns.Add("UsefulArea", "Полезная площадь");
                dgvApartments.Columns.Add("NumberOfRooms", "Кол-во комнат");
                dgvApartments.Columns.Add("TenantName", "ФИО арендатора");
                dgvApartments.Columns.Add("RegistrationDate", "Дата регистрации");
                dgvApartments.Columns.Add("FamilyMembersCount", "Кол-во членов семьи");
                dgvApartments.Columns.Add("ChildrenCount", "Кол-во детей");
                dgvApartments.Columns.Add("HasDebt", "Задолженность");
                dgvApartments.Columns.Add("Notes", "Примечания");
            }

            // Заполняем DataGridView данными из сервиса данных
            var apartments = _dataService.GetApartments();
            foreach (var apartment in apartments)
            {
                dgvApartments.Rows.Add(
                    apartment.BuildingNumber,
                    apartment.ApartmentNumber,
                    apartment.TotalArea,
                    apartment.UsefulArea,
                    apartment.NumberOfRooms,
                    apartment.TenantName,
                    apartment.RegistrationDate.ToShortDateString(),
                    apartment.FamilyMembersCount,
                    apartment.ChildrenCount,
                    apartment.HasDebt ? "есть" : "нет", // Отображаем "есть" или "нет" вместо true/false
                    apartment.Notes);
            }
        }

        private void ClearInputFields()
        {
            txtBuildingNumber.Clear();
            txtApartmentNumber.Clear();
            txtTotalArea.Clear();
            txtUsefulArea.Clear();
            txtNumberOfRooms.Clear();
            txtTenantName.Clear();
            dtpRegistrationDate.Value = DateTime.Now; // Сбрасываем DateTimePicker
            txtFamilyMembersCount.Clear();
            txtChildrenCount.Clear();
            chkHasDebt.Checked = false;
            txtNotes.Clear();
        }
    }
}
