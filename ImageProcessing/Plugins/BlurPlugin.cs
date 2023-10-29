using ImageProcessing.Core;
using System.Drawing;

namespace ImageProcessing.Plugins
{
    internal class BlurPlugin : IImagePlugin
    {
        private int blurRadius;

        public BlurPlugin(int blurRadius = 1) 
        {
            this.blurRadius = blurRadius;
        }

        public ModifiableImage ModifyImage(ModifiableImage modifiableImage)
        {
            // blurring logic

            Bitmap blurredImage = new Bitmap(modifiableImage.ImageData);

            // ...

            return new ModifiableImage(blurredImage);
        }
    }
}
