namespace goFish
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.textName = new System.Windows.Forms.TextBox();
			this.buttonStart = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textProgress = new System.Windows.Forms.TextBox();
			this.textBooks = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonAsk = new System.Windows.Forms.Button();
			this.listHand1 = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Your Name";
			// 
			// textName
			// 
			this.textName.Location = new System.Drawing.Point(16, 30);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(168, 20);
			this.textName.TabIndex = 1;
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(190, 30);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(168, 23);
			this.buttonStart.TabIndex = 2;
			this.buttonStart.Text = "Start the game!";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Game Progress";
			// 
			// textProgress
			// 
			this.textProgress.Location = new System.Drawing.Point(16, 81);
			this.textProgress.Multiline = true;
			this.textProgress.Name = "textProgress";
			this.textProgress.ReadOnly = true;
			this.textProgress.Size = new System.Drawing.Size(342, 301);
			this.textProgress.TabIndex = 4;
			// 
			// textBooks
			// 
			this.textBooks.Location = new System.Drawing.Point(16, 410);
			this.textBooks.Multiline = true;
			this.textBooks.Name = "textBooks";
			this.textBooks.ReadOnly = true;
			this.textBooks.Size = new System.Drawing.Size(342, 112);
			this.textBooks.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 393);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Books";
			// 
			// buttonAsk
			// 
			this.buttonAsk.Enabled = false;
			this.buttonAsk.Location = new System.Drawing.Point(364, 499);
			this.buttonAsk.Name = "buttonAsk";
			this.buttonAsk.Size = new System.Drawing.Size(188, 23);
			this.buttonAsk.TabIndex = 7;
			this.buttonAsk.Text = "Ask for a card";
			this.buttonAsk.UseVisualStyleBackColor = true;
			this.buttonAsk.Click += new System.EventHandler(this.buttonAsk_Click);
			// 
			// listHand1
			// 
			this.listHand1.FormattingEnabled = true;
			this.listHand1.Location = new System.Drawing.Point(365, 30);
			this.listHand1.Name = "listHand1";
			this.listHand1.Size = new System.Drawing.Size(187, 459);
			this.listHand1.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(362, 13);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Your Hand";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(566, 540);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.listHand1);
			this.Controls.Add(this.buttonAsk);
			this.Controls.Add(this.textBooks);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textProgress);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.textName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Go Fish!";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textProgress;
		private System.Windows.Forms.TextBox textBooks;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonAsk;
		private System.Windows.Forms.ListBox listHand1;
		private System.Windows.Forms.Label label4;
	}
}

