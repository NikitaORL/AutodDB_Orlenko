
using AutodDB_Orlenko.Data; 
using AutodDB_Orlenko.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Cryptography;
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
                        //Cars = string.Join(", ", o.Cars.Select(c => c.Brand + " " + c.Model))
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
        }


        private void ShopName_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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
                MessageBox.Show("Пожалуйста, выберите владельца машины!");
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

            LoadOwners();

            textBoxOwnerName.Clear();
            textBoxOwnerPhone.Clear();
        }
    }
}
