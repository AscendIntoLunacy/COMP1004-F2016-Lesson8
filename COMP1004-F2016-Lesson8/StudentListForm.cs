using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// In order to access the database context, we need to 
// include the Models folder in our script.
using COMP1004_F2016_Lesson8.Models;

namespace COMP1004_F2016_Lesson8
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            GetStudents();
        }

        private void GetStudents()
        {
            // Connect to database using EF.
            CollegeContext db = new CollegeContext();

            // Use LINQ to access the Student table in the database.
            var StudentList = (from student in db.Students
                               select student).ToList();

            // Display the Student List in the DataGridView
            StudentsDataGridView.DataSource = StudentList;
        }
    }
}
