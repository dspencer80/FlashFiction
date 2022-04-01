﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashFiction
{
    public class bookShelf
    {
        Shelf book;

        public bookShelf()
        {
            book = new Shelf();
        }

        public static void Main(string[] args)
        {
            string selection = "";
            bookShelf prompt = new bookShelf();

            prompt.displayMenu();
            while (!selection.ToUpper().Equals("Q"))
            {
                Console.WriteLine("Selection: ");
                selection = Console.ReadLine();
                prompt.performAction(selection);
            }
        }

        void displayMenu()
        {
            Console.WriteLine("FLASH FICTION");
            Console.WriteLine("=========");
            Console.WriteLine("A - Add a story");
            Console.WriteLine("D - Delete a story");
            Console.WriteLine("E - Edit a story");
            Console.WriteLine("L - Show all stories");
            Console.WriteLine("Q - Quit");
        }

        void performAction(string selection)
        {
            string name = "";
            string title = "";
            string story = "";

            switch (selection.ToUpper())
            {
                case "A":
                    Console.WriteLine("Enter Author's Name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter Your Title: ");
                    title = Console.ReadLine();
                    Console.WriteLine("Begin Your Story: ");
                    story = Console.ReadLine();
                    if (book.add(name, title, story))
                    {
                        Console.WriteLine("Story successfully added!");
                    }
                    else
                    {
                        Console.WriteLine("A story is already on file for {0}.", name);
                    }
                    break;
                case "D":
                    Console.WriteLine("Enter Story to Delete: ");
                    name = Console.ReadLine();
                    if (book.remove(name))
                    {
                        Console.WriteLine("Story successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Story for {0} could not be found.", name);
                    }
                    break;
                case "L":
                    if (book.isEmpty())
                    {
                        Console.WriteLine("There are no stories.");
                    }
                    else
                    {
                        Console.WriteLine("Stories:");
                        book.list(
                          delegate (Story a) {
                              Console.WriteLine("{0} - {1}", a.name, a.title, a.story);
                          }
                        );
                    }
                    break;
                case "E":
                    Console.WriteLine("Enter Story to Edit: ");
                    title = Console.ReadLine();
                    Story stories = book.find(title);
                    if (stories == null)
                    {
                        Console.WriteLine("Story for {0} count not be found.", stories);
                    }
                    else
                    {
                        Console.WriteLine("Enter new Story: ");
                        stories.title = Console.ReadLine();
                        Console.WriteLine("Story updated for {0}", stories);
                    }
                    break;
            }
        }
    }

}
