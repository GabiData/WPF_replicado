using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_replicado.Informacoes;

namespace WPF_replicado.Variaveis
{
    //public class MainView : INotifyPropertyChanged
    public class MainView

    {
        public MainCommand mainCommand { get; set; }



    public MainView()
        {
            mainCommand = new MainCommand();
                
        }

        
        public string Nome
        {
            get { return Nome;  }
            set { Nome = value; }
        }
   
        public string Endereco
        {
            get { return Endereco; }
            set { Endereco = value; }
        }
       
        public int Telefone
        {
            get { return Telefone; }
            set { Telefone = value; }
        }
        
    public string Email
        {
            get { return Email; }
            set { Email = value; }
        }

        public ObservableCollection<Dados>DadosList

        {
            get { return DadosList; }
            set { DadosList = value; }

        }

        public Dados


        public void Finalizar()
        {
            DadosList = new ObsevableCollection<Dados>();

            for (int i = 1; i < = Nome; i++)
            {
                DadosList.Add(new Dados { Nome = i, Endereco = Endereco, Telefone = Telefone, Email = Email, });

            }

            DadosList = DadosList;
            OnPropertyChanged("DadosList");

        }
            


       

        























    }

















}

