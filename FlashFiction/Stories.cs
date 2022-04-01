using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashFiction
{

    class Story
    {
        public string name;
        public string title;
        public string story;

        public Story(string name, string title, string story)
        {
            this.name = name;
            this.title = title;
            this.story = story;
        }
    }
}
