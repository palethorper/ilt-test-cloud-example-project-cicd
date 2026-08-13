<!-- discovery-metadata: cs=2 xaml=10 deps=6 -->
# Application Testing ILT — Project Context

> Auto-generated from the current project. Refresh after significant project changes.

## Overview

- Project type: Tests
- Target: Windows
- Expression language: Visual Basic
- Namespace: `ApplicationTestingILT`
- Project folder: `C:\UiPath\ABN-ILT`
- Configured `Main.xaml` is not present; tests are registered individually in `project.json`.

## Dependencies

- UiPath.DataService.Activities 25.9.10
- UiPath.Excel.Activities 3.6.0-preview
- UiPath.IntegrationService.Activities 1.30.0
- UiPath.System.Activities 26.6.3
- UiPath.Testing.Activities 25.10.2
- UiPath.UIAutomation.Activities 26.10.2

## Structure and conventions

- Training topics are grouped in numbered folders.
- Low-code test cases use sequence-based Windows XAML and Visual Basic expressions.
- Registered test cases are listed under `designOptions.fileInfoCollection` in `project.json`.
- File-backed test data is stored under `.variations` and registered in `.variations\config.json`.
- Existing assertions use UiPath Testing activities; loan tests commonly log input values and capture evidence.
- Preserve the existing Object Repository under `.objects` and generated code under `.local`.

## API exercise context

- Source data: `4.APIs\APITestData.xlsx`, worksheet `Sheet1`.
- Columns: `Amount`, `Term`, `Income`, `Age`, `Email`, `Accepted`.
- UiBank operation: create a new quote using Integration Service object `QuotesNewquote`.
- Request fields: amount, term, income, age, email.
- Generated response type exposes nullable `accepted` and `rate`, plus `quoteid`.
- Generated response bundles currently cached: `C7A936B4AB9_QuotesNewquote_Create` and `CCCADC469F5_QuotesNewquote_Create`.
- The connection identifier and dynamic Insert Record activity configuration are not stored in the current source XAML.

## Validation

- Validate an edited XAML with `uip rpa validate`.
- Validate the project with `uip rpa build` or `uip rpa get-errors`.
- Do not hand-edit opaque Integration Service `Configuration` blobs; generate those through Studio or the UiPath tooling.
