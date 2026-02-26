using ProjetoIntegradorSENAC.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.LogInf
{
    public partial class logInf : Form
    {
        int idEmpresa;
        public logInf(int idEmpresa)
        {
            InitializeComponent();
            this.idEmpresa = idEmpresa;
            CarregarLogs();
        }

        private void CarregarLogs()
        {
            string sql = $@"
        SELECT 
            l.id,
            u.nome AS Usuario,
            l.descricao AS Descricao,
            DATE_FORMAT(l.data, '%d/%m/%Y %H:%i') AS Data
        FROM logs l
        INNER JOIN usuarios u ON u.id = l.usuario_id
        WHERE l.comercio_id = {idEmpresa}
        ORDER BY l.data DESC
    ";

            DataTable dt = Banco.Pesquisar(sql);
            dgvLogs.DataSource = dt;
        }
    }
}
