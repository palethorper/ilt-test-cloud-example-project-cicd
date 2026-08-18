# UiPath Test Cloud ILT activity project

This Studio project contains the worked examples and exercise scaffolds used during the instructor-led Test Cloud course. Open `project.json` in UiPath Studio and run the individual registered test cases; the project does not use a `Main.xaml` orchestration workflow.

## Activity map

| Folder | Activities |
|---|---|
| `1.Test Case` | Verification activities and assertion patterns |
| `2.Autopilot for developers` | Low-code generation and Stopwatch examples |
| `3.Test Data Management\AI Generated` | Generate and store UiBank test data |
| `3.Test Data Management\Data driven` | File-backed data-driven test example |
| `3.Test Data Management\Synthetic Data` | Synthetic-data input and requirements |
| `3.Test Data Management\Test Data Queues` | Queue schema and dispatcher workflow |
| `4.APIs` | Direct HTTP, Swagger and Integration Service API exercises |
| `Coded Test Cases` | C# test examples |
| `.templates` | Login/logout execution template and reusable test template |

## Before running

1. Use a Windows Studio profile with the project packages restored.
2. Connect Studio to the intended Automation Cloud tenant and Test Manager project.
3. Confirm UiBank access and supply your own credentials securely.
4. Configure the required Data Service entities, Test Data Queue, Object Repository targets and Integration Service connection for the exercise being run.
5. Do not publish client secrets, passwords, tokens or personal data with the project.

## Important exercise status

- `4.APIs\TC_CreateLoan_WithIntegrationService.xaml` is a scaffold, not a completed solution. Add the UiBank `QuotesNewquote` connector activity through Studio so Studio generates the full connection configuration; do not hand-edit the opaque configuration.
- `4.APIs\ApplyForLoan-ServiceConnection.xaml` is also an incomplete service-connection example.
- Several workflows are intentionally marked **In Progress** or contain commented teaching steps.
- The Excel, CSV and generated variation files under `4.APIs` contain different scenarios. Select the source specified by the exercise you are delivering.

## Security

The instructor working copy may contain literal training credentials in `Coded Test Cases\TC_Coded_Login.cs`. Do not distribute the live project folder. The prepared participant ZIP replaces those values with placeholders; trainees should supply credentials at runtime or use a secure credential asset.

## Validation

An isolated copy of the project passed `uip rpa build` on 2026-08-14. Analyzer warnings remain for deliberately incomplete exercises, unassigned workflows and teaching-oriented naming. No runtime smoke test was performed because the project requires environment-specific UI, API, Data Service and tenant connections.

The detailed project map is in `.claude\rules\project-context.md`. Trainer notes and exercise solutions are in `C:\UiPath\Training Materials\ILT-Training`.
