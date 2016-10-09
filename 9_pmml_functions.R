# get value to use
get_value <- function(init_value) {
  
  if(is.na(as.numeric(init_value))) {
    # not numeric
    val <- paste0("\"",init_value,"\"")
  } else {
    # numeric
    val <- init_value
  }
  
  return(val)
  
}


# get operator to use
get_operator <- function(operator)
{
  print(operator)
  op = ""
  if(operator == "greaterOrEqual") {
    op <- ">=" 
    } 
  else if(operator == "lessThan") {
    op <- "<"
    }
  else if(operator == "isMissing") {
    op <- "is Nothing"
  }
  else if(operator == "equal") {
    op <- "=" 
  }
  else {
    stop(paste0("Unknown operator type of :", operator))
  }
  
  return(op)
  
}


# complete branch is a full IF to END IF
process_complete_branch <- function(nodeset, fileConn, vbScoreName) {
  
  operator <- get_operator(nodeset$SimplePredicate[2])
  
  val <- get_value(nodeset$SimplePredicate[3])
  
  if(nodeset$SimplePredicate[2] == "isMissing") writeLines((paste0('IF ', "row.item" , '(\"', nodeset$SimplePredicate[1],'\")', ' ', operator,  ' THEN ')),fileConn, sep = "\n")
  if(nodeset$SimplePredicate[2] != "isMissing") writeLines((paste0('IF ', "row.item" , '(\"', nodeset$SimplePredicate[1],'\")', ' ', operator, val, ' THEN ')),fileConn, sep = "\n")
  
  writeLines((paste0(vbScoreName , ' = ', vbScoreName , " + ", nodeset$.attrs[2])),fileConn)
  writeLines((paste0(" END IF")),fileConn)
}


# A complex branch is one with a nested if statement
process_complex_branch_start <- function(nodeset, fileConn) {
  
  print(nodeset$SimplePredicate)
  operator <- get_operator(nodeset$SimplePredicate[2])
  
  val <- get_value(nodeset$SimplePredicate[3])

  
  if(nodeset$SimplePredicate[2] == "isMissing") writeLines((paste0('IF ', "row.item" , '(\"', nodeset$SimplePredicate[1],'\")', ' ', operator,  ' THEN ')),fileConn, sep = "\n")
  if(nodeset$SimplePredicate[2] != "isMissing") writeLines((paste0('IF ', "row.item" , '(\"', nodeset$SimplePredicate[1],'\")', ' ', operator, val, ' THEN ')),fileConn, sep = "\n")
  writeLines("'Start of a complex loop", fileConn)
}

# End a branch that has nests in it
process_complex_branch_end <- function(fileConn) {
  writeLines("'End of a complex loop", fileConn)
  writeLines((paste0(" END IF")),fileConn)
}


# Wrapper to process an arbitraty node
# Recursively walks through the nestes structure
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
        # another set, recursively call this routine
        process_nodeset(nodeset[k]$Node,fileConn,vbScoreName)
      }
      else {
        # oops, unknown scenario
        stop('Nodeset not 2 or 5 long')
      }
      
    }
    
    process_complex_branch_end(fileConn)
    
  }
}