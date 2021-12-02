using System;

namespace testes
{
    class Program
    {
        public int Hp;
        public int MaxHp = 200;
        public int Dano;
        public int MaxDano = 50;
        public bool Quebra_Codigo = false;
        static void Main(string[] args)
        {
            Console.WriteLine("Versão: 0.0.2");


        }

        public void CriarPersonagem()
        {

            Console.WriteLine("Vamos criar o seu personagem?");
            Console.WriteLine("Quanto de vida você quer ter?");
            Hp = int.Parse(Console.ReadLine());
            while (Hp > MaxHp)
            {
                int paciencia = 5;
                Console.WriteLine("A quantidade maxima de vida é 200 >:(");
                Console.WriteLine("Quanta vida você quer?");
                Hp = int.Parse(Console.ReadLine());
                paciencia--;
                Quebra_Codigo = true;
                if (paciencia == 0)
                {
                    Console.WriteLine("Já que alguem é cabeça dura eu estou deixando sua vida em 10 bom dia");
                    Hp = 10;
                }
            }
            Console.WriteLine("Agora vamos para o dano XD");
            Console.WriteLine("Quanto de dano você quer causar por acerto?");
            Dano = int.Parse(Console.ReadLine());
            while (Dano > MaxDano)
            {
                int paciencia = 5;
                bool repeticao = false;
                if (Quebra_Codigo == true)
                {
                    if (repeticao == false)
                    {
                        Console.WriteLine("Lá vamos nós de novo -_-´");
                        repeticao = true;
                    }
                }
                Console.WriteLine("Quanto de dano você quer causar por acerto?");
                Dano = int.Parse(Console.ReadLine());
                paciencia--;
                if(paciencia == 0)
                {
                    Console.WriteLine("Já que alguem é cabeça dura eu estou deixando seu dano para 5");
                    Dano = 5;
                }
            }

        }


    }
}
