﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVEntityFramwork
{
    public partial class Writer : Form
    {
        int Max;
        public Writer()
        {
            InitializeComponent();

            //LoadData();
            //DisableComponent();
        }
        public void DisableComponent()
        {
            //txtTen.Enabled = false;
            //btnHuy.Enabled = false;
        }
        public void EnabledComponent()
        {
        //    txtTen.Enabled = true;
        //    btnHuy.Enabled = true;
        }
        public void LoadData()
        {
            //using (var db = new Model1())
            //{
            //    db.Configuration.LazyLoadingEnabled = false;
            //    var query = from d in db.TACGIAs
            //                select d;
            //    dgvTacGia.DataSource = query.ToList();
            //    dgvTacGia.AutoResizeColumns();
            //    dgvTacGia.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //    dgvTacGia.AutoResizeRows();
            //}
            //var MaxMATG = dgvTacGia.Rows.Count;
            //Max = MaxMATG;
            //dgvTacGia.Columns[0].HeaderText = "Mã Tác Giả";
            //dgvTacGia.Columns[1].HeaderText = "Tên Tác Giả";

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            //EnabledComponent();
            //btnDangKy.Enabled = false;
            //btnLoadData.Enabled = false;
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            //LoadData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //DisableComponent();
            //txtTen.Text = null;
            //btnDangKy.Enabled = true;
            //btnLoadData.Enabled = true;
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)13)
            //{
            //    using (var db = new Model1())
            //    {
            //        TACGIA tacgia = new TACGIA();
            //        tacgia.TENTACGIA = txtTen.Text;
            //        tacgia.MATACGIA = Max + 1;

            //        db.TACGIAs.Add(tacgia);
            //        db.SaveChanges();
            //    }
            //    txtTen.Text = "";
            //    DisableComponent();
            //    LoadData();
            //    btnDangKy.Enabled = true;
            //    btnLoadData.Enabled = true;
            //}
        }
    }
}