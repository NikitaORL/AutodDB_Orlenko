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
            LoadOwnersToComboBox2();
            LoadCarsToComboBoxForService();
            LoadServicesToComboBox();
            LoadCarServicesGrid();

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
            LoadOwnersToComboBox2();

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
            LoadOwnersToComboBox2();
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
            LoadCarsToComboBoxForService();


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
            LoadCarsToComboBoxForService();
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
            LoadServicesToComboBox();
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
            LoadServicesToComboBox();
        }
        //---------------------------------вкладка ServiceCar-----------------------------------------------------

        private void LoadOwnersToComboBox2()
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

                comboBoxOwner2.DataSource = owners;
                comboBoxOwner2.DisplayMember = "FullName";
                comboBoxOwner2.ValueMember = "Id";

                comboBoxOwner2.SelectedIndex = -1;
            }
        }

        private void LoadCarsToComboBoxForService()
        {
            using (var context = new AutoDbContext())
            {
                var cars = context.Cars
                    .Select(c => new
                    {
                        c.Id,
                        Full = c.Brand + " " + c.Model + " (" + c.RegistrationNumber + ")"
                    })
                    .ToList();

                comboBoxCar.DataSource = cars;
                comboBoxCar.DisplayMember = "Full";
                comboBoxCar.ValueMember = "Id";


                comboBoxCar.SelectedIndex = -1;
            }
        }

        private void LoadServicesToComboBox()
        {
            using (var context = new AutoDbContext())
            {
                var services = context.Services
                    .Select(s => new
                    {
                        s.Id,
                        s.Name
                    })
                    .ToList();

                comboBoxService.DataSource = services;
                comboBoxService.DisplayMember = "Name";
                comboBoxService.ValueMember = "Id";

                comboBoxService.SelectedIndex = -1;
            }
        }

        private void AddbtnServiceCars_Click(object sender, EventArgs e)
        {
            if (comboBoxCar.SelectedItem == null || comboBoxService.SelectedItem == null)
            {
                MessageBox.Show("Palun vali auto ja teenus!");
                return;
            }

            if (!int.TryParse(textBoxMileage.Text.Trim(), out int mileage))
            {
                MessageBox.Show("Palun sisesta korrektne läbisõit!");
                return;
            }

            int carId = (int)comboBoxCar.SelectedValue;
            int serviceId = (int)comboBoxService.SelectedValue;

            using (var context = new AutoDbContext())
            {
                // Проверяем, существует ли уже такая запись
                var exists = context.CarServices
                    .Any(cs => cs.CarId == carId && cs.ServiceId == serviceId);

                if (exists)
                {
                    MessageBox.Show("See teenus on juba valitud selle auto jaoks!");
                    return;
                }

                var carService = new CarService
                {
                    CarId = carId,
                    ServiceId = serviceId,
                    Mileage = mileage
                };

                context.CarServices.Add(carService);
                context.SaveChanges();
            }

            MessageBox.Show("Teenuse seos lisatud edukalt!");
            LoadCarServicesGrid();

            textBoxMileage.Clear();
        }


        private void DeletebtnServiceCar_Click(object sender, EventArgs e)
        {
            if (dataGridViewServiceCar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Palun vali rida kustutamiseks!");
                return;
            }

            int carId = (int)dataGridViewServiceCar.SelectedRows[0].Cells["CarId"].Value;
            int serviceId = (int)dataGridViewServiceCar.SelectedRows[0].Cells["ServiceId"].Value;

            using (var context = new AutoDbContext())
            {
                var carService = context.CarServices
                    .FirstOrDefault(cs => cs.CarId == carId && cs.ServiceId == serviceId);

                if (carService != null)
                {
                    context.CarServices.Remove(carService);
                    context.SaveChanges();
                    MessageBox.Show("Teenuse seos kustutatud edukalt!");
                }
            }

            LoadCarServicesGrid();
        }


        private void LoadCarServicesGrid()
        {
            using (var context = new AutoDbContext())
            {
                dataGridViewServiceCar.DataSource = context.CarServices
                    .Include(cs => cs.Car)
                    .Include(cs => cs.Service)
                    .Select(cs => new
                    {
                        Owner = cs.Car.Owner.FullName,
                        cs.CarId,
                        Car = cs.Car.Brand + " " + cs.Car.Model + " (" + cs.Car.RegistrationNumber + ")",
                        cs.ServiceId,
                        Service = cs.Service.Name,
                        cs.Mileage
                    })
                    .ToList();
            }
        }
    }
}
