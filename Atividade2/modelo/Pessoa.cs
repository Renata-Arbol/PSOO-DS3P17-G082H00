public class Pessoa
{
    private string _nome;
    public string Nome
    {
        get
        {
            return _nome;
        }
        set
        {
            _nome = value;
        }
    }
    public double Peso;
    public double Altura { get; set; }

    private double CalcularIMC()
    {
        if (ValidaValoresEntrada())
        {
            return Peso / (Altura * Altura);
        }
        return 0;
    }

    public string IndiceIMC()
    {

        double indice = this.CalcularIMC();

        if (indice < 18.5)
            return "magreza";

        if (indice >= 18.5 && indice <= 24.9)
            return "normal";
        
        if (indice >= 25.0 && indice <= 29.9)
            return "normal";

        if (indice > 29.9 && indice <= 34.9)
            return "obsesidade grau II";

        if (indice > 39.9)
            return "obesidade grau III";
        return "Ocorreu um erro.";
    }
    private Boolean ValidaValoresEntrada()
    {
        if (this.Peso <= 0 || this.Altura <= 0 || this.Peso == null || this.Altura == null)
        {
            return false;
        }
        return true;
    }
}
