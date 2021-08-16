using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
	public partial class Form2 : Form
	{
		public List<SoccerUC> Soccers { get; set; } = new List<SoccerUC>();
		public Form2(List<PlayerUC> players,string Link,string FlagName)
		{
			InitializeComponent();
			PictureFlag.LoadAsync(Link);
			CountryName.Text = FlagName;

			Soccers.Add(soccerUC1);
			Soccers.Add(soccerUC2);
			Soccers.Add(soccerUC3);

			Soccers.Add(soccerUC6);
			Soccers.Add(soccerUC4);
			Soccers.Add(soccerUC5);

			Soccers.Add(soccerUC7);
			Soccers.Add(soccerUC8);
			Soccers.Add(soccerUC10);
			Soccers.Add(soccerUC11);

			Soccers.Add(soccerUC12);


			for (int i = 0; i < players.Count; i++)
			{
				Soccers[i].lblNumber.Text = players[i].txtPlayerNumber.Text;
				Soccers[i].lblName.Text = players[i].txtPlayerName.Text;
			}
			
		}
	}
}
