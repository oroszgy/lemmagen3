using  System;
using  LemmaSharp;

namespace  LemaNow
{
 classProgram 
 {
     static void  Main(string [] args)
     {
         string  exampleSentence = "On the other hand, inflectional paradigms, "  +
             "or lists of inflected forms of typical words (such as sing, sang, "  +
             "sung, sings, singing, singer, singers, song, songs, songstress, "  +
             "songstresses in English) need to be analyzed according to criteria "  +
             "for uncovering the underlying lexical stem." ;

         string [] exampleWords = exampleSentence.Split(
             new  char [] {' ', ',', '.', ')', '('}, StringSplitOptions .RemoveEmptyEntries);
         
         ILemmatizer  lmtz = new  LemmatizerPrebuiltCompact (LemmaSharp.LanguagePrebuilt .English);

         Console .ForegroundColor = ConsoleColor .Green;
         Console .WriteLine("Example sentence lemmatized" );
         Console .WriteLine("        WORD ==> LEMMA" );
         foreach  (string  word in  exampleWords)
             LemmatizeOne(lmtz, word);
         
         Console .ForegroundColor = ConsoleColor .White;
     }

     private  static  void  LemmatizeOne(LemmaSharp.ILemmatizer  lmtz, string  word)
     {
         string  wordLower = word.ToLower();
         string  lemma = lmtz.Lemmatize(wordLower);
         Console .ForegroundColor = wordLower == lemma ? ConsoleColor .White : ConsoleColor .Red;
         Console .WriteLine("{0,12} ==> {1}" , word, lemma);
     }
 }
}