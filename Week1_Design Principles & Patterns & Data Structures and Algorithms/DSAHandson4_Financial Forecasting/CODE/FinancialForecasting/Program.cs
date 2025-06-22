using System;

namespace DSAHandson4_FinancialForecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double principal = 10000;      // Initial value (₹10,000)
            double rate = 0.08;            // Annual growth rate (8%)
            int years = 5;                 // Number of years to forecast

            Console.WriteLine("=== Financial Forecasting ===");

            // Recursive Forecast
            double futureRecursive = ForecastRecursive(principal, rate, years);
            Console.WriteLine($"[Recursive] Future Value after {years} years: ₹{futureRecursive:F2}");

            // Iterative Forecast
            double futureIterative = ForecastIterative(principal, rate, years);
            Console.WriteLine($"[Iterative] Future Value after {years} years: ₹{futureIterative:F2}");

            // Memoized Forecast
            double futureMemo = ForecastMemo(principal, rate, years);
            Console.WriteLine($"[Memoized Recursion] Future Value after {years} years: ₹{futureMemo:F2}");
        }

        // Recursive approach
        static double ForecastRecursive(double principal, double rate, int years)
        {
            if (years == 0)
                return principal;
            return ForecastRecursive(principal, rate, years - 1) * (1 + rate);
        }

        // Iterative approach (optimized)
        static double ForecastIterative(double principal, double rate, int years)
        {
            double value = principal;
            for (int i = 0; i < years; i++)
            {
                value *= (1 + rate);
            }
            return value;
        }

        // Memoized recursive approach
        static double ForecastMemo(double principal, double rate, int years)
        {
            double[] memo = new double[years + 1];
            for (int i = 0; i <= years; i++) memo[i] = -1;
            return Helper(principal, rate, years, memo);
        }

        static double Helper(double principal, double rate, int year, double[] memo)
        {
            if (year == 0) return principal;
            if (memo[year] != -1) return memo[year];

            memo[year] = Helper(principal, rate, year - 1, memo) * (1 + rate);
            return memo[year];
        }
    }
}
