using System.Xml.Serialization;

namespace EmulatorGamesDisplay
{
    public class Game
    {
        public Game()
        {
            Plays = 0;
            ModifiedOrAdded = false;
        }

        [XmlIgnore]
        public bool ModifiedOrAdded; //For checking if we should save...
        public string Name;
        public string Date;
        public string Description;
        public string Platform;
        public int Rating;
        public int Plays;
        public string FileName;
        public SerializableImage Icon;
        public string RealFileName;
    }
}
