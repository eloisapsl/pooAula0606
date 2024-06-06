using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection conexao;
        public Form1()
        {
            InitializeComponent();
            conexao = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=banco1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {
                conexao.Open();
                var selectCmd = conexao.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM Contato";

                SqlDataReader leitorDados = selectCmd.ExecuteReader();
                while (leitorDados.Read())
                {
                    //leitorDados["Nome"]
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
