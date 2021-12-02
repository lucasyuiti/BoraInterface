using System;
using System.Collections.Generic;
using System.Text;

namespace testes.Interfaces
{
    public interface IInteracoes<T>
    {
        bool Vivo(T obj);
        string Luta(T x, T y);
        Jogador CriarJogador(int Hp,int DanoBase);
    }
}
