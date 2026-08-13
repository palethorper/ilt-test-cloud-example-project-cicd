# Application Testing ILT agent guidance

<!-- PROJECT-CONTEXT:START -->
- This is a UiPath Windows test-automation project using Visual Basic expressions.
- Keep training assets grouped under their existing numbered topic folders.
- Register new test cases in `project.json` with a new lowercase GUID.
- Store file-backed test data under `.variations` and register it in `.variations\config.json`.
- For Integration Service activities, preserve or generate the complete opaque `Configuration` value; never invent or partially reconstruct it.
- After changing XAML, validate the file and then validate/build the whole project.
- Project details are documented in `.claude\rules\project-context.md`.
<!-- PROJECT-CONTEXT:END -->
