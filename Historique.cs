﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblio;

namespace REL
{
    public partial class Historique : Form
    {
        public Historique()
        {
            InitializeComponent();
            BindDataGridView();
        }
        private void BindDataGridView()
        {
            cDemande dem = new cDemande();
            int statut = 6;
            if (cbstatut.Checked)
            {
                statut = 5;
            }
            gv_list.DataSource = dem.listHistorique(statut, cUtilisateur.user_id);

        }

        private void cbstatut_CheckedChanged(object sender, EventArgs e)
        {
            BindDataGridView();
        }


    }
}
