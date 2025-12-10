using AutodDB_Orlenko.Data;
using AutodDB_Orlenko.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AutodDB_Orlenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LoadOwners();
            LoadCars();
            LoadServices();
            LoadOwnersToComboBox();
            LoadCarServicesCar();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadOwners()
        {
            using (var context = new AutoDbContext())
            {
                dataGridViewOmanukud.DataSource = context.Owners
                    .Include(o => o.Cars)
                    .Select(o => new
                    {
                        o.Id,
                        o.FullName,
                        o.Phone,
                    })
                    .ToList();
            }
        }

        //--------------тут форма Owners -------------------------------------
        private void AddBtnOwners_Click(object sender, EventArgs e) //добавление
        {
            string name = textBoxOwnerName.Text.Trim();
            string phone = textBoxOwnerPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Palun siseta omaniku nimi ja number!!!");
                return;
            }

            using (var context = new AutoDbContext())
            {
                var owner = new Owner
                {
                    FullName = name,
                    Phone = phone
                };

                context.Owners.Add(owner);
                context.SaveChanges();
            }

            LoadOwners();
            LoadOwnersToComboBox();

            textBoxOwnerName.Clear();
            textBoxOwnerPhone.Clear();
        }

        private void DeleteBtnOwners_Click(object sender, EventArgs e) // удаление
        {
            if (dataGridViewOmanukud.SelectedRows.Count == 0)
            {
                MessageBox.Show("Palun vali omanik kui tahad kustuta");
                return;
            }

            int id = (int)dataGridViewOmanukud.SelectedRows[0].Cells["Id"].Value;

            using (var context = new AutoDbContext())
            {
                var owner = context.Owners.FirstOrDefault(o => o.Id == id);

                if (owner != null)
                {
                    context.Owners.Remove(owner);
                    context.SaveChanges();
                }
            }

            LoadOwners();
            LoadOwnersToComboBox();
        }

        //--------------------------------вкладка Cars--------------------------------------

        private void LoadCars()
        {
            using (var context = new AutoDbContext())
            {
                dataGridViewCars.DataSource = context.Cars
                    .Include(o => o.Owner)
                    .Select(o => new
                    {
                        o.Id,
                        o.Brand,
                        o.Model,
                        o.RegistrationNumber,
                        Owner = o.Owner.FullName
                    })
                    .ToList();
            }
        }

        private void CarsAddBtn_Click(object sender, EventArgs e)
        {
            string Brand = textBoxBrand.Text.Trim();
            string Model = textBoxModel.Text.Trim();
            string RegistrationNumber = textBoxRegNumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(Brand) || string.IsNullOrWhiteSpace(Model) || string.IsNullOrWhiteSpace(RegistrationNumber))
            {
                MessageBox.Show("Palun siseta kõik andmed!!!");
                return;
            }

            if (comboBoxOwner.SelectedItem == null)
            {
                MessageBox.Show("Vali omanik !");
                return;
            }

            using (var context = new AutoDbContext())
            {
                var car = new Car
                {
                    Brand = Brand,
                    Model = Model,
                    RegistrationNumber = RegistrationNumber,
                    OwnerId = (int)comboBoxOwner.SelectedValue
                };

                context.Cars.Add(car);
                context.SaveChanges();
            }

            LoadCars();


            textBoxBrand.Clear();
            textBoxModel.Clear();
            textBoxRegNumber.Clear();
        }

        private void LoadOwnersToComboBox()
        {
            using (var context = new AutoDbContext())
            {
                var owners = context.Owners
                    .Select(o => new
                    {
                        o.Id,
                        o.FullName
                    })
                    .ToList();

                comboBoxOwner.DataSource = owners;
                comboBoxOwner.DisplayMember = "FullName";
                comboBoxOwner.ValueMember = "Id";
            }
        }

        private void CarsDeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewCars.SelectedRows.Count == 0)
            {
                MessageBox.Show("Palun vali auto kui tahad kustuta");
                return;
            }

            int id = (int)dataGridViewCars.SelectedRows[0].Cells["Id"].Value;

            using (var context = new AutoDbContext())
            {
                var car = context.Cars.FirstOrDefault(c => c.Id == id);

                if (car != null)
                {
                    context.Cars.Remove(car);
                    context.SaveChanges();
                }
            }

            LoadCars();
        }

        //--------------------------------вкладка Service--------------------------------------

        private void LoadServices()
        {
            using (var context = new AutoDbContext())
            {
                dataGridViewService.DataSource = null;
                dataGridViewService.DataSource = context.Services
                    .Select(s => new
                    {
                        s.Id,
                        s.Name,
                        s.Price
                    })
                    .ToList();
            }
        }



        private void buttonServiceAdd_Click_1(object sender, EventArgs e)
        {
            string name = textBoxServiceName.Text.Trim();
            string priceText = textBoxServicePrice.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(priceText))
            {
                MessageBox.Show("Palun siseta kõik andmed!!!");
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Sisesta korrektne hind!");
                return;
            }

            using (var context = new AutoDbContext())
            {
                var service = new Service
                {
                    Name = name,
                    Price = price
                };

                context.Services.Add(service);
                context.SaveChanges();
            }

            textBoxServiceName.Clear();
            textBoxServicePrice.Clear();

            LoadServices();
        }

        private void buttonServiceDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewService.SelectedRows.Count == 0)
            {
                MessageBox.Show("Palun vali service kui tahad kustuta");
                return;
            }

            int id = Convert.ToInt32(dataGridViewService.SelectedRows[0].Cells["Id"].Value);

            using (var context = new AutoDbContext())
            {
                var service = context.Services
                                     .FirstOrDefault(s => s.Id == id);

                if (service != null)
                {
                    context.Services.Remove(service);
                    context.SaveChanges();
                }
            }

            LoadServices();
        }
        //---------------------------------вкладка ServiceCar----------------------------------------------------

    }

}
