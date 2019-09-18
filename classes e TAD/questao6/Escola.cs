using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Escola
    {
        public ArrayList funcionarios;

        public Escola()
        {
            funcionarios = new ArrayList();
        }
        public void listarFuncionarios()
        {
            foreach(object funcionario in funcionarios)
            {
                if (funcionario.GetType() == typeof(Professor))
                {
                    Professor professor = (Professor)funcionario;
                    professor.mostrarDados();
                }
                if (funcionario.GetType() == typeof(Administrativo))
                {
                    Administrativo admin = (Administrativo)funcionario;
                    admin.mostrarDados();
                }
            }
            Console.ReadKey();
        }

        public void adicionarFuncionario(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
        }
    }
}
