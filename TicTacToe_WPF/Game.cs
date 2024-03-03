﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_WPF
{
    internal class Game
    {
        Random random = new Random();
        public int step = 0;
        public string[] msg = new string[] { "Ход игрока играющего крестиком!", "Ход игрока играющего ноликом!" };
        public string[] win = new string[] { "Победил игрок играющий крестиком!", "Победил игрок играющий ноликом!"};
        private string cross = "X", zero = "O";
        //char[] Endaged = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        // Проверяем занято поле.
        //bool Is_Endaged(int value, char cr)
        //{
        //    if (Endaged[value] != cross && Endaged[value] != zero)
        //    {
        //        Endaged[value] = cr;
        //        return true;
        //    }
        //    else
        //        return false;
        //}

        // Ничья
        //bool Is_Draw()
        //{
        //    for (int i = 0; i < Endaged.Length; i++)
        //    {
        //        if (Is_Endaged(i, Convert.ToChar(i + 49)))
        //            return true;
        //    }
        //    Console.WriteLine("Ничья\nДля выход нажмите любую кнопку");
        //    Console.ReadKey(true);
        //    return false;
        //}

        // Метод проверяет выигрышные ситуации.
        //bool Is_Winner()
        //{
        //    // 1 == 2 == 3
        //    if (Endaged[0] == Endaged[1] && Endaged[1] == Endaged[2])
        //    {
        //        Console.WriteLine(win[step]);
        //        Console.ReadKey(true);
        //        return false;
        //    }

        //    // 4 == 5 == 6
        //    if (Endaged[3] == Endaged[4] && Endaged[4] == Endaged[5])
        //    {
        //        Console.WriteLine(win[step]);
        //        Console.ReadKey(true);
        //        return false;
        //    }

        //    // 7 == 8 == 9
        //    if (Endaged[6] == Endaged[7] && Endaged[7] == Endaged[8])
        //    {
        //        Console.WriteLine(win[step]);
        //        Console.ReadKey(true);
        //        return false;
        //    }

        //    // 1 == 5 == 9
        //    if (Endaged[0] == Endaged[4] && Endaged[4] == Endaged[8])
        //    {
        //        Console.WriteLine(win[step]);
        //        Console.ReadKey(true);
        //        return false;
        //    }

        //    // 3 == 5 == 7
        //    if (Endaged[2] == Endaged[4] && Endaged[4] == Endaged[6])
        //    {
        //        Console.WriteLine(win[step]);
        //        Console.ReadKey(true);
        //        return false;
        //    }

        //    // 1 == 4 == 7
        //    if (Endaged[0] == Endaged[3] && Endaged[3] == Endaged[6])
        //    {
        //        Console.WriteLine(win[step]);
        //        Console.ReadKey(true);
        //        return false;
        //    }

        //    // 2 == 5 == 8
        //    if (Endaged[1] == Endaged[4] && Endaged[4] == Endaged[7])
        //    {
        //        Console.WriteLine(win[step]);
        //        Console.ReadKey(true);
        //        return false;
        //    }

        //    // 3 == 6 == 9
        //    if (Endaged[2] == Endaged[5] && Endaged[5] == Endaged[8])
        //    {
        //        Console.WriteLine(win[step]);
        //        Console.ReadKey(true);
        //        return false;
        //    }
        //    return true;
        //}

        // Ход компьютера
        //void ComLogic(char cr)
        //{
        //    bool cycle = true;
        //    Console.WriteLine("Ход компьютера");
        //    Console.WriteLine($"Вы играете {cr}\n");
        //    do
        //    {
        //        if (Is_Endaged(random.Next(9), cr))
        //            cycle = false;
        //    } while (cycle);
        //    System.Threading.Thread.Sleep(2000);
        //}

        // Ход игрока
        //void Player(char cr)
        //{
        //    bool cycle = true;
        //    Console.WriteLine("Ход игрока");
        //    Console.WriteLine($"Вы играете {cr}\n");
        //    try
        //    {
        //        while (cycle)
        //        {
        //            Console.SetCursorPosition(0, 12);
        //            for (int i = 0; i < 5; i++)
        //            {
        //                Console.WriteLine("                                                                                                    ");
        //            }
        //            Console.SetCursorPosition(0, 12);
        //            Console.Write("Введите номер свободной ячейки: ");
        //            if (!Is_Endaged(Convert.ToInt32(Console.ReadLine()) - 1, cr))
        //            {
        //                Console.WriteLine("Такой ход уже был!\n");
        //                Console.ReadKey(true);
        //            }
        //            else
        //                cycle = false;
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        Console.WriteLine("Для продолжения нажмите любую клавишу!");
        //        Console.ReadKey();

        //    }
        //}

        // Кто ходит?
        //public string Step()
        //{
        //    if (step == 0)
        //    {
        //        //ComLogic(zero);
        //        //Player(zero);
        //        step = 1;
        //        return zero;
        //    }
        //    else
        //    {
        //        //Player(cross);
        //        step = 0;
        //        return cross;
        //    }
        //}

        //
        //public void Play()
        //{
        //    step = random.Next(2);
        //    do
        //    {           
        //        Step();
        //    }
        //    while (Is_Winner() && Is_Draw());
        //}
    }
}
