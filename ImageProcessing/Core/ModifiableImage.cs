using System.Drawing;

namespace ImageProcessing.Core
{
    public class ModifiableImage
    {
        // Using System.Drawing.Image as a placehodel for image data storage        
        private Image imageData;

        public ModifiableImage(Image imageData)
        {
            if (imageData == null) throw new ArgumentNullException(nameof(imageData));

            this.ImageData = imageData;
        }

        public Image ImageData { get => imageData; private set => imageData = value; }
    }
}
