using System;
using System.Collections.Generic;
using System.Linq;

namespace LoremGen
{
    /// <summary>
    /// This is the Lorem Ipsum generator.
    /// To get the Lorem Ipsum as a string or byte sequence use on of the following methods:
    /// </summary>
    public static class LoremGen
    {
        private const int DefaultSeed = 42357;
        private static Random _random;

        static LoremGen()
        {
            _random = new Random(DefaultSeed);
        }

        public static IEnumerable<string> Words(int number, int seed = DefaultSeed)
        {
            SetGeneratorSeed(seed);

            for (var i = 0; i < number; i++)
            {
                var idx = _random.Next(0, DataSource.WordsNumber);
                yield return DataSource.Words[idx];
            }
        }

        public static IEnumerable<string> Paragraphs(int number, int seed = DefaultSeed)
        {
            SetGeneratorSeed(seed);
            var wordsInParagraph = _random.Next(60, 160);

            for (var i = 0; i < number; i++)
            {
                var indexes = Enumerable.Range(0, wordsInParagraph)
                    .Select(_ => _random.Next(0, DataSource.WordsNumber));

                var paragraph = string.Join(" ", indexes.Select(idx => DataSource.Words[idx]));
                yield return paragraph;
            }
        }

        private static void SetGeneratorSeed(int seed)
        {
            _random = new Random(seed);
        }
    }
}