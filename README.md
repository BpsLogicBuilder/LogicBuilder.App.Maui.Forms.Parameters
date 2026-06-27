# LogicBuilder.App.Maui.Forms.Parameters

[![CI](https://github.com/BpsLogicBuilder/LogicBuilder.App.Maui.Forms.Parameters/actions/workflows/ci.yml/badge.svg)](https://github.com/BpsLogicBuilder/LogicBuilder.App.Maui.Forms.Parameters/actions/workflows/ci.yml)
[![CodeQL](https://github.com/BpsLogicBuilder/LogicBuilder.App.Maui.Forms.Parameters/actions/workflows/github-code-scanning/codeql/badge.svg)](https://github.com/BpsLogicBuilder/LogicBuilder.App.Maui.Forms.Parameters/actions/workflows/github-code-scanning/codeql)
[![codecov](https://codecov.io/github/BpsLogicBuilder/LogicBuilder.App.Maui.Forms.Parameters/graph/badge.svg?token=HNP9ELDBSP)](https://codecov.io/github/BpsLogicBuilder/LogicBuilder.App.Maui.Forms.Parameters)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=BpsLogicBuilder_LogicBuilder.App.Maui.Forms.Parameters&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=BpsLogicBuilder_LogicBuilder.App.Maui.Forms.Parameters)

A .NET Standard 2.0 library that provides parameter classes serving as a contract between the Logic Builder application and .NET MAUI applications.

## Overview

This library defines the configuration parameters that control the functionality, layout, controls, validation, and visibility of screens in .NET MAUI applications built with the Logic Builder framework. These parameter classes enable declarative, metadata-driven UI configuration without requiring manual XAML or code-behind modifications.

## Key Features

- **Form Configuration**: Define data entry forms with validation, field settings, and conditional directives
- **Navigation Parameters**: Configure navigation bars, menus, and routing
- **List & Search Forms**: Set up collection views with filtering, paging, and data binding
- **Text Forms**: Create read-only text displays with formatted content and hyperlinks
- **Data Binding**: Support for single and multi-property bindings to UI controls
- **Validation**: Declarative validation rules and messages for form fields
- **Conditional Directives**: Control field visibility and behavior based on runtime conditions
- **Template Support**: Multiple UI templates for text fields, dropdowns, multi-select controls, and more

## Main Parameter Types

### Form Settings
- **DataFormSettingsParameters**: Configure data entry forms with fields, validation, and CRUD operations
- **ListFormSettingsParameters**: Define list views with item templates and data selectors
- **SearchFormSettingsParameters**: Set up searchable lists with filtering and paging
- **TextFormSettingsParameters**: Create read-only text content displays

### Navigation
- **NavigationBarParameters**: Configure application navigation bars and menu items
- **NavigationMenuItemParameters**: Define individual navigation menu entries

### Controls & Bindings
- **TextItemBindingParameters**: Bind data to text input fields with various templates (date, checkbox, switch, label, hidden)
- **DropDownItemBindingParameters**: Configure dropdown/picker controls
- **MultiSelectItemBindingParameters**: Set up multi-selection controls
- **FormGroupParameters**: Group related fields together with headers

### Validation & Directives
- **ValidationMessageParameters**: Define field-level validation rules
- **ValidationRuleParameters**: Specify individual validation constraints
- **VariableDirectivesParameters**: Control conditional behavior and visibility
- **DirectiveParameters**: Execute conditional logic based on field values

## Usage

These parameters are typically configured within the Logic Builder application and consumed by .NET MAUI applications at runtime to dynamically construct user interfaces without code changes.

Example conceptual usage:
```c#
	var formSettings = new DataFormSettingsParameters
	( 
		title: "Edit User", 
		validationMessages: validationList, 
		fieldSettings: fieldList, 
		formType: FormType.Edit, 
		modelType: typeof(User), 
		requestDetails: new FormRequestDetailsParameters(...) 
	);
```

## Dependencies

- **LogicBuilder.Forms.Parameters**: Horizontal parameter types used across more application types
- **.NET Standard 2.0**: Ensures broad compatibility with .NET Framework, .NET Core, and modern .NET

## License

MIT License - Copyright © BPS 2026

## Related Projects

- [LogicBuilder](https://github.com/BpsLogicBuilder/LogicBuilder) - The main Logic Builder application
- [LogicBuilder.App.Maui.Forms.Parameters](https://github.com/BpsLogicBuilder/LogicBuilder.App.Maui.Forms.Parameters) - This repository

## Package Information

Available as a NuGet package: `LogicBuilder.App.Maui.Forms.Parameters`

For more information, visit the [GitHub repository](https://github.com/BpsLogicBuilder/LogicBuilder.App.Maui.Forms.Parameters).
