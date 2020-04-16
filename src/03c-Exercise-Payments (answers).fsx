// ================================================
// DDD Exercise: Model a payment taking system
//
// ================================================

(*
The payment taking system should accept
* Cash
* Credit cards
* Paypal
* Bitcoin

For credit card payments we need a CardType and CardNumber
* CardType is one of Visa, MasterCard or AmericanExpress
* CardNumber is a constrained string

For PayPal we need an EmailAddress
* EmailAddress is a constrained string

For Bitcoin we need a BitcoinAddress 
* BitcoinAddress is a constrained string

A payment consists of a:
* payment method AND
* a non-negative payment amount

*)

type CardType = Visa | Mastercard | Amex
type CardNumber = CardNumber of string
type EmailAddress = EmailAddress of string
type BitcoinAddress = BitcoinAddress of string

type PaymentMethod =
    | Cash
    | Card of CardType * CardNumber
    | PayPal of EmailAddress
    | Bitcoin of BitcoinAddress

// will be constrained to be non-negative
type PaymentAmount = PaymentAmount of float

type Payment = {
    PaymentMethod: PaymentMethod
    PaymentAmount: PaymentAmount
    }

