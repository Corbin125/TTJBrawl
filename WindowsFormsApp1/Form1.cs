using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        //static string ApplicationName = "TableTop Brawl";

        public Form1()
        {
            InitializeComponent();
        }
        // defining variables for characters
        string playerName = null;
        string characterName = null;
        string race = null;
        int strength = 0;
        int intelligence = 0;
        int dexterity = 0;
        int level = 1;
        int experience = 0;
        // print to text box for testing
        private void button1_Click(object sender, EventArgs e)
        {
            
            playerName = txt_playerName.Text;
            characterName = txt_characterName.Text;
            race = txt_race.Text;
            strength = Int32.Parse(txt_strength.Text);
            intelligence = Int32.Parse(txt_intelligence.Text);
            dexterity = Int32.Parse(txt_dexterity.Text);
            txt_test.Text += playerName + "\r\n" + characterName + "\r\n" + race + "\r\n" + strength +
                "\r\n" + intelligence + "\r\n" + dexterity + "\r\n" + "\r\n";

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserCredential credential;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/sheets.googleapis.com-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

                SheetsService sheetsService = new SheetsService(new BaseClientService.Initializer
            {
                HttpClientInitializer = GetCredential(),
                ApplicationName = "TableTop Brawl",
            });
            // Spreadsheet to request
            string spreadsheetId = "1nITN-NKCSODuR4LLJGuqBKyrf47lmvCYiRl7oCe453U";
            // Range of cells
            List<string> ranges = new List<string>();  // TODO: Update placeholder value.
            // Grid Data
            bool includeGridData = false;

            SpreadsheetsResource.GetRequest request = sheetsService.Spreadsheets.Get(spreadsheetId);
            request.Ranges = ranges;
            request.IncludeGridData = includeGridData;

            

        }

        public static UserCredential GetCredential()
        {
            // TODO: Change placeholder below to generate authentication credentials. See:
            // https://developers.google.com/sheets/quickstart/dotnet#step_3_set_up_the_sample
            //
            // Authorize using one of the following scopes:
            //     "https://www.googleapis.com/auth/drive"
            //     "https://www.googleapis.com/auth/drive.file"
            //     "https://www.googleapis.com/auth/spreadsheets"
                return null;
        }

        
        //a   

    }
}