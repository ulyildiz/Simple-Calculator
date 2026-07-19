# Simple Calculator — ME 107 (Gebze Technical University)

A small Windows Forms desktop calculator, built for an ME 107 homework assignment practicing classes and methods in VB.NET.

## Assignment

> Create a class called `Calculator` with the following methods:
> - `Add(number1 As Double, number2 As Double) As Double` (returns the sum)
> - `Subtract(number1 As Double, number2 As Double) As Double` (returns the difference)
> - `Multiply(number1 As Double, number2 As Double) As Double` (returns the product)
> - `Divide(number1 As Double, number2 As Double) As Double` (returns the quotient — handle division by zero)
>
> Create a Visual Basic form with two text boxes for inputting numbers, four buttons labeled `+`, `-`, `*`, `/`, and a label to display the result. When a button is clicked, perform the corresponding operation using the `Calculator` class and display the result in the label. Create a single instance of the `Calculator` class in the form.

## What's implemented

- **`Calculator`** (`Calculator.vb`) — `Add`, `Subtract`, `Multiply`, `Divide`. `Divide` checks for a zero denominator, shows an error `MessageBox` instead of throwing, and returns `0` in that case rather than crashing.
- **`frmCalculator`** (`frmCalculator.vb`) — holds a single `Calculator` instance, wires the four operator buttons to their matching method, and writes the result into `lblResult`.
- **Live input validation** on both number text boxes (`TextChanged`): if the current text isn't numeric, the box is cleared and an error message pops up — beyond what the assignment asked for.

## Known limitation

**You can't type a negative number into either box character by character.** The `TextChanged` handler validates on every keystroke with `IsNumeric(...)`, and a lone `-` (the natural first character of, say, `-5`) isn't numeric by itself — so the moment you press `-`, the box is cleared and the error dialog pops up before you can type the rest of the number. Pasting a complete negative value (e.g. pasting `-5` in one go) works fine, since the whole string is validated at once and `-5` *is* numeric — it's specifically typing one character at a time that's affected.

## Requirements

- Windows (WinForms doesn't run cross-platform, even on modern .NET)
- .NET 8 SDK with the **.NET desktop development** workload (or Visual Studio 2022 with the same workload)

## Build & run

```bash
dotnet build
dotnet run
```

or open `Simple Calculator.sln` in Visual Studio and press **F5**.

## Usage

1. Enter a number in each text box.
2. Click `+`, `-`, `*`, or `/`.
3. The result appears in the label below.

## Project structure

```
.
├── Simple Calculator.sln / Simple Calculator.vbproj
├── Calculator.vb                # Add / Subtract / Multiply / Divide
├── frmCalculator.vb              # Form logic: button clicks, input validation
├── frmCalculator.Designer.vb      # Auto-generated UI layout
├── frmCalculator.resx              # Form resources
├── ApplicationEvents.vb              # Standard VB "My.Application" event hooks (unmodified)
└── My Project/                          # Standard VB.NET project scaffolding
```

## License

[MIT](LICENSE)
