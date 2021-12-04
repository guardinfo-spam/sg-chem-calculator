using NUnit.Framework;
using SgSeason2.Lib;
using System.Linq;
using static SgSeason2.Lib.Enums;

namespace SGSeason2.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void OutOfPositionPlayerHas5LinksAndYellowChem()
        {
            TeamData teamData = new TeamData();
            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "GK",
                Name = "Johny1",
                Nation = "Italy",
                PlayedPosition = "GK",
                TotalStats = 460
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny2",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny3",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "RB",
                Name = "Johny4",
                Nation = "Italy",
                PlayedPosition = "RB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny5",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny6",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny7",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny8",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny9",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny10",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });


            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CF",
                Name = "Johny11",
                Nation = "Italy",
                PlayedPosition = "ST",
                TotalStats = 450
            });

            var expectedChemistryResult = new ChemistryResult
            {
                ChemistryValue = 5,
                Chemistry = Chemistry.Yellow
            };

            teamData.CalculateDetailedChemistryData();

            Assert.IsTrue(teamData.Team.Last().PlayerChemistryInTeam.Equals(expectedChemistryResult));
        }

        [Test]
        public void InPositionPlayerHas7LinksAndGreenChem()
        {
            TeamData teamData = new TeamData();
            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "GK",
                Name = "Johny1",
                Nation = "Italy",
                PlayedPosition = "GK",
                TotalStats = 460
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny2",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny3",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "RB",
                Name = "Johny4",
                Nation = "Italy",
                PlayedPosition = "RB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny5",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny6",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny7",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny8",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny9",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny10",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });


            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "ST",
                Name = "Johny11",
                Nation = "Italy",
                PlayedPosition = "ST",
                TotalStats = 450
            });

            var expectedChemistryResult = new ChemistryResult
            {
                ChemistryValue = 7,
                Chemistry = Chemistry.Green
            };

            teamData.CalculateDetailedChemistryData();

            Assert.IsTrue(teamData.Team.Last().PlayerChemistryInTeam.Equals(expectedChemistryResult));
        }

        [Test]
        public void FrenchHeroInPositionHas2ButNoOtherMatchesLinksAndRedChem()
        {
            TeamData teamData = new TeamData();
            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "GK",
                Name = "Johny1",
                Nation = "Italy",
                PlayedPosition = "GK",
                TotalStats = 460
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny2",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny3",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "RB",
                Name = "Johny4",
                Nation = "Italy",
                PlayedPosition = "RB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny5",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny6",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny7",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny8",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny9",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny10",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });


            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Hero",
                League = "Serie A",
                FormationPosition = "ST",
                Name = "Johny11",
                Nation = "France",
                PlayedPosition = "ST",
                TotalStats = 450
            });

            var expectedChemistryResult = new ChemistryResult
            {
                ChemistryValue = 2,
                Chemistry = Chemistry.Red
            };

            teamData.CalculateDetailedChemistryData();

            Assert.IsTrue(teamData.Team.Last().PlayerChemistryInTeam.Equals(expectedChemistryResult));
        }

        [Test]
        public void FrenchHeroInPositionHas2LinksAndRedChem()
        {
            TeamData teamData = new TeamData();            

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny9",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Hero",
                League = "PL",
                FormationPosition = "CB",
                Name = "Johny10",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });


            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Hero",
                League = "Serie A",
                FormationPosition = "ST",
                Name = "Johny11",
                Nation = "France",
                PlayedPosition = "ST",
                TotalStats = 450
            });

            var expectedChemistryResult = new ChemistryResult
            {
                ChemistryValue = 2,
                Chemistry = Chemistry.Red
            };

            teamData.CalculateDetailedChemistryData();

            Assert.IsTrue(teamData.Team.Last().PlayerChemistryInTeam.Equals(expectedChemistryResult));
        }

        [Test]
        public void FrenchHeroInPositionHas4LinksAndRedChem()
        {
            TeamData teamData = new TeamData();

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny9",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Hero",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny10",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });


            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Hero",
                League = "Serie A",
                FormationPosition = "ST",
                Name = "Johny11",
                Nation = "France",
                PlayedPosition = "ST",
                TotalStats = 450
            });

            var expectedChemistryResult = new ChemistryResult
            {
                ChemistryValue = 4,
                Chemistry = Chemistry.Red
            };

            teamData.CalculateDetailedChemistryData();

            Assert.IsTrue(teamData.Team.Last().PlayerChemistryInTeam.Equals(expectedChemistryResult));
        }


        [Test]
        public void ItalianHeroInPositionHas3LinksAndRedChemWIthAnotherItalianNonHeroPlayer()
        {
            TeamData teamData = new TeamData();

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Milan",
                League = "Serie A",
                FormationPosition = "CB",
                Name = "Johny9",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Hero",
                League = "Serie A",
                FormationPosition = "ST",
                Name = "Johny11",
                Nation = "Italy",
                PlayedPosition = "ST",
                TotalStats = 450
            });

            var expectedChemistryResult = new ChemistryResult
            {
                ChemistryValue = 3,
                Chemistry = Chemistry.Red
            };

            teamData.CalculateDetailedChemistryData();

            Assert.IsTrue(teamData.Team.Last().PlayerChemistryInTeam.Equals(expectedChemistryResult));
        }

        [Test]
        public void ItalianIcons()
        {
            TeamData teamData = new TeamData();

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Icon",
                League = "Icon",
                FormationPosition = "CB",
                Name = "Johny9",
                Nation = "Italy",
                PlayedPosition = "CB",
                TotalStats = 450
            });

            teamData.AddPlayerInTeam(new PlayerData
            {
                Club = "Icon",
                League = "Icon",
                FormationPosition = "ST",
                Name = "Johny11",
                Nation = "Italy",
                PlayedPosition = "ST",
                TotalStats = 450
            });

            var expectedChemistryResult = new ChemistryResult
            {
                ChemistryValue = 10,
                Chemistry = Chemistry.Red
            };

            teamData.CalculateDetailedChemistryData();
            var teamChem = teamData.TeamChemistry;

            Assert.IsTrue(teamChem.Equals(expectedChemistryResult));
        }
    }
}