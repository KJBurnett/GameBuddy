using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Buddy
{
    public class ImageHolder
    {
        public string name      { get; set; }
        public int currentImage { get; set; }
        public int totalImages  { get; set; }

        public ImageHolder() { }

        public ImageHolder(string name, string currentImage, string totalImages)
        {
            this.name = name;
            this.currentImage   = Convert.ToInt32(currentImage);
            this.totalImages    = Convert.ToInt32(totalImages);
        }

        public string GetStoredImage()
        {
            return this.name + " (" + this.currentImage + ").png";
        }

        public override string ToString()
        {
            return this.name + "," + this.currentImage.ToString() + "," + this.totalImages.ToString();
        }
 
    }// end class ImageHolder
}// end namespace Game_Buddy
