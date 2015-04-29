﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationSystem
{
    public partial class studentInformationSystem : Form
    {
        public studentInformationSystem()
        {
            InitializeComponent();
        }

        private void showButton_MouseEnter(object sender, EventArgs e)
        {
            showButton.BackColor = Color.Gainsboro;
        }

        private void showButton_MouseLeave(object sender, EventArgs e)
        {
            showButton.BackColor = Color.NavajoWhite;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (studentNameTextBox.Text == "" ||
                    studentRollNoTextBox.Text == "" ||
                    fatherNameTextBox.Text == "" ||
                    motherNameTextBox.Text == "" ||
                    instituteNameTextBox.Text == "" || sscResultTextBox.Text == "" || sessionTextBox.Text == "")
                {
                    MessageBox.Show("Please Fill Up All The Information", "Error", MessageBoxButtons.RetryCancel);
                    studentNameTextBox.Text =
                     studentRollNoTextBox.Text =
                         fatherNameTextBox.Text =
                             motherNameTextBox.Text =
                                 instituteNameTextBox.Text = sscResultTextBox.Text = sessionTextBox.Text = "";
                }
                else
                {
                    string connectionPath =
                        @"server=.\sqlexpress; database=StudentInformationSystem;integrated security=SSPI";

                    SqlConnection studentInformationSystemDatabaseConnection = new SqlConnection(connectionPath);
                    studentInformationSystemDatabaseConnection.Open();
                    string studentRollNo, studentName, fatherName, motherName, instituteName, sscResult, session;
                    studentRollNo = studentRollNoTextBox.Text;
                    studentName = studentNameTextBox.Text;
                    fatherName = fatherNameTextBox.Text;
                    motherName = motherNameTextBox.Text;
                    sscResult = sscResultTextBox.Text;
                    instituteName = instituteNameTextBox.Text;
                    session = sessionTextBox.Text;
                    string insertQuery =
                        "insert into studentInformationTable(studentRollNo,studentName,fatherName,motherName,sscResult,instituteName,session) values('" +
                        studentRollNo + "','" + studentName + "','" + fatherName + "','" + motherName + "','" +
                        sscResult + "','" + instituteName + "','" + session +
                        "')";
                    SqlCommand commandQuery = new SqlCommand(insertQuery, studentInformationSystemDatabaseConnection);
                    commandQuery.ExecuteNonQuery();
                    MessageBox.Show(" Student information saved successfully . ",
                        "Saved To Database",
                        MessageBoxButtons.OKCancel);
                    studentNameTextBox.Text =
                        studentRollNoTextBox.Text =
                            fatherNameTextBox.Text =
                                motherNameTextBox.Text =
                                    instituteNameTextBox.Text = sscResultTextBox.Text = sessionTextBox.Text = "";

                    studentInformationSystemDatabaseConnection.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }

       
    }
}
