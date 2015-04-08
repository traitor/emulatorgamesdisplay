using System.Drawing;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace EmulatorGamesDisplay
{
    public class SerializableImage : IXmlSerializable
    {
        private string _base64;
        private Image _image;
        [XmlIgnore]
        public Image Image { get { return _image; } set { _image = value; } }

        public SerializableImage()
        {

        }

        public SerializableImage(string pBase64)
        {
            _base64 = pBase64;
            Image = ByteArrayToImage(System.Convert.FromBase64String(pBase64));
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void WriteXml(XmlWriter pWriter)
        {
            //w.WriteString(System.Convert.ToBase64String(ImageToByteArray(Image)));
            pWriter.WriteString(_base64);
        }

        public void ReadXml(XmlReader pReader)
        {
            pReader.MoveToContent();

            bool isEmptyElement = pReader.IsEmptyElement;
            pReader.ReadStartElement();
            if (!isEmptyElement)
            {
                _base64 = pReader.ReadContentAsString();
                Image = ByteArrayToImage(System.Convert.FromBase64String(_base64));
                pReader.ReadEndElement();
            }
        }

        public Image GetIcon(Game pGame, Config pConfig)
        {
            return GetPlatformImage(pGame, ResizeImage(pConfig.IconWidth - (pConfig.ShowPlatformIcon && pConfig.ResizeWithPlatformIcon ? 32 : 0),
                    pConfig.IconHeight - (pConfig.ShowPlatformIcon && pConfig.ResizeWithPlatformIcon ? 32 : 0), true), pConfig);
        }

        public Image ResizeImage(int pNewWidth, int pMaxHeight, bool pResizeIfWider)
        {
            var orgWidth = pNewWidth;
            var orgHeight = pMaxHeight;
            // Ensure the generated thumbnail is not being used by rotating it 360 degrees
            _image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            _image.RotateFlip(RotateFlipType.Rotate180FlipNone);

            if (pResizeIfWider)
            {
                if (_image.Width <= pNewWidth)
                {
                    pNewWidth = _image.Width;
                }
            }

            var newHeight = _image.Height * pNewWidth / _image.Width;
            if (newHeight > pMaxHeight)
            {
                pNewWidth = _image.Width * pMaxHeight / _image.Height;
                newHeight = pMaxHeight;
            }

            var temp = new Bitmap(orgWidth, pMaxHeight);
            var newImage = Graphics.FromImage(temp);
            newImage.DrawImage(_image, orgWidth / 2 - pNewWidth / 2, orgHeight / 2 - newHeight / 2, pNewWidth, newHeight);
            return temp;
        }

        public Image GetPlatformImage(Game pGame, Image pImage, Config pConfig)
        {
            var bitmap = new Bitmap(pConfig.IconWidth, pConfig.IconHeight);
            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.DrawImage(pImage, new Point(pConfig.IconWidth / 2 - pImage.Width / 2, pConfig.IconHeight / 2 - pImage.Height / 2));

                if (pConfig.ShowPlatformIcon) //Apply platform icon.
                {
                    Bitmap platformImage = null;
                    switch (pGame.Platform)
                    {
                        case "NES":
                        case "Nintendo Entertainment System":
                            platformImage = Properties.Resources.NES;
                            break;

                        case "SNES":
                        case "Super Nintendo":
                            platformImage = Properties.Resources.SNES;
                            break;

                        case "N64":
                        case "Nintendo 64":
                            platformImage = Properties.Resources.N64;
                            break;

                        case "GB":
                        case "GameBoy":
                            platformImage = Properties.Resources.GB;
                            break;

                        case "GBC":
                        case "GameBoy Color":
                            platformImage = Properties.Resources.GBC;
                            break;

                        case "GBA":
                        case "GameBoy Advance":
                            platformImage = Properties.Resources.GBA;
                            break;

                        case "NDS":
                        case "Nintendo DS":
                            platformImage = Properties.Resources.NDS;
                            break;
                    }
                    if (platformImage != null)
                        graphics.DrawImage(platformImage, new Point(0, pConfig.IconHeight - platformImage.Height));
                }
            }
            return bitmap;
        }

        public Image GetPlatformImage(Game pGame, Config pConfig)
        {
            return GetPlatformImage(pGame, 
                ResizeImage(pConfig.IconWidth - (pConfig.ShowPlatformIcon && pConfig.ResizeWithPlatformIcon ? 32 : 0),
                pConfig.IconHeight - (pConfig.ShowPlatformIcon && pConfig.ResizeWithPlatformIcon ? 32 : 0), true), pConfig);
        }

        public static Image ByteArrayToImage(byte[] pByteArray)
        {
            Image returnImage;
            using (var ms = new MemoryStream(pByteArray))
            {
                returnImage = Image.FromStream(ms);
                ms.Close();
            }
            return returnImage;
        }

        public static byte[] ImageToByteArray(Image pImage)
        {
            byte[] byteArray;
            using (var ms = new MemoryStream())
            {
                pImage.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                byteArray = ms.ToArray();
                ms.Close();
            }
            return byteArray;
        }
    }
}