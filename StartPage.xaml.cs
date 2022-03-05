using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using Xamarin.Forms.PlatformConfiguration;

namespace RoboticsScoutApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : TabbedPage
    {
        int autoTechFouls = 0;
        int autoFouls = 0;
        int autoLowerHub = 0;
        int autoLowerHubMissed = 0;
        int autoUpperHub = 0;
        int autoUpperHubMissed = 0;
        int teleTechFouls = 0;
        int teleFouls = 0;
        int teleLowerHub = 0;
        int teleLowerHubMissed = 0;
        int teleUpperHub = 0;
        int teleUpperHubMissed = 0;

        String myDate;

        public StartPage()
        {
            InitializeComponent();
        }

        private void ResetAll()
        {
            // start
            nameEntry.Text = "";
            matchNumberEntry.Text = "";
            matchTypeEntry.SelectedIndex = -1;
            replayEntry.IsToggled = false;
            teamNumberEntry.Text = "";
            alianceColorEntry.SelectedIndex = -1;
            preloadCargoEntry.IsToggled= false; 

            // auto
            taxiEntry.IsToggled = false;
            autoTechFoulsLabel.Text = "0";
            autoFoulsLabel.Text = "0";
            autoLowerHubLabel.Text = "0";
            autoLowerHubMissLabel.Text = "0";
            autoUpperHubLabel.Text = "0";
            autoUpperHubMissLabel.Text = "0";
            autoTechFouls = 0;
            autoFouls = 0;
            autoLowerHub = 0;
            autoLowerHubMissed = 0;
            autoUpperHub = 0;
            autoUpperHubMissed = 0;
            
            // teleop
            teleTechFoulsLabel.Text = "0";
            teleFoulsLabel.Text = "0";
            teleLowerHubLabel.Text = "0";
            teleLowerHubMissLabel.Text = "0";
            teleUpperHubLabel.Text = "0";
            teleUpperHubMissLabel.Text = "0";
            teleTechFouls = 0;
            teleFouls = 0;
            teleLowerHub = 0;
            teleLowerHubMissed = 0;
            teleUpperHub = 0;
            teleUpperHubMissed = 0;
            // climb
            climbLevelEntry.SelectedIndex = -1;
            attemptedClimbLevelEntry.SelectedIndex = -1;
            climberSideAxisEntry.SelectedIndex = -1;
            // post match
            howMuchDefense.SelectedIndex = -1;
            howGoodDefense.SelectedIndex = -1;  
            howMuchDefendedAgainst.SelectedIndex = -1;
            opposingDefenseStrength.SelectedIndex = -1;
            breakdownEntry.IsToggled = false;
            commentsEntry.Text = "";
            filePic.SelectedIndex = 1;
            /* data handler variables
            _data.AutoLower = 0;
            _data.AutoOuter = 0;
            _data.AutoInner = 0;
            _data.AutoMissed = 0;
            _data.AutoDropped = 0;
            _data.AutoCollected = 0;
            _data.TeleLower = 0;
            _data.TeleOuter = 0;
            _data.TeleInner = 0;
            _data.TeleMissed = 0;
            _data.TeleDropped = 0;
            _data.TeleCollected = 0;
            _data.Fouls = 0; */
        }

        private void AutoTechFoulsMinus_Clicked(object sender, EventArgs e)
        {
            if (autoTechFouls > 0)
            {
                autoTechFouls -= 1;
            }
            autoTechFoulsLabel.Text = autoTechFouls.ToString();
        }

        private void AutoTechFoulsPlus_Clicked(object sender, EventArgs e)
        {
            autoTechFouls += 1;
            autoTechFoulsLabel.Text = autoTechFouls.ToString();
        }

        private void AutoFoulsMinus_Clicked(object sender, EventArgs e)
        {
            if (autoFouls > 0)
            {
                autoFouls -= 1;
            }
            autoFoulsLabel.Text = autoFouls.ToString();
        }

        private void AutoFoulsPlus_Clicked(object sender, EventArgs e)
        {
            autoFouls += 1;
            autoFoulsLabel.Text = autoFouls.ToString();
        }



        private void AutoLowerHubMinus_Clicked(object sender, EventArgs e)
        {
            if (autoLowerHub > 0)
            {
                autoLowerHub -= 1;
            }
            autoLowerHubLabel.Text = autoLowerHub.ToString();
        }

        private void AutoLowerHubPlus_Clicked(object sender, EventArgs e)
        {
            autoLowerHub += 1;
            autoLowerHubLabel.Text = autoLowerHub.ToString();
        }

        private void AutoLowerHubMissMinus_Clicked(object sender, EventArgs e)
        {
            if (autoLowerHubMissed > 0)
            {
                autoLowerHubMissed -= 1;
            }
            autoLowerHubMissLabel.Text = autoLowerHubMissed.ToString();
        }

        private void AutoLowerHubMissPlus_Clicked(object sender, EventArgs e)
        {
            autoLowerHubMissed += 1;
            autoLowerHubMissLabel.Text = autoLowerHubMissed.ToString();
        }

        private void AutoUpperHubMinus_Clicked(object sender, EventArgs e)
        {
            if (autoUpperHub > 0)
            {
                autoUpperHub -= 1;
            }
            autoUpperHubLabel.Text = autoUpperHub.ToString();
        }

        private void AutoUpperHubPlus_Clicked(object sender, EventArgs e)
        {
            autoUpperHub += 1;
            autoUpperHubLabel.Text = autoUpperHub.ToString();
        }

        private void AutoUpperHubMissMinus_Clicked(object sender, EventArgs e)
        {
            if (autoUpperHubMissed > 0)
            {
                autoUpperHubMissed -= 1;
            }
            autoUpperHubMissLabel.Text = autoUpperHubMissed.ToString();
        }

        private void AutoUpperHubMissPlus_Clicked(object sender, EventArgs e)
        {
            autoUpperHubMissed += 1;
            autoUpperHubMissLabel.Text = autoUpperHubMissed.ToString();
        }

        private void TeleTechFoulsMinus_Clicked(object sender, EventArgs e)
        {
            if (teleTechFouls > 0)
            {
                teleTechFouls -= 1;
            }
            teleTechFoulsLabel.Text = teleTechFouls.ToString();
        }

        private void TeleTechFoulsPlus_Clicked(object sender, EventArgs e)
        {
            teleTechFouls += 1;
            teleTechFoulsLabel.Text = teleTechFouls.ToString();
        }

        private void TeleFoulsMinus_Clicked(object sender, EventArgs e)
        {
            if (teleFouls > 0)
            {
                teleFouls -= 1;
            }
            teleFoulsLabel.Text = teleFouls.ToString();
        }

        private void TeleFoulsPlus_Clicked(object sender, EventArgs e)
        {
            teleFouls += 1;
            teleFoulsLabel.Text = teleFouls.ToString();
        }



        private void TeleLowerHubMinus_Clicked(object sender, EventArgs e)
        {
            if (teleLowerHub > 0)
            {
                teleLowerHub -= 1;
            }
            teleLowerHubLabel.Text = teleLowerHub.ToString();
        }

        private void TeleLowerHubPlus_Clicked(object sender, EventArgs e)
        {
            teleLowerHub += 1;
            teleLowerHubLabel.Text = teleLowerHub.ToString();
        }

        private void TeleLowerHubMissMinus_Clicked(object sender, EventArgs e)
        {
            if (teleLowerHubMissed > 0)
            {
                teleLowerHubMissed -= 1;
            }
            teleLowerHubMissLabel.Text = teleLowerHubMissed.ToString();
        }

        private void TeleLowerHubMissPlus_Clicked(object sender, EventArgs e)
        {
            teleLowerHubMissed += 1;
            teleLowerHubMissLabel.Text = teleLowerHubMissed.ToString();
        }

        private void TeleUpperHubMinus_Clicked(object sender, EventArgs e)
        {
            if (teleUpperHub > 0)
            {
                teleUpperHub -= 1;
            }
            teleUpperHubLabel.Text = teleUpperHub.ToString();
        }

        private void TeleUpperHubPlus_Clicked(object sender, EventArgs e)
        {
            teleUpperHub += 1;
            teleUpperHubLabel.Text = teleUpperHub.ToString();
        }

        private void TeleUpperHubMissMinus_Clicked(object sender, EventArgs e)
        {
            if (teleUpperHubMissed > 0)
            {
                teleUpperHubMissed -= 1;
            }
            teleUpperHubMissLabel.Text = teleUpperHubMissed.ToString();
        }

        private void TeleUpperHubMissPlus_Clicked(object sender, EventArgs e)
        {
            teleUpperHubMissed += 1;
            teleUpperHubMissLabel.Text = teleUpperHubMissed.ToString();
        }


        private void MainTabbedPage_CurrentPageChanged(object sender, EventArgs e)
        {

        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameEntry.Text) ||
                string.IsNullOrWhiteSpace(matchNumberEntry.Text) ||
                string.IsNullOrWhiteSpace(teamNumberEntry.Text) ||
                alianceColorEntry.SelectedIndex == -1 ||
                filePic.SelectedIndex == -1)
                await DisplayAlert("Error", "Not all data entries are filled", "OK");
            else
            {
                myDate = DateTime.Now.ToString(); //date

                //setting variables for the responses in the fields
                String name = nameEntry.Text;
                String MatchNumber = matchNumberEntry.Text;
                var MathType = matchTypeEntry.SelectedItem;
                String Replay = replayEntry.IsToggled.ToString();
                String TeamNumber = teamNumberEntry.Text;
                var AllianceColor = alianceColorEntry.SelectedItem;
                String PreloadCargo = preloadCargoEntry.IsToggled.ToString();
                String Taxi = (taxiEntry.IsToggled).ToString();
                int AutoTechFoul = autoTechFouls;
                int AutoFoul = autoFouls;



                var DefensePlayed = howMuchDefense.SelectedItem;
                var PlayingDefense = howGoodDefense.SelectedItem;
                var DefendedAgainst = howMuchDefendedAgainst.SelectedItem;
                var OpposingDefense = opposingDefenseStrength.SelectedItem;
                String BreakDown = breakdownEntry.IsToggled.ToString();
                String comments = commentsEntry.Text;
                


                ResetAll();
            }
        }
        public static void textfile()
        {
            SimpleDateFormat formatter = new SimpleDateFormat("yyyy_MM_dd");
            Date now = new Date();
            String fileName = formatter.format(now) + ".txt";


            try
            {
                File root = new File(Environment.getExternalStorageDirectory() + File.separator + "Music_Folder", "Report Files");
                //File root = new File(Environment.getExternalStorageDirectory(), "Notes");
                if (!root.exists())
                {
                    root.mkdirs();
                }
                File gpxfile = new File(root, fileName);


                FileWriter writer = new FileWriter(gpxfile, true);
                writer.append(sBody + "\n\n");
                writer.flush();
                writer.close();
                Toast.makeText(this, "Data has been written to Report File", Toast.LENGTH_SHORT).show();
            }
            catch (IOException e)
            {
                e.printStackTrace();

            }
        }
        
    }
}