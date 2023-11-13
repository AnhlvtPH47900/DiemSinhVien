using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace DiemSinhVien
{
    public partial class Form2 : Form
    {
        private int _idWhenClick;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string masvToSearch = txtMaSV.Text;

            for (int i = 0; i < lstDanhSachDiem.Items.Count; i++)
            {
                string item = lstDanhSachDiem.Items[i].ToString();

                if (item.Contains(masvToSearch))
                {
                    MessageBox.Show($"Mã sinh viên {masvToSearch} được tìm thấy: {item}");
                }
            }
        }

        private void lstDanhSachDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDanhSachDiem.SelectedItems != null)
            {
                txtMaSV.Text = lstDanhSachDiem.SelectedItems.ToString();
                txtTen.Text = lstDanhSachDiem.SelectedItems.ToString();
                txtTiengAnh.Text = lstDanhSachDiem.SelectedItems.ToString();
                txtTinHoc.Text = lstDanhSachDiem.SelectedItems.ToString();
                txtGDTC.Text = lstDanhSachDiem.SelectedItems.ToString();
                txtDiemTB.Text = lstDanhSachDiem.SelectedItems.ToString();

            }
            else
            {
                txtMaSV.Clear();
                txtTen.Clear();
                txtTiengAnh.Clear();
                txtTinHoc.Clear();
                txtGDTC.Clear();
                txtDiemTB.Clear();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            txtTen.Text = "";
            txtTiengAnh.Text = "";
            txtTinHoc.Text = "";
            txtGDTC.Text = "";
            txtDiemTB.Text = "";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ma1 = txtMaSV.Text;
            lstDanhSachDiem.Items.Add(ma1);
            string ten1 = txtTen.Text;
            lstDanhSachDiem.Items.Add(ten1);
            string ta = txtTiengAnh.Text;
            lstDanhSachDiem.Items.Add(ta);
            string th = txtTinHoc.Text;
            lstDanhSachDiem.Items.Add(th);
            string gd = txtGDTC.Text;
            lstDanhSachDiem.Items.Add(gd);
            string dtb = txtDiemTB.Text;
            lstDanhSachDiem.Items.Add(dtb);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ma1 = txtMaSV.Text;
            string ten1 = txtTen.Text;
            string ta = txtTiengAnh.Text;
            string th = txtTinHoc.Text;
            string gd = txtGDTC.Text;
            string dtb = txtDiemTB.Text;

            for (int i = lstDanhSachDiem.Items.Count - 1; i >= 0; i--)
            {
                string item = lstDanhSachDiem.Items[i].ToString();

                if (item.Contains(ma1) || item.Contains(ten1) || item.Contains(ta) || item.Contains(th) || item.Contains(gd) || item.Contains(dtb))
                {
                    lstDanhSachDiem.Items.RemoveAt(i);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }
 
    }
}

