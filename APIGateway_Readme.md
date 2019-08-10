# API Gateway Requirements

### 1. Directing Requests to the Authentication Service

If a user has not been Authenticated
### 2. Requests aggregation:
####   As part of the gateway pattern you can aggregate multiple client requests (usually Http requests) targeting multiple internal microservices into a single client request. 


#### Multiple API Gateways
I started with building a simple API Gateway project in .NET Core.

This gateway would be the first place a request would stop to
1. Get authenticated
2. Get directed to the View for the User Portal

```C#
services.AddTokenJwtAuthorize();
```

# A collapsible section with markdown
<details>
  <summary>Click to expand!</summary>
  
  ## Heading
  1. A numbered
  2. list
     * With some
     * Sub bullets
</details>