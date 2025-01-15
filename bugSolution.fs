let xRef = ref 10
let yRef = ref 20

let add xRef yRef = !xRef + !yRef

let z = add xRef yRef
printf "%d\n" z

//Modify values using ref cells
xRef := 15
yRef := 25

printf "%d\n" (add xRef yRef)