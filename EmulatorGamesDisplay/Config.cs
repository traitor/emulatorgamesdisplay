namespace EmulatorGamesDisplay
{
    public class Config
    {
        public Config()
        {
            Maximized = false;
        }

        public string RomDirectory;
        public string NESEmulator;
        public string SuperNESEmulator;
        public string N64Emulator;
        public string GBAEmulator;
        public string DSEmulator;
        public bool Maximized;
        public bool HideSidebar = false;
        public int WindowWidth = 993;
        public int WindowHeight = 536;
        public int IconWidth;
        public int IconHeight;
        public bool ShowPlatformIcon;
        public bool ResizeWithPlatformIcon;
    }
}
