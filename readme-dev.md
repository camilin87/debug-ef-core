# Development  

Documentation for developers working on the project.  

## Deployment  

[Docs](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-visual-studio)  

### Step 1: Package project  

```bash
PROJECT_FILE=DebugEFCore.csproj && \
  rm -f bin/Release/*.nupkg && \
  dotnet clean $PROJECT_FILE -c Release && \
  dotnet build $PROJECT_FILE -c Release && \
  dotnet pack $PROJECT_FILE -c Release
```

### Step 2: Publish nuget  

```bash
dotnet nuget push bin/Release/DebugEFCore.*.nupkg \
  -k `sudo security find-generic-password -w -gs NUGET_PUSH_KEY` \
  -s https://api.nuget.org/v3/index.json
```

*The above command assumes there's a `NUGET_PUSH_KEY` stored in the Keychain*  
