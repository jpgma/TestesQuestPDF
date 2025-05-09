using QuestPDF.Companion;
using QuestPDF.Infrastructure;
using TestesQuestPDF;

QuestPDF.Settings.EnableDebugging = true;
QuestPDF.Settings.License = LicenseType.Community;

//var etiqueta = new EtiquetaDanfeSimplificado()
//{
//    Chave = "52240746163062000115550010000001951137797910",
//    ProtocoloAutorizacao = "152247722804946",
//    DataAutorizacao = new DateTime(2024, 07, 02, 15, 49, 5),
//    TipoEmissaoNF = 1,
//    CategoriaNF = "Saída",
//    NumeroNF = 195,
//    SerieNF = 1,
//    DataEmissao = new DateTime(2024, 07, 02),
//    ValorTotal = 36510,

//    NomeEmitente = "INSOL TECNOLOGIA DA AUTOMACAO LTDA",
//    CnpjEmitente = "46.163.062/0001-15",
//    IEEmitente = "10.921.293-2",
//    FoneEmitente = "(62) 4101-255",
//    EnderecoEmitente = """
//    RUA MACEIO, Nº 243, SET URIAS MAGALHAES
//    74565-540 Goiania - GO
//    """,

//    NomeDestinatario = "HORTIFRUTI SANTA RITA LTDA",
//    CnpjDestinatario = "03.029.716/0001-00",
//    IEDestinatario = "283072385",
//    EnderecoDestinatario = """
//    AV GUAICURUS, Nº 3111, VILA SANTO EUGENIO
//    79063-080 Campo Grande - MS
//    """
//};

var etiqueta = new EtiquetaPesagemSevisa()
{
    NomeProduto = "NOME DO PRODUTO",
    ProduzidoPor = "SEVISA INDÚSTRIA E COMÉRCIO DE ALIMENTOS LTDA",
    CNPJ = "50.952.151/0001-18",
    InscricaoEstadual = "15.899.001-3",
    Endereco = "RUA B QD, 011 LT. 011 - JARDIM PLANALTO CEP: 68.515-000",
    CidadeEstado = "PARAUAPEBAS - PA",
    Email = "sevisaalimentos@yahoo.com",
    WhatsApp = "(94) 3352-0043",
    DataFabricacao = DateTime.Now,
    PesoLiquido = "12.123",
    NumeroAgenciaDefesa = 90
};

//var doc = 
etiqueta.GerarEtiqueta().ShowInCompanion();

//string jsonString = """
//        [
//      {
//        "Cpf": "44234263826",
//        "Position": "EXPOSITOR",
//        "Name": "Fernanda Gonçalves Coimbra da Silva",
//        "Role": "Analista de Relações Governamentais",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "34683803801",
//        "Position": "EXPOSITOR",
//        "Name": "Filipe Rubim de Castro Souza",
//        "Role": "Coordenador de Relações Governamentais",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "21654172871",
//        "Position": "EXPOSITOR",
//        "Name": "Vanessa Arduina Lima",
//        "Role": "coordenadora",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "31133859895",
//        "Position": "EXPOSITOR",
//        "Name": "Jefferson Rodrigo Cantelli",
//        "Role": "Analista de Desenvolvimento - atendimento no estande e apoia as atividades operacionais",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "34835433840",
//        "Position": "EXPOSITOR",
//        "Name": "Gabriel Takahiro Toma de Lima",
//        "Role": "CONSULTOR",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "37335482801",
//        "Position": "EXPOSITOR",
//        "Name": "Juarez Dal Pian",
//        "Role": "Produtor Audiovisual",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "25522909811",
//        "Position": "EXPOSITOR",
//        "Name": "Simone Sanches",
//        "Role": "Coordenadora de Comunicação",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "40249192888",
//        "Position": "EXPOSITOR",
//        "Name": "Cainã Godoy",
//        "Role": "Gerente de Projetos",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "07430781870",
//        "Position": "EXPOSITOR",
//        "Name": "Valter César Calis",
//        "Role": "Gerente de Marketing / Apresentador do Pitch de 10 minutos SIM Inova",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "09976716885",
//        "Position": "EXPOSITOR",
//        "Name": "Andrea Grecco",
//        "Role": "Assessor Parlamentar - SEDUC",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "39273305822",
//        "Position": "EXPOSITOR",
//        "Name": "Felipe Batista de Lima",
//        "Role": "Assessor Parlamentar II",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "42144288895",
//        "Position": "EXPOSITOR",
//        "Name": "Deigo Alqueja da Costa",
//        "Role": "Assessor",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "28923826842",
//        "Position": "EXPOSITOR",
//        "Name": "Ivan Ipolyto",
//        "Role": "CEO - prospecção",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "04892126896",
//        "Position": "EXPOSITOR",
//        "Name": "Edgard Edmilson Pereira",
//        "Role": "Gestor Comercial",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "05799834801",
//        "Position": "EXPOSITOR",
//        "Name": "Jose Marcelo de Souza",
//        "Role": "Gestão Comercial",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "10490619851",
//        "Position": "EXPOSITOR",
//        "Name": "Jonas Macaneiro",
//        "Role": "Chefe do Depto de Suporte Institucional e Logística",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "03443274692",
//        "Position": "EXPOSITOR",
//        "Name": "Marcelle Goulart",
//        "Role": "Comunicação e Marketing",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "37990714825",
//        "Position": "EXPOSITOR",
//        "Name": "Carolina Lima Bueno",
//        "Role": "Comunicação e Marketing",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "13285854847",
//        "Position": "EXPOSITOR",
//        "Name": "Aldo Bonametti",
//        "Role": "CEO",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "42650331801",
//        "Position": "EXPOSITOR",
//        "Name": "Abraão Oliveira",
//        "Role": "Comunicação e Marketing",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "36580755890",
//        "Position": "EXPOSITOR",
//        "Name": "Lallia Endill Souza Silva",
//        "Role": "Agente de vendas",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "02476040894",
//        "Position": "EXPOSITOR",
//        "Name": "Miromar Aparecido Rosa",
//        "Role": "Agente de Vendas - Relações Públicas",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "15110945837",
//        "Position": "EXPOSITOR",
//        "Name": "CLEBER POZZANI",
//        "Role": "SOCIO ADMINISTRADOR",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "07326237824",
//        "Position": "EXPOSITOR",
//        "Name": "GISELE TONCHIS",
//        "Role": "ASSISTENTE",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "40396838898",
//        "Position": "EXPOSITOR",
//        "Name": "Edilene Alves dos Santos",
//        "Role": "Painelista",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "25838096870",
//        "Position": "EXPOSITOR",
//        "Name": "ROSIMEIRE FRANCÉ VITAL",
//        "Role": "Painelista",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "00843021004",
//        "Position": "EXPOSITOR",
//        "Name": "Jonatan Gomes",
//        "Role": "Consultor de Vendas",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "07620940448",
//        "Position": "EXPOSITOR",
//        "Name": "Lucas Monteiro Liausu Cavalcanti",
//        "Role": "Diretor",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "04849676499",
//        "Position": "EXPOSITOR",
//        "Name": "Júlio César Souza de Lira",
//        "Role": "Diretor Comercial - Demonstração dos serviços prestados pela empresa.",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "09733562602",
//        "Position": "EXPOSITOR",
//        "Name": "Elton Magno Fonseca Rodrigues",
//        "Role": "Prospector Comercial",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "17418200811",
//        "Position": "EXPOSITOR",
//        "Name": "Fernando dos Santos Murai",
//        "Role": "Painelista",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "33726610871",
//        "Position": "EXPOSITOR",
//        "Name": "Tâmara Silva Camargo",
//        "Role": "Comunicação, estará no stand de balcão",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "54244951091",
//        "Position": "EXPOSITOR",
//        "Name": "Jose Mauricio Wandscheer",
//        "Role": "Representante",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "59412518153",
//        "Position": "EXPOSITOR",
//        "Name": "Marcos Augusto Lemos Dias",
//        "Role": "Representante",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "00843021004",
//        "Position": "EXPOSITOR",
//        "Name": "Jonatan Gomes",
//        "Role": "Representante",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "58288538053",
//        "Position": "EXPOSITOR",
//        "Name": "Antônio Luis Remedi Cordeiro",
//        "Role": "Proprietário",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "36262598898",
//        "Position": "EXPOSITOR",
//        "Name": "Maria Carolina Mischiatti Lopes",
//        "Role": "Assessora",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "22131374801",
//        "Position": "EXPOSITOR",
//        "Name": "Gustavo Teixeira de Miranda",
//        "Role": "Coordenador Regional do Escritório Descentralizado de Santos do CAU-SP. Atuação em território junto aos mais de 20 municípios de pequeno porte com atuação na minha área de abrangência (Vale do Ribeira)",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "20169212858",
//        "Position": "EXPOSITOR",
//        "Name": "Elaine Pereira da Silva",
//        "Role": "Coordenador Escritório Descentralizado de Campinas (atendimento)",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "05188765861",
//        "Position": "EXPOSITOR",
//        "Name": "Paulo Romano Reschilian",
//        "Role": "Coordenador EDSao José dos Campos",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "37657286830",
//        "Position": "EXPOSITOR",
//        "Name": "Maria Heloísa Maltarolo",
//        "Role": "Representante regional São José do Rio Preto",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "39994828851",
//        "Position": "EXPOSITOR",
//        "Name": "Leandro Crocco de Faria",
//        "Role": "Demonstração da plataforma",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "08314746967",
//        "Position": "EXPOSITOR",
//        "Name": "Luiz Fernando Cauduro Junior",
//        "Role": "Diretor",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "16500588886",
//        "Position": "EXPOSITOR",
//        "Name": "Marcelo Olimpio",
//        "Role": "Representante",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "29485348878",
//        "Position": "EXPOSITOR",
//        "Name": "Danieli André Carvalho",
//        "Role": "Analista de Cerimonial",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "06421128866",
//        "Position": "EXPOSITOR",
//        "Name": "GILBERTO DER HAROUTIOUNIN",
//        "Role": "REPRESENTANTE",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "13476240827",
//        "Position": "EXPOSITOR",
//        "Name": "Helaine Fátima de Sousa",
//        "Role": "expositor no estande",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "30230039987",
//        "Position": "EXPOSITOR",
//        "Name": "Maury Massani Tanji",
//        "Role": "Conselheiro",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "30019881851",
//        "Position": "EXPOSITOR",
//        "Name": "José Roberto Silva",
//        "Role": "Sub Gerente",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "11797969854",
//        "Position": "EXPOSITOR",
//        "Name": "Marcelo Vicente Vangoni",
//        "Role": "Gerente geral",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "12722919877",
//        "Position": "EXPOSITOR",
//        "Name": "Marcos Caparbo",
//        "Role": "diretor administrativo",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "03266684621",
//        "Position": "EXPOSITOR",
//        "Name": "Alessandra Salloum",
//        "Role": "Conselheira",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "26466727807",
//        "Position": "EXPOSITOR",
//        "Name": "LILIAN BITNER",
//        "Role": "Trabalhar no estande",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "02466369857",
//        "Position": "EXPOSITOR",
//        "Name": "Orlando Gerola Júnior",
//        "Role": "Conselheiro do Conselho Federal de Biomedicina",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "02165369857",
//        "Position": "EXPOSITOR",
//        "Name": "Orlando Gerola Junior",
//        "Role": "Relação com prefeitos e assessores sobre o profissional Biomécico",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "67677460615",
//        "Position": "EXPOSITOR",
//        "Name": "HEBERT CHIMICATTI",
//        "Role": "Advogado , distribuição de kits",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "29387537803",
//        "Position": "EXPOSITOR",
//        "Name": "Márcia Aparecida Bernardes",
//        "Role": "Assessora do Gabinete do Secretário da Educação do Estado de São Paulo",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "26009316863",
//        "Position": "EXPOSITOR",
//        "Name": "FABIANA NASCIMENTO HIDALGO",
//        "Role": "GERENTE DO DEPTO DE REGISTROS",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "02991899883",
//        "Position": "EXPOSITOR",
//        "Name": "Oswaldo Galvão Filho",
//        "Role": "Apresentação e Aplicação de Cromoterapia ao público",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "16772762827",
//        "Position": "EXPOSITOR",
//        "Name": "Fernanda Basci Vaitkevicius",
//        "Role": "Biomédica",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "07326237824",
//        "Position": "EXPOSITOR",
//        "Name": "Gisele Tonchisc",
//        "Role": "Representante",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "06472216401",
//        "Position": "EXPOSITOR",
//        "Name": "THAIS DOMINIQUE BATISTA BESERRA",
//        "Role": "DIRETORIA",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "76734730620",
//        "Position": "EXPOSITOR",
//        "Name": "ALESSANDRO RODRIGUES DOS SANTOS",
//        "Role": "ADVOGADO - LICITAÇÕES",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "06343148825",
//        "Position": "EXPOSITOR",
//        "Name": "SHEILA GONÇALVES",
//        "Role": "Assessora  (coordenar estande da FDE)",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "48831640801",
//        "Position": "EXPOSITOR",
//        "Name": "Gabrielle Vieira da Silva",
//        "Role": "Auxiliar comercial",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "39693043855",
//        "Position": "EXPOSITOR",
//        "Name": "Vinícius Americano Paroni",
//        "Role": "Expositor estande da Fundação ITESP",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "11797969854",
//        "Position": "EXPOSITOR",
//        "Name": "Marcelo Vicente Vangoni",
//        "Role": "Gerencia Geral(trabalhar no Stand)",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "02750145848",
//        "Position": "EXPOSITOR",
//        "Name": "aparecida costa zocateli",
//        "Role": "Gerente Institucional",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "74472844834",
//        "Position": "EXPOSITOR",
//        "Name": "Dácio Campos",
//        "Role": "Presidente do Conselho Regional de Biomedicina",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "51996570625",
//        "Position": "EXPOSITOR",
//        "Name": "Lúcio Chimicatti",
//        "Role": "Assessor Especial da Presidência",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "89044401815",
//        "Position": "EXPOSITOR",
//        "Name": "Durval Rodrigues",
//        "Role": "Tesoureiro",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "34053631874",
//        "Position": "EXPOSITOR",
//        "Name": "Francisco C. G. Feitosa",
//        "Role": "Motorista",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "28268160802",
//        "Position": "EXPOSITOR",
//        "Name": "Fernando scognamiglio",
//        "Role": "Expositor",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "09440269405",
//        "Position": "EXPOSITOR",
//        "Name": "ELTON EMANOEL GOMES DA SILVA",
//        "Role": "Arquiteto e Urbanista / Design de Interiores",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "04777634485",
//        "Position": "EXPOSITOR",
//        "Name": "José Sérgio Lucena Neto",
//        "Role": "Diretor",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "59851384453",
//        "Position": "EXPOSITOR",
//        "Name": "José Sergio Filho",
//        "Role": "Diretor",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "34718821894",
//        "Position": "EXPOSITOR",
//        "Name": "Luis Daniel Pereira Costa",
//        "Role": "Soldador",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "51931446830",
//        "Position": "EXPOSITOR",
//        "Name": "Vythor Marques Martins",
//        "Role": "Projetista",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "51635003253",
//        "Position": "EXPOSITOR",
//        "Name": "Fabricio Moura Moreira",
//        "Role": "Presidente da Fundação de Desenvolvimento da Educação (FDE)",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "42144288895",
//        "Position": "EXPOSITOR",
//        "Name": "Diego Alqueja da Costa",
//        "Role": "Assessor Técnico de Gabinete",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "31182032850",
//        "Position": "EXPOSITOR",
//        "Name": "Tiago Michele Ziruolo",
//        "Role": "Diretor de Projetos Especiais",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "09976716885",
//        "Position": "EXPOSITOR",
//        "Name": "Andrea Grecco",
//        "Role": "Assessor Parlamentar",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "306 972 984 34",
//        "Position": "EXPOSITOR",
//        "Name": "Jorge Luiz Liausu Cavalcanti",
//        "Role": "Presidente",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "23521512878",
//        "Position": "EXPOSITOR",
//        "Name": "NICOLE AMSTALDEN GUARDIA SAMUELSON",
//        "Role": "Recepcionista",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "38858602870",
//        "Position": "EXPOSITOR",
//        "Name": "FABIANE ALCARDE GOIA",
//        "Role": "RECEPCIONISTA",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "16494275818",
//        "Position": "EXPOSITOR",
//        "Name": "ROSELI A OLIVEIRA SILVA",
//        "Role": "SUPERVISORA DAAF - GTC ARARAS",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "30644831880",
//        "Position": "EXPOSITOR",
//        "Name": "Alfredo José Ferreira de Melo",
//        "Role": "Expositor",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "25663154850",
//        "Position": "EXPOSITOR",
//        "Name": "Willian Ponciano",
//        "Role": "Coordenador Regional",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "36895301801",
//        "Position": "EXPOSITOR",
//        "Name": "Pedro Casare",
//        "Role": "Jornalista / Repórter",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "29893750822",
//        "Position": "EXPOSITOR",
//        "Name": "Fabio Spirito",
//        "Role": "Jornalista",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "37603699878",
//        "Position": "EXPOSITOR",
//        "Name": "Suzane Casare",
//        "Role": "Repórter Cinematográfico",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "39627569810",
//        "Position": "EXPOSITOR",
//        "Name": "Silas Silva",
//        "Role": "Repórter Cinematográfico",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "76438910872",
//        "Position": "EXPOSITOR",
//        "Name": "Gilmar Rodrigues",
//        "Role": "",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "06732518832",
//        "Position": "EXPOSITOR",
//        "Name": "Evaildo Raimundo",
//        "Role": "",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "08513327905",
//        "Position": "EXPOSITOR",
//        "Name": "Anderson Ribeiro Junior",
//        "Role": "",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "74605402853",
//        "Position": "EXPOSITOR",
//        "Name": "José Antônio Marangoni",
//        "Role": "",
//        "Address": "",
//        "Date": "30/10/2024"
//      },
//      {
//        "Cpf": "25408379809",
//        "Position": "EXPOSITOR",
//        "Name": "Rafael Leandro Iafelix",
//        "Role": "",
//        "Address": "",
//        "Date": "30/10/2024"
//      }
//    ]
//    """;

//// Deserialize the JSON into an array of Cracha objects
//Cracha[] crachas = JsonSerializer.Deserialize<Cracha[]>(jsonString);

//var doc = EtiquetaDanfeSimplificado.GerarEtiqueta(); --CrachasCredenciamento.GerarCrachas(crachas);

//doc.ShowInPreviewer();//.GeneratePdf().;
////File.WriteAllBytes($"crachas-{DateTime.Now:yyyyMMddHHmmss}.pdf", bytes);


