using System.Text;

string test = "hfadslkjhfdskjhfdskjhfdskdfhfdslkjhfdskjhfkjdshfdshrwqiuyr7432qyr324927r5wqeresfdsff";

StringBuilder sb = new StringBuilder(test);

for (int i = 0; i < 100; i++)
{
    // test += test;
    sb.Append(test);
}

//Console.WriteLine(sb.ToString());

string s1 = "hola otro mundo";

Console.WriteLine(s1.Length);
Console.WriteLine(s1.ToUpper());
Console.WriteLine(s1.ToUpper().ToLower());

foreach (char c in s1)
{
    Console.WriteLine(c);
}

Console.WriteLine("m?: " + s1.IndexOf("m"));
Console.WriteLine("x?: " + s1.IndexOf("x"));
Console.WriteLine("ho?: " + s1.IndexOf("ho"));
Console.WriteLine("ultima o: " + s1.LastIndexOf("o"));

int posicionPrimeraO = s1.IndexOf("o");
Console.WriteLine("segunda o: " + s1.IndexOf("o", posicionPrimeraO + 1));

Console.WriteLine(s1.Replace("hola", "adios"));

Console.WriteLine("100".CompareTo("2"));

string path = @"C:\Pictures\2025\Enero\CoolPic.jpg";
int pos = path.LastIndexOf("\\") + 1;
string fileName = path.Substring(pos);

Console.WriteLine(fileName);

string Contenido = """
    Las artes decorativas son las actividades relacionadas con el arte y la artesanía destinadas a producir objetos con una finalidad a la vez utilitaria y ornamental. Son por lo general obras realizadas con una elaboración industrial o artesanal pero persiguiendo una cierta finalidad estética. El concepto es sinónimo de las llamadas artes aplicadas o artes industriales, también llamadas a veces artes menores en contraposición a las artes mayores o bellas artes. En cierto sentido, las artes decorativas es un término aplicado preferentemente a las artes industriales, así como a la pintura y la escultura, cuando su objetivo no es el de generar una obra única y diferenciada, sino que buscan una finalidad decorativa y ornamental, con una producción generalmente seriada.[1]​

    Las artes decorativas incluyen procedimientos y técnicas como la cerámica, el mosaico, la ebanistería, la orfebrería, la glíptica, el esmalte, la taracea, la metalistería, el textil, la tapicería, la corioplastia o la vidriería. También a menudo engloba las artes gráficas (grabado) y la miniatura, así como algunas obras de arquitectura, pintura y escultura destinadas a la ornamentación y concebidas en serie, no como obras individuales.[2]​

    Las artes decorativas han estado presentes en mayor o menor medida en todos los períodos de la historia del arte en general, bien por solitario o bien en conjunción con otras artes, especialmente la arquitectura. En muchos casos han marcado de forma determinante algún período histórico, como el arte bizantino, el islámico o el gótico, de tal forma que no sería posible valorarlo adecuadamente sin la presencia de este tipo de realizaciones. En otros casos, especialmente el de culturas nómadas, es el único tipo de realización artística llevado a cabo por estos pueblos, como es el caso de los escitas o de los pueblos germánicos que invadieron el Imperio romano. En muchas culturas las artes decorativas han tenido un estatus similar al resto de las artes, como es el caso de la cerámica griega o la laca china. Cabe también valorar la estrecha relación entre las artes decorativas y la cultura popular, que a menudo ha tenido en este medio su principal vía de expresión.[3]​

    Concepto

    Interior de estilo modernista de la casa Vicens (Barcelona, 1883-1888), de Antoni Gaudí
    Este tipo de técnicas entra dentro del concepto de arte (del latín ars, artis, y este del griego τέχνη téchnē),[4]​ una manifestación creativa del ser humano entendida generalmente como cualquier actividad o producto realizado con una finalidad estética y comunicativa, mediante la cual se expresan ideas, emociones o, en general, una visión del mundo, a través de diversos recursos y materiales. El arte es un componente de la cultura, que refleja en su concepción los sustratos económicos y sociales, así como la transmisión de ideas y valores inherentes a cualquier cultura humana a lo largo del espacio y el tiempo.[5]​

    La clasificación del arte ha tenido una evolución paralela al concepto mismo de arte: durante la antigüedad clásica se consideraba arte todo tipo de habilidad manual y destreza, de tipo racional y sujeta a reglas, por lo que entraban en esa denominación tanto las actuales bellas artes como la artesanía y las ciencias.[6]​ En el siglo II Galeno dividió el arte en artes liberales y artes vulgares, según si tenían un origen intelectual o manual. En el Renacimiento empezó a considerarse que la arquitectura, la pintura y la escultura eran actividades que requerían no solo oficio y destreza, sino también un tipo de concepción intelectual que las hacían superiores a otros tipos de manualidades.[7]​ En 1746, Charles Batteux estableció en Las bellas artes reducidas a un único principio la concepción actual de bellas artes, donde incluyó la pintura, la escultura, la música, la poesía y la danza, mientras que mantuvo el término «artes mecánicas» para el resto de actividades artísticas, y señaló como actividades entre ambas categorías la arquitectura. Con el tiempo esta lista sufrió variaciones y, a fecha de hoy, no está del todo cerrada, pero en general sentó una base comúnmente aceptada.[8]​

    Los términos «artes decorativas», «artes aplicadas», «artes industriales» o «artes menores» surgieron por oposición a las «bellas artes» o «artes mayores», aunque a menudo la frontera no está del todo clara.[9]​ En general, dentro de las artes plásticas la función decorativa se considera secundaria: así, si la pintura tiene por sí sola una autonomía como obra de arte, en su aplicación a un objeto pierde esa singularidad para cumplir una función subordinada, la de embellecer ese objeto. Si la pintura puede representar una visión del mundo en la libertad conceptual del artista, la pintura decorativa se moverá en un círculo cerrado de temas y motivos.[10]​

    """;

// Buscar las apariciones de una incognita
Console.Write("Escriba una incognita a buscar: ");
string incognita = Console.ReadLine();
var palabras = Contenido.Split(new char[] { ',', ' ', '.', ';', '\'', '"', '?', '!', '¡', '¿', '«', '»', ':' });
int conteo = 0;
foreach(var palabra  in palabras)
{
    if (palabra.Contains(incognita.Trim(), StringComparison.CurrentCultureIgnoreCase))
    {
        conteo += 1;
    }
}
Console.WriteLine($"La palabra {incognita} aparece {conteo} veces");
//Console.WriteLine("La palabra {0} aparece {1} veces", incognita, conteo);
// ' hola ' -> 'hola'

