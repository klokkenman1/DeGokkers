using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeGokkers.Interfaces;
using DeGokkers.Classes;

namespace DeGokkers.Components
{
    public partial class UserEntry : UserControl
    {
        private UserAddRemove form;

        public UserEntry()
        {
            InitializeComponent();
            form = null;

            lblName.Text = LangResource.GetTranslation("lbl_name");
            btnRemove.Text = LangResource.GetTranslation("lbl_remove_symbol");
            btnAdd.Text = LangResource.GetTranslation("lbl_add_symbol");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (form != null)
            {
                form.OnUserAdd();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (form != null)
            {
                form.OnUserRemove();
            }
        }

        public void SetControlWindow(UserAddRemove form)
        {
            this.form = form;
        }

        public string GetValue()
        {
            return txtEntry.Text;
        }
    }
}
