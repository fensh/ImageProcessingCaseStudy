using ImageProcessing.Core;
using System.Drawing;

namespace ImageProcessing.Plugins
{
    internal class ResizePlugin : IImagePlugin
    {
        private int targetWidth;
        private bool keepAspectRatio;

        public ResizePlugin(int targetWidth, bool keepAspectRatio = false)
        {
            this.targetWidth = targetWidth;
            this.keepAspectRatio = keepAspectRatio;
        }

        public ModifiableImage ModifyImage(ModifiableImage image)
        {
            // resizing logic
            Bitmap blurredImage = new Bitmap(image.ImageData);

            // ...

            return new ModifiableImage(blurredImage);
        }
    }
}
