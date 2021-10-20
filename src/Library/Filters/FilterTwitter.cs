using System.Drawing;
using TwitterUCU;
using System;

namespace CompAndDel.Filters
{
    public class FilterTwitter : IFilter
    {
        public IPicture Filter(IPicture image)
        {
            var twitter = new TwitterImage();
            //await twitter.InitializeAsync();
            Console.WriteLine(twitter.PublishToTwitter("text", @"PathToImage.png"));
            return image;          
        }
    }
}