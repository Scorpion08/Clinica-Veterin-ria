using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Clinica_Veterinaria.util;
using Clinica_Veterinaria.modelo;
using System.Windows.Forms;


namespace Clinica_Veterinaria.modelo
{
    public class PetCadastro
    {
        public int Id { get; set; }
        public string nomeDono { get; set; }
        public string telefone { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string animal { get; set; }
        public string qualAnimal { get; set; }
        public string sexodoAnimal { get; set;}
        public string nomeAnimal { get; set; }
        public string idadeAnimal { get; set; }

        public PetCadastro()
        {

        }

        public void Cadastrar()
        {
            NpgsqlConnection conexao = null;
            try
            {

                conexao = ConectaDB.getConexao();
                string sql = "INSERT INTO cadastro (nomeDono,telefone,RG,CPF,animal,qualAnimal,sexodoAnimal,nomeAnimal,idadeAnimal) VALUES" +
                    "('" + this.nomeDono + "','" + this.telefone + "','" + this.RG + "','" + this.CPF + "','" +
                    this.animal + "','"+this.qualAnimal+"','"+this.sexodoAnimal+"','" + this.nomeAnimal + "','" + this.idadeAnimal + "')";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.Add(new NpgsqlParameter("@nomeDono", this.nomeDono));
                cmd.Parameters.Add(new NpgsqlParameter("@telefone", this.telefone));
                cmd.Parameters.Add(new NpgsqlParameter("@RG", this.RG));
                cmd.Parameters.Add(new NpgsqlParameter("@CPF", this.CPF));
                cmd.Parameters.Add(new NpgsqlParameter("@animal", this.animal));
                cmd.Parameters.Add(new NpgsqlParameter("@qualAnimal", this.qualAnimal));
                cmd.Parameters.Add(new NpgsqlParameter("@sexodoAnimal", this.sexodoAnimal));
                cmd.Parameters.Add(new NpgsqlParameter("@nomeAnimal", this.nomeAnimal));
                cmd.Parameters.Add(new NpgsqlParameter("@idadeAnimal", this.idadeAnimal));
                cmd.ExecuteNonQuery();


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

        public List<PetCadastro> Visualizar()
        {
            NpgsqlConnection conexao = null;
            try
            {

                conexao = ConectaDB.getConexao();
                string sql = "SELECT * FROM cadastro";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                List<PetCadastro> listadePets = new List<PetCadastro>();
                while (dr.Read())
                {
                    PetCadastro novoPet = new PetCadastro();
                    novoPet.Id = Convert.ToInt16(dr["id"]);
                    novoPet.nomeDono = dr["nomeDono"].ToString();
                    novoPet.telefone = dr["telefone"].ToString();
                    novoPet.RG = dr["RG"].ToString();
                    novoPet.CPF = dr["CPF"].ToString();
                    novoPet.animal = dr["animal"].ToString();
                    novoPet.qualAnimal = dr["qualAnimal"].ToString();
                    novoPet.sexodoAnimal = dr["sexodoAnimal"].ToString();
                    novoPet.nomeAnimal = dr["nomeAnimal"].ToString();
                    novoPet.idadeAnimal = dr["idadeAnimal"].ToString();

                    listadePets.Add(novoPet);

                }


                return listadePets;
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

        public void Update()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                String sql = "UPDATE  public.cadastro SET nomedono = @nomedono, telefone = @telefone, RG = @RG, CPF = @CPF, animal = @animal ,qualAnimal = @qualAnimal,sexodoAnimal = @sexodoAnimal, nomeAnimal = @nomeAnimal, idadeAnimal = @idadeAnimal WHERE id = @id";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);


                cmd.Parameters.Add("@id", Id);
                cmd.Parameters.Add("@nomedono",nomeDono);
                cmd.Parameters.Add("@telefone",telefone);
                cmd.Parameters.Add("@RG",RG);
                cmd.Parameters.Add("@CPF",CPF);
                cmd.Parameters.Add("@animal", animal);
                cmd.Parameters.Add("@qualAnimal", qualAnimal);
                cmd.Parameters.Add("@sexodoAnimal", sexodoAnimal);
                cmd.Parameters.Add("@nomeAnimal", nomeAnimal);
                cmd.Parameters.Add("@idadeAnimal",idadeAnimal);
                
                cmd.ExecuteNonQuery();

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


        public void Deletar()
        {

            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                String sql = "DELETE FROM public.cadastro WHERE id = @id;";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@id", Id);
                cmd.ExecuteNonQuery();
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
    }
}
