# webex.login

## Syntax

```G1ANT
webex.login type ⟦text⟧ url ⟦text⟧ nowait ⟦bool⟧
```

## Description


This command take us to login the account by taking credentials

| Argument        | Type | Required | Default Value | Description |
| --------        | ---- | -------- | ------------- | ----------- |
| `mail-id`       | [text] |yes           |         |Enter mail-id of your webex account |
| `password`      | [text] |yes           |         |Enter password of your webex account |
| `result`        | [variable]  |no      |[♥result] |Name of a variable where the command's result will be stored |
| `nowait`        | [bool] | no           |true     | By default, waits until the webpage fully loads |
| `waitfornewwindow` | [bool]  | no       | true | If set to true, the command should wait for a new window to appear after clicking the specified element || `timeout`       | [timespan  | no                 | [♥timeoutcommand]| Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed |
| `errorcall`     | [procedure]| no       |         | Name of a procedure to call when the command throws an exception or when a given `timeout` expires |
| `errorjump`     | [label]    | no       |         | Name of the label to jump to when the command throws an exception or when a given `timeout` expires |
| `errormessage`  | [text]     | no       |         | A message that will be shown in case the command throws an exception or when a given `timeout` expires, and no `errorjump` argument is specified |
| `errorresult`   | [variable] | no       |         | Name of a variable that will store the returned exception. The variable will be of [error](https://manual.g1ant.com/link/G1ANT.Language/G1ANT.Language/Structures/ErrorStructure.md) structure  |

For more information about `if`, `timeout`, `errorcall`, `errorjump`, `errormessage` and `errorresult` arguments, see [Common Arguments](https://manual.g1ant.com/link/G1ANT.Manual/appendices/common-arguments.md) page.

## Example

This code is used to login to the meeting;

```G1ANT
webex.open 
webex.login mail-id <Enter your mail-id here> password <Enter your password here>
```

