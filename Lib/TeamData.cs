using static SgSeason2.Lib.Enums;

namespace SgSeason2.Lib
{
    public class TeamData
    {
        public List<PlayerData> Team { get; set; }

        public int ChemistryValue { get; set; }
        
        public ChemistryResult TeamChemistry { get { return CalculateTeamChemistry(); } }

        public int TeamBS { get { return Team.Sum(p => p.TotalStats); } }

        public List<PlayerData> DetailedChemistryData { get { return CalculateDetailedChemistryData(); } }
        
        public TeamData()
        {
            this.Team = new List<PlayerData>();
        }

        public void AddPlayerInTeam(PlayerData player)
        {
            if (player == null) throw new ArgumentNullException(nameof(player));
            Team.Add(player);
        }

        private ChemistryResult CalculateTeamChemistry()
        {
            int totalTeamChem = Team.Sum(p => p.PlayerChemistryInTeam.ChemistryValue);
            Chemistry teamChem = Chemistry.Red;

            if (totalTeamChem >= 62) { teamChem = Chemistry.Green; }
            else if (totalTeamChem >= 49) { teamChem = Chemistry.Yellow; }
            else teamChem = Chemistry.Red;

            var result = new ChemistryResult
            {
                ChemistryValue = totalTeamChem,
                Chemistry = teamChem
            };

            return result;
        }

        public List<PlayerData> CalculateDetailedChemistryData()
        {
            foreach ( var player in Team )
            {
                player.PlayerChemistryInTeam = calculatePlayerChemistry(player);
            }

            return Team;
        }

        private ChemistryResult calculatePlayerChemistry(PlayerData player)
        {
            int links = 0;            

            foreach ( var searchedPlayer in Team )
            {
                //skip current player
                if (player.Name.Equals(searchedPlayer.Name)) continue;

                //deal with Hero cards

                if ( player.Club.ToLower().Equals("hero") )
                {
                    if (searchedPlayer.Club.ToLower().Equals("hero"))
                    {
                        if (player.League.Equals(searchedPlayer.League)) { links = links + 2; }
                    }
                }
                else
                {
                    if (player.Club.Equals(searchedPlayer.Club))
                    {
                        links = links + 1;
                    }

                    if ( !searchedPlayer.Club.ToLower().Equals("hero"))
                    {
                        if ( player.League.Equals(searchedPlayer.League) )
                        {
                            links = links + 1;
                        }
                    }
                }                
                
                
                if ( player.Nation.Equals(searchedPlayer.Nation) )
                {
                    links = links + 1;
                }
            }

            //player in correct position?
            if (player.FormationPosition.Equals(player.PlayedPosition))
            {
                links = links + 2;
            }
            else if ( links > 5 )
            {
                links = 5;
            }
          

            //final adjustments
            var chemistryResult = new ChemistryResult();
            if (links < 5)
            {
                links = 0;
                chemistryResult.Chemistry = Chemistry.Red;
            }
            else if (links > 6)
            {
                links = 7;
                chemistryResult.Chemistry = Chemistry.Green;
            }
            else
            {
                links = 5;
                chemistryResult.Chemistry = Chemistry.Yellow;
            }

            chemistryResult.ChemistryValue = links;

            return chemistryResult;
        }
    }
}
