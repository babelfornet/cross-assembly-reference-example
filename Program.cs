// See https://aka.ms/new-console-template for more information
using System;
using MathNet.Numerics;
using MathNet.Numerics.Statistics;

double[] values = { 1, 2, 3, 4, 5 };

// Calculate mean
double mean = values.Mean();
Console.WriteLine($"Mean: {mean}");

// Calculate variance
double variance = values.Variance();
Console.WriteLine($"Variance: {variance}");

// Calculate standard deviation
double standardDeviation = values.StandardDeviation();
Console.WriteLine($"Standard Deviation: {standardDeviation}");

// Calculate correlation coefficient
double[] x = { 1, 2, 3, 4, 5 };
double[] y = { 2, 4, 6, 8, 10 };
double correlationCoefficient = Correlation.Pearson(x, y);
Console.WriteLine($"Correlation Coefficient: {correlationCoefficient}");

// Spearman coefficient
double spearman = Correlation.Spearman(x, y);
Console.WriteLine($"Spearman: {spearman}");

// Perform linear regression
(double, double) tuple = Fit.Line(x, y);
double slope = tuple.Item1;
double yIntercept = tuple.Item2;
Console.WriteLine($"Linear Regression: Slope={slope}, Y-Intercept={yIntercept}");

// Calculate coefficient of determination
double coefficientOfDetermination = GoodnessOfFit.RSquared(x, y);
Console.WriteLine($"Coefficient of Determination: {coefficientOfDetermination}");
