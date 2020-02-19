using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinica_Veterinaria.modelo;
using Clinica_Veterinaria.util;
using Npgsql;



namespace Clinica_Veterinaria
{
    public partial class FormCadastro : Form
    {
      
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {

                string NomeDono = txtnomeDono.Text;
                string Telefone = mtbContato.Text;
                string RG = mtbRG.Text;
                string CPF = mtbCPF.Text;
                string Animal = cbAnimal.Text;
                string QualAnimal = txtqualAnimal.Text;
                string SexodoAnimal = cbSexoAnimal.Text;
                string NomeAnimal = txtnomeAnimal.Text;
                string IdadeAnimal = txtidadeAnimal.Text + " " + cbidadeAnimal.Text;


                txtnomeDono.Text = " ";
                mtbContato.Text = " ";
                mtbRG.Text = " ";
                mtbCPF.Text = " ";
                cbAnimal.Text = " ";
                txtqualAnimal.Text = " ";
                cbSexoAnimal.Text = null;
                lblSexo.Hide();
                txtnomeAnimal.Text = " ";
                txtidadeAnimal.Text = " ";
                cbidadeAnimal.Text = null;

                PetCadastro petCadastro = new PetCadastro();
                petCadastro.nomeDono = NomeDono;
                petCadastro.telefone = Telefone;
                petCadastro.RG = RG;
                petCadastro.CPF = CPF;
                petCadastro.animal = Animal;
                petCadastro.qualAnimal = QualAnimal;
                petCadastro.sexodoAnimal = SexodoAnimal;
                petCadastro.nomeAnimal = NomeAnimal;
                petCadastro.idadeAnimal = IdadeAnimal;

                petCadastro.Cadastrar();

                MessageBox.Show("Cadastrado com sucesso! ");

            }
            catch (Exception)
            {
                MessageBox.Show("Erro!", "Erro ao Cadastrar!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtnomeDono.Text = null;
                mtbContato.Text = null;
                mtbRG.Text = null;
                mtbCPF.Text = null;
                cbAnimal.Text = null;
                txtqualAnimal = null;
                cbSexoAnimal = null;
                lblSexo.Hide();
                txtnomeAnimal.Text = null;
                txtidadeAnimal.Text = null;
                txtnomeDono.Focus();




            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            PetCadastro petCadastro = new PetCadastro();

            dgvRegistro.DataSource = petCadastro.Visualizar();
            dgvRegistro.Show();
            dgvRegistro.Size = new System.Drawing.Size(646, 491);
            dgvRegistro.Location = new Point(12, 25);

            btnVoltar.Location = new Point(677, 61);
            btnVoltar.Show();
            lblqualAnimal.Hide();
            txtqualAnimal.Hide();
            lblSexo.Hide();
            cbSexoAnimal.Hide();


        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            dgvRegistro.Hide();

            btnVoltar.Hide();
            btnDelete.Hide();
            txtId.Hide();
            lblInsiraId.Hide();
            btnOk.Hide();

            txtnomeDono.Text = " ";
            mtbContato.Text = " ";
            mtbRG.Text = " ";
            mtbCPF.Text = " ";
            cbAnimal.Text = null;
            txtnomeAnimal.Text = " ";
            cbSexoAnimal.Text = null;
            lblSexo.Show();
            cbSexoAnimal.Show();
            txtidadeAnimal.Text = " ";
            cbidadeAnimal.Text = null;

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            PetCadastro petCadastro = new PetCadastro();



            dgvRegistro.DataSource = petCadastro.Visualizar();
            dgvRegistro.Show();
            dgvRegistro.Size = new System.Drawing.Size(646, 491);
            dgvRegistro.Location = new Point(12, 25);

            btnDelete.Location = new Point(697, 61);
            btnDelete.Show();
            btnVoltar.Location = new Point(677, 133);
            btnVoltar.Show();
            txtId.Show();
            lblInsiraId.Show();
            lblSexo.Hide();
            cbSexoAnimal.Hide();





        }

        private void dgvRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAnimal.Text == "Outros")
            {
                lblqualAnimal.Show();
                txtqualAnimal.Show();
                txtqualAnimal.Focus();
                cbAnimal.Text = txtqualAnimal.Text;
            }
            else
            {
                lblqualAnimal.Hide();
                txtqualAnimal.Hide();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            PetCadastro petCadastro = new PetCadastro();
            dgvRegistro.DataSource = petCadastro.Visualizar();
            dgvRegistro.Show();
            dgvRegistro.Size = new System.Drawing.Size(646, 491);
            dgvRegistro.Location = new Point(12, 25);
            btnVoltar.Location = new Point(677, 103);
            btnVoltar.Show();
            btnOk.Show();
            lblSexo.Hide();
            cbSexoAnimal.Hide();
            btnOk.Location = new Point(677, 61);
            txtId.Show();
            lblInsiraId.Show();



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("Deseja excluir registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (confirmar.ToString().ToUpper() == "YES")
            {
                try
                {
                    PetCadastro apagarPet = new PetCadastro();
                    apagarPet.Id = Convert.ToInt16(txtId.Text);
                    apagarPet.Deletar();
                    
                   
                    MessageBox.Show("Operação realizada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvRegistro.Hide();

                    btnVoltar.Hide();
                    btnDelete.Hide();
                    txtId.Hide();
                    lblInsiraId.Hide();

                    txtnomeDono.Text = " ";
                    mtbContato.Text = " ";
                    mtbRG.Text = " ";
                    mtbCPF.Text = " ";
                    cbAnimal.Text = null;
                    txtqualAnimal.Text = " ";
                    cbSexoAnimal.Text = null;
                    lblSexo.Hide();
                    txtnomeAnimal.Text = " ";
                    txtidadeAnimal.Text = " ";
                    cbidadeAnimal.Text = null;
                    txtId.Text = " ";
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar resgistro. " + ex.Message,
                        "Falha na operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtId.Text;
                string nomeDono = txtnomeDono.Text;
                string telefone = mtbContato.Text;
                string RG = mtbRG.Text;
                string CPF = mtbCPF.Text;
                string animal = cbAnimal.Text;
                string qualAnimal = txtqualAnimal.Text;
                string sexodoAnimal = cbSexoAnimal.Text;
                string nomeAnimal = txtnomeAnimal.Text;
                string idadeAnimal = txtidadeAnimal.Text+" "+ cbidadeAnimal.Text;
                

                PetCadastro pet = new PetCadastro();
                pet.Id = Convert.ToInt32(id);
                pet.nomeDono = nomeDono;
                pet.telefone = telefone;
                pet.RG = RG;
                pet.CPF = CPF;
                pet.animal = animal;
                pet.qualAnimal = qualAnimal;
                pet.sexodoAnimal = sexodoAnimal;
                pet.nomeAnimal = nomeAnimal;
                pet.idadeAnimal = idadeAnimal;
                

                pet.Update();

                MessageBox.Show("Operação Realizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar alterar. " + ex.Message,
                 "Falha na operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            btnUpdate.Hide();
            btnCadastro.Enabled = true;
            btnVisualizar.Enabled = true;
            btnAtualizar.Enabled = true;
            btnDeletar.Enabled = true;
                              
            txtnomeDono.Text = " ";
            mtbContato.Text = " ";
            mtbRG.Text = " ";
            mtbCPF.Text = " ";
            cbAnimal.Text = null;
            txtnomeAnimal.Text = " ";
            cbSexoAnimal.Text = null;
            lblSexo.Hide();
            txtidadeAnimal.Text = " ";
            cbidadeAnimal.Text = null;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string idadeAnimal = txtidadeAnimal.Text + " " + cbidadeAnimal.Text;

            dgvRegistro.Hide();
            btnOk.Hide();
            btnVoltar.Hide();
            btnDelete.Hide();
            btnUpdate.Show();
            txtId.Hide();
            lblInsiraId.Hide();
            btnUpdate.Show();
            btnCancelar.Show();
            btnCadastro.Enabled = false;
            btnVisualizar.Enabled = false;
            btnAtualizar.Enabled = false;
            btnDeletar.Enabled = false;
            
        

            PetCadastro petCadastro = new PetCadastro();

            NpgsqlConnection conexao = null;
            try
            {

                conexao = ConectaDB.getConexao();
                string sql = "SELECT nomeDono,telefone,RG,CPF,animal,qualAnimal,sexodoAnimal,nomeAnimal,idadeAnimal FROM cadastro WHERE id=@id ";



                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@id",txtId.Text);

                
                NpgsqlDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    string stringTemp;

                    //passo os valores para as textbox,combobox, etc 
                    txtnomeDono.Text = leitor["nomeDono"].ToString();
                    mtbContato.Text = leitor["telefone"].ToString();
                    mtbRG.Text = leitor["RG"].ToString();
                    mtbCPF.Text = leitor["CPF"].ToString();
                    cbAnimal.Text = leitor["animal"].ToString();
                    txtqualAnimal.Text = leitor["qualAnimal"].ToString();
                    cbSexoAnimal.Text = leitor["sexodoAnimal"].ToString();
                    txtnomeAnimal.Text = leitor["nomeAnimal"].ToString();
                    //armazeno o valor que vem do banco
                    stringTemp = leitor["idadeAnimal"].ToString();
                    //atribuo ele a um vetor e aplico o metodo Split
                    string[] listTemp = stringTemp.Split(' ');
                    //depois armazeno as strings quebradas separadamente
                    txtidadeAnimal.Text = listTemp[0];
                    idadeAnimal = listTemp[1];
                    cbidadeAnimal.Text = idadeAnimal;


                }

                txtnomeDono.Focus();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }

            
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnVoltar.Hide();
            btnDelete.Hide();
            txtId.Hide();
            lblInsiraId.Hide();
            btnUpdate.Hide();
            btnCancelar.Hide();
            btnCadastro.Enabled = true;
            btnVisualizar.Enabled = true;
            btnAtualizar.Enabled = true;
            btnDeletar.Enabled = true;

            txtnomeDono.Text = " ";
            mtbContato.Text = " ";
            mtbRG.Text = " ";
            mtbCPF.Text = " ";
            cbAnimal.Text = null;
            txtqualAnimal.Text = " ";
            cbSexoAnimal.Text = null; 
            txtnomeAnimal.Text = " ";
            txtidadeAnimal.Text = " ";
            cbidadeAnimal.Text = null;
            txtId.Text = " ";
        }
    }
}
