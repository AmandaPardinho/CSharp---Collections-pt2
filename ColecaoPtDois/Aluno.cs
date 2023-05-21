using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColecaoPtDois
{
    public class Aluno
    {
        private string _nome;
        public string Nome 
        { 
            get { return _nome; } 
        }

        private int _numeroMatricula;

        public int NumeroMatricula
        {
            get { return _numeroMatricula; }
        }

        public Aluno(string nome, int numeroMatricula)
        {
            this._nome = nome;
            this._numeroMatricula = numeroMatricula;
        }

        public override string ToString()
        {
            return $"[Aluno: {this._nome}; Matrícula: {this._numeroMatricula}]";
        }

    }
}
