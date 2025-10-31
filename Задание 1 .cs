using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pr_1
{
    internal class Book
    {
            private string title;
            private int pages;

            public string Title
            {
                get { return title; }
                set { title = value ?? "Без названия"; } 
            }

            public int Pages
            {
                get { return pages; }
                set
                {
                    if (value < 1 || value > 5000)
                    {
                        Console.WriteLine("Страниц должно быть от 1 до 5000!");
                        return;
                    }
                    pages = value;
                }
            }

            public Book(string title, int pages)
            {
                Title = title;
                Pages = pages;
            }

            public Book(string title) : this(title, 10)
            {
            }

            public Book() : this("Без названия")
            {
            }

            public void Read()
            {
                Console.WriteLine($"Читаю книгу \"{Title}\", страниц: {Pages}.");
            }
    }
    public static void Main()
        {
            Book book1 = new Book("Колобок", 15);
            Book book2 = new Book("Скорбь сатаны", 544);
            Book book3 = new Book("Клуб самоубийц", 256);

            book1.Read();
            book2.Read();
            book3.Read();

            Console.WriteLine();

            Console.WriteLine("Попытка установить 0 страниц:");
            Book badBook = new Book("Неизвестная книга", 0);
            badBook.Read();

        }


    }

 
