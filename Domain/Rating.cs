using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Rating : Entity
    {
        public virtual VideoGame VideoGame { get; set; } = new VideoGame();
        public virtual User User { get; set; } = new User();
        public int Mark { get; set; }

    }
}
