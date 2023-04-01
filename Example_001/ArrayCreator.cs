/// <summary>
/// Это класс, отвечающий за создание массива
/// </summary>
public static class ArrayCreator
{
    /// <summary>
    /// Метод создания массива
    /// </summary>
    /// <param name="n">Количество элементов</param>
    /// <returns>строку с представлением массива</returns>
    public static int[] Create(this int n)
    {
        return new int[n];
    }


public static string ConvertToString(this int[] array)
{
    string str = $"[{String.Join(' ', array)}]";
    Console.WriteLine(str);
    return str;
}

///<summary>
///Заполняет массив
///</summary>
public static int[] Fill(this int[] array, int min = 1, int max = 5)

{
   return array = array.Select(item => Random.Shared.Next(min, max)).ToArray();
}
}