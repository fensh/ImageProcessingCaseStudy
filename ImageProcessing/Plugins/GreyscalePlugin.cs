using ImageProcessing.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing.Plugins
{
    internal class GrayscalePlugin : IImagePlugin
    {
        public GrayscalePlugin() { }

        public ModifiableImage ModifyImage(ModifiableImage image)
        {
            // greyscale logic
            Bitmap blurredImage = new Bitmap(image.ImageData);

            // ...

            return new ModifiableImage(blurredImage);
        }
    }
}
