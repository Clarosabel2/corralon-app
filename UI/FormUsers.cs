using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.common.Styles;

namespace UI
{
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
            ApplyStyleCommon.DGVStyle(this.dgvUsers);
            LoadUsers();
        }

        private void LoadUsers()
        {
            DataGridViewTextBoxColumn idcol = new DataGridViewTextBoxColumn();
            idcol.HeaderText = "ID";
            idcol.Name = "userId";
            idcol.DataPropertyName = "Id";
            idcol.ReadOnly = true;

            DataGridViewTextBoxColumn dniCol = new DataGridViewTextBoxColumn();
            dniCol.HeaderText = "DNI";
            dniCol.Name = "dni";
            dniCol.DataPropertyName = "Dni";
            dniCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dniCol.ReadOnly = true;

            DataGridViewTextBoxColumn emailCol = new DataGridViewTextBoxColumn();
            emailCol.HeaderText = "Email";
            emailCol.Name = "productCategory";
            emailCol.DataPropertyName = "Categoria";
            emailCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            emailCol.ReadOnly = true;

            DataGridViewTextBoxColumn usernameCol = new DataGridViewTextBoxColumn();
            usernameCol.HeaderText = "Username";
            usernameCol.Name = "productBrand";
            usernameCol.DataPropertyName = "Brand";
            usernameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            usernameCol.ReadOnly = true;

            DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
            nameCol.HeaderText = "Nombre";
            nameCol.Name = "product";
            nameCol.DataPropertyName = "Name";
            nameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameCol.ReadOnly = true;

            DataGridViewTextBoxColumn lastnameCol = new DataGridViewTextBoxColumn();
            lastnameCol.HeaderText = "Apellido";
            lastnameCol.Name = "productPrice";
            lastnameCol.DataPropertyName = "Price";
            lastnameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lastnameCol.ReadOnly = true;

            DataGridViewTextBoxColumn rolCol = new DataGridViewTextBoxColumn();
            rolCol.HeaderText = "Rol";
            rolCol.Name = "rol";
            rolCol.DataPropertyName = "Rol";
            rolCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            rolCol.ReadOnly = true;


            DataGridViewImageColumn btnDeleteCol = new DataGridViewImageColumn();
            btnDeleteCol.HeaderText = "Acciones";
            //btnDeleteCol.Text = "Eliminar";
            btnDeleteCol.Image = Properties.Resources.delete_icon_circle;
            btnDeleteCol.Name = "btnDelete";
            btnDeleteCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn btnEditCol = new DataGridViewImageColumn();
            btnEditCol.HeaderText = " ";
            btnEditCol.Image = Properties.Resources.edit_icon_circle;
            btnEditCol.Name = "btnEdit";
            btnEditCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dgvUsers.Columns.Add(idcol);
            dgvUsers.Columns.Add(dniCol);
            dgvUsers.Columns.Add(emailCol);
            dgvUsers.Columns.Add(usernameCol);
            dgvUsers.Columns.Add(nameCol);
            dgvUsers.Columns.Add(lastnameCol);
            dgvUsers.Columns.Add(rolCol);
            dgvUsers.Columns.Add(btnDeleteCol);
            dgvUsers.Columns.Add(btnEditCol);

            BLL_User.GetAllUser().ForEach(u => dgvUsers.Rows.Add(u.Emp.Id, u.Emp.Dni, u.Emp.Email, u.Username, u.Emp.Name, u.Emp.Lastname, u.Rol.ToString()));
            /*
            BLL_Product.GetProducts().ForEach(p => dgvProducts.Rows.Add(p.Id, p.Category, p.Brand.NameBrand, p.Name, p.Price, p.Stock));
             */
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            FormCreateUser f = new FormCreateUser();
            f.BringToFront();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }
    }
}
