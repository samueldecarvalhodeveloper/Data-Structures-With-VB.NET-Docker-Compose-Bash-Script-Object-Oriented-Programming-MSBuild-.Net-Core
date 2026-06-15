#syntax=docker/dockerfile:1

FROM mcr.microsoft.com/dotnet/sdk:9.0

WORKDIR /src/app/

COPY ./Program.vb /src/app/Program.vb
COPY ./DataStructures.vbproj /src/app/DataStructures.vbproj
COPY ./DataStructures.sln /src/app/DataStructures.sln
COPY ./Src/ /src/app/Src/

RUN dotnet publish -c Release -o /src/app/publish/

CMD dotnet /src/app/publish/DataStructures.dll
