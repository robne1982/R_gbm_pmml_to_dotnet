library(gbm)
library(devtools)
install_github(repo = "jpmml/r2pmml")
library("r2pmml")

# The purpose of this code is not to build a good model
# All I need is a GBM model I can use for testing!
# We'll use iris

tt <- read.csv('titanic.csv')
names(tt)

# Clean age
tt$Age <- ifelse(is.na(tt$Age),-1, tt$Age)

summary(tt)

formula <- Survived ~ Pclass + Sex + Age +  SibSp

mdl_interactions <- gbm(formula = formula, n.trees = 100, 
                        data = tt, distribution = 'bernoulli', interaction.depth = 3) 

summary(mdl_interactions)

# Check is predicts
summary(mdl_interactions)

# Add predictions
titanic_inc_preds_interactions <- tt
titanic_inc_preds_interactions$mdl_pred <- predict(mdl_interactions, titanic_inc_preds_interactions, n.trees = 100, type = "link")

# Write csv data to file
write.csv(x = titanic_inc_preds_interactions, file = 'titanic_inc_preds_interactions.csv',col.names = TRUE, row.names = F)

# Export model to PMML
r2pmml(mdl_interactions, "titanicmdl.pmml")
