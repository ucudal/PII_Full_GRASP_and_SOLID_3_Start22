using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrint : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }

    /* 
    AllInOnePrinter fue eliminada ya que incumplia con SRP al tener la responsabilidad de imprimir la
    receta por consola y tambien por archivo asique cree las clases FilePrint y ConsolePrint junto a
    la superclase IPrint.
    */

}