# fbandroid.tab

## Syntax

```G1ANT
fbandroid.tab
```

## Description

This command opens the required tab in the opened adroid application.

| Argument         | Type       | Required | Default Value                                               | Description |
| ---------------- | ---------- | -------- | ----------------------------------------------------------- | ----------- |
| `Tab`            | [text]     |yes       |                                                             |Enter one of the tab names as shown below: home, profile, notifications, friends, marketplace, groups, memories, videos, saved, pages, events, jobs, nearbyfriends        |
| `if`             | [bool]     | no       | true                                                        | Executes the command only if a specified condition is true   |
| `timeout`        | [timespan  | no       | [♥timeoutcommand]| Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed |
| `errorcall`      | [procedure]| no       |                                                             | Name of a procedure to call when the command throws an exception or when a given `timeout` expires |
| `errorjump`      | [label]    | no       |                                                             | Name of the label to jump to when the command throws an exception or when a given `timeout` expires |
| `errormessage`   | [text]     | no       |                                                             | A message that will be shown in case the command throws an exception or when a given `timeout` expires, and no `errorjump` argument is specified |
| `errorresult`    | [variable] | no       |                                                             | Name of a variable that will store the returned exception. The variable will be of [error](https://manual.g1ant.com/link/G1ANT.Language/G1ANT.Language/Structures/ErrorStructure.md) structure  |

For more information about `if`, `timeout`, `errorcall`, `errorjump`, `errormessage` and `errorresult` arguments, see [Common Arguments](https://manual.g1ant.com/link/G1ANT.Manual/appendices/common-arguments.md) page.

## Example

This simple script opens a facebook application and then logs into the account with provided credentials. It will then open the gaming tab, wait for 5 seconds and then open the profile tab.

```G1ANT
fbandroid.open Email <enter_your_login ID> Password <enter_the_password_here>
fbandroid.tab gaming
delay 5
fbandroid.tab profile

```
