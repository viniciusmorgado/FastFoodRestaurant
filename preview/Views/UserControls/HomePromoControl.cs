﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FastFoodRestaurant.Controllers;

namespace FastFoodRestaurant.Views
{
    public partial class HomePromoControl : UserControl
    {
        #region Object Controllers
        HomePromoControlController homepromoController = new HomePromoControlController();
        #endregion

        public HomePromoControl()
        {
            InitializeComponent();
        }

        private void HomePromoControlOrderNow_Click(object sender, EventArgs e)
        {
            homepromoController.DbEntryRecordRegister("Burger", 19, 1);
        }
    }
}