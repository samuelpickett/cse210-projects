using System.Formats.Tar;
using System.Security.Cryptography;

class NutritionGoal
{
    private int _calories;
    private int _protein;
    private int _fats;
    private int _carbs;
    private int _vitA;
    private int _vitB;
    private int _vitC;
    private int _pota;
    private int _fiber;
    private int _zinc;
    private int _iron;

    public NutritionGoal(int cal, int pro, int fat, int carb)
    {
        _calories = cal;
        _protein = pro;
        _fats = fat;
        _carbs = carb;
        _vitA = 0;
        _vitB = 0;
        _vitC = 0;
        _pota = 0;
        _fiber = 0;
        _zinc = 0;
        _iron = 0;
    }

    public NutritionGoal(int cal, int pro, int fat, int carb, int a, int b, int c, int pota, int fiber, int zinc, int iron)
    {
        _calories = cal;
        _protein = pro;
        _fats = fat;
        _carbs = carb;
        _vitA = a;
        _vitB = b;
        _vitC = c;
        _pota = pota;
        _fiber = fiber;
        _zinc = zinc;
        _iron = iron;
    }



}