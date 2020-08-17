# swiggy.search

## Syntax

```G1ANT
swiggy.search textsearch ⟦text⟧ 
```

## Description

This command opens an instance of a chosen web browser and navigates to a default URL address.
| Argument | Type | Required | Default Value | Description |
| -------- | ---- | -------- | ------------- | ----------- |
| `loginid` | [text] |yes  |    |Enter loginid of your swiggy account |
| `otp` | [text] |yes  |    |Enter OTP received on your registered phone number |
| `text` | [text] |yes   |    |Enter keyword you want to search on your swiggy account |
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

This simple script opens chrome, searches for swiggy's webpage and login into your account by credentials that have been provided by you. Then wait for 2 seconds and adds keyword you want to search.

```G1ANT
swiggy.open browse chrome
swiggy.login loginid <Enter your loginid here> 
swiggy.otp otp <Enter OTP here> 
delay 2
swiggy.search text <Enter keyword, you want to search here>
```