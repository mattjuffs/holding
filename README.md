# Holding

> A simple .NET Core Razor Page for pointing domains to

You can see it in use on the following domains:

* http://dustyspider.co.uk
* http://juffs.co.uk
* http://juffs.uk

---

## How does it work?

`Index.cshtml` determines the domain from the request and exposes it as a Property of the Model.

The HTML & CSS has been adapted from https://github.com/mattjuffs/framework `error.html`.

---

## Troubleshooting

If hosting in **IIS 8.5** on **Server 2016**, you may come across the following error:

> HTTP Error 500.30 - ANCM In-Process Start Failure

Amend the `web.config` - change this line:

```
<aspNetCore processPath=".\Holding.exe" stdoutLogEnabled="true" stdoutLogFile=".\logs\stdout" hostingModel="inprocess" />
```

To the following:

```
<aspNetCore processPath=".\Holding.exe" stdoutLogEnabled="true" stdoutLogFile=".\logs\stdout" hostingModel="outofprocess" />
```

Thanks to: https://stackoverflow.com/questions/53811569/http-error-500-30-ancm-in-process-start-failure