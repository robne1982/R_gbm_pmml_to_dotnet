# R_gbm_pmml_to_dotnet

Convert R gbm models to .NET code, via PMML.

## Introduction
Whilst I realize it's not something that everyone (anyone?!) will need, I want to score gbm models in .NET, and I want to build them in R. I've tried a few other options (RServe, R.NET) but they all proved to have poor performance, so I figure that just writing the scoring code out in .NET is going to be fastest and simplest approach.

This project will have some R example code to generate a gbm model using the R gbm library. We'll then create a PMML version of this model and write a generic function in R to create .NET output (probably VB.NET as that's what I need, but I realise this means I'm not cool). Finally I'll test that the code works in .NET.

## Scope

After getting started I realized that to be able to convert *any* GBM output to .NET via PMML was going to be hard work. I'm only going to be using GBM with the distribution set to 'bernoulli' for binary outcomes or 'gaussian' for continuous outcomes, so the conversion routines have the following limitations;

- There's a routine for 'bernoulli' R GBM's and another for 'gaussian' GBM's. They are seperate because the PMML is quite different for the two.
- The routines support any arbitrarily complex GBM, at least in terms of n.trees and interaction.depth settings
- The rotuines ignore the PMML types and make the assumption that any feature that can cast as a number is a number, and if not, it's a character. This would be easy to change but this minimal approach works for me. Just don't call your categorical variables "1", "2" etc and it will work fine!
- The code assumes you take care of NA's manually. Missings break the .NET code for now.
- For Bernoulli GBM's the .NET code value is equivalent to predicting in R with type='link'. It's easy to apply the logistic trasformation if needed.
- I'll test as far as making sure scores match for 1 example case based on gaussian GBM's (using the iris dataset) and for bernoulli GBM's using Titanic. There could be reasons why the conversion will fail for other datasets. If I find these I'll update the code, but please test your model!



