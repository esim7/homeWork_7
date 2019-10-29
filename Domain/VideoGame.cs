using System;
using System.Collections.Generic;

namespace Domain
{
    public class VideoGame : Entity
    {
        public string Name { get; set; }
        public string GameInfo { get; set; }
        public int AverageMark { get; set; }
    }
}
