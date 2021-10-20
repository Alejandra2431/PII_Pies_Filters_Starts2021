using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"beer.jpg");
            IPipe thirdPipe = new PipeNull();
            IPipe secondPipe = new PipeSerial(new FilterNegative(), thirdPipe);
            IPipe firstPipe = new PipeSerial(new FilterGreyscale(), secondPipe);
            provider.SavePicture(picture, @"beer.jpg");

            //Ejercicio 2
            
            PictureProvider provider2 = new PictureProvider();
            IPicture picture2 = provider2.GetPicture(@"beer.jpg");

            IPipe fifthPipe2= new PipeNull();
            IPipe fourthPipe2= new PipeSerial(new FilterSave(),fifthPipe2);
            IPipe thirdPipe2= new PipeSerial(new FilterNegative(), fourthPipe2);
            IPipe secondPipe2= new PipeSerial(new FilterSave(),thirdPipe2);
            IPipe firstPipe2= new PipeSerial(new FilterGreyscale(),secondPipe2);
            provider2.SavePicture(picture2, @"beer.jpg");

            //Ejercicio 3

            PictureProvider provider3 = new PictureProvider();
            IPicture pic2 = provider3.GetPicture("..\\Adds\\índice.jpg");

            IPipe fifthpipe3 = new PipeNull();
            IPipe fourthpipe3 = new PipeSerial(new FilterTwitter(), fifthpipe3);
            IPipe thirdpipe3 = new PipeSerial(new FilterNegative(), fourthpipe3);
            IPipe secondpipe3 = new PipeSerial(new FilterTwitter(), thirdpipe3);
            IPipe firstpipe3= new PipeSerial(new FilterGreyscale(),secondpipe3);
            firstpipe3.Send(pic2);

            //Ejercicio 4

            PictureProvider provider4 = new PictureProvider();
            IPicture pic4 = provider4.GetPicture(@"luke.jpg");

            IPipe fifthPipe4= new PipeNull();

            IPipe thirdPipe4= new PipeSerial(new FilterNegative(), fifthPipe4);


            firstpipe3.Send(pic4);
            provider4.SavePicture(thirdPipe4.Send(pic4),@"luke.jpg");

        }
    }
}
