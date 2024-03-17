using System.Text;
using LoremGen.Example;

const int totalWords = 500;
const int totalParagraphs = totalWords / 100;

const bool generateWords = true;
if (generateWords)
    Words();
else
    Paragraphs();

return;

void Words()
{
    var words = LoremGen.LoremGen.Words(totalWords);

    var fileWriter = File.OpenWrite("./dest-words.txt");
    foreach (var item in words)
    {
        var formattedItem = item + " ";
        var bytes = Encoding.UTF8.GetBytes(formattedItem);
        fileWriter.Write(bytes);
    }
}

void Paragraphs()
{
    var paragraphs = LoremGen.LoremGen.Paragraphs(totalParagraphs);

    var fileWriter = File.OpenWrite("./dest-paragraphs.txt");
    foreach (var item in paragraphs)
    {
        var formattedItem = item + " ";
        var bytes = Encoding.UTF8.GetBytes(formattedItem);
        fileWriter.Write(bytes);
    }
}