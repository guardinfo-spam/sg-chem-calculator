using SgSeason2.Lib;

var data = ReadDataFromFile();
var teamData = PreparePlayersData(data);

var playersChemData = teamData.CalculateDetailedChemistryData();
var teamChemData = teamData.TeamChemistry;

Console.WriteLine($"Team chem is : { teamChemData.ChemistryValue }, {teamChemData.Chemistry}");

string[] ReadDataFromFile()
{
     return File.ReadAllLines("C://temp//sg.txt");
}

TeamData PreparePlayersData(string[] playersData)
{
    string[] separators = { "\t" };
    var teamData = new TeamData();

    foreach ( string row in playersData )
    {
        string[] result = row.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        PlayerData playerData = new PlayerData
        {
            FormationPosition = result[0],
            Name = result[1],
            Nation = result[2],
            Club = result[3],
            League = result[4],
            PlayedPosition = result[5],
            TotalStats = int.Parse(result[6])
        };

        teamData.AddPlayerInTeam(playerData);        
    }    

    return teamData;
}