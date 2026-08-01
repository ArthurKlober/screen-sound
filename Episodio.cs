class Episodio
{
    public Episodio(string titulo, int duracao, int ordem)
    {
        Titulo = titulo;
        Duracao = duracao;
        Ordem = ordem;
    }
    public List<string> convidados = new List<string>();
    public int Duracao { get; }

    public int Ordem { get; }
    public string Resumo
    {
        get
        {
            string texto = $"Ep. {Ordem} - {Titulo} ({Duracao} minutos)";
            if (convidados.Count() > 0)
            {
                texto += "\nConvidados: ";
                int i = 0;
                foreach (string convidado in convidados)
                {
                    
                    if (i == (convidados.Count()-1))
                    {
                        texto += $"{convidado}."; 
                    }else
                    {
                        texto += $"{convidado}, ";
                    }
                    i++;
                }
            }
            else
            {
                texto += "\nO podcast não possui convidados.\n";
            }
            return texto;
        }

    }

    public string Titulo {  get; }


    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}