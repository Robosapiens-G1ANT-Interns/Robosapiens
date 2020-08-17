# swiggy.open

## Syntax

```G1ANT
swiggy.open browse ⟦text⟧
```

## Description

This command opens an instance of a chosen web browser and navigates to a default URL address.
| Argument | Type | Required | Default Value | Description |
| -------- | ---- | -------- | ------------- | ----------- |
| `browse` | [text] |yes  |    |Enter the name of a web browse |
| `url`    | [text] |no   |    |URL address of a webpage to be loaded |
| `result` | [variable] |no |  [♥result] |Name of a variable where the command's result will be stored |
| `nowait` | [bool] | no |  | By default, waits until the webpage fully loads |
| `timeout` | [timespan]  | no | [♥timeoutcommand] | Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed |
| `errorcall` | [procedure]| no |     | Name of a procedure to call when the command throws an exception or when a given `timeout` expires |
| `errorjump` | [lable]| no |     | Name of the label to jump to when the command throws an exception or when a given timeout expires |
| `errormessage` | [text]| no |     | A message that will be shown in case the command throws an exception or when a given timeout expires, and no errorjump argument is specified |
| `errorresult` | [variable]| no |     | Name of a variable that will store the returned exception. The variable will be of error structure |

For more information about `if`, `timeout`, `errorcall`, `errorjump`, `errormessage`and `errorresult` arguments, see `Common Arguments` page.

## Example

This simple script opens chrome and searches for swiggy's webpage

```G1ANT
swiggy.open browse chrome
```
