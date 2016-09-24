# R_gbm_pmml_to_dotnet

Convert R gbm models to .NET code via PMML.

## Introduction
Whilst I realize it's not something that everyone will need, I want to score gbm models in .NET, and I want to build them in R. I've tried a few other options (RServe, R.NET) but they all proved to have poor performance (in terms of runtime), so I figure that just writing the scoring code out in .NET is going to be fastest.

This project will have some R example code to generate a gbm model using the R gbm library. We'll then create a PMML version of this model and write a generic function in R to create .NET output (probably VB.NET as that's what I need, but I realise this means I'm not cool). Finally I'll test that the code works in .NET.


