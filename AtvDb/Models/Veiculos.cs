namespace AtvDb.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string veiculoname { get; set; }
        public string modelo { get; set; }
        public string placa { get; set; }
        public int Ano_de_Fabricação { get; set; }
        public int Quilometragem_Atual { get; set; }
    }
}
