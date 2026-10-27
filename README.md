# ClickHere ScreenShield Delay

<p align="center">
  <img src=".github/logo.png" alt="clickhere-screensheild-delay logo" width="128" />
</p>

A VB.NET console program that starts ScreenShield after a short delay.

## What it does

It counts for 15 seconds, then starts
`C:\Program Files\ScreenShield\ScreenShield.exe` without a window.
This is useful at logon, so other start-up tasks finish before the
screen lock starts.

## Tech

- Visual Basic .NET console application

## Building

Open the `.sln` file in Visual Studio and build it. Windows only.

## License

Licensed under the Apache License 2.0. See [LICENSE](LICENSE).
