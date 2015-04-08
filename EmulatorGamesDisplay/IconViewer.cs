using System.Drawing;
using System.Windows.Forms;

namespace EmulatorGamesDisplay
{
    public partial class IconViewer : Form
    {
        public IconViewer(Image pImage)
        {
            InitializeComponent();
            Size = new Size(pImage.Width + 6, pImage.Height + 24); //Accounting for the form's border size...
            pbxGameIcon.Image = pImage;
        }
    }
}
