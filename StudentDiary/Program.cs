﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();

            //diary.AddRating(5);
            //diary.AddRating(8.5f);
            //diary.AddRating(4.7f);
            //float avg = diary.CalculateAverage();
            //float max = diary.GivenMaxRating();
            //float min = diary.GivenMinRating();

            for (; ; )
            {
                Console.WriteLine("Podaj ocene z zakresu 1-10. (11 konczy wprowadzanie ocen) ");
                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);       // wczytywanie oceny z konsoli i wpisywanie do rating
                                                                                    // zabezpieczenie przed wpisywaniem liter zamiast cyfr

                if (rating == 11)       // 11 zatrzymuje petle do wpisywania ocen
                {
                    break;
                }

                if (result)
                {
                    if (rating > 0 && rating <= 10) // jezeli liczba miesi sie w zakresie 1-10 to dopisz ja do dzienniczka
                    {
                        diary.AddRating(rating);    // dodawanie wpisanej oceny do dzienniczka
                    }
                    else                            // jezeli liczba z poza zakresu 1-10 to nie dopisuj jej, wyswietl tylko ostrzerzenie
                    {
                        Console.WriteLine("Niepoprawna liczba. Liczba z poza zakresu 1-10!");
                    }
                }
            }

            Console.WriteLine("Srednia twoich ocento: " + diary.CalculateAverage());
            Console.WriteLine("Najwyzsza ocena to: " + diary.GivenMaxRating());
            Console.WriteLine("Najnizsza ocena to: " + diary.GivenMinRating());
            
            Console.ReadKey();
        }
    }
}
