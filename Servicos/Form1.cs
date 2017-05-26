using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicos
{
    public partial class Form1 : Form
    {
        Servico service;
        public Form1()
        {
            InitializeComponent();
            service = new Servico();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            
            service.NewService(this);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            service.SaveService(txt_name, txt_address, txt_phone, txt_service);
        }        
    }
}
