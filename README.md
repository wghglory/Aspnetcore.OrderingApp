# Asp.net Core Razor

## .Net 读取本地 json 文件

Services/JsonFormDataService.cs

```csharp
_srcJson = JsonConvert.DeserializeObject<DropDownData>(File.ReadAllText("data.json"));
```