# messengerlite.sendmessage

## Syntax

```G1ANT
messengerlite.sendmessage
```

## Description

This command sends a message to a specific contact in the messenger lite application.

| Argument       | Type       | Required | Default Value                                               | Description |
| -------------- | ---------- | -------- | ----------------------------------------------------------- | ----------- |
| `ConversationName`| [bool]  | Yes      |                                                             | Enter the contact name that you want to send a message to.   |
| `Message`      | [bool]     | Yes      |                                                             | Enter the context of the message (TEXT) that needs to be sent.  |
| `if`           | [bool]     | no       | true                                                        | Executes the command only if a specified condition is true   |
| `timeout`      | [timespan  | no       | [♥timeoutcommand]                                           | Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed |
| `errorcall`    | [procedure]| no       |                                                             | Name of a procedure to call when the command throws an exception or when a given `timeout` expires |
| `errorjump`    | [label]    | no       |                                                             | Name of the label to jump to when the command throws an exception or when a given `timeout` expires |
| `errormessage` | [text]     | no       |                                                             | A message that will be shown in case the command throws an exception or when a given `timeout` expires, and no `errorjump` argument is specified |
| `errorresult`  | [variable] | no       |                                                             | Name of a variable that will store the returned exception. The variable will be of [error](https://manual.g1ant.com/link/G1ANT.Language/G1ANT.Language/Structures/ErrorStructure.md) structure  |

For more information about `if`, `timeout`, `errorcall`, `errorjump`, `errormessage` and `errorresult` arguments, see [Common Arguments](https://manual.g1ant.com/link/G1ANT.Manual/appendices/common-arguments.md) page.

## Example

This simple script opens a messenger app in the connected android device and sends a message to a contact mentioned in the argument.

```G1ANT
messengerlite.open
delay 3
messengerlite.sendmessage ConversationName <enter_contact_name_here> Message <enter_message_here>
delay 4
```
