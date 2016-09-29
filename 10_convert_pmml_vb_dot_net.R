library(XML)

# VB.NET Parameters
vbTableName <- 'dt'
vbIterator <- 'i'
vbScoreName <- 'score'

smpModelXML <- xmlToList(xmlParse('mdl_simple.pmml'))

# Pull out the areas of interest
miningModelSchema <- smpModelXML[["MiningModel"]][["MiningSchema"]]
miningModelTarget <- smpModelXML[["MiningModel"]][["Targets"]]
miningModelSegmentation <- smpModelXML[["MiningModel"]][["Segmentation"]]


# miningModelSegmentation list contains 1 element per 'tree' of the GBM
# In this case, each 'tree' has 5 elements, of which the bit we need is the 
# three nodes. Note that in future we will have >3 nodes, as we increase 
# interaction depth

# length(miningModelSegmentation)

# Print start of loop

print(paste0("For Each row As DataRow In ", vbTableName,".Rows"))

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
    
    
    print(paste0('IF ', vbTableName , '[\"', nodeSet$SimplePredicate[1],'\"]', ' ', operator, nodeSet$SimplePredicate[3], ' THEN ', vbScoreName , ' = ', vbScoreName , " + ", nodeSet$.attrs[2]))
    
    
  }
  
  
  
}

print("Console.WriteLine(\" score = \" & cstr(score)) ")
print("Next row")



