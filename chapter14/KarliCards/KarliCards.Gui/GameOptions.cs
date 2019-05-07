using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace KarliCards.Gui
{
    [Serializable]
    public class GameOptions
    {

        private ObservableCollection<string> playerNames = new ObservableCollection<string>();
        public List<string> SelectedPlayers { get; set; } = new List<string>();
        private bool playAgainstComputer = true;
        private int numberOfPlayers = 2;
        private ComputerSkillLevel computerSkill = ComputerSkillLevel.Dumb;


        public bool PlayAgainstComputer {
            get { return playAgainstComputer; }
            set {
                playAgainstComputer = value;
                OnPropertyChanged(nameof(PlayAgainstComputer));
            }

        }
        public int NumberOfPlayers {
            get { return numberOfPlayers; }
            set {
                numberOfPlayers = value;
                OnPropertyChanged(nameof(NumberOfPlayers));
            }
        }
        public int MinutesBeforeLose { get; set; }
        public ComputerSkillLevel ComputerSkill {
            get { return computerSkill; }
            set {
                computerSkill = value;
                OnPropertyChanged(nameof(ComputerSkill));
            }
        }


        public ObservableCollection<string> PlayerNames
        {
            get
            {
                return playerNames;
            }
            set
            {
                playerNames = value;
                OnPropertyChanged("PlayerNames");
            }
        }

        public void AddPlayer(string playerName)
        {
            if (playerNames.Contains(playerName))
                return;
            playerNames.Add(playerName);
            OnPropertyChanged("PlayerNames");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }

    [Serializable]
    public enum ComputerSkillLevel
    {
        Dumb,
        Good,
        Cheats
    }






}
