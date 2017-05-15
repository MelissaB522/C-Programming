using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3_1SportsTeamEx3;
using _3_2SportsTeamEx4;

namespace _4_1SportsTeamEx5
{
    public partial class Form1 : Form
    {
        Soccer aSoccerTeam;
        Football aFootballTeam;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //instantiating some team objects
            aSoccerTeam = new Soccer("MLS", "Sporting Kansas City", "Bob Ross", "Blue the Dog", "USA", "Grass", "Male");            
            aFootballTeam = new Football("NFL", "Broncos", "Gary Kubiak", "Miles & Thunder", "AFC", 3, 8);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if soccer is chosen, soccer specific fields are turned on and football specific fields are turned off
            if (cbxSport.Text == "Soccer")
            {             
                pnlFootball.Visible = false;
                pnlSoccer.Visible = true;
                
            }
            //if football is chosen, football specific fields are turned on and soccer specific fields are turned off
            else if (cbxSport.Text == "Football")
            {
                pnlSoccer.Visible = false;
                pnlFootball.Visible = true;
                pnlFootball.Location = pnlSoccer.Location;
                
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //when button is clicked, if football was chosen the football fields will be populated with the instance of the object created above
            if (cbxSport.Text == "Football")
            {
                txtTeamType.Text = aFootballTeam.Type;
                txtName.Text = aFootballTeam.Name;
                txtCoach.Text = aFootballTeam.Coach;
                txtMascot.Text = aFootballTeam.Mascot;
                txtLength.Text = aFootballTeam.GameLength();
                txtNumPlayers.Text = Convert.ToString(aFootballTeam.NumberOfPlayers());
                txtLeague.Text = aFootballTeam.League;
                txtSBAppear.Text = Convert.ToString(aFootballTeam.SuperBowlAppearances);
                txtSBWins.Text = Convert.ToString(aFootballTeam.SuperBowlWins);
            }
            //when button is clicked, if soccer was chosen the soccer fields will be populated with the instance of the object created above
            else if (cbxSport.Text == "Soccer")
            {
                txtTeamType.Text = aSoccerTeam.Type;
                txtName.Text = aSoccerTeam.Name;
                txtCoach.Text = aSoccerTeam.Coach;
                txtMascot.Text = aSoccerTeam.Mascot;
                txtLength.Text = aSoccerTeam.GameLength();
                txtNumPlayers.Text = Convert.ToString(aSoccerTeam.NumberOfPlayers());
                txtCountry.Text = aSoccerTeam.Country;
                txtField.Text = aSoccerTeam.FieldType;
                txtGender.Text = aSoccerTeam.Gender;
            }
        }
    }
}
