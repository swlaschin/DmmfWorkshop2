// ================================================
// DDD Exercise: Refactoring designs to use states
// ================================================

(*
Much code has implicit states that you can recognize by fields called "IsSomething", or nullable date

This is a sign that states transitions are present but not being modelled properly.
*)

// Exercise A - redesign this type into two states: 
// * RegisteredCustomer (with an id) OR
// * GuestCustomer (without an id)
type Customer_Before =
    {
    CustomerName: string
    IsGuest: bool
    RegistrationId: int option
    }

type CustomerName = CustomerName of string
type RegistrationId  = RegistrationId of int

type Customer_After =
    | Guest of CustomerName
    | RegisteredCustomer of CustomerName * RegistrationId


// Exercise B - redesign this type into two states: 
// * Connected (with handle, etc)
// * OR Disconnected (with reason)
type Connection_Before =
   {
   IsConnected: bool
   ConnectionStartedUtc: System.DateTime option
   ConnectionHandle: int
   ReasonForDisconnection: string
   }

type ConnectionHandle = ConnectionHandle of int
type ConnectionStartedUtc = System.DateTime
type ReasonForDisconnection = string

type Connection_After =
    | Connected of ConnectionHandle * ConnectionStartedUtc
    | Disconnected of ReasonForDisconnection


// Exercise C - redesign this type into two states.
// Can you guess what the states are from the flags?
// how does the refactored version help improve the documentation?
type Order_Before =
   {
   OrderId: int
   IsPaid: bool
   PaidAmount: float option //only set when paid
   PaidDate: System.DateTime option //only set when paid
   }

type OrderId = OrderId of int
type PaidAmount = float
type PaidDate = System.DateTime
type PaidOrderInfo = {
    OrderId : OrderId
    Amount : PaidAmount
    Date : PaidDate 
    }

type Order_After =
    | Unpaid of OrderId
    | Paid of PaidOrderInfo 

