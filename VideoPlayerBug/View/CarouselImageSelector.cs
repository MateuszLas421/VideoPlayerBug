using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoPlayerBug.Models;
using VideoPlayerBug.View.Items;

namespace VideoPlayerBug.View
{
    public class CarouselImageSelector : DataTemplateSelector
    {
        DataTemplate DataTemplateImage;
        DataTemplate DataTemplateVideo;

        public CarouselImageSelector()
        {
            DataTemplateImage = new DataTemplate(typeof(ImageItem));
            DataTemplateVideo = new DataTemplate(typeof(VideoItem));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var media = item as MediaItem;
            if (!media.IsVideo)
            {
                return DataTemplateImage;
            }
            else
            {
                return DataTemplateVideo;
            }
        }
    }
}
