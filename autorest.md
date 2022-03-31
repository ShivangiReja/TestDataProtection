# DataProtection

> see https://aka.ms/autorest

This is the AutoRest configuration file for DataProtection.

---

## Getting Started

To build the SDK for DataProtection, simply [Install AutoRest](https://aka.ms/autorest/install) and in this folder, run:

> `autorest`

To see additional help and options, run:

> `autorest --help`

---

## Configuration

### Basic Information

These are the global settings for the DataProtection API.

``` yaml
title: Data Protection Plugin
description: Open API 2.0 Specs for Azure Data Protection service
openapi-type: data-plane
tag: package-2022-03
use-internal-constructors: true
license-header: MICROSOFT_MIT
```

### Validations

Run validations when `--validate` is specified on command line

``` yaml $(validate)
azure-validator: true
model-validator: true
semantic-validator: true
message-format: json
```

### Tag: package-2022-03

These settings apply only when `--tag=package-2022-03` is specified on the command line.

``` yaml $(tag) == 'package-2022-03'
input-file: $(this-folder)/ServerReview.json
```
---

## C#

These settings apply only when `--csharp` is specified on the command line.
Please also specify `--csharp-sdks-folder=<path to "SDKs" directory of your azure-sdk-for-net clone>`.

``` yaml $(csharp)
csharp:
  azure-arm: false
  payload-flattening-threshold: 1
  license-header: MICROSOFT_MIT_NO_VERSION
  namespace: Microsoft.DataProtection.DatasourcePlugin
  output-folder: C:/Users/shreja/source/repos/TestDataProtection/Generated
  clear-output-folder: true
```