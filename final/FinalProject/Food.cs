using System.Data;

abstract public class Food
{
    private String _name;
    private String _typeOfFood;
    private int _calories;
    private int _gramsProtein;
    private int _gramsFat;
    private int _gramsCarbs;


    public Food(String name, String type, int cal, int carbs, int fat, int protein)
    {
        _name = name;
        _typeOfFood = type;
        _calories = cal;
        _gramsProtein = protein;
        _gramsFat = fat;
        _gramsCarbs = carbs;
    }


    // Displays the nutrition info for the food
    public virtual String getFood()
    {
        return $"{_name}: Type: {_typeOfFood}, Calories: {_calories}, Carbs: {_gramsCarbs}, Fat: {_gramsFat}, Protein: {_gramsProtein}";
    }

    // Getters for the class 
    public String getName()
    {
        return _name;
    }

    public int getCal()
    {
        return _calories;
    }
    public int getPro()
    {
        return _gramsProtein;
    }
    public int getFat()
    {
        return _gramsFat;
    }
    public int getCarbs()
    {
        return _gramsCarbs;
    }

    // String representation for the Load function in FoodJournal.cs
    public virtual string StringRep()
    {
        return $"{_name},{_typeOfFood},{_calories},{_gramsCarbs},{_gramsFat},{_gramsProtein}";
    }
}