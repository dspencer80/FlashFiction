using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashFiction
{
    class Shelf
    {
        List<Story> stories = new List<Story>();


        public bool add(string name, string title, string story)
        {
            Story stories = new Story(name, title, story);
            Story result = find(name);

            if (result == null)
            {
                this.stories.Add(stories);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool remove(string name)
        {
            Story stories = find(name);

            if (stories != null)
            {
                this.stories.Remove(stories);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void list(Action<Story> action)
        {
            stories.ForEach(action);
        }

        public bool isEmpty()
        {
            return (stories.Count == 0);
        }

        public Story find(string name)
        {
            Story story = stories.Find(
              delegate (Story a) {
                  return a.name == name;
              }
            );
            return story;
        }
    }
}
