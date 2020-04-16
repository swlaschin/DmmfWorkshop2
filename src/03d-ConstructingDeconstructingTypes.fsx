(*
Shows how to construct and deconstruct various types
*)

// =============================
// Constructing and Destructuring records
// =============================

// definition
type Name = {
    FirstName: string
    MiddleInitial: string
    LastName: string
    }

// to create
let name = {FirstName="a"; MiddleInitial="b";LastName="c"}

// to extract
let first = name.FirstName


// =============================
// Constructing and Destructuring Single Choice Wrappers
// =============================

// definition
type EmailAddress = EmailAddress of string

// to create a wrapper, use the case as a function
let email = EmailAddress "x@example.com"

// to deconstruct a wrapper, there are a number of ways
// Approach 1: use pattern matching with one case
let value1 = 
    match email with
    | EmailAddress addrStr -> addrStr // return the inner value

// Approach 2: use pattern matching on the LEFT hand side
let (EmailAddress addrStr) = email


// Approach 3: in functions you can use the 
// pattern matching directly in the parameter
let printEmailAddress (EmailAddress addrStr) = 
    printfn "EmailAddress = %s" addrStr

// test
printEmailAddress email   


// =============================
// Constructing and Destructuring Choices
// =============================

type CardInfo = {
    CardNumber : string
    ExpiryMonth : int
    ExpiryYear : int
    }

// Use Choice types for OR
type PaymentMethod =
  | Cash
  | Card of CardInfo 
  | PayPal of EmailAddress 


// to create, use one of the cases as a function
let paymentMethod1 = Cash

let cardInfo = {
    CardNumber = "1234"
    ExpiryMonth = 1
    ExpiryYear = 2024
    }
let paymentMethod2 = Card cardInfo

let emailAddress = EmailAddress "scott@example.com"
let paymentMethod3 = PayPal emailAddress

// to destructure a choice type, use pattern matching
let printMethod paymentMethod =
  match paymentMethod with
  | Cash -> printfn "Cash"
  | Card cardInfo -> printfn "Card with %A" cardInfo
  | PayPal emailAddress -> printfn "PayPal with %A" emailAddress

paymentMethod1 |> printMethod
paymentMethod2 |> printMethod
paymentMethod3 |> printMethod


// =============================
// Constructing Function types
// =============================

// To implement a function based on a function type
// 1.  define a value in the normal way, but use the function type as the type annotation
//     let placeOrder : PlaceOrder = ...
// 2.  for the implementation, use a lambda with however many parameters are needed.

// here's example of adding two numbers


// the definition
type AddTwoNumbers = int -> int -> int  

// the implementation
let addTwoNumbers : AddTwoNumbers =  
    fun n1 n2 -> 
        n1 + n2

// the definition
type UnwrapEmailAddress = EmailAddress -> string

// the implementation
let UnwrapEmailAddress : UnwrapEmailAddress = 
    fun (EmailAddress addrStr) -> addrStr


