namespace DesafioProjetoHospedagem.Models
{
  public class Reserva
  {
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva() { }

    public Reserva(int diasReservados)
    {
      DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {

      if (Suite.Capacidade >= hospedes.Count)
      {
        Hospedes = hospedes;
      }

      else
      {
        throw new Exception($"Numero de Hospedes é maior que a capacidade de Suites");
      }

    }

    public void CadastrarSuite(Suite suite)
    {
      Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
      return Hospedes.Count();
    }

    public decimal CalcularValorDiaria()
    {

      decimal valor = 0;
      decimal desconto = 0;

      if (DiasReservados >= 10)
      {
        desconto = (DiasReservados * Suite.ValorDiaria) * 0.10M;
        valor = (DiasReservados * Suite.ValorDiaria) - desconto;
      }
      else
      {
        valor = DiasReservados * Suite.ValorDiaria;
      }
      return valor;

    }
  }
}