using Fusion.LoremGen;

const int totalWords = 5;
const int totalParagraphs = 1;

var words = LoremGen.Words(totalWords);
Console.WriteLine("Generated words: {0}", string.Join(" ", words));

var paragraph = LoremGen.Paragraphs(totalParagraphs).First();
Console.WriteLine("Generated paragraph: {0}", paragraph);
