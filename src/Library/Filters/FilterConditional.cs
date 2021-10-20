using System;
using CognitiveCoreUCU;

namespace CompAndDel.Filters
{
    public class FilterConditional
    {
        public Boolean Filter(IPicture image)
        {
            PictureProvider provider4 = new PictureProvider();
            CognitiveFace cognitiveFace = new CognitiveFace(false, System.Drawing.Color.Blue);
            FilterSave save = new FilterSave();
            save.Filter(image);
            return cognitiveFace.FaceFound;         
        }
    }
}