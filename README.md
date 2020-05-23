# ASP.Net WebApi2 Application with OWIN

Repository contains ready to use preconfigured project to create fully functional production ready RESTful services.

> Note! If you are looking for a .Net Core project template, please, check out the project [ASP.Net Core RESTful Service Project Template](https://github.com/drwatson1/AspNet-Core-REST-Service).

The template uses the 4.7.1 version of .Net Framework. Make sure that you have it installed before use the template.

**Contains**

- CORS enabled
- preconfigured HTTP OPTIONS handler
- Cache-Control header preconfigured
- Autofac as a DI-container
- Content formatter configured to use Json.Net
- AutoMapper
- Unhandled exceptions handler
- Unhandled exceptions logger
- Serilog as a default logger preconfigured to save logs to %AppData%/Logs folder
- Swagger for API documentation
- JWT-Bearer authentication to protect your API with IdentityModel
- Ability to use environment variables in configuration options (web.config)
- Support .env files to easy switching between different environments (DotNetEnv)
- ... and some other boilerplate code

**Getting Started**

1. Install the extension from the [Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=sergey-tregub.asp-net-web-api-owin-template) or download and install the latest version from the [GitHub](https://github.com/drwatson1/AspNet-WebApi/releases). Also, you can install it from Visual Studio. To do so click on "Tools/Extensions and Updates..." menu item, then select "Online/Visual Studio Marketplace/Templates" on the left pane, search for "ASP.Net WebAPI Application Project Template," select it and click "Download" button.
1. Restart Visual Studio
1. Click on "File/New Project..." menu item
1. Type "webapi" on the right pane
1. Select "APS.Net WebAPI Application With OWIN" and click OK button.
1. Run the service
1. Open a browser and navigate to http://localhost:5000/swagger/ui/index to see API documentation
1. Play around with the API

Visit project [Wiki pages](https://github.com/drwatson1/AspNet-WebApi/wiki) to learn more about the template.

Any suggestions and bug reports are very appeciated.
