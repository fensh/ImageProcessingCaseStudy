using ImageProcessing.Plugins;
using System.Drawing;

namespace ImageProcessing.Core
{
    internal class ImageModifier
    {
        private List<IImagePlugin> imagePlugins;
        public ImageModifier(params IImagePlugin[] imagePlugins) 
        {
            this.imagePlugins = new List<IImagePlugin>();
            this.imagePlugins.AddRange(imagePlugins);
        }

        public ImageModifier()
        {
            this.imagePlugins = new List<IImagePlugin>();
        }

        public void AddPlugin(IImagePlugin imagePlugin)
        {
            this.imagePlugins.Add(imagePlugin);
        }

        public Image ModifyImage(Image image)
        {
            var modifiableImage = new ModifiableImage(image); 

            foreach (var plugin in imagePlugins)
            {
                modifiableImage = plugin.ModifyImage(modifiableImage);
            }

            return modifiableImage.ImageData;
        }
    }
}
