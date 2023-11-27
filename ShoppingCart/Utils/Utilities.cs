namespace ShoppingCart.Utils
{
    public static class Utilities
    {
        public static void CheckPageTitle(this string actual, string expected)
        {
            Assert.That(actual, Is.EqualTo(expected));
            Console.WriteLine("<Expected: {0} | Actual: {1}>", expected, actual);
        }
    }
}
