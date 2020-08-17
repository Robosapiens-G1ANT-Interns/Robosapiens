# uber.book

## Syntax

```G1ANT
uber.search pickup ⟦text⟧ drop ⟦text⟧ ride ⟦text⟧ 
```

## Description

This command opens an instance of a chosen web browser and navigates to a default URL address.
| Argument | Type | Required | Default Value | Description |
| -------- | ---- | -------- | ------------- | ----------- |
| `loginid` | [text] |yes  |    |Enter loginid of your uber account |
| `password` | [text] |yes   |    |Enter password of your uber account |
| `pickup` | [text] |yes   |    |Enter Pickup location |
| `drop` | [text] |yes   |    |Enter Drop location |
| `ride` | [text] |yes   |    |Enter ride type |
| `result` | [variable] |no |  [♥result] |Name of a variable where the command's result will be stored |
| `nowait` | [bool] | no |true  | By default, waits until the webpage fully loads |
| `waitfornewwindow` | [bool]  | no | true | If set to true, the command should wait for a new window to appear after clicking the specified element |
| `timeout` | [timespan]  | no | [♥timeoutcommand] | Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed |
| `errorcall` | [procedure]| no |     | Name of a procedure to call when the command throws an exception or when a given `timeout` expires |
| `errorjump` | [lable]| no |     | Name of the label to jump to when the command throws an exception or when a given timeout expires |
| `errormessage` | [text]| no |     | A message that will be shown in case the command throws an exception or when a given timeout expires, and no errorjump argument is specified |
| `errorresult` | [variable]| no |     | Name of a variable that will store the returned exception. The variable will be of error structure |
For more information about `if`, `timeout`, `errorcall`, `errorjump`, `errormessage`and `errorresult` arguments, see `Common Arguments` page.

## Example

This simple script opens chrome, searches for uber's webpage and login into your account by credentials that have been provided by you. Then wait for 2 seconds and adds keyword you want to search.

```G1ANT
uber.open browse chrome
uber.login loginid <Enter your loginid here> 
uber.otp otp <Enter otp here> password <Enter password here>
delay 2
uber.search pickup <Enter pickup location> drop <Enter drop location> ride <Enter ride type>

```