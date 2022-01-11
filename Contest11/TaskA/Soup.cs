using System;

public class Soup
{
    Ingredient[] ingredients;

    static int counterVegetables;
    static int counterMeat;

    public Soup(Ingredient[] ingredients)
    {
        this.ingredients = ingredients;
    }

    public bool WillEat
    {
        get
        {
            foreach (var el in ingredients)
            {
                if (el is Vegetable)
                    if ((el as Vegetable).IsAllergicTo)
                        return false;
                else
                    counterVegetables++;
                if (el is Meat && (el as Meat).IsTasty)
                    counterMeat++;
            }

            if (ingredients.Length != counterMeat + counterVegetables)
                return false;

            return true;
        }
    }
}