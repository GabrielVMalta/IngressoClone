using IngressoMVC.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Data
{
    public class InicializadorDeDados
    {
        public static void Inicializar(IApplicationBuilder builder)
        {
            using (var serviceScope = builder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<IngressoDbContext>();

                context.Database.EnsureCreated();

                if (!context.Cinemas.Any())
                {
                    //instanciar novos cinemas
                    context.Cinemas.Add(new Cinema("Cinemark", "O sucesso da Cinemark está ligado à experiência vivida pelo público, nosso propósito é oferecer uma experiência inesquecível, afinal, nosso DNA é de inovação e tecnologia. 1984 foi o ponta pé inicial para uma revolução no cinema.Sempre acreditamos que a experiência do filme ultrapassa as telas e que entretenimento é mais que um filme, um filme é mais que uma sala, e uma sala é mais que tecnologia.", "https://cdn.freebiesupply.com/logos/large/2x/cinemark-1-logo-png-transparent.png"));
                    context.SaveChanges();
                }

                if (!context.Atores.Any())
                {
                    context.Atores.AddRange(new List<Ator>()
                    {
                        new Ator("Dwayne Johnson", "Dwayne Douglas Johnson (Hayward, 2 de maio de 1972), conhecido pelo nome artístico The Rock, é um ator, produtor e lutador américo-canadense. Johnson também foi um jogador de futebol americano universitário pela Universidade de Miami, vencendo o campeonato nacional em 1991 pelo Miami Hurricanes. Também atuou pelo Calgary Stampeders na Liga Canadense de Futebol, sendo cortado após dois meses durante a temporada de 1995. Mais tarde tornou-se lutador profissional como seu avô, Peter Maivia, e seu pai, Rocky Johnson (de quem ele também herdou sua cidadania canadense). Originalmente anunciado como 'Rocky Maivia', ele ganhou fama nacional durante sua passagem pela World Wrestling Federation (WWF/E) entre 1996 e 2004 como a principal figura da empresa durante a Attitude Era, se tornando no primeiro lutador de terceira geração a competir na companhia. Ele retornou como um lutador ocasional entre 2011 e 2013, continuando a fazer aparições esporádicas após isso. Em dezembro de 2016, ele ganhou 17 títulos na WWE, incluindo dez reinados como campeão mundial, tendo ganhado o WWF/E Championship oito vezes e o WCW World Championship em duas ocasiões. Ele também ganhou o Intercontinental Championship duas vezes e o WWF Tag Team Championship cinco vezes, sendo por isso o sexto lutador da história a completar a tríplice coroa da WWE. Na empresa, ele ainda ganhou o Royal Rumble de 2000. The Rock é considerado por críticos e fãs como um dos maiores lutadores na história da WWE, bem como o lutador que arrecadou mais bilheteria na história da luta livre. A autobiografia de Johnson chamada The Rock Says..., foi co-escrita com Joe Layden, e publicada em 2000. Ele estreou na primeira porisção da lista de best sellers do The New York Times, tendo permanecido nessa lista por várias semanas.O primeiro papel principal de Johnson em filmes foi em The Scorpion King em 2002.Para este papel, lhe foi pago $ 5,5 milhões, um recorde mundial para um ator em seu primeiro papel de protagonista. Ele já apareceu em vários filmes, incluindo The Rundown, The Game Plan, Get Smart, The Other Guys e Faster.Seu papel mais marcante foi como Luke Hobbs na franquia The Fast and the Furious. Ele também organizou e produziu a série The Hero no canal TNT.", "https://www.themoviedb.org/t/p/w300_and_h450_bestv2/kuqFzlYMc2IrsOyPznMd1FroeGq.jpg"),
                        new Ator("Vin Diesel", "Mark Sinclair Vincent, mais conhecido como Vin Diesel, (Nova Iorque, 18 de Julho de 1967) é um ator, roteirista e produtor de cinema norte-americano. Vin Diesel tem ascendência holandesa e africana (mãe norte americana de origem holandesa e pai africano). Matriculou-se na Universidade Hunter College, onde estudava Inglês. Já trabalhou como operador de telemarketing e segurança de algumas boates de Nova Iorque. Após 3 anos, o rapaz abandonou os estudos para se dedicar mais à sua carreira de ator, viajou para Los Angeles e, mesmo sendo um respeitado e experiente ator de teatro, ele não conseguiu impressionar ninguém em Hollywood e, após um ano de tentativas, volta para Nova Iorque. Sua mãe, Silvia Sinclair Halpern, deu-lhe um livro 'Filmes ao Preço de Carros Usados', de Rick Schmidt. O livro demonstrou a Vin que ele poderia controlar a sua carreira, fazendo os seus próprios filmes. Conseguiu três mil dólares, escreveu uma história baseada nas suas próprias experiências e filmou em menos de três dias, a curta-metragem Multi-Facial (1995). O filme de 20 minutos foi escrito, produzido, dirigido e estreado por Diesel e mostra a vida de um aspirante a ator que, para conseguir um papel, finge ter uma nacionalidade diferente a cada teste que comparece, mas acabava sempre dando-se mal. O filme acabou por ser exibido no Festival de Cannes e ganhou alguns fãs de peso, entre eles Steven Spielberg, que anotou o nome do ator para, quem sabe, usá - lo num futuro próximo. Feliz com o curta, voltou para Los Angeles e, através de uma campanha de telemarketing, conseguiu quase 50 mil dólares para financiar a sua primeira longa-metragem, 'Strays'(1997) e, seis meses após o fim das filmagens, ele foi aceito para o Festival de Cinema de Sundance. Chamou mais uma vez a atenção de Steven Spielberg, que, ainda impressionado com a atuação de Diesel em 'Multi-Facial', queria conhecê-lo.Foi convidado para ser um dos soldados comandados por Tom Hanks no premiado O Resgate do Soldado Ryan(1998), filme que ainda contava com Matt Damon, Edward Burns, Giovanni Ribisi e outros.Em 2000, Vin Diesel interpretou o anti - herói Riddick no filme Pitch Black. Vendo o bom trabalho de Diesel, os produtores do filme Velozes e Furiosos(2001) resolveram dar a Vin Diesel um personagem de destaque na sua nova produção.Diesel Interpretaria Dominic Toretto, o antagonista do personagem interpretado pelo ator Paul Walker.O ator interpretou essa mesma personagem em mais cinco filmes do franchise e, segundo um anúncio do estúdio Universal Pictures em Novembro de 2014, poderá voltar a interpretar essa mesma personagem em mais três filmes.Com o nome em alta, Diesel atuou na comédia de ação Filhos da Máfia(2001), ao lado de Barry Pepper, Seth Green e John Malkovich.O seu próximo trabalho realmente colocou-o na elite de Hollywood, sendo o agente secreto Xander Cage de Triplo X(2002), também estreado por Samuel L.Jackson e Asia Argento. Em 2004, Vin Diesel interpretou novamente o anti-herói Riddick no filme The Chronicles of Riddick.Em 2005 interpretou Tenente Shane Wolfe em Operação Babá.Em 2006 estrelou 'Sob suspeita'(Find Me Guilty), dirigido por Sidney Lumet, baseado em fatos reais - o julgamento da maior família de mafiosos dos EUA.", "https://www.themoviedb.org/t/p/w300_and_h450_bestv2/9uxTwqB8anAiPomB6Kqm6A73VTV.jpg"),
                        new Ator("Paul Walker", "Paul William Walker IV (Glendale, 12 de setembro de 1973 — Santa Clarita, 30 de novembro de 2013) foi um ator norte-americano. Tornou-se conhecido em 2001 após interpretar Brian O'Conner no filme The Fast and the Furious e sua sequência, 2 Fast 2 Furious. Os seus outros filmes incluem os sucessos Resgate Abaixo de Zero, Anjo de Vidro, Mergulho Radical e Perseguição - A Estrada da Morte.", "https://www.themoviedb.org/t/p/w300_and_h450_bestv2/gOnKt6xCdVSiK0aYmmmnEx7s5rX.jpg"),
                        new Ator("Michelle Rodriguez", "Mayte Michelle Rodríguez (nascida em 12 de julho de 1978), conhecida profissionalmente como Michelle Rodriguez, é uma atriz, roteirista e DJ americana. Ela conseguiu seu papel de destaque como uma boxeadora problemática no filme independente Girlfight (2000), que foi recebido com aclamação da crítica e ganhou vários prêmios, incluindo o Independent Spirit Award e Gotham Award de Melhor Estreia. No ano seguinte, ela estrelou como Letty Ortiz no filme de sucesso The Fast and the Furious (2001), reprisando seu papel nas sequências Fast & Furious (2009), Fast & Furious 6 (2013) e Furious 7 (2015). Durante sua carreira, Rodriguez interpretou mulheres duras e independentes em vários filmes de ação de sucesso, como Blue Crush, S.W.A.T., Battle: Los Angeles e Avatar. Ela também é conhecida por seus papéis como Shé na comédia de ação Machete and Machete Kills, e Rain Ocampo nos filmes de ficção científica Resident Evil e Resident Evil: Retribution. Rodriguez também se ramificou na televisão, interpretando Ana Lucia Cortez na segunda temporada da série Lost como parte do elenco principal, antes de fazer várias aparições especiais antes do final da série.Ela também fez trabalho de voz em videogames como Call of Duty e Halo, e emprestou sua voz para o filme de animação 3D Turbo e para a série de televisão IGPX. Com seus filmes arrecadando mais de $ 5 bilhões coletivamente, um artigo da Entertainment Weekly de 2013 descreveu Rodriguez como 'indiscutivelmente a atriz mais icônica no gênero de ação, bem como uma das latinas mais visíveis em Hollywood'.", "https://www.themoviedb.org/t/p/w300_and_h450_bestv2/xSvkVrLz6xas1mCeOR9i4QtmhnQ.jpg")
                    });

                    context.SaveChanges();
                }

                if (!context.Produtores.Any())
                {
                    context.Produtores.AddRange(new List<Produtor>()
                    {
                        new Produtor("Justin Lin", "Justin Lin is a Taiwanese-American film director whose films have grossed $2 billion worldwide. He is best known for his work on Better Luck Tomorrow (2002), The Fast and the Furious: Tokyo Drift (2006), Fast & Furious (2009), Fast Five (2011), Fast & Furious 6 (2013), F9 (2021), and Star Trek Beyond (2016). He is also known for his work on television shows like Community and the second season of True Detective. Lin was born in Taipei, Taiwan, and grew up in a working-class neighborhood in Cypress, California, in Orange County. He attended Cypress High School and University of California, San Diego for two years before transferring to UCLA, where he earned a B.A. in Film & Television and a MFA in Film Directing & Production from the UCLA film school.", "https://www.themoviedb.org/t/p/w300_and_h450_bestv2/w0ryazdt8iS3GBrjXfv0FIwvUGY.jpg"),
                        new Produtor("James Cameron", "James Cameron was born in Kapuskasing, Ontario, Canada, on August 16, 1954. He moved to the USA in 1971. The son of an engineer, he majored in physics at California State University but, after graduating, drove a truck to support his screen-writing ambition. He landed his first professional film job as art director, miniature-set builder, and process-projection supervisor on Roger Corman's Battle Beyond the Stars (1980) and debuted as a director with Piranha Part Two: The Spawning (1981) the following year. In 1984, he wrote and directed The Terminator (1984), a futuristic action-thriller starring Arnold Schwarzenegger, Michael Biehn, and Linda Hamilton. It was a huge success. After this came a string of successful science-fiction action films such as Aliens (1986) and Terminator 2: Judgment Day (1991). Cameron is now one of the most sought-after directors in Hollywood. He was formerly married to producer Gale Anne Hurd, who produced several of his films. He married Kathryn Bigelow in 1989.", "https://www.themoviedb.org/t/p/w300_and_h450_bestv2/9NAZnTjBQ9WcXAQEzZpKy4vdQto.jpg")
                    });

                    context.SaveChanges();
                }

                if (!context.Categorias.Any())
                {
                    context.Categorias.AddRange(new List<Categoria>()
                    {
                        new Categoria("Ação"),
                        new Categoria("Ficção"),
                        new Categoria("Aventura"),
                        new Categoria("Romance"),
                        new Categoria("Terror")
                    });

                    context.SaveChanges();
                }

                if (!context.Filmes.Any())
                {
                    context.Filmes.AddRange(new List<Filme>()
                    {
                        new Filme("Velozes & Furiosos 5: Operação Rio", "Desde que o ex-policial Brian O'Conner e Mia Torretto libertaram Dom da prisão, eles viajam pelas fronteiras para fugir das autoridades. No Rio de Janeiro, eles fazem um último trabalho antes que possam ganhar sua liberdade definitiva. Montando sua equipe de elite de pilotos de carro, Brian e Dom sabem que têm de enfrentar o empresário corrupto que quer vê-los mortos, antes que o agente federal em sua trilha os encontre.", 29, "https://www.themoviedb.org/t/p/w300_and_h450_bestv2/l1lvu5P4xfBicxuhgL0pmvkWReO.jpg", 1, 1),
                        new Filme("Avatar", "Apesar de não ter mais os movimentos da perna, o ex-fuzileiro naval Jake Sully ainda sente que pode ser um guerreiro. Sua intuição começa a se tornar realidade quando ele viaja anos-luz até a estação espacial montada no Planeta Pandora. Habitado por grandes seres azuis, os Na´vi, o local tem uma atmosfera fatal para qualquer terrestre. Por isso, oficiais criaram o programa Avatar, em que um corpo biológico, híbrido de humano e Na´vi, pode ser comandado a distância.", 29, "https://www.themoviedb.org/t/p/w300_and_h450_bestv2/jRXYjXNq0Cs2TcJjLkki24MLp7u.jpg", 1, 2)
                    });

                    context.SaveChanges();
                }

                if (!context.FilmesCategorias.Any())
                {
                    context.FilmesCategorias.AddRange(new List<FilmeCategoria>()
                    {
                        new FilmeCategoria(1, 1),
                        new FilmeCategoria(1, 3),
                        new FilmeCategoria(1, 4),
                        new FilmeCategoria(2, 1),
                        new FilmeCategoria(2, 2),
                        new FilmeCategoria(2, 4)
                    });

                    context.SaveChanges();
                }

                if (!context.AtoresFilmes.Any())
                {
                    context.AtoresFilmes.AddRange(new List<AtorFilme>()
                    {
                        new AtorFilme(1, 1),
                        new AtorFilme(2, 1),
                        new AtorFilme(3, 1),
                        new AtorFilme(4, 1),
                        new AtorFilme(4, 2)
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
