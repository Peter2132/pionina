

class Pianino
{
    static int[] Octave1 = { 1047, 1175, 1319, 1397, 1568, 1760, 1976, 1109, 1245, 1480, 1661, 1865 };
    static int[] Octave2 = { 2093, 2349, 2637, 2794, 3136, 3520, 3951, 2217, 2489, 2960, 3322, 3729 };
    static int[] Octave3 = { 4126, 4699, 5274, 5588, 6272, 7040, 7902, 4435, 4978, 5920, 6645, 7459 };
    static int[] Noti = Octave1; 

    static void Main(string[] name)
    {
        ConsoleKeyInfo KeyInfo;

        do
        {
            KeyInfo = Console.ReadKey(true);

            Console.WriteLine("F1, F2, F3 для переключения.");
            Console.WriteLine("Нажмите Q,W,E,R,T,Y,U - белые. A,S,D,F,G - черные.");
            Console.WriteLine("Нажмите Enter для выхода.");
            if (KeyInfo.Key == ConsoleKey.F1)
            {
                
                Noti = Octave1;
            }    

            else if (KeyInfo.Key == ConsoleKey.F2)
            {
                
                Noti = Octave2;
            }

            else if (KeyInfo.Key == ConsoleKey.F3)
            {
                
                Noti = Octave3;
            }

            if (KeyInfo.Key == ConsoleKey.Q)
            {
                Console.Beep(Noti[0], 300);

            }
               
            else if (KeyInfo.Key == ConsoleKey.W)
            {
                Console.Beep(Noti[1], 300);
            }
                
            else if (KeyInfo.Key == ConsoleKey.E)
            {
                Console.Beep(Noti[2], 300);
            }
                
            else if (KeyInfo.Key == ConsoleKey.R)
            {
                Console.Beep(Noti[3], 300);

            }
                
            else if (KeyInfo.Key == ConsoleKey.T)
            {
                Console.Beep(Noti[4], 300);
            }
                
            else if (KeyInfo.Key == ConsoleKey.Y)
            {
                Console.Beep(Noti[5], 300);
            }
                
            else if (KeyInfo.Key == ConsoleKey.U)
            {
                Console.Beep(Noti[6], 300);
            }
                
            else if (KeyInfo.Key == ConsoleKey.A)
            {
                Console.Beep(Noti[7], 300);
            }
                
            else if (KeyInfo.Key == ConsoleKey.S)
            {
                Console.Beep(Noti[8], 300);
            }
               
            else if (KeyInfo.Key == ConsoleKey.D)
            {
                Console.Beep(Noti[9], 300);
            }
                
            else if (KeyInfo.Key == ConsoleKey.F)
            {
                Console.Beep(Noti[10], 300);
            }
            else if (KeyInfo.Key == ConsoleKey.G)
            {
                Console.Beep(Noti[11], 300);
            }

            else if (KeyInfo.Key == ConsoleKey.Enter)
            {
                break;
            }
        } while (true);
    }
}