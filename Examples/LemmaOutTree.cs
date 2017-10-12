using  System;
using  LemmaSharp;
using  System.Text;
using  System.IO;

namespace  LemaOutTree
{
 class  Program 
 {
     static  void  Main(string [] args)
     {
         ILemmatizer  lmtz = new  LemmatizerPrebuiltCompact (LemmaSharp.LanguagePrebuilt .Czech);
         StreamWriter  tw = new  StreamWriter (File .OpenWrite("ExampleFile.txt" ));
         Output(((Lemmatizer )lmtz).RootNode, tw, 0, false );
     }

     private  static  void  Output(LemmaTreeNode  ltn, TextWriter  sb, int  iLevel, bool  first) {
         sb.Write(new  string ('\t' , first?1:iLevel));
         sb.Write("RULE: " );
         sb.Write("i\""  + (ltn.bWholeWord ? "#"  : "" ) + ltn.sCondition + "\" " );
         sb.Write("t\""  + ltn.sCondition.Substring(ltn.sCondition.Length-ltn.lrBestRule.iFrom) + "\"->\""  + ltn.lrBestRule.sTo + "\";" );
         sb.WriteLine();
         if  (ltn.dictSubNodes != null ) {
             sb.Write(new  string ('\t' , iLevel));
             sb.Write("{:" );
             bool  firstInner = true ;
             foreach  (LemmaTreeNode  ltnChild in  ltn.dictSubNodes.Values) {
                 Output(ltnChild, sb, iLevel + 1, firstInner);
                 firstInner = false ;
             }
             sb.Write(new  string ('\t' , iLevel));
             sb.Write(":}" );
             sb.WriteLine();
             sb.WriteLine();
         }
     }
 }
}
