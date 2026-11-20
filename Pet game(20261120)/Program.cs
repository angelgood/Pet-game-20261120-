var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles(); // 告訴網站預設首頁是 index.html
app.UseStaticFiles();  // 允許顯示 wwwroot 裡的網頁

app.Run();