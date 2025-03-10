// See https://aka.ms/new-console-template for more information
using System;

public class KodePos
{
    public static string GetKodePos(string daerah)
    {
        string[,] dataKodePos =
        {
            {"Batununggal", "40266" },
            {"Kujangsari", "40287" },
            {"Mengger", "40267" },
            {"Wates", "40256" },
            {"Cijaura", "40287" },
            {"Jatisari", "40286" },
            {"Margasari", "40286" },
            {"Sekejati", "40286" },
            {"Kebonwaru", "40272" },
            {"Maleer", "40274" },
            {"Samoja", "40273" }
        };

        for (int i = 0; i < dataKodePos.GetLength(0); i++)
        {
            if (dataKodePos[i, 0].Equals(daerah, StringComparison.OrdinalIgnoreCase))
            { 
                return dataKodePos[i, 1];
            }
        }
        return "kode pos tidak ditemukan";
    }
}

public class DoorMachine
{
    enum State { Terkunci, Terbuka, Keluar};
    public void door()
    {
        State state = State.Terkunci;
        String[] doorState = { "terkunci", "terbuka", "keluar" };

        Console.WriteLine("\n" + ">>Pintu saat ini " + doorState[(int)state] + "\n");
        while (state != State.Keluar)
        { 
            Console.WriteLine("Masukkan perintah: ");
            String perintah = Console.ReadLine();

            switch (state)
            {
                case State.Terkunci:
                    if(perintah == "Buka Pintu")
                    {
                        state = State.Terbuka;
                        Console.WriteLine(">>Pintu tidak terkunci\n");
                    }
                    else if (perintah == "Kunci Pintu")
                    {
                        state = State.Terkunci;
                        Console.WriteLine(">>Pintu terkunci\n");
                    }
                    else if(perintah == "Keluar")
                    {
                        Program.Main();
                    }
                    break;
                case State.Terbuka:
                    if(perintah == "Buka Pintu")
                    {
                        state = State.Terbuka;
                        Console.WriteLine(">>Pintu tidak terkunci\n");
                    }
                    else if(perintah == "Kunci Pintu")
                    {
                        state = State.Terkunci;
                        Console.WriteLine(">>Pintu terkunci\n");
                    }
                    else if (perintah == "Keluar")
                    {
                        Program.Main();
                    }
                    break;
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        int pilihan;
        do
        {
            Console.WriteLine("\n======= M E N U =======");
            Console.WriteLine("1. Program Kode Pos");
            Console.WriteLine("2. Program Door Machine");
            Console.WriteLine("3. Keluar");
            Console.WriteLine("=======================");
            Console.WriteLine("Masukkan Pilihan: ");
            pilihan = Int32.Parse(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    Console.WriteLine("Masukkan nama kelurahan: ");
                    string kelurahan = Console.ReadLine() ?? "";

                    string kodePos = KodePos.GetKodePos(kelurahan);
                    Console.WriteLine($"kode pos {kelurahan} : {kodePos}");
                    break;
                case 2:
                    DoorMachine door = new DoorMachine();
                    door.door();
                    break;
            }
        } while (pilihan != 3);
    }
}