# F# Mutability Bug

This repository demonstrates a potential issue in F# related to mutable variables and function scope.  The example shows how using mutable variables and reusing names within nested scopes can lead to unexpected behavior, particularly when the programmer doesn't fully understand how F# manages variable scope in these situations. 

The `bug.fs` file shows the erroneous code, while `bugSolution.fs` provides a corrected version that avoids the issues. The key is to be careful with variable naming and understand the implications of mutability. 