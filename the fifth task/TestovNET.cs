using System;

public class grocerystore
{
    public static void Main(string[] args)
    {
        string product1 = "Сметана";
        string product2 = "сметана";
        string product3 = "Cыр";
        string product4 = "Сметана 15% Простоквашино";
        string productList = "Сметана, Сыр, Яйца";

        // 1. Операторы == и !=  - Сравнение строк (регистрозависимое)
        Console.WriteLine($"'{product1}' == '{product2}': {product1 == product2}"); // false
        Console.WriteLine($"'{product1}' != '{product3}': {product1 != product3}"); // true


        // 2. Equals() - Сравнение продуктов (с учетом регистра и без)
        Console.WriteLine($"'{product1}'.Equals('{product2}'): {product1.Equals(product2)}"); // false
        Console.WriteLine($"'{product1}'.Equals('{product2}', StringComparison.OrdinalIgnoreCase): {product1.Equals(product2, StringComparison.OrdinalIgnoreCase)}"); // true


        // 3. Compare() - Сравнение продуктов (с учетом регистра и без)
        Console.WriteLine($"String.Compare('{product1}', '{product3}'): {String.Compare(product1, product3)}"); // отрицательное число (produkt1 < produkt3)
        Console.WriteLine($"String.Compare('{product1}', '{product2}', StringComparison.OrdinalIgnoreCase): {String.Compare(product1, product2, StringComparison.OrdinalIgnoreCase)}"); // 0 (равны, регистр игнорируется)


        // 4. CompareOrdinal() - Сравнение продуктов (регистрозависимое, быстрое)
        Console.WriteLine($"String.CompareOrdinal('{product1}', '{product2}'): {String.CompareOrdinal(product1, product2)}"); // не 0 (разные)


        // 5. IndexOf() - Поиск товара в списке продуктов
        Console.WriteLine($"'{productList}'.IndexOf('{product1}'): {productList.IndexOf(product1)}"); // 0 (первый продукт в списке)


        // 6. Contains() - Проверка наличия товара в списке продуктов
        Console.WriteLine($"'{productList}'.Contains('{product3}'): {productList.Contains(product3)}"); // true


        // 7. Contains() - Проверка частичного совпадения названия товара
        Console.WriteLine($"'{product4}'.Contains('{product1}'): {product4.Contains(product1)}"); // true

        Console.ReadKey();
    }
}