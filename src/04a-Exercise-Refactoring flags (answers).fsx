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

type CustomerName = CustomerName of string
type RegistrationId  = RegistrationId of int

type Customer_AfterRefactoring =
    | Guest of CustomerName
    | RegisteredCustomer of CustomerName * RegistrationId


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

type ConnectionHandle = ConnectionHandle of int
type ConnectionStartedUtc = System.DateTime
type ReasonForDisconnection = string

type Connection_AfterRefactoring =
    | Connected of ConnectionHandle * ConnectionStartedUtc
    | Disconnected of ReasonForDisconnection


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

type OrderId = OrderId of int
type PaidAmount = float
type PaidDate = System.DateTime
type PaidOrderInfo = {
    OrderId : OrderId
    Amount : PaidAmount
    Date : PaidDate
    }

type Order_AfterRefactoring =
    | Unpaid of OrderId
    | Paid of PaidOrderInfo

