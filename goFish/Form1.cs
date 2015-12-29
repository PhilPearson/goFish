using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goFish
{
	public partial class Form1 : Form
	{
		public Form1() {
			InitializeComponent();
		}

		private Game game;

		private void buttonStart_Click(object sender, EventArgs e) {
			if (String.IsNullOrEmpty(textName.Text)) {
				MessageBox.Show("Please enter you name", "Cant start the game yet.");
				return;
			}
			game = new Game(textName.Text, new List<string> { "Joe", "Bob" }, textProgress);
			buttonStart.Enabled = false;
			textName.Enabled = false;
			buttonAsk.Enabled = true;
			UpdateForm();
		}

		private void UpdateForm() {
			listHand1.Items.Clear();
			foreach (String cardName in game.GetPlayerCardNames(0))
				listHand1.Items.Add(cardName);
			/*
			listHand2.Items.Clear();
			foreach (String cardName in game.GetPlayerCardNames(1))
				listHand2.Items.Add(cardName);
			listHand3.Items.Clear();
			foreach (String cardName in game.GetPlayerCardNames(2))
				listHand3.Items.Add(cardName);
			*/
			textBooks.Text = game.DescribeBooks();
			textProgress.Text += game.DescribePlayerHands();
			textProgress.SelectionStart = textProgress.Text.Length;
			textProgress.ScrollToCaret();
		}

		private void buttonAsk_Click(object sender, EventArgs e) {
			textProgress.Text = "";
			if (listHand1.SelectedIndex < 0) {
				MessageBox.Show("Please select a card");
				return;
			}
			if (game.PlayOneRound(listHand1.SelectedIndex)) {
				textProgress.Text += "The winner is... " + game.GetWinnerName();
				textBooks.Text = game.DescribeBooks();
				buttonAsk.Enabled = false;
			} else {
				UpdateForm();
			}
		}
	}
}
