using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Отель
{
    public partial class Сотрудник : Form
    {
        JArray results = null;

        public Сотрудник()
        {
            WorkWithFile.LoadArray("Employee.txt");
            InitializeComponent();
        }

        private void CardUser_Click(object sender, EventArgs e)
        {
            var q = dataGridViewSearchUser.CurrentCell.RowIndex;

            if (results == null)
            {
                return;
            }
            if (q > results.Count - 1)
            {
                return;
            }

            var bio = results[q];


            int x = 0;
            for (x = 0; x < WorkWithFile.jArray.Count - 1; x++)
            {
                if (JToken.DeepEquals(WorkWithFile.jArray[x], bio))
                    break;

            }

            var ds = new Карта_сотрудника(x, accessLevels.user);

            ds.Activate();
            ds.Show();
        }

        private void SearchUser_Click(object sender, EventArgs e)
        {
            string aa = "";
            if (searchPatronymic.Text == "" && searchPositiob.Text == ""
                && searchLastName.Text == ""
                && searchFirstName.Text == "")
                return;

            var q = WorkWithFile.jArray.Where(
                a =>
                {
                    var f = a.ToObject<Bio>();

                    if (searchFirstName.Text != "")
                    {
                        if (searchFirstName.Text != f.Имя)
                            return false;
                    }
                    if (searchLastName.Text != "")
                    {
                        if (searchLastName.Text != f.Фамилия)
                            return false;
                    }
                    if (searchPatronymic.Text != "")
                    {
                        if (searchPatronymic.Text != f.Отчество)
                            return false;
                    }
                    if (searchPositiob.Text != "")
                    {
                        if (searchPositiob.Text != f.Должность)
                            return false;
                    }
                    return true;
                }

                );

            foreach (var item in q)
            {
                aa += item.ToObject<Bio>().Фамилия + " " + item.ToObject<Bio>().Имя;
            }

            results = new JArray(q);
            dataGridViewSearchUser.DataSource = results;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            dataGridViewListUser.DataSource = WorkWithFile.jArray;
        }

        private void dataGridViewListUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Сотрудник_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SearchEmployeeUser_Click(object sender, EventArgs e)
        {

        }
    }
}
