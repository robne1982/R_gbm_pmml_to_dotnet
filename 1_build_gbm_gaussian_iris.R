library(gbm)
library(devtools)
install_github(repo = "jpmml/r2pmml")
library("r2pmml")

# The purpose of this code is not to build a good model
# All I need is a GBM model I can use for testing!
# We'll use iris

names(iris)
names(iris) <- gsub("\\.", "", names(iris))

formula <- SepalLength ~ SepalWidth + PetalLength + PetalWidth + Species

mdl_interactions <- gbm(formula = formula, n.trees = 10, 
           data = iris, distribution = 'gaussian', interaction.depth = 10) 

# Check is predicts
summary(mdl_interactions)

# Add predictions
iris_inc_preds_interactions <- iris
iris_inc_preds_interactions$mdl_pred <- predict(mdl_interactions, iris_inc_preds_interactions, n.trees = 10)

# Write csv data to file
write.csv(x = iris_inc_preds_interactions, file = 'iris_inc_preds_interactions.csv',col.names = TRUE, row.names = F)

# Export model to PMML
r2pmml(mdl_interactions, "mdl.pmml")
