using StudentRegistrationCodeFirstFromDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApp
{
    public partial class MainForm : Form
    {
        private StudentRegistrationEntities context;
        public MainForm()
        {
            InitializeComponent();

            this.Text = "Student Using Add/Update Forms App using EF Code First from DB library";

            context = new StudentRegistrationEntities();
            context.Database.Log = (s => Debug.Write(s));
            context.SeedDatabase();
            context.SaveChanges();

            this.Load += (s, e) => MainForm_Load();

            StudentForm studentForm = new StudentForm();
            buttonStudent.Click += (s, e) => AddOrUpdateForm<Student>(dataGridViewStudents, studentForm);

            DepartmentForm departmentForm = new DepartmentForm();
            buttonDepartment.Click += (s, e) => AddOrUpdateForm<Department>(dataGridViewDepartment, departmentForm);
        }

        private void AddOrUpdateForm<T>(DataGridView dataGridView, Form form) where T : class
        {
            var result = form.ShowDialog();

            // form has closed

            if (result == DialogResult.OK)
            {
                // reload the db and update the gridview


                if (form.Tag != null)
                {
                    int id = (int)form.Tag;

                    T entity = context.Set<T>().Find(id);
                    context.Entry<T>(entity).Reload();
                }
                else dataGridView.DataSource = SetBindingList<T>();

                dataGridView.Refresh();

                // ALWAYS update the customer orders report, hence use of AsNoTracking()

                LoadRegistrationView();
            }

        }

        private BindingList<T> SetBindingList<T>() where T : class
        {
            DbSet<T> dbSet = context.Set<T>();

            dbSet.Load();
            BindingList<T> list = dbSet.Local.ToBindingList<T>();
            return list;
        }

        public void LoadRegistrationView()
        {
            using (StudentRegistrationEntities ordersViewContext = new StudentRegistrationEntities())
            {
                ordersViewContext.Database.Log = (s => Debug.Write(s));

                // force a read from the db, and we don't need to track these entities

                dataGridViewRegistration.DataSource = dataGridViewRegistrationContext.Student.AsNoTracking().ToList();
                dataGridViewRegistration.Refresh();
            }

        }

    }
}
