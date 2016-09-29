library(gbm)
library(devtools)
install_github(repo = "jpmml/r2pmml")
library("r2pmml")

# The purpose of this code is not to build a good model
# All I need is a GBM model I can use for testing!
# We'll use iris

names(iris)

formula <- Sepal.Length ~ Sepal.Width + Petal.Length + Petal.Width + Species

mdl_simple <- gbm(formula = formula, n.trees = 2, 
                        data = iris, distribution = 'gaussian', interaction.depth = 1) 

# Check is predicts
summary(mdl_interactions)

# Add predictions
iris_inc_preds <- iris
iris_inc_preds$mdl_pred <- predict(mdl_simple, iris_inc_preds, n.trees = 1000)

# Write csv data to file
write.csv(x = iris_inc_preds, file = 'iris_inc_preds_simple.csv',col.names = TRUE, row.names = F)

# Export model to PMML
r2pmml(mdl_simple, "mdl_simple.pmml")
