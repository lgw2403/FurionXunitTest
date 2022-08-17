Serve.Run(RunOptions.Default);

//var builder = WebApplication.CreateBuilder(args).Inject();

//// Add services to the container.

//var env = App.HostEnvironment;
//string environmentName = env.EnvironmentName;

//builder.Services.AddFileLogging(options =>
//{
//    options.FileNameRule = fileName =>
//    {
//        return string.Format(fileName, DateTime.Now);
//    };
//});
//builder.Services.AddFileLogging("logs/error/error-{0:yyyy}-{0:MM}-{0:dd}.log", options =>
//{
//    options.FileNameRule = fileName =>
//    {
//        return string.Format(fileName, DateTime.Now);
//    };
//    options.WriteFilter = (logMsg) =>
//    {
//        return logMsg.LogLevel == LogLevel.Error;
//    };
//});

//builder.Services.AddControllers().AddInject();

//var app = builder.Build();

//app.UseUnifyResultStatusCodes();

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.UseInject();

//app.MapControllers();

//app.Run();

public partial class Program { }