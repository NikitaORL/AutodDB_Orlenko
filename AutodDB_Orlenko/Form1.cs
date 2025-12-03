
using AutodDB_Orlenko.Data; // подключение контекста базы
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

            // Загружаем владельцев сразу при старте формы
            LoadOwners();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Можно также вызвать LoadOwners() здесь вместо конструктора
            // LoadOwners();
        }

        // ------------------ Загрузка владельцев ----------------------
        private void LoadOwners()
        {
            using (var context = new AutoDbContext())
            {
                dataGridViewOmanukud.DataSource = context.Owners
                    .Include(o => o.Cars) // подгружаем машины владельца
                    .Select(o => new
                    {
                        o.Id,
                        o.FullName,
                        o.Phone,
                        Cars = string.Join(", ", o.Cars.Select(c => c.Brand + " " + c.Model))
                    })
                    .ToList();
            }
        }
    }
}
