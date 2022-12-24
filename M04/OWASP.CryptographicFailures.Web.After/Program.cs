var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    //app.UseHsts();
}

app.UseHsts(opt => opt.MaxAge(365)
    .IncludeSubdomains());
app.UseXContentTypeOptions();
app.UseXXssProtection(opt => opt.EnabledWithBlockMode());
app.UseXfo(opt => opt.SameOrigin());
app.UseReferrerPolicy(opt => opt.NoReferrer());
app.UseCsp(opt => opt
    .DefaultSources(source => source.Self())
    .StyleSources(source => source.Self()
        .UnsafeInline())
    .ScriptSources(source => source.Self()
        .UnsafeInline()
        .UnsafeEval())
);

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();