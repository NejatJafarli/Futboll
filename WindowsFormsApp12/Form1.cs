using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
	public partial class Form1 : Form
	{
		
		public SortedDictionary<string, string> CountiesCodeAndName { get; set; } = GetCountriesNameAndCode();
		public Form1()
		{
			InitializeComponent();

			cbCountries.DataSource = CountiesCodeAndName.Keys.ToList();

		}

		public static SortedDictionary<string, string> GetCountriesNameAndCode()
		{
			SortedDictionary<string, string> countriesNameAndCodes = new SortedDictionary<string, string>(CultureInfo.GetCultures(CultureTypes.SpecificCultures)
				.Select(x => new RegionInfo(x.LCID))
				.Select(x => new[] { new { Name = x.DisplayName, Code = x.Name },
									})
				.SelectMany(x => x)
				.Distinct()
				.ToDictionary(x => x.Name, x => x.Code, StringComparer.InvariantCultureIgnoreCase));

			countriesNameAndCodes.Remove("World");
			countriesNameAndCodes.Remove("Caribbean");
			countriesNameAndCodes.Remove("Latin America");
			return countriesNameAndCodes;
		}
		public List<PlayerUC> Players { get; set; } = new List<PlayerUC>();
		private void Form1_Load(object sender, EventArgs e)
		{

			Players.Add(playerUC1);
			Players.Add(playerUC2);
			Players.Add(playerUC3);
			Players.Add(playerUC4);

			Players.Add(playerUC6);
			Players.Add(playerUC5);
			Players.Add(playerUC7);
			Players.Add(playerUC8);
			Players.Add(playerUC9);
			Players.Add(playerUC10);
			Players.Add(playerUC11);
			playerUC1.txtPosition.Text = "F";
			playerUC2.txtPosition.Text = "F";
			playerUC3.txtPosition.Text = "F";

			playerUC4.txtPosition.Text = "MD";
			playerUC5.txtPosition.Text = "MD";
			playerUC6.txtPosition.Text = "MD";

			playerUC7.txtPosition.Text = "DD";
			playerUC8.txtPosition.Text = "DD";
			playerUC9.txtPosition.Text = "DD";
			playerUC10.txtPosition.Text = "DD";

			playerUC11.txtPosition.Text = "GK";
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{

		}

		public string Link { get; set; }
		private void cbCountries_SelectedIndexChanged(object sender, EventArgs e)
		{

			string countryCode = CountiesCodeAndName[cbCountries.SelectedItem as string];
			Link = @"https://www.countryflags.io/";
			Link += countryCode;
			Link += @"/flat/64.png";
			pictureBox1.LoadAsync(Link);
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{

			try
			{
				for (int i = 0; i < Players.Count; i++)
				{
					if (string.IsNullOrWhiteSpace(Players[i].txtPlayerName.Text))
						throw new Exception("Any Player Name Is Empty");
					if (string.IsNullOrWhiteSpace(Players[i].txtPlayerNumber.Text))
						throw new Exception("Any Player Number Is Empty");
					if (Players[i].txtPlayerName.Text.Length < 3)
						throw new Exception("Player Name Lenght Must Be Greater Three");
				}
				for (int i = 0; i < Players.Count; i++)
				{
					for (int k = i+1; k < Players.Count; k++)
					{
						if (Players[i].txtPlayerNumber.Text == Players[k].txtPlayerNumber.Text)
							throw new Exception("Player Number Is Unique");
					}
				}
				Form2 form2= new Form2(Players,Link,cbCountries.SelectedItem.ToString());

				form2.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
