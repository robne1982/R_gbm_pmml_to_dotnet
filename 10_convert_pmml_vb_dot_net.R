library(XML)

# VB.NET Parameters
vbTableName <- 'dt'
vbIterator <- 'i'
vbScoreName <- 'score'

file.remove("vb_dot_net_model.txt")

fileConn <- file("vb_dot_net_model.txt", 'a')



smpModelXML <- xmlToList(xmlParse('mdl_simple.pmml'))



# Pull out the areas of interest
miningModelSchema <- smpModelXML[["MiningModel"]][["MiningSchema"]]
miningModelTarget <- smpModelXML[["MiningModel"]][["Targets"]]
miningModelSegmentation <- smpModelXML[["MiningModel"]][["Segmentation"]]

rescaleConstant <- miningModelTarget$Target[2]

# miningModelSegmentation list contains 1 element per 'tree' of the GBM
# In this case, each 'tree' has 5 elements, of which the bit we need is the 
# three nodes. Note that in future we will have >3 nodes, as we increase 
# interaction depth

# length(miningModelSegmentation)

# Print start of loop
writeLines("Public Function fnScoreModel(ByRef dt As DataTable)",fileConn)

writeLines((paste0("For Each row As DataRow In ", vbTableName,".Rows")),fileConn)

writeLines((paste0("Dim score as double =  ", rescaleConstant)),fileConn)

# For now, loop over tree
for (i in 1:(length(miningModelSegmentation) -1 )) {
  
  # In this case, we have 1 node containing 3 nodes
  # We'll likely need to generalise this for future
  it_miningModelSegmentation <- miningModelSegmentation[i]
  
  
  # It looks like the first element is meaningless (or at least, I don't know what it means)
  # and the useful data is from the 2nd to the 2nd last position
  print(length(it_miningModelSegmentation$Segment$TreeModel$Node)-1)
  for (j in 2:(length(it_miningModelSegmentation$Segment$TreeModel$Node)-1)) {
   
    # Here we have each individual statement
    nodeSet <-  miningModelSegmentation[i]$Segment$TreeModel$Node[[j]]
    
    operator = ""
    if(nodeSet$SimplePredicate[2] == "greaterOrEqual") operator <- ">="
    if(nodeSet$SimplePredicate[2] == "lessThan") operator <- "<"
    if(nodeSet$SimplePredicate[2] == "isMissing") operator <- "is Nothing"
    
    
    if(nodeSet$SimplePredicate[2] == "isMissing") writeLines((paste0('IF ', "row.item" , '(\"', nodeSet$SimplePredicate[1],'\")', ' ', operator,  ' THEN ')),fileConn, sep = "\n")
    if(nodeSet$SimplePredicate[2] != "isMissing") writeLines((paste0('IF ', "row.item" , '(\"', nodeSet$SimplePredicate[1],'\")', ' ', operator, nodeSet$SimplePredicate[3], ' THEN ')),fileConn, , sep = "\n")
    
    writeLines((paste0(vbScoreName , ' = ', vbScoreName , " + ", nodeSet$.attrs[2])),fileConn)
    writeLines((paste0(" END IF")),fileConn)
    
    
    
    
  }
  
  
  
}



#writeLines("Console.WriteLine(\" score = \" & cstr(score)) ", fileConn)
writeLines("Console.WriteLine(\" score delta  = \"  & CStr(score - row.Item(\"mdl_pred\")))", fileConn)

writeLines("Next row",fileConn)
writeLines("End Function",fileConn)
close(fileConn)


