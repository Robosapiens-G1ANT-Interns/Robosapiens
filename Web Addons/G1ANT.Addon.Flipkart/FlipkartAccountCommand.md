# flipkart.account 

## Syntax

```G1ANT
flipkart.account 
```

## Description


    Select account specific options in argument: profile, supercoinzone, flipkartplus, orders, wishlist, mychats, coupons, giftcards, notifications, and logout. (Make sure that the arguments are in lowercase) 

| Argument         | Type       | Required | Default Value                                               | Description |
| ---------------- | ---------- | -------- | ----------------------------------------------------------- | ----------- |
| `option`         | [text]     | yes      |                                                             | Enter the optionn that you want to open in the account.|
| `if`             | [bool]     | no       | true                                                        | Executes the command only if a specified condition is true   |
| `timeout`        | [timespan  | no       | [♥timeoutcommand]                                           | Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed |
| `errorcall`      | [procedure]| no       |                                                             | Name of a procedure to call when the command throws an exception or when a given `timeout` expires |
| `errorjump`      | [label]    | no       |                                                             | Name of the label to jump to when the command throws an exception or when a given `timeout` expires |
| `errormessage`   | [text]     | no       |                                                             | A message that will be shown in case the command throws an exception or when a given `timeout` expires, and no `errorjump` argument is specified |
| `errorresult`    | [variable] | no       |                                                             | Name of a variable that will store the returned exception. The variable will be of [error](https://manual.g1ant.com/link/G1ANT.Language/G1ANT.Language/Structures/ErrorStructure.md) structure  |

For more information about `if`, `timeout`, `errorcall`, `errorjump`, `errormessage` and `errorresult` arguments, see [Common Arguments](https://manual.g1ant.com/link/G1ANT.Manual/appendices/common-arguments.md) page.

## Example

This simple script opens a flipkart webpage and opens the flipkartplus section in the account.

```G1ANT

flipkart.login LoginID <enter_your_loginID> Password <enter_the_password_here>
delay 5
flipkart.account flipkartplus
```
