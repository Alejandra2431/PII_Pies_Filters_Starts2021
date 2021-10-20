using System.Drawing;

namespace CompAndDel.Filters
{
    public class FilterSave : IFilter
    {
        public IPicture Filter(IPicture image)
        {
            PictureProvider p2 = new PictureProvider();
            p2.SavePicture(image, @"beer.jpg");  
            return image;          
        }
    }
}