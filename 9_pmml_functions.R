process_complete_branch <- function(nodeset, fileConn, vbScoreName) {
  operator = ""
  if(nodeset$SimplePredicate[2] == "greaterOrEqual") operator <- ">="
  if(nodeset$SimplePredicate[2] == "lessThan") operator <- "<"
  if(nodeset$SimplePredicate[2] == "isMissing") operator <- "is Nothing"
  
  
  if(nodeset$SimplePredicate[2] == "isMissing") writeLines((paste0('IF ', "row.item" , '(\"', nodeset$SimplePredicate[1],'\")', ' ', operator,  ' THEN ')),fileConn, sep = "\n")
  if(nodeset$SimplePredicate[2] != "isMissing") writeLines((paste0('IF ', "row.item" , '(\"', nodeset$SimplePredicate[1],'\")', ' ', operator, nodeset$SimplePredicate[3], ' THEN ')),fileConn, , sep = "\n")
  
  writeLines((paste0(vbScoreName , ' = ', vbScoreName , " + ", nodeset$.attrs[2])),fileConn)
  writeLines((paste0(" END IF")),fileConn)
}


process_complex_branch_start <- function(nodeset, fileConn) {
  operator = ""
  if(nodeset$SimplePredicate[2] == "greaterOrEqual") operator <- ">="
  if(nodeset$SimplePredicate[2] == "lessThan") operator <- "<"
  if(nodeset$SimplePredicate[2] == "isMissing") operator <- "is Nothing"
  
  
  if(nodeset$SimplePredicate[2] == "isMissing") writeLines((paste0('IF ', "row.item" , '(\"', nodeset$SimplePredicate[1],'\")', ' ', operator,  ' THEN ')),fileConn, sep = "\n")
  if(nodeset$SimplePredicate[2] != "isMissing") writeLines((paste0('IF ', "row.item" , '(\"', nodeset$SimplePredicate[1],'\")', ' ', operator, nodeset$SimplePredicate[3], ' THEN ')),fileConn, , sep = "\n")
  writeLines("'Start of a complex loop", fileConn)
}

process_complex_branch_end <- function(fileConn) {
  writeLines("'End of a complex loop", fileConn)
  writeLines((paste0(" END IF")),fileConn)
}

process_nodeset <- function(nodeset,fileConn,vbScoreName) {
  if ( length(nodeset) ==2 ) {
    process_complete_branch(nodeset, fileConn,vbScoreName)
  }
  
  
  if ( length(nodeset) ==5 ) {
    process_complex_branch_start(nodeset[1], fileConn)
    
    for (k in 2:4) {
      if(length(nodeset[k]$Node) == 2) {
        process_complete_branch(nodeset[k]$Node, fileConn,vbScoreName)
      }
      else if(length(nodeset[k]$Node)  == 5) {
        process_nodeset(nodeset[k]$Node,fileConn,vbScoreName)
      }
      else {
        stop('Nodeset not 2 or 5 long')
      }
      
    }
    
    process_complex_branch_end(fileConn)
    
  }
}