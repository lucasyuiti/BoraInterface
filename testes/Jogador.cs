using System;
using System.Collections.Generic;
using System.Text;
using testes.Interfaces;

namespace testes
{
    public class Jogador : IInteracoes<Jogador>
    {
        public int Hp  { get; set; }
        public int DanoBase { get; set; }
        public Jogador(int hp, int danoBase)
        {
            Hp = hp;
            DanoBase = danoBase;
        }

        public bool Vivo(Jogador x)
        {
            if (x.Hp >= 1) return true;
            else return false;
        }

        public string Luta (Jogador x, Jogador y)
        {
            x.Hp = x.Hp - y.DanoBase;
            y.Hp = y.Hp - x.DanoBase;
            if (x.Hp == y.Hp) return "Empate!!";
            if (x.Hp > y.Hp) return "Jogador 1 venceu";
            else return "jogador 2 venceu";
        }

        public Jogador CriarJogador(int Hp, int DanoBase)
        {
            return new Jogador(Hp, DanoBase);
        }
    }

    
}
