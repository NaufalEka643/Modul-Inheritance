using InLaptop;

class program
{
    static void Main(string[] args)
    {
        Vga vga1 = new inVga.Nvidia("Nvidia");
        Vga vga2 = new inVga.AMD("AMD");
        Processor processor1 = new Processor("Intel","Core i5");
        Processor processor2 = new Processor("AMD", "Ryzen");
        Processor processor3 = new Processor("Intel", "Core i7");

        Laptop laptop1 = new InLaptop.Vivobook("ASUS", "Vivobook",vga1, processor1);
        Laptop laptop2 = new InLaptop.Ideapad("Lenovo", "Ideapad",vga2, processor2);
        Predator predator = new InLaptop.Predator("Acer", "Predator",vga2, processor3);

        Acer acer = new Predator("Acer", "Predator", vga2, processor3);
        //acer.BermainGame();
        
        predator.BermainGame();
        
        //Console.WriteLine(laptop1.vga.merk);
        //Console.WriteLine(laptop1.processor.merk);
        //Console.WriteLine(laptop1.processor.tipe);

        //laptop2.LaptopDinyalakan();
        //laptop2.LaptopDimatikan();

        //laptop1.Ngoding();

    }

}
class Laptop
{
    public string merk;
    public string tipe;
    public Vga vga;
    public Processor processor;
    public Laptop(string merk, string tipe, Vga vga, Processor processor)
    {
        this.merk = merk;
        this.tipe = tipe;
        this.vga = vga;
        this.processor = processor;
    }
    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} Menyala");
    }
    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} Mati");
    }
}

namespace InLaptop
{
    class ASUS : Laptop
    {
        public ASUS(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            merk = "ASUS";
        }
    }
    class ROG : ASUS
    {
        public ROG(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            tipe = "ROG";
        }
    }
    class Vivobook : ASUS
    {
        public Vivobook(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }
    class Acer : Laptop
    {
        public Acer(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            merk = "Acer";
        }
    }
    class Swift : Acer
    {
        public Swift(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            tipe = "Swift";
        }
    }

    class Predator : Acer
    {
        public Predator(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {this.merk} {this.tipe} sedang memainkan game");
        }
    }
    class Lenovo : Laptop
    {
        public Lenovo(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            merk = "Lenovo";
        }
    }
    class Ideapad : Lenovo
    {
        public Ideapad(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            tipe = "Ideapad";
        }
    }
    class Legion : Lenovo
    {
        public Legion(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            tipe = "Legion";
        }
    }

}


class Processor
{
    public string merk;
    public string tipe;
    public Processor(string merk, string tipe)
    {
        this.merk = merk;
        this.tipe = tipe;
    }
}

namespace InProcessor
{
    class Intel : Processor
    {
        public Intel(string merk, string tipe) : base(merk, tipe)
        {
            merk = "Intel";
        }
    }

    class Corei3 : Intel
    {
        public Corei3(string merk, string tipe) : base(merk, tipe)
        {
            tipe = "Core i3";
        }
    }

    class Corei5 : Intel
    {
        public Corei5(string merk, string tipe) : base(merk, tipe)
        {
            tipe = "Core i5";
        }
    }

    class Corei7 : Intel
    {
        public Corei7(string merk, string tipe) : base(merk, tipe)
        {
            tipe = "Core i7";
        }
    }
    class Amd : Processor
    {
        public Amd(string merk, string tipe) : base(merk, tipe)
        {
            merk = "AMD";
        }
    }
    class Ryzen : Amd
    {
        public Ryzen(string merk, string tipe) : base(merk, tipe)
        {
            tipe = "RYZEN";
        }
    }
    class Athlon : Amd
    {
        public Athlon(string merk, string tipe) : base(merk, tipe)
        {
            tipe = "Athlon";
        }
    }
}

class Vga
{
    public string merk;
    public Vga(string merk)
    {
        this.merk = merk;
    }
}
namespace inVga
{
    class Nvidia : Vga
    {
        public Nvidia(string merk) : base(merk)
        {
            merk = "Nvidia";
        }
    }
    class AMD : Vga
    {
        public AMD(string merk) : base(merk)
        {
            merk = "AMD";
        }
    }
}