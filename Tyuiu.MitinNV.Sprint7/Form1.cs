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
            _dataService = new DataService(); // ������������� ������� ������
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ���������� ������ ��� �������� �����
            LoadApartments();

            // ��������� ������ ��������
            btnDeleteApartment.Click += btnDeleteApartment_Click;
        }

        private void btnAddApartment_Click(object sender, EventArgs e)
        {
            try
            {
                // �������� ������ �� ����� �����
                var buildingNumber = int.Parse(txtBuildingNumber.Text);
                var apartmentNumber = int.Parse(txtApartmentNumber.Text);
                var totalArea = double.Parse(txtTotalArea.Text);
                var usefulArea = double.Parse(txtUsefulArea.Text);
                var numberOfRooms = int.Parse(txtNumberOfRooms.Text);
                var tenantName = txtTenantName.Text;
                var registrationDate = dtpRegistrationDate.Value; // ���������� DateTimePicker ��� ����
                var familyMembersCount = int.Parse(txtFamilyMembersCount.Text);
                var childrenCount = int.Parse(txtChildrenCount.Text);
                var hasDebt = chkHasDebt.Checked;
                var notes = txtNotes.Text;

                // ������� ����� ������ �������� � ��������� ��� � ��������� ������
                var apartment = new Apartment(buildingNumber, apartmentNumber, totalArea, usefulArea, numberOfRooms, tenantName, registrationDate, familyMembersCount, childrenCount, hasDebt, notes);
                _dataService.AddApartment(apartment);

                // ��������� ����������� ������
                LoadApartments();

                // ������� ����� �����
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ��� ���������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    $"�� �������, ��� ������ ������� �������� {buildingNumber}/{apartmentNumber}?",
                    "������������� ��������",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmationResult == DialogResult.Yes)
                {
                    _dataService.RemoveApartment(buildingNumber, apartmentNumber); // ������� �������� �� ������
                    LoadApartments(); // ��������� �������
                }
            }
        }

        private void LoadApartments()
        {
            // ������� ������������ ������ � DataGridView
            dgvApartments.Rows.Clear();

            // ��������, ��� � DataGridView ���� �������
            if (dgvApartments.Columns.Count == 0)
            {
                dgvApartments.Columns.Add("BuildingNumber", "� ������");
                dgvApartments.Columns.Add("ApartmentNumber", "� ��������");
                dgvApartments.Columns.Add("TotalArea", "����� �������");
                dgvApartments.Columns.Add("UsefulArea", "�������� �������");
                dgvApartments.Columns.Add("NumberOfRooms", "���-�� ������");
                dgvApartments.Columns.Add("TenantName", "��� ����������");
                dgvApartments.Columns.Add("RegistrationDate", "���� �����������");
                dgvApartments.Columns.Add("FamilyMembersCount", "���-�� ������ �����");
                dgvApartments.Columns.Add("ChildrenCount", "���-�� �����");
                dgvApartments.Columns.Add("HasDebt", "�������������");
                dgvApartments.Columns.Add("Notes", "����������");
            }

            // ��������� DataGridView ������� �� ������� ������
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
                    apartment.HasDebt ? "����" : "���", // ���������� "����" ��� "���" ������ true/false
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
            dtpRegistrationDate.Value = DateTime.Now; // ���������� DateTimePicker
            txtFamilyMembersCount.Clear();
            txtChildrenCount.Clear();
            chkHasDebt.Checked = false;
            txtNotes.Clear();
        }
    }
}
