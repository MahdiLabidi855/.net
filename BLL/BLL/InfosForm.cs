using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BLL
{
    public partial class InfosForm : Form
    {
        public InfosForm()
        {
            InitializeComponent();
        }

        public void LoadInfos(string title, Dictionary<string, string> infos)
        {
            lblTitle.Text = title;
            dgv.Rows.Clear();
            foreach (var pair in infos)
            {
                dgv.Rows.Add(pair.Key, pair.Value);
            }
        }
    }
}
