# Hello, Test Containers 

This repository is a demonstration of test containers using dotnet. 
Follow along with test containers at 
[the dotnet getting started page](https://testcontainers.com/guides/getting-started-with-testcontainers-for-dotnet/).

Testcontainers is a testing library that provides easy and lightweight APIs for bootstrapping integration tests with real services wrapped in Docker containers. Using Testcontainers, you can write tests that talk to the same type of services you use in production, without mocks or in-memory services.

```
$ cd ~/src/dotnet/hello-testcontainers/; time git pull; time dotnet --info; time dotnet build; time dotnet clean; time dotnet test;
remote: Enumerating objects: 7, done.
remote: Counting objects: 100% (7/7), done.
remote: Compressing objects: 100% (1/1), done.
remote: Total 4 (delta 3), reused 4 (delta 3), pack-reused 0 (from 0)
Unpacking objects: 100% (4/4), 353 bytes | 353.00 KiB/s, done.
From github.com:kusl/hello-testcontainers
   a357f41..8ae0ab3  master     -> origin/master
Updating a357f41..8ae0ab3
Fast-forward
 CustomerService.Tests/CustomerServiceTest.cs | 8 ++------
 1 file changed, 2 insertions(+), 6 deletions(-)

real	0m0.502s
user	0m0.054s
sys	0m0.027s
.NET SDK:
 Version:           9.0.101
 Commit:            eedb237549
 Workload version:  9.0.100-manifests.3068a692
 MSBuild version:   17.12.12+1cce77968

Runtime Environment:
 OS Name:     debian
 OS Version:  12
 OS Platform: Linux
 RID:         linux-x64
 Base Path:   /usr/share/dotnet/sdk/9.0.101/

.NET workloads installed:
There are no installed workloads to display.
Configured to use loose manifests when installing new manifests.

Host:
  Version:      9.0.0
  Architecture: x64
  Commit:       9d5a6a9aa4

.NET SDKs installed:
  9.0.101 [/usr/share/dotnet/sdk]

.NET runtimes installed:
  Microsoft.AspNetCore.App 9.0.0 [/usr/share/dotnet/shared/Microsoft.AspNetCore.App]
  Microsoft.NETCore.App 9.0.0 [/usr/share/dotnet/shared/Microsoft.NETCore.App]

Other architectures found:
  None

Environment variables:
  Not set

global.json file:
  /home/kushal/src/dotnet/hello-testcontainers/global.json

Learn more:
  https://aka.ms/dotnet/info

Download .NET:
  https://aka.ms/dotnet/download

real	0m0.249s
user	0m0.193s
sys	0m0.056s
Restore complete (1.0s)
  CustomerService succeeded (0.4s) → CustomerService/bin/Debug/net9.0/CustomerService.dll
  CustomerService.Tests succeeded (0.2s) → CustomerService.Tests/bin/Debug/net9.0/CustomerService.Tests.dll

Build succeeded in 2.0s

real	0m2.396s
user	0m2.819s
sys	0m0.296s

Build succeeded in 1.0s

real	0m1.467s
user	0m1.957s
sys	0m0.262s
Restore complete (1.0s)
  CustomerService succeeded (0.5s) → CustomerService/bin/Debug/net9.0/CustomerService.dll
  CustomerService.Tests succeeded (0.3s) → CustomerService.Tests/bin/Debug/net9.0/CustomerService.Tests.dll
[xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.8.2+699d445a1a (64-bit .NET 9.0.0)
[xUnit.net 00:00:00.10]   Discovering: CustomerService.Tests
[xUnit.net 00:00:00.15]   Discovered:  CustomerService.Tests
[xUnit.net 00:00:00.15]   Starting:    CustomerService.Tests
[testcontainers.org 00:00:00.15] Connected to Docker:
  Host: unix:///var/run/docker.sock
  Server Version: 20.10.24+dfsg1
  Kernel Version: 6.1.0-28-amd64
  API Version: 1.41
  Operating System: Debian GNU/Linux 12 (bookworm)
  Total Memory: 3.72 GB
[testcontainers.org 00:00:00.36] Docker container 9ee2a64caf93 created
[testcontainers.org 00:00:00.41] Start Docker container 9ee2a64caf93
[testcontainers.org 00:00:00.76] Wait for Docker container 9ee2a64caf93 to complete readiness checks
[testcontainers.org 00:00:00.76] Docker container 9ee2a64caf93 ready
[testcontainers.org 00:00:00.83] Docker container 65a6384a950d created
[testcontainers.org 00:00:00.83] Start Docker container 65a6384a950d
[testcontainers.org 00:00:01.19] Wait for Docker container 65a6384a950d to complete readiness checks
[testcontainers.org 00:00:01.20] Execute "pg_isready --host localhost --dbname postgres --username postgres" at Docker container 65a6384a950d
[testcontainers.org 00:00:02.35] Execute "pg_isready --host localhost --dbname postgres --username postgres" at Docker container 65a6384a950d
[testcontainers.org 00:00:03.45] Execute "pg_isready --host localhost --dbname postgres --username postgres" at Docker container 65a6384a950d
[testcontainers.org 00:00:03.54] Docker container 65a6384a950d ready
[testcontainers.org 00:00:03.81] Delete Docker container 65a6384a950d
[xUnit.net 00:00:04.63]   Finished:    CustomerService.Tests
  CustomerService.Tests test succeeded (5.6s)

Test summary: total: 1, failed: 0, succeeded: 1, skipped: 0, duration: 5.6s
Build succeeded in 7.9s

real	0m8.237s
user	0m3.563s
sys	0m0.351s
```