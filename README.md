# R_gbm_pmml_to_dotnet

Convert R gbm models to .NET code, via PMML. This isn't the prettiest or most generic code, but you may it useful if you need to do something similar.

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

## Files

### 1_build_gbm_gaussian_iris.R

Builds a simple gaussian GBM on the iris dataset. Outputs iris_inc_preds_interactions.csv with the raw data and predictions, and iris_mdl.pmml, which is the PMML representation of this model.

### 2_build_gbm_bernoulli_titanic_data.R

As above, but builds a Bernoulli gbm on titanic data (predicting survival). Outputs titanic_inc_preds_interactions.csv (data + preds) and titanicmdl.pmml.

### 9_pmml_functions.R

Functions to parse the PMML files, iterate through the trees, and write .NET

### 11_convert_gaussian_gbm_pmml_vb_dot_net.R

Code that uses 9_pmml_functions.R, plus some guassian model specific code, to produce VB.NET code

### 12_convert_gbm_bernoulli_pmml_vb_dot_net.R

As above, but for GBM. Minimal changes, other than to account for the different structure of the PMML file for Bernoulli GBM models.



