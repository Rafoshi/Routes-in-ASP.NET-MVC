using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace AppRoute66.Models
{
    public class Noticia
    {
        public int NoticiaID { get; set; }
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public string Conteudo { get; set; }
        public DateTime Data { get; set; }

        public IEnumerable<Noticia> TodasNoticias()
        {
            var retorno = new Collection<Noticia>
            {
                new Noticia
                {
                    NoticiaID = 1,
                    Categoria = "Esportes",
                    Titulo = "Etec de Esportes realiza 3º Torneio Educacional, Esportivo, Cultural e Solidário",
                    Conteudo = "Teve início neste sábado, 20 de agosto, a terceira edição do Torneio Educacional, Esportivo, Cultural e Solidário organizado pela Escola Técnica Estadual (Etec) de Esportes – Curt Walter Otto Baumgart, localizada no bairro da Vila Maria, na Capital. O evento é aberto à comunidade.",
                    Data = new DateTime(2021,6,14)
                },
                new Noticia
                {
                    NoticiaID = 2,
                    Categoria = "Esportes",
                    Titulo = "F1 - Horner: 'Vitória na França desmente acusações sobre nós' ",
                    Conteudo = "Chefe da Red Bull diz que triunfo no último fim de semana mostrou que equipe cumpre as regras e desempenho forte do carro",
                    Data = new DateTime(2021,06,23)
                },
                new Noticia
                {
                    NoticiaID = 3,
                    Categoria = "Esportes",
                    Titulo = "Gabigol dificilmente será titular com Tite",
                    Conteudo = "Gabriel Barbosa, o Gabigol, seria titular em várias seleções do mundo. No Brasil, não. As dificuldades são enormes e nada têm com sua enorme capacidade goleadora",
                    Data = new DateTime(2021,06,22)
                },
                new Noticia
                {
                    NoticiaID = 4,
                    Categoria = "Escola",
                    Titulo = "Unicamp abre inscrições para oficinas de professores sobre o vestibular",
                    Conteudo = "Evento será realizado no dia 7 de agosto em formato virtual e tem o objetivo de capacitar os docentes a orientar suas turmas sobre o exame da instituição.",
                    Data = new DateTime(2021,06,21)
                },
                new Noticia
                {
                    NoticiaID = 5,
                    Categoria = "Escola",
                    Titulo = "Estados apresentam falhas nos protocolos para volta às aulas, aponta pesquisa",
                    Conteudo = "Um levantamento com dados públicos de cinco estados sobre medidas para o retorno às aulas presenciais aponta falhas nos protocolos analisados, considerando o que a ciência já apontou como seguro para impedir a transmissão de coronavírus (como o uso de máscaras e o escalonamento no transporte até a testagem).",
                    Data = new DateTime(2021,06,22)
                },
                new Noticia
                {
                    NoticiaID = 6,
                    Categoria = "Escola",
                    Titulo = "Unicamp tem maior índice de abstenção da história do vestibular indígena",
                    Conteudo = "A Unicamp informou, nesta segunda-feira (21), que o índice de abstenção do vestibular indígena 2021, realizado no domingo (20), foi de 57,6%. De acordo com a Comissão Permanente Para os Vestibulares da instituição (Comvest), 978 dos 1.697 candidatos não compareceram ao exame. O número foi o maior desde o início da aplicação da prova nesta modalidade, há três anos.",
                    Data = new DateTime(2021,06,19)
                },
            };

            return retorno;
        }
    }
}