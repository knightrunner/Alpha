C:\dev\Knightrunner\GreatLibrary\DataSchema\bin\Debug\DataSchema.exe %1UserAccountingData.xml /scriptTarget:MSSQL /scriptOut:%1Autogenerated\UserAccountingData.sql /codeTarget:DotNet /codeOut:%1Autogenerated\UserAccountingData.dbml
"C:\Program Files\Microsoft SDKs\Windows\v6.0A\Bin\x64\SqlMetal.exe" /namespace:Knightrunner.Library.UserAccounting /code:%1Autogenerated\UserAccountingData.cs /language:csharp %1Autogenerated\UserAccountingData.dbml
del %1Autogenerated\UserAccountingData.dbml