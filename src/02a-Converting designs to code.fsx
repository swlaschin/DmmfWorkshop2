// This file shows how to convert a design
// into F# code

// start with "module rec NameOfDomain"
module rec Examples

// NOTE: the "rec" means recursive and allows types
// to be defined AFTER first use.
// If this keyword is removed, you will get type errors
// but these can be fixed by reordering the definitions
// so that definition always comes BEFORE first use.

// it's useful to have an "undefined" type
type undefined = exn

// ================================
// AND becomes a record type
// ================================

(*
data Name =
  FirstName
  AND MiddleInitial
  AND LastName

data Order =
  OrderId
  AND list of OrderLines

*)

type Name= {
    FirstName: string
    MiddleInitial: string
    LastName: string
    }

type Order = {
  OrderId : OrderId
  OrderLines : OrderLine list
}

type OrderId = undefined
type OrderLine = undefined

// ================================
// OR becomes a choice type
// ================================

(*
data PaymentMethod =
  Cash
  OR Card (with CardInfo)
  OR PayPal (with EmailAddress)
*)

type PaymentMethod =
  | Cash
  | Card of CardInfo
  | PayPal of EmailAddress

type CardInfo = undefined


// ================================
// Primitives become wrapper types
// ================================

(*
data EmailAddress= a constrained string
data ProductId = a constrained int
*)

/// constraint checking will be added later in the constructor
type EmailAddress = EmailAddress of string
type ProductId = ProductId of int


// ================================
// A Workflow becomes a function type
// ================================

(*
Workflow: "Place order"
Event data: OrderForm
Output: OrderPlaced event
*)

type PlaceOrder =
    OrderForm -> OrderPlaced

type OrderForm = undefined
type OrderPlaced = undefined

