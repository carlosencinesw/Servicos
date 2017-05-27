using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Servicos
{
    class Servico
    {
        string _name;
        string _address;
        string _phone;
        string _service;

        public string Name
        {
            set
            {
                _name = value;
            }

            get
            {
                return _name;
            }
        }

        public string Address
        {
            set
            {
                _address = value;
            }
            
            get
            {
                return _address;
            }
        }

        public string Phone
        {
            set
            {
                _phone = value;
            }

            get
            {
                return _phone;
            }
        }

        public string Service
        {
            set
            {
                _service = value;
            }

            get
            {
                return _service;
            }
        }

        public void NewService(Control con)
        {
            foreach(Control c in con.Controls)
            {
                if(c is TextBox)
                {
                    ((TextBox)c).Clear();
                } else
                {
                    NewService(c);
                }
            }
        }

        public void SaveService(TextBox name, TextBox address, TextBox phone, TextBox service)
        {
            Name = name.Text;
            Address = address.Text;
            Phone = phone.Text;
            Service = service.Text;
            // Gera um novo arquivo baseado no nome do cliuente.
            TextWriter file = new StreamWriter("Serviço - " + address.Text + " - " + name.Text + ".txt");

            // Escreve os dados no arquivo.
            file.WriteLine("Cliente: " + Name);
            file.WriteLine("Endereço: " + Address);
            file.WriteLine("Telefone: " + Phone);
            file.WriteLine("Serviço: " + Service);

            // Fecha o arquivo.
            file.Close();
        }
    }
}
