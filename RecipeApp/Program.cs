internal class Program
{
    private static void Main(string[] args)
    {
        // Initialize a new recipe object
        Recipe recipe = new Recipe();
        // Continuously display a menu for user interaction
        while (true)
        {
            // Display the menu options
            Console.WriteLine("|=======================================================================|");
            Console.WriteLine("|WELCOME USER TO YOUR RECIPE MANGER APP....PLEASE SELECT A NUMBER");
            Console.WriteLine("|=======================================================================|");
            Console.WriteLine("|Enter 1 To Enter Recipe Details");
            Console.WriteLine("|=======================================================================|");
            Console.WriteLine("|Enter 2 To Display Menu");
            Console.WriteLine("|=======================================================================|");
            Console.WriteLine("|Enter 3 To Scale Recipes");
            Console.WriteLine("|=======================================================================|");
            Console.WriteLine("|Enter 4 To Rest Qauntity");
            Console.WriteLine("|=======================================================================|");
            Console.WriteLine("|Enter 5 To Clear Recipes");
            Console.WriteLine("|=======================================================================|");
            Console.WriteLine("|Enter 6 To Exit");
            Console.WriteLine("|=======================================================================|");
            string ans = Console.ReadLine();
            switch (ans)
            {
                case "1":
                    //This line writes a message to the console, prompting the user to enter recipe details.
                    recipe.EnterData();
                    break;
                case "2":
                    //This line writes a message to the console, prompting the user to display the menu
                    recipe.RecipeDisplay();
                    break;
                case "3":
                    //This line writes a message to the console, prompting the user to scale the recipe
                    Console.WriteLine("Enter a scale of 0.5, 2 or 3");
                    double scale1 = Convert.ToDouble(Console.ReadLine());
                    recipe.RecipesScale(scale1);
                    break;
                case "4":
                    // This line writes a message to the console, prompting the user to enter quantities.
                    recipe.RestRecipe();
                    break;
                case "5":
                    //This line writes a message to the console, prompting the user to rest the recipe
                    recipe.ClearRecipe();
                    break;
                case "6":
                    // This line writes a message to the console, prompting the user to exit the program.
                    Environment.Exit(0);
                    break;
                    default:
                    Console.WriteLine("Wrong Vaild.Try Again");
                    break;
            }
        }
    }
}
// Define a Recipe class with the properties and methods that i will be using
class Recipe
{
    // Declare private fields for ingredients, amounts, units, and steps
    private String[] ingrediants;
    private Double[] amount;
    private String[] units;
    private String[] steps;

    public Recipe()
    {
        // Initialize the fields with empty arrays
        ingrediants = new String[0];
        amount = new Double[0];
        units = new String[0];
        steps = new String[0];
    }
    // EnterData method to enter recipe details
    public void EnterData()
    {
        // Prompt the user to enter the number of ingredients
        Console.WriteLine("|-----------------------------------------------------------------------|");
        Console.WriteLine("|Enter Number Of Ingredients");
        Console.WriteLine("|-----------------------------------------------------------------------|");
        // Read user input
        int ingNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("|=======================================================================|");

        // Initialize arrays with the specified size
        ingrediants = new String[ingNum];
        amount = new Double[ingNum];
        units = new String[ingNum];

        // Prompt the user to enter ingredient details
        for (int i = 0; i < ingNum; i++) {
            // Prompt the user to enter the ingredient name
            //this will move the ingredient from index zero to index one and increment the rest for the ingredients
            Console.WriteLine("|-----------------------------------------------------------------------|");
            Console.WriteLine($"|Enter Ingredients Details# {i + 1}: ");
            Console.WriteLine("|-----------------------------------------------------------------------|");
            Console.WriteLine("|Name: ");
            Console.WriteLine("|-----------------------------------------------------------------------|"); ;
            // Read user input
            ingrediants[i] = Console.ReadLine();
            Console.WriteLine("|=======================================================================|");

            // Prompt the user to enter the ingredient quantity
            Console.WriteLine("|-----------------------------------------------------------------------|"); ;
            Console.WriteLine("|Quantiy: ");
            Console.WriteLine("|-----------------------------------------------------------------------|");
            amount[i] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("|=======================================================================|");
            // Prompt the user to enter the ingredient units
            Console.WriteLine("|-----------------------------------------------------------------------|");
            Console.WriteLine("|Units of Measurement: ");
            Console.WriteLine("|-----------------------------------------------------------------------|");
            units[i] = Console.ReadLine();
            Console.WriteLine("|=======================================================================|");
        }
        // Prompt the user to enter the number of steps
        Console.WriteLine("|-----------------------------------------------------------------------|");
        Console.WriteLine("|Enter Number of steps: ");
        Console.WriteLine("|-----------------------------------------------------------------------|");
        int stpNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("|=======================================================================|");
        steps = new String[stpNum];

        for (int a = 0; a < stpNum; a++)
        {
            Console.WriteLine("|-----------------------------------------------------------------------|");
            Console.WriteLine($"|Steps#{a + 1}: ");
            Console.WriteLine("|-----------------------------------------------------------------------|");
            steps[a] = Console.ReadLine();
            Console.WriteLine("|=======================================================================|");
        }
    }
    // RecipeDisplay method will display the recipe details
    public void RecipeDisplay()
    {
        // Display the ingredients
        Console.WriteLine("|=======================================================================|");
        Console.WriteLine("|Ingredients:");
        Console.WriteLine("|=======================================================================|");
        // Display the ingredient name, quantity, and units
        for (int i = 0; i < ingrediants.Length; i++)
        {
            Console.WriteLine($"- {amount[i]} {units[i]} of {ingrediants[i]}");
        }
        // Display the steps
        Console.WriteLine("|=======================================================================|");
        Console.WriteLine("|Steps: ");
        Console.WriteLine("|=======================================================================|");
        for (int a = 0; a < steps.Length; a++)
        {
            Console.WriteLine($"- {steps[a]} ");
        }

    }
    // RecipesScale method will increase amount
    public void RecipesScale(double scale)
    {
        for (int i = 0; i < amount.Length; i++)
        {
            amount[i] *= scale;
        }
    }
    // RestRecipe method will rest the amount to the original amount
    public void RestRecipe()
    {
        for (int i = 0; i < amount.Length; i++)
        {
            amount[i] /= 2;
        }
    }
    // ClearRecipe will clear all the array
    public void ClearRecipe()
    {
        //decalaring the array to null
        ingrediants = new String[0];
        amount = new Double[0];
        units = new String[0];
        steps = new String[0];
    }
 
        }
   