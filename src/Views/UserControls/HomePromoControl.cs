﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FastFoodRestaurant.Controllers;
using System.Threading.Tasks;

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

        private async void HomePromoControlOrderNow_Click(object sender, EventArgs e)
        {
            await Task.Run(() => homepromoController.DbEntryRecordRegister("Burger", 19, 1));
        }
    }
}
