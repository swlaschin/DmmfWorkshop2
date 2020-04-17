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

type CardType = Visa | Mastercard | ??
type CardNumber = CardNumber of string
type EmailAddress = ??
type BitcoinAddress = ??

type PaymentMethod =
    | Cash
    | Card of ??
    | PayPal of ??
    | Bitcoin of ??

type PaymentAmount = ??

type Payment = ??

