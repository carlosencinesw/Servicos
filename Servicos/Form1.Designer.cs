namespace Servicos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_service = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_loaded = new System.Windows.Forms.TextBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.bnt_load = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerador de Ordens de Serviço";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(78, 53);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(257, 20);
            this.txt_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enderecço:";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(78, 89);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(257, 20);
            this.txt_address.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Serviço:";
            // 
            // txt_service
            // 
            this.txt_service.Location = new System.Drawing.Point(78, 174);
            this.txt_service.Multiline = true;
            this.txt_service.Name = "txt_service";
            this.txt_service.Size = new System.Drawing.Size(257, 162);
            this.txt_service.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Serviço (Leitura)";
            // 
            // txt_loaded
            // 
            this.txt_loaded.Location = new System.Drawing.Point(375, 174);
            this.txt_loaded.Multiline = true;
            this.txt_loaded.Name = "txt_loaded";
            this.txt_loaded.Size = new System.Drawing.Size(282, 162);
            this.txt_loaded.TabIndex = 8;
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(375, 50);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(138, 23);
            this.btn_new.TabIndex = 9;
            this.btn_new.Text = "Novo";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // bnt_load
            // 
            this.bnt_load.Location = new System.Drawing.Point(375, 80);
            this.bnt_load.Name = "bnt_load";
            this.bnt_load.Size = new System.Drawing.Size(138, 23);
            this.bnt_load.TabIndex = 11;
            this.bnt_load.Text = "Carregar";
            this.bnt_load.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(519, 80);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(138, 23);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "Sair";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(519, 51);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(138, 23);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Salvar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(78, 125);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(257, 20);
            this.txt_phone.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Telefone:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 348);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.bnt_load);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.txt_loaded);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_service);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_service;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_loaded;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button bnt_load;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label6;
    }
}

