let mutable x = 10
let mutable y = 20

let add x y = x + y

let z = add x y

printf "%d\n" z

x <- 30 //This will cause a warning but won't change the value of x in the add function
y <- 40

printf "%d\n" (add x y)