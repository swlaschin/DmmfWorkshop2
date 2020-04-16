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


type Customer_After = ???


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

type Connection_After = ??


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

type Order_After = ??

