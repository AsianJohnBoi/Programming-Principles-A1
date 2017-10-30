﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TankBattle
{
	public partial class setupGameForm : Form
	{
		private int playerAmount, roundAmount;

		public setupGameForm()
		{
			InitializeComponent();
		}

        private void setupPlayersButton_Click(object sender, EventArgs e)
		{
            playerAmount = (int)playerAmountInput.Value;
            roundAmount = (int)roundAmountInput.Value;
			Hide();
			setupPlayerForm setupPlayer = new setupPlayerForm(playerAmount, roundAmount);
			setupPlayer.Show();
		}
	}
}
