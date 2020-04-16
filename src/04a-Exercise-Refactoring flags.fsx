// ================================================
// DDD Exercise: Refactoring designs to use states
// ================================================

(*
Often a domain type has implicit states that you can recognize 
by the use of boolean fields, or fields which are nullable.

These fields are only used sometimes, but in other cases
are missing or not needed.

This is a sign that a CHOICE of possible states is present 
but are not being modelled properly.

We saw an example of this with the Unverified/Verified email address
*)

// before refactoring
type EmailAddress = EmailAddress of string
type EmailContact_BeforeRefactoring =
    {
    EmailAddress: EmailAddress
    IsVerified: bool
    }

// after refactoring
type VerifiedEmailAddress = VerifiedEmailAddress of EmailAddress 
type EmailContact_AfterRefactoring =
    | Unverified of EmailAddress
    | Verified of VerifiedEmailAddress

// =================================================
// Exercise A - redesign this type into two states: 
// * RegisteredCustomer (with an id) OR
// * GuestCustomer (without an id)
type Customer_BeforeRefactoring =
    {
    CustomerName: string
    IsGuest: bool
    RegistrationId: int option
    }


type Customer_AfterRefactoring = ???

// =================================================
// Exercise B - redesign this type into two states: 
// * Connected (with handle, etc)
// * OR Disconnected (with reason)
type Connection_BeforeRefactoring =
   {
   IsConnected: bool
   ConnectionStartedUtc: System.DateTime option
   ConnectionHandle: int
   ReasonForDisconnection: string
   }

type Connection_AfterRefactoring = ??

// =================================================
// Exercise C - redesign this type into two states.
// Can you guess what the states are from the flags?
// how does the refactored version help improve the documentation?
type Order_BeforeRefactoring =
   {
   OrderId: int
   IsPaid: bool
    PaidAmount: float option //only set when paid
    PaidDate: System.DateTime option //only set when paid
   }

type Order_AfterRefactoring = ??

