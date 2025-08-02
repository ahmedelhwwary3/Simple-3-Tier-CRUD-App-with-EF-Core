using BizLayer;
using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer;
using System;
using System.Windows.Forms;

namespace ADO2EFcore
{
    public partial class Form1 : Form
    {
        BindingSource bsDoctors;
        List<DoctorFullData> LstDoctors;

        public Form1()
        {
            InitializeComponent();
        }
        public void FillSpecializationCB()
        {
            foreach (var d in LstDoctors)
            {
                cbSpecialization.Items.Add(d.Specialization);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bsDoctors = new BindingSource();
            LstDoctors = DoctorManager.GetAllDoctorsFullData();
            FillSpecializationCB();
            bsDoctors.DataSource = LstDoctors;
            cbSpecialization.DataBindings.Add("Text", bsDoctors, "Specialization");
            txtName.DataBindings.Add("Text", bsDoctors, "Name");
            lblDoctorID.DataBindings.Add("Text", bsDoctors, "DoctorID");
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            bsDoctors.MoveNext();

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            bsDoctors.MovePrevious();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bsDoctors.EndEdit();
            var Doctors = bsDoctors.DataSource as List<DoctorFullData>;
            PersonDomain person;
            foreach (var d in Doctors)
            {
                DoctorManager.UpdateDoctorByID(new DoctorDomain() { DoctorID=d.DoctorID,PersonID=PersonManager.GetPersonByName(d.Name).PersonID,Specialization=d.Specialization});
            }
             
        }
    }
}
