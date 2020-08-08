# instagramandroid.sendmessage

## Syntax

```G1ANT
instagramandroid.sendmessage ContactName [text] Message [text]
```

## Description

This command send a direct message to the specified user's contacts.

| Argument         | Type       | Required | Default Value                                               | Description |
| ---------------- | ---------- | -------- | ----------------------------------------------------------- | ----------- |
| `ContactName`    | [text]     | Yes      |                                                             | Enter the Contact Name that you want to send the message to.   |
| `Message`        | [text]     | Yes      |                                                             | Enter the message that you want to send.   |
| `if`             | [bool]     | no       | true                                                        | Executes the command only if a specified condition is true   |
| `timeout`        | [timespan  | no       | [♥timeoutcommand]                                           | Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed |
| `errorcall`      | [procedure]| no       |                                                             | Name of a procedure to call when the command throws an exception or when a given `timeout` expires |
| `errorjump`      | [label]    | no       |                                                             | Name of the label to jump to when the command throws an exception or when a given `timeout` expires |
| `errormessage`   | [text]     | no       |                                                             | A message that will be shown in case the command throws an exception or when a given `timeout` expires, and no `errorjump` argument is specified |
| `errorresult`    | [variable] | no       |                                                             | Name of a variable that will store the returned exception. The variable will be of [error](https://manual.g1ant.com/link/G1ANT.Language/G1ANT.Language/Structures/ErrorStructure.md) structure  |

For more information about `if`, `timeout`, `errorcall`, `errorjump`, `errormessage` and `errorresult` arguments, see [Common Arguments](https://manual.g1ant.com/link/G1ANT.Manual/appendices/common-arguments.md) page.

## Example

This simple script opens an Instagram application instance in the connected android device and send a message to another instagram user.

```G1ANT
instagramandroid.open
delay 3
instagramandroid.sendmessage ContactName <enter_the_contact_name> Message <message_text>
delay 4

```
