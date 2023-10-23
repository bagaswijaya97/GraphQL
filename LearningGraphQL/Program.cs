using LearningGraphQL.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer().AddQueryType<EducationService>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
	endpoints.MapGraphQL();
});

app.MapGet("/", () => "Halo, Aku lagi belajar Integrasi GrphQL menggunakan Framework .NetCore 7 nih.\n\nUntuk demo nya tambahkan '/GraphQL' pada URL diatas tanpa tanda petik yaa.\n\nTerima Kasih :)");

app.Run();
