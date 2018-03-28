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
using Data = Google.Apis.Sheets.v4.Data;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        SheetsService sheetsService;
        
        string spreadsheetId = "1nITN-NKCSODuR4LLJGuqBKyrf47lmvCYiRl7oCe453U";
        string range = "A2:H";
        static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        public void NotMain()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.ReadWrite))
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

            }

            sheetsService = new SheetsService(new BaseClientService.Initializer
            {
                HttpClientInitializer = GetCredential(),
                ApplicationName = "TableTop Brawl",
                ApiKey = "AIzaSyCnF3u6zTn4U2PE-ypGNIB154Ko5Cbeet4",
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
        //static string ApplicationName = "TableTop Brawl";
        /*public void Form1_Load(object sender, EventArgs e)
        {
            UserCredential credential;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.ReadWrite))
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
                
            }

            sheetsService = new SheetsService(new BaseClientService.Initializer
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



        }**/

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

        // Start of Form Code
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
        
        
        // Button 1 "Confirm" 
        private void button1_Click(object sender, EventArgs e) //TODO: have this send input to spreadsheet
        {
            NotMain();
            // prints inputs to text box for testing
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
            NotMain();
            
            
            SpreadsheetsResource.ValuesResource.GetRequest.ValueRenderOptionEnum valueRenderOption = (SpreadsheetsResource.ValuesResource.GetRequest.ValueRenderOptionEnum)0;
            SpreadsheetsResource.ValuesResource.GetRequest.DateTimeRenderOptionEnum dateTimeRenderOption = (SpreadsheetsResource.ValuesResource.GetRequest.DateTimeRenderOptionEnum)0;  // TODO: Update placeholder value.

            SpreadsheetsResource.ValuesResource.GetRequest request = sheetsService.Spreadsheets.Values.Get(spreadsheetId, range);
            request.ValueRenderOption = valueRenderOption;
            request.DateTimeRenderOption = dateTimeRenderOption;

            Data.ValueRange response = request.Execute();
            String valueString = (JsonConvert.SerializeObject(response.Values));
            valueString = Regex.Replace(valueString, "[\\[\"]", "");
            String[] valueArray = valueString.Split(new String[] { "]" }, StringSplitOptions.None);
            //String[] characterArray;
            foreach (String element in valueArray)
            {
                //String[] elements = element.Split(new String[] { "," }, StringSplitOptions.None);
                var characterArray = valueArray.Select(y => element.Split(new[] { ',' })).ToArray();
            }

            /*Random rand = new Random();
            int r = rand.Next(0, length);
            int r2 = rand.Next(0, length);**/

            txt_fightOutput.Text += valueArray[0][1];//(JsonConvert.SerializeObject(response.Values));
        }


        
    }
}