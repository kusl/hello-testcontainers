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

on fedora, 

```bash
kushal@kusfedora2024:~$ cd ~/src/dotnet/hello-testcontainers/; time dotnet build; time dotnet clean; time dotnet test;
Restore complete (0.6s)
  CustomerService succeeded (0.2s) → CustomerService/bin/Debug/net9.0/CustomerService.dll
  CustomerService.Tests succeeded (0.2s) → CustomerService.Tests/bin/Debug/net9.0/CustomerService.Tests.dll

Build succeeded in 1.2s

real	0m1.402s
user	0m0.898s
sys	0m0.186s

Build succeeded in 0.4s

real	0m0.544s
user	0m0.523s
sys	0m0.101s
Restore complete (0.4s)
  CustomerService succeeded (1.7s) → CustomerService/bin/Debug/net9.0/CustomerService.dll
  CustomerService.Tests succeeded (0.3s) → CustomerService.Tests/bin/Debug/net9.0/CustomerService.Tests.dll
[xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.8.2+699d445a1a (64-bit .NET 9.0.0)
[xUnit.net 00:00:00.05]   Discovering: CustomerService.Tests
[xUnit.net 00:00:00.07]   Discovered:  CustomerService.Tests
[xUnit.net 00:00:00.08]   Starting:    CustomerService.Tests
[testcontainers.org 00:00:00.05] Connected to Docker:
  Host: unix:///var/run/docker.sock
  Server Version: 27.3.1
  Kernel Version: 6.11.10-300.fc41.x86_64
  API Version: 1.47
  Operating System: Fedora Linux 41 (Workstation Edition)
  Total Memory: 62.71 GB
[testcontainers.org 00:00:00.26] Docker container 41630ab3720f created
[testcontainers.org 00:00:00.29] Start Docker container 41630ab3720f
[testcontainers.org 00:00:00.61] Wait for Docker container 41630ab3720f to complete readiness checks
[testcontainers.org 00:00:00.61] Docker container 41630ab3720f ready
[xUnit.net 00:01:00.84]     CustomerService.Tests.CustomerServiceTest.ShouldReturnTwoCustomers [FAIL]
[xUnit.net 00:01:00.84]       DotNet.Testcontainers.Containers.ResourceReaperException : Initialization has been cancelled.
[xUnit.net 00:01:00.84]       Stack Trace:
[xUnit.net 00:01:00.84]         /_/src/Testcontainers/Containers/ResourceReaper.cs(236,0): at DotNet.Testcontainers.Containers.ResourceReaper.GetAndStartNewAsync(Guid sessionId, IDockerEndpointAuthenticationConfiguration dockerEndpointAuthConfig, IImage resourceReaperImage, IMount dockerSocket, ILogger logger, Boolean requiresPrivilegedMode, TimeSpan initTimeout, CancellationToken ct)
[xUnit.net 00:01:00.84]         /_/src/Testcontainers/Containers/ResourceReaper.cs(248,0): at DotNet.Testcontainers.Containers.ResourceReaper.GetAndStartNewAsync(Guid sessionId, IDockerEndpointAuthenticationConfiguration dockerEndpointAuthConfig, IImage resourceReaperImage, IMount dockerSocket, ILogger logger, Boolean requiresPrivilegedMode, TimeSpan initTimeout, CancellationToken ct)
[xUnit.net 00:01:00.84]         /_/src/Testcontainers/Containers/ResourceReaper.cs(135,0): at DotNet.Testcontainers.Containers.ResourceReaper.GetAndStartDefaultAsync(IDockerEndpointAuthenticationConfiguration dockerEndpointAuthConfig, ILogger logger, Boolean isWindowsEngineEnabled, CancellationToken ct)
[xUnit.net 00:01:00.84]         /_/src/Testcontainers/Clients/TestcontainersClient.cs(297,0): at DotNet.Testcontainers.Clients.TestcontainersClient.RunAsync(IContainerConfiguration configuration, CancellationToken ct)
[xUnit.net 00:01:00.84]         /_/src/Testcontainers/Containers/DockerContainer.cs(416,0): at DotNet.Testcontainers.Containers.DockerContainer.UnsafeCreateAsync(CancellationToken ct)
[xUnit.net 00:01:00.84]         /_/src/Testcontainers/Containers/DockerContainer.cs(280,0): at DotNet.Testcontainers.Containers.DockerContainer.StartAsync(CancellationToken ct)
[xUnit.net 00:01:00.85]   Finished:    CustomerService.Tests
  CustomerService.Tests test failed with 1 error(s) (61.4s)
    /_/src/Testcontainers/Containers/ResourceReaper.cs(236): error TESTERROR: 
      CustomerService.Tests.CustomerServiceTest.ShouldReturnTwoCustomers (1ms): Error Message: DotNet.Testcontainers.Containers.ResourceReaperException : Initialization has been cancelled.
      Stack Trace:
         at DotNet.Testcontainers.Containers.ResourceReaper.GetAndStartNewAsync(Guid sessionId, IDockerEndpointAuthenticationConfiguration dockerEndpointAuthConfig, IImage resourceReaperImage, IMount dockerSocket, ILogger logger, Boolean requiresPrivilegedMode, TimeSpan initTimeout, CancellationToken ct) in /_/src/Testcontainers/Containers/ResourceReaper.cs:line 236
         at DotNet.Testcontainers.Containers.ResourceReaper.GetAndStartNewAsync(Guid sessionId, IDockerEndpointAuthenticationConfiguration dockerEndpointAuthConfig, IImage resourceReaperImage, IMount dockerSocket, ILogger logger, Boolean requiresPrivilegedMode, TimeSpan initTimeout, CancellationToken ct) in /_/src/Testcontainers/Containers/ResourceReaper.cs:line 248
         at DotNet.Testcontainers.Containers.ResourceReaper.GetAndStartDefaultAsync(IDockerEndpointAuthenticationConfiguration dockerEndpointAuthConfig, ILogger logger, Boolean isWindowsEngineEnabled, CancellationToken ct) in /_/src/Testcontainers/Containers/ResourceReaper.cs:line 135
         at DotNet.Testcontainers.Clients.TestcontainersClient.RunAsync(IContainerConfiguration configuration, CancellationToken ct) in /_/src/Testcontainers/Clients/TestcontainersClient.cs:line 297
         at DotNet.Testcontainers.Containers.DockerContainer.UnsafeCreateAsync(CancellationToken ct) in /_/src/Testcontainers/Containers/DockerContainer.cs:line 416
         at DotNet.Testcontainers.Containers.DockerContainer.StartAsync(CancellationToken ct) in /_/src/Testcontainers/Containers/DockerContainer.cs:line 280

Test summary: total: 1, failed: 1, succeeded: 0, skipped: 0, duration: 61.3s
Build failed with 1 error(s) in 63.9s

real	1m4.048s
user	0m1.562s
sys	0m0.216s
kushal@kusfedora2024:~/src/dotnet/hello-testcontainers$ cd ~/src/dotnet/; time git clone git@github.com:testcontainers/testcontainers-dotnet.git
Cloning into 'testcontainers-dotnet'...
remote: Enumerating objects: 13572, done.
remote: Counting objects: 100% (598/598), done.
remote: Compressing objects: 100% (414/414), done.
remote: Total 13572 (delta 304), reused 331 (delta 175), pack-reused 12974 (from 1)
Receiving objects: 100% (13572/13572), 4.96 MiB | 9.68 MiB/s, done.
Resolving deltas: 100% (9892/9892), done.

real	0m1.221s
user	0m0.196s
sys	0m0.113s
kushal@kusfedora2024:~/src/dotnet$ export TESTCONTAINERS_RYUK_CONTAINER_PRIVILEGED=true; cd ~/src/dotnet/hello-testcontainers/; time dotnet build; time dotnet clean; time dotnet test;
Restore complete (0.4s)
  CustomerService succeeded (0.1s) → CustomerService/bin/Debug/net9.0/CustomerService.dll
  CustomerService.Tests succeeded (0.0s) → CustomerService.Tests/bin/Debug/net9.0/CustomerService.Tests.dll

Build succeeded in 0.8s

real	0m0.899s
user	0m0.839s
sys	0m0.163s

Build succeeded in 0.4s

real	0m0.550s
user	0m0.529s
sys	0m0.106s
Restore complete (0.4s)
  CustomerService succeeded (1.6s) → CustomerService/bin/Debug/net9.0/CustomerService.dll
  CustomerService.Tests succeeded (0.2s) → CustomerService.Tests/bin/Debug/net9.0/CustomerService.Tests.dll
[xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.8.2+699d445a1a (64-bit .NET 9.0.0)
[xUnit.net 00:00:00.05]   Discovering: CustomerService.Tests
[xUnit.net 00:00:00.07]   Discovered:  CustomerService.Tests
[xUnit.net 00:00:00.08]   Starting:    CustomerService.Tests
[testcontainers.org 00:00:00.05] Connected to Docker:
  Host: unix:///var/run/docker.sock
  Server Version: 27.3.1
  Kernel Version: 6.11.10-300.fc41.x86_64
  API Version: 1.47
  Operating System: Fedora Linux 41 (Workstation Edition)
  Total Memory: 62.71 GB
[testcontainers.org 00:00:00.23] Docker container afa5676133f3 created
[testcontainers.org 00:00:00.26] Start Docker container afa5676133f3
[testcontainers.org 00:00:00.58] Wait for Docker container afa5676133f3 to complete readiness checks
[testcontainers.org 00:00:00.58] Docker container afa5676133f3 ready
[testcontainers.org 00:00:00.60] Searching Docker registry credential in CredsStore
[testcontainers.org 00:00:00.60] Searching Docker registry credential in CredHelpers
[testcontainers.org 00:00:00.60] Searching Docker registry credential in Auths
[testcontainers.org 00:00:00.60] Searching Docker registry credential in Auths
[testcontainers.org 00:00:00.61] Docker registry credential https://index.docker.io/v1/ found
[testcontainers.org 00:00:05.92] Docker image postgres:15-alpine created
[testcontainers.org 00:00:06.35] Docker container cfcf5bc69082 created
[testcontainers.org 00:00:06.36] Start Docker container cfcf5bc69082
[testcontainers.org 00:00:06.66] Wait for Docker container cfcf5bc69082 to complete readiness checks
[testcontainers.org 00:00:06.66] Execute "pg_isready --host localhost --dbname postgres --username postgres" at Docker container cfcf5bc69082
[testcontainers.org 00:00:07.72] Execute "pg_isready --host localhost --dbname postgres --username postgres" at Docker container cfcf5bc69082
[testcontainers.org 00:00:08.76] Execute "pg_isready --host localhost --dbname postgres --username postgres" at Docker container cfcf5bc69082
[testcontainers.org 00:00:09.79] Execute "pg_isready --host localhost --dbname postgres --username postgres" at Docker container cfcf5bc69082
[testcontainers.org 00:00:10.84] Execute "pg_isready --host localhost --dbname postgres --username postgres" at Docker container cfcf5bc69082
[testcontainers.org 00:00:11.87] Execute "pg_isready --host localhost --dbname postgres --username postgres" at Docker container cfcf5bc69082
[testcontainers.org 00:00:12.92] Execute "pg_isready --host localhost --dbname postgres --username postgres" at Docker container cfcf5bc69082
[testcontainers.org 00:00:13.95] Execute "pg_isready --host localhost --dbname postgres --username postgres" at Docker container cfcf5bc69082
[testcontainers.org 00:00:14.01] Docker container cfcf5bc69082 ready
[testcontainers.org 00:00:14.15] Delete Docker container cfcf5bc69082
[xUnit.net 00:00:14.72]   Finished:    CustomerService.Tests
  CustomerService.Tests test succeeded (15.2s)

Test summary: total: 1, failed: 0, succeeded: 1, skipped: 0, duration: 15.2s
Build succeeded in 17.6s

real	0m17.762s
user	0m1.535s
sys	0m0.196s
```