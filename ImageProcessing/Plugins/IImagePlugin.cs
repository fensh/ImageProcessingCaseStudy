using ImageProcessing.Core;

namespace ImageProcessing.Plugins
{
    internal interface IImagePlugin
    {
        ModifiableImage ModifyImage(ModifiableImage image);
    }
}
