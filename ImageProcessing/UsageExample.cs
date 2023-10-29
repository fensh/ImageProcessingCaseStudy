using ImageProcessing.Core;
using ImageProcessing.Plugins;
using System.Drawing;

namespace ImageProcessing
{
    public class UsageExample
    {
        public static void ImageModificationUsage()
        {
            var originalImage = Image.FromFile("sample.png");
            
            var modifier = new ImageModifier();
            modifier.AddPlugin(new ResizePlugin(targetWidth: 100, keepAspectRatio: true));
            modifier.AddPlugin(new BlurPlugin(blurRadius: 2));
            modifier.AddPlugin(new GrayscalePlugin());

            var newImage = modifier.ModifyImage(originalImage);
        }
    }
}
