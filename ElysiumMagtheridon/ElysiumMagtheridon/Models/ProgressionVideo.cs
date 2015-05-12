using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElysiumMagtheridon.Models
{
    public class ProgressionVideo : IProgressionItem
    {
        string type;

        public ProgressionVideo(string videoType)
        {
            this.type = videoType;
        }
    }
}