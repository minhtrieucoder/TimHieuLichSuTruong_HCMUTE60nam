﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _60nam_vongBanket
{
    public partial class frm__round_01_showRules : Form
    {
        public frm__round_01_showRules()
        {
            InitializeComponent();
        }

        private void lb_showQuestionnaire01_Click(object sender, EventArgs e)
        {
            frm__round_01_Questionnaire frm = new frm__round_01_Questionnaire();
            frm.Show();
        }
    }
}
