namespace EPA_AlgoritimoELogicao.Models
{
    public class Cliente
    {
        public string Nome { get; set; };
        public string Telefonr { get; set; };
        public string Email { get; set; };
        public int Idade { get; set; };
        public string CPF { get; set; };

        public DateTime CarimboCadstro  { get; set; };
    }
}
