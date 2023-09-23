<svg fill="none" width="100%" height="600" xmlns="http://www.w3.org/2000/svg">
  <foreignObject width="100%" height="100%">
    <div id="heading" xmlns="http://www.w3.org/1999/xhtml">
      <style>
        .flex-container{display: flex; align-items: center; justify-content: center;}
        .left-logo{border-radius: 50%;overflow: hidden;display: flex;border: 3px solid #0d4399;padding: 0;margin: 0;flex-direction: column;width: 120px;}
        .right-logo{border-radius: 50%;overflow: hidden;display: flex;border: 3px solid #0d4399;padding: 0;margin: 0;flex-direction: column;width: 120px;margin-left: -10px;}
        #heading{
          height:600px;
          background: linear-gradient(159deg,#15f9ad 14.05%,#0d4399 100%);
          padding:20px 0;
          display:flex;
          flex-direction:column;
          justify-content:center;
        }
        .text-white{color:#f8f9fa !important;}
        #shields{
          width:100%;
          height:50px;
          margin-top:-30px;
          text-align:center;
        }
      </style>
      <div class="flex-container">
        <a href="https://cord.com/" class="left-logo">
          <img src="src/Cord.SDK/cord.png">
        </a>
        <a href="https://dealforward.com/" class="right-logo">
          <img src="https://prod-simpliciter-io.s3.eu-central-1.amazonaws.com/API%20Uploads/4fdd9646-f10e-4cdd-9ee9-004278f6da49/Frame_1_1_efcd76af2c.png">
        </a>
      </div>
       <h1 align="center" class="text-white">Cord .NET SDK</h1>
        <p align="center" class="text-white">Toolkit for the Cord.</p>
    </div>
    <div id="shields">
      <img src="https://img.shields.io/nuget/dt/Cord.SDK"/>
      <img src="https://img.shields.io/github/contributors/simpliciterio/cord.net.sdk?color=dark-green"/>
      <img src="https://img.shields.io/github/issues/simpliciterio/cord.net.sdk"/>
      <img src="https://img.shields.io/github/license/simpliciterio/cord.net.sdk"/>
      <img src="https://img.shields.io/nuget/vpre/Cord.SDK"/>
    </div>
  </foreignObject>
</svg>


## About The Project

It is a Software Development Kit project for the .NET platform where you can interact with [Cord](https://cord.com/). It aims to be able to use REST ends on Cord and execute authentication processes.

## Getting Started

To start using it, include it in your project using the .NET CLI or Package Manager.

### Installation

#### .NET CLI

```sh
dotnet add package Cord.SDK
```

#### Package Manager

```sh
NuGet\Install-Package Cord.SDK
```

### Configuration

NET project, you can make SDK related configurations as in the example below.

```csharp
builder.Services.AddCordSdk(opt =>
{
    opt.ApplicationId = "ID";
    opt.Secret = "SECRET";
});
```

| Property              | Type     | Description                                                                                               | Required | Default |
| --------------------- | -------- | --------------------------------------------------------------------------------------------------------- | -------- | ------- |
| ApplicationId         | `string` | Application id for Rest API access                                                                        | ✅       |         |
| Secret                | `string` | Secret key for Rest API access                                                                            | ✅       |         |
| ClientTokenExpiration | `int`    | Specifies the expiration time in minutes of the token required for users to connect to Cord.              | ❌       | `60`    |
| ServerTokenExpiration | `int`    | Specifies the expiration time in minutes of the token to be used by the server in Rest API communication. | ❌       | `1440`  |

---

## Usage

To access Cord services, inject the ICord interface into your method or class.

```csharp
async Task MyMethod([FromServices] ICord cord)
{
  cord.Users.V1.*****
}
```

```csharp
public class MyClass
{
  private readonly ICord _cord;

  public MyClass(ICord cord) => _cord = cord;

  public async Task MyMethod()
  {
      _cord.Organizations.V1.*****
  }
}
```

**All methods of services for the Rest API have implemented CancellationToken.**

<!--
### Table Of Contents

- **[Organizations | V1](#organizations--v1)**
  - [Create Or Update](#organization--create-or-update)
  - [List](#organization--list)
  - [Get](#organization--get)
  - [Update Members](#organization--update-members)


### Organizations | V1

Services you can use to manage organizations on Cord

#### Organization | Create or Update

This method creates or updates an organization:

- If the organization does not exist in the Cord backend (based on its ID), it will be created; some fields are required.
- if the organization exists, it will be updated: all fields are optional, only the fields provided will be updated; if the request is updating the members list, the list is treated as exhaustive: all member user IDs must be included, previous members who are not in the list will be removed.

```csharp
CordResponse response = await cord.Organizations.V1.CreateOrUpdate("my_id", new OrganizationPutItem("My Organization Name"), CancellationToken.None);
```

#### Organization | List

Use this method to list all organizations that you have created within your Cord application.

```csharp
IEnumerable<OrganizationListItem> list = await cord.Organizations.V1.List(CancellationToken.None);
```

#### Organization | Get

Detailed information of the related organization according to the organization id value sent.

```csharp
OrganizationGetItem item = await cord.Organization.V1.Get("my_id", CancellationToken.None);
```

#### Organization | Update Members

It is used to add or remove users to the organization in bulk. -->
