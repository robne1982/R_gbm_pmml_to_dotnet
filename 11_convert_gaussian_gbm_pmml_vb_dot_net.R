library(XML)

'%!in%' <- function(x,y)!('%in%'(x,y))

source('9_pmml_functions.R')

# VB.NET Parameters
vbTableName <- 'dt'
vbIterator <- 'i'
vbScoreName <- 'score'

file.remove("vb_dot_net_model.txt")
fileConn <- file("vb_dot_net_model.txt", 'a')

smpModelXML <- xmlToList(xmlParse('mdl.pmml'))




# Pull out the areas of interest
miningModelSchema <- smpModelXML[["MiningModel"]][["MiningSchema"]]
miningModelTarget <- smpModelXML[["MiningModel"]][["Targets"]]
miningModelSegmentation <- smpModelXML[["MiningModel"]][["Segmentation"]]

rescaleConstant <- miningModelTarget$Target[2]

# miningModelSegmentation list contains 1 element per 'tree' of the GBM
# In this case, each 'tree' is a nested set of nodes, depending on the interaction depth..

#length(miningModelSegmentation)

# Print start of loop
writeLines("Public Function fnScoreModel(ByRef dt As DataTable)",fileConn)

writeLines((paste0("For Each row As DataRow In ", vbTableName,".Rows")),fileConn)

writeLines((paste0("Dim score as double =  ", rescaleConstant)),fileConn)

# For now, loop over tree
for (i in 1:(length(miningModelSegmentation) -1 )) {
  
  writeLines((paste0("Tree #", i)),fileConn)
  
  # This gets us to the root of this tree
  it_treemodel <- miningModelSegmentation[[i]]$TreeModel$Node
  
  # First element is junk, last element is junk, so loop over the rest...
  for (j in 2:(length(it_treemodel)-1)) {
    # A tree model with length 2 is just a simple if then end if statement
    # A tree model with length 5 has other nodes it and includes  leading if statement that apply to everything futher down
    # I'm not sure this is all of the potential lengths...
    
    nodeset <- it_treemodel[[j]]
    if ( length(nodeset) %!in% c(2,5)) stop("Unexpected branch size")
    
    process_nodeset(nodeset,fileConn,vbScoreName)
    
    
  }
}


#writeLines("Console.WriteLine(\" score = \" & cstr(score)) ", fileConn)
writeLines("Console.WriteLine(\" score delta  = \"  & CStr(score - row.Item(\"mdl_pred\")))", fileConn)

writeLines("Next row",fileConn)
writeLines("End Function",fileConn)
close(fileConn)


